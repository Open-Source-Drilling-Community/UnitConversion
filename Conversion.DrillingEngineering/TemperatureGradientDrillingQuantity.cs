using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class TemperatureGradientDrillingQuantity : TemperatureGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;
        private static TemperatureGradientDrillingQuantity instance_ = null;

        public static new TemperatureGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new TemperatureGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public TemperatureGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Temperature Gradient (drilling)" };
            ID = new Guid("82b91f3f-d1ec-476b-98e0-eedbba6281ec");
            Reset();
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.KelvinPerMetre));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPerMetre));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer10Metre));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer30Metre));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Metre));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPerFoot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer30Foot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Foot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPerFoot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer30Foot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot));
        }

    }
}
