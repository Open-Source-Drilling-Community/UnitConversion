using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ElectricCurrentQuantity : SymbolizedBasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "I";
        public override string SIUnitName { get; } = "ampere";
        public override string SIUnitLabel { get; } = "A";
        private static ElectricCurrentQuantity instance_ = null;
        public override double ElectricCurrentDimension { get; } = 1;

        public static ElectricCurrentQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ElectricCurrentQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public ElectricCurrentQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Electrical Current" };
            ID = new Guid("a322deae-e965-41bf-b4fe-a7530d33c9a0");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("1cd2ef0e-baf8-43fb-9fac-64f84560d0a9"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "coulomb per second",
                    UnitLabel = "C/s",
                    ID = new Guid("0a9cc349-3bac-4f44-9a9b-3940ae595f03"),
                    ConversionFactorFromSI = 1.0
                },
                new UnitChoice
                {
                    UnitName = "siemens volt",
                    UnitLabel = "S.V",
                    ID = new Guid("52bc6bd9-f25d-470b-9068-b6e87f1f2ed0"),
                    ConversionFactorFromSI = 1.0
                },
                new UnitChoice
                {
                    UnitName = "volt per ohm",
                    UnitLabel = "V/Ω",
                    ID = new Guid("100dd38e-19ad-465c-a995-0fb1174e506b"),
                    ConversionFactorFromSI = 1.0
                },
                new UnitChoice
                {
                    UnitName = "watt per volt",
                    UnitLabel = "W/V",
                    ID = new Guid("29464509-67a2-4062-b78a-8156e54cfa88"),
                    ConversionFactorFromSI = 1.0
                },
                new UnitChoice
                {
                    UnitName = "weber per henry",
                    UnitLabel = "Wb/H",
                    ID = new Guid("bf3285f5-34be-4592-822d-f6ffc3ce4858"),
                    ConversionFactorFromSI = 1.0
                },
                new UnitChoice
                {
                    UnitName = "deciampere",
                    UnitLabel = "dA",
                    ID = new Guid("fdca0a23-f088-4a93-8bfa-4776d19dc26e"),
                    ConversionFactorFromSI = 10.0
                },
                new UnitChoice
                {
                    UnitName = "centiampere",
                    UnitLabel = "cA",
                    ID = new Guid("f057be23-0f56-4a5f-bb39-3ec032b66ff8"),
                    ConversionFactorFromSI = 100.0
                },
                new UnitChoice
                {
                    UnitName = "milliampere",
                    UnitLabel = "mA",
                    ID = new Guid("a2b3179e-3003-48eb-82aa-80fbfb2cfe39"),
                    ConversionFactorFromSI = 1000.0
                },
                new UnitChoice
                {
                    UnitName = "microampere",
                    UnitLabel = "µA",
                    ID = new Guid("fb4dfa70-2011-468a-9c4a-06aba3754fc2"),
                    ConversionFactorFromSI = 1000000.0
                },
                new UnitChoice
                {
                    UnitName = "nanoampere",
                    UnitLabel = "nA",
                    ID = new Guid("f5f75652-d393-4328-87f0-6132fd8dc786"),
                    ConversionFactorFromSI = 1000000000.0
                },
                new UnitChoice
                {
                    UnitName = "picoampere",
                    UnitLabel = "pA",
                    ID = new Guid("9c5c1ea2-89bc-48f8-83ab-fbde7b1f3721"),
                    ConversionFactorFromSI = 1000000000000.0
                },
                new UnitChoice
                {
                    UnitName = "biot",
                    UnitLabel = "Bi",
                    ID = new Guid("4648ec96-2c82-4aa2-8de3-d6eb105f470e"),
                    ConversionFactorFromSI = 0.1
                },
                 new UnitChoice
                {
                    UnitName = "abampere",
                    UnitLabel = "abA",
                    ID = new Guid("d589a05d-d6a4-4d2d-9ec7-3a02d0de2ef0"),
                    ConversionFactorFromSI = 0.1
                },
               new UnitChoice
                {
                    UnitName = "kiloampere",
                    UnitLabel = "kA",
                    ID = new Guid("5a500f57-a5d1-41c2-9b8d-b08757420bb8"),
                    ConversionFactorFromSI = 0.001
                },
                new UnitChoice
                {
                    UnitName = "megaampere",
                    UnitLabel = "MA",
                    ID = new Guid("978af2aa-e776-43d6-bfe6-4055b6d602e8"),
                    ConversionFactorFromSI = 0.000001
                },
                new UnitChoice
                {
                    UnitName = "gigaampere",
                    UnitLabel = "GA",
                    ID = new Guid("eb1b76cd-4863-4cf3-b421-1cd80d2fb0b4"),
                    ConversionFactorFromSI = 0.000000001
                },
                new UnitChoice
                {
                    UnitName = "teraampere",
                    UnitLabel = "TA",
                    ID = new Guid("4bf45d0a-e177-45b9-8a40-f8f51d5b15c6"),
                    ConversionFactorFromSI = 0.000000000001
                },
                new UnitChoice
                {
                    UnitName = "gilbert",
                    UnitLabel = "Gi",
                    ID = new Guid("2f036ab5-992d-4dff-beef-2e2fad2f5379"),
                    ConversionFactorFromSI = 1.256637
                },
                new UnitChoice
                {
                    UnitName = "statampere",
                    UnitLabel = "stA",
                    ID = new Guid("7d9a22ac-62d8-476d-8429-bc41febbe707"),
                    ConversionFactorFromSI = 2997924536.843143
                }
            };
        }
    }
}
