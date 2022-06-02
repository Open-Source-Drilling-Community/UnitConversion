using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingCompressibilityQuantity : CompressibilityQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 1E-13;

        private static DrillingCompressibilityQuantity instance_ = null;

        public static new DrillingCompressibilityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingCompressibilityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingCompressibilityQuantity() : base()
        {
            Name = "DrillingCompressibility";
            ID = new Guid("bfec67e2-839f-47d7-968c-69287567835d");
            Reset();
            this.UnitChoices.Add(CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InverseBar));
            this.UnitChoices.Add(CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InversePascal));
            this.UnitChoices.Add(CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch));
        }

    }
}
