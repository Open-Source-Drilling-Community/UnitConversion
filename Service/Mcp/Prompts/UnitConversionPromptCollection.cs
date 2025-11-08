using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;

namespace OSDC.UnitConversion.Service.Mcp.Prompts;

/// <summary>
/// Provides the static prompts that describe how to interact with the UnitConversion MCP server.
/// </summary>
internal sealed class UnitConversionPromptCollection : IEnumerable<McpServerPrompt>
{
    private static readonly JsonSerializerOptions SerializerOptions = new(JsonSerializerDefaults.Web);

    private readonly IReadOnlyList<McpServerPrompt> _prompts;

    public UnitConversionPromptCollection()
    {
        _prompts =
        [
            CreatePrompt(
                "unit-conversion-primer",
                "Unit Conversion Primer",
                "Guidance for pairing the server's REST API, MCP tools, and resource documents.",
                HandlePrimerAsync),
            CreatePrompt(
                "quantity-unit-alignment",
                "Quantity & Unit Alignment",
                "Workflow for mapping informal physical quantities and unit choices to canonical tool parameters.",
                HandleQuantityUnitAlignmentAsync),
            CreatePrompt(
                "quantity-unit-rag",
                "Quantity/Unit RAG Search",
                "Forces a retrieval-augmented search whenever measurements are mentioned so the right documents back each conversion.",
                HandleQuantityUnitRagSearchAsync),
            CreatePrompt(
                "unit-system-report",
                "Unit System Report",
                "Generates a structured set of user messages that summarize a requested unit system id.",
                HandleUnitSystemReportAsync)
        ];
    }

    public IEnumerator<McpServerPrompt> GetEnumerator() => _prompts.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static McpServerPrompt CreatePrompt(
        string name,
        string title,
        string description,
        Func<RequestContext<GetPromptRequestParams>, CancellationToken, ValueTask<GetPromptResult>> handler)
    {
        var options = new McpServerPromptCreateOptions
        {
            Name = name,
            Title = title,
            Description = description,
            SerializerOptions = SerializerOptions
        };

        return McpServerPrompt.Create(handler, options);
    }

    private static ValueTask<GetPromptResult> HandlePrimerAsync(
        RequestContext<GetPromptRequestParams> request,
        CancellationToken cancellationToken)
    {
        var message = new PromptMessage
        {
            Role = Role.User,
            Content = new TextContentBlock
            {
                Text = """
                    You are connected to the Unit Conversion MCP server. Combine the following capabilities:
                    • Legacy conversion tools exposed via MCP allow you to query, create, update, or delete unit systems and conversion sets. Prefer these tools when you need transactional changes.
                    • REST endpoints rooted at /UnitConversion/api provide the same data surface area and are suitable for bulk operations or when the calling platform does not support MCP tools.
                    • Resource documents under resource://unit-conversion/documents/ contain curated explanations, examples, and migration guides. Retrieve them via resources/list + resources/get before attempting speculative conversions.

                    Always cite the exact tool or resource URI that backs your answer. Encourage the caller to provide concrete identifiers (unit system id, conversion set id, etc.) so that every operation is reproducible.
                    """
            }
        };

        var result = new GetPromptResult
        {
            Description = "Explains how to combine the available conversion APIs, MCP tools, and vectorized documents."
        };
        result.Messages.Add(message);
        return ValueTask.FromResult(result);
    }

    private static ValueTask<GetPromptResult> HandleQuantityUnitAlignmentAsync(
        RequestContext<GetPromptRequestParams> request,
        CancellationToken cancellationToken)
    {
        var callerPrompt = ReadArgument(request, "userPrompt");
        var builder = new StringBuilder()
            .AppendLine("You triage free-form conversion requests for the Unit Conversion MCP server.")
            .AppendLine("Apply this workflow whenever a caller lists multiple physical quantities or uses informal unit names:")
            .AppendLine("1. Parse the caller text and extract every physical quantity plus requested unit choices (including slang, abbreviations, and implied units).")
            .AppendLine("2. For each unique quantity, call resources/list under resource://unit-conversion/documents/ until you find metadata where physicalQuantityName or usualNames intersect the extracted tokens. Immediately call resources/get on the promising URIs to keep the Markdown description and Available Units table in context.")
            .AppendLine("3. Use the retrieved metadata to map slang to canonical identifiers. Confirm the id with find_physical_quantity_id_by_name and hydrate details with get_physical_quantity_by_id when needed.")
            .AppendLine("4. Normalize unit names by matching the caller wording to metadata.unitLabel/unitName. When only a unit system is supplied, resolve it with find_unit_system_id_by_name before continuing.")
            .AppendLine("5. Invoke convert_unit_value for direct unit-choice conversions and convert_unit_system_value when switching between unit systems. Run the tools once per quantity/value pair so the audit trail stays explicit.")
            .AppendLine("6. Summarize the outcome per quantity, echoing both the caller wording and the canonical identifiers. Cite every MCP tool call and each resource://unit-conversion/documents/... URI you relied on.")
            .AppendLine("If no document matches a term, ask the caller to clarify instead of guessing.");

        if (!string.IsNullOrWhiteSpace(callerPrompt))
        {
            builder.AppendLine()
                .AppendLine("Caller prompt excerpt:")
                .AppendLine(callerPrompt.Trim());
        }

        var result = new GetPromptResult
        {
            Description = "Guides the model through resolving ambiguous physical quantities and unit choices before running conversions."
        };
        result.Messages.Add(new PromptMessage
        {
            Role = Role.User,
            Content = new TextContentBlock { Text = builder.ToString() }
        });
        return ValueTask.FromResult(result);
    }

