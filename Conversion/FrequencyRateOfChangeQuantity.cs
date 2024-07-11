using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class FrequencyRateOfChangeQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "HertzPerSecond";
        public override string SIUnitLabel { get; } = "Hz/s";
        public override double TimeDimension { get; } = -2;
        private static FrequencyRateOfChangeQuantity instance_ = null;

        public static FrequencyRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FrequencyRateOfChangeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public FrequencyRateOfChangeQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Frequency Rate Of Change" };
            ID = new Guid("e9d5bfe9-428b-4df0-9fe5-d9ad17e6a0cb");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("4d7e4b49-df76-4259-a96c-8c1250d5ecdd"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        }
      };
        }
    }
}
