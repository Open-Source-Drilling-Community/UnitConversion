using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.ModelShared;

/// <summary>Collects bounded discovery pages. Reference projections are for display/context only;
/// fetch a selected full record before editing or accessing engineering collections.</summary>
public static class DiscoveryClientExtensions
{
    public static async Task<List<PhysicalQuantityLight>> ListPhysicalQuantityLightAsync(this Client client, string? name = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var items = new List<PhysicalQuantityLight>();
        int offset = 0;
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            PhysicalQuantityDiscoveryPage page = await client.DiscoverPhysicalQuantityAsync(offset: offset, limit: 200, name: name, cancellationToken: cancellationToken);
            items.AddRange(page.Items);
            if (page.NextOffset is not int next) return items;
            if (next <= offset) throw new InvalidOperationException("Discovery pagination did not advance.");
            offset = next;
        }
    }

    public static Task<List<PhysicalQuantityLight>> ListPhysicalQuantityLightAsync(this Client client, CancellationToken cancellationToken) =>
        client.ListPhysicalQuantityLightAsync(cancellationToken: cancellationToken, name: null);

    /// <summary>Light fields projected into the existing UI reference type. Never submit these partial references as replacements.</summary>
    public static async Task<List<PhysicalQuantity>> ListPhysicalQuantityReferencesAsync(this Client client, string? name = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var summaries = await client.ListPhysicalQuantityLightAsync(name: name, cancellationToken: cancellationToken);
        var references = summaries.ConvertAll(summary => JsonSerializer.Deserialize<PhysicalQuantity>(JsonSerializer.Serialize(summary))
            ?? throw new JsonException("A discovery reference is null."));
        foreach (var value in references)
        {
            value.UsualNames ??= new List<string> { value.Name };
            value.UnitChoices ??= new List<UnitChoice>();
        }
        return references;
    }

    public static Task<List<PhysicalQuantity>> ListPhysicalQuantityReferencesAsync(this Client client, CancellationToken cancellationToken) =>
        client.ListPhysicalQuantityReferencesAsync(cancellationToken: cancellationToken, name: null);

    /// <summary>Replace one reference with its complete selected record before editing or reading nested data.</summary>
    public static async Task<PhysicalQuantity> LoadPhysicalQuantityDetailsAsync(this Client client, IList<PhysicalQuantity> references, Guid id, CancellationToken cancellationToken = default)
    {
        var value = await client.GetPhysicalQuantityByIdAsync(id, cancellationToken: cancellationToken);
        for (int index = 0; index < references.Count; index++)
            if (DiscoveryIdentifier(references[index]) == id) { references[index] = value; return value; }
        references.Add(value);
        return value;
    }

    public static async Task<List<UnitConversionSetLight>> ListUnitConversionSetLightAsync(this Client client, string? name = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var items = new List<UnitConversionSetLight>();
        int offset = 0;
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            UnitConversionSetDiscoveryPage page = await client.DiscoverUnitConversionSetAsync(offset: offset, limit: 200, name: name, cancellationToken: cancellationToken);
            items.AddRange(page.Items);
            if (page.NextOffset is not int next) return items;
            if (next <= offset) throw new InvalidOperationException("Discovery pagination did not advance.");
            offset = next;
        }
    }

    public static Task<List<UnitConversionSetLight>> ListUnitConversionSetLightAsync(this Client client, CancellationToken cancellationToken) =>
        client.ListUnitConversionSetLightAsync(cancellationToken: cancellationToken, name: null);

    /// <summary>Light fields projected into the existing UI reference type. Never submit these partial references as replacements.</summary>
    public static async Task<List<UnitConversionSet>> ListUnitConversionSetReferencesAsync(this Client client, string? name = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var summaries = await client.ListUnitConversionSetLightAsync(name: name, cancellationToken: cancellationToken);
        return summaries.ConvertAll(summary => JsonSerializer.Deserialize<UnitConversionSet>(JsonSerializer.Serialize(summary))
            ?? throw new JsonException("A discovery reference is null."));
    }

    public static Task<List<UnitConversionSet>> ListUnitConversionSetReferencesAsync(this Client client, CancellationToken cancellationToken) =>
        client.ListUnitConversionSetReferencesAsync(cancellationToken: cancellationToken, name: null);

    /// <summary>Replace one reference with its complete selected record before editing or reading nested data.</summary>
    public static async Task<UnitConversionSet> LoadUnitConversionSetDetailsAsync(this Client client, IList<UnitConversionSet> references, Guid id, CancellationToken cancellationToken = default)
    {
        var value = await client.GetUnitConversionSetByIdAsync(id, cancellationToken: cancellationToken);
        for (int index = 0; index < references.Count; index++)
            if (DiscoveryIdentifier(references[index]) == id) { references[index] = value; return value; }
        references.Add(value);
        return value;
    }

    public static async Task<List<UnitSystemLight>> ListUnitSystemLightAsync(this Client client, string? name = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var items = new List<UnitSystemLight>();
        int offset = 0;
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            UnitSystemDiscoveryPage page = await client.DiscoverUnitSystemAsync(offset: offset, limit: 200, name: name, cancellationToken: cancellationToken);
            items.AddRange(page.Items);
            if (page.NextOffset is not int next) return items;
            if (next <= offset) throw new InvalidOperationException("Discovery pagination did not advance.");
            offset = next;
        }
    }

    public static Task<List<UnitSystemLight>> ListUnitSystemLightAsync(this Client client, CancellationToken cancellationToken) =>
        client.ListUnitSystemLightAsync(cancellationToken: cancellationToken, name: null);

    /// <summary>Light fields projected into the existing UI reference type. Never submit these partial references as replacements.</summary>
    public static async Task<List<UnitSystem>> ListUnitSystemReferencesAsync(this Client client, string? name = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var summaries = await client.ListUnitSystemLightAsync(name: name, cancellationToken: cancellationToken);
        return summaries.ConvertAll(summary => JsonSerializer.Deserialize<UnitSystem>(JsonSerializer.Serialize(summary))
            ?? throw new JsonException("A discovery reference is null."));
    }

    public static Task<List<UnitSystem>> ListUnitSystemReferencesAsync(this Client client, CancellationToken cancellationToken) =>
        client.ListUnitSystemReferencesAsync(cancellationToken: cancellationToken, name: null);

    /// <summary>Replace one reference with its complete selected record before editing or reading nested data.</summary>
    public static async Task<UnitSystem> LoadUnitSystemDetailsAsync(this Client client, IList<UnitSystem> references, Guid id, CancellationToken cancellationToken = default)
    {
        var value = await client.GetUnitSystemByIdAsync(id, cancellationToken: cancellationToken);
        for (int index = 0; index < references.Count; index++)
            if (DiscoveryIdentifier(references[index]) == id) { references[index] = value; return value; }
        references.Add(value);
        return value;
    }

    public static async Task<List<UnitSystemConversionSetLight>> ListUnitSystemConversionSetLightAsync(this Client client, string? name = null, System.Guid? unitSystemInId = null, System.Guid? unitSystemOutId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var items = new List<UnitSystemConversionSetLight>();
        int offset = 0;
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            UnitSystemConversionSetDiscoveryPage page = await client.DiscoverUnitSystemConversionSetAsync(offset: offset, limit: 200, name: name, unitSystemInId: unitSystemInId, unitSystemOutId: unitSystemOutId, cancellationToken: cancellationToken);
            items.AddRange(page.Items);
            if (page.NextOffset is not int next) return items;
            if (next <= offset) throw new InvalidOperationException("Discovery pagination did not advance.");
            offset = next;
        }
    }

    public static Task<List<UnitSystemConversionSetLight>> ListUnitSystemConversionSetLightAsync(this Client client, CancellationToken cancellationToken) =>
        client.ListUnitSystemConversionSetLightAsync(cancellationToken: cancellationToken, name: null);

    /// <summary>Light fields projected into the existing UI reference type. Never submit these partial references as replacements.</summary>
    public static async Task<List<UnitSystemConversionSet>> ListUnitSystemConversionSetReferencesAsync(this Client client, string? name = null, System.Guid? unitSystemInId = null, System.Guid? unitSystemOutId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var summaries = await client.ListUnitSystemConversionSetLightAsync(name: name, unitSystemInId: unitSystemInId, unitSystemOutId: unitSystemOutId, cancellationToken: cancellationToken);
        return summaries.ConvertAll(summary => JsonSerializer.Deserialize<UnitSystemConversionSet>(JsonSerializer.Serialize(summary))
            ?? throw new JsonException("A discovery reference is null."));
    }

    public static Task<List<UnitSystemConversionSet>> ListUnitSystemConversionSetReferencesAsync(this Client client, CancellationToken cancellationToken) =>
        client.ListUnitSystemConversionSetReferencesAsync(cancellationToken: cancellationToken, name: null);

    /// <summary>Replace one reference with its complete selected record before editing or reading nested data.</summary>
    public static async Task<UnitSystemConversionSet> LoadUnitSystemConversionSetDetailsAsync(this Client client, IList<UnitSystemConversionSet> references, Guid id, CancellationToken cancellationToken = default)
    {
        var value = await client.GetUnitSystemConversionSetByIdAsync(id, cancellationToken: cancellationToken);
        for (int index = 0; index < references.Count; index++)
            if (DiscoveryIdentifier(references[index]) == id) { references[index] = value; return value; }
        references.Add(value);
        return value;
    }

    private static Guid? DiscoveryIdentifier(object value)
    {
        object metadata = value.GetType().GetProperty("MetaInfo")?.GetValue(value);
        return (metadata?.GetType().GetProperty("ID")?.GetValue(metadata) ?? value.GetType().GetProperty("ID")?.GetValue(value)) as Guid?;
    }
}
