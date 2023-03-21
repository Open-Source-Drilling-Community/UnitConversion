using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingFluidShearStressQuantity : FluidShearStressQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1E-04;

        private static DrillingFluidShearStressQuantity instance_ = null;

        public static new DrillingFluidShearStressQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingFluidShearStressQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingFluidShearStressQuantity() : base()
        {
            Name = "DrillingFluidShearStress";
            ID = new Guid("828ccbc1-5d0e-4fd9-b552-4b54b22c108e");
            Reset();
            this.UnitChoices.Add(FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.PoundPer100SquareFoot));
            this.UnitChoices.Add(FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.PoundPerSquareFoot));
            this.UnitChoices.Add(FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.DynesPerSquareCentimeter));
            this.UnitChoices.Add(FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.PoundPerSquareInch));
        }
    }
}
