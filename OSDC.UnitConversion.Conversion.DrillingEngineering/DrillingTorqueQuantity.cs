using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingTorqueQuantity : TorqueQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = +.1;
        private static DrillingTorqueQuantity instance_ = null;

        public static new DrillingTorqueQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingTorqueQuantity();
                }
                return instance_;
            }
        }

        protected DrillingTorqueQuantity() : base()
        {
            Name = "DrillingTorque";
            ID = new Guid("eff33c0e-1e92-49e4-a7ab-716d9d66a157");
            Reset();
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.MeterNewton));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.FootPound));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.KiloFootPound));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.MeterDecaNewton));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.MeterKilogramForce));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.MeterKiloNewton));
            PostProcess();
        }

    }
}
