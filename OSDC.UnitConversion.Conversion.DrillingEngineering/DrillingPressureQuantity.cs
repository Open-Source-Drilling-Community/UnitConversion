using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingPressureQuantity : PressureQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 10000;

        private static DrillingPressureQuantity instance_ = null;

        public static new DrillingPressureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingPressureQuantity();
                }
                return instance_;
            }
        }

        protected DrillingPressureQuantity() : base()
        {
            Name = "DrillingPressure";
            ID = new Guid("d9db6bb4-77af-4fc3-a683-7bedd781fcba");
            Reset();
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Bar));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.KiloPascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.MegaPascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.KiloPoundPerSquareInch));
            PostProcess();
        }

    }
}
