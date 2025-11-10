using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OSDC.UnitConversion.Service.Mcp.Resources;

/// <summary>
/// Generates embeddings by calling a nomic-ai/nomic-embed-text compatible endpoint (e.g., Hugging Face Text Embeddings Inference).
/// </summary>
internal sealed class NomicEmbeddingGenerator : ITextEmbeddingGenerator
{
    private readonly HttpClient _httpClient;
    private readonly VectorDocumentSearchOptions _options;
    private readonly ILogger<NomicEmbeddingGenerator> _logger;

    public NomicEmbeddingGenerator(
        HttpClient httpClient,
        IOptions<VectorDocumentSearchOptions> options,
        ILogger<NomicEmbeddingGenerator> logger)
    {
        ArgumentNullException.ThrowIfNull(httpClient);
        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(logger);

        _httpClient = httpClient;
        _options = options.Value;
        _logger = logger;

        if (_options.Nomic.Timeout > TimeSpan.Zero)
        {
            _httpClient.Timeout = _options.Nomic.Timeout;
        }
    }

    public async Task<float[]> GenerateAsync(string text, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var endpoint = _options.Nomic.Endpoint;
        if (string.IsNullOrWhiteSpace(endpoint))
        {
            throw new InvalidOperationException("VectorDocumentSearch:Nomic:Endpoint must be configured.");
        }

        using var request = new HttpRequestMessage(HttpMethod.Post, endpoint)
        {
            Content = JsonContent.Create(new EmbeddingRequest(_options.EmbeddingModel, text))
        };

        if (TryResolveApiKey(out var apiKey))
        {
            var header = string.IsNullOrWhiteSpace(_options.Nomic.ApiKeyHeader)
                ? "Authorization"
                : _options.Nomic.ApiKeyHeader!;
            var prefix = _options.Nomic.ApiKeyPrefix ?? "Bearer ";
            request.Headers.Add(header, $"{prefix}{apiKey}");
        }

        using var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            var detail = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            _logger.LogError("nomic-embed-text request failed with status {Status}: {Body}", (int)response.StatusCode, detail);
            throw new InvalidOperationException("Embedding provider rejected the request.");
        }

        var payload = await response.Content.ReadFromJsonAsync<EmbeddingResponse>(cancellationToken: cancellationToken).ConfigureAwait(false);
        var embedding = payload?.Data.Count > 0 ? payload.Data[0].Embedding : null;
        if (embedding is null || embedding.Count == 0)
        {
            throw new InvalidOperationException("Embedding provider returned an empty payload.");
        }

        return embedding.ToArray();
    }

    private bool TryResolveApiKey(out string? apiKey)
    {
        apiKey = null;

        if (!string.IsNullOrWhiteSpace(_options.Nomic.ApiKey))
        {
            apiKey = _options.Nomic.ApiKey;
            return true;
        }

        if (!string.IsNullOrWhiteSpace(_options.Nomic.ApiKeyEnvironmentVariable))
        {
            var fromEnv = Environment.GetEnvironmentVariable(_options.Nomic.ApiKeyEnvironmentVariable);
            if (!string.IsNullOrWhiteSpace(fromEnv))
            {
                apiKey = fromEnv;
                return true;
            }
        }

        return false;
    }

    private sealed record EmbeddingRequest(
        [property: JsonPropertyName("model")] string Model,
        [property: JsonPropertyName("input")] string Input);

    private sealed record EmbeddingResponse(
        [property: JsonPropertyName("data")] List<EmbeddingItem> Data);

    private sealed record EmbeddingItem(
        [property: JsonPropertyName("embedding")] List<float> Embedding);
}
