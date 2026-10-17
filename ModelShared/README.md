# Shared model for UnitConversion

This nuget package hosts the C# shared model for client applications of the UnitConversion microservice.
Classes and methods are scoped within the namespace: ``OSDC.UnitConversion.ModelShared``

More info on:

https://github.com/Open-Source-Drilling-Community/UnitConversion

The OpenApi schema of the microservice is available and testable at:

https://app.digiwells.no/UnitConversion/swagger

Microservice is available at:

https://app.digiwells.no/UnitConversion/api/PhysicalQuantity
https://app.digiwells.no/UnitConversion/api/UnitSystem
https://app.digiwells.no/UnitConversion/api/UnitConversionSet
https://app.digiwells.no/UnitConversion/api/UnitSystemConversionSet

Web app is available at:

https://app.digiwells.no/UnitConversion/webapp/PhysicalQuantity
https://app.digiwells.no/UnitConversion/webapp/UnitSystem
https://app.digiwells.no/UnitConversion/webapp/UnitConversionSet
https://app.digiwells.no/UnitConversion/webapp/UnitSystemConversionSet

# Contributors

**Eric Cayeux**, *NORCE Energy Modelling and Automation*

**Gilles Pelfrene**, *NORCE Energy Modelling and Automation*

## Bounded light discovery

Resource and catalog discovery returns light pages, with `offset` defaulting to 0 and `limit` defaulting to 50 (allowed range 1–200). Names and relevant resource-reference filters are evaluated on the server. Unbounded full-object `HeavyData` routes and tools, including filtered full-object lists, have been removed. Existing UUID and HTTP-metadata listings remain available; use named light pages for routine discovery.

REST routes and MCP tool names (relative to the service's existing API path base):

- `/PhysicalQuantity/LightData` / `physical_quantity_discover`
- `/UnitConversionSet/LightData` / `unit_conversion_set_discover`
- `/UnitSystem/LightData` / `unit_system_discover`
- `/UnitSystemConversionSet/LightData` / `unit_system_conversion_set_discover`

Pages contain `Items`, `Offset`, `Limit`, `TotalCount`, and `NextOffset`; `NextOffset` is null on the final page. Offset pages are individually consistent reads, not a snapshot spanning requests: concurrent inserts/deletes can change later pages. Refresh discovery when the underlying collection changes. EarthGeodesy's existing search pages instead expose `Items[].Value`, `Offset`, `Limit`, and `TotalCount`.

Single-record reads, result/chunk reads, and deliberate backup/export/restore operations are preserved. Backups can still contain complete resources and should be treated as explicit bulk operations.

This is a breaking REST/MCP contract change: update generated clients, UIs, and external integrations together with the service release. Removed heavy-list names are not compatibility aliases. No persisted engineering shapes, database names, or storage volumes are changed. Historical usage counters are retained; bounded discovery has a separate additive `DiscoveryRequestsPerDay` history in resource services.


Regenerate from the owning service's freshly compiled OpenAPI, refresh dependent schema snapshots, then regenerate consuming clients/DTOs. Do not edit generated C# to restore removed methods. Keep the hand-authored discovery client extensions alongside generated clients: they iterate bounded light pages when a complete name/reference list is needed. Reference projections are partial display/context objects; retrieve a selected complete record before full-replacement writes or engineering calculations. Schema-name normalization must also rewrite discriminator mappings.
