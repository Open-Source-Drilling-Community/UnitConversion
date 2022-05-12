using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SpecificHeatCapacityTemperatureGradientQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "JoulePerKilogramKelvinPerKelvin";
        public override string SIUnitSymbol { get; } = "J/kg•K²";
        public override double LengthDimension { get; } = 2;
        public override double TimeDimension { get; } = -2;
        public override double TemperatureDimension { get; } = -2;
        private static SpecificHeatCapacityTemperatureGradientQuantity instance_ = null;

        public static SpecificHeatCapacityTemperatureGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SpecificHeatCapacityTemperatureGradientQuantity();
                }
                return instance_;
            }
        }
        protected SpecificHeatCapacityTemperatureGradientQuantity() : base()
        {
            Name = "SpecificHeatCapcityTemperatureGradient";
            ID = new Guid("3a317540-3db4-47a1-a566-33b6f39b7540");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitSymbol = SIUnitSymbol,
          ID = new Guid("9570fd84-ff2e-4a74-93b7-39bcf6558301"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "JoulePerGramKelvinPerKelvin",
          UnitSymbol = "J/g•K²",
          ID = new Guid("69520d03-c7c3-483f-bbbb-6bdf3cf74463"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "JoulePerGramDegreeCelsiusPerCelsius",
          UnitSymbol = "J/g•°C²",
          ID = new Guid("9ed03436-3032-4bee-a145-fd03b6236816"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "CaloriePerGramDegreeCelsiusPerCelsius",
          UnitSymbol = "Cal/g•°C²",
          ID = new Guid("ad3fe4d1-3286-4313-9f45-f2110b7ca6f2"),
          ConversionFactorFromSI = 0.0002388459
        },
        new UnitChoice
        {
          UnitName = "BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit",
          UnitSymbol = "BTU/lb•°F²",
          ID = new Guid("57264532-79b7-4a19-8ffe-617bba781be3"),
          ConversionFactorFromSI = 0.00013269216666666667
        }
      };
            PostProcess();
        }
    }
}
