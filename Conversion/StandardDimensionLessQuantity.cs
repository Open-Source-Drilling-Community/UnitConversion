using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class StandardDimensionlessQuantity : DimensionlessQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static StandardDimensionlessQuantity instance_ = null;

        public static new StandardDimensionlessQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new StandardDimensionlessQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public StandardDimensionlessQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Standard Dimensionless" };
            ID = new Guid("5d356437-ab4e-4de7-8219-1f4988315dee");
            Reset();
            this.UnitChoices.Add(DimensionlessQuantity.Instance.GetUnitChoice(DimensionlessQuantity.UnitChoicesEnum.Dimensionless));
        }
    }
}
