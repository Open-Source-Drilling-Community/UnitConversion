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

public sealed class PostUnitSystemConversionSetMcpTool : IMcpTool
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<PostUnitSystemConversionSetMcpTool> _logger;

    private static readonly JsonObject Schema = new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["unitSystemConversionSet"] = new JsonObject
            {
                ["type"] = "object",
                ["description"] = "The unit system conversion set payload to create."
            }
        },
        ["required"] = new JsonArray { "unitSystemConversionSet" },
        ["additionalProperties"] = false
    };

    public PostUnitSystemConversionSetMcpTool(IServiceProvider serviceProvider, ILogger<PostUnitSystemConversionSetMcpTool> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public string Name => "post_unit_system_conversion_set";

    public string Description => "Creates a new unit system conversion set by forwarding the payload to the UnitSystemConversionSetController.";

    public JsonNode? InputSchema => Schema;

    public Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (arguments?["unitSystemConversionSet"] is not JsonNode setNode)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitSystemConversionSet' is required."));
        }

        UnitSystemConversionSet? unitSystemConversionSet;
        try
        {
            unitSystemConversionSet = setNode.Deserialize<UnitSystemConversionSet>(McpToolJsonOptions.Default);
        }
        catch (JsonException jsonEx)
        {
            _logger.LogWarning(jsonEx, "Failed to deserialize unit system conversion set payload.");
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitSystemConversionSet' must be a valid unit system conversion set payload."));
        }

        if (unitSystemConversionSet is null)
        {
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("Argument 'unitSystemConversionSet' must be a valid unit system conversion set payload."));
        }

        try
        {
            using var scope = _serviceProvider.CreateScope();
            var controller = ActivatorUtilities.CreateInstance<UnitSystemConversionSetController>(scope.ServiceProvider);

            var actionResult = controller.PostUnitSystemConversionSet(unitSystemConversionSet);

            if (actionResult is StatusCodeResult status && status.StatusCode == StatusCodes.Status409Conflict)
            {
                var id = unitSystemConversionSet.MetaInfo?.ID;
                var idText = id == Guid.Empty ? "unknown" : id.ToString();
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status409Conflict, $"Unit system conversion set '{idText}' already exists."));
            }

            if (actionResult is BadRequestResult)
            {
                return Task.FromResult<JsonNode?>(McpToolResponses.CreateValidationError("The provided unit system conversion set payload is invalid."));
            }

            var response = ActionResultToolHelper.CreateResponse(actionResult, "Unit system conversion set created.", "Failed to create the unit system conversion set.");
            return Task.FromResult(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute tool {ToolName}.", Name);
            return Task.FromResult<JsonNode?>(McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "An unexpected error occurred while creating the unit system conversion set."));
        }
    }
}

