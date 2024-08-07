using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillStemMaterialStrengthQuantity : MaterialStrengthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 10000;
        private static DrillStemMaterialStrengthQuantity instance_ = null;

        public static new DrillStemMaterialStrengthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillStemMaterialStrengthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DrillStemMaterialStrengthQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Drill Stem Material Strength (drilling)" };
            ID = new Guid("fd58fca3-6221-4e85-a7aa-a021ee04e8a8");
            Reset();
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Gigapascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Megapascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.MegapoundPerSquareInch));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.PoundPer100SquareFoot));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Psi));
        }

    }
}
