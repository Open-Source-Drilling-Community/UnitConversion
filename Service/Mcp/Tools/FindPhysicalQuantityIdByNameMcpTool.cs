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
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.Service.Controllers;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class FindPhysicalQuantityIdByNameMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<FindPhysicalQuantityIdByNameMcpTool> _logger;

    private static readonly JsonObject Schema = new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["name"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Name (or common synonym) of the physical quantity."
            }
        },
        ["required"] = new JsonArray { "name" },
        ["additionalProperties"] = false
    };

    public FindPhysicalQuantityIdByNameMcpTool(IServiceProvider serviceProvider, ILogger<FindPhysicalQuantityIdByNameMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "find_physical_quantity_id_by_name";

    public string Description => "Looks up the ID of a physical quantity by name (case, spacing, and accent tolerant) using the PhysicalQuantityController.";

    public JsonNode? InputSchema => Schema;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (arguments?["name"] is not JsonValue nameValue || nameValue.GetValue<string?>() is not { } rawName || string.IsNullOrWhiteSpace(rawName))
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'name' is required and must be a non-empty string."));
        }

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<PhysicalQuantityController>(scope.ServiceProvider);

            ActionResult<IEnumerable<DrillingPhysicalQuantity>> actionResult = controller.GetAllPhysicalQuantity();

            IEnumerable<BasePhysicalQuantity>? quantities = ExtractQuantities(actionResult);
            if (quantities is null)
            {
                var statusCode = actionResult.Result switch
                {
                    ObjectResult objectResult => objectResult.StatusCode ?? StatusCodes.Status500InternalServerError,
                    StatusCodeResult codeResult => codeResult.StatusCode,
                    _ => StatusCodes.Status500InternalServerError
                };

                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(statusCode, "Unable to retrieve physical quantities for lookup."));
            }

            var searchToken = Normalize(rawName);
            var bestMatch = FindBestMatch(quantities, searchToken);

            if (bestMatch is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"No physical quantity matched '{rawName}'."));
            }

            var payload = new JsonObject
            {
                ["id"] = bestMatch.Value.Quantity.ID.ToString(),
                ["name"] = bestMatch.Value.Quantity.Name
            };

            if (!string.Equals(bestMatch.Value.Quantity.Name, bestMatch.Value.MatchedLabel, StringComparison.Ordinal))
            {
                payload["matchedName"] = bestMatch.Value.MatchedLabel;
            }

            if (bestMatch.Value.Quantity.UsualNames is { Count: > 0 })
            {
                payload["synonyms"] = JsonSerializer.SerializeToNode(bestMatch.Value.Quantity.UsualNames, McpToolJsonOptions.Default);
            }

            return Task.FromResult<JsonNode?>(payload);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while searching for the physical quantity."));
        }
    }

    private static IEnumerable<BasePhysicalQuantity>? ExtractQuantities(ActionResult<IEnumerable<DrillingPhysicalQuantity>> actionResult)
    {
        if (actionResult.Value is IEnumerable<DrillingPhysicalQuantity> drillingValues)
        {
            return drillingValues.Cast<BasePhysicalQuantity>();
        }

        if (actionResult.Value is IEnumerable<BasePhysicalQuantity> baseValues)
        {
            return baseValues;
        }

        if (actionResult.Result is ObjectResult { Value: { } value })
        {
            if (value is IEnumerable<DrillingPhysicalQuantity> drilling)
            {
                return drilling.Cast<BasePhysicalQuantity>();
            }

            if (value is IEnumerable<BasePhysicalQuantity> bases)
            {
                return bases;
            }
        }

        return null;
    }

    private static (BasePhysicalQuantity Quantity, string MatchedLabel, int Score)? FindBestMatch(IEnumerable<BasePhysicalQuantity> quantities, string searchToken)
    {
        var bestScore = 0;
        (BasePhysicalQuantity Quantity, string MatchedLabel, int Score)? best = null;

        foreach (var quantity in quantities)
        {
            if (quantity.ID == Guid.Empty)
            {
                continue;
            }

            EvaluateCandidate(quantity.Name, quantity, searchToken, ref bestScore, ref best, 3);

            if (quantity.UsualNames is { Count: > 0 })
            {
                foreach (var synonym in quantity.UsualNames)
                {
                    EvaluateCandidate(synonym, quantity, searchToken, ref bestScore, ref best, 2);
                }
            }
        }

        return best;
    }

    private static void EvaluateCandidate(
        string? label,
        BasePhysicalQuantity quantity,
        string searchToken,
        ref int bestScore,
        ref (BasePhysicalQuantity Quantity, string MatchedLabel, int Score)? best,
        int exactMatchScore)
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
            best = (quantity, label, score);
        }
        else if (score > 0 && best.HasValue && score == bestScore)
        {
            // tie-breaker: prefer shorter matched label
            if ((label?.Length ?? int.MaxValue) < best.Value.MatchedLabel.Length)
            {
                best = (quantity, label!, score);
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
