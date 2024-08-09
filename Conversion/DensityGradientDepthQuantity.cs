using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DensityGradientDepthQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "kilogram per cubic metre per metre";
        public override string SIUnitLabel { get; } = "kg/m³/m";
        public override double MassDimension { get; } = 1;
        public override double LengthDimension { get; } = -4;

        private static DensityGradientDepthQuantity instance_ = null;

        public static DensityGradientDepthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityGradientDepthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DensityGradientDepthQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Density Gradient Depth" };
            ID = new Guid("037e0326-5095-4c82-ba1b-4df594243cda");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = SIUnitName,
                  UnitLabel = SIUnitLabel,
                  ID = new Guid("00707a6a-2e33-4214-9f8c-3e64eaa82ec1"),
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                },
                new UnitChoice
                {
                  UnitName = "specific gravity per metre",
                  UnitLabel = "sg/m",
                  ID = new Guid("07964c1e-b0d5-4785-bee4-8b4b8882b8b2"),
                  ConversionFactorFromSI = Factors.SpecificGavity4degC
                },
                new UnitChoice
                {
                  UnitName = "specific gravity per 10 metre",
                  UnitLabel = "sg/10m",
                  ID = new Guid("4af1c9f0-480c-4e80-a62b-c6b57b486c3f"),
                  ConversionFactorFromSI = Factors.Deca*Factors.SpecificGavity4degC
                },
                new UnitChoice
                {
                  UnitName = "specific gravity per 30 metre",
                  UnitLabel = "sg/30m",
                  ID = new Guid("f8499728-220b-4b2d-94b2-3dc2cdfa6a92"),
                  ConversionFactorFromSI = 3.0*Factors.Deca*Factors.SpecificGavity4degC
                },
                new UnitChoice
                {
                  UnitName = "specific gravity per 100 metre",
                  UnitLabel = "sg/100m",
                  ID = new Guid("af987ef2-c8e5-470a-bc53-b2fff05d2c6a"),
                  ConversionFactorFromSI = Factors.Hecto*Factors.SpecificGavity4degC
                },
                new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per 100 metre",
                  UnitLabel = "g/cm³/100m",
                  ID = new Guid("361f976c-6271-41d2-8da3-6b4009cf5e06"),
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi*Factors.Hecto/Factors.Milli
                },
                new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per foot",
                  UnitLabel = "ppgUK/ft",
                  ID = new Guid("f2e67c73-3706-4c14-b23a-afe474b2ecbe"),
                  ConversionFactorFromSI = Factors.GallonUK*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per 30 foot",
                  UnitLabel = "ppgUK/30ft",
                  ID = new Guid("684acd16-b420-4952-bc42-ffb47044074d"),
                  ConversionFactorFromSI = Factors.GallonUK*30.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per 100 foot",
                  UnitLabel = "ppgUK/100ft",
                  ID = new Guid("f4b6b8a9-c222-4ac9-a6bb-072a9ca7d567"),
                  ConversionFactorFromSI = Factors.GallonUK*100.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per gallon (US) per foot",
                  UnitLabel = "ppgUS/ft",
                  ID = new Guid("56128f8e-f59e-4f30-927b-35acb6ab44b1"),
                  ConversionFactorFromSI = Factors.GallonUS*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per gallon (US) per 30 foot",
                  UnitLabel = "ppgUS/30ft",
                  ID = new Guid("389150f0-4602-4468-bba3-a8eaf1d36ca0"),
                  ConversionFactorFromSI = Factors.GallonUS*30.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per gallon (US) per 100 foot",
                  UnitLabel = "ppgUS/100ft",
                  ID = new Guid("658a9698-d34b-4a56-9ee3-3cf6e46a52a3"),
                  ConversionFactorFromSI = Factors.GallonUS*100.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per 10 metre",
                  UnitLabel = "kg/m³/10m",
                  ID = new Guid("2d0ed7e8-2b80-46ff-9566-bd1429aa3129"),
                  ConversionFactorFromSI = Factors.Deca/Factors.Unit
                },
                new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per 30 metre",
                  UnitLabel = "kg/m³/30m",
                  ID = new Guid("dccaa4b1-cf9f-4075-a9f2-50931e38af01"),
                  ConversionFactorFromSI = 3.0 *Factors.Deca/Factors.Unit
                },
                new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per 100 metre",
                  UnitLabel = "kg/m³/30m",
                  ID = new Guid("ccca234e-8626-4f75-beed-4da4abad1317"),
                  ConversionFactorFromSI = Factors.Hecto/Factors.Unit
                },
                new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per metre",
                  UnitLabel = "g/cm³/m",
                  ID = new Guid("91fe264e-6f5f-4a4d-b7f7-1532810ad5bd"),
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi/Factors.Milli
                },
                new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per 10 metre",
                  UnitLabel = "g/cm³/10m",
                  ID = new Guid("836701f1-1fbd-4ae3-aba8-17a97379272c"),
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi*Factors.Deca/Factors.Milli
                },
                new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per 30 metre",
                  UnitLabel = "g/cm³/30m",
                  ID = new Guid("faaa4f2f-4dd4-419a-a985-ea16c5fc6d49"),
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi*3.0*Factors.Deca/Factors.Milli
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic foot per foot",
                  UnitLabel = "lb/ft³/ft",
                  ID = new Guid("2c75c006-8ab5-475e-87aa-f5b0501b5ad7"),
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic foot per 30 foot",
                  UnitLabel = "lb/ft³/30ft",
                  ID = new Guid("cd7e9b61-06e9-41ca-b1dd-c2dd0b2cce55"),
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot*30.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic foot per 100 foot",
                  UnitLabel = "lb/ft³/100ft",
                  ID = new Guid("bd3c10c7-aa1b-438a-a61d-791f05de5a64"),
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot*100.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic inch per foot",
                  UnitLabel = "lb/in³/ft",
                  ID = new Guid("8997f813-9692-4f1a-b281-42260799f2ab"),
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic inch per 30 foot",
                  UnitLabel = "lb/in³/30ft",
                  ID = new Guid("394876ee-1779-4ac0-a306-ad64fd9b640f"),
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch*30.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic inch per 100 foot",
                  UnitLabel = "lb/in³/100ft",
                  ID = new Guid("11826f55-a121-498c-b03d-e51431f00476"),
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch*100.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic yard per foot",
                  UnitLabel = "lb/yd³/ft",
                  ID = new Guid("09c728a5-da92-4a0c-a5bb-3aa166c2564d"),
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic yard per 30 foot",
                  UnitLabel = "lb/yd³/30ft",
                  ID = new Guid("82a23b2f-56a9-4345-97ec-61e6ec250915"),
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard*30.0*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                  UnitName = "pound per cubic yard per 100 foot",
                  UnitLabel = "lb/yd³/100ft",
                  ID = new Guid("6f82e6f2-2cb8-467f-8baa-6d766056acf7"),
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard*100.0*Factors.Foot/Factors.Pound
                },
            };
        }
    }
}
