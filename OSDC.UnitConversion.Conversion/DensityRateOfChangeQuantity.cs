using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DensityRateOfChangeQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "KilogramPerCubicMeterPerSecond";
        public override string SIUnitLabel { get; } = "kg/m³/s";
        public override double MassDimension { get; } = 1;
        public override double LengthDimension { get; } = -3;
        public override double TimeDimension { get; } = -1;
        private static DensityRateOfChangeQuantity instance_ = null;

        public static DensityRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityRateOfChangeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DensityRateOfChangeQuantity() : base()
        {
            Name = "DensitySpeed";
            ID = new Guid("be272506-8c7a-4eff-9a05-ad4d07f36e11");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("d80197aa-f0b2-4a26-a5a4-b132a248c377"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "SpecificGravityPerSecond",
          UnitLabel = "sg/s",
          ID = new Guid("dec0a290-ffd8-4fc0-ae11-3a6068469791"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "SpecificGravityPerMinute",
          UnitLabel = "sg/min",
          ID = new Guid("9c314f49-3297-4f7b-9cf3-5da32ba2f1cc"),
          ConversionFactorFromSI = 0.06
        },
        new UnitChoice
        {
          UnitName = "SpecificGravityPerHour",
          UnitLabel = "sg/h",
          ID = new Guid("ce5d34b0-d7ab-48a4-87c1-9a43fabf5c06"),
          ConversionFactorFromSI = 3.6
        },
        new UnitChoice
        {
          UnitName = "GramPerCubicCentimeterPerHour",
          UnitLabel = "kg/cm³/h",
          ID = new Guid("c8d6a682-00ca-4d0f-b603-bf2d755f4b31"),
          ConversionFactorFromSI = 3.6
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUKPerSecond",
          UnitLabel = "ppgUK/s",
          ID = new Guid("e5a712d2-b874-4e7a-873e-a4f4f3ec7a67"),
          ConversionFactorFromSI = 0.010022412855
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUKPerMinute",
          UnitLabel = "ppgUK/min",
          ID = new Guid("e79c74b9-774d-4695-81d5-75042f268b96"),
          ConversionFactorFromSI = 0.6013447713
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUKPerHour",
          UnitLabel = "ppgUK/h",
          ID = new Guid("5b461e39-d632-4f5e-b7e7-ef30745e5070"),
          ConversionFactorFromSI = 36.080686277999995
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUSPerSecond",
          UnitLabel = "ppgUS/s",
          ID = new Guid("eee6814a-d701-4cd8-b392-ebfedde20e11"),
          ConversionFactorFromSI = 0.0083454044518
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUSPerMinute",
          UnitLabel = "ppgUS/min",
          ID = new Guid("c047d53d-38f3-4dce-b590-1c9ab700a3ea"),
          ConversionFactorFromSI = 0.500724267108
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUSPerHour",
          UnitLabel = "ppgUS/hour",
          ID = new Guid("822327d4-9f7c-4e91-9528-4eff5dfc9643"),
          ConversionFactorFromSI = 30.043456026479998
        }
      };
        }
    }
}
