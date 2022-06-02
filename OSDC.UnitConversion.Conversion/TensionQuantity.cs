using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class TensionQuantity : ForceQuantity
    {
        public override string TypicalSymbol { get; } = null;
        private static TensionQuantity instance_ = null;

        public static new TensionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new TensionQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public TensionQuantity() : base()
        {
            Name = "Tension";
            ID = new Guid("7c4e127d-aa65-4796-a962-c2c666c4fdd0");
            Reset();
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.Newton));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.DecaNewton));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.KiloNewton));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.KiloDecaNewton));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.KilogramForce));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.PoundForce));
            this.UnitChoices.Add(ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.KiloPoundForce));
        }
    }
}
