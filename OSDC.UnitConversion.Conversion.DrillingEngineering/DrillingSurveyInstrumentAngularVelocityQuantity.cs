using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingSurveyInstrumentAngularVelocityQuantity : AngularVelocityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-7;

        private static DrillingSurveyInstrumentAngularVelocityQuantity instance_ = null;

        public static new DrillingSurveyInstrumentAngularVelocityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingSurveyInstrumentAngularVelocityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingSurveyInstrumentAngularVelocityQuantity() : base()
        {
            Name = "DrillingSurveyInstrumentAngularVelocity";
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
