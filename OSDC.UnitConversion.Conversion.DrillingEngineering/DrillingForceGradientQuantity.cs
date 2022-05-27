using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingForceGradientQuantity : ForceGradientQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 1;
        private static DrillingForceGradientQuantity instance_ = null;

        public static new DrillingForceGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingForceGradientQuantity();
                }
                return instance_;
            }
        }

        protected DrillingForceGradientQuantity() : base()
        {
            Name = "DrillingForceGradient";
            ID = new Guid("78942f39-d764-42f1-b270-47a3b35e5112");
            Reset();
            this.UnitChoices.Add(ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPerMeter));
            this.UnitChoices.Add(ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPer30Meter));
            this.UnitChoices.Add(ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter));
            PostProcess();
        }

    }
}
