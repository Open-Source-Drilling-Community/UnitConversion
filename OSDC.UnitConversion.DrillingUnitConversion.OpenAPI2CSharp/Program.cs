using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using NJsonSchema;
using NSwag.CodeGeneration.CSharp;
using System.Text;

/// <summary>
/// This program automatically generates POCO (plain old C# objects) classes associated with the model dependencies of the current model.
/// Model dependencies are defined by their OpenApi schema that is usually found at the following endpoint:https://myServer/myMicroservice/api/swagger/v1/swagger.json
/// For each model dependency, the swagger.json is hard copied in the current subfolder json-schemas/
/// This approach is preferred to discovering swagger.json documents automatically online (it is considered a more maintainable approach).
/// C# classes are automatically generated based on NSwag
/// These C# classes can be viewed as automatically generated DTO's (Data Transfer Objects) that are necessary for a microservice to run.
/// More information on the approach followed, assumptions, limitations and other approaches tested: https://github.com/NORCE-DrillingAndWells/DrillingAndWells/wiki/MS-Development#shared-data-model
/// </summary>
class Program
{
    private static bool finished_ = false;
    private static readonly object lock_ = new object();

    private static readonly string VERSION = "1.0.0";
    private static readonly string JSON_BUNDLE = "BundleFromOpenApi.json";
    private static readonly string CSHARP_MODEL = "ModelSharedFromOpenApi.cs";
    private static readonly string MODEL_FOR_SERVICE = "OSDC.UnitConversion.DrillingUnitConversion.ModelShared";
    private static readonly string MODEL_FOR_WEBAPP = "OSDC.UnitConversion.DrillingUnitConversion.ModelSharedForWebApp";
    private static readonly string PREFIX = "OSDC.UnitConversion.DrillingUnitConversion.";

    ////////////////////////////////////////////////
    // PARAMETERS TO CHANGE FOR EACH MICROSERVICE //
    ////////////////////////////////////////////////
    private static readonly string NAMESPACE = "OSDC.UnitConversion.DrillingUnitConversion.ModelShared";
    private static readonly string[] MICROSERVICE_DEPENDENCIES = { "DrillingUnitConversion" };
    private static readonly string[] WEBAPP_DEPENDENCIES = { "DrillingUnitConversion" };

    static async Task Main()
    {
        bool finished = false;
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        do
        {
            Thread.Sleep(100);
            await GenerateDocAndClasses();

            lock (lock_)
            {
                finished = finished_;
            }
        } while (!finished);

        return;
    }


    static async Task GenerateDocAndClasses()
    {
        List<Task<bool>> taskList = new();

        taskList.Add(Task.Run(() => GenerateFromServices(MODEL_FOR_SERVICE, MICROSERVICE_DEPENDENCIES, PREFIX)));
        taskList.Add(Task.Run(() => GenerateFromServices(MODEL_FOR_WEBAPP, WEBAPP_DEPENDENCIES, PREFIX)));
        var result = await Task.WhenAll(taskList);
        bool error = false;
        foreach (var res in result)
            error |= res;
        if (error)
            Console.BackgroundColor = ConsoleColor.Red;

        lock (lock_)
        {
            finished_ = true;
        }
    }

