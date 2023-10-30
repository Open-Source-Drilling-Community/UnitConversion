using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingSurveyInstrumentReciprocalLengthQuantity : WaveNumberQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-8;

        private static DrillingSurveyInstrumentReciprocalLengthQuantity instance_ = null;

        public static new DrillingSurveyInstrumentReciprocalLengthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingSurveyInstrumentReciprocalLengthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingSurveyInstrumentReciprocalLengthQuantity() : base()
        {
            Name = "DrillingSurveyInstrumentReciprocalLength";
            ID = new Guid("c198aa3b-3b24-402d-b60b-f54ff9430f33");
            Reset();
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalMetre));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalDecameter));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalHectometer));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalKilometer));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalFeet));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalYard));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalMile));
        }
    }
}
