using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingSpecificHeatCapacityTemperatureGradientQuantity : SpecificHeatCapacityTemperatureGradientQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.01;
        private static DrillingSpecificHeatCapacityTemperatureGradientQuantity instance_ = null;

        public static new DrillingSpecificHeatCapacityTemperatureGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingSpecificHeatCapacityTemperatureGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DrillingSpecificHeatCapacityTemperatureGradientQuantity() : base()
        {
            Name = "DrillingSpecificHeatCapacityTemperatureGradient";
            ID = new Guid("5f180166-bc44-4855-916f-236a5a31893d");
            Reset();
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerKilogramKelvinPerKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerGramKelvinPerKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerGramDegreeCelsiusPerCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerGramDegreeCelsiusPerCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit));
        }

    }
}
