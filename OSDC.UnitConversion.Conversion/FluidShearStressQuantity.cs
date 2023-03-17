using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class FluidShearStressQuantity : PressureQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override double? MeaningfulPrecisionInSI { get; } = 1E-04;
        private static FluidShearStressQuantity instance_ = null;

        public static new FluidShearStressQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FluidShearStressQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public FluidShearStressQuantity() : base()
        {
            Name = "FluidShearStress";
            ID = new Guid("b8f8f4f5-1925-4eaf-87c2-2adfdf618454");
            Reset();
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.KiloPascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Bar));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPer100SquareFoot));
        }
    }
}
