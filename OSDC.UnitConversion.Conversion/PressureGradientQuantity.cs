using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PressureGradientQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "PascalPerMeter";
        public override string SIUnitSymbol { get; } = "Pa/m";
        public override double LengthDimension { get; } = -2;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        private static PressureGradientQuantity instance_ = null;

        public static PressureGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PressureGradientQuantity();
                }
                return instance_;
            }
        }
        protected PressureGradientQuantity() : base()
        {
            Name = "PressureGradient";
            ID = new Guid("62eb6afe-bd7d-48dd-b4fd-de40e9f3c632");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitSymbol = SIUnitSymbol,
          ID = new Guid("f5a37831-4a70-44de-af34-4f6ce1a54af3"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "BarPerMeter",
          UnitSymbol = "bar/m",
          ID = new Guid("73a70891-87cf-44fc-8437-94938f034eec"),
          ConversionFactorFromSI = 1E-05
        },
        new UnitChoice
        {
          UnitName = "PSIPerMeter",
          UnitSymbol = "psi/m",
          ID = new Guid("2235a51b-cdf2-4f53-9664-b7a968dbbba3"),
          ConversionFactorFromSI = 0.00014503762645158165
        },
        new UnitChoice
        {
          UnitName = "PSIPerFoot",
          UnitSymbol = "psi/ft",
          ID = new Guid("b99cef5c-d6df-4803-b52b-6050cf7e7ff8"),
          ConversionFactorFromSI = 4.4207468542442094E-05
        }
      };
            PostProcess();
        }
    }
}
