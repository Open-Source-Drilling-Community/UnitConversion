using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class FrequencyRateOfChangeQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "HertzPerSecond";
        public override string SIUnitSymbol { get; } = "Hz/s";
        public override double TimeDimension { get; } = -2;
        private static FrequencyRateOfChangeQuantity instance_ = null;

        public static FrequencyRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FrequencyRateOfChangeQuantity();
                }
                return instance_;
            }
        }
        protected FrequencyRateOfChangeQuantity() : base()
        {
            Name = "FrequencyRateOfChange";
            ID = new Guid("e9d5bfe9-428b-4df0-9fe5-d9ad17e6a0cb");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitSymbol = SIUnitSymbol,
          ID = new Guid("4d7e4b49-df76-4259-a96c-8c1250d5ecdd"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        }
      };
            PostProcess();
        }
    }
}
