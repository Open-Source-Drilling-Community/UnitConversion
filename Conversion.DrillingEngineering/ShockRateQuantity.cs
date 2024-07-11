using System;
using System.Collections.Generic;
using System.Linq;
using OSDC.UnitConversion.Conversion;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class ShockRateQuantity : FrequencyQuantity
    {

        public override double? MeaningfulPrecisionInSI { get; } = 0.016666666666666666;
        private static ShockRateQuantity instance_ = null;

        public static new ShockRateQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ShockRateQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public ShockRateQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Shock Rate (drilling)" };
            ID = new Guid("0076d96f-bfc3-4f98-8541-4fd12e4bcbff");
            Reset();
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = SIUnitName,
                UnitLabel = SIUnitLabel,
                ID = new Guid("8acb8ee8-4cb7-44ef-b702-81c9f3008bf3"),
                ConversionFactorFromSI = 1.0,
                IsSI = true
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "ShockPerMinute",
                UnitLabel = "spm",
                ID = new Guid("6ccbee46-cb8a-4777-b1d2-e88eedd24f73"),
                ConversionFactorFromSI = 60
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "ShockPerHour",
                UnitLabel = "spm",
                ID = new Guid("0c0d4ecb-ee11-4b57-9bc7-70860637232e"),
                ConversionFactorFromSI = 3600
            });
        }

    }
}
