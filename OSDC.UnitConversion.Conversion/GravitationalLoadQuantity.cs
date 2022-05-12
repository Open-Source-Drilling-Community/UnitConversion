using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class GravitationalLoadQuantity : MassQuantity
    {
        private static GravitationalLoadQuantity instance_ = null;

        public static new GravitationalLoadQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new GravitationalLoadQuantity();
                }
                return instance_;
            }
        }
        protected GravitationalLoadQuantity() : base()
        {
            Name = "GravitationalLoad";
            ID = new Guid("55682046-ff04-4a77-9311-a9f738f790b6");
            Reset();
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Kilogram));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.TonneMetric));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Pound));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.KiloPound));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.TonUK));
            PostProcess();
        }
    }
}
