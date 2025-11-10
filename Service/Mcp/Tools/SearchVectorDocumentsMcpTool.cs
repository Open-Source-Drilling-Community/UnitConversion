using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OSDC.UnitConversion.Service.Mcp.Resources;

namespace OSDC.UnitConversion.Service.Mcp.Tools;

/// <summary>
/// Exposes a semantic search over the vectorized resource catalog so LLMs can gather relevant document ids.
/// </summary>
public sealed class SearchVectorDocumentsMcpTool : IMcpTool
{
    private static readonly JsonObject Schema = new()
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["query"] = new JsonObject
            {
                ["type"] = "string",
                ["description"] = "Free-form user query describing the needed physical quantities or unit choices."
            },
            ["maxResults"] = new JsonObject
            {
                ["type"] = "integer",
                ["minimum"] = 1,
                ["maximum"] = 200,
                ["description"] = "Optional cap on the number of results to return (defaults to server preference)."
            }
        },
        ["required"] = new JsonArray { "query" },
        ["additionalProperties"] = false
    };

    private readonly IVectorDocumentRepository _repository;
    private readonly ITextEmbeddingGenerator _embeddingGenerator;
    private readonly VectorDocumentSearchOptions _options;
    private readonly ILogger<SearchVectorDocumentsMcpTool> _logger;

    public SearchVectorDocumentsMcpTool(
        IVectorDocumentRepository repository,
        ITextEmbeddingGenerator embeddingGenerator,
        IOptions<VectorDocumentSearchOptions> options,
        ILogger<SearchVectorDocumentsMcpTool> logger)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _embeddingGenerator = embeddingGenerator ?? throw new ArgumentNullException(nameof(embeddingGenerator));
        _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public string Name => "search_vector_resources";

    public string Description => "Returns the top vector-matched resource ids for a query so callers know which documents to fetch.";

    public JsonNode? InputSchema => Schema;

    public async Task<JsonNode?> InvokeAsync(JsonObject? arguments, CancellationToken cancellationToken)
    {
        if (!TryReadQuery(arguments, out var query, out var error))
        {
            return error;
        }

        var maxResults = ReadMaxResults(arguments);

        try
        {
            var embedding = await _embeddingGenerator.GenerateAsync(query, cancellationToken).ConfigureAwait(false);
            if (embedding.Length != _options.EmbeddingDimensions)
            {
                _logger.LogWarning("Generated embedding length {Length} does not match the configured dimensions {Dimensions}.", embedding.Length, _options.EmbeddingDimensions);
            }

            var hits = await _repository.SearchAsync(embedding, maxResults, cancellationToken).ConfigureAwait(false);
            var results = new JsonArray();
            foreach (var hit in hits)
            {
                var node = new JsonObject
                {
                    ["uri"] = hit.Uri,
                    ["id"] = hit.Id,
                    ["score"] = Math.Round(hit.Score, 6)
                };

                if (!string.IsNullOrWhiteSpace(hit.Name))
                {
                    node["name"] = hit.Name;
                }

                if (!string.IsNullOrWhiteSpace(hit.Title))
                {
                    node["title"] = hit.Title;
                }

                results.Add(node);
            }

            return new JsonObject
            {
                ["results"] = results
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to execute {ToolName}.", Name);
            return McpToolResponses.CreateError(StatusCodes.Status500InternalServerError, "Vector search failed. Ensure embeddings are configured correctly.");
        }
    }

    private bool TryReadQuery(JsonObject? arguments, out string query, out JsonNode? error)
    {
        query = string.Empty;
        error = null;

        if (arguments?["query"] is not JsonValue value || value.GetValue<string?>() is not { } raw || string.IsNullOrWhiteSpace(raw))
        {
            error = McpToolResponses.CreateValidationError("Argument 'query' is required and must be a non-empty string.");
            return false;
        }

        query = raw.Trim();
        return true;
    }

    private int ReadMaxResults(JsonObject? arguments)
    {
        if (arguments?["maxResults"] is JsonValue value && value.TryGetValue<int>(out var requested))
        {
            return Math.Clamp(requested, 1, Math.Max(_options.MaxLimit, 1));
        }

        return Math.Clamp(_options.DefaultLimit, 1, Math.Max(_options.MaxLimit, 1));
    }
}
