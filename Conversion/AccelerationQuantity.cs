using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AccelerationQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "γ";
        public override string SIUnitName { get; } = "metre per second squared";
        public override string SIUnitLabel { get; } = "m/s²";
        public override double LengthDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        private static AccelerationQuantity instance_ = null;

        public static AccelerationQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AccelerationQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public AccelerationQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Acceleration" };
            ID = new Guid("454a7b6b-a921-428e-8aa7-a4a636a58e34");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = SIUnitName,
                  UnitLabel = SIUnitLabel,
                  ID = new Guid("20515c0b-8a90-4e76-a2b3-cab213db5a06"),
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                },
                new UnitChoice
                {
                  UnitName = "foot per second squared",
                  UnitLabel = "ft/s²",
                  ID = new Guid("74f20b52-6c15-40e2-ae23-5493326fc879"),
                  ConversionFactorFromSI = 1.0/Factors.Foot
                },
                new UnitChoice
                {
                  UnitName = "centimetre per second squared",
                  UnitLabel = "cm/s²",
                  ID = new Guid("4dc923c6-81db-4bd1-aa2c-933966ebbef4"),
                  ConversionFactorFromSI = 1.0/Factors.Centi
                },
                 new UnitChoice
                {
                  UnitName = "centimetre per hour per second",
                  UnitLabel = "cm/(h•s)",
                  ID = new Guid("b469c349-fd35-4802-b408-dd6f86d62d27"),
                  ConversionFactorFromSI = Factors.Hour/Factors.Centi
                },
                new UnitChoice
                {
                  UnitName = "centimetre per minute per second",
                  UnitLabel = "cm/(min•s)",
                  ID = new Guid("e681e123-03d7-42eb-9ef5-33da76a6d78c"),
                  ConversionFactorFromSI = Factors.Minute/Factors.Centi
                },
                new UnitChoice
                {
                  UnitName = "foot per hour per second",
                  UnitLabel = "ft/(h•s)",
                  ID = new Guid("ccdc1097-4386-4e78-beff-438807b0d52c"),
                  ConversionFactorFromSI = Factors.Hour/Factors.Foot
                },
                new UnitChoice
                {
                  UnitName = "foot per minute per second",
                  UnitLabel = "ft/(min•s)",
                  ID = new Guid("eea429f4-ada7-4c40-adc0-4054dde8549a"),
                  ConversionFactorFromSI = Factors.Minute/Factors.Foot
                },
                new UnitChoice
                {
                  UnitName = "galileo",
                  UnitLabel = "Gal",
                  ID = new Guid("a88f1f6d-e025-47b8-802a-0c802f730824"),
                  ConversionFactorFromSI = 1.0/Factors.Centi
                },
                new UnitChoice
                {
                  UnitName = "gravity standard",
                  UnitLabel = "gn",
                  ID = new Guid("94dcb02d-04d9-4613-b3c0-d3bdcc3ce382"),
                  ConversionFactorFromSI = 1.0/Factors.G
                },
                new UnitChoice
                {
                  UnitName = "inch per hour per second",
                  UnitLabel = "in/(h•s)",
                  ID = new Guid("16cc4dc1-0fb0-4bfa-acc2-55a754ab47f9"),
                  ConversionFactorFromSI = Factors.Hour/Factors.Inch
                },
                new UnitChoice
                {
                  UnitName = "inch per minute per second",
                  UnitLabel = "in/(min•s)",
                  ID = new Guid("e33ae152-f371-4b4c-aaf7-51e5635cbcaa"),
                  ConversionFactorFromSI = Factors.Minute/Factors.Inch
                },
                new UnitChoice
                {
                  UnitName = "inch per second squared",
                  UnitLabel = "in/s²",
                  ID = new Guid("2c872353-889f-444a-a182-1a1d3fd09bb3"),
                  ConversionFactorFromSI = 1.0/Factors.Inch
                },
                new UnitChoice
                {
                  UnitName = "knot per second",
                  UnitLabel = "kn/s",
                  ID = new Guid("eefbcd14-1031-4763-8a5d-a9fc8c4fc833"),
                  ConversionFactorFromSI = 1.0/Factors.Knot
                },
                new UnitChoice
                {
                  UnitName = "metre per second per millisecond",
                  UnitLabel = "m/(s•ms)",
                  ID = new Guid("ecefe9c4-9d38-4fd8-8f56-482f7c54874e"),
                  ConversionFactorFromSI = Factors.Milli /Factors.Unit
                },
                new UnitChoice
                {
                  UnitName = "mile per hour per second",
                  UnitLabel = "mi/(h•s)",
                  ID = new Guid("622bde1c-57b2-4845-8a14-c252a0f6c0df"),
                  ConversionFactorFromSI = Factors.Hour / Factors.Mile
                },
                new UnitChoice
                {
                  UnitName = "mile per minute per second",
                  UnitLabel = "mi/(min•s)",
                  ID = new Guid("f58cace4-7e55-4218-ad64-5c3e420efe02"),
                  ConversionFactorFromSI = Factors.Minute /Factors.Mile
                },
                new UnitChoice
                {
                  UnitName = "mile per second squared",
                  UnitLabel = "mi/s²",
                  ID = new Guid("4f91adee-52ad-420b-94a8-5b45ab0399a9"),
                  ConversionFactorFromSI = 1.0/Factors.Mile
                },
                new UnitChoice
                {
                  UnitName = "kilometre per second squared",
                  UnitLabel = "km/s²",
                  ID = new Guid("8b77b272-564a-4637-83cf-bf9d08d231db"),
                  ConversionFactorFromSI = 1.0/Factors.Kilo
                },
                new UnitChoice
                {
                  UnitName = "kilometre per hour per second",
                  UnitLabel = "km/(h•s)",
                  ID = new Guid("9f74f510-f9ce-4393-9d9d-83518519e42a"),
                  ConversionFactorFromSI = Factors.Hour/Factors.Kilo
                },
                new UnitChoice
                {
                  UnitName = "kilometre per minute per second",
                  UnitLabel = "km/(min•s)",
                  ID = new Guid("aaaba47c-f11e-44fa-b5df-e981f6356f5a"),
                  ConversionFactorFromSI = Factors.Minute/Factors.Kilo
                }
            };
        }
    }
}
