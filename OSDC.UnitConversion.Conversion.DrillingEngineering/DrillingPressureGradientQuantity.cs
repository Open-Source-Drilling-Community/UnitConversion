using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingPressureGradientQuantity : PressureGradientQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 10000;
        private static DrillingPressureGradientQuantity instance_ = null;

        public static new DrillingPressureGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingPressureGradientQuantity();
                }
                return instance_;
            }
        }
        protected DrillingPressureGradientQuantity() : base()
        {
            Name = "DrillingPressureGradient";
            ID = new Guid("92a284e7-9898-41f7-950d-4ba9f1ec550b");
            Reset();
            this.UnitChoices.Add(PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PascalPerMeter));
            this.UnitChoices.Add(PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.BarPerMeter));
            this.UnitChoices.Add(PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PSIPerFoot));
            this.UnitChoices.Add(PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PSIPerMeter));
            PostProcess();
        }

    }
}
