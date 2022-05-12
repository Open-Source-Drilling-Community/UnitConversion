using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingMassQuantity : MassQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.1;
        private static DrillingMassQuantity instance_ = null;

        public static new DrillingMassQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingMassQuantity();
                }
                return instance_;
            }
        }
        protected DrillingMassQuantity() : base()
        {
            Name = "DrillingMass";
            ID = new Guid("f4c0a6fd-5000-4507-8612-ae4374c0cacc");
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
