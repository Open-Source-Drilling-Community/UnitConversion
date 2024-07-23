using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class VolumetricFlowRateQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "Q";
        public override string SIUnitName { get; } = "CubicMetrePerSecond";
        public override string SIUnitLabel { get; } = "m³/s";
        public override double LengthDimension { get; } = 3;
        public override double TimeDimension { get; } = -1;
        private static VolumetricFlowRateQuantity instance_ = null;

        public static VolumetricFlowRateQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new VolumetricFlowRateQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public VolumetricFlowRateQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Volumetric Flow Rate", "Flow Rate (volumetric)" };
            ID = new Guid("9c4eb2bc-413f-456e-ae6b-b1055be8e839");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = "LiterPerSecond",
          UnitLabel = "l/s",
          ID = new Guid("6dafb683-0f61-42ba-a22c-7bd5c9cea4ae"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("fabe7a23-1ba2-4f5d-b3f5-d5729166c7a0"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "CubicFootPerSecond",
          UnitLabel = "ft³/s",
          ID = new Guid("a02fc355-34da-447b-ad1f-66cef4cc96d5"),
          ConversionFactorFromSI = 35.31467
        },
        new UnitChoice
        {
          UnitName = "UKGallonPerSecond",
          UnitLabel = "gpsUK",
          ID = new Guid("21ca44f5-ed4e-414d-b285-b38730600794"),
          ConversionFactorFromSI = 219.96924829908778
        },
        new UnitChoice
        {
          UnitName = "USGallonPerSecond",
          UnitLabel = "gpsUS",
          ID = new Guid("21fe7e3a-bf92-4c94-b6d7-e2d30dfc4cd3"),
          ConversionFactorFromSI = 264.17985364436106
        },
        new UnitChoice
        {
          UnitName = "BarrelPerSecond",
          UnitLabel = "bbl/s",
          ID = new Guid("a73caac6-062e-4f79-8374-8fb2598b6842"),
          ConversionFactorFromSI = 6.28999651534193
        },
        new UnitChoice
        {
          UnitName = "CubicMetrePerMinute",
          UnitLabel = " m³/min",
          ID = new Guid("98eec130-224c-457a-a5dd-50b55a3a28ab"),
          ConversionFactorFromSI = 60
        },
        new UnitChoice
        {
          UnitName = "LiterPerMinute",
          UnitLabel = "l/min",
          ID = new Guid("e1ff1684-02ed-41c0-a82c-40b4a6d348b5"),
          ConversionFactorFromSI = 60000
        },
        new UnitChoice
        {
          UnitName = "CubicFootPerMinute",
          UnitLabel = " ft³/min",
          ID = new Guid("a81e08db-d8fd-4379-bc8e-c223c3fb71b3"),
          ConversionFactorFromSI = 2118.8802
        },
        new UnitChoice
        {
          UnitName = "UKGallonPerMinute",
          UnitLabel = "gpmUK",
          ID = new Guid("bb1d3fbc-efc1-4cf7-9c13-33c25a874224"),
          ConversionFactorFromSI = 13198.1548979
        },
        new UnitChoice
        {
          UnitName = "USGallonPerMinute",
          UnitLabel = "gpmUS",
          ID = new Guid("ceca76e7-fd1e-4220-b072-9f40467a05e3"),
          ConversionFactorFromSI = 15850.3230745
        },
        new UnitChoice
        {
          UnitName = "BarrelPerMinute",
          UnitLabel = "bbl/m",
          ID = new Guid("3672c640-3924-4921-861b-d14c99643615"),
          ConversionFactorFromSI = 377.39979092051584
        },
        new UnitChoice
        {
          UnitName = "CubicMetrePerHour",
          UnitLabel = "m³/h",
          ID = new Guid("d6607bed-0235-4838-87c8-2ff6c76be2ad"),
          ConversionFactorFromSI = 3600
        },
        new UnitChoice
        {
          UnitName = "LiterPerHour",
          UnitLabel = "l/h",
          ID = new Guid("fe2d8a01-fd2b-4652-80bd-f0da2ce990fd"),
          ConversionFactorFromSI = 3600000
        },
        new UnitChoice
        {
          UnitName = "CubicFootPerHour",
          UnitLabel = "ft³/h",
          ID = new Guid("54f30d1c-670a-4566-bfb2-3ce644d68878"),
          ConversionFactorFromSI = 127132.812
        },
        new UnitChoice
        {
          UnitName = "UKGallonPerHour",
          UnitLabel = "gphUK",
          ID = new Guid("85d47672-e1ce-4b33-be1d-eabc2ec1c4c1"),
          ConversionFactorFromSI = 791889.293874
        },
        new UnitChoice
        {
          UnitName = "USGallonPerHour",
          UnitLabel = "gphUS",
          ID = new Guid("36892d41-4a11-4d32-9a8c-1e43ac1f8c6d"),
          ConversionFactorFromSI = 951019.38447
        },
        new UnitChoice
        {
          UnitName = "BarrelPerHour",
          UnitLabel = "bbl/h",
          ID = new Guid("af1bd583-3a13-4d3a-8f65-ede4f8fe9789"),
          ConversionFactorFromSI = 22643.98745523095
        },
        new UnitChoice
        {
          UnitName = "CubicMetrePerDay",
          UnitLabel = "m³/d",
          ID = new Guid("f512755c-166c-4346-a0f7-74f09703410f"),
          ConversionFactorFromSI = 86400
        },
        new UnitChoice
        {
          UnitName = "MillionCubicMetrePerDay",
          UnitLabel = "Mm³/d",
          ID = new Guid("d09b4db7-9fbe-4018-aeb7-15286ccff8d6"),
          ConversionFactorFromSI = 0.0864
        },
        new UnitChoice
        {
          UnitName = "UKGallonPerDay",
          UnitLabel = "gpdUK",
          ID = new Guid("334cf647-375e-4423-8ef4-e1171f938f9a"),
          ConversionFactorFromSI = 19005343.052975997
        },
        new UnitChoice
        {
          UnitName = "USGallonPerDay",
          UnitLabel = "gpdUS",
          ID = new Guid("c0a47cc8-8ba1-47a1-ab94-d3e4361dd063"),
          ConversionFactorFromSI = 22824465.227280002
        },
        new UnitChoice
        {
          UnitName = "MillionUKGallonPerDay",
          UnitLabel = "MillionUKGallonPerDay",
          ID = new Guid("f083576e-1d99-4243-bcfa-5ca6093b6931"),
          ConversionFactorFromSI = 19.005343052976
        },
        new UnitChoice
        {
          UnitName = "MillionUSGallonPerDay",
          UnitLabel = "MillionUSGallonPerDay",
          ID = new Guid("ffe9958a-3daa-472d-87ab-0b1217dcb1c5"),
          ConversionFactorFromSI = 22.82446522728
        },
        new UnitChoice
        {
          UnitName = "LiterPerDay",
          UnitLabel = "l/d",
          ID = new Guid("67628fe2-6a64-4ea6-94fe-5a34e7568b53"),
          ConversionFactorFromSI = 86400000
        },
        new UnitChoice
        {
          UnitName = "MillionLiterPerDay",
          UnitLabel = "MillionLiterPerDay",
          ID = new Guid("1889c1dd-5aa3-45fe-b6cb-79a760e44832"),
          ConversionFactorFromSI = 86.4
        },
        new UnitChoice
        {
          UnitName = "CubicFootPerDay",
          UnitLabel = "ft³/d",
          ID = new Guid("6b9a886b-b96a-473b-8dea-e850583ad5d8"),
          ConversionFactorFromSI = 3051187.488
        },
        new UnitChoice
        {
          UnitName = "ThousandStandardCubicFootPerDay",
          UnitLabel = "Mscf/d",
          ID = new Guid("627a75ed-2ab8-480a-96be-b9266d34ba5d"),
          ConversionFactorFromSI = 4.087346064814815E-07
        },
        new UnitChoice
        {
          UnitName = "MillionStandardCubicFootPerDay",
          UnitLabel = "MMscf/d",
          ID = new Guid("f1c76ab3-8e54-4ad1-a7fe-a09be2a61285"),
          ConversionFactorFromSI = 4.087346064814815E-10
        },
        new UnitChoice
        {
          UnitName = "BarrelPerDay",
          UnitLabel = "bbl/d",
          ID = new Guid("9d36ce54-5bdc-4f4b-9948-dd65c58c9db3"),
          ConversionFactorFromSI = 543455.6989255428
        },
        new UnitChoice
        {
          UnitName = "CubicMetrePerYear",
          UnitLabel = "m³/year",
          ID = new Guid("f0e95734-b6a0-4081-b022-8c5bc0e7dd64"),
          ConversionFactorFromSI = 31557600
        },
        new UnitChoice
        {
          UnitName = "LiterPerYear",
          UnitLabel = "l/year",
          ID = new Guid("d2b8abd2-cd97-4933-8e0a-54d8a4eef7ce"),
          ConversionFactorFromSI = 31557600000
        },
        new UnitChoice
        {
          UnitName = "CubicFootPerYear",
          UnitLabel = "ft³/year",
          ID = new Guid("5ae7fcd3-fae0-4d81-abca-4c3d36d49e6d"),
          ConversionFactorFromSI = 1114446229.992
        },
        new UnitChoice
        {
          UnitName = "UKGallonPerYear",
          UnitLabel = "gpyUK",
          ID = new Guid("b7f54c43-a2ee-4b27-bccb-4c0e752e4caf"),
          ConversionFactorFromSI = 6941701550.0994835
        },
        new UnitChoice
        {
          UnitName = "USGallonPerYear",
          UnitLabel = "gpyUS",
          ID = new Guid("94558d1e-fbe2-4f06-a985-44210a1f0bc8"),
          ConversionFactorFromSI = 8336635924.264021
        },
        new UnitChoice
        {
          UnitName = "BarrelPerYear",
          UnitLabel = "bbl/year",
          ID = new Guid("0360ea30-fbf5-4dda-bf99-670dd6983420"),
          ConversionFactorFromSI = 543455.6989255428
        }
      };
        }
    }
}
