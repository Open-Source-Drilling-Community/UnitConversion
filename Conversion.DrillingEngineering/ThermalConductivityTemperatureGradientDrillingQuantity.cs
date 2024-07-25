using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class ThermalConductivityTemperatureGradientDrillingQuantity : ThermalConductivityTemperatureGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static ThermalConductivityTemperatureGradientDrillingQuantity instance_ = null;

        public static new ThermalConductivityTemperatureGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ThermalConductivityTemperatureGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ThermalConductivityTemperatureGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Thermal Conductivity Temperature Gradient (drilling)" };
            ID = new Guid("559ae484-42ed-4379-86f5-67dae451a9c9");
            Reset();
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.WattPerMetreKelvinPerKelvin));
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitPerFahrenheit));
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheitPerFahrenheit));
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsiusPerCelsius));
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsiusPerCelsius));
        }

    }
}
