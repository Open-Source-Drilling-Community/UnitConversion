using System.Text.Json.Nodes;

namespace NORCE.Drilling.UnitConversion.Service.Mcp;

public sealed record McpHandshake(
    string ProtocolVersion,
    string? ClientName,
    string? ClientVersion,
    string? SessionId,
    JsonObject? Capabilities);
