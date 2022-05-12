using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class RateOfPenetrationQuantity : VelocityQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 2.77778E-05;
        private static RateOfPenetrationQuantity instance_ = null;

        public static new RateOfPenetrationQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RateOfPenetrationQuantity();
                }
                return instance_;
            }
        }
        protected RateOfPenetrationQuantity() : base()
        {
            Name = "RateOfPenetration";
            ID = new Guid("c2581b41-944c-410b-9805-62c4b54de510");
            Reset();
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerHour));
            PostProcess();
        }
    }
}
