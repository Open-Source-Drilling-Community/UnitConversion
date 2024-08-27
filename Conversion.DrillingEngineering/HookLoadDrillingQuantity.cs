using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class HookLoadDrillingQuantity : GravitationalLoadQuantity
    {
        public override string SIUnitName { get; } = "kilogram";
        public override string SIUnitLabelLatex { get; } = "kg";
        public override double? MeaningfulPrecisionInSI { get; } = 100;
        private static HookLoadDrillingQuantity instance_ = null;

        public static new HookLoadDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new HookLoadDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public HookLoadDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "hook load (drilling)" };
            ID = new Guid("126be5e9-ed09-459e-92ce-32a5fcd81f0a");
            DescriptionMD = base.DescriptionMD;
            DescriptionMD += Environment.NewLine;
            DescriptionMD += "The meaningful precision of hook load in the drilling context is typically: " + MeaningfulPrecisionInSI.ToString() + " " + MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Kilogram).UnitLabel + Environment.NewLine;
            SemanticExample = GetSemanticExample();
            Reset();
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Kilogram));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.TonneMetric));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Pound));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Kilopound));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.TonUK));
        }
    }
}
