using System;
using System.Collections.Generic;
using System.Linq;

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
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public GravitationalLoadQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Gravitational Load" };
            ID = new Guid("55682046-ff04-4a77-9311-a9f738f790b6");
            Reset();
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Kilogram));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.TonneMetric));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Pound));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.KiloPound));
            this.UnitChoices.Add(MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.TonUK));
        }
    }
}
