using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ForceGradientQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "NewtonPerMeter";
        public override string SIUnitLabel { get; } = "N/m";
        public override double LengthDimension { get; } = 0;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -3;
        private static ForceGradientQuantity instance_ = null;

        public static ForceGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ForceGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ForceGradientQuantity() : base()
        {
            Name = "ForceGradient";
            ID = new Guid("e5212340-1147-4cad-9f71-5cd9d4208ffd");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("e503a1d3-1815-4321-8087-6e3d6dc641c8"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "NewtonPer30Meter",
          UnitLabel = "N/30m",
          ID = new Guid("be16e271-5ce7-445b-a8db-9014a6acc22b"),
          ConversionFactorFromSI = 30
        },
        new UnitChoice
        {
          UnitName = "decaNewtonPerMeter",
          UnitLabel = "daN/m",
          ID = new Guid("46defe0c-4a00-45d1-83bb-f898e00a78c5"),
          ConversionFactorFromSI = 10
        }
      };
        }
    }
}
