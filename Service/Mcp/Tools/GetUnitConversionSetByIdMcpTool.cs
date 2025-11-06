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

public sealed class GetUnitConversionSetByIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetUnitConversionSetByIdMcpTool> _logger;

    public GetUnitConversionSetByIdMcpTool(IServiceProvider serviceProvider, ILogger<GetUnitConversionSetByIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_unit_conversion_set_by_id";

    public string Description => "Fetches a unit conversion set by its identifier by calling the UnitConversionSetController.";

    public JsonNode? InputSchema => McpToolArgumentHelpers.CreateGuidSchema("id");

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (!McpToolArgumentHelpers.TryParseGuid(arguments, "id", out var id, out var parseError))
        {
            return Task.FromResult(parseError);
        }

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitConversionSetController>(scope.ServiceProvider);

            ActionResult<UnitConversionSet> actionResult = controller.GetUnitConversionSetById(id);

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
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"Unit conversion set '{id}' was not found."));
            }

            if (actionResult.Result is BadRequestResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("The unit conversion set id must be a non-empty UUID."));
            }

            if (actionResult.Result is ObjectResult objectResult)
            {
                var statusCode = objectResult.StatusCode ?? StatusCodes.Status500InternalServerError;
                var message = objectResult.Value as string ?? "Unable to retrieve the unit conversion set.";
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(statusCode, message));
            }

            if (actionResult.Result is StatusCodeResult statusCodeResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(statusCodeResult.StatusCode, "Unable to retrieve the unit conversion set."));
            }

            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "Unable to retrieve the unit conversion set."));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while retrieving the unit conversion set."));
        }
    }
}
