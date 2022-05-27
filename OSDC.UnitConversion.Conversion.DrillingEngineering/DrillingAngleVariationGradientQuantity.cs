using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingAngleVariationGradientQuantity : AngleVariationGradientQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.00017453292519943296;

        private static DrillingAngleVariationGradientQuantity instance_ = null;

        public static new DrillingAngleVariationGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingAngleVariationGradientQuantity();
                }
                return instance_;
            }
        }

        protected DrillingAngleVariationGradientQuantity() : base()
        {
            Name = "DrillingAngleVariationGradient";
            ID = new Guid("e6f22876-ca88-4d0e-a4a5-c76b0db3556f");
            Reset();
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.RadianPerMeter));
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerMeter));
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot));
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerCentimeter));
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerInch));
            PostProcess();
        }

    }
}
