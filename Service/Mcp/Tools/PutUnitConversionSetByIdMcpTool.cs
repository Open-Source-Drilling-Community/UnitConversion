using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Model;
using OSDC.UnitConversion.Service.Controllers;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class PutUnitConversionSetByIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<PutUnitConversionSetByIdMcpTool> _logger;

    private static readonly JsonObject Schema = new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["id"] = new JsonObject
            {
                ["type"] = "string",
                ["format"] = "uuid"
            },
            ["unitConversionSet"] = new JsonObject
            {
                ["type"] = "object",
                ["description"] = "The updated unit conversion set payload."
            }
        },
        ["required"] = new JsonArray { "id", "unitConversionSet" },
        ["additionalProperties"] = false
    };

    public PutUnitConversionSetByIdMcpTool(IServiceProvider serviceProvider, ILogger<PutUnitConversionSetByIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "put_unit_conversion_set_by_id";

    public string Description => "Updates an existing unit conversion set by forwarding the payload to the UnitConversionSetController.";

    public JsonNode? InputSchema => Schema;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (!McpToolArgumentHelpers.TryParseGuid(arguments, "id", out var id, out var parseError))
        {
            return Task.FromResult(parseError);
        }

        if (arguments?["unitConversionSet"] is not JsonNode setNode)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitConversionSet' is required."));
        }

        UnitConversionSet? unitConversionSet;
        try
        {
            unitConversionSet = setNode.Deserialize<UnitConversionSet>(McpToolJsonOptions.Default);
        }
        catch (JsonException jsonEx)
        {
            _logger.LogWarning(jsonEx, "Failed to deserialize unit conversion set payload.");
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitConversionSet' must be a valid unit conversion set payload."));
        }

        if (unitConversionSet is null)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitConversionSet' must be a valid unit conversion set payload."));
        }

        var payloadId = unitConversionSet.MetaInfo?.ID ?? Guid.Empty;
        if (payloadId == Guid.Empty || payloadId != id)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("The unit conversion set payload ID must match the 'id' argument."));
        }

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitConversionSetController>(scope.ServiceProvider);

            var actionResult = controller.PutUnitConversionSetById(id, unitConversionSet);

            if (actionResult is NotFoundResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"Unit conversion set '{id}' was not found."));
            }

            if (actionResult is BadRequestResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("The unit conversion set payload is invalid or its ID does not match the target id."));
            }

            var response = ActionResultToolHelper.CreateResponse(actionResult, "Unit conversion set updated.", "Failed to update the unit conversion set.");
            return Task.FromResult(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while updating the unit conversion set."));
        }
    }
}
