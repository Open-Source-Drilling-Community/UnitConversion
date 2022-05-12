using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingPlaneAngleQuantity : PlaneAngleQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.01 * Math.PI / 180.0;
        private static DrillingPlaneAngleQuantity instance_ = null;

        public static new DrillingPlaneAngleQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingPlaneAngleQuantity();
                }
                return instance_;
            }
        }
        protected DrillingPlaneAngleQuantity() : base()
        {
            Name = "DrillingPlaneAngle";
            ID = new Guid("94ad3e73-2a44-4c60-bbca-188b941f3357");
            Reset();
            this.UnitChoices.Add(PlaneAngleQuantity.Instance.GetUnitChoice(PlaneAngleQuantity.UnitChoicesEnum.Radian));
            this.UnitChoices.Add(PlaneAngleQuantity.Instance.GetUnitChoice(PlaneAngleQuantity.UnitChoicesEnum.Degree));
            PostProcess();
        }

    }
}
