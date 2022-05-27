using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillStemMaterialStrengthQuantity : MaterialStrengthQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 10000;
        private static DrillStemMaterialStrengthQuantity instance_ = null;

        public static new DrillStemMaterialStrengthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillStemMaterialStrengthQuantity();
                }
                return instance_;
            }
        }
        protected DrillStemMaterialStrengthQuantity() : base()
        {
            Name = "DrillStemMaterialStrength";
            ID = new Guid("fd58fca3-6221-4e85-a7aa-a021ee04e8a8");
            Reset();
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.GigaPascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.MegaPascal));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.MegapoundPerSquareInch));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.PoundPer100SquareFoot));
            this.UnitChoices.Add(MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.PSI));
            PostProcess();
        }

    }
}
