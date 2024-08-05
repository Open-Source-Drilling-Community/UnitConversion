using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AngleMagneticFluxDensityQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "radian tesla";
        public override string SIUnitLabel { get; } = "rad.T";
        public override double PlaneAngleDimension { get; } = 1;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        public override double ElectricCurrentDimension { get; } = -1;
        private static AngleMagneticFluxDensityQuantity instance_ = null;

        public static AngleMagneticFluxDensityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AngleMagneticFluxDensityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public AngleMagneticFluxDensityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Angle Magnetic Flux Density" };
            ID = new Guid("03bb57e6-ca8b-4741-a211-9cf57c8fd177");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = SIUnitName,
                  UnitLabel = SIUnitLabel,
                  ID = new Guid("242bd328-96ef-4a1b-9a78-1e2eb8366955"),
                  ConversionFactorFromSI = 1.0,
                  IsSI = true
                },
                new UnitChoice
                {
                  UnitName = "radian gauss",
                  UnitLabel = "rad.G",
                  ID = new Guid("aa726b90-bd4b-420c-ae71-6f2f1fde3b58"),
                  ConversionFactorFromSI = 10000.0
                },
                new UnitChoice
                {
                  UnitName = "radian milligauss",
                  UnitLabel = "rad.mG",
                  ID = new Guid("352a5b84-306d-4e38-898a-58705683fdf0"),
                  ConversionFactorFromSI = 10000000.0
                },
                new UnitChoice
                {
                  UnitName = "radian millitesla",
                  UnitLabel = "rad.mT",
                  ID = new Guid("663639b3-48b8-4c04-a2eb-6ae2e16daa9b"),
                  ConversionFactorFromSI = 1000.0
                },
                new UnitChoice
                {
                  UnitName = "radian microTesla",
                  UnitLabel = "rad.µT",
                  ID = new Guid("b445e592-e0ca-490f-8880-9708e4e96a01"),
                  ConversionFactorFromSI = 1000000.0
                },
                new UnitChoice
                {
                  UnitName = "radian nanoTesla",
                  UnitLabel = "rad.nT",
                  ID = new Guid("b4aeee40-29fa-463a-80a4-e10fa42c743f"),
                  ConversionFactorFromSI = 1000000000.0
                },
                new UnitChoice
                {
                  UnitName = "radian maxwell per square centimetre",
                  UnitLabel = "rad.Mx/cm²",
                  ID = new Guid("02d06899-5d89-4669-a4c2-35adb9ec3924"),
                  ConversionFactorFromSI = 10000.0
                },
                new UnitChoice
                {
                  UnitName = "radian weber per square metre",
                  UnitLabel = "rad.Wb/m²",
                  ID = new Guid("409e8e85-0870-4529-ae0c-95ab6506c445"),
                  ConversionFactorFromSI = 1.0
                },
                 new UnitChoice
                {
                  UnitName = "degree tesla",
                  UnitLabel = "°.T",
                  ID = new Guid("13df770f-6e77-4de4-91c6-137206e53fbb"),
                  ConversionFactorFromSI = 1.0 * 180.0 / Math.PI
                },
                new UnitChoice
                {
                  UnitName = "degree gauss",
                  UnitLabel = "°.G",
                  ID = new Guid("73bb1de0-ccc0-42e6-b88e-44ecfb6fe7e4"),
                  ConversionFactorFromSI = 10000.0 * 180.0 / Math.PI
                },
                new UnitChoice
                {
                  UnitName = "degree milligauss",
                  UnitLabel = "°.mG",
                  ID = new Guid("e74c9ae3-6e17-48e1-896b-e6c1877d68d7"),
                  ConversionFactorFromSI = 10000000.0 * 180.0 / Math.PI
                },
                new UnitChoice
                {
                  UnitName = "degree millitesla",
                  UnitLabel = "°.mT",
                  ID = new Guid("812a3461-ae4a-405b-ae5d-73eb23e8a71f"),
                  ConversionFactorFromSI = 1000.0 * 180.0 / Math.PI
                },
                new UnitChoice
                {
                  UnitName = "degree microtesla",
                  UnitLabel = "°.µT",
                  ID = new Guid("50782201-236e-4537-843b-121e8dca28c6"),
                  ConversionFactorFromSI = 1000000.0 * 180.0 / Math.PI
                },
                new UnitChoice
                {
                  UnitName = "degree nanotesla",
                  UnitLabel = "°.nT",
                  ID = new Guid("0d9bf20d-2b10-4e73-ae8e-3d3e91862ec0"),
                  ConversionFactorFromSI = 1000000000.0 * 180.0 / Math.PI
                },
                new UnitChoice
                {
                  UnitName = "degree maxwell per square centimetre",
                  UnitLabel = "°.Mx/cm²",
                  ID = new Guid("092e8231-a6e6-4b29-bdd6-2ae490aa583a"),
                  ConversionFactorFromSI = 10000.0 * 180.0 / Math.PI
                },
                new UnitChoice
                {
                  UnitName = "degree weber per square metre",
                  UnitLabel = "°.Wb/m²",
                  ID = new Guid("2d7e1d60-6401-41c0-b436-612116be9ad4"),
                  ConversionFactorFromSI = 1.0 * 180.0 / Math.PI
                }
            };
        }
    }
}
