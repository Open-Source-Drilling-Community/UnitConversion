using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class StandardDimensionLessQuantity : DimensionLessQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.001;

        private static StandardDimensionLessQuantity instance_ = null;

        public static new StandardDimensionLessQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new StandardDimensionLessQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public StandardDimensionLessQuantity() : base()
        {
            Name = "StandardDimensionLess";
            ID = new Guid("5d356437-ab4e-4de7-8219-1f4988315dee");
            Reset();
            this.UnitChoices.Add(DimensionLessQuantity.Instance.GetUnitChoice(DimensionLessQuantity.UnitChoicesEnum.DimensionLess));
        }
    }
}