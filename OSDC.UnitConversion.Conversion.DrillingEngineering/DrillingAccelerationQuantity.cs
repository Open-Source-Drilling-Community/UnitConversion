using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingAccelerationQuantity : AccelerationQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.001;

        private static DrillingAccelerationQuantity instance_ = null;

        public static new DrillingAccelerationQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingAccelerationQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingAccelerationQuantity() : base()
        {
            Name = "DrillingAcceleration";
            ID = new Guid("b6c99136-8e57-4eea-9a31-fb804bc8ae4b");
            Reset();
            this.UnitChoices.Add(AccelerationQuantity.Instance.GetUnitChoice(AccelerationQuantity.UnitChoicesEnum.MeterPerSecondSquare));
            this.UnitChoices.Add(AccelerationQuantity.Instance.GetUnitChoice(AccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare));
        }

    }
}
