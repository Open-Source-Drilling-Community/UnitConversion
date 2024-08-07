using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PressureLossConstantQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "pressure loss constant SI";
        public override string SIUnitLabel { get; } = "(m³/s)²•(kg/m³)/Pa";
        public override double LengthDimension { get; } = 4;
        private static PressureLossConstantQuantity instance_ = null;

        public static PressureLossConstantQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PressureLossConstantQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public PressureLossConstantQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Pressure Loss Constant" };
            ID = new Guid("6417f6e0-969d-43f2-bee6-249199ec1697");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("e0b334c4-2e44-4b1b-891f-9deae86a4d17"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "pressure loss constant metric",
                    UnitLabel = "(l/min)²•sg/bar",
                    ID = new Guid("043fbd34-1e4f-45bc-9935-b1797b606fd6"),
                    ConversionFactorFromSI = 360000000000
                },
                new UnitChoice
                {
                    UnitName = "pressure loss constant UK",
                    UnitLabel = "gpmuk²•ppguk/psi",
                    ID = new Guid("d5a97f2d-cb2f-449f-8f60-0ad292a01b87"),
                    ConversionFactorFromSI = 12036978643.119
                },
                new UnitChoice
                {
                    UnitName = "pressure loss constant US",
                    UnitLabel = "gpmus²•ppgus/psi",
                    ID = new Guid("b5cb21d1-0e71-4ab2-8d9d-42de21753edc"),
                    ConversionFactorFromSI = 14455817187.722
                }
            };
        }
    }
}