    static async Task<bool> GenerateFromServices(string model, string[] microservices, string prefix)
    {
        PrettyPrint(model, "Starting generation process (OpenApi document and POCO model)...");

        bool error = true;
        var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
        while (directory != null && !directory.GetFiles("*.sln").Any())
        {
            directory = directory.Parent;
        }
        if (directory != null)
        {
            string sourceCodeDir = directory.FullName + "\\" + model;

            if (Directory.Exists(sourceCodeDir))
            {
                if (!File.Exists(sourceCodeDir + "\\" + JSON_BUNDLE) && !File.Exists(sourceCodeDir + "\\" + CSHARP_MODEL))
                {
                    try
                    {
                        // a bundle OpenApi schema (json format) is created to combine OpenApi schema dependencies (Microsoft.OpenApi.Models.OpenApiDocument is used)
                        OpenApiDocument document = new OpenApiDocument
                        {
                            Info = new OpenApiInfo
                            {
                                Title = "Shared Model",
                                Description = "Data model containing model dependencies of the current microservice or webapp",
                                Version = VERSION
                            },
                            Components = new OpenApiComponents
                            {
                                Schemas = new Dictionary<string, OpenApiSchema> { }
                            }
                        };

                        foreach (string msi in microservices)
                        {
                            // reading the hardcopied swagger.json
                            var stream = File.OpenRead(directory.FullName + "\\" + prefix + "OpenApi2CSharp\\json-schemas\\" + msi + ".swagger.json");
                            var doc = new OpenApiStreamReader().Read(stream, out var diagnostic);
                            foreach (var s in doc.Components.Schemas)
                            {
                                document.Components.Schemas.TryAdd(s.Key, s.Value);
                            }
                        }
                        var outputString = document.Serialize(OpenApiSpecVersion.OpenApi3_0, OpenApiFormat.Json);

                        // storing json schema bundle (just for verification)
                        using (StreamWriter writer = new StreamWriter(sourceCodeDir + "\\" + JSON_BUNDLE))
                        {
                            writer.WriteLine(outputString);
                        }

                        PrettyPrint(model, "OpenApi document has been generated successfully!");

                        // C# code generation through NSwag library (NSwag.OpenApiDocument is used)
                        NSwag.OpenApiDocument nswDocument = await NSwag.OpenApiDocument.FromJsonAsync(outputString);

                        var settings = new CSharpClientGeneratorSettings
                        {
                            CSharpGeneratorSettings =
                            {
                                Namespace = NAMESPACE,
                                TypeNameGenerator = new CustomTypeNameGenerator(),
                                JsonLibrary = NJsonSchema.CodeGeneration.CSharp.CSharpJsonLibrary.SystemTextJson
                            }
                        };
                        var generator = new CSharpClientGenerator(nswDocument, settings);
                        var code = generator.GenerateFile();
                        using (StreamWriter writer = new StreamWriter(sourceCodeDir + "\\" + CSHARP_MODEL))
                        {
                            writer.WriteLine(code);
                        }
                        error = false;
                        PrettyPrint(model, "POCO model has been generated successfully!");
                    }
                    catch (HttpRequestException ex)
                    {
                        PrettyPrint(model, "Problem with HttpRequest sent to a microservice", ex.Message);
                    }
                    catch (Exception ex)
                    {
                        PrettyPrint(model, "Problem occurred", ex.Message);
                    }
                }
                else
                {
                    PrettyPrint(model, "File " + sourceCodeDir + "\\" + CSHARP_MODEL + " already exists");
                }
            }
            else
            {
                PrettyPrint(model, "You must create a class library project " + sourceCodeDir + "\\ first!");
            }
        }
        else
        {
            PrettyPrint(model, "Unable to locate current folder");
        }
        return error;
    }

    static void PrettyPrint(string model, string message, string exception = "")
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("> ").
           Append(model).
           Append("\n\t" + message);
        if (exception != "")
            sb.Append("\n\t" + exception);
        Console.WriteLine(sb);
    }

    public static HttpClient SetHttpClient(string host, string hostBasePath)
    {
        HttpClient httpClient = new()
        {
            BaseAddress = new Uri(host + hostBasePath)
        };
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        return httpClient;
    }

    /// <summary>
    /// This custom type generator is designed to format type names: getting rid of namespaces; and getting rid of '+' signs (associated with enums type names)
    /// Note that '+' signs associated with enums should have been filtered out at this stage (Startup.cs::AddSwaggerGen() service settings are tuned to achieve this at the swagger.json stage)
    /// </summary>
    public class CustomTypeNameGenerator : ITypeNameGenerator
    {
        public string Generate(JsonSchema schema, string typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            return typeNameHint.Split('.', '+').Last();
        }
    }

}