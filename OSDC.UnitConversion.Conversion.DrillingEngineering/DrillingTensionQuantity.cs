using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingTensionQuantity : TensionQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 100;
        private static DrillingTensionQuantity instance_ = null;

        public static new DrillingTensionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingTensionQuantity();
                }
                return instance_;
            }
        }

        protected DrillingTensionQuantity() : base()
        {
            Name = "DrillingTension";
            ID = new Guid("fe8fd6fd-814c-44c9-9462-f034dd46dc85");
            Reset();
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.Newton));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.DecaNewton));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.KiloDecaNewton));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.KilogramForce));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.KiloNewton));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.KiloPoundForce));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.PoundForce));
            PostProcess();
        }

    }
}
