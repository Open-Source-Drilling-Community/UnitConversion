using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class GasShowQuantity : ProportionQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 1E-07;
        private static GasShowQuantity instance_ = null;

        public static new GasShowQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new GasShowQuantity();
                }
                return instance_;
            }
        }
        protected GasShowQuantity() : base()
        {
            Name = "GasShow";
            ID = new Guid("c81adbce-b90b-4889-8b79-921d95b35179");
            Reset();
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Proportion));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PerThousand));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PartPerMillion));
            PostProcess();
        }
    }
}
