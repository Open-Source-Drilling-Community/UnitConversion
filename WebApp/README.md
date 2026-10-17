# UnitConversion webapp

The UnitConversion webapp serves as a user interface to manage data associated with UnitConversion microservice

It is packaged as a docker container called:

``osdcunitconversionwebappclient``

It is available on dockerhub, under the digiwells organization, at:

https://hub.docker.com/?namespace=digiwells

The API (OpenApi schema) of the microservice is available and testable at:

https://app.digiwells.no/UnitConversion/api/swagger

The webapp itself is available at:

https://app.digiwells.no/UnitConversion/webapp/PhysicalQuantity
https://app.digiwells.no/UnitConversion/webapp/UnitSystem
https://app.digiwells.no/UnitConversion/webapp/UnitConversionSet
https://app.digiwells.no/UnitConversion/webapp/UnitSystemConversionSet

# Funding

The current work has been funded by the [Research Council of Norway](https://www.forskningsradet.no/) and [Industry partners](https://www.digiwells.no/about/board/) in the framework of the cent for research-based innovation [SFI Digiwells (2020-2028)](https://www.digiwells.no/) focused on Digitalization, Drilling Engineering and GeoSteering.

# Contributors

**Eric Cayeux**, *NORCE Energy Modelling and Automation*

**Gilles Pelfrene**, *NORCE Energy Modelling and Automation*

**Andrew Holsaeter**, *NORCE Energy Modelling and Automation*

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


Tables/selectors use light discovery. Editors retrieve the selected complete resource; category options load only for chosen or already assigned definitions. Slot context uses paginated light locations, and rig-history context reads the selected wellbore. Backup selection uses discovery while the dedicated export/restore APIs retain full backup semantics.
