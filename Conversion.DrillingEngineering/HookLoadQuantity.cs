using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class HookLoadQuantity : GravitationalLoadQuantity
    {
        public override string SIUnitName { get; } = "Kilogram";
        public override string SIUnitLabel { get; } = "kg";
        public override double? MeaningfulPrecisionInSI { get; } = 100;
        private static HookLoadQuantity instance_ = null;

        public static new HookLoadQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new HookLoadQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public HookLoadQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Hook Load (drilling)" };
            ID = new Guid("126be5e9-ed09-459e-92ce-32a5fcd81f0a");
            Reset();
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Kilogram));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.TonneMetric));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Pound));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.KiloPound));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.TonUK));
        }
    }
}
