using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SpecificHeatCapacityQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "joule per kilogram kelvin";
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
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Specific Heat Capacity" };
            ID = new Guid("e5c75fa9-0102-42dc-bb0c-830fe9fca2b9");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("52d9523e-546b-41dd-b283-a125447433a3"),
          ConversionFactorFromSI = 1.0/Factors.Unit,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "joule per gram kelvin",
          UnitLabel = "J/g•K",
          ID = new Guid("0c38001b-ecba-4920-ac75-e4644d8feced"),
          ConversionFactorFromSI = Factors.Milli/Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "joule per gram degree celsius",
          UnitLabel = "J/g•°C",
          ID = new Guid("5b620d63-2269-42d3-8385-edca04c7ea70"),
          ConversionFactorFromSI = Factors.Milli/Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "calorie per gram degree celsius",
          UnitLabel = "cal/g•°C",
          ID = new Guid("bb241c58-e76c-4d96-81c1-356b3f2ad397"),
          ConversionFactorFromSI = Factors.Milli/Factors.Calorie
        },
        new UnitChoice
        {
          UnitName = "british thermal unit per pound degree fahrenheit",
          UnitLabel = "BTU/lb•°F",
          ID = new Guid("ad9274f2-4c1a-45fe-97c1-710f00deca16"),
          ConversionFactorFromSI = Factors.Pound*Factors.FahrenheitSlope/Factors.BTU
        },
        new UnitChoice
        {
          UnitName = "kilocalorie per gram degree celsius",
          UnitLabel = "Cal/g•°C",
          ID = new Guid("b283ecf7-20e4-4a6c-b62b-b07f56fa6614"),
          ConversionFactorFromSI = Factors.Milli/(Factors.Kilo*Factors.Calorie)
        }

      };
        }
    }
}
