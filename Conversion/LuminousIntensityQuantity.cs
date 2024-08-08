using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class LuminousIntensityQuantity : SymbolizedBasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "J";
        public override string SIUnitName { get; } = "candela";

        public override string SIUnitLabel { get; } = "cd";

        public override double LuminousIntensityDimension { get; } = 1;

        private static LuminousIntensityQuantity instance_ = null;

        public static LuminousIntensityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new LuminousIntensityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public LuminousIntensityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Luminous Intensity" };
            ID = new Guid("fd02d171-cd96-4a41-84cc-431b50ba879b");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("28411995-11f2-4967-92ed-5077237f17e1"),
                    ConversionFactorFromSI = 1.0/Factors.Unit,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "lumen per steradian",
                    UnitLabel = "lm/st",
                    ID = new Guid("5683bf23-cd97-4141-9bf4-62a43750ceda"),
                    ConversionFactorFromSI = 1.0/Factors.Unit
                },
                new UnitChoice
                {
                    UnitName = "millicandela",
                    UnitLabel = "mcd",
                    ID = new Guid("b722e2e1-bcc4-4d6c-ad47-dfd24bb66543"),
                    ConversionFactorFromSI = 1.0/Factors.Milli
                },
                new UnitChoice
                {
                    UnitName = "kilocandela",
                    UnitLabel = "kcd",
                    ID = new Guid("f1159794-14ab-49bb-80de-0164c8172c1f"),
                    ConversionFactorFromSI = 1.0/Factors.Kilo
                },
                new UnitChoice
                {
                    UnitName = "hefnerkerze",
                    UnitLabel = "hefnerkerze",
                    ID = new Guid("8059d89c-1ed5-43d3-a9dc-a11de6cd0f8d"),
                    ConversionFactorFromSI = 1.0/Factors.Hefnerkerze
                },
                new UnitChoice
                {
                    UnitName = "international candle",
                    UnitLabel = "int. candle",
                    ID = new Guid("fa25c6d3-c832-42a1-8490-c31131378ee2"),
                    ConversionFactorFromSI = 1.0/Factors.InternationalCandle
                },
                new UnitChoice
                {
                    UnitName = "decimal candle",
                    UnitLabel = "dec. candle",
                    ID = new Guid("a07a3c15-4679-4a6a-a79b-64fe27fa5799"),
                    ConversionFactorFromSI = 1.0 / Factors.Unit
                },
                new UnitChoice
                {
                    UnitName = "berliner lichteinheit",
                    UnitLabel = "berliner lichteinheit",
                    ID = new Guid("ffd07aaa-486b-495d-bb63-a93d122c35e4"),
                    ConversionFactorFromSI = 1.0/ Factors.Hefnerkerze
                },
                new UnitChoice
                {
                    UnitName = "DVWG candle",
                    UnitLabel = "DVWG candle",
                    ID = new Guid("b2fa4a9a-4c5d-4a31-8002-a7bc9e857af5"),
                    ConversionFactorFromSI = 1.0/Factors.DVGWCandle
                },
                new UnitChoice
                {
                    UnitName = "violle",
                    UnitLabel = "violle",
                    ID = new Guid("1e53e27a-3e4f-4b68-833f-c7a05fdf094e"),
                    ConversionFactorFromSI = 1.0/Factors.Violle
                },
                new UnitChoice
                {
                    UnitName = "carcel",
                    UnitLabel = "carcel",
                    ID = new Guid("70b8902f-8a35-4398-b4ba-1e2b4858264f"),
                    ConversionFactorFromSI = 1.0/Factors.Carcel
                }
            };
        }
    }
}
