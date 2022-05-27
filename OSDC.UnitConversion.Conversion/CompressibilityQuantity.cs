using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class CompressibilityQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "β";
        public override string SIUnitName { get; } = "InversePascal";
        public override string SIUnitLabel { get; } = "1/Pa";
        public override double MassDimension { get; } = -1;
        public override double LengthDimension { get; } = 1;
        public override double TimeDimension { get; } = 1;
        private static CompressibilityQuantity instance_ = null;

        public static CompressibilityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new CompressibilityQuantity();
                }
                return instance_;
            }
        }
        protected CompressibilityQuantity() : base()
        {
            Name = "Compressibility";
            ID = new Guid("1e7af8b8-0267-4d5d-a162-59123a8fde14");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("0e259998-c8bb-4a4d-b281-afb8008b2693"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "InverseBar",
          UnitLabel = "1/bar",
          ID = new Guid("4a0f6df4-0d2d-489b-80f1-511be7713101"),
          ConversionFactorFromSI = 100000
        },
        new UnitChoice
        {
          UnitName = "InversePoundPerSquareInch",
          UnitLabel = "1/psi",
          ID = new Guid("282ab24c-6c43-4710-8e52-433bdf90cc2e"),
          ConversionFactorFromSI = 6894.7625831
        }
      };
            PostProcess();
        }
    }
}
