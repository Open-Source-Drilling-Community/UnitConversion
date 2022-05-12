using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingElongationGradientQuantity : ElongationGradientQuantity, IEngineeringQuantity
    {
        
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.01;
        private static DrillingElongationGradientQuantity instance_ = null;

        public static new DrillingElongationGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingElongationGradientQuantity();
                }
                return instance_;
            }
        }

        protected DrillingElongationGradientQuantity() : base()
        {
            Name = "DrillingElongationGradient";
            ID = new Guid("4410a514-a65a-48ca-82d1-ab788b3d2df9");
            Reset();
            this.UnitChoices.Add(ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MeterPerMeter));
            this.UnitChoices.Add(ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MillimeterPerMeter));
            this.UnitChoices.Add(ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerFoot));
            PostProcess();
        }
        
    }
}
