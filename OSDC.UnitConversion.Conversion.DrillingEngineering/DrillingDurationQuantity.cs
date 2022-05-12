using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingDurationQuantity : TimeQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.001;

        private static DrillingDurationQuantity instance_ = null;

        public static new DrillingDurationQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingDurationQuantity();
                }
                return instance_;
            }
        }

        protected DrillingDurationQuantity() : base()
        {
            Name = "DrillingDuration";
            ID = new Guid("22443197-6bcf-45f7-9079-4f710585af60");
            Reset();
            this.UnitChoices.Add(TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Second));
            this.UnitChoices.Add(TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Minute));
            this.UnitChoices.Add(TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Hour));
            this.UnitChoices.Add(TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Day));
            PostProcess();
        }

    }
}
