using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class StandardProportionQuantity : ProportionQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static StandardProportionQuantity instance_ = null;

        public static new StandardProportionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new StandardProportionQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public StandardProportionQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Standard Proportion" };
            ID = new Guid("97555d61-9fc3-4769-9143-6bc2bf51b2d7");
            Reset();
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Proportion));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PerThousand));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PartPerMillion));
        }
    }
}
