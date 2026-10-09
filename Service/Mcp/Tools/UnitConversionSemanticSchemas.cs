using System.Linq;
using System.Text.Json.Nodes;
using OSDC.DotnetLibraries.Drilling.SemanticCatalogue;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

/// <summary>Provider-owned mappings to the published unit-conversion vocabulary.</summary>
internal static class UnitConversionSemanticSchemas
{
    private static JsonObject Metadata(string concept, string? role = null)
    {
        var catalogue = SemanticCatalogue.Default;
        var result = new JsonObject { ["catalogue"] = catalogue.Document.Id, ["catalogueVersion"] = catalogue.Document.Version,
            ["concept"] = concept, ["curationStatus"] = catalogue.Get(concept).Status.ToString(), ["assertionSource"] = "provider-unit-conversion-contract",
            ["requiredContext"] = new JsonArray(catalogue.RequiredContext(concept).Select(x => (JsonNode?)JsonValue.Create(x)).ToArray()) };
        if (role is not null) result["role"] = role;
        if (role is not null) result["requiredContext"] = new JsonArray(catalogue.RequiredContext(concept).Concat(catalogue.RequiredContext(role)).Distinct().Select(x => (JsonNode?)JsonValue.Create(x)).ToArray());
        if (catalogue.SiUnit(concept) is string unit) result["siUnit"] = unit;
        if (catalogue.Quantity(concept) is { } quantity)
            result["physicalQuantity"] = new JsonObject { ["catalogue"] = quantity.Catalogue, ["id"] = quantity.Id.ToString(), ["name"] = quantity.Name, ["siUnitName"] = quantity.SiUnitName };
        return result;
    }
    internal static JsonNode Annotate(string name, JsonNode original, bool input)
    {
        var schema = original.DeepClone();
        string? concept = name switch
        {
            "convert_values" => Concepts.DirectUnitConversion,
            "convert_between_unit_systems" => Concepts.UnitSystemConversion,
            "search_physical_quantities" => Concepts.PhysicalQuantitySearch,
            "get_physical_quantity" => Concepts.PhysicalQuantity,
            "search_documentation" => Concepts.DocumentationSemanticSearch,
            "list_unit_systems" or "get_unit_system" or "create_unit_system" or "replace_unit_system" or "delete_unit_system" => Concepts.UnitSystem,
            _ => null // Unknown tools remain unannotated and cannot become generated semantic leaves.
        };
        if (concept is null) return schema;
        schema["x-osdc-semantic"] = Metadata(concept, OperationRole(name));
        if (schema["properties"] is JsonObject properties)
        {
            void Bind(string field, string meaning, string? role = null)
            { if (properties[field] is JsonObject property) property["x-osdc-semantic"] = Metadata(meaning, role); }
            Bind("physicalQuantityId", Concepts.PhysicalQuantityIdentifier); Bind("physicalQuantity", Concepts.PhysicalQuantityCanonicalName);
            Bind("unitInId", Concepts.UnitChoiceIdentifier, Concepts.SourceReference); Bind("unitOutId", Concepts.UnitChoiceIdentifier, Concepts.TargetReference);
            Bind("unitIn", Concepts.UnitName, Concepts.SourceReference); Bind("unitOut", Concepts.UnitName, Concepts.TargetReference);
            Bind("unitSystemInId", Concepts.ResourceIdentifier, Concepts.SourceReference); Bind("unitSystemOutId", Concepts.ResourceIdentifier, Concepts.TargetReference);
            Bind("unitSystemIn", Concepts.UnitSystem, Concepts.SourceReference); Bind("unitSystemOut", Concepts.UnitSystem, Concepts.TargetReference);
            if (input && properties["values"] is JsonObject values)
            { values["x-osdc-semantic"] = Metadata(Concepts.QuantityConversionBatch); values["items"]!["x-osdc-semantic"] = Metadata(Concepts.UnitConversion, Concepts.UnitConversionInputValue); }
            if (!input)
            {
                Bind("quantity", Concepts.PhysicalQuantity); Bind("inputUnit", Concepts.UnitChoice, Concepts.SourceReference);
                Bind("outputUnit", Concepts.UnitChoice, Concepts.TargetReference); Bind("inputSystem", Concepts.UnitSystem, Concepts.SourceReference);
                Bind("outputSystem", Concepts.UnitSystem, Concepts.TargetReference);
                if (properties["results"] is JsonObject results)
                {
                    results["type"] = "array";
                    results["items"] = new JsonObject { ["type"] = "object", ["properties"] = new JsonObject {
                        ["inputValue"] = Scalar("number", Concepts.UnitConversionInputValue),
                        ["numericValue"] = Scalar("number", Concepts.UnitConversionNumericResult),
                        ["formattedValue"] = Scalar("string", Concepts.UnitConversionFormattedResult) },
                        ["required"] = new JsonArray("inputValue", "numericValue", "formattedValue"), ["additionalProperties"] = true };
                }
            }
        }
        return schema;
    }
    private static string OperationRole(string name) => name switch
    {
        "convert_values" or "convert_between_unit_systems" => Concepts.StatelessEvaluation,
        "search_physical_quantities" or "search_documentation" or "list_unit_systems" => Concepts.ResourceCollectionRetrieval,
        "get_physical_quantity" or "get_unit_system" => Concepts.ResourceRetrieval,
        "create_unit_system" => Concepts.ResourceCreation,
        "replace_unit_system" => Concepts.ResourceReplacement,
        "delete_unit_system" => Concepts.ResourceDeletion,
        _ => Concepts.OperationRole
    };
    private static JsonObject Scalar(string type, string role) => new() { ["type"] = type, ["x-osdc-semantic"] = Metadata(Concepts.UnitConversion, role) };
}
