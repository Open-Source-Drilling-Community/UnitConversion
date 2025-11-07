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
using OSDC.UnitConversion.Conversion.UnitSystem.DrillingEngineering;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class GetAllUnitSystemMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetAllUnitSystemMcpTool> _logger;

    public GetAllUnitSystemMcpTool(IServiceProvider serviceProvider, ILogger<GetAllUnitSystemMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_all_unit_system";

    public string Description => "Returns the whole content of every unit systems by invoking the UnitSystemController heavy-data endpoint.";

    public JsonNode? InputSchema => null;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitSystemController>(scope.ServiceProvider);

            ActionResult<IEnumerable<DrillingUnitSystem>> actionResult = controller.GetAllUnitSystem();

            if (ActionResultToolHelper.TryResolveResult(actionResult, "Unable to retrieve unit systems.", out var unitSystems, out var errorNode))
            {
                var payload = JsonSerializer.SerializeToNode(unitSystems, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            return Task.FromResult(errorNode);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving unit systems."));
        }
    }
}

