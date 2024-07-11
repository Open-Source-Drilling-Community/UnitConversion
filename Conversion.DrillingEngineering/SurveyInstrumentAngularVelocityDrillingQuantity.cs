using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class SurveyInstrumentAngularVelocityDrillingQuantity : AngularVelocityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-7;

        private static SurveyInstrumentAngularVelocityDrillingQuantity instance_ = null;

        public static new SurveyInstrumentAngularVelocityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SurveyInstrumentAngularVelocityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public SurveyInstrumentAngularVelocityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "" };
            ID = new Guid("76dd6ac8-8b67-416c-b41f-07bbf4065cdb");
            Reset();
            this.UnitChoices.Add(AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.RadianPerSecond));
            this.UnitChoices.Add(AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond));
            this.UnitChoices.Add(AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerMinute));
            this.UnitChoices.Add(AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerHour));
            this.UnitChoices.Add(AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerDay));
        }

    }
}
