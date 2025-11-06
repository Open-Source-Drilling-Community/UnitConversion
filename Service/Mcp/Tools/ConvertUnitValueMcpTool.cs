using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.DotnetLibraries.General.DataManagement;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Model;
using OSDC.UnitConversion.Service.Controllers;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class ConvertUnitValueMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<ConvertUnitValueMcpTool> _logger;

    private static readonly JsonObject Schema = new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["physicalQuantity"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Name or synonym of the physical quantity to convert."
            },
            ["unitIn"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Name or label of the unit to convert from."
            },
            ["unitOut"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Name or label of the unit to convert to."
            },
            ["value"] = new JsonObject
            {
                ["type"] = "number",
                ["description"] = "Numeric value to convert."
            }
        },
        ["required"] = new JsonArray { "physicalQuantity", "unitIn", "unitOut", "value" },
        ["additionalProperties"] = false
    };

    public ConvertUnitValueMcpTool(IServiceProvider serviceProvider, ILogger<ConvertUnitValueMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "convert_unit_value";

    public string Description => "Converts a value between two unit choices by creating a temporary UnitConversionSet.";

    public JsonNode? InputSchema => Schema;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (!TryGetRequiredString(arguments, "physicalQuantity", out var physicalQuantityNameRaw, out var validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryGetRequiredString(arguments, "unitIn", out var unitNameInRaw, out validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryGetRequiredString(arguments, "unitOut", out var unitNameOutRaw, out validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryGetRequiredDouble(arguments, "value", out var value, out validationError))
        {
            return Task.FromResult(validationError);
        }

        var physicalQuantityName = physicalQuantityNameRaw!;
        var unitNameIn = unitNameInRaw!;
        var unitNameOut = unitNameOutRaw!;

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var pqController = ActivatorUtilities.CreateInstance<PhysicalQuantityController>(scope.ServiceProvider);
            var conversionSetController = ActivatorUtilities.CreateInstance<UnitConversionSetController>(scope.ServiceProvider);

            var physicalQuantity = FindPhysicalQuantity(pqController, physicalQuantityName);
            if (physicalQuantity is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"No physical quantity matched '{physicalQuantityName}'."));
            }

            if (physicalQuantity.UnitChoices is null || physicalQuantity.UnitChoices.Count == 0)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, $"Physical quantity '{physicalQuantity.Name}' has no unit choices available."));
            }

            var unitChoiceIn = FindUnitChoice(physicalQuantity.UnitChoices, unitNameIn);
            if (unitChoiceIn is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"No unit choice matched '{unitNameIn}' for physical quantity '{physicalQuantity.Name}'."));
            }

            var unitChoiceOut = FindUnitChoice(physicalQuantity.UnitChoices, unitNameOut);
            if (unitChoiceOut is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"No unit choice matched '{unitNameOut}' for physical quantity '{physicalQuantity.Name}'."));
            }

            var conversionSetId = Guid.NewGuid();
            var quantityConversion = new QuantityUnitConversion
            {
                QuantityID = physicalQuantity.ID,
                UnitChoiceIDIn = unitChoiceIn.ID,
                UnitChoiceIDOut = unitChoiceOut.ID,
                ValueConversionList = new List<ValueConversion>
                {
                    new ValueConversion { DataIn = value }
                }
            };

            var conversionSet = new UnitConversionSet
            {
                MetaInfo = new MetaInfo
                {
                    ID = conversionSetId
                },
                QuantityUnitConversionList = new List<QuantityUnitConversion> { quantityConversion }
            };

            var postResult = conversionSetController.PostUnitConversionSet(conversionSet);
            if (postResult is ObjectResult objectResultPost && (objectResultPost.StatusCode ?? StatusCodes.Status200OK) >= StatusCodes.Status400BadRequest)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(objectResultPost.StatusCode ?? StatusCodes.Status500InternalServerError, "Failed to create unit conversion set."));
            }

            if (postResult is StatusCodeResult codeResultPost && codeResultPost.StatusCode >= StatusCodes.Status400BadRequest)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(codeResultPost.StatusCode, "Failed to create unit conversion set."));
            }

            try
            {
                var getResult = conversionSetController.GetUnitConversionSetById(conversionSetId);
                var persistedConversionSet = getResult.Value ?? (getResult.Result as ObjectResult)?.Value as UnitConversionSet;
                if (persistedConversionSet?.QuantityUnitConversionList is null ||
                    persistedConversionSet.QuantityUnitConversionList.Count == 0)
                {
                    return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "Unit conversion set did not return any conversion result."));
                }

                var persistedQuantityConversion = persistedConversionSet.QuantityUnitConversionList[0];
                if (persistedQuantityConversion.ValueConversionList is null || persistedQuantityConversion.ValueConversionList.Count == 0)
                {
                    return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "Unit conversion set did not compute any values."));
                }

                var persistedValue = persistedQuantityConversion.ValueConversionList[0];

                var payload = new JsonObject
                {
                    ["physicalQuantity"] = physicalQuantity.Name,
                    ["quantityId"] = physicalQuantity.ID.ToString(),
                    ["input"] = new JsonObject
                    {
                        ["value"] = value,
                        ["unitName"] = unitChoiceIn.UnitName,
                        ["unitLabel"] = unitChoiceIn.UnitLabel,
                        ["unitId"] = unitChoiceIn.ID.ToString()
                    },
                    ["output"] = new JsonObject
                    {
                        ["value"] = persistedValue.DataOut,
                        ["formattedValue"] = persistedValue.DataOutString,
                        ["unitName"] = unitChoiceOut.UnitName,
                        ["unitLabel"] = unitChoiceOut.UnitLabel,
                        ["unitId"] = unitChoiceOut.ID.ToString()
                    }
                };

                return Task.FromResult<JsonNode?>(payload);
            }
            finally
            {
                var deleteResult = conversionSetController.DeleteUnitConversionSetById(conversionSetId);
                if (deleteResult is ObjectResult objectResultDelete && (objectResultDelete.StatusCode ?? StatusCodes.Status200OK) >= StatusCodes.Status400BadRequest)
                {
                    _logger.LogWarning("Failed to delete temporary unit conversion set {ConversionSetId}: {StatusCode}", conversionSetId, objectResultDelete.StatusCode);
                }
                else if (deleteResult is StatusCodeResult codeResultDelete && codeResultDelete.StatusCode >= StatusCodes.Status400BadRequest)
                {
                    _logger.LogWarning("Failed to delete temporary unit conversion set {ConversionSetId}: {StatusCode}", conversionSetId, codeResultDelete.StatusCode);
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while performing the unit conversion."));
        }
    }

    private static bool TryGetRequiredString(JsonObject? arguments, string key, out string? value, out JsonNode? error)
    {
        value = null;
        error = null;

        if (arguments?[key] is not JsonValue jsonValue)
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' is required.");
            return false;
        }

        value = jsonValue.GetValue<string?>();
        if (string.IsNullOrWhiteSpace(value))
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' must be a non-empty string.");
            return false;
        }

        return true;
    }

    private static bool TryGetRequiredDouble(JsonObject? arguments, string key, out double value, out JsonNode? error)
    {
        value = 0d;
        error = null;

        if (arguments?[key] is not JsonValue jsonValue)
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' is required.");
            return false;
        }

        try
        {
            value = jsonValue.GetValue<double>();
        }
        catch (Exception)
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' must be a number.");
            return false;
        }

        if (double.IsNaN(value) || double.IsInfinity(value))
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' must be a finite number.");
            return false;
        }

        return true;
    }

    private static BasePhysicalQuantity? FindPhysicalQuantity(
        PhysicalQuantityController controller,
        string rawName)
    {
        var actionResult = controller.GetAllPhysicalQuantity();
        IEnumerable<BasePhysicalQuantity>? quantities = actionResult.Value switch
        {
            IEnumerable<BasePhysicalQuantity> baseValues => baseValues,
            _ => null
        };

        if (quantities is null && actionResult.Result is ObjectResult objectResult)
        {
            quantities = objectResult.Value switch
            {
                IEnumerable<BasePhysicalQuantity> baseValues => baseValues,
                _ => null
            };
        }

        if (quantities is null)
        {
            return null;
        }

        var candidates = quantities
            .Select(q => BasePhysicalQuantity.GetQuantity(q.ID) ?? (q as BasePhysicalQuantity))
            .OfType<BasePhysicalQuantity>();

        var searchToken = Normalize(rawName);
        var bestScore = 0;
        BasePhysicalQuantity? best = null;
        string? bestLabel = null;

        foreach (var quantity in candidates)
        {
            if (quantity.ID == Guid.Empty)
            {
                continue;
            }

            EvaluateCandidate(quantity.Name, quantity, searchToken, ref bestScore, ref best, ref bestLabel, 3);

            if (quantity.UsualNames is { Count: > 0 })
            {
                foreach (var synonym in quantity.UsualNames)
                {
                    EvaluateCandidate(synonym, quantity, searchToken, ref bestScore, ref best, ref bestLabel, 2);
                }
            }
        }

        return best;
    }

    private static UnitChoice? FindUnitChoice(IEnumerable<UnitChoice> unitChoices, string rawName)
    {
        var searchToken = Normalize(rawName);
        var bestScore = 0;
        UnitChoice? best = null;
        string? bestLabel = null;

        foreach (var unitChoice in unitChoices)
        {
            if (unitChoice.ID == Guid.Empty)
            {
                continue;
            }

            EvaluateCandidate(unitChoice.UnitName, unitChoice, searchToken, ref bestScore, ref best, ref bestLabel, 3);
            EvaluateCandidate(unitChoice.UnitLabel, unitChoice, searchToken, ref bestScore, ref best, ref bestLabel, 2);
            EvaluateCandidate(unitChoice.SIUnitName, unitChoice, searchToken, ref bestScore, ref best, ref bestLabel, 1);
        }

        return best;
    }

    private static void EvaluateCandidate<T>(
        string? label,
        T candidate,
        string searchToken,
        ref int bestScore,
        ref T? best,
        ref string? bestLabel,
        int exactMatchScore)
        where T : class
    {
        if (string.IsNullOrWhiteSpace(label))
        {
            return;
        }

        var normalizedLabel = Normalize(label);
        if (normalizedLabel.Length == 0)
        {
            return;
        }

        int score = 0;
        if (normalizedLabel.Equals(searchToken, StringComparison.Ordinal))
        {
            score = exactMatchScore;
        }
        else if (normalizedLabel.Contains(searchToken, StringComparison.Ordinal))
        {
            score = 1;
        }
        else if (searchToken.Contains(normalizedLabel, StringComparison.Ordinal))
        {
            score = 1;
        }

        if (score > bestScore)
        {
            bestScore = score;
            best = candidate;
            bestLabel = label;
        }
        else if (score > 0 && best is not null && score == bestScore)
        {
            if ((label?.Length ?? int.MaxValue) < (bestLabel?.Length ?? int.MaxValue))
            {
                best = candidate;
                bestLabel = label;
            }
        }
    }

    private static string Normalize(string value)
    {
        var normalized = value.Normalize(NormalizationForm.FormD);
        var builder = new StringBuilder(normalized.Length);

        foreach (var ch in normalized)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(ch) == UnicodeCategory.NonSpacingMark)
            {
                continue;
            }

            if (char.IsLetterOrDigit(ch))
            {
                builder.Append(char.ToLowerInvariant(ch));
            }
        }

        return builder.ToString();
    }
}
