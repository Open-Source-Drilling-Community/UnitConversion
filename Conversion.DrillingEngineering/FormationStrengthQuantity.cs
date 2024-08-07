using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class FormationStrengthQuantity : MaterialStrengthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 10000;
        private static FormationStrengthQuantity instance_ = null;

        public static new FormationStrengthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FormationStrengthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public FormationStrengthQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Formation Strength (drilling)" };
            ID = new Guid("55a8119f-4609-4d51-91b4-e2281c46c779");
            Reset();
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Gigapascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Megapascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.MegapoundPerSquareInch));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.PoundPer100SquareFoot));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Psi));
        }

    }
}
