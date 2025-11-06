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

public sealed class PutUnitSystemConversionSetByIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<PutUnitSystemConversionSetByIdMcpTool> _logger;

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
            ["unitSystemConversionSet"] = new JsonObject
            {
                ["type"] = "object",
                ["description"] = "The updated unit system conversion set payload."
            }
        },
        ["required"] = new JsonArray { "id", "unitSystemConversionSet" },
        ["additionalProperties"] = false
    };

    public PutUnitSystemConversionSetByIdMcpTool(IServiceProvider serviceProvider, ILogger<PutUnitSystemConversionSetByIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "put_unit_system_conversion_set_by_id";

    public string Description => "Updates an existing unit system conversion set through the UnitSystemConversionSetController.";

    public JsonNode? InputSchema => Schema;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (!McpToolArgumentHelpers.TryParseGuid(arguments, "id", out var id, out var parseError))
        {
            return Task.FromResult(parseError);
        }

        if (arguments?["unitSystemConversionSet"] is not JsonNode setNode)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitSystemConversionSet' is required."));
        }

        UnitSystemConversionSet? unitSystemConversionSet;
        try
        {
            unitSystemConversionSet = setNode.Deserialize<UnitSystemConversionSet>(McpToolJsonOptions.Default);
        }
        catch (JsonException jsonEx)
        {
            _logger.LogWarning(jsonEx, "Failed to deserialize unit system conversion set payload.");
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitSystemConversionSet' must be a valid unit system conversion set payload."));
        }

        if (unitSystemConversionSet is null)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitSystemConversionSet' must be a valid unit system conversion set payload."));
        }

        var payloadId = unitSystemConversionSet.MetaInfo?.ID ?? Guid.Empty;
        if (payloadId == Guid.Empty || payloadId != id)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("The unit system conversion set payload ID must match the 'id' argument."));
        }

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitSystemConversionSetController>(scope.ServiceProvider);

            var actionResult = controller.PutUnitSystemConversionSetById(id, unitSystemConversionSet);

            if (actionResult is NotFoundResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"Unit system conversion set '{id}' was not found."));
            }

            if (actionResult is BadRequestResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("The unit system conversion set payload is invalid or its ID does not match the target id."));
            }

            var response = ActionResultToolHelper.CreateResponse(actionResult, "Unit system conversion set updated.", "Failed to update the unit system conversion set.");
            return Task.FromResult(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while updating the unit system conversion set."));
        }
    }
}

