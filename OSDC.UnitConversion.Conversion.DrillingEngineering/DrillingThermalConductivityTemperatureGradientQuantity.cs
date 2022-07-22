using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingThermalConductivityTemperatureGradientQuantity : ThermalConductivityTemperatureGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static DrillingThermalConductivityTemperatureGradientQuantity instance_ = null;

        public static new DrillingThermalConductivityTemperatureGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingThermalConductivityTemperatureGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DrillingThermalConductivityTemperatureGradientQuantity() : base()
        {
            Name = "DrillingThermalConductivityTemperatureGradient";
            ID = new Guid("559ae484-42ed-4379-86f5-67dae451a9c9");
            Reset();
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.WattPerMetreKelvinPerKelvin));
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit));
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit));
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsiusPerCelsius));
            this.UnitChoices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsiusPerCelsius));
        }

    }
}
