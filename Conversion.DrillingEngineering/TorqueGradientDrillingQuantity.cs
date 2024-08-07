using System;
using System.Collections.Generic;
using System.Linq;
using OSDC.UnitConversion.Conversion;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class TorqueGradientDrillingQuantity : TorqueGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1;
        private static TorqueGradientDrillingQuantity instance_ = null;

        public static new TorqueGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new TorqueGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public TorqueGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Torque Gradient (drilling)" };
            ID = new Guid("6ad57f76-fb74-4099-a257-1d47216bfe65");
            Reset();
            this.UnitChoices.Add(TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMetrePerMetre));
            this.UnitChoices.Add(TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilonewtonMetrePerMetre));
            this.UnitChoices.Add(TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.DecanewtonMetrePerMetre));
            this.UnitChoices.Add(TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.FootPoundPerFoot));
            this.UnitChoices.Add(TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilofootPoundPerFoot));
            this.UnitChoices.Add(TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.FootPoundPerMetre));
            this.UnitChoices.Add(TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilofootPoundPerMetre));
        }
    }
}
