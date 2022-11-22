using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingForceQuantity : ForceQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.1;
        private static DrillingForceQuantity instance_ = null;

        public static new DrillingForceQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingForceQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingForceQuantity() : base()
        {
            Name = "DrillingForce";
            ID = new Guid("30c08b42-6a89-4d99-879b-882eb7ed46d0");
            Reset();
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.Newton));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.DecaNewton));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.KiloDecaNewton));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.KilogramForce));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.KiloNewton));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.KiloPoundForce));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.PoundForce));
        }

    }
}
