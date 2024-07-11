using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class BlockVelocityQuantity : VelocityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static BlockVelocityQuantity instance_ = null;

        public static new BlockVelocityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new BlockVelocityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public BlockVelocityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Block Velocity (drilling)" };
            ID = new Guid("82a2b5fc-9edd-45ea-80cb-1cd46d516fdb");
            Reset();
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MetrePerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MetrePerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MetrePerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond));
        }
    }
}
