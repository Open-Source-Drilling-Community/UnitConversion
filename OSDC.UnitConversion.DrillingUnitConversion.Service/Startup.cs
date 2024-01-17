using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.HttpOverrides;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null; // preserves C# properties naming conventions (no forced lower case applied)
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); // allows to serialize enums as strings (and not integers)
                });
            services.AddSwaggerGen(c =>
            {
                c.CustomSchemaIds(x => x.FullName.Replace("+", ".")); // exposes the types according to their fully qualified names / replacing + by . handles enum types that are improperly referenced in swagger.json otherwise ($ref)
                c.UseAllOfToExtendReferenceSchemas(); // allows to preserve nullable enum types (warning: may have side effects https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/2378)
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var basePath = "/DrillingUnitConversion/api";
            var scheme = "http";

            app.UsePathBase(basePath);

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedProto
            });

            if (env.IsDevelopment())
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
      }
}
