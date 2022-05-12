using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace OSDC.UnitConversion.GenerateEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currentFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
            string baseFolder = "";
            do
            {
                baseFolder += "..\\";
                currentFolder = currentFolder.Parent;
            } while (!"UnitConversion".Equals(currentFolder.Name));
            List<PhysicalQuantity> quantities = UnitChoiceSet.AvailableQuantities;
            if (quantities != null)
            {
                GenerateFile(baseFolder + "OSDC.UnitConversion.Conversion\\EnumerationQuantities.cs", typeof(PhysicalQuantity), quantities);
                UnitChoiceSet SI = UnitChoiceSet.SIUnitChoiceSet;
                UnitChoiceSet metric = UnitChoiceSet.MetricUnitChoiceSet;
                UnitChoiceSet imperial = UnitChoiceSet.ImperialUnitChoiceSet;
                UnitChoiceSet us = UnitChoiceSet.USUnitChoiceSet;
            }
            quantities = DrillingUnitChoiceSet.AvailableQuantities;
            if (quantities != null)
            {
                GenerateFile(baseFolder + "OSDC.UnitConversion.Conversion.DrillingEngineering\\EnumerationQuantities.cs", typeof(DrillingPhysicalQuantity), quantities);
                DrillingUnitChoiceSet SI = DrillingUnitChoiceSet.DrillingSIUnitChoiceSet;
                DrillingUnitChoiceSet metric = DrillingUnitChoiceSet.DrillingMetricUnitChoiceSet;
                DrillingUnitChoiceSet imperial = DrillingUnitChoiceSet.DrillingImperialUnitChoiceSet;
                DrillingUnitChoiceSet us = DrillingUnitChoiceSet.DrillingUSUnitChoiceSet;
            }
        }

        static void GenerateFile(string filename, Type typ, List<PhysicalQuantity> quantities)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine();
                if (typ != null && !string.IsNullOrEmpty(typ.Namespace))
                {
                    string namesp = typ.Namespace;
                    string namecl = typ.Name;
                    string parentCl = typ.BaseType.Name;
                    writer.WriteLine("namespace " + namesp);
                    writer.WriteLine("{");
                    writer.WriteLine("  public partial class " + namecl + " : " + parentCl);
                    writer.WriteLine("  {");
                    writer.WriteLine("     public new enum QuantityEnum ");
                    writer.WriteLine("       {");
                    for (int i = 0; i < quantities.Count; i++)
                    {
                        PhysicalQuantity quantity = quantities[i];
                        string quantityName = quantity.Name;
                        string enumName = Convert(quantityName);
                        writer.WriteLine("         " + enumName + ((i < quantities.Count - 1) ? ", " : "") + " // " + quantityName);
                    }
                    writer.WriteLine("       }");
                    writer.WriteLine("    protected static new Dictionary<QuantityEnum, Guid> enumLookUp_ = new Dictionary<QuantityEnum, Guid>()");
                    writer.WriteLine("    {");
                    for (int i = 0; i < quantities.Count; i++)
                    {
                        PhysicalQuantity quantity = quantities[i];
                        string quantityName = quantity.Name;
                        string enumName = Convert(quantityName);
                        writer.WriteLine("         {QuantityEnum." + enumName + ", new Guid(\"" + quantity.ID.ToString() + "\")}" + ((i < quantities.Count - 1) ? ", " : "") + " // " + quantityName);
                    }
                    writer.WriteLine("    };");
                    writer.WriteLine("  }");
                    writer.WriteLine("}");
                    writer.WriteLine();
                }
                foreach (PhysicalQuantity quantity in quantities)
                {
                    typ = quantity.GetType();
                    if (typ != null && !string.IsNullOrEmpty(typ.Namespace))
                    {
                        string namesp = typ.Namespace;
                        string namecl = typ.Name;
                        string parentCl = typ.BaseType.Name;
                        writer.WriteLine("namespace " + namesp);
                        writer.WriteLine("{");
                        writer.WriteLine("  public partial class " + namecl + " : " + parentCl);
                        writer.WriteLine("  {");
                        writer.WriteLine("    public new enum UnitChoicesEnum ");
                        writer.WriteLine("      {");
                        for (int i = 0; i < quantity.UnitChoices.Count; i++)
                        {
                            UnitChoice choice = quantity.UnitChoices[i];
                            string choiceName = choice.UnitName;
                            string enumName = Convert(choiceName);
                            writer.WriteLine("         " + enumName + ((i < quantity.UnitChoices.Count - 1) ? ", " : "") + " // " + choiceName);
                        }
                        writer.WriteLine("      }");
                        writer.WriteLine("    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()");
                        writer.WriteLine("    {");
                        for (int i = 0; i < quantity.UnitChoices.Count; i++)
                        {
                            UnitChoice choice = quantity.UnitChoices[i];
                            string choiceName = choice.UnitName;
                            string enumName = Convert(choiceName);
                            writer.WriteLine("         {UnitChoicesEnum." + enumName + ", new Guid(\"" + choice.ID.ToString() + "\")}" + ((i < quantity.UnitChoices.Count - 1) ? ", " : "") + " // " + choiceName);
                        }
                        writer.WriteLine("    };");
                        writer.WriteLine("    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)");
                        writer.WriteLine("    {");
                        writer.WriteLine("       UnitChoice c = null;");
                        writer.WriteLine("       Guid guid;");
                        writer.WriteLine("       if (enumLookUp_.TryGetValue(choice, out guid))");
                        writer.WriteLine("       {");
                        writer.WriteLine("         c = GetUnitChoice(guid);");
                        writer.WriteLine("       }");
                        writer.WriteLine("       return c;");
                        writer.WriteLine("    }");
                        writer.WriteLine("  }");
                        writer.WriteLine("}");
                    }
                }
            }
        }
        static string Convert(string name)
        {
            string[] tokens = name.Split(' ');
            string convertedName = "";
            foreach (string token in tokens)
            {
                if (!string.IsNullOrEmpty(token))
                {
                    string capitalizedToken = token.Substring(0, 1).ToUpper() + token.Substring(1);
                    capitalizedToken = capitalizedToken.Replace('\'', '_');
                    capitalizedToken = capitalizedToken.Replace('\\', '_');
                    capitalizedToken = capitalizedToken.Replace('/', '_');
                    convertedName += capitalizedToken;
                }
            }
            return convertedName;
        }
    }
}
