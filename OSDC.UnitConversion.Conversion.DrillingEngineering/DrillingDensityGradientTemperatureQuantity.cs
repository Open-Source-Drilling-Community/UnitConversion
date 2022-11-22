using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingDensityGradientTemperatureQuantity : DensityGradientTemperatureQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static DrillingDensityGradientTemperatureQuantity instance_ = null;

        public static new DrillingDensityGradientTemperatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingDensityGradientTemperatureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingDensityGradientTemperatureQuantity() : base()
        {
            Name = "DrillingDensityGradientTemperature";
            ID = new Guid("b5ccd49c-a9fd-4cfd-8dd1-fb4d3f8c3ad5");
            Reset();
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.KilogramPerCubicMeterPerKelvin));
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.GramPerCubicCentimeterPerCelsius));
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUKPerCelsius));
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit));
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.SpecificGravityPerCelsius));
        }

    }
}
