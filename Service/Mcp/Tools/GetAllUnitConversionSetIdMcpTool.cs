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

public sealed class GetAllUnitConversionSetIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetAllUnitConversionSetIdMcpTool> _logger;

    public GetAllUnitConversionSetIdMcpTool(IServiceProvider serviceProvider, ILogger<GetAllUnitConversionSetIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_all_unit_conversion_set_id";

    public string Description => "Returns the identifiers of every unit conversion set by invoking the UnitConversionSetController.";

    public JsonNode? InputSchema => null;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitConversionSetController>(scope.ServiceProvider);

            ActionResult<IEnumerable<Guid>> actionResult = controller.GetAllUnitConversionSetId();

            if (ActionResultToolHelper.TryResolveResult(actionResult, "Unable to retrieve unit conversion set identifiers.", out var identifiers, out var errorNode))
            {
                var payload = JsonSerializer.SerializeToNode(identifiers, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            return Task.FromResult(errorNode);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving unit conversion set identifiers."));
        }
    }
}
