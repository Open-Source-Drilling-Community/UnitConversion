using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class FormationResistivityDrillingQuantity : ResistivityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 10000;
        private static FormationResistivityDrillingQuantity instance_ = null;

        public static new FormationResistivityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FormationResistivityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public FormationResistivityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "formation resistivity (drilling)" };
            ID = new Guid("ed01d6da-225d-4bcc-beac-55ccdb6fb0b9");
            DescriptionMD = base.DescriptionMD;
            DescriptionMD += Environment.NewLine;
            DescriptionMD += "The meaningful precision of formation resistivity in the drilling context is typically: " + MeaningfulPrecisionInSI.ToString() + " " + ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMetre).UnitLabel + Environment.NewLine;
            Reset();
            this.UnitChoices.Add(ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMetre));
        }

    }
}
