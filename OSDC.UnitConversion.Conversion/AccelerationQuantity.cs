using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AccelerationQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "γ";
        public override string SIUnitName { get; } = "MeterPerSecondSquare";
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
            Name = "Acceleration";
            ID = new Guid("454a7b6b-a921-428e-8aa7-a4a636a58e34");
            UnitChoices = new List<UnitChoice>()
            {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("20515c0b-8a90-4e76-a2b3-cab213db5a06"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "FootPerSecondSquare",
          UnitLabel = "ft/s²",
          ID = new Guid("74f20b52-6c15-40e2-ae23-5493326fc879"),
          ConversionFactorFromSI = 1.0/0.3048
        },
        new UnitChoice
        {
          UnitName = "CentimeterPerSecondSquare",
          UnitLabel = "cm/s²",
          ID = new Guid("4dc923c6-81db-4bd1-aa2c-933966ebbef4"),
          ConversionFactorFromSI = 100.0
        },
         new UnitChoice
        {
          UnitName = "CentimeterPerHourPerSecond",
          UnitLabel = "cm/(h.s)",
          ID = new Guid("b469c349-fd35-4802-b408-dd6f86d62d27"),
          ConversionFactorFromSI = 360000.0
        },
        new UnitChoice
        {
          UnitName = "CentimeterPerMinutePerSecond",
          UnitLabel = "cm/(min.s)",
          ID = new Guid("e681e123-03d7-42eb-9ef5-33da76a6d78c"),
          ConversionFactorFromSI = 60000.0
        },
        new UnitChoice
        {
          UnitName = "FootPerHourPerSecond",
          UnitLabel = "ft/(h.s)",
          ID = new Guid("ccdc1097-4386-4e78-beff-438807b0d52c"),
          ConversionFactorFromSI = 1.0/8.46667e-5
        },
        new UnitChoice
        {
          UnitName = "FootPerMinutePerSecond",
          UnitLabel = "ft/(min.s)",
          ID = new Guid("eea429f4-ada7-4c40-adc0-4054dde8549a"),
          ConversionFactorFromSI = 1.0/0.00508
        },
        new UnitChoice
        {
          UnitName = "Galileo",
          UnitLabel = "Gal",
          ID = new Guid("a88f1f6d-e025-47b8-802a-0c802f730824"),
          ConversionFactorFromSI = 100.0
        },
        new UnitChoice
        {
          UnitName = "GravityStandard",
          UnitLabel = "gn",
          ID = new Guid("94dcb02d-04d9-4613-b3c0-d3bdcc3ce382"),
          ConversionFactorFromSI = 1.0/9.089665
        },
        new UnitChoice
        {
          UnitName = "InchPerHourPerSecond",
          UnitLabel = "in/(h.s)",
          ID = new Guid("16cc4dc1-0fb0-4bfa-acc2-55a754ab47f9"),
          ConversionFactorFromSI = 1.0/7.05556e-6
        },
        new UnitChoice
        {
          UnitName = "InchPerMinutePerSecond",
          UnitLabel = "in/(min.s)",
          ID = new Guid("e33ae152-f371-4b4c-aaf7-51e5635cbcaa"),
          ConversionFactorFromSI = 1.0/4.23333e-4
        },
        new UnitChoice
        {
          UnitName = "InchPerSecondSquare",
          UnitLabel = "in/s²",
          ID = new Guid("2c872353-889f-444a-a182-1a1d3fd09bb3"),
          ConversionFactorFromSI = 1.0/0.0254
        },
        new UnitChoice
        {
          UnitName = "KnotPerSecond",
          UnitLabel = "kn/s",
          ID = new Guid("eefbcd14-1031-4763-8a5d-a9fc8c4fc833"),
          ConversionFactorFromSI = 1.0/0.514444
        },
        new UnitChoice
        {
          UnitName = "MeterPerSecondPerMillisecond",
          UnitLabel = "m/(s.ms)",
          ID = new Guid("ecefe9c4-9d38-4fd8-8f56-482f7c54874e"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "MilePerHourPerSecond",
          UnitLabel = "mi/(h.s)",
          ID = new Guid("622bde1c-57b2-4845-8a14-c252a0f6c0df"),
          ConversionFactorFromSI = 1.0/0.44704
        },
        new UnitChoice
        {
          UnitName = "MilePerMinutePerSecond",
          UnitLabel = "mi/(min.s)",
          ID = new Guid("f58cace4-7e55-4218-ad64-5c3e420efe02"),
          ConversionFactorFromSI = 1.0/26.8244
        },
        new UnitChoice
        {
          UnitName = "MilePerSecondSquare",
          UnitLabel = "mi/s²",
          ID = new Guid("4f91adee-52ad-420b-94a8-5b45ab0399a9"),
          ConversionFactorFromSI = 1.0/1609.344
        },
        new UnitChoice
        {
          UnitName = "KilometerPerSecondSquare",
          UnitLabel = "km/s²",
          ID = new Guid("8b77b272-564a-4637-83cf-bf9d08d231db"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "KilometerPerHourPerSecond",
          UnitLabel = "km/(h.s)",
          ID = new Guid("9f74f510-f9ce-4393-9d9d-83518519e42a"),
          ConversionFactorFromSI = 3.6
        },
        new UnitChoice
        {
          UnitName = "KilometerPerMinutePerSecond",
          UnitLabel = "km/(min.s)",
          ID = new Guid("aaaba47c-f11e-44fa-b5df-e981f6356f5a"),
          ConversionFactorFromSI = 0.06
        }
            };
        }
    }
}
