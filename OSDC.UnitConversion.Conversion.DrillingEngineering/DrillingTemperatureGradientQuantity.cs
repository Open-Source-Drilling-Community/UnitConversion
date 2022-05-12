using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingTemperatureGradientQuantity : TemperatureGradientQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.001;
        private static new DrillingTemperatureGradientQuantity instance_ = null;

        public static new DrillingTemperatureGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingTemperatureGradientQuantity();
                }
                return instance_;
            }
        }
        protected DrillingTemperatureGradientQuantity() : base()
        {
            Name = "DrillingTemperatureGradient";
            ID = new Guid("82b91f3f-d1ec-476b-98e0-eedbba6281ec");
            Reset();
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.KelvinPerMeter));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPerMeter));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer10Meter));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer30Meter));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Meter));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPerFoot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer30Foot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Foot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPerFoot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer30Foot));
            this.UnitChoices.Add(TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot));
            PostProcess();
        }

    }
}
