using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingDensityQuantity : DensityQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 1;

        private static DrillingDensityQuantity instance_ = null;

        public static new DrillingDensityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingDensityQuantity();
                }
                return instance_;
            }
        }

        protected DrillingDensityQuantity() : base()
        {
            Name = "DrillingDensity";
            ID = new Guid("60f2af98-56e4-4f9c-8438-59646a35fc0d");
            Reset();
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.GramPerCubicCentimeter));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.GramPerCubicMeter));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.KilogramPerCubicMeter));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerCubicFoot));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUK));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUS));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.SpecificGravity));
            PostProcess();
        }


    }
}
