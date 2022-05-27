using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class VelocityQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "v";
        public override string SIUnitName { get; } = "MeterPerSecond";
        public override string SIUnitLabel { get; } = "m/s";
        public override double LengthDimension { get; } = 1;
        public override double TimeDimension { get; } = -1;
        private static VelocityQuantity instance_ = null;

        public static VelocityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new VelocityQuantity();
                }
                return instance_;
            }
        }
        protected VelocityQuantity() : base()
        {
            Name = "Velocity";
            ID = new Guid("b3fd17fe-ce71-4ef3-ac99-cf4f5756e81a");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "MeterPerMinute",
          UnitLabel = "m/min",
          ID = new Guid("824d3b5b-1e51-446a-99a4-39c02377f303"),
          ConversionFactorFromSI = 60
        },
        new UnitChoice
        {
          UnitName = "CentimeterPerSecond",
          UnitLabel = "cm/s",
          ID = new Guid("d32f84d7-f076-49ab-8bd5-1ccd27e0eba6"),
          ConversionFactorFromSI = 100
        },
        new UnitChoice
        {
          UnitName = "MeterPerHour",
          UnitLabel = "m/h",
          ID = new Guid("b4867c19-0668-4043-b3b9-f666f7552b02"),
          ConversionFactorFromSI = 3600
        },
                new UnitChoice
        {
          UnitName = "MeterPerDay",
          UnitLabel = "m/d",
          ID = new Guid("aa10055f-1ef6-460d-841c-b6dc69f6a7f2"),
          ConversionFactorFromSI = 3600 * 24
        },
        new UnitChoice
        {
          UnitName = "FootPerHour",
          UnitLabel = "ft/h",
          ID = new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170"),
          ConversionFactorFromSI = 11811.023622
        },
        new UnitChoice
        {
          UnitName = "FootPerDay",
          UnitLabel = "ft/d",
          ID = new Guid("aa58ec87-0dbc-4ed4-b8aa-8553b02c7b14"),
          ConversionFactorFromSI = 11811.023622 * 24.0
        },
    new UnitChoice
        {
          UnitName = "FootPerMinute",
          UnitLabel = "ft/m",
          ID = new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076"),
          ConversionFactorFromSI = 196.8503936
        },
        new UnitChoice
        {
          UnitName = "FootPerSecond",
          UnitLabel = "ft/s",
          ID = new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa"),
          ConversionFactorFromSI = 3.280839894
        },
        new UnitChoice
        {
          UnitName = "InchPerSecond",
          UnitLabel = "in/s",
          ID = new Guid("8cd16c97-5c7a-4ee9-b59b-cbe2decd8ff9"),
          ConversionFactorFromSI = 1.0 / 0.0254
        },

        new UnitChoice
        {
          UnitName = "MilePerHour",
          UnitLabel = "mph",
          ID = new Guid("6c6d0be3-5b60-4b8a-9fd6-8b7afb261081"),
          ConversionFactorFromSI = 2.236936
        }
      };
            PostProcess();
        }
    }
}
