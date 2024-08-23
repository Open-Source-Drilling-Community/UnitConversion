using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SpecificHeatCapacityGradientPerTemperatureQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "joule per kilogram squared kelvin";
        public override string SIUnitLabel { get; } = "J/kg•K²";
        public override double LengthDimension { get; } = 2;
        public override double TimeDimension { get; } = -2;
        public override double TemperatureDimension { get; } = -2;
        private static SpecificHeatCapacityGradientPerTemperatureQuantity instance_ = null;

        public static SpecificHeatCapacityGradientPerTemperatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SpecificHeatCapacityGradientPerTemperatureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public static List<UnitChoice> UnitChoiceDescriptions = new List<UnitChoice>()
        {
        new UnitChoice
        {
          UnitName = "joule per kilogram squared kelvin",
          UnitLabel = "J/kg•K²",
          ID = new Guid("9570fd84-ff2e-4a74-93b7-39bcf6558301"),
          ConversionFactorFromSIFormula = "1.0/Factors.Unit",
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "joule per gram squared kelvin",
          UnitLabel = "J/g•K²",
          ID = new Guid("69520d03-c7c3-483f-bbbb-6bdf3cf74463"),
          ConversionFactorFromSIFormula = "Factors.Milli"
        },
        new UnitChoice
        {
          UnitName = "joule per gram degree squared celsius",
          UnitLabel = "J/g•°C²",
          ID = new Guid("9ed03436-3032-4bee-a145-fd03b6236816"),
          ConversionFactorFromSIFormula = "Factors.Milli"
        },
        new UnitChoice
        {
          UnitName = "calorie per gram degree squared celsius",
          UnitLabel = "cal/g•°C²",
          ID = new Guid("ad3fe4d1-3286-4313-9f45-f2110b7ca6f2"),
          ConversionFactorFromSIFormula = "Factors.Milli/Factors.Calorie"
        },
        new UnitChoice
        {
          UnitName = "british thermal unit per pound squared degree fahrenheit ",
          UnitLabel = "BTU/lb•°F²",
          ID = new Guid("57264532-79b7-4a19-8ffe-617bba781be3"),
          ConversionFactorFromSIFormula = "Factors.Pound*Factors.FahrenheitSlope*Factors.FahrenheitSlope/Factors.BTU"
        }
        };
        public SpecificHeatCapacityGradientPerTemperatureQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "specific heat capacity gradient per temperature" };
            ID = new Guid("3a317540-3db4-47a1-a566-33b6f39b7540");
            DescriptionMD = string.Empty;
            DescriptionMD += @"A specific heat capacity gradient per temperature is the first derivative of a specific heat capacity compared to the temperature: $\frac{dC_p}{dT}$, where $C_p$ is a specific heat capacity and $T$ is a temperature." + Environment.NewLine;
            DescriptionMD += @"The dimension of specific heat capacity gradient per temperature is:" + Environment.NewLine;
            DescriptionMD += "$" + GetDimensionsMD() + "$." + Environment.NewLine;
            InitializeUnitChoices();
        }
    }
}
