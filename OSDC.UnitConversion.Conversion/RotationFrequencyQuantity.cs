using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class RotationFrequencyQuantity : FrequencyQuantity
    {

        public override double? MeaningfulPrecisionInSI { get; } = 0.016666666666666666;
        private static RotationFrequencyQuantity instance_ = null;

        public static new RotationFrequencyQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RotationFrequencyQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public RotationFrequencyQuantity() : base()
        {
            Name = "RotationFrequency";
            ID = new Guid("f6f7ab6f-3003-49d2-a17d-92a0f81938f2");
            Reset();
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = SIUnitName,
                UnitLabel = SIUnitLabel,
                ID = new Guid("59d8be09-9eee-4a88-926c-72e1c7c1242e"),
                ConversionFactorFromSI = 1.0,
                IsSI = true
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "RPM",
                UnitLabel = "rpm",
                ID = new Guid("30880b5f-803d-412e-9736-62dca3ba5bbd"),
                ConversionFactorFromSI = 60
            });
        }

    }
}
