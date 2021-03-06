using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class MassGradientQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "kilogramPerMeter";
        public override string SIUnitLabel { get; } = "kg/m";
        public override double LengthDimension { get; } = -1;
        public override double MassDimension { get; } = 1;
        private static MassGradientQuantity instance_ = null;

        public static MassGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MassGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public MassGradientQuantity() : base()
        {
            Name = "MassGradient";
            ID = new Guid("b8694592-8f8d-4684-b0ba-c88de50c8486");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("c8b4a6ea-29bf-4e5a-b7ce-9142cefc0752"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "PoundPerFoot",
          UnitLabel = " lb/ft",
          ID = new Guid("6fdf4cb6-a43b-482d-9bc8-d4ad49770f9e"),
          ConversionFactorFromSI = 0.6719689753966845
        },
        new UnitChoice
        {
          UnitName = "gramPerMeter",
          UnitLabel = "g/m",
          ID = new Guid("0cea1e32-9adb-4882-9070-d027cd0eef8e"),
          ConversionFactorFromSI = 1000
        }
      };
        }
    }
}
