using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SmallProportionQuantity : ProportionQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-8;

        private static SmallProportionQuantity instance_ = null;

        public static new SmallProportionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SmallProportionQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public SmallProportionQuantity() : base()
        {
            Name = "SmallProportion";
            ID = new Guid("875392e2-ef43-45f7-a19b-19c51eaba248");
            Reset();
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Proportion));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PerThousand));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PartPerMillion));
        }
    }
}
