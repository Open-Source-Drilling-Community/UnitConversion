using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PorosityQuantity : ProportionQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;
        private static PorosityQuantity instance_ = null;

        public static new PorosityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PorosityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public PorosityQuantity() : base()
        {
            Name = "Porosity";
            ID = new Guid("2f6516a1-47cc-498f-8271-e84150183665");
            Reset();
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Proportion));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent));
            this.UnitChoices.Add(ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.PerThousand));
        }
    }
}
