using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DensityQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "KilogramPerCubicMetre";
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
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "GramPerCubicMetre",
          UnitLabel = "g/m³",
          ID = new Guid("8c5b7fc3-0ade-4e85-9646-71ec5fcb869a"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = "SpecificGravity",
          UnitLabel = "s.g.",
          ID = new Guid("da94ba95-4494-45af-bf99-31f00031c680"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "GramPerCubicCentimetre",
          UnitLabel = "g/cm³",
          ID = new Guid("64f1b0d8-609f-4ed9-99da-52e18fe97450"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUK",
          UnitLabel = "ppgUK",
          ID = new Guid("75ecf787-8778-4d74-afc7-498e117d27bf"),
          ConversionFactorFromSI = 0.0100224
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUS",
          UnitLabel = "ppgUS",
          ID = new Guid("dcc01dd0-4610-42c7-9a55-2ddeb45ef6da"),
          ConversionFactorFromSI = 0.0083454
        },
        new UnitChoice
        {
          UnitName = "PoundPerCubicFoot",
          UnitLabel = "lb/ft³",
          ID = new Guid("f7479c8c-8d03-460b-bfa3-2b68808be935"),
          ConversionFactorFromSI = 0.0624279606
        }
      };
        }
    }
}
