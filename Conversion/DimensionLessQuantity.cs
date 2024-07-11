using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DimensionlessQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "Dimensionless";
        public override string SIUnitLabel { get; } = "";
        private static DimensionlessQuantity instance_ = null;

        public static DimensionlessQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DimensionlessQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DimensionlessQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Dimensionless" };
            ID = new Guid("790ae2cd-170c-4908-b2b9-163ba95f5b43");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("8744b0f7-2866-42d8-bf6c-b619ac87b945"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        }
      };
        }
    }
}
