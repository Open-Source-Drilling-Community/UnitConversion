using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class RotationFrequencyRateOfChangeDrillingQuantity : RotationFrequencyRateOfChangeQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.016666666666666666;

        private static RotationFrequencyRateOfChangeDrillingQuantity instance_ = null;

        public static new RotationFrequencyRateOfChangeDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RotationFrequencyRateOfChangeDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public RotationFrequencyRateOfChangeDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Rotation Frequency Rate Of Change (drilling)" };
            ID = new Guid("4950170a-7882-4673-9d27-3402dbbca2bb");
            Reset();
            this.UnitChoices.Add(RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond));
            this.UnitChoices.Add(RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond));
        }

    }
}
