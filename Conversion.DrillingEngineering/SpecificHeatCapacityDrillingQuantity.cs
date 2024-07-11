using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class SpecificHeatCapacityDrillingQuantity : SpecificHeatCapacityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static SpecificHeatCapacityDrillingQuantity instance_ = null;

        public static new SpecificHeatCapacityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SpecificHeatCapacityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public SpecificHeatCapacityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Specific Heat Capacity (drilling)" };
            ID = new Guid("05c59293-4e3b-4fc0-b579-12c241109610");
            Reset();
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerKilogramKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerGramKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerGramDegreeCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.CaloriePerGramDegreeCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit));
        }

    }
}
