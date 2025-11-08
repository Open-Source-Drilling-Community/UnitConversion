using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OSDC.UnitConversion.Service.Mcp.Resources;

internal interface IVectorDocumentRepository
{
    Task<VectorDocumentPage> ListAsync(string? cursor, int pageSize, CancellationToken cancellationToken);

    Task<VectorDocumentRecord?> GetByUriAsync(string uri, CancellationToken cancellationToken);
}

internal sealed record VectorDocumentPage(IReadOnlyList<VectorDocumentRecord> Documents, string? NextCursor)
{
    public static VectorDocumentPage Empty { get; } = new(Array.Empty<VectorDocumentRecord>(), null);
}

internal sealed class VectorDocumentRepository : IVectorDocumentRepository
{
    private const string ColumnId = "Id";
    private const string ColumnUri = "Uri";
    private const string ColumnName = "Name";
    private const string ColumnTitle = "Title";
    private const string ColumnDescription = "Description";
    private const string ColumnMimeType = "MimeType";
    private const string ColumnContent = "Content";
    private const string ColumnMetadata = "MetadataJson";
    private const string ColumnSize = "Size";
    private const string ColumnSortOrder = "SortOrder";

    private readonly VectorDocumentConnectionFactory _connectionFactory;
    private readonly VectorDocumentDatabaseOptions _options;
    private readonly ILogger<VectorDocumentRepository> _logger;
    private readonly string _tableName;

    public VectorDocumentRepository(
        VectorDocumentConnectionFactory connectionFactory,
        IOptions<VectorDocumentDatabaseOptions> options,
        ILogger<VectorDocumentRepository> logger)
    {
        ArgumentNullException.ThrowIfNull(connectionFactory);
        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(logger);

        _connectionFactory = connectionFactory;
        _options = options.Value;
        _logger = logger;
        _tableName = SanitizeIdentifier(_options.DocumentTableName);
    }

    public async Task<VectorDocumentPage> ListAsync(string? cursor, int pageSize, CancellationToken cancellationToken)
    {
        await using var connection = await TryOpenConnectionAsync(cancellationToken).ConfigureAwait(false);
        if (connection is null)
        {
            return VectorDocumentPage.Empty;
        }

        var nextOffset = CursorHelper.Parse(cursor);

        await using var command = connection.CreateCommand();
        command.CommandText = $@"
            SELECT
                {ColumnId},
                {ColumnUri},
                {ColumnName},
                {ColumnTitle},
                {ColumnDescription},
                {ColumnMimeType},
                {ColumnContent},
                {ColumnMetadata},
                {ColumnSize},
                {ColumnSortOrder}
            FROM {_tableName}
            ORDER BY COALESCE({ColumnSortOrder}, {ColumnTitle}, {ColumnName}, {ColumnId})
            LIMIT $limit OFFSET $offset;";
        command.Parameters.AddWithValue("$limit", pageSize);
        command.Parameters.AddWithValue("$offset", nextOffset);

        var documents = new List<VectorDocumentRecord>();
        await using var reader = await command.ExecuteReaderAsync(cancellationToken).ConfigureAwait(false);
        while (await reader.ReadAsync(cancellationToken).ConfigureAwait(false))
        {
            documents.Add(ReadRecord(reader));
        }

        var hasMore = documents.Count == pageSize;
        var nextCursor = hasMore
            ? (nextOffset + documents.Count).ToString(CultureInfo.InvariantCulture)
            : null;

        return new VectorDocumentPage(documents, nextCursor);
    }

    public async Task<VectorDocumentRecord?> GetByUriAsync(string uri, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(uri);

        await using var connection = await TryOpenConnectionAsync(cancellationToken).ConfigureAwait(false);
        if (connection is null)
        {
            return null;
        }

        var documentId = ExtractDocumentId(uri);

        await using var command = connection.CreateCommand();
        command.CommandText = $@"
            SELECT
                {ColumnId},
                {ColumnUri},
                {ColumnName},
                {ColumnTitle},
                {ColumnDescription},
                {ColumnMimeType},
                {ColumnContent},
                {ColumnMetadata},
                {ColumnSize},
                {ColumnSortOrder}
            FROM {_tableName}
            WHERE {ColumnUri} = $uri OR ({ColumnId} = $id AND $id IS NOT NULL)
            LIMIT 1;";
        command.Parameters.AddWithValue("$uri", uri);
        command.Parameters.AddWithValue("$id", (object?)documentId ?? DBNull.Value);

        await using var reader = await command.ExecuteReaderAsync(cancellationToken).ConfigureAwait(false);
        if (await reader.ReadAsync(cancellationToken).ConfigureAwait(false))
        {
            return ReadRecord(reader);
        }

        return null;
    }

