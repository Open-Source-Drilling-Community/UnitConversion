using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class SpecificHeatCapacityGradientPerTemperatureDrillingQuantity : SpecificHeatCapacityGradientPerTemperatureQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static SpecificHeatCapacityGradientPerTemperatureDrillingQuantity instance_ = null;

        public static new SpecificHeatCapacityGradientPerTemperatureDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SpecificHeatCapacityGradientPerTemperatureDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public SpecificHeatCapacityGradientPerTemperatureDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "specific heat capacity gradient per temperature (drilling)" };
            ID = new Guid("5f180166-bc44-4855-916f-236a5a31893d");
            DescriptionMD = base.DescriptionMD;
            DescriptionMD += Environment.NewLine;
            DescriptionMD += "The meaningful precision of specific heat capacity gradient per temperature in the drilling context is typically: " + MeaningfulPrecisionInSI.ToString() + " " + SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.JoulePerKilogramSquaredKelvin).UnitLabel + Environment.NewLine;
            Reset();
            this.UnitChoices.Add(SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.JoulePerKilogramSquaredKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.JoulePerGramSquaredKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.JoulePerGramDegreeSquaredCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.CaloriePerGramDegreeSquaredCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundSquaredDegreeFahrenheit));
        }

    }
}
