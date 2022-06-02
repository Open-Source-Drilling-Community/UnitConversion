using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingTemperatureQuantity : TemperatureQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.01;
        private static DrillingTemperatureQuantity instance_ = null;

        public static new DrillingTemperatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingTemperatureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DrillingTemperatureQuantity() : base()
        {
            Name = "DrillingTemperature";
            ID = new Guid("84ce5a77-fd76-4014-ad8e-03f194c3e329");
            Reset();
            this.UnitChoices.Add(TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Kelvin));
            this.UnitChoices.Add(TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Celsius));
            this.UnitChoices.Add(TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Fahrenheit));
        }

    }
}
