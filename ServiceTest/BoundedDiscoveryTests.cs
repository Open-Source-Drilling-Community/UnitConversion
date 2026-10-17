using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Nodes;
using OSDC.UnitConversion.Service.Mcp;
using OSDC.UnitConversion.Service.Mcp.Tools;
using NUnit.Framework;

namespace OSDC.UnitConversion.ServiceTest;

public sealed class BoundedDiscoveryTests
{
    [Test]
    public async Task Physical_quantity_discovery_pages_the_mixed_base_and_drilling_catalog()
    {
        var controller = new OSDC.UnitConversion.Service.Controllers.PhysicalQuantityController(
            Microsoft.Extensions.Logging.Abstractions.NullLogger<OSDC.UnitConversion.Service.Controllers.PhysicalQuantityController>.Instance);
        var response = controller.DiscoverPhysicalQuantity(offset: 0, limit: 2);
        var page = (OSDC.UnitConversion.Model.PhysicalQuantityDiscoveryPage)
            ((Microsoft.AspNetCore.Mvc.OkObjectResult)response.Result!).Value!;
        var ids = new HashSet<Guid>(OSDC.UnitConversion.Conversion.BasePhysicalQuantity.AvailableBasePhysicalQuantities.Select(q => q.ID));
        ids.UnionWith(OSDC.UnitConversion.Conversion.DrillingEngineering.DrillingPhysicalQuantity.AvailablePhysicalQuantities.Select(q => q.ID));
        Assert.That(page.TotalCount, Is.EqualTo(ids.Count));
        Assert.That(page.Items.Select(q => q.ID), Is.EqualTo(ids.OrderBy(id => id.ToString(), StringComparer.Ordinal).Take(2)));
        Assert.That(page.NextOffset, Is.EqualTo(2));

        var services = new ServiceCollection(); services.AddLogging(); services.AddDiscoveryMcpTools();
        using var provider = services.BuildServiceProvider();
        var tool = provider.GetServices<IMcpTool>().Single(t => t.Name == "physical_quantity_discover");
        var result = await tool.InvokeAsync(new JsonObject { ["offset"] = 0, ["limit"] = 2 }, CancellationToken.None);
        Assert.That(result!["status"]!.GetValue<int>(), Is.EqualTo(200));
        Assert.That(result["data"]!["TotalCount"]!.GetValue<int>(), Is.EqualTo(ids.Count));
        Assert.That(result["data"]!["Items"]!.AsArray(), Has.Count.EqualTo(2));
    }

    [Test]
    public async Task Discovery_tools_are_bounded_and_validate_before_storage()
    {
        var services = new ServiceCollection(); services.AddLogging(); services.AddDiscoveryMcpTools();
        using var provider = services.BuildServiceProvider();
        var tools = provider.GetServices<IMcpTool>().ToArray();
        Assert.That(tools, Has.Length.EqualTo(4));
        foreach (var tool in tools)
        {
            Assert.That(tool.InputSchema!["properties"]!["limit"]!["maximum"]!.GetValue<int>(), Is.EqualTo(200));
            Assert.That(tool.OutputSchema!.ToJsonString(), Does.Contain("NextOffset"));
            var result = await tool.InvokeAsync(new JsonObject { ["limit"] = 201 }, CancellationToken.None);
            Assert.That(result!["status"]!.GetValue<int>(), Is.EqualTo(400));
        }
    }
}
