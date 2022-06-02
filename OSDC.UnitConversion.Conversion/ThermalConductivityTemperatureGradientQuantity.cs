using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ThermalConductivityTemperatureGradientQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "WattPerMetreKelvinPerKelvin";
        public override string SIUnitLabel { get; } = "(W/(m•K))/K";
        public override double LengthDimension { get; } = 1;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -3;
        public override double TemperatureDimension { get; } = -2;
        private static ThermalConductivityTemperatureGradientQuantity instance_ = null;

        public static ThermalConductivityTemperatureGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ThermalConductivityTemperatureGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ThermalConductivityTemperatureGradientQuantity() : base()
        {
            Name = "ThermalConductivityTemperatureGradient";
            ID = new Guid("5e509f43-8fb4-490e-b9a5-59d7393761c0");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("0459940e-d71f-4b01-9ea6-eeb05d754af2"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "CaloriePerMetreSecondDegreeCelsiusPerCelsius",
          UnitLabel = "Cal/m•s•°C²",
          ID = new Guid("eb08ff8c-d542-440f-a4c7-610653018910"),
          ConversionFactorFromSI = 0.238846
        },
        new UnitChoice
        {
          UnitName = "CaloriePerCentimetreSecondDegreeCelsiusPerCelsius",
          UnitLabel = "Cal/cm•s•°C²",
          ID = new Guid("6c21a6cd-61fe-4086-95a7-ad6d6820c96e"),
          ConversionFactorFromSI = 0.00238846
        },
        new UnitChoice
        {
          UnitName = "BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit",
          UnitLabel = "BUT/h•ft•°F²",
          ID = new Guid("b79509ea-8c03-4538-9974-208f7e0ee40e"),
          ConversionFactorFromSI = 0.32099405555555555
        },
        new UnitChoice
        {
          UnitName = "BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit",
          UnitLabel = "BUT•in/h•ft²•°F²",
          ID = new Guid("918b4e34-3986-427f-8bb6-c09740a7c299"),
          ConversionFactorFromSI = 3.8519288888888887
        }
      };
        }
    }
}
