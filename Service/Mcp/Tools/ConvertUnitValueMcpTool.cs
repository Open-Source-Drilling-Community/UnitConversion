using System;
using System.Collections.Generic;
using System.Linq;
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
                ["description"] = "Requested physical-quantity name or common synonym. Matching ignores case, spacing, punctuation, and accents. A specialised quantity retains its meaningful precision even when a compatible unit is inherited from an ancestor quantity."
            },
            ["unitIn"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Source UnitName or UnitLabel. Matching accepts case/punctuation differences, common symbols, plurals, and British/American spellings such as metre/meter. If absent on a specialised quantity, its physical-quantity ancestors are searched."
            },
            ["unitOut"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Target UnitName or UnitLabel. Matching accepts case/punctuation differences, common symbols, plurals, and British/American spellings. If absent on the requested subtype, compatible ancestor quantities are searched."
            },
            ["value"] = new JsonObject
            {
                ["type"] = "number",
                ["description"] = "Finite numeric value expressed in unitIn. The returned numeric output is expressed in unitOut."
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

    public string Description => "Synchronously convert one finite numeric value between dimensionally compatible unit choices for a requested physical quantity. Quantity names and synonyms are matched tolerantly; unit matching also handles common symbols, plurals, and British/American spellings such as metre/meter. A specialised drilling quantity is searched first, followed by its physical-quantity ancestors—for example, RateOfPenetrationDrilling can use furlong per fortnight inherited from Velocity. The exact numeric result is preserved, while formattedValue uses the requested specialised quantity's MeaningfulPrecisionInSI. The temporary UnitConversionSet is deleted automatically.";

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

            if (!PhysicalQuantityHierarchy.Enumerate(physicalQuantity).Any(quantity => quantity.UnitChoices is { Count: > 0 }))
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, $"Physical quantity '{physicalQuantity.Name}' has no unit choices available."));
            }

            var unitChoiceIn = FindUnitChoice(physicalQuantity, unitNameIn);
            if (unitChoiceIn is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, BuildUnitNotFoundMessage(physicalQuantity, unitNameIn)));
            }

            var unitChoiceOut = FindUnitChoice(physicalQuantity, unitNameOut);
            if (unitChoiceOut is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, BuildUnitNotFoundMessage(physicalQuantity, unitNameOut)));
            }

            var conversionSetId = Guid.NewGuid();
            var quantityConversion = new QuantityUnitConversion
            {
                QuantityID = physicalQuantity.ID,
                UnitChoiceIDIn = unitChoiceIn.Value.Choice.ID,
                UnitChoiceIDOut = unitChoiceOut.Value.Choice.ID,
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
                        ["unitName"] = unitChoiceIn.Value.Choice.UnitName,
                        ["unitLabel"] = unitChoiceIn.Value.Choice.UnitLabel,
                        ["unitId"] = unitChoiceIn.Value.Choice.ID.ToString(),
                        ["declaredByPhysicalQuantity"] = QuantityReference(unitChoiceIn.Value.DeclaringQuantity),
                        ["inherited"] = unitChoiceIn.Value.DeclaringQuantity.ID != physicalQuantity.ID
                    },
                    ["output"] = new JsonObject
                    {
                        ["value"] = persistedValue.DataOut,
                        ["formattedValue"] = persistedValue.DataOutString,
                        ["unitName"] = unitChoiceOut.Value.Choice.UnitName,
                        ["unitLabel"] = unitChoiceOut.Value.Choice.UnitLabel,
                        ["unitId"] = unitChoiceOut.Value.Choice.ID.ToString(),
                        ["declaredByPhysicalQuantity"] = QuantityReference(unitChoiceOut.Value.DeclaringQuantity),
                        ["inherited"] = unitChoiceOut.Value.DeclaringQuantity.ID != physicalQuantity.ID,
                        ["meaningfulPrecisionInSI"] = physicalQuantity.MeaningfulPrecisionInSI
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

        var searchToken = McpNameNormalizer.NormalizeText(rawName);
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

    private static (UnitChoice Choice, BasePhysicalQuantity DeclaringQuantity)? FindUnitChoice(BasePhysicalQuantity quantity, string rawName)
    {
        var searchToken = McpNameNormalizer.NormalizeUnit(rawName);
        var bestScore = 0;
        UnitChoice? best = null;
        BasePhysicalQuantity? declaringQuantity = null;
        string? bestLabel = null;

        foreach (BasePhysicalQuantity candidateQuantity in PhysicalQuantityHierarchy.Enumerate(quantity))
        {
            foreach (UnitChoice unitChoice in candidateQuantity.UnitChoices ?? [])
            {
                if (unitChoice.ID == Guid.Empty) continue;

                UnitChoice? previousBest = best;
                EvaluateCandidate(unitChoice.UnitName, unitChoice, searchToken, ref bestScore, ref best, ref bestLabel, 3, normalizeUnit: true);
                EvaluateCandidate(unitChoice.UnitLabel, unitChoice, searchToken, ref bestScore, ref best, ref bestLabel, 2, normalizeUnit: true);
                EvaluateCandidate(unitChoice.SIUnitName, unitChoice, searchToken, ref bestScore, ref best, ref bestLabel, 1, normalizeUnit: true);
                if (!ReferenceEquals(previousBest, best)) declaringQuantity = candidateQuantity;
            }
        }

        return best is not null && declaringQuantity is not null ? (best, declaringQuantity) : null;
    }

    private static void EvaluateCandidate<T>(
        string? label,
        T candidate,
        string searchToken,
        ref int bestScore,
        ref T? best,
        ref string? bestLabel,
        int exactMatchScore,
        bool normalizeUnit = false)
        where T : class
    {
        if (string.IsNullOrWhiteSpace(label))
        {
            return;
        }

        var normalizedLabel = normalizeUnit ? McpNameNormalizer.NormalizeUnit(label) : McpNameNormalizer.NormalizeText(label);
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

    private static JsonObject QuantityReference(BasePhysicalQuantity quantity) => new()
    {
        ["id"] = quantity.ID.ToString(),
        ["name"] = quantity.Name
    };

    private static string BuildUnitNotFoundMessage(BasePhysicalQuantity quantity, string unitName)
    {
        string searched = string.Join(" -> ", PhysicalQuantityHierarchy.Enumerate(quantity).Select(candidate => candidate.Name));
        return $"No unit choice matched '{unitName}'. Searched physical-quantity hierarchy: {searched}. Use get_physical_quantity_by_id to inspect the requested quantity and its parentPhysicalQuantities metadata.";
    }
}
