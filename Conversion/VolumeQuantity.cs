using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class VolumeQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "CubicMetre";
        public override string SIUnitLabel { get; } = "m³";
        public override double LengthDimension { get; } = 3;
        private static VolumeQuantity instance_ = null;

        public static VolumeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new VolumeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public VolumeQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Volume" };
            ID = new Guid("69151432-d2ed-4473-a3dc-334f8e6daaa6");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("a465ba87-53d6-456c-8e74-315a1a212498"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "Liter",
          UnitLabel = "l",
          ID = new Guid("3f713743-6248-4b0b-8f3b-c97b6fab76b1"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = "Deciliter",
          UnitLabel = "dl",
          ID = new Guid("3d7dde61-a9e9-4df6-8ee4-1eb4a4be1147"),
          ConversionFactorFromSI = 10000
        },
        new UnitChoice
        {
          UnitName = "Centiliter",
          UnitLabel = "cl",
          ID = new Guid("8d9baa02-5c3e-46f8-b909-7ca92d7bfa7a"),
          ConversionFactorFromSI = 99999.99999999999
        },
        new UnitChoice
        {
          UnitName = "Milliliter",
          UnitLabel = "ml",
          ID = new Guid("6eb0d045-36e5-448d-be94-96a24a03f3e6"),
          ConversionFactorFromSI = 1000000
        },
        new UnitChoice
        {
          UnitName = "USGallon",
          UnitLabel = "US Gal.",
          ID = new Guid("1377d8ac-d203-48ed-bad4-733b0dc9d496"),
          ConversionFactorFromSI = 264.17985364436106
        },
        new UnitChoice
        {
          UnitName = "UKGallon",
          UnitLabel = "UK Gal.",
          ID = new Guid("78f1cef7-c489-498c-96fb-d37474e242a9"),
          ConversionFactorFromSI = 219.96924829908778
        },
        new UnitChoice
        {
          UnitName = "Barrel",
          UnitLabel = "bbl",
          ID = new Guid("b0f03925-d158-48ee-8c33-bf72c08cae68"),
          ConversionFactorFromSI = 6.28999651534193
        },
        new UnitChoice
        {
          UnitName = "MillionCubicMetre",
          UnitLabel = "Mm³",
          ID = new Guid("4c021db5-327b-44d3-9c4f-5a9b84af602f"),
          ConversionFactorFromSI = 1E-06
        },
        new UnitChoice
        {
          UnitName = "MillionLiter",
          UnitLabel = "Ml",
          ID = new Guid("4f3f67df-28af-4398-966f-b23de678f50c"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "MillionUKGallon",
          UnitLabel = "M UK Gal.",
          ID = new Guid("ab9a2938-f519-47c0-bcaa-d61c8fa23c7b"),
          ConversionFactorFromSI = 0.0002199692482990878
        },
        new UnitChoice
        {
          UnitName = "MillionBarrel",
          UnitLabel = "Mbbl",
          ID = new Guid("9d03120c-2c74-4666-8e24-98e143ab88db"),
          ConversionFactorFromSI = 0.00026417985364436106
        },
        new UnitChoice
        {
          UnitName = "ThousandStandardCubicFoot",
          UnitLabel = "Mscf",
          ID = new Guid("e50b6a47-cf4c-4a74-8c1c-758000df5d67"),
          ConversionFactorFromSI = 0.03531467
        },
        new UnitChoice
        {
          UnitName = "MillionStandardCubicFoot",
          UnitLabel = "MMscf",
          ID = new Guid("387b78ff-d51b-4684-b059-4c813407d767"),
          ConversionFactorFromSI = 3.531467E-05
        }
      };
        }
    }
}
