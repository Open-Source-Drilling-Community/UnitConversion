using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;
using NUnit.Framework;
using OSDC.DotnetLibraries.General.DataManagement;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.Conversion.UnitSystem.DrillingEngineering;
using OSDC.UnitConversion.Model;

namespace OSDC.UnitConversion.ServiceTest;

[TestFixture]
[Category("Integration")]
public class McpToolIntegrationTests
{
    private const string McpEndpoint = "http://localhost:5002/UnitConversion/api/mcp";

    private readonly IReadOnlyDictionary<string, object?> _emptyArgs =
        new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);

    private McpClient? _client;
    private HttpClientTransport? _transport;
    private JsonSerializerOptions? _serializerOptions;

    private BasePhysicalQuantity? _sampleQuantity;
    private UnitChoice? _unitChoiceIn;
    private UnitChoice? _unitChoiceOut;
    private DrillingUnitSystem? _siUnitSystem;
    private DrillingUnitSystem? _metricUnitSystem;

    [OneTimeSetUp]
    public async Task OneTimeSetUp()
    {
        _serializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            PropertyNamingPolicy = null,
            TypeInfoResolver = JsonTypeInfoResolver.Combine(new DefaultJsonTypeInfoResolver())
        };
        _serializerOptions.Converters.Add(new JsonStringEnumConverter());

        var loggerFactory = NullLoggerFactory.Instance;
        var transportOptions = new HttpClientTransportOptions
        {
            Endpoint = new Uri(McpEndpoint),
            TransportMode = HttpTransportMode.AutoDetect, 
            Name = "ServiceTestClient",
            ConnectionTimeout = TimeSpan.FromSeconds(15)
        };

        _transport = new HttpClientTransport(transportOptions, loggerFactory);

        try
        {
            _client = await McpClient.CreateAsync(
                _transport,
                new McpClientOptions
                {
                    ClientInfo = new Implementation { Name = "ServiceTest", Version = "1.0.0" },
                    Capabilities = new ClientCapabilities()
                },
                loggerFactory,
                CancellationToken.None).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            Assert.Ignore($"Unable to connect to MCP server at {McpEndpoint}. {ex.Message}");
        }

        var list = DrillingPhysicalQuantity.AvailablePhysicalQuantities?.Select(q => q as BasePhysicalQuantity);
        _sampleQuantity = DrillingPhysicalQuantity.AvailablePhysicalQuantities?.FirstOrDefault(q => q is not null && q.UnitChoices is { Count: >= 2 });

        if (_sampleQuantity is null)
        {
            Assert.Fail("No physical quantity with at least two unit choices was found.");
        }

        var sampleQuantity = _sampleQuantity!;
        _unitChoiceIn = sampleQuantity.UnitChoices!.First();
        _unitChoiceOut = sampleQuantity.UnitChoices.First(choice => choice.ID != _unitChoiceIn.ID);
        _siUnitSystem = DrillingUnitSystem.SIUnitSystem;
        _metricUnitSystem = DrillingUnitSystem.MetricUnitSystem;

        Assert.Multiple(() =>
        {
            Assert.That(_unitChoiceIn, Is.Not.Null, "Failed to obtain an input unit choice.");
            Assert.That(_unitChoiceOut, Is.Not.Null, "Failed to obtain an output unit choice.");
            Assert.That(_siUnitSystem, Is.Not.Null, "Failed to obtain the SI unit system.");
            Assert.That(_metricUnitSystem, Is.Not.Null, "Failed to obtain the metric unit system.");
        });
    }

    [OneTimeTearDown]
    public async Task OneTimeTearDown()
    {
        if (_client is not null)
        {
            await _client.DisposeAsync().ConfigureAwait(false);
        }

        if (_transport is not null)
        {
            await _transport.DisposeAsync().ConfigureAwait(false);
        }
    }

    [Test]
    public async Task PingTool_ReturnsPong()
    {
        var payload = await CallToolForJsonAsync("ping").ConfigureAwait(false);
        var message = GetString(payload?["message"]);
        Assert.That(message, Is.EqualTo("pong"));
    }

    [Test]
    public async Task PhysicalQuantityTools_WorkAsExpected()
    {
        var quantityIdsNode = await CallToolForJsonAsync("get_all_physical_quantity_id").ConfigureAwait(false);
        var quantityIds = ParseGuidArray(quantityIdsNode);
        Assert.That(quantityIds, Does.Contain(_sampleQuantity!.ID));

        var quantityNode = await CallToolForJsonAsync(
            "get_physical_quantity_by_id",
            CreateArgs(("id", _sampleQuantity.ID))).ConfigureAwait(false);
        var quantity = Deserialize<DrillingPhysicalQuantity>(quantityNode);
        Assert.That(quantity, Is.Not.Null);
        Assert.That(quantity!.ID, Is.EqualTo(_sampleQuantity.ID));

        var allQuantitiesNode = await CallToolForJsonAsync("get_all_physical_quantity").ConfigureAwait(false);
        var allQuantities = Deserialize<List<DrillingPhysicalQuantity>>(allQuantitiesNode);
        Assert.That(allQuantities, Is.Not.Null.And.Not.Empty);
        Assert.That(allQuantities!.Any(q => q.ID == _sampleQuantity.ID), Is.True);

        var lookupNode = await CallToolForJsonAsync(
            "find_physical_quantity_id_by_name",
            CreateArgs(("name", _sampleQuantity.Name))).ConfigureAwait(false);
        var lookupId = GetGuid(lookupNode?["id"]);
        Assert.That(lookupId, Is.EqualTo(_sampleQuantity.ID));

        var convertNode = await CallToolForJsonAsync(
            "convert_unit_value",
            CreateArgs(
                ("physicalQuantity", _sampleQuantity.Name),
                ("unitIn", _unitChoiceIn!.UnitName),
                ("unitOut", _unitChoiceOut!.UnitName),
                ("value", 10d))).ConfigureAwait(false);
        AssertThatStatusOk(convertNode, "convert_unit_value");
        var convertedValue = GetNullableDouble(convertNode?["output"]?["value"]);
        Assert.That(convertedValue, Is.Not.Null);
    }

    [Test]
    public async Task UnitSystemTools_WorkAsExpected()
    {
        var unitSystemIdsNode = await CallToolForJsonAsync("get_all_unit_system_id").ConfigureAwait(false);
        var unitSystemIds = ParseGuidArray(unitSystemIdsNode);
        Assert.That(unitSystemIds, Does.Contain(_siUnitSystem!.ID));

        var siNode = await CallToolForJsonAsync(
            "get_unit_system_by_id",
            CreateArgs(("id", _siUnitSystem.ID))).ConfigureAwait(false);
        var siSystem = Deserialize<DrillingUnitSystem>(siNode);
        Assert.That(siSystem, Is.Not.Null);
        Assert.That(siSystem!.ID, Is.EqualTo(_siUnitSystem.ID));

        var lightNode = await CallToolForJsonAsync("get_all_unit_system_light").ConfigureAwait(false);
        var lightSystems = Deserialize<List<UnitSystemLight>>(lightNode);
        Assert.That(lightSystems, Is.Not.Null.And.Not.Empty);
        Assert.That(lightSystems!.Any(us => us.ID == _siUnitSystem.ID), Is.True);

        var allNode = await CallToolForJsonAsync("get_all_unit_system").ConfigureAwait(false);
        var allSystems = Deserialize<List<DrillingUnitSystem>>(allNode);
        Assert.That(allSystems, Is.Not.Null.And.Not.Empty);
        Assert.That(allSystems!.Any(us => us.ID == _siUnitSystem.ID), Is.True);

        var findNode = await CallToolForJsonAsync(
            "find_unit_system_id_by_name",
            CreateArgs(("name", _siUnitSystem.Name))).ConfigureAwait(false);
        var findId = GetGuid(findNode?["id"]);
        Assert.That(findId, Is.EqualTo(_siUnitSystem.ID));

        var newSystem = CreateUnitSystemTemplate();
        var postNode = await CallToolForJsonAsync(
            "post_unit_system",
            CreateArgs(("unitSystem", newSystem))).ConfigureAwait(false);
        AssertThatStatusOk(postNode, "post_unit_system");

        try
        {
            var createdNode = await CallToolForJsonAsync(
                "get_unit_system_by_id",
                CreateArgs(("id", newSystem.ID))).ConfigureAwait(false);
            var created = Deserialize<DrillingUnitSystem>(createdNode);
            Assert.That(created, Is.Not.Null);
            Assert.That(created!.Name, Is.EqualTo(newSystem.Name));

            newSystem.Description = "Updated MCP test unit system";
            var putNode = await CallToolForJsonAsync(
                "put_unit_system_by_id",
                CreateArgs(("id", newSystem.ID), ("unitSystem", newSystem))).ConfigureAwait(false);
            AssertThatStatusOk(putNode, "put_unit_system_by_id");

            var updatedNode = await CallToolForJsonAsync(
                "get_unit_system_by_id",
                CreateArgs(("id", newSystem.ID))).ConfigureAwait(false);
            var updated = Deserialize<DrillingUnitSystem>(updatedNode);
            Assert.That(updated, Is.Not.Null);
            Assert.That(updated!.Description, Is.EqualTo(newSystem.Description));
        }
        finally
        {
            var deleteNode = await CallToolForJsonAsync(
                "delete_unit_system_by_id",
                CreateArgs(("id", newSystem.ID))).ConfigureAwait(false);
            AssertThatStatusOk(deleteNode, "delete_unit_system_by_id");
        }

        var convertSystemNode = await CallToolForJsonAsync(
            "convert_unit_system_value",
            CreateArgs(
                ("physicalQuantity", _sampleQuantity!.Name),
                ("unitSystemIn", _siUnitSystem.Name),
                ("unitSystemOut", _metricUnitSystem!.Name),
                ("value", 15d))).ConfigureAwait(false);
        AssertThatStatusOk(convertSystemNode, "convert_unit_system_value");
        var convertedSystemValue = GetNullableDouble(convertSystemNode?["outputValue"]);
        Assert.That(convertedSystemValue, Is.Not.Null);
    }

    [Test]
    public async Task UnitConversionSetTools_WorkAsExpected()
    {
        var id = Guid.NewGuid();
        var set = CreateUnitConversionSet(id, 25d);

        var postNode = await CallToolForJsonAsync(
            "post_unit_conversion_set",
            CreateArgs(("unitConversionSet", set))).ConfigureAwait(false);
        AssertThatStatusOk(postNode, "post_unit_conversion_set");

        try
        {
            var idListNode = await CallToolForJsonAsync("get_all_unit_conversion_set_id").ConfigureAwait(false);
            var ids = ParseGuidArray(idListNode);
            Assert.That(ids, Does.Contain(id));

            var metaNode = await CallToolForJsonAsync("get_all_unit_conversion_set_meta_info").ConfigureAwait(false);
            var metaInfos = Deserialize<List<MetaInfo>>(metaNode);
            Assert.That(metaInfos, Is.Not.Null);
            Assert.That(metaInfos!.Any(m => m.ID == id), Is.True);

            var getNode = await CallToolForJsonAsync(
                "get_unit_conversion_set_by_id",
                CreateArgs(("id", id))).ConfigureAwait(false);
            var fetched = Deserialize<UnitConversionSet>(getNode);
            Assert.That(fetched, Is.Not.Null);
            Assert.That(fetched!.MetaInfo?.ID, Is.EqualTo(id));
            Assert.That(fetched.QuantityUnitConversionList, Is.Not.Null.And.Not.Empty);

            var allNode = await CallToolForJsonAsync("get_all_unit_conversion_set").ConfigureAwait(false);
            var allSets = Deserialize<List<UnitConversionSet>>(allNode);
            Assert.That(allSets, Is.Not.Null.And.Not.Empty);

            set.QuantityUnitConversionList![0].ValueConversionList![0].DataIn = 50d;
            var putNode = await CallToolForJsonAsync(
                "put_unit_conversion_set_by_id",
                CreateArgs(("id", id), ("unitConversionSet", set))).ConfigureAwait(false);
            AssertThatStatusOk(putNode, "put_unit_conversion_set_by_id");
        }
        finally
        {
            var deleteNode = await CallToolForJsonAsync(
                "delete_unit_conversion_set_by_id",
                CreateArgs(("id", id))).ConfigureAwait(false);
            AssertThatStatusOk(deleteNode, "delete_unit_conversion_set_by_id");
        }
    }

    [Test]
    public async Task UnitSystemConversionSetTools_WorkAsExpected()
    {
        var id = Guid.NewGuid();
        var conversionSet = CreateUnitSystemConversionSet(id, 12.5d);

        var postNode = await CallToolForJsonAsync(
            "post_unit_system_conversion_set",
            CreateArgs(("unitSystemConversionSet", conversionSet))).ConfigureAwait(false);
        AssertThatStatusOk(postNode, "post_unit_system_conversion_set");

        try
        {
            var idListNode = await CallToolForJsonAsync("get_all_unit_system_conversion_set_id").ConfigureAwait(false);
            var ids = ParseGuidArray(idListNode);
            Assert.That(ids, Does.Contain(id));

            var metaNode = await CallToolForJsonAsync("get_all_unit_system_conversion_set_meta_info").ConfigureAwait(false);
            var metaInfos = Deserialize<List<MetaInfo>>(metaNode);
            Assert.That(metaInfos, Is.Not.Null);
            Assert.That(metaInfos!.Any(m => m.ID == id), Is.True);

            var getNode = await CallToolForJsonAsync(
                "get_unit_system_conversion_set_by_id",
                CreateArgs(("id", id))).ConfigureAwait(false);
            var fetched = Deserialize<UnitSystemConversionSet>(getNode);
            Assert.That(fetched, Is.Not.Null);
            Assert.That(fetched!.MetaInfo?.ID, Is.EqualTo(id));

            var allNode = await CallToolForJsonAsync("get_all_unit_system_conversion_set").ConfigureAwait(false);
            var allSets = Deserialize<List<UnitSystemConversionSet>>(allNode);
            Assert.That(allSets, Is.Not.Null.And.Not.Empty);

            conversionSet.QuantityConversionList![0].ValueConversionList![0].DataIn = 22.2d;
            var putNode = await CallToolForJsonAsync(
                "put_unit_system_conversion_set_by_id",
                CreateArgs(("id", id), ("unitSystemConversionSet", conversionSet))).ConfigureAwait(false);
            AssertThatStatusOk(putNode, "put_unit_system_conversion_set_by_id");
        }
        finally
        {
            var deleteNode = await CallToolForJsonAsync(
                "delete_unit_system_conversion_set_by_id",
                CreateArgs(("id", id))).ConfigureAwait(false);
            AssertThatStatusOk(deleteNode, "delete_unit_system_conversion_set_by_id");
        }
    }

    private async Task<CallToolResult> CallToolAsync(
        string toolName,
        IReadOnlyDictionary<string, object?>? arguments = null,
        CancellationToken cancellationToken = default)
    {
        if (_client is null)
        {
            Assert.Fail("MCP client is not initialised.");
        }

        var args = arguments ?? _emptyArgs;
        var token = cancellationToken == default ? CreateCancellationToken() : cancellationToken;
        return await _client!.CallToolAsync(toolName, args, progress: null, _serializerOptions!, token)
            .ConfigureAwait(false);
    }

    private async Task<JsonNode?> CallToolForJsonAsync(
        string toolName,
        IReadOnlyDictionary<string, object?>? arguments = null,
        CancellationToken cancellationToken = default)
    {
        var result = await CallToolAsync(toolName, arguments, cancellationToken).ConfigureAwait(false);
        if (result.IsError == true)
        {
            Assert.Fail($"Tool '{toolName}' reported an error: {FormatContent(result)}");
        }

        if (result.StructuredContent is null)
        {
            if (result.Content is { Count: > 0 })
            {
                Assert.Fail($"Tool '{toolName}' returned non-structured content: {FormatContent(result)}");
            }

            return null;
        }

        return result.StructuredContent;
    }

    private string FormatContent(CallToolResult result)
    {
        if (result.Content is null || result.Content.Count == 0)
        {
            return "(no content)";
        }

        var options = _serializerOptions ?? new JsonSerializerOptions(JsonSerializerDefaults.Web);
        return string.Join(", ", result.Content.Select(block => JsonSerializer.Serialize(block, options)));
    }

    private static IReadOnlyDictionary<string, object?> CreateArgs(params (string Key, object? Value)[] pairs)
    {
        var dictionary = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
        foreach (var (key, value) in pairs)
        {
            dictionary[key] = value;
        }

        return dictionary;
    }

    private CancellationToken CreateCancellationToken() => new CancellationTokenSource(TimeSpan.FromSeconds(30)).Token;

    private T? Deserialize<T>(JsonNode? node)
    {
        if (node is null)
        {
            return default;
        }

        return node.Deserialize<T>(_serializerOptions!);
    }

    private static List<Guid> ParseGuidArray(JsonNode? node)
    {
        var array = node?.AsArray() ?? throw new AssertionException("Expected a JSON array.");
        var result = new List<Guid>(array.Count);
        foreach (var item in array)
        {
            var guid = GetGuid(item);
            if (guid != Guid.Empty)
            {
                result.Add(guid);
            }
        }

        return result;
    }

    private static Guid GetGuid(JsonNode? node)
    {
        if (node is JsonValue value)
        {
            if (value.TryGetValue<Guid>(out var guid))
            {
                return guid;
            }

            if (value.TryGetValue<string?>(out var text) && Guid.TryParse(text, out guid))
            {
                return guid;
            }
        }

        return Guid.Empty;
    }

    private static double? GetNullableDouble(JsonNode? node)
    {
        if (node is JsonValue value)
        {
            if (value.TryGetValue<double>(out var number))
            {
                return number;
            }

            if (value.TryGetValue<string?>(out var text) && double.TryParse(text, out number))
            {
                return number;
            }
        }

        return null;
    }

    private static string? GetString(JsonNode? node)
    {
        if (node is JsonValue value && value.TryGetValue<string?>(out var text))
        {
            return text;
        }

        return null;
    }

    private void AssertThatStatusOk(JsonNode? node, string toolName)
    {
        if (node is not JsonObject obj)
        {
            return;
        }

        if (!obj.TryGetPropertyValue("status", out var statusNode) || statusNode is null)
        {
            return;
        }

        if (statusNode is JsonValue jsonValue)
        {
            if (jsonValue.TryGetValue<string?>(out var text))
            {
                Assert.That(text, Is.EqualTo("ok").IgnoreCase, $"Tool '{toolName}' responded with status '{text}'.");
                return;
            }

            if (jsonValue.TryGetValue<int>(out var code))
            {
                Assert.That(code, Is.InRange(200, 299), $"Tool '{toolName}' responded with status code {code}.");
            }
        }
    }

    private DrillingUnitSystem CreateUnitSystemTemplate()
    {
        var template = DrillingUnitSystem.MetricUnitSystem;
        return new DrillingUnitSystem
        {
            ID = Guid.NewGuid(),
            Name = $"TestUnitSystem_{Guid.NewGuid():N}",
            Description = "Temporary unit system created by MCP tests",
            IsDefault = false,
            IsSI = false,
            Choices = new Dictionary<string, string>(template.Choices)
        };
    }

    private UnitConversionSet CreateUnitConversionSet(Guid id, double value)
    {
        return new UnitConversionSet
        {
            MetaInfo = new MetaInfo { ID = id },
            Name = $"MCP UnitConversionSet {id}",
            Description = "Temporary conversion set created by MCP tests",
            QuantityUnitConversionList =
            [
                new QuantityUnitConversion
                {
                    QuantityID = _sampleQuantity!.ID,
                    UnitChoiceIDIn = _unitChoiceIn!.ID,
                    UnitChoiceIDOut = _unitChoiceOut!.ID,
                    ValueConversionList =
                    [
                        new ValueConversion { DataIn = value }
                    ]
                }
            ]
        };
    }

    private UnitSystemConversionSet CreateUnitSystemConversionSet(Guid id, double value)
    {
        return new UnitSystemConversionSet
        {
            MetaInfo = new MetaInfo { ID = id },
            Name = $"MCP UnitSystemConversionSet {id}",
            Description = "Temporary unit system conversion set created by MCP tests",
            UnitSystemInID = _siUnitSystem!.ID,
            UnitSystemOutID = _metricUnitSystem!.ID,
            QuantityConversionList =
            [
                new QuantityConversion
                {
                    QuantityID = _sampleQuantity!.ID,
                    ValueConversionList =
                    [
                        new ValueConversion { DataIn = value }
                    ]
                }
            ]
        };
    }
}
