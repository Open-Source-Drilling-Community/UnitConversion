using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class StandardProportionQuantity : ProportionQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.001;

        private static StandardProportionQuantity instance_ = null;

        public static new StandardProportionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new StandardProportionQuantity();
                }
                return instance_;
            }
        }

        protected StandardProportionQuantity() : base()
        {
            Name = "StandardProportion";
            ID = new Guid("97555d61-9fc3-4769-9143-6bc2bf51b2d7");
            Reset();
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Proportion));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PerThousand));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PartPerMillion));
            PostProcess();
        }


    }
}
