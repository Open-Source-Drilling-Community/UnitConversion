using System;
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
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.Service.Controllers;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class FindUnitSystemIdByNameMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<FindUnitSystemIdByNameMcpTool> _logger;

    private static readonly JsonObject Schema = new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["name"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Name of the unit system to search for."
            }
        },
        ["required"] = new JsonArray { "name" },
        ["additionalProperties"] = false
    };

    public FindUnitSystemIdByNameMcpTool(IServiceProvider serviceProvider, ILogger<FindUnitSystemIdByNameMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "find_unit_system_id_by_name";

    public string Description => "Looks up the ID of a unit system by name (case and spacing insensitive) using the UnitSystemController.";

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
            var controller = ActivatorUtilities.CreateInstance<UnitSystemController>(scope.ServiceProvider);

            ActionResult<System.Collections.Generic.IEnumerable<UnitSystemLight>> actionResult = controller.GetAllUnitSystemLight();

            var unitSystems = ExtractUnitSystems(actionResult);
            if (unitSystems is null)
            {
                var statusCode = actionResult.Result switch
                {
                    ObjectResult objectResult => objectResult.StatusCode ?? StatusCodes.Status500InternalServerError,
                    StatusCodeResult codeResult => codeResult.StatusCode,
                    _ => StatusCodes.Status500InternalServerError
                };

                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(statusCode, "Unable to retrieve unit systems for lookup."));
            }

            var searchToken = Normalize(rawName);
            var bestMatch = FindBestMatch(unitSystems, searchToken);

            if (bestMatch is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"No unit system matched '{rawName}'."));
            }

            var payload = new JsonObject
            {
                ["id"] = bestMatch.Value.System.ID.ToString(),
                ["name"] = bestMatch.Value.System.Name
            };

            if (!string.Equals(bestMatch.Value.System.Name, bestMatch.Value.MatchedLabel, StringComparison.Ordinal))
            {
                payload["matchedName"] = bestMatch.Value.MatchedLabel;
            }

            if (!string.IsNullOrWhiteSpace(bestMatch.Value.System.Description))
            {
                payload["description"] = bestMatch.Value.System.Description;
            }

            return Task.FromResult<JsonNode?>(payload);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while searching for the unit system."));
        }
    }

    private static System.Collections.Generic.IEnumerable<UnitSystemLight>? ExtractUnitSystems(
        ActionResult<System.Collections.Generic.IEnumerable<UnitSystemLight>> actionResult)
    {
        if (actionResult.Value is { } values)
        {
            return values;
        }

        if (actionResult.Result is ObjectResult { Value: { } objectValue } && objectValue is System.Collections.Generic.IEnumerable<UnitSystemLight> converted)
        {
            return converted;
        }

        return null;
    }

    private static (UnitSystemLight System, string MatchedLabel, int Score)? FindBestMatch(
        System.Collections.Generic.IEnumerable<UnitSystemLight> unitSystems,
        string searchToken)
    {
        var bestScore = 0;
        (UnitSystemLight System, string MatchedLabel, int Score)? best = null;

        foreach (var unitSystem in unitSystems)
        {
            if (unitSystem.ID == Guid.Empty || string.IsNullOrWhiteSpace(unitSystem.Name))
            {
                continue;
            }

            EvaluateCandidate(unitSystem.Name, unitSystem, searchToken, ref bestScore, ref best, 3);

            if (!string.IsNullOrWhiteSpace(unitSystem.Description))
            {
                EvaluateCandidate(unitSystem.Description, unitSystem, searchToken, ref bestScore, ref best, 1);
            }
        }

        return best;
    }

    private static void EvaluateCandidate(
        string? label,
        UnitSystemLight unitSystem,
        string searchToken,
        ref int bestScore,
        ref (UnitSystemLight System, string MatchedLabel, int Score)? best,
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
            best = (unitSystem, label, score);
        }
        else if (score > 0 && best.HasValue && score == bestScore)
        {
            if ((label?.Length ?? int.MaxValue) < best.Value.MatchedLabel.Length)
            {
                best = (unitSystem, label!, score);
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

