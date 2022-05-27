using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class BlockVelocityQuantity : VelocityQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.01;
        private static BlockVelocityQuantity instance_ = null;

        public static new BlockVelocityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new BlockVelocityQuantity();
                }
                return instance_;
            }
        }
        protected BlockVelocityQuantity() : base()
        {
            Name = "BlockVelocity";
            ID = new Guid("82a2b5fc-9edd-45ea-80cb-1cd46d516fdb");
            Reset();
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond));
            PostProcess();
        }
    }
}
