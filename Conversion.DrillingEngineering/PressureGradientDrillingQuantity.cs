using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class PressureGradientDrillingQuantity : PressureGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 10000;
        private static PressureGradientDrillingQuantity instance_ = null;

        public static new PressureGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PressureGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public PressureGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Pressure Gradient (drilling)" };
            ID = new Guid("92a284e7-9898-41f7-950d-4ba9f1ec550b");
            Reset();
            this.UnitChoices.Add(PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PascalPerMetre));
            this.UnitChoices.Add(PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.BarPerMetre));
            this.UnitChoices.Add(PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PSIPerFoot));
            this.UnitChoices.Add(PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PSIPerMetre));
        }

    }
}
