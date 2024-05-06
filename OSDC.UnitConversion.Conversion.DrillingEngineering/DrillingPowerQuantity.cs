using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingPowerQuantity : PowerQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.1;
        private static DrillingPowerQuantity instance_ = null;

        public static new DrillingPowerQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingPowerQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingPowerQuantity() : base()
        {
            Name = "DrillingPower";
            ID = new Guid("d7f0d3a8-2d15-4ae9-897a-5d1ef7feef8a");
            Reset();
            this.UnitChoices.Add(PowerQuantity.Instance.GetUnitChoice(PowerQuantity.UnitChoicesEnum.Watt));
            this.UnitChoices.Add(PowerQuantity.Instance.GetUnitChoice(PowerQuantity.UnitChoicesEnum.KiloWatt));
            this.UnitChoices.Add(PowerQuantity.Instance.GetUnitChoice(PowerQuantity.UnitChoicesEnum.MegaWatt));
        }
    }
}