    private async Task<SqliteConnection?> TryOpenConnectionAsync(CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(_options.DatabasePath))
        {
            _logger.LogWarning("Vector document database path is not configured.");
            return null;
        }

        if (!File.Exists(_options.DatabasePath))
        {
            _logger.LogInformation("Vector document database was not found at {DatabasePath}. No document resources will be exposed.", _options.DatabasePath);
            return null;
        }

        try
        {
            return await _connectionFactory.CreateOpenConnectionAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to open vector document database at {DatabasePath}.", _options.DatabasePath);
            return null;
        }
    }

    private VectorDocumentRecord ReadRecord(SqliteDataReader reader)
    {
        var id = reader.GetString(reader.GetOrdinal(ColumnId));
        var uri = reader.IsDBNull(reader.GetOrdinal(ColumnUri))
            ? BuildUri(id)
            : reader.GetString(reader.GetOrdinal(ColumnUri));
        var title = reader.IsDBNull(reader.GetOrdinal(ColumnTitle)) ? null : reader.GetString(reader.GetOrdinal(ColumnTitle));
        var name = reader.IsDBNull(reader.GetOrdinal(ColumnName)) ? (title ?? id) : reader.GetString(reader.GetOrdinal(ColumnName));
        var metadata = ParseMetadata(reader, reader.GetOrdinal(ColumnMetadata));

        return new VectorDocumentRecord
        {
            Id = id,
            Uri = uri,
            Name = name,
            Title = title,
            Description = reader.IsDBNull(reader.GetOrdinal(ColumnDescription)) ? null : reader.GetString(reader.GetOrdinal(ColumnDescription)),
            MimeType = reader.IsDBNull(reader.GetOrdinal(ColumnMimeType)) ? null : reader.GetString(reader.GetOrdinal(ColumnMimeType)),
            Content = reader.IsDBNull(reader.GetOrdinal(ColumnContent)) ? string.Empty : reader.GetString(reader.GetOrdinal(ColumnContent)),
            Metadata = metadata,
            Size = reader.IsDBNull(reader.GetOrdinal(ColumnSize)) ? null : reader.GetInt64(reader.GetOrdinal(ColumnSize)),
            SortOrder = reader.IsDBNull(reader.GetOrdinal(ColumnSortOrder)) ? null : reader.GetDouble(reader.GetOrdinal(ColumnSortOrder))
        };
    }

    private static JsonObject? ParseMetadata(SqliteDataReader reader, int ordinal)
    {
        if (ordinal < 0 || reader.IsDBNull(ordinal))
        {
            return null;
        }

        var raw = reader.GetString(ordinal);
        if (string.IsNullOrWhiteSpace(raw))
        {
            return null;
        }

        try
        {
            return JsonNode.Parse(raw)?.AsObject();
        }
        catch (JsonException)
        {
            return null;
        }
    }

    private string BuildUri(string id)
    {
        if (string.IsNullOrEmpty(_options.ResourceUriPrefix))
        {
            return id;
        }

        return _options.ResourceUriPrefix.TrimEnd('/') + "/" + id;
    }

    private string? ExtractDocumentId(string uri)
    {
        if (string.IsNullOrEmpty(_options.ResourceUriPrefix) || string.IsNullOrEmpty(uri))
        {
            return null;
        }

        var prefix = _options.ResourceUriPrefix.TrimEnd('/') + "/";
        if (uri.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
        {
            return uri[prefix.Length..];
        }

        return null;
    }

    private static string SanitizeIdentifier(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("The document table name cannot be empty.", nameof(value));
        }

        foreach (var ch in value)
        {
            if (char.IsLetterOrDigit(ch) || ch == '_')
            {
                continue;
            }

            throw new ArgumentException("The document table name may only contain letters, digits, or underscores.", nameof(value));
        }

        return value;
    }

    private static class CursorHelper
    {
        public static int Parse(string? cursor)
        {
            if (string.IsNullOrWhiteSpace(cursor))
            {
                return 0;
            }

            return int.TryParse(cursor, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) && value > 0
                ? value
                : 0;
        }
    }
}
