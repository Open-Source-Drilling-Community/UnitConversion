using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class MassRateQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "KilogramPerSecond";
        public override string SIUnitLabel { get; } = "kg/s";
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -1;
        private static MassRateQuantity instance_ = null;

        public static MassRateQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MassRateQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public MassRateQuantity() : base()
        {
            Name = "MassRate";
            ID = new Guid("3dd05c4c-3d6d-49ae-a878-5a5e4a6e7acf");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("a2daceb8-7705-4c97-9945-b354ea1ff78d"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "KilogramPerMinute",
          UnitLabel = "kg/min",
          ID = new Guid("b776ae6f-5b86-462c-b815-2608d7e98192"),
          ConversionFactorFromSI = 60
        }
      };
        }
    }
}
