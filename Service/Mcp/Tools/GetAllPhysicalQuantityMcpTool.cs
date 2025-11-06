using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Service.Controllers;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class GetAllPhysicalQuantityMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetAllPhysicalQuantityMcpTool> _logger;

    public GetAllPhysicalQuantityMcpTool(IServiceProvider serviceProvider, ILogger<GetAllPhysicalQuantityMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_all_physical_quantity";

    public string Description => "Returns every physical quantity available in the service by using the PhysicalQuantityController heavy-data endpoint.";

    public JsonNode? InputSchema => null;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<PhysicalQuantityController>(scope.ServiceProvider);

            ActionResult<IEnumerable<DrillingPhysicalQuantity>> actionResult = controller.GetAllPhysicalQuantity();

            if (ActionResultToolHelper.TryResolveResult(actionResult, "Unable to retrieve physical quantities.", out var quantities, out var errorNode))
            {
                var payload = JsonSerializer.SerializeToNode(quantities, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            return Task.FromResult(errorNode);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving physical quantities."));
        }
    }
}
