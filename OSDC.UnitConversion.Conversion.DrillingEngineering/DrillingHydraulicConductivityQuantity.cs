using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingHydraulicConductivityQuantity : HydraulicConductivityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;
        private static DrillingHydraulicConductivityQuantity instance_ = null;

        public static new DrillingHydraulicConductivityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingHydraulicConductivityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingHydraulicConductivityQuantity() : base()
        {
            Name = "DrillingHydraulicConductivity";
            ID = new Guid("6cc821d6-b979-4bf9-b1cc-ac266b221330");
            Reset();
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerDay));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerDay));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.CentimeterPerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.InchPerSecond));
        }

    }
}
