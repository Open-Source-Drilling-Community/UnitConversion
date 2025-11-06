using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.DotnetLibraries.General.DataManagement;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.Conversion.UnitSystem.DrillingEngineering;
using OSDC.UnitConversion.Model;
using OSDC.UnitConversion.Service.Controllers;
using OSDC.UnitConversion.Conversion;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class ConvertUnitSystemValueMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<ConvertUnitSystemValueMcpTool> _logger;

    private static readonly JsonObject Schema = new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["physicalQuantity"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Name (or synonym) of the physical quantity to convert."
            },
            ["physicalQuantityId"] = new JsonObject
            {
                ["type"] = "string",
                ["format"] = "uuid",
                ["description"] = "Identifier of the physical quantity to convert. Overrides the name if both are supplied."
            },
            ["unitSystemIn"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Name of the source unit system."
            },
            ["unitSystemInId"] = new JsonObject
            {
                ["type"] = "string",
                ["format"] = "uuid",
                ["description"] = "Identifier of the source unit system. Overrides the name if both are supplied."
            },
            ["unitSystemOut"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Name of the destination unit system."
            },
            ["unitSystemOutId"] = new JsonObject
            {
                ["type"] = "string",
                ["format"] = "uuid",
                ["description"] = "Identifier of the destination unit system. Overrides the name if both are supplied."
            },
            ["value"] = new JsonObject
            {
                ["type"] = "number",
                ["description"] = "Numeric value to convert."
            }
        },
        ["required"] = new JsonArray { "value" },
        ["additionalProperties"] = false
    };

    public ConvertUnitSystemValueMcpTool(IServiceProvider serviceProvider, ILogger<ConvertUnitSystemValueMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "convert_unit_system_value";

    public string Description => "Converts a value between two unit systems by creating a temporary UnitSystemConversionSet.";

    public JsonNode? InputSchema => Schema;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (!TryParseOptionalGuid(arguments, "physicalQuantityId", out var quantityId, out var validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryParseOptionalGuid(arguments, "unitSystemInId", out var unitSystemInId, out validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryParseOptionalGuid(arguments, "unitSystemOutId", out var unitSystemOutId, out validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryGetOptionalString(arguments, "physicalQuantity", out var physicalQuantityName, out validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryGetOptionalString(arguments, "unitSystemIn", out var unitSystemInName, out validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryGetOptionalString(arguments, "unitSystemOut", out var unitSystemOutName, out validationError))
        {
            return Task.FromResult(validationError);
        }

        if (!TryGetRequiredDouble(arguments, "value", out var value, out validationError))
        {
            return Task.FromResult(validationError);
        }

        if (quantityId is null && string.IsNullOrWhiteSpace(physicalQuantityName))
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Either 'physicalQuantityId' or 'physicalQuantity' must be provided."));
        }

        if (unitSystemInId is null && string.IsNullOrWhiteSpace(unitSystemInName))
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Either 'unitSystemInId' or 'unitSystemIn' must be provided."));
        }

        if (unitSystemOutId is null && string.IsNullOrWhiteSpace(unitSystemOutName))
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Either 'unitSystemOutId' or 'unitSystemOut' must be provided."));
        }

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var pqController = ActivatorUtilities.CreateInstance<PhysicalQuantityController>(scope.ServiceProvider);
            var unitSystemController = ActivatorUtilities.CreateInstance<UnitSystemController>(scope.ServiceProvider);
            var conversionSetController = ActivatorUtilities.CreateInstance<UnitSystemConversionSetController>(scope.ServiceProvider);

            var physicalQuantity = ResolvePhysicalQuantity(pqController, quantityId, physicalQuantityName);
            if (physicalQuantity is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, "Unable to resolve the requested physical quantity."));
            }

            var unitSystemIn = ResolveUnitSystem(unitSystemController, unitSystemInId, unitSystemInName);
            if (unitSystemIn is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, "Unable to resolve the source unit system."));
            }

            var unitSystemOut = ResolveUnitSystem(unitSystemController, unitSystemOutId, unitSystemOutName);
            if (unitSystemOut is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, "Unable to resolve the destination unit system."));
            }

            var constructedId = Guid.NewGuid();
            var quantityConversion = new QuantityConversion
            {
                QuantityID = physicalQuantity.ID,
                ValueConversionList = new List<ValueConversion>
                {
                    new ValueConversion { DataIn = value }
                }
            };

            var conversionSet = new UnitSystemConversionSet
            {
                MetaInfo = new MetaInfo { ID = constructedId },
                UnitSystemInID = unitSystemIn.ID,
                UnitSystemOutID = unitSystemOut.ID,
                QuantityConversionList = new List<QuantityConversion> { quantityConversion }
            };

            var postResult = conversionSetController.PostUnitSystemConversionSet(conversionSet);
            if (IsFailure(postResult))
            {
                return Task.FromResult<JsonNode?>(CreateFailureResponse(postResult, "Failed to create unit system conversion set."));
            }

            try
            {
                var getResult = conversionSetController.GetUnitSystemConversionSetById(constructedId);
                var persisted = getResult.Value ?? (getResult.Result as ObjectResult)?.Value as UnitSystemConversionSet;
                if (persisted?.QuantityConversionList is null || persisted.QuantityConversionList.Count == 0)
                {
                    return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "Unit system conversion set did not return any conversion result."));
                }

                var persistedQuantityConversion = persisted.QuantityConversionList[0];
                if (persistedQuantityConversion.ValueConversionList is null || persistedQuantityConversion.ValueConversionList.Count == 0)
                {
                    return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "Unit system conversion set did not compute any values."));
                }

                var persistedValue = persistedQuantityConversion.ValueConversionList[0];

                var payload = new JsonObject
                {
                    ["physicalQuantity"] = physicalQuantity.Name,
                    ["quantityId"] = physicalQuantity.ID.ToString(),
                    ["unitSystemIn"] = new JsonObject
                    {
                        ["name"] = unitSystemIn.Name,
                        ["id"] = unitSystemIn.ID.ToString(),
                        ["description"] = unitSystemIn.Description
                    },
                    ["unitSystemOut"] = new JsonObject
                    {
                        ["name"] = unitSystemOut.Name,
                        ["id"] = unitSystemOut.ID.ToString(),
                        ["description"] = unitSystemOut.Description
                    },
                    ["inputValue"] = value,
                    ["outputValue"] = persistedValue.DataOut,
                    ["formattedOutput"] = persistedValue.DataOutString
                };

            return Task.FromResult<JsonNode?>(payload);
            }
            finally
            {
                var deleteResult = conversionSetController.DeleteUnitSystemConversionSetById(constructedId);
                if (IsFailure(deleteResult))
                {
                    _logger.LogWarning("Failed to delete temporary unit system conversion set {ConversionSetId}.", constructedId);
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while performing the unit system conversion."));
        }
    }

    private static bool TryParseOptionalGuid(JsonObject? arguments, string key, out Guid? value, out JsonNode? error)
    {
        value = null;
        error = null;

        if (arguments is null || !arguments.TryGetPropertyValue(key, out var node) || node is null)
        {
            return true;
        }

        if (node is JsonValue valueNode)
        {
            var guidText = valueNode.GetValue<string?>();
            if (string.IsNullOrWhiteSpace(guidText))
            {
                return true;
            }

            if (Guid.TryParse(guidText, out var parsed))
            {
                value = parsed;
                return true;
            }
        }

        error = McpToolResponses.CreateValidationError($"Argument '{key}' must be a UUID string when provided.");
        return false;
    }

    private static bool TryGetOptionalString(JsonObject? arguments, string key, out string? value, out JsonNode? error)
    {
        value = null;
        error = null;

        if (arguments is null || !arguments.TryGetPropertyValue(key, out var node) || node is null)
        {
            return true;
        }

        if (node is JsonValue jsonValue)
        {
            value = jsonValue.GetValue<string?>();
            return true;
        }

        error = McpToolResponses.CreateValidationError($"Argument '{key}' must be a string if provided.");
        return false;
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

    private static bool IsFailure(IActionResult result)
    {
        return result switch
        {
            ObjectResult objectResult => (objectResult.StatusCode ?? StatusCodes.Status200OK) >= StatusCodes.Status400BadRequest,
            StatusCodeResult statusCodeResult => statusCodeResult.StatusCode >= StatusCodes.Status400BadRequest,
            _ => false
        };
    }

    private static JsonNode CreateFailureResponse(IActionResult result, string defaultMessage)
    {
        return result switch
        {
            ObjectResult objectResult => McpToolResponses.CreateError(objectResult.StatusCode ?? StatusCodes.Status500InternalServerError, defaultMessage),
            StatusCodeResult statusCodeResult => McpToolResponses.CreateError(statusCodeResult.StatusCode, defaultMessage),
            _ => McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, defaultMessage)
        };
    }

    private static BasePhysicalQuantity? ResolvePhysicalQuantity(
        PhysicalQuantityController controller,
        Guid? quantityId,
        string? quantityName)
    {
        var actionResult = controller.GetAllPhysicalQuantity();
        IEnumerable<BasePhysicalQuantity>? quantities = null;

        if (actionResult.Value is IEnumerable<BasePhysicalQuantity> baseValues)
        {
            quantities = baseValues;
        }
        else if (actionResult.Value is IEnumerable<DrillingPhysicalQuantity> drillingValues)
        {
            quantities = drillingValues;
        }
        else if (actionResult.Result is ObjectResult objectResult)
        {
            if (objectResult.Value is IEnumerable<BasePhysicalQuantity> baseValuesFromResult)
            {
                quantities = baseValuesFromResult;
            }
            else if (objectResult.Value is IEnumerable<DrillingPhysicalQuantity> drillingValuesFromResult)
            {
                quantities = drillingValuesFromResult;
            }
        }

        if (quantities is null)
        {
            return null;
        }

        var candidates = quantities
            .Select(q => BasePhysicalQuantity.GetQuantity(q.ID) ?? (q as BasePhysicalQuantity))
            .OfType<BasePhysicalQuantity>();

        if (quantityId is Guid id && id != Guid.Empty)
        {
            var byId = candidates.FirstOrDefault(q => q.ID == id);
            if (byId != null)
            {
                return byId;
            }
        }

        if (string.IsNullOrWhiteSpace(quantityName))
        {
            return null;
        }

        var searchToken = Normalize(quantityName);
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

    private static UnitSystemLight? ResolveUnitSystem(
        UnitSystemController controller,
        Guid? unitSystemId,
        string? unitSystemName)
    {
        var actionResult = controller.GetAllUnitSystemLight();
        IEnumerable<UnitSystemLight>? unitSystems = actionResult.Value switch
        {
            IEnumerable<UnitSystemLight> lights => lights,
            _ => null
        };

        if (unitSystems is null && actionResult.Result is ObjectResult objectResult)
        {
            unitSystems = objectResult.Value switch
            {
                IEnumerable<UnitSystemLight> lights => lights,
                _ => null
            };
        }

        if (unitSystems is null)
        {
            return null;
        }

        if (unitSystemId is Guid id && id != Guid.Empty)
        {
            var byId = unitSystems.FirstOrDefault(u => u.ID == id);
            if (byId != null)
            {
                return byId;
            }
        }

        if (string.IsNullOrWhiteSpace(unitSystemName))
        {
            return null;
        }

        var searchToken = Normalize(unitSystemName);
        var bestScore = 0;
        UnitSystemLight? best = null;
        string? bestLabel = null;

        foreach (var unitSystem in unitSystems)
        {
            if (unitSystem.ID == Guid.Empty)
            {
                continue;
            }

            EvaluateCandidate(unitSystem.Name, unitSystem, searchToken, ref bestScore, ref best, ref bestLabel, 3);
            EvaluateCandidate(unitSystem.Description, unitSystem, searchToken, ref bestScore, ref best, ref bestLabel, 1);
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
