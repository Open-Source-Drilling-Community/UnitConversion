using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class SurveyInstrumentReciprocalLengthDrillingQuantity : WaveNumberQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-8;

        private static SurveyInstrumentReciprocalLengthDrillingQuantity instance_ = null;

        public static new SurveyInstrumentReciprocalLengthDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SurveyInstrumentReciprocalLengthDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public SurveyInstrumentReciprocalLengthDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Survey Instrument Reciprocal Length (drilling)" };
            ID = new Guid("c198aa3b-3b24-402d-b60b-f54ff9430f33");
            Reset();
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalMetre));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalDecametre));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalHectometre));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalKilometre));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalFeet));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalYard));
            this.UnitChoices.Add(WaveNumberQuantity.Instance.GetUnitChoice(WaveNumberQuantity.UnitChoicesEnum.ReciprocalMile));
        }
    }
}
