using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DensityGradientTemperatureQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "KilogramPerCubicMeterPerKelvin";
        public override string SIUnitLabel { get; } = "kg/m³/K";
        public override double MassDimension { get; } = 1;
        public override double LengthDimension { get; } = -3;
        public override double TemperatureDimension { get; } = -1;
        private static DensityGradientTemperatureQuantity instance_ = null;

        public static DensityGradientTemperatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityGradientTemperatureQuantity();
                }
                return instance_;
            }
        }
        protected DensityGradientTemperatureQuantity() : base()
        {
            Name = "DensityGradientTemperature";
            ID = new Guid("2d788f1e-db66-49c3-8eb6-313152cd8e3c");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("8b947453-ebe8-4fa9-b59a-87557150e1cf"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "SpecificGravityPerCelsius",
          UnitLabel = "sg/°C",
          ID = new Guid("2b1d68c0-4e75-4e9d-92a1-37d501e7cb3e"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "GramPerCubicCentimeterPerCelsius",
          UnitLabel = "g/cm³/°C",
          ID = new Guid("e78e2b25-e0a7-4c06-b6df-60f97f767a20"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUKPerCelsius",
          UnitLabel = "ppgUK/°C",
          ID = new Guid("edac57eb-7535-447f-bcf9-0c6709b6ae3b"),
          ConversionFactorFromSI = 0.0030548275200000005
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUSPerFarenheit",
          UnitLabel = "ppgUS/F",
          ID = new Guid("397a5f98-842e-4d86-8fb7-f4f2f82e720b"),
          ConversionFactorFromSI = 0.00254367792,
        }
      };
            PostProcess();
        }
    }
}
