using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class HeatTransferCoefficientQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "WattPerMeterSquaredPerKelvin";
        public override string SIUnitLabel { get; } = "W/m²/K";
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -3;
        public override double TemperatureDimension { get; } = -1;
        private static HeatTransferCoefficientQuantity instance_ = null;

        public static HeatTransferCoefficientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new HeatTransferCoefficientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public HeatTransferCoefficientQuantity() : base()
        {
            Name = "HeatTransferCoefficient";
            ID = new Guid("08c247bc-a55b-460e-a9a7-150faf10bdff");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("e1737353-c10b-46cd-aa4e-9c90afb2f01e"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit",
          UnitLabel = "BTU/h/ft²/°F",
          ID = new Guid("6963db25-2bd9-4017-9c83-cc578a11abbf"),
          ConversionFactorFromSI = 0.176110184
        }
      };
        }
    }
}
