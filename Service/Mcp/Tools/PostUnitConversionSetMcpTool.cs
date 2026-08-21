using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Model;
using OSDC.UnitConversion.Service.Controllers;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

public sealed class PostUnitConversionSetMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<PostUnitConversionSetMcpTool> _logger;

    private static readonly JsonObject Schema = McpToolArgumentHelpers.CreateUnitConversionSetSchema();

    public PostUnitConversionSetMcpTool(IServiceProvider serviceProvider, ILogger<PostUnitConversionSetMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "post_unit_conversion_set";

    public string Description => "Create, calculate, and persist a batch converting values between explicit unit choices. Assign a case UUID and group DataIn values by physical-quantity UUID. Source and target unit-choice UUIDs may be declared directly by that quantity or inherited from one of its physical-quantity ancestors. DataOut remains numeric and unrounded; DataOutString uses the requested quantity's MeaningfulPrecisionInSI even for inherited units. Retrieve results by the same case UUID.";

    public JsonNode? InputSchema => Schema;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (arguments?["unitConversionSet"] is not JsonNode setNode)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitConversionSet' is required."));
        }

        UnitConversionSet? unitConversionSet;
        try
        {
            unitConversionSet = setNode.Deserialize<UnitConversionSet>(McpToolJsonOptions.Default);
        }
        catch (JsonException jsonEx)
        {
            _logger.LogWarning(jsonEx, "Failed to deserialize unit conversion set payload.");
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitConversionSet' must be a valid unit conversion set payload."));
        }

        if (unitConversionSet is null)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitConversionSet' must be a valid unit conversion set payload."));
        }

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitConversionSetController>(scope.ServiceProvider);

            var actionResult = controller.PostUnitConversionSet(unitConversionSet);

            if (actionResult is StatusCodeResult status && status.StatusCode == StatusCodes.Status409Conflict)
            {
                var id = unitConversionSet.MetaInfo?.ID;
                var idText = id == Guid.Empty ? "unknown" : id.ToString();
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status409Conflict, $"Unit conversion set '{idText}' already exists."));
            }

            if (actionResult is BadRequestResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("The provided unit conversion set payload is invalid."));
            }

            var response = ActionResultToolHelper.CreateResponse(actionResult, "Unit conversion set created.", "Failed to create the unit conversion set.");
            return Task.FromResult(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while creating the unit conversion set."));
        }
    }
}
