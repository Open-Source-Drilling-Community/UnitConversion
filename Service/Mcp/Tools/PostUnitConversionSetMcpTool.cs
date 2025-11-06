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

    private static readonly JsonObject Schema = new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["unitConversionSet"] = new JsonObject
            {
                ["type"] = "object",
                ["description"] = "The unit conversion set payload to create."
            }
        },
        ["required"] = new JsonArray { "unitConversionSet" },
        ["additionalProperties"] = false
    };

    public PostUnitConversionSetMcpTool(IServiceProvider serviceProvider, ILogger<PostUnitConversionSetMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "post_unit_conversion_set";

    public string Description => "Creates a new unit conversion set by forwarding the payload to the UnitConversionSetController.";

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
