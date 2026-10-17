using System.Net;
using System.Text;
using OSDC.UnitConversion.DrillingRazorMudComponents;

namespace ConversionDrillingRazorMudComponentsUnitTests;

public sealed class UnitSystemDiscoveryClientTests
{
    [Fact]
    public async Task Reads_all_light_pages_instead_of_deserializing_the_envelope_as_an_array()
    {
        var handler = new PageHandler();
        using var client = new HttpClient(handler) { BaseAddress = new Uri("https://unit.test/") };
        var items = await UnitSystemDiscoveryClient.ReadAsync(client, "UnitSystem/");
        Assert.Equal(2, items.Count);
        Assert.Equal(new[] { "/UnitSystem/LightData?offset=0&limit=200", "/UnitSystem/LightData?offset=1&limit=200" }, handler.Requests);
        Assert.Equal(new[] { "First", "Second" }, items.Select(item => item.Name));
    }

    [Fact]
    public async Task Rejects_a_page_that_would_loop_forever()
    {
        using var client = new HttpClient(new PageHandler { InvalidNextOffset = true }) { BaseAddress = new Uri("https://unit.test/") };
        await Assert.ThrowsAsync<System.Text.Json.JsonException>(() => UnitSystemDiscoveryClient.ReadAsync(client, "UnitSystem"));
    }

    private sealed class PageHandler : HttpMessageHandler
    {
        public List<string> Requests { get; } = [];
        public bool InvalidNextOffset { get; init; }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Requests.Add(request.RequestUri!.PathAndQuery);
            bool first = Requests.Count == 1;
            string json = System.Text.Json.JsonSerializer.Serialize(new {
                Items = new[] { new { ID = Guid.NewGuid(), Name = first ? "First" : "Second" } },
                Offset = first ? 0 : 1, Limit = 200, TotalCount = 2,
                NextOffset = first ? (int?)(InvalidNextOffset ? 0 : 1) : null });
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(json, Encoding.UTF8, "application/json") });
        }
    }
}
