using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class RelativeTemperatureQuantity : TemperatureQuantity
    {

        private static RelativeTemperatureQuantity instance_ = null;

        public static RelativeTemperatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RelativeTemperatureQuantity();
                }
                return instance_;
            }
        }

        protected RelativeTemperatureQuantity() : base()
        {
            Name = "Relative Temperature";
            ID = new Guid("58dadec7-7858-414b-8d7b-66504d5c2793");
            Reset();
            this.UnitChoices.Add(TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Kelvin));
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "Relative Celcius",
                UnitSymbol = "°C",
                ID = new Guid("10ea31a1-e661-41c9-9a3d-245904b73599"),
                ConversionFactorFromSI = 1.0,
                IsMetric = true
            }
            );
            this.UnitChoices.Add(new UnitChoice()
            {
                UnitName = "Rankine",
                UnitSymbol = "°R",
                ID = new Guid("62f3ffbc-eda3-400a-9fb7-8d021771f0fa"),
                ConversionFactorFromSI = 9.0 / 5.0,
                IsUS = true,
                IsImperial = true
            }
            );
            PostProcess();
        }
    }
}
