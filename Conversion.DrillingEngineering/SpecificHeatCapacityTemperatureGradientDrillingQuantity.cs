using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class SpecificHeatCapacityTemperatureGradientDrillingQuantity : SpecificHeatCapacityTemperatureGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static SpecificHeatCapacityTemperatureGradientDrillingQuantity instance_ = null;

        public static new SpecificHeatCapacityTemperatureGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SpecificHeatCapacityTemperatureGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public SpecificHeatCapacityTemperatureGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Specific Heat Capacity Temperature Gradient (drilling)" };
            ID = new Guid("5f180166-bc44-4855-916f-236a5a31893d");
            Reset();
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerKilogramKelvinPerKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerGramKelvinPerKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerGramDegreeCelsiusPerCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerGramDegreeCelsiusPerCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFahrenheitPerFahrenheit));
        }

    }
}
