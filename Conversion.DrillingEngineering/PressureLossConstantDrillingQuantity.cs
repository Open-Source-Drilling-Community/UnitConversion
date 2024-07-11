using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class PressureLossConstantDrillingQuantity : PressureLossConstantQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.1;

        private static PressureLossConstantDrillingQuantity instance_ = null;

        public static new PressureLossConstantDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PressureLossConstantDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public PressureLossConstantDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Pressure Loss Constant (drilling)" };
            ID = new Guid("fd799f5c-0963-4201-aec3-e531df6b226e");
            Reset();
            this.UnitChoices.Add(PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantSI));
            this.UnitChoices.Add(PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantMetric));
            this.UnitChoices.Add(PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUK));
            this.UnitChoices.Add(PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUS));
        }

    }
}
