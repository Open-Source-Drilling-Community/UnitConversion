using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingSpecificHeatCapacityQuantity : SpecificHeatCapacityQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.01;
        private static DrillingSpecificHeatCapacityQuantity instance_ = null;

        public static new DrillingSpecificHeatCapacityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingSpecificHeatCapacityQuantity();
                }
                return instance_;
            }
        }
        protected DrillingSpecificHeatCapacityQuantity() : base()
        {
            Name = "DrillingSpecificHeatCapacity";
            ID = new Guid("05c59293-4e3b-4fc0-b579-12c241109610");
            Reset();
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerKilogramKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerGramKelvin));
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerGramDegreeCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.CaloriePerGramDegreeCelsius));
            this.UnitChoices.Add(SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit));
            PostProcess();
        }

    }
}
