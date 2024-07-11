using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DensityGradientDepthQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "KilogramPerCubicMetrePerMetre";
        public override string SIUnitLabel { get; } = "kg/m³/m";
        public override double MassDimension { get; } = 1;
        public override double LengthDimension { get; } = -4;

        private static DensityGradientDepthQuantity instance_ = null;

        public static DensityGradientDepthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityGradientDepthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DensityGradientDepthQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Density Gradient Depth" };
            ID = new Guid("037e0326-5095-4c82-ba1b-4df594243cda");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("00707a6a-2e33-4214-9f8c-3e64eaa82ec1"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "SpecificGravityPerMetre",
          UnitLabel = "sg/m",
          ID = new Guid("07964c1e-b0d5-4785-bee4-8b4b8882b8b2"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "SpecificGravityPer10Metre",
          UnitLabel = "sg/10m",
          ID = new Guid("4af1c9f0-480c-4e80-a62b-c6b57b486c3f"),
          ConversionFactorFromSI = 0.01
        },
        new UnitChoice
        {
          UnitName = "SpecificGravityPer30Metre",
          UnitLabel = "sg/30m",
          ID = new Guid("f8499728-220b-4b2d-94b2-3dc2cdfa6a92"),
          ConversionFactorFromSI = 0.03
        },
        new UnitChoice
        {
          UnitName = "SpecificGravityPer100Metre",
          UnitLabel = "sg/100m",
          ID = new Guid("af987ef2-c8e5-470a-bc53-b2fff05d2c6a"),
          ConversionFactorFromSI = 0.1
        },
        new UnitChoice
        {
          UnitName = "GramPerCubicCentimetrePer100Metre",
          UnitLabel = "g/cm³/100m",
          ID = new Guid("361f976c-6271-41d2-8da3-6b4009cf5e06"),
          ConversionFactorFromSI = 0.1
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUKPerFoot",
          UnitLabel = "ppgUK/ft",
          ID = new Guid("f2e67c73-3706-4c14-b23a-afe474b2ecbe"),
          ConversionFactorFromSI = 0.0100224
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUKPer30Foot",
          UnitLabel = "ppgUK/30ft",
          ID = new Guid("684acd16-b420-4952-bc42-ffb47044074d"),
          ConversionFactorFromSI = 0.30067200000000005
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUKPer100Foot",
          UnitLabel = "ppgUK/100ft",
          ID = new Guid("f4b6b8a9-c222-4ac9-a6bb-072a9ca7d567"),
          ConversionFactorFromSI = 1.00224
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUSPerFoot",
          UnitLabel = "ppgUS/ft",
          ID = new Guid("56128f8e-f59e-4f30-927b-35acb6ab44b1"),
          ConversionFactorFromSI = 0.015021719999999999
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUSPer30Foot",
          UnitLabel = "ppgUS/30ft",
          ID = new Guid("389150f0-4602-4468-bba3-a8eaf1d36ca0"),
          ConversionFactorFromSI = 0.4506516
        },
        new UnitChoice
        {
          UnitName = "PoundPerGallonUSPer100Foot",
          UnitLabel = "ppgUS/100ft",
          ID = new Guid("658a9698-d34b-4a56-9ee3-3cf6e46a52a3"),
          ConversionFactorFromSI = 1.5021719999999998
        }
      };
        }
    }
}
