using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.DotnetLibraries.General.DataManagement;
using OSDC.UnitConversion.Service.Controllers;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class GetAllUnitSystemConversionSetMetaInfoMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<GetAllUnitSystemConversionSetMetaInfoMcpTool> _logger;

    public GetAllUnitSystemConversionSetMetaInfoMcpTool(IServiceProvider serviceProvider, ILogger<GetAllUnitSystemConversionSetMetaInfoMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "get_all_unit_system_conversion_set_meta_info";

    public string Description => "Returns metadata for every unit system conversion set via the UnitSystemConversionSetController.";

    public JsonNode? InputSchema => null;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitSystemConversionSetController>(scope.ServiceProvider);

            ActionResult<IEnumerable<MetaInfo>> actionResult = controller.GetAllUnitSystemConversionSetMetaInfo();

            if (ActionResultToolHelper.TryResolveResult(actionResult, "Unable to retrieve unit system conversion set meta information.", out var metaInfos, out var errorNode))
            {
                var payload = JsonSerializer.SerializeToNode(metaInfos, McpToolJsonOptions.Default);
                return Task.FromResult(payload);
            }

            return Task.FromResult(errorNode);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving unit system conversion set meta information."));
        }
    }
}

