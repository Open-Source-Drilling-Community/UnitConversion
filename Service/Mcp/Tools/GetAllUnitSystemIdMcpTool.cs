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

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class GetAllUnitSystemIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetAllUnitSystemIdMcpTool> _logger;

    public GetAllUnitSystemIdMcpTool(IServiceProvider serviceProvider, ILogger<GetAllUnitSystemIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_all_unit_system_id";

    public string Description => "List the UUIDs of all built-in and custom unit systems without transferring their physical-quantity-to-unit-choice mappings. Use an ID with get_unit_system_by_id or a unit-system conversion set.";

    public JsonNode? InputSchema => McpToolArgumentHelpers.CreateEmptySchema();

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitSystemController>(scope.ServiceProvider);

            ActionResult<IEnumerable<Guid>> actionResult = controller.GetAllUnitSystemId();

            if (ActionResultToolHelper.TryResolveResult(actionResult, "Unable to retrieve unit system identifiers.", out var identifiers, out var errorNode))
            {
                var payload = JsonSerializer.SerializeToNode(identifiers, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            return Task.FromResult(errorNode);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving unit system identifiers."));
        }
    }
}

