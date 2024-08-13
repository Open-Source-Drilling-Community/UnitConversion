using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class FrequencyQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "hertz";
        public override string SIUnitLabel { get; } = "Hz";
        public override double TimeDimension { get; } = -1;
        private static FrequencyQuantity instance_ = null;

        public static FrequencyQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FrequencyQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public FrequencyQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Frequency" };
            ID = new Guid("8a1ff3d9-95c9-43e1-abb4-4ae9b8df861e");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("7c572c06-0699-4187-9d0c-397f479fe93d"),
                    ConversionFactorFromSI = 1.0/Factors.Unit,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "reciprocal second",
                    UnitLabel = "1/s",
                    ID = new Guid("39240f8f-8c82-4026-9db7-f72ec60cb4c9"),
                    ConversionFactorFromSI = 1.0/Factors.Unit,
                },
                new UnitChoice
                {
                    UnitName = "kilohertz",
                    UnitLabel = "kHz",
                    ID = new Guid("acf483c1-5d7a-4914-afa2-de7abed9be3e"),
                    ConversionFactorFromSI = 1.0/Factors.Kilo
                },
                new UnitChoice
                {
                    UnitName = "megahertz",
                    UnitLabel = "MHz",
                    ID = new Guid("6dea9f29-d4f4-49a7-86fe-0205d4bab45e"),
                    ConversionFactorFromSI = 1.0/Factors.Mega
                },
                new UnitChoice
                {
                    UnitName = "gigahertz",
                    UnitLabel = "GHz",
                    ID = new Guid("655ee4f9-1782-4ec0-894a-afff9b75cac7"),
                    ConversionFactorFromSI = 1.0/Factors.Giga
                },
                new UnitChoice
                {
                    UnitName = "terahertz",
                    UnitLabel = "THz",
                    ID = new Guid("9ca52ae4-2fc5-4e60-b774-79c73442de13"),
                    ConversionFactorFromSI = 1.0/Factors.Tera
                }
            };
        }
    }
}
