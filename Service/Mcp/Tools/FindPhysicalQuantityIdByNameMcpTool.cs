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
                ["description"] = "Name or common synonym of the physical quantity. Matching ignores case, spacing, punctuation, and accents. The result also identifies parent physical quantities whose compatible unit choices may be used."
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

    public string Description => "Resolve a physical-quantity UUID from a name or common synonym using case-, spacing-, punctuation-, and accent-tolerant matching. The response explains whether the match is specialised and lists its parent physical quantities. A specialised quantity can use compatible unit choices inherited from those parents while retaining its own MeaningfulPrecisionInSI for formatted results. Returns 404 when no supported quantity matches.";

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

            var searchToken = McpNameNormalizer.NormalizeText(rawName);
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
            payload["hierarchy"] = PhysicalQuantityMcpMetadata.Create(bestMatch.Value.Quantity);

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

        var normalizedLabel = McpNameNormalizer.NormalizeText(label);
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

}
