using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;
using OSDC.UnitConversion.Service.Mcp;
using OSDC.UnitConversion.Service.Mcp.Prompts;
using OSDC.UnitConversion.Service.Mcp.Resources;
using OSDC.UnitConversion.Service.Mcp.Tools;
using OSDC.UnitConversion.Service;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// registering the manager of SQLite connections through dependency injection
builder.Services.AddSingleton(sp => new SqlConnectionManager(
    $"Data Source={SqlConnectionManager.HOME_DIRECTORY}{SqlConnectionManager.DATABASE_FILENAME}",
    sp.GetRequiredService<ILogger<SqlConnectionManager>>()));

// registering the database cleaner service through dependency injection
builder.Services.AddHostedService(sp => new DatabaseCleanerService(
    sp.GetRequiredService<ILogger<DatabaseCleanerService>>(),
    sp.GetRequiredService<SqlConnectionManager>()));

builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    {
        // preserves C# properties naming conventions (no forced lower case applied)
        options.JsonSerializerOptions.PropertyNamingPolicy = null;

        // allows to serialize enums as strings (and not integers)
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddSwaggerGen(c =>
{
    //// exposes the types according to their fully qualified names / replacing + by . handles enum types that are improperly referenced in swagger.json otherwise ($ref)
    //c.CustomSchemaIds(x => x.Name);
    c.CustomSchemaIds(x => x.FullName!.Replace("+", "."));

    // allows to preserve nullable enum types (warning: may have side effects https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/2378)
    c.UseAllOfToExtendReferenceSchemas();

    // VERY IMPORTANT => Adding this UseOneOfForPolymorphism
    c.UseOneOfForPolymorphism();

    // enableAnnotationsForPolymorphism Very import for having e.g. CasingSection.Hanger not be of type DerivedType1 and instead be the correct type BaseType
    c.EnableAnnotations(enableAnnotationsForInheritance: true, enableAnnotationsForPolymorphism: true);

    // ACTIVATE THE CODE BELOW IF THE MODEL CONTAINS A DERIVEDTYPE THAT DERIVES FROM A BASETYPE (SEE WELLCONCEPTARCHITECTURE)
    // Wire up a schema filter to apply the Discriminator info on the base schema (as per NSwag)
    // BaseType is a generic type from which a DerivedType may inherit from (e.g. in WellConceptArchitecture BaseType=RelativeTo and DerivedType=RelativeToFixedDepth)
    //c.DocumentFilter<PolymorphismDocumentFilter<BaseType>>(); // document filter registers the schemas
    //c.SchemaFilter<PolymorphismSchemaFilter<BaseType>>(); // schema filter sets the schemas (timing is automatically managed)
});

builder.Services.Configure<VectorDocumentDatabaseOptions>(builder.Configuration.GetSection("VectorDocumentDatabase"));
builder.Services.Configure<VectorDocumentSearchOptions>(builder.Configuration.GetSection("VectorDocumentSearch"));
builder.Services.AddSingleton<VectorDocumentConnectionFactory>();
builder.Services.AddSingleton<IVectorDocumentRepository, VectorDocumentRepository>();
builder.Services.AddHttpClient<ITextEmbeddingGenerator, NomicEmbeddingGenerator>();
builder.Services.AddSingleton<VectorDocumentResourceService>();
builder.Services.AddOptions<McpServerHandlers>()
    .Configure<VectorDocumentResourceService>((handlers, resourceService) =>
    {
        handlers.ListResourcesHandler = resourceService.ListResourcesAsync;
        handlers.ReadResourceHandler = resourceService.ReadResourceAsync;
    });

// MCP server registrations
var serverVersion = typeof(SqlConnectionManager).Assembly.GetName().Version?.ToString() ?? "1.0.0";

var mcpBuilder = builder.Services.AddMcpServer(options =>
{
    options.ServerInfo = new Implementation
    {
        Name = "UnitConversionService",
        Version = serverVersion
    };
    options.Capabilities = new ServerCapabilities
    {
        Tools = new ToolsCapability(),
        Resources = new ResourcesCapability(),
        Prompts = new PromptsCapability()
    };
});
mcpBuilder.WithHttpTransport();
mcpBuilder.WithPrompts<UnitConversionPromptCollection>(new JsonSerializerOptions(JsonSerializerDefaults.Web));

builder.Services.AddLegacyMcpTool<PingMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllPhysicalQuantityIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetPhysicalQuantityByIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllPhysicalQuantityMcpTool>();
builder.Services.AddLegacyMcpTool<FindPhysicalQuantityIdByNameMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitSystemIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetUnitSystemByIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitSystemLightMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitSystemMcpTool>();
builder.Services.AddLegacyMcpTool<FindUnitSystemIdByNameMcpTool>();
builder.Services.AddLegacyMcpTool<PostUnitSystemMcpTool>();
builder.Services.AddLegacyMcpTool<PutUnitSystemByIdMcpTool>();
builder.Services.AddLegacyMcpTool<DeleteUnitSystemByIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitConversionSetIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitConversionSetMetaInfoMcpTool>();
builder.Services.AddLegacyMcpTool<GetUnitConversionSetByIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitConversionSetMcpTool>();
builder.Services.AddLegacyMcpTool<PostUnitConversionSetMcpTool>();
builder.Services.AddLegacyMcpTool<PutUnitConversionSetByIdMcpTool>();
builder.Services.AddLegacyMcpTool<DeleteUnitConversionSetByIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitSystemConversionSetIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitSystemConversionSetMetaInfoMcpTool>();
builder.Services.AddLegacyMcpTool<GetUnitSystemConversionSetByIdMcpTool>();
builder.Services.AddLegacyMcpTool<GetAllUnitSystemConversionSetMcpTool>();
builder.Services.AddLegacyMcpTool<PostUnitSystemConversionSetMcpTool>();
builder.Services.AddLegacyMcpTool<PutUnitSystemConversionSetByIdMcpTool>();
builder.Services.AddLegacyMcpTool<DeleteUnitSystemConversionSetByIdMcpTool>();
builder.Services.AddLegacyMcpTool<ConvertUnitValueMcpTool>();
builder.Services.AddLegacyMcpTool<ConvertUnitSystemValueMcpTool>();
builder.Services.AddLegacyMcpTool<SearchVectorDocumentsMcpTool>();

// end MCP server

var app = builder.Build();

var basePath = "/UnitConversion/api";
var scheme = "http";

app.UsePathBase(basePath);

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedProto
});

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSwagger(c =>
{
    c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
    {
        if (httpReq.Headers.ContainsKey("X-Forwarded-Host"))
        {
            //scheme = httpReq.Headers["X-Original-Proto"];
            scheme = "https";
        }
        else
        {
            scheme = httpReq.Scheme;
        }
        swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer { Url = $"{scheme}://{httpReq.Host.Value}{basePath}" } };
    });
});

//app.UseDeveloperExceptionPage(); // useful for debugging complex errors (e.g. Swagger exceptions)

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("v1/swagger.json", "API Version 1");
});

app.UseCors(cors => cors
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .SetIsOriginAllowed(origin => true)
                        .AllowCredentials()
           );

app.MapMcp("/mcp");
app.MapMcpWebSocket("/mcp/ws");
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
