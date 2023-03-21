using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PressureQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "p";
        public override string SIUnitName { get; } = "Pascal";
        public override string SIUnitLabel { get; } = "Pa";
        public override double MassDimension { get; } = 1;
        public override double LengthDimension { get; } = -1;
        public override double TimeDimension { get; } = -2;

        private static PressureQuantity instance_ = null;

        public static PressureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PressureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public PressureQuantity() : base()
        {
            Name = "Pressure";
            ID = new Guid("0f282508-9223-489d-86e6-36307f987045");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "KiloPascal",
          UnitLabel = "KPa",
          ID = new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "Bar",
          UnitLabel = "bar",
          ID = new Guid("0d182739-f8f6-47a6-afcb-71feac973307"),
          ConversionFactorFromSI = 1E-05
        },
         new UnitChoice
        {
          UnitName = "Millibar",
          UnitLabel = "mbar",
          ID = new Guid("43e4fe86-948d-4765-a69d-513ce6dc2b5b"),
          ConversionFactorFromSI = 0.01
        },
         new UnitChoice
        {
          UnitName = "Microbar",
          UnitLabel = "µbar",
          ID = new Guid("7fb9e41f-4748-4457-b8b9-efb73da52d94"),
          ConversionFactorFromSI = 10
        },
       new UnitChoice
        {
          UnitName = "PoundPerSquareInch",
          UnitLabel = "psi",
          ID = new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485"),
          ConversionFactorFromSI = 0.00014503762645158165
        },
        new UnitChoice
        {
          UnitName = "PoundPer100SquareFoot",
          UnitLabel = "lb/100ft²",
          ID = new Guid("e3b95821-d782-4f12-a492-489cbcd6d2a1"),
          ConversionFactorFromSI = 2.0887
        },
         new UnitChoice
        {
          UnitName = "KiloPoundPerSquareInch",
          UnitLabel = "ksi",
          ID = new Guid("a07b5fe5-87e3-4422-afe1-f54de24deeb8"),
          ConversionFactorFromSI = 0.00000014503762645158165
         },
         new UnitChoice
        {
          UnitName = "Standard atmosphere",
          UnitLabel = "atm",
          ID = new Guid("93839971-33f2-43e9-82eb-9f869846f999"),
          ConversionFactorFromSI = 0.000009869232667
         },
         new UnitChoice
        {
          UnitName = "PoundPerSquareFoot",
          UnitLabel = "lb/ft²",
          ID = new Guid("35b28889-c076-4274-b200-cf7732b17aa3"),
          ConversionFactorFromSI = 0.02088543
        },
        new UnitChoice
        {
          UnitName = "MegaPascal",
          UnitLabel = "MPa",
          ID = new Guid("4ef28797-f416-4d97-b36a-711ea848bcc0"),
          ConversionFactorFromSI = 1E-06
        },
        new UnitChoice
        {
          UnitName = "GigaPascal",
          UnitLabel = "GPa",
          ID = new Guid("5c81fb9b-36ad-47b7-9a8e-c999f7fdbfe3"),
          ConversionFactorFromSI = 1E-09
        },
        new UnitChoice
        {
          UnitName = "NewtonPerSquareMeter",
          UnitLabel = "N/m²",
          ID = new Guid("101e92c3-47ab-4d55-8982-93061bc82dea"),
          ConversionFactorFromSI = 1.0
        },
          new UnitChoice
        {
          UnitName = "NewtonPerSquareCentimeter",
          UnitLabel = "N/cm²",
          ID = new Guid("2aa59deb-84d9-41c5-969f-8c8bb9d0c369"),
          ConversionFactorFromSI = 0.0001
        },
         new UnitChoice
        {
          UnitName = "NewtonPerSquareMillimeter",
          UnitLabel = "N/mm²",
          ID = new Guid("e5e9cb06-38a8-4ac2-a8a5-8b74689a31a8"),
          ConversionFactorFromSI = 0.000001
        },
        new UnitChoice
        {
          UnitName = "KiloNewtonPerSquareMeter",
          UnitLabel = "kN/m²",
          ID = new Guid("eaa46677-af1c-4922-bf61-d82f2925534b"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "MegaPoundPerSquareInch",
          UnitLabel = "Mpsi",
          ID = new Guid("bb49de0a-fbf3-4914-b6b9-fc60ab502522"),
          ConversionFactorFromSI = 1.4503762645158166E-10
        },
        new UnitChoice
        {
          UnitName = "Torr",
          UnitLabel = "Torr",
          ID = new Guid("f5afdfee-624e-46fa-b798-0ab1b04d2181"),
          ConversionFactorFromSI = 0.0075006168
        },
        new UnitChoice
        {
          UnitName = "CentimeterMercuryZeroDegC",
          UnitLabel = "cm Hg 0°C",
          ID = new Guid("412602dc-837b-4fab-afc9-3bf4798a9bed"),
          ConversionFactorFromSI = 0.0007500638
        },
        new UnitChoice
        {
          UnitName = "MillimeterMercuryZeroDegC",
          UnitLabel = "mm Hg 0°C",
          ID = new Guid("d91f64fe-4df4-4ddd-943c-d985fbd1659b"),
          ConversionFactorFromSI = 0.007500638
        },
        new UnitChoice
        {
          UnitName = "InchMercury32DegF",
          UnitLabel = "in Hg 32°F",
          ID = new Guid("ab729585-0716-4f24-9502-fcd07ba051bc"),
          ConversionFactorFromSI = 0.0002953006
        },
        new UnitChoice
        {
          UnitName = "InchMercury60DegF",
          UnitLabel = "in Hg 60°F",
          ID = new Guid("83ed97cc-526c-41cc-be78-ea0c86412080"),
          ConversionFactorFromSI = 0.000296134
        },
        new UnitChoice
        {
          UnitName = "CentimeterWater4DegC",
          UnitLabel = "cm Aq 4°C",
          ID = new Guid("a1bac4cc-f37c-4aa5-aec6-ede0b4c52f09"),
          ConversionFactorFromSI = 0.01019744289
        },
        new UnitChoice
        {
          UnitName = "MillimeterWater4DegC",
          UnitLabel = "mm Aq 4°C",
          ID = new Guid("a46b3ef6-fe2a-4ff3-bc2d-7a26661ce45e"),
          ConversionFactorFromSI = 0.1019744289
        },
        new UnitChoice
        {
          UnitName = "InchWater4DegC",
          UnitLabel = "in Aq 4°C",
          ID = new Guid("3015f436-b35d-455c-af23-b9bc4dd857da"),
          ConversionFactorFromSI = 0.0040147421
        },
        new UnitChoice
        {
          UnitName = "FootWater4DegC",
          UnitLabel = "ft Aq 4°C",
          ID = new Guid("52de6721-dfec-4a54-861c-e74da72c8470"),
          ConversionFactorFromSI = 0.0003345623
        },
        new UnitChoice
        {
          UnitName = "InchWater60DegF",
          UnitLabel = "in Aq 60°F",
          ID = new Guid("80b388f3-5036-42cb-8462-91a8bfbc429e"),
          ConversionFactorFromSI = 0.0040185981
        },
        new UnitChoice
        {
          UnitName = "FootWater60DegF",
          UnitLabel = "ft Aq 60°F",
          ID = new Guid("5dc3d224-5a3d-410e-8348-463f802a9b27"),
          ConversionFactorFromSI = 0.0003348832
        },
        new UnitChoice
        {
          UnitName = "DynesPerSquareCentimeter",
          UnitLabel = "dynes/cm²",
          ID = new Guid("04ca59b8-90e1-4903-ac82-ee95cac0ca38"),
          ConversionFactorFromSI = 10.0
        }
      };
        }
    }
}
