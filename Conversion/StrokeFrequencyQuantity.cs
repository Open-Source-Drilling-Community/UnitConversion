using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace OSDC.UnitConversion.Conversion
{
    public partial class StrokeFrequencyQuantity : FrequencyQuantity
    {

        public override double? MeaningfulPrecisionInSI { get; } = 0.016666666666666666;
        private static StrokeFrequencyQuantity instance_ = null;

        public static new StrokeFrequencyQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new StrokeFrequencyQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public StrokeFrequencyQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Stroke Frequency", "SPM" };
            ID = new Guid("86fd37e4-3ebf-42ec-9eb2-1e65f7abf29e");
            Reset();
            this.UnitChoices.Add(FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz));
            this.UnitChoices.Add(FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Spm));
        }

    }
}
