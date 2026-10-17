using System.Runtime.CompilerServices;
using System.Text.Json;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

[assembly: InternalsVisibleTo("ConversionDrillingRazorMudComponentsUnitTests")]

namespace OSDC.UnitConversion.DrillingRazorMudComponents;

internal static class UnitSystemDiscoveryClient
{
    internal static async Task<List<UnitSystemLight>> ReadAsync(HttpClient client, string controller)
    {
        List<UnitSystemLight> items = [];
        int offset = 0;
        while (true)
        {
            using var response = await client.GetAsync($"{controller.TrimEnd('/')}/LightData?offset={offset}&limit=200");
            response.EnsureSuccessStatusCode();
            using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
            var page = document.RootElement;
            var records = page.GetProperty("Items").Deserialize<List<UnitSystemLight>>()
                ?? throw new JsonException("Unit-system discovery returned no item collection.");
            if (page.GetProperty("Offset").GetInt32() != offset || records.Count > 200)
                throw new JsonException("Invalid unit-system discovery page.");
            items.AddRange(records);
            var next = page.GetProperty("NextOffset");
            if (next.ValueKind == JsonValueKind.Null) return items;
            int nextOffset = next.GetInt32();
            if (records.Count == 0 || nextOffset != offset + records.Count)
                throw new JsonException("Unit-system discovery did not advance.");
            offset = nextOffset;
        }
    }
}
