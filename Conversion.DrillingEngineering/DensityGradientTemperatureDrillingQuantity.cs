using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DensityGradientTemperatureDrillingQuantity : DensityGradientTemperatureQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static DensityGradientTemperatureDrillingQuantity instance_ = null;

        public static new DensityGradientTemperatureDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityGradientTemperatureDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DensityGradientTemperatureDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Density Gradient Temperature (drilling)" };
            ID = new Guid("b5ccd49c-a9fd-4cfd-8dd1-fb4d3f8c3ad5");
            Reset();
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.KilogramPerCubicMetrePerKelvin));
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.GramPerCubicCentimetrePerCelsius));
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUKPerCelsius));
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit));
            this.UnitChoices.Add(DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.SpecificGravityPerCelsius));
        }

    }
}
