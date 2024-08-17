using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

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
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Rotation Frequency", "Rotary speed", "RPM" };
            ID = new Guid("f6f7ab6f-3003-49d2-a17d-92a0f81938f2");
            Reset();
            this.UnitChoices.Add(FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz));
            this.UnitChoices.Add(FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Rpm));
        }

    }
}
