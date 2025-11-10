# UnitConversion microservice

The UnitConversion microservice is packaged as a docker container named:

``osdcunitconversionservice``

It is available on dockerhub, under the digiwells organization, at:

https://hub.docker.com/?namespace=digiwells

The API (OpenApi schema) of the microservice is available and testable at:

https://app.digiwells.no/UnitConversion/api/swagger

The microservice itself is available at:

https://app.digiwells.no/UnitConversion/api/PhysicalQuantity
https://app.digiwells.no/UnitConversion/api/UnitSystem
https://app.digiwells.no/UnitConversion/api/UnitConversionSet
https://app.digiwells.no/UnitConversion/api/UnitSystemConversionSet

## MCP server

Alongside the REST API, the microservice exposes a [Model Context Protocol](https://modelcontextprotocol.io/) server that allows MCP compatible clients to call domain specific tools over HTTP (or WebSocket) transports. The public entry point is:

```
https://app.digiwells.no/UnitConversion/api/mcp
```

When running the service locally the default endpoint is:

```
http://localhost:5002/UnitConversion/api/mcp
```

### Supported tools

| Tool name | Description |
|-----------|-------------|
| `ping` | Returns a `pong` payload to validate connectivity |
| `get_all_physical_quantity_id` / `get_physical_quantity_by_id` / `get_all_physical_quantity` | List or retrieve physical quantities |
| `find_physical_quantity_id_by_name` | Tolerant lookup of a physical quantity identifier by name/synonym |
| `convert_unit_value` | Convert values between two unit choices for a given physical quantity |
| `get_all_unit_system_id` / `get_unit_system_by_id` / `get_all_unit_system_light` / `get_all_unit_system` | List or retrieve unit systems |
| `find_unit_system_id_by_name` | Tolerant lookup of unit system identifiers |
| `post_unit_system`, `put_unit_system_by_id`, `delete_unit_system_by_id` | Manage user-defined unit systems |
| `convert_unit_system_value` | Convert values between two unit systems |
| `search_vector_resources` | Returns the top vector-matched resource URIs plus similarity scores for a textual query |
| `get_all_unit_conversion_set_*`, `get_unit_conversion_set_by_id`, `post_unit_conversion_set`, `put_unit_conversion_set_by_id`, `delete_unit_conversion_set_by_id` | Manage unit conversion sets |
| `get_all_unit_system_conversion_set_*`, `get_unit_system_conversion_set_by_id`, `post_unit_system_conversion_set`, `put_unit_system_conversion_set_by_id`, `delete_unit_system_conversion_set_by_id` | Manage unit system conversion sets |

`search_vector_resources` expects a nomic-ai/nomic-embed-text compatible endpoint (default `http://localhost:8080/embeddings`). Configure `VectorDocumentSearch:Nomic:*` or the `NOMIC_API_KEY` environment variable if the inference server requires authentication, and ensure the vector database was generated with the same model/dimension pair.

### Example request

You can call tools over HTTP by POSTing a JSON-RPC 2.0 request. For example, to convert a value between two unit choices:

```bash
curl -X POST \
  -H "Content-Type: application/json" \
  -H "Accept: application/json" \
  -d '{
        "jsonrpc": "2.0",
        "id": 1,
        "method": "tools.call",
        "params": {
          "name": "convert_unit_value",
          "arguments": {
            "physicalQuantity": "Mud Density",
            "unitIn": "kilogram per cubic metre",
            "unitOut": "pound per gallon",
            "value": 1200
          }
        }
      }' \
  http://localhost:5002/UnitConversion/api/mcp
```

Clients that prefer Server Sent Events (SSE) or WebSockets can switch the transport mode during the MCP handshake—the service accepts both HTTP streaming and WebSocket sessions.

# Funding

The current work has been funded by the [Research Council of Norway](https://www.forskningsradet.no/) and [Industry partners](https://www.digiwells.no/about/board/) in the framework of the cent for research-based innovation [SFI Digiwells (2020-2028)](https://www.digiwells.no/) focused on Digitalization, Drilling Engineering and GeoSteering. 

# Contributors

**Eric Cayeux**, *NORCE Energy Modelling and Automation*

**Gilles Pelfrene**, *NORCE Energy Modelling and Automation*
