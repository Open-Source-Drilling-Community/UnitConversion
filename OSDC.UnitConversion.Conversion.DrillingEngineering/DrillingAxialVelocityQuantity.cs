using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingAxialVelocityQuantity : VelocityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static DrillingAxialVelocityQuantity instance_ = null;

        public static new DrillingAxialVelocityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingAxialVelocityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DrillingAxialVelocityQuantity() : base()
        {
            Name = "DrillingAxialVelocity";
            ID = new Guid("e278ace8-d577-4fb4-8d1d-dd8a3d072027");
            Reset();
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond));
        }
    }
}
