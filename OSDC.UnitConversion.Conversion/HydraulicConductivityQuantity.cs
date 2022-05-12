using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class HydraulicConductivityQuantity : VelocityQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "MeterPerSecond";
        public override string SIUnitSymbol { get; } = "m/s";
        private static HydraulicConductivityQuantity instance_ = null;

        public static new HydraulicConductivityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new HydraulicConductivityQuantity();
                }
                return instance_;
            }
        }
        protected HydraulicConductivityQuantity() : base()
        {
            Name = "HydraulicConductivity";
            ID = new Guid("04df2b82-aff0-485a-855e-3d2aa53e12eb");
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
            PostProcess();
        }
    }
}
