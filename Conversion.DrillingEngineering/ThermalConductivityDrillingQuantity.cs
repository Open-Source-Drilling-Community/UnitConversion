using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class ThermalConductivityDrillingQuantity : ThermalConductivityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static ThermalConductivityDrillingQuantity instance_ = null;

        public static new ThermalConductivityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ThermalConductivityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ThermalConductivityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Thermal Conductivity (drilling)" };
            ID = new Guid("186eef6a-9da3-4b97-a6d0-d496bdf59321");
            Reset();
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.WattPerMetreKelvin));
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsius));
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsius));
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheit));
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit));
        }

    }
}
