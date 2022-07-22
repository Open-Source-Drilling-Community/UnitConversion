using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingFluidVelocityQuantity : VelocityQuantity
    {
        
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static DrillingFluidVelocityQuantity instance_ = null;

        public static new DrillingFluidVelocityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingFluidVelocityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingFluidVelocityQuantity() : base()
        {
            Name = "DrillingFluidVelocity";
            ID = new Guid("dac9cee1-59a3-42d5-98c6-0c7baf5083bb");
            Reset();
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond));
        }
        
    }
}
