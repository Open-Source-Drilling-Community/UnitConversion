using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class FormationResistivityQuantity : ResistivityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 10000;
        private static FormationResistivityQuantity instance_ = null;

        public static new FormationResistivityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FormationResistivityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public FormationResistivityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Formation Resistivity (drilling)" };
            ID = new Guid("ed01d6da-225d-4bcc-beac-55ccdb6fb0b9");
            Reset();
            this.UnitChoices.Add(ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMetre));
        }

    }
}
