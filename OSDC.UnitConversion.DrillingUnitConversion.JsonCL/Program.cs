using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.IO;
using System.Threading;

namespace OSDC.UnitConversion.DrillingUnitConversion.JsonCL
{
    internal class Program
    {
        private static bool finished_ = false;
        private readonly static object lock_ = new object();
        static void Main(string[] args)
        {
            Generate(args);
            bool finished = false;
            do
            {
                Thread.Sleep(100);
                lock (lock_)
                {
                    finished = finished_;
                }
            } while (!finished);
        }

        static async void Generate(string[] args)
        {
            string solutionRootDir = ".\\";
            bool found = false;
            do
            {
                DirectoryInfo info = Directory.GetParent(solutionRootDir);
                if (info != null && "OSDC.UnitConversion.DrillingUnitConversion.JsonCL".Equals(info.Name))
                {
                    found = true;
                }
                else
                {
                    solutionRootDir += "..\\";
                }
            } while (!found);
            string jsonSchemaRootDir = solutionRootDir + "..\\OSDC.UnitConversion.DrillingUnitConversion.Service\\wwwroot\\DrillingUnitConversion\\json-schemas\\";
            string sourceCodeDir = solutionRootDir + "..\\OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared\\";
            if (args != null && args.Length >= 1 && Directory.Exists(args[0]))
            {
                sourceCodeDir = args[0];
            }
            string codeNamespace = "OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared";
            if (args != null && args.Length >= 2 && !string.IsNullOrEmpty(args[1]))
            {
                codeNamespace = args[1];
            }
            JsonSchema pipeModelSchema = await JsonSchema.FromFileAsync(jsonSchemaRootDir + "DataUnitConversionSet.txt");
            CSharpGeneratorSettings settings = new CSharpGeneratorSettings
            {
                Namespace = codeNamespace
            };
            var pipeModelGenerator = new CSharpGenerator(pipeModelSchema, settings);
            var pipeModelFile = pipeModelGenerator.GenerateFile();
            using (StreamWriter writer = new StreamWriter(sourceCodeDir + "DataUnitConversionSetModelFromJson.cs"))
            {
                writer.WriteLine(pipeModelFile);
            }
            lock (lock_)
            {
                finished_ = true;
            }
        }
    }
}
