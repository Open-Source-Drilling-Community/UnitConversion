using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class LengthQuantity : BasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "L";
        public override string SIUnitName { get; } = "metre";

        public override string SIUnitSymbol { get; } = "m";
        private static LengthQuantity instance_ = null;

        public override double LengthDimension { get; } = 1;

        public static LengthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new LengthQuantity();
                }
                return instance_;
            }
        }

        protected LengthQuantity() : base()
        {
            Name = "Length";
            ID = new Guid("96058475-80c4-4394-b21a-afd2fb1594c8");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitSymbol = SIUnitSymbol,
                    ID = new Guid("cc442e11-bb28-4e51-9074-87df66050d8a"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "decimeter",
                    UnitSymbol = "dm",
                    ID = new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01"),
                    ConversionFactorFromSI = 10.0
                },
                new UnitChoice
                {
                    UnitName = "centimeter",
                    UnitSymbol = "cm",
                    ID = new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461"),
                    ConversionFactorFromSI = 100.0
                },
                new UnitChoice
                {
                    UnitName = "millimeter",
                    UnitSymbol = "mm",
                    ID = new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25"),
                    ConversionFactorFromSI = 1000.0
                },
                new UnitChoice
                {
                    UnitName = "micrometer",
                    UnitSymbol = "µm",
                    ID = new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f"),
                    ConversionFactorFromSI = 1000000.0
                },
                new UnitChoice
                {
                    UnitName = "nanometer",
                    UnitSymbol = "nm",
                    ID = new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9"),
                    ConversionFactorFromSI = 1000000000.0
                },
                new UnitChoice
                {
                    UnitName = "ångstrøm",
                    UnitSymbol = "Å",
                    ID = new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a"),
                    ConversionFactorFromSI = 10000000000.0
                },
                new UnitChoice
                {
                    UnitName = "picometer",
                    UnitSymbol = "nm",
                    ID = new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e"),
                    ConversionFactorFromSI = 1000000000000.0
                },
                new UnitChoice
                {
                    UnitName = "decameter",
                    UnitSymbol = "dam",
                    ID = new Guid("0ff9e118-e7d5-4ace-b140-eb3383812b21"),
                    ConversionFactorFromSI = 0.1
                },
                new UnitChoice
                {
                    UnitName = "hectometer",
                    UnitSymbol = "hm",
                    ID = new Guid("cb5c81a3-b9da-42b5-a2ea-0509df445d01"),
                    ConversionFactorFromSI = 0.01
                },
                new UnitChoice
                {
                    UnitName = "kilometer",
                    UnitSymbol = "km",
                    ID = new Guid("93aee1b8-653d-4841-b948-10460cb84334"),
                    ConversionFactorFromSI = 0.001
                },
                new UnitChoice
                {
                    UnitName = "astronomical unit",
                    UnitSymbol = "au",
                    ID = new Guid("0471d74c-cc44-45bd-be0a-aaad6c05f0d0"),
                    ConversionFactorFromSI = 1.0/1.495978707e11
                },
                new UnitChoice
                {
                    UnitName = "light year",
                    UnitSymbol = "ly",
                    ID = new Guid("fc43d439-576f-430c-855e-60b28f70856e"),
                    ConversionFactorFromSI = 1.0/9460730472580800.0
                },
                new UnitChoice
                {
                    UnitName = "parsec",
                    UnitSymbol = "pc",
                    ID = new Guid("0565c7e8-11cb-48de-8d7a-d58c89955d0f"),
                    ConversionFactorFromSI = 1.0/30856775814913673.0
                },
                new UnitChoice
                {
                    UnitName = "feet",
                    UnitSymbol = "ft",
                    ID = new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a"),
                    ConversionFactorFromSI = 1.0/0.3048
                },
                new UnitChoice
                {
                    UnitName = "US survey feet",
                    UnitSymbol = "ft",
                    ID = new Guid("eaf5909f-c68e-4346-9517-1dafad48b161"),
                    ConversionFactorFromSI = 1.0/0.304801
                },
                new UnitChoice
                {
                    UnitName = "inch",
                    UnitSymbol = "in",
                    ID = new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919"),
                    ConversionFactorFromSI = 1.0/0.0254
                },
                new UnitChoice
                {
                    UnitName = "yard",
                    UnitSymbol = "yd",
                    ID = new Guid("7b9156e4-7cce-41cf-a251-95412f4d91a5"),
                    ConversionFactorFromSI = 1.0/0.9144
                },
                new UnitChoice
                {
                    UnitName = "fathom",
                    UnitSymbol = "fathom",
                    ID = new Guid("6be602af-ea19-41cc-af7f-8263564c3c3b"),
                    ConversionFactorFromSI = 1.0/1.8288
                },
                new UnitChoice
                {
                    UnitName = "surveyor's chain",
                    UnitSymbol = "chain",
                    ID = new Guid("f101708b-ab63-4f21-ac87-4b5b3615eb30"),
                    ConversionFactorFromSI = 1.0/(22.0*0.9144)
                },
                new UnitChoice
                {
                    UnitName = "mile",
                    UnitSymbol = "mi",
                    ID = new Guid("95736fd3-878b-4d93-9a78-ee6f20619628"),
                    ConversionFactorFromSI = 1.0/1609.344
                },
                new UnitChoice
                {
                    UnitName = "international nautical mile",
                    UnitSymbol = "nmi",
                    ID = new Guid("4c297035-e0cf-4bfe-aa63-d835170e8e25"),
                    ConversionFactorFromSI = 1.0/1852.0
                },
                new UnitChoice
                {
                    UnitName = "UK nautical mile",
                    UnitSymbol = "UK nmi",
                    ID = new Guid("3b7a50d6-dc58-4cd7-9a5b-96dba59eceaa"),
                    ConversionFactorFromSI = 1.0/1853.184
                },
                new UnitChoice
                {
                    UnitName = "scandinavian mile",
                    UnitSymbol = "mil",
                    ID = new Guid("22e6763c-4105-4a4c-9dfe-044256a107d1"),
                    ConversionFactorFromSI = 1.0/10000.0
                },
                new UnitChoice
                {
                    UnitName = "inch/32",
                    UnitSymbol = "in/32",
                    ID = new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f"),
                    ConversionFactorFromSI = 32.0 / 0.0254
                },
                new UnitChoice
                {
                    UnitName = "mil",
                    UnitSymbol = "mil",
                    ID = new Guid("648502a7-47e0-42dc-aacc-2e1789b0f1ce"),
                    ConversionFactorFromSI = 1.0/0.0000254
                },
                new UnitChoice
                {
                    UnitName = "thou",
                    UnitSymbol = "thou",
                    ID = new Guid("2ce1b2d1-8157-4ad5-ae85-5d6c634f5c68"),
                    ConversionFactorFromSI = 1.0/0.0000254
                },
                new UnitChoice
                {
                    UnitName = "hand",
                    UnitSymbol = "hand",
                    ID = new Guid("608205f3-8c52-40f2-9796-a586d1cd62da"),
                    ConversionFactorFromSI = 1.0/0.1016
                },
                new UnitChoice
                {
                    UnitName = "furlong",
                    UnitSymbol = "furlong",
                    ID = new Guid("7ce130d1-8147-409f-99b3-bf22b0aae4cc"),
                    ConversionFactorFromSI = 1.0/201.168
                },
            };
            PostProcess();
        }
    }
}
