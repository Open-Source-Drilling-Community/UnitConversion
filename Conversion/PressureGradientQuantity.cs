using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PressureGradientQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "pascal per metre";
        public override string SIUnitLabel { get; } = "Pa/m";
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
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public PressureGradientQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Pressure Gradient" };
            ID = new Guid("62eb6afe-bd7d-48dd-b4fd-de40e9f3c632");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("f5a37831-4a70-44de-af34-4f6ce1a54af3"),
                    ConversionFactorFromSI = 1.0/Factors.Unit,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "bar per metre",
                    UnitLabel = "bar/m",
                    ID = new Guid("73a70891-87cf-44fc-8437-94938f034eec"),
                    ConversionFactorFromSI = 1.0/Factors.Bar
                },
                new UnitChoice
                {
                    UnitName = "psi per metre",
                    UnitLabel = "psi/m",
                    ID = new Guid("2235a51b-cdf2-4f53-9664-b7a968dbbba3"),
                    ConversionFactorFromSI = 1.0/Factors.PSI
                },
                new UnitChoice
                {
                    UnitName = "psi per foot",
                    UnitLabel = "psi/ft",
                    ID = new Guid("b99cef5c-d6df-4803-b52b-6050cf7e7ff8"),
                    ConversionFactorFromSI = Factors.Foot/Factors.PSI
                }
            };
        }
    }
}