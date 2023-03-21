using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingFluidShearRateQuantity : FluidShearRateQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1E-02;

        private static DrillingFluidShearRateQuantity instance_ = null;

        public static new DrillingFluidShearRateQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingFluidShearRateQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingFluidShearRateQuantity() : base()
        {
            Name = "DrillingFluidShearRate";
            ID = new Guid("f4254261-59d7-4ba6-8ffa-f653df8e181a");
            Reset();
            this.UnitChoices.Add(FluidShearRateQuantity.Instance.GetUnitChoice(FluidShearRateQuantity.UnitChoicesEnum.Hertz));
            this.UnitChoices.Add(FluidShearRateQuantity.Instance.GetUnitChoice(FluidShearRateQuantity.UnitChoicesEnum.ReciprocalSecond));
        }
    }
}
