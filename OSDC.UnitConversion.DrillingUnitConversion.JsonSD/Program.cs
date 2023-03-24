using NJsonSchema;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.DrillingUnitConversion.Model;
using System;
using System.IO;

namespace OSDC.UnitConversion.DrillingUnitConversion.JsonSD
{
    internal class Program
    {
        static void Main()
        {
            GenerateJsonSchemas();
        }

        static void GenerateJsonSchemas()
        {
            string rootDir = ".\\";
            bool found = false;
            do
            {
                DirectoryInfo info = Directory.GetParent(rootDir);
                if (info != null && "OSDC.UnitConversion.DrillingUnitConversion.JsonSD".Equals(info.Name))
                {
                    found = true;
                }
                else
                {
                    rootDir += "..\\";
                }
            } while (!found);
            rootDir += "..\\OSDC.UnitConversion.DrillingUnitConversion.Service\\wwwroot\\DrillingUnitConversion\\json-schemas\\";
            var baseData1Schema = JsonSchema.FromType<Tuple<DataUnitConversionSet, DrillingUnitChoiceSet, PhysicalQuantity, QuantityDataConversion>>();
            var baseData1SchemaJson = baseData1Schema.ToJson();
            using StreamWriter writer = new StreamWriter(rootDir + "DataUnitConversionSet.txt");
            writer.WriteLine(baseData1SchemaJson);
        }
    }
}
