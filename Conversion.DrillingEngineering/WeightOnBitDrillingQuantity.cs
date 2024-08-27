using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class WeightOnBitDrillingQuantity : GravitationalLoadQuantity
    {

        public override double? MeaningfulPrecisionInSI { get; } = 10;
        private static WeightOnBitDrillingQuantity instance_ = null;

        public static new WeightOnBitDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new WeightOnBitDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public WeightOnBitDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "weight on bit (drilling)", "WOB" };
            ID = new Guid("5e75da44-a675-4f0e-a0fb-52b2cb6797ce");
            DescriptionMD = base.DescriptionMD;
            DescriptionMD += Environment.NewLine;
            DescriptionMD += "The meaningful precision of weight on bit in the drilling context is typically: " + MeaningfulPrecisionInSI.ToString() + " " + GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Kilogram).UnitLabel + Environment.NewLine;
            SemanticExample = GetSemanticExample();
            Reset();
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Kilogram));
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.TonneMetric));
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Pound));
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Kilopound));
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.TonUK));
        }
    }
}
