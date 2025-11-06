using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Model;
using OSDC.UnitConversion.Service.Controllers;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class GetAllUnitSystemConversionSetMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetAllUnitSystemConversionSetMcpTool> _logger;

    public GetAllUnitSystemConversionSetMcpTool(IServiceProvider serviceProvider, ILogger<GetAllUnitSystemConversionSetMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_all_unit_system_conversion_set";

    public string Description => "Returns all unit system conversion sets via the UnitSystemConversionSetController heavy-data endpoint.";

    public JsonNode? InputSchema => null;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitSystemConversionSetController>(scope.ServiceProvider);

            ActionResult<IEnumerable<UnitSystemConversionSet>> actionResult = controller.GetAllUnitSystemConversionSet();

            if (ActionResultToolHelper.TryResolveResult(actionResult, "Unable to retrieve unit system conversion sets.", out var conversionSets, out var errorNode))
            {
                var payload = JsonSerializer.SerializeToNode(conversionSets, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            return Task.FromResult(errorNode);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving unit system conversion sets."));
        }
    }
}

