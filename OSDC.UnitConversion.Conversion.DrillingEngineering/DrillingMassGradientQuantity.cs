using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingMassGradientQuantity : MassGradientQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.05;
        private static DrillingMassGradientQuantity instance_ = null;

        public static new DrillingMassGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingMassGradientQuantity();
                }
                return instance_;
            }
        }
        protected DrillingMassGradientQuantity() : base()
        {
            Name = "DrillingMassGradient";
            ID = new Guid("dc474098-a2b5-44fb-b56a-0ae20ff62ad6");
            Reset();
            this.UnitChoices.Add(MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.KilogramPerMeter));
            this.UnitChoices.Add(MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.PoundPerFoot));
            PostProcess();
        }

    }
}
