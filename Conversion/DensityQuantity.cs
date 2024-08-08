using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DensityQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "kilogram per cubic metre";
        public override string SIUnitLabel { get; } = "kg/m³";
        public override double MassDimension { get; } = 1;
        public override double LengthDimension { get; } = -3;
        private static DensityQuantity instance_ = null;

        public static DensityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DensityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Density" };
            ID = new Guid("5754358c-9359-4bb0-8eb4-08602d19c6af");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("8e175ca0-08f6-441d-afcf-a58bbe429abf"),
                    ConversionFactorFromSI = 1.0/Factors.Unit,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "gram per cubic metre",
                    UnitLabel = "g/m³",
                    ID = new Guid("8c5b7fc3-0ade-4e85-9646-71ec5fcb869a"),
                    ConversionFactorFromSI = 1.0/Factors.Milli
                },
                new UnitChoice
                {
                    UnitName = "specific gravity",
                    UnitLabel = "s.g.",
                    ID = new Guid("da94ba95-4494-45af-bf99-31f00031c680"),
                    ConversionFactorFromSI = 1.0/Factors.SpecificGavity4degC
                },
                new UnitChoice
                {
                    UnitName = "gram per cubic centimetre",
                    UnitLabel = "g/cm³",
                    ID = new Guid("64f1b0d8-609f-4ed9-99da-52e18fe97450"),
                    ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi / Factors.Milli
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (UK)",
                    UnitLabel = "ppgUK",
                    ID = new Guid("75ecf787-8778-4d74-afc7-498e117d27bf"),
                    ConversionFactorFromSI = 1.0/Factors.PPGUK
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (US)",
                    UnitLabel = "ppgUS",
                    ID = new Guid("dcc01dd0-4610-42c7-9a55-2ddeb45ef6da"),
                    ConversionFactorFromSI = 1.0/Factors.PPGUS
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic foot",
                    UnitLabel = "lb/ft³",
                    ID = new Guid("f7479c8c-8d03-460b-bfa3-2b68808be935"),
                    ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic inch",
                    UnitLabel = "lb/in³",
                    ID = new Guid("d549658a-76ab-4507-8a9e-e62a5cf47e23"),
                    ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Pound
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic yard",
                    UnitLabel = "lb/yd³",
                    ID = new Guid("8199e187-5283-42cc-891e-b3887c3aa450"),
                    ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard/Factors.Pound
                }
            };
        }
    }
}