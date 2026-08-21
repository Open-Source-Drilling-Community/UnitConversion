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

public sealed class GetAllPhysicalQuantityIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetAllPhysicalQuantityIdMcpTool> _logger;

    public GetAllPhysicalQuantityIdMcpTool(IServiceProvider serviceProvider, ILogger<GetAllPhysicalQuantityIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_all_physical_quantity_id";

    public string Description => "List the UUIDs of every supported drilling physical quantity without transferring dimensions or unit choices. Use an ID with get_physical_quantity_by_id, a conversion-set payload, or unit-system Choices; use find_physical_quantity_id_by_name when starting from a human name.";

    public JsonNode? InputSchema => McpToolArgumentHelpers.CreateEmptySchema();

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<PhysicalQuantityController>(scope.ServiceProvider);

            ActionResult<IEnumerable<Guid>> actionResult = controller.GetAllPhysicalQuantityId();

            if (ActionResultToolHelper.TryResolveResult(actionResult, "Unable to retrieve physical quantity identifiers.", out var identifiers, out var errorNode))
            {
                var payload = JsonSerializer.SerializeToNode(identifiers, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            return Task.FromResult(errorNode);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving physical quantity identifiers."));
        }
    }
}
