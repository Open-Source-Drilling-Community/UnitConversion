# OSDC.UnitConversion.WebPages

Reusable Razor class library containing the UnitConversion web pages.

## Usage

Reference the package from a Blazor Server web application, configure the UnitConversion service URL, and include the assembly in the application router:

```razor
<Router AppAssembly="@typeof(App).Assembly"
        AdditionalAssemblies="new[] { typeof(OSDC.UnitConversion.WebPages.UnitConversionMain).Assembly }">
```

The host application must register MudBlazor 9.9.0 or a compatible later version and MudBlazor.Markdown services.

```csharp
builder.Services.AddMudServices();
builder.Services.AddMudMarkdownServices();
OSDC.UnitConversion.WebPages.Configuration.UnitConversionHostURL = builder.Configuration["UnitConversionHostURL"];
```

## Pages

- `/UnitConversion`
- `/SingleUnitConversion`
- `/PhysicalQuantity`
- `/Statistics`

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

## Package release 4.0.0

This release packages the current WebPages and generated contracts. Update consuming WebApps to `OSDC.UnitConversion.WebPages` version `4.0.0` after it is available on nuget.org. This is a major update for the bounded light discovery contracts; rebuild consumers together with their updated service clients.

## Trusted NuGet publishing

The `publish-webpages-nuget.yml` workflow authenticates with GitHub OIDC through `NuGet/login@v1`; no long-lived `NUGET_API_KEY` secret is used. Set `NUGET_USER` to the nuget.org profile username as a repository variable (a repository secret is also accepted). The publishing job requests `contents: read` and `id-token: write` and obtains its temporary credential immediately before uploading.

On nuget.org, the package owner must configure a trusted-publishing policy for `Open-Source-Drilling-Community/UnitConversion`, workflow filename `publish-webpages-nuget.yml`, with permission to push new versions of `OSDC.UnitConversion.WebPages`. Leave the policy environment empty because the workflow does not declare a GitHub environment. Trigger the workflow manually with the intended version or push a `webpages-v*` tag. Already published versions are skipped.
