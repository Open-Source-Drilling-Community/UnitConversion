using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Nodes;
using OSDC.UnitConversion.Service.Mcp;
using OSDC.UnitConversion.Service.Mcp.Tools;
using NUnit.Framework;

namespace OSDC.UnitConversion.ServiceTest;

public sealed class BoundedDiscoveryTests
{
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
