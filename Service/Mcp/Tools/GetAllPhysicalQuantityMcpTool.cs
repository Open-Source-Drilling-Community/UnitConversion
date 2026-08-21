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
using OSDC.UnitConversion.Conversion;

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

    public string Description => "Retrieve every supported physical quantity with complete dimensional metadata and all available unit choices. This is a large reference-data response; prefer the ID, name-lookup, or get-by-ID tools when only one quantity is needed.";

    public JsonNode? InputSchema => McpToolArgumentHelpers.CreateEmptySchema();

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<PhysicalQuantityController>(scope.ServiceProvider);

            ActionResult<IEnumerable<DrillingPhysicalQuantity>> actionResult = controller.GetAllPhysicalQuantity();

            IEnumerable<BasePhysicalQuantity>? quantities = actionResult.Value switch
            {
                IEnumerable<BasePhysicalQuantity> baseValues => baseValues,
                _ => null
            };

            if (quantities is null && actionResult.Result is ObjectResult objectResult)
            {
                quantities = objectResult.Value switch
                {
                    IEnumerable<BasePhysicalQuantity> baseValues => baseValues,
                    _ => null
                };
            }

            if (quantities is null)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "Unable to retrieve physical quantities."));
            }

            var payload = JsonSerializer.SerializeToNode(quantities, McpToolJsonOptions.Default);
            return Task.FromResult<JsonNode?>(payload);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(500, "An unexpected error occurred while retrieving physical quantities."));
        }
    }
}
