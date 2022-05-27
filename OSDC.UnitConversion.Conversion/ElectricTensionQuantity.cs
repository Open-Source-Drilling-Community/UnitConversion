using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ElectricTensionQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "Volt";
        public override string SIUnitLabel { get; } = "V";
        public override double LengthDimension { get; } = 2;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -3;
        public override double ElectricCurrentDimension { get; } = -1;
        public override double? MeaningFullPrecisionInSI { get; } = 0.01;
        private static ElectricTensionQuantity instance_ = null;

        public static ElectricTensionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ElectricTensionQuantity();
                }
                return instance_;
            }
        }
        protected ElectricTensionQuantity() : base()
        {
            Name = "ElectricTension";
            ID = new Guid("da5094a4-7481-4246-9def-1bd3b6f893a1");
            UnitChoices = new List<UnitChoice>()
            {
        new UnitChoice
        {
          UnitName = "Volt",
          UnitLabel = "V",
          ID = new Guid("618fafff-fc9c-4d22-a64d-b7579931aa93"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "Millivolt",
          UnitLabel = "mV",
          ID = new Guid("f186f5d4-2b0b-4cfe-b24c-0c02d3155cf8"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = "Centivolt",
          UnitLabel = "cV",
          ID = new Guid("ee01194e-dee3-4b50-8312-5fde3c8f774e"),
          ConversionFactorFromSI = 100
        },
        new UnitChoice
        {
          UnitName = "Kilovolt",
          UnitLabel = "kV",
          ID = new Guid("6ffc60bc-ec9f-44d4-961b-79d9e593bf64"),
          ConversionFactorFromSI = 0.001
        }
      };
            PostProcess();
        }
    }
}
