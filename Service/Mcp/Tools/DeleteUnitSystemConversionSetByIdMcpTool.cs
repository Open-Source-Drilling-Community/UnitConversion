using System;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Service.Controllers;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class DeleteUnitSystemConversionSetByIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<DeleteUnitSystemConversionSetByIdMcpTool> _logger;

    public DeleteUnitSystemConversionSetByIdMcpTool(IServiceProvider serviceProvider, ILogger<DeleteUnitSystemConversionSetByIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "delete_unit_system_conversion_set_by_id";

    public string Description => "Deletes a unit system conversion set by its identifier through the UnitSystemConversionSetController.";

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
            var controller = ActivatorUtilities.CreateInstance<UnitSystemConversionSetController>(scope.ServiceProvider);

            var actionResult = controller.DeleteUnitSystemConversionSetById(id);

            if (actionResult is NotFoundResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status404NotFound, $"Unit system conversion set '{id}' was not found."));
            }

            var response = ActionResultToolHelper.CreateResponse(actionResult, "Unit system conversion set deleted.", "Failed to delete the unit system conversion set.");
            return Task.FromResult(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while deleting the unit system conversion set."));
        }
    }
}

