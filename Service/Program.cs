using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

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
    c.CustomSchemaIds(x => x.FullName.Replace("+", "."));

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

app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();