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

public sealed class GetAllUnitSystemConversionSetIdMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetAllUnitSystemConversionSetIdMcpTool> _logger;

    public GetAllUnitSystemConversionSetIdMcpTool(IServiceProvider serviceProvider, ILogger<GetAllUnitSystemConversionSetIdMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_all_unit_system_conversion_set_id";

    public string Description => "Returns the identifiers of every unit system conversion set via the UnitSystemConversionSetController.";

    public JsonNode? InputSchema => null;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitSystemConversionSetController>(scope.ServiceProvider);

            ActionResult<IEnumerable<Guid>> actionResult = controller.GetAllUnitSystemConversionSetId();

            if (ActionResultToolHelper.TryResolveResult(actionResult, "Unable to retrieve unit system conversion set identifiers.", out var identifiers, out var errorNode))
            {
                var payload = JsonSerializer.SerializeToNode(identifiers, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            return Task.FromResult(errorNode);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving unit system conversion set identifiers."));
        }
    }
}

