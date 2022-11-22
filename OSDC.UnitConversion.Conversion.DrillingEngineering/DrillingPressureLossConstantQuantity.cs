using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingPressureLossConstantQuantity : PressureLossConstantQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.1;

        private static DrillingPressureLossConstantQuantity instance_ = null;

        public static new DrillingPressureLossConstantQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingPressureLossConstantQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingPressureLossConstantQuantity() : base()
        {
            Name = "DrillingPressureLossConstant";
            ID = new Guid("fd799f5c-0963-4201-aec3-e531df6b226e");
            Reset();
            this.UnitChoices.Add(PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantSI));
            this.UnitChoices.Add(PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantMetric));
            this.UnitChoices.Add(PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUK));
            this.UnitChoices.Add(PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUS));
        }

    }
}
