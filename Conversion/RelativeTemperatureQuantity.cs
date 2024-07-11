using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class RelativeTemperatureQuantity : TemperatureQuantity
    {

        private static RelativeTemperatureQuantity instance_ = null;

        public static new RelativeTemperatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RelativeTemperatureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public RelativeTemperatureQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Relative Temperature" };
            ID = new Guid("58dadec7-7858-414b-8d7b-66504d5c2793");
            Reset();
            this.UnitChoices.Add(TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Kelvin));
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "Relative Celcius",
                UnitLabel = "°C",
                ID = new Guid("10ea31a1-e661-41c9-9a3d-245904b73599"),
                ConversionFactorFromSI = 1.0
            }
            );
            this.UnitChoices.Add(new UnitChoice()
            {
                UnitName = "Rankine",
                UnitLabel = "°R",
                ID = new Guid("62f3ffbc-eda3-400a-9fb7-8d021771f0fa"),
                ConversionFactorFromSI = 9.0 / 5.0
            }
            );
        }
    }
}
