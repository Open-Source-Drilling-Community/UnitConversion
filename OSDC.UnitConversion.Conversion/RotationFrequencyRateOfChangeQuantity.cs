using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class RotationFrequencyRateOfChangeQuantity : FrequencyRateOfChangeQuantity
    {
        public override string TypicalSymbol { get; } = null;
        private static RotationFrequencyRateOfChangeQuantity instance_ = null;

        public static new RotationFrequencyRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RotationFrequencyRateOfChangeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public RotationFrequencyRateOfChangeQuantity() : base()
        {
            Name = "RotationFreqencyRateOfChange";
            ID = new Guid("ed24a9f7-b70d-4f39-a992-241f25e1a77e");
            Reset();
            this.UnitChoices.Add(FrequencyRateOfChangeQuantity.Instance.GetUnitChoice(FrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond));
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "RPMPerSecond",
                UnitLabel = "rpm/s",
                ID = new Guid("762b5d58-a1ba-40cb-8776-2004613d15fb"),
                ConversionFactorFromSI = 60
            });
        }

    }
}
