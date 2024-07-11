using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class GasShowQuantity : ProportionQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1E-07;
        private static GasShowQuantity instance_ = null;

        public static new GasShowQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new GasShowQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public GasShowQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Gas Show (drilling)" };
            ID = new Guid("c81adbce-b90b-4889-8b79-921d95b35179");
            Reset();
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Proportion));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PerThousand));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PartPerMillion));
        }
    }
}
