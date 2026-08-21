using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Service.Controllers;
using OSDC.UnitConversion.Conversion.UnitSystem.DrillingEngineering;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class GetUnitSystemByIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetUnitSystemByIdMcpTool> _logger;

    public GetUnitSystemByIdMcpTool(IServiceProvider serviceProvider, ILogger<GetUnitSystemByIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_unit_system_by_id";

    public string Description => "Retrieve one complete unit system by UUID. The Choices object maps physical-quantity UUID strings to the selected unit-choice UUID strings and defines how unit-system conversions interpret and produce values. Returns 404 when absent.";

    public JsonNode? InputSchema => McpToolArgumentHelpers.CreateGuidSchema("id", "UUID of the unit system to retrieve, including its Choices mapping.");

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (!McpToolArgumentHelpers.TryParseGuid(arguments, "id", out var id, out var parseError))
        {
            return Task.FromResult(parseError);
        }

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitSystemController>(scope.ServiceProvider);

            ActionResult<DrillingUnitSystem> actionResult = controller.GetUnitSystemById(id);

            if (actionResult.Value is not null)
            {
                var payload = JsonSerializer.SerializeToNode(actionResult.Value, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            if (actionResult.Result is OkObjectResult okObjectResult && okObjectResult.Value is not null)
            {
                var payload = JsonSerializer.SerializeToNode(okObjectResult.Value, okObjectResult.Value.GetType(), McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            if (actionResult.Result is NotFoundResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"Unit system '{id}' was not found."));
            }

            if (actionResult.Result is BadRequestResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("The unit system id must be a non-empty UUID."));
            }

            if (actionResult.Result is ObjectResult objectResult)
            {
                var statusCode = objectResult.StatusCode ?? StatusCodes.Status500InternalServerError;
                var message = objectResult.Value as string ?? "Unable to retrieve the unit system.";
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(statusCode, message));
            }

            if (actionResult.Result is StatusCodeResult statusCodeResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(statusCodeResult.StatusCode, "Unable to retrieve the unit system."));
            }

            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "Unable to retrieve the unit system."));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while retrieving the unit system."));
        }
    }
}

