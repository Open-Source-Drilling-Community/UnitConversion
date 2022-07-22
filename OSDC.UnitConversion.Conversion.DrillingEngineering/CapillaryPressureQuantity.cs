using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class CapillaryPressureQuantity : PressureQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.1;
        private static CapillaryPressureQuantity instance_ = null;

        public static new CapillaryPressureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new CapillaryPressureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public CapillaryPressureQuantity() : base()
        {
            Name = "CapillaryPressure";
            ID = new Guid("72228ff1-9ba8-44f0-b9b1-85fa8dfb32ea");
            Reset();
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Bar));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.KiloPascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.MegaPascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.KiloPoundPerSquareInch));
        }
    }
}
