using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class MassGradientQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "kilogram per metre";
        public override string SIUnitLabel { get; } = "kg/m";
        public override double LengthDimension { get; } = -1;
        public override double MassDimension { get; } = 1;
        private static MassGradientQuantity instance_ = null;

        public static MassGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MassGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public MassGradientQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Mass Gradient" };
            ID = new Guid("b8694592-8f8d-4684-b0ba-c88de50c8486");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("c8b4a6ea-29bf-4e5a-b7ce-9142cefc0752"),
                    ConversionFactorFromSI = 1.0/Factors.Unit,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "pound per foot",
                    UnitLabel = "lb/ft",
                    ID = new Guid("6fdf4cb6-a43b-482d-9bc8-d4ad49770f9e"),
                    ConversionFactorFromSI = Factors.Foot/Factors.Pound
                },
                new UnitChoice
                {
                    UnitName = "gram per metre",
                    UnitLabel = "g/m",
                    ID = new Guid("0cea1e32-9adb-4882-9070-d027cd0eef8e"),
                    ConversionFactorFromSI = 1.0/Factors.Milli
                }
            };
        }
    }
}
