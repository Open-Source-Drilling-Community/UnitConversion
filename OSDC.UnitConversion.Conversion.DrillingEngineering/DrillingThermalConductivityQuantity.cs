using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingThermalConductivityQuantity : ThermalConductivityQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.01;
        private static DrillingThermalConductivityQuantity instance_ = null;

        public static new DrillingThermalConductivityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingThermalConductivityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DrillingThermalConductivityQuantity() : base()
        {
            Name = "DrillingThermalConductivity";
            ID = new Guid("186eef6a-9da3-4b97-a6d0-d496bdf59321");
            Reset();
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.WattPerMetreKelvin));
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsius));
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsius));
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit));
            this.UnitChoices.Add(ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFarenheit));
        }

    }
}
