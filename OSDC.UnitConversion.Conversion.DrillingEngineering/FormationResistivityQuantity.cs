using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class FormationResistivityQuantity : ResistivityQuantity, IEngineeringQuantity
    {
    public virtual double? MeaningFullPrecisionInSI {get; } = 10000;
        private static FormationResistivityQuantity instance_ = null;

        public static new FormationResistivityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FormationResistivityQuantity();
                }
                return instance_;
            }
        }

        protected FormationResistivityQuantity() : base()
        {
            Name = "FormationResistivity";
            ID = new Guid("ed01d6da-225d-4bcc-beac-55ccdb6fb0b9");
            Reset();
            this.UnitChoices.Add(ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMeter));
            PostProcess();
        }

    }
}
