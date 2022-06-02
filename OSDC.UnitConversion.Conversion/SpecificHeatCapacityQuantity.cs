using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SpecificHeatCapacityQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "JoulePerKilogramKelvin";
        public override string SIUnitLabel { get; } = "J/kg•K";
        public override double LengthDimension { get; } = 2;
        public override double TimeDimension { get; } = -2;
        public override double TemperatureDimension { get; } = -1;
        private static SpecificHeatCapacityQuantity instance_ = null;

        public static SpecificHeatCapacityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SpecificHeatCapacityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public SpecificHeatCapacityQuantity() : base()
        {
            Name = "SpecificHeatCapacity";
            ID = new Guid("e5c75fa9-0102-42dc-bb0c-830fe9fca2b9");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("52d9523e-546b-41dd-b283-a125447433a3"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "JoulePerGramKelvin",
          UnitLabel = "J/g•k",
          ID = new Guid("0c38001b-ecba-4920-ac75-e4644d8feced"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "JoulePerGramDegreeCelsius",
          UnitLabel = "J/g•°C",
          ID = new Guid("5b620d63-2269-42d3-8385-edca04c7ea70"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "CaloriePerGramDegreeCelsius",
          UnitLabel = "Cal/g•°C",
          ID = new Guid("bb241c58-e76c-4d96-81c1-356b3f2ad397"),
          ConversionFactorFromSI = 0.0002388459
        },
        new UnitChoice
        {
          UnitName = "BritishThermalUnitPerPoundDegreeFarenheit",
          UnitLabel = "BTU/lb•°F",
          ID = new Guid("ad9274f2-4c1a-45fe-97c1-710f00deca16"),
          ConversionFactorFromSI = 0.0002388459
        }
      };
        }
    }
}
