using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class PressureDrillingQuantity : PressureQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 10000;

        private static PressureDrillingQuantity instance_ = null;

        public static new PressureDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PressureDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public PressureDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Pressure (drilling)", "MSE (as a pressure)" };
            ID = new Guid("d9db6bb4-77af-4fc3-a683-7bedd781fcba");
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