    private static ValueTask<GetPromptResult> HandleQuantityUnitRagSearchAsync(
        RequestContext<GetPromptRequestParams> request,
        CancellationToken cancellationToken)
    {
        var callerPrompt = ReadArgument(request, "userPrompt");
        var builder = new StringBuilder()
            .AppendLine("Trigger a retrieval-augmented generation (RAG) sweep whenever a caller mentions physical quantities or unit choices.")
            .AppendLine("1. Scan the caller message for measurement nouns (density, torque, mud weight, flow rate, etc.) or unit tokens (psi, kPa, ppg, bbl/d). The moment you find any, you must gather evidence before calling tools.")
            .AppendLine("2. Turn those tokens into a search list. Iterate resources/list over resource://unit-conversion/documents/ and pick URIs whose name, title, or metadata fields align with the tokens. If your client caches embeddings, run the semantic search first and then confirm hits with resources/get.")
            .AppendLine("3. Fetch at least one physical-quantity document and one unit-choice document for each detected measurement so the Markdown content, synonyms, and formulas stay in context.")
            .AppendLine("4. Capture the canonical ids, unit labels, and conversion formulas from those documents. They become the parameters for find_physical_quantity_id_by_name, convert_unit_value, or convert_unit_system_value.")
            .AppendLine("5. Summarize the retrieved snippets back to the caller and state which MCP tool you will call next. Do not perform conversions until you have cited the supporting resource://unit-conversion/documents/... URIs.")
            .AppendLine("6. If retrieval fails, report which tokens and cursors you tried and ask for clearer wording instead of fabricating units or identifiers.")
            .AppendLine("Always treat the RAG evidence as the source of truth for synonyms and abbreviations.");

        if (!string.IsNullOrWhiteSpace(callerPrompt))
        {
            builder.AppendLine()
                .AppendLine("Caller prompt excerpt:")
                .AppendLine(callerPrompt.Trim());
        }

        var result = new GetPromptResult
        {
            Description = "Forces the model to run a RAG/document lookup when measurements are detected so subsequent tool calls stay grounded."
        };
        result.Messages.Add(new PromptMessage
        {
            Role = Role.User,
            Content = new TextContentBlock { Text = builder.ToString() }
        });
        return ValueTask.FromResult(result);
    }

    private static ValueTask<GetPromptResult> HandleUnitSystemReportAsync(
        RequestContext<GetPromptRequestParams> request,
        CancellationToken cancellationToken)
    {
        var unitSystemId = ReadArgument(request, "unitSystemId") ?? "unknown";
        var fallbackUnit = ReadArgument(request, "focusUnit") ?? "none specified";
        var referenceResource = ReadArgument(request, "resourceUri");

        var builder = new StringBuilder()
            .AppendLine($"Create a concise report about the unit system '{unitSystemId}'.")
            .AppendLine("Fetch the latest values via the MCP tools before composing the answer.")
            .AppendLine("Cover:")
            .AppendLine("1. Canonical name, default status, and whether it is SI-compliant.")
            .AppendLine("2. Important conversion factors or derived units that differ from SI.")
            .AppendLine($"3. Contextual guidance for the focus unit or dimension: {fallbackUnit}.")
            .AppendLine("4. Cite any resource documents used so the result can be reproduced.");

        if (!string.IsNullOrWhiteSpace(referenceResource))
        {
            builder.AppendLine()
                .AppendLine($"Seed context with the resource at {referenceResource} if available.");
        }

        var message = new PromptMessage
        {
            Role = Role.User,
            Content = new TextContentBlock
            {
                Text = builder.ToString()
            }
        };

        var result = new GetPromptResult
        {
            Description = "Generates a structured set of tasks to inspect a unit system by id."
        };
        result.Messages.Add(message);
        return ValueTask.FromResult(result);
    }

    private static string? ReadArgument(RequestContext<GetPromptRequestParams> request, string argumentName)
    {
        if (request.Params?.Arguments is not IReadOnlyDictionary<string, JsonElement> arguments)
        {
            return null;
        }

        if (!arguments.TryGetValue(argumentName, out var value))
        {
            return null;
        }

        return value.ValueKind switch
        {
            JsonValueKind.String => value.GetString(),
            JsonValueKind.Number when value.TryGetDouble(out var number) => number.ToString(CultureInfo.InvariantCulture),
            _ => value.ToString()
        };
    }
}
