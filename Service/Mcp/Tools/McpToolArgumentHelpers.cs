using System;
using System.Linq;
using System.Text.Json.Nodes;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

internal static class McpToolArgumentHelpers
{
    public static JsonObject CreateEmptySchema() => new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject(),
        ["additionalProperties"] = false
    };

    public static JsonObject CreateGuidSchema(string key, string? description = null)
    {
        return new JsonObject
        {
            ["type"] = "object",
            ["properties"] = new JsonObject
            {
                [key] = new JsonObject
                {
                    ["type"] = "string",
                    ["format"] = "uuid",
                    ["description"] = description ?? "UUID of the persistent resource."
                }
            },
            ["required"] = new JsonArray
            {
                key
            },
            ["additionalProperties"] = false
        };
    }

    public static JsonObject CreateUnitConversionSetSchema(bool includeId = false) =>
        WrapBody("unitConversionSet", CreateUnitConversionSetObjectSchema(), includeId, "unitConversionSet.MetaInfo.ID");

    public static JsonObject CreateUnitSystemConversionSetSchema(bool includeId = false) =>
        WrapBody("unitSystemConversionSet", CreateUnitSystemConversionSetObjectSchema(), includeId, "unitSystemConversionSet.MetaInfo.ID");

    public static JsonObject CreateUnitSystemSchema(bool includeId = false) =>
        WrapBody("unitSystem", CreateUnitSystemObjectSchema(), includeId, "unitSystem.ID");

    private static JsonObject WrapBody(string bodyName, JsonObject bodySchema, bool includeId, string identityPath)
    {
        JsonObject properties = new() { [bodyName] = bodySchema };
        JsonArray required = new(bodyName);
        if (includeId)
        {
            properties["id"] = Uuid($"UUID of the persistent resource to replace; it must equal {identityPath}.");
            required.Add("id");
        }

        return new JsonObject
        {
            ["type"] = "object",
            ["properties"] = properties,
            ["required"] = required,
            ["additionalProperties"] = false
        };
    }

    private static JsonObject CreateUnitConversionSetObjectSchema()
    {
        JsonObject properties = CreatePersistentResourceProperties("unit conversion set");
        properties["QuantityUnitConversionList"] = new JsonObject
        {
            ["type"] = "array",
            ["minItems"] = 1,
            ["description"] = "Conversions grouped by physical quantity and explicit source/target unit choices.",
            ["items"] = new JsonObject
            {
                ["type"] = "object",
                ["properties"] = new JsonObject
                {
                    ["QuantityID"] = Uuid("UUID of the physical quantity. Discover it with find_physical_quantity_id_by_name or a physical-quantity retrieval tool."),
                    ["UnitChoiceIDIn"] = Uuid("UUID of the source unit choice belonging to QuantityID."),
                    ["UnitChoiceIDOut"] = Uuid("UUID of the target unit choice belonging to QuantityID."),
                    ["ValueConversionList"] = CreateValueConversionListSchema()
                },
                ["required"] = new JsonArray("QuantityID", "UnitChoiceIDIn", "UnitChoiceIDOut", "ValueConversionList"),
                ["additionalProperties"] = false
            }
        };
        return ResourceObject("Persistent batch converting values between explicit unit choices. Creation calculates DataOut and DataOutString before storing the case.", properties, "MetaInfo", "QuantityUnitConversionList");
    }

    private static JsonObject CreateUnitSystemConversionSetObjectSchema()
    {
        JsonObject properties = CreatePersistentResourceProperties("unit-system conversion set");
        properties["UnitSystemInID"] = Uuid("UUID of the source unit system. Its choice for each QuantityID defines the input unit.");
        properties["UnitSystemOutID"] = Uuid("UUID of the target unit system. Its choice for each QuantityID defines the output unit.");
        properties["QuantityConversionList"] = new JsonObject
        {
            ["type"] = "array",
            ["minItems"] = 1,
            ["description"] = "Values grouped by physical quantity; unit choices are resolved from UnitSystemInID and UnitSystemOutID.",
            ["items"] = new JsonObject
            {
                ["type"] = "object",
                ["properties"] = new JsonObject
                {
                    ["QuantityID"] = Uuid("UUID of a physical quantity mapped by both selected unit systems."),
                    ["ValueConversionList"] = CreateValueConversionListSchema()
                },
                ["required"] = new JsonArray("QuantityID", "ValueConversionList"),
                ["additionalProperties"] = false
            }
        };
        return ResourceObject("Persistent batch converting values between two unit systems. Creation calculates DataOut and DataOutString before storing the case.", properties, "MetaInfo", "UnitSystemInID", "UnitSystemOutID", "QuantityConversionList");
    }

    private static JsonObject CreateUnitSystemObjectSchema() => new()
    {
        ["type"] = "object",
        ["description"] = "A named mapping from physical-quantity UUIDs to unit-choice UUIDs.",
        ["properties"] = new JsonObject
        {
            ["ID"] = Uuid("Stable caller-assigned unit-system UUID."),
            ["Name"] = NullableString("Human-readable unit-system name, for example SI, Metric, Imperial, or a custom name."),
            ["Description"] = NullableString("Human-readable purpose and conventions of the unit system."),
            ["IsDefault"] = new JsonObject { ["type"] = "boolean", ["description"] = "Whether this is a built-in/default unit system." },
            ["IsSI"] = new JsonObject { ["type"] = "boolean", ["description"] = "Whether every mapped choice is the SI choice for its physical quantity." },
            ["Choices"] = new JsonObject
            {
                ["type"] = "object",
                ["description"] = "Map whose property names are physical-quantity UUID strings and values are unit-choice UUID strings. Each choice must belong to its quantity.",
                ["additionalProperties"] = new JsonObject { ["type"] = "string", ["format"] = "uuid" }
            }
        },
        ["required"] = new JsonArray("ID"),
        ["additionalProperties"] = false
    };

    private static JsonObject CreateValueConversionListSchema() => new()
    {
        ["type"] = "array",
        ["minItems"] = 1,
        ["description"] = "Numeric values to convert. Submit DataIn; DataOut and DataOutString are calculated by the service.",
        ["items"] = new JsonObject
        {
            ["type"] = "object",
            ["properties"] = new JsonObject
            {
                ["DataIn"] = new JsonObject { ["type"] = "number", ["description"] = "Finite input value expressed in the selected source unit." },
                ["DataOut"] = NullableNumber("Calculated numeric value in the selected target unit. Omit it when submitting a new case."),
                ["DataOutString"] = new JsonObject { ["type"] = new JsonArray("string", "null"), ["description"] = "Calculated target value formatted using the quantity's meaningful SI precision. Omit it on input." }
            },
            ["required"] = new JsonArray("DataIn"),
            ["additionalProperties"] = false
        }
    };

    private static JsonObject CreatePersistentResourceProperties(string resourceName) => new()
    {
        ["MetaInfo"] = new JsonObject
        {
            ["type"] = "object",
            ["description"] = $"Identity and optional HTTP location metadata for the {resourceName}.",
            ["properties"] = new JsonObject { ["ID"] = Uuid("Stable caller-assigned resource UUID.") },
            ["required"] = new JsonArray("ID"),
            ["additionalProperties"] = true
        },
        ["Name"] = NullableString("Human-readable resource name."),
        ["Description"] = NullableString("Human-readable purpose or provenance."),
        ["CreationDate"] = NullableDateTime("UTC creation timestamp."),
        ["LastModificationDate"] = NullableDateTime("UTC timestamp of the latest modification.")
    };

    private static JsonObject ResourceObject(string description, JsonObject properties, params string[] required) => new()
    {
        ["type"] = "object",
        ["description"] = description,
        ["properties"] = properties,
        ["required"] = new JsonArray(required.Select(value => (JsonNode?)value).ToArray()),
        ["additionalProperties"] = false
    };

    private static JsonObject Uuid(string description) => new() { ["type"] = "string", ["format"] = "uuid", ["description"] = description };
    private static JsonObject NullableString(string description) => new() { ["type"] = new JsonArray("string", "null"), ["description"] = description };
    private static JsonObject NullableDateTime(string description) => new() { ["type"] = new JsonArray("string", "null"), ["format"] = "date-time", ["description"] = description };
    private static JsonObject NullableNumber(string description) => new() { ["type"] = new JsonArray("number", "null"), ["description"] = description };

    public static bool TryParseGuid(JsonObject? arguments, string key, out Guid value, out JsonNode? error)
    {
        value = Guid.Empty;
        error = null;

        var node = arguments?[key];
        if (node is null)
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' is required.");
            return false;
        }

        if (!Guid.TryParse(node.ToString(), out value))
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' must be a valid UUID.");
            return false;
        }

        return true;
    }

    public static bool TryParseDouble(JsonObject? arguments, string key, out double value, out JsonNode? error)
    {
        value = 0d;
        error = null;

        var node = arguments?[key];
        if (node is null)
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' is required.");
            return false;
        }

        try
        {
            value = node.GetValue<double>();
        }
        catch (Exception ex) when (ex is InvalidOperationException or FormatException)
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' must be a number.");
            return false;
        }

        if (double.IsNaN(value) || double.IsInfinity(value))
        {
            error = McpToolResponses.CreateValidationError($"Argument '{key}' must be a finite number.");
            return false;
        }

        return true;
    }
}
