using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingRotationFrequencyRateOfChangeQuantity : RotationFrequencyRateOfChangeQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.016666666666666666;

        private static DrillingRotationFrequencyRateOfChangeQuantity instance_ = null;

        public static new DrillingRotationFrequencyRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingRotationFrequencyRateOfChangeQuantity();
                }
                return instance_;
            }
        }

        protected DrillingRotationFrequencyRateOfChangeQuantity() : base()
        {
            Name = "DrillingRotationFrequencyRateOfChange";
            ID = new Guid("4950170a-7882-4673-9d27-3402dbbca2bb");
            Reset();
            this.UnitChoices.Add(RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond));
            this.UnitChoices.Add(RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond));
            PostProcess();
        }

    }
}
