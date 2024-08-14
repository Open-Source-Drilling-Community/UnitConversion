using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
  public partial class AccelerationQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "metre per second squared",
                  UnitLabel = "m/s²",
                  ID = new Guid("20515c0b-8a90-4e76-a2b3-cab213db5a06"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "foot per second squared",
                  UnitLabel = "ft/s²",
                  ID = new Guid("74f20b52-6c15-40e2-ae23-5493326fc879"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Foot",
                  ConversionFactorFromSI = 1.0/Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per second squared",
                  UnitLabel = "cm/s²",
                  ID = new Guid("4dc923c6-81db-4bd1-aa2c-933966ebbef4"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per hour per second",
                  UnitLabel = "cm/(h•s)",
                  ID = new Guid("b469c349-fd35-4802-b408-dd6f86d62d27"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Centi",
                  ConversionFactorFromSI = Factors.Hour/Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per minute per second",
                  UnitLabel = "cm/(min•s)",
                  ID = new Guid("e681e123-03d7-42eb-9ef5-33da76a6d78c"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Centi",
                  ConversionFactorFromSI = Factors.Minute/Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "foot per hour per second",
                  UnitLabel = "ft/(h•s)",
                  ID = new Guid("ccdc1097-4386-4e78-beff-438807b0d52c"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Foot",
                  ConversionFactorFromSI = Factors.Hour/Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "foot per minute per second",
                  UnitLabel = "ft/(min•s)",
                  ID = new Guid("eea429f4-ada7-4c40-adc0-4054dde8549a"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Foot",
                  ConversionFactorFromSI = Factors.Minute/Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "galileo",
                  UnitLabel = "Gal",
                  ID = new Guid("a88f1f6d-e025-47b8-802a-0c802f730824"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "gravity standard",
                  UnitLabel = "gn",
                  ID = new Guid("94dcb02d-04d9-4613-b3c0-d3bdcc3ce382"),
                  ConversionFactorFromSIFormula = "1.0/Factors.G",
                  ConversionFactorFromSI = 1.0/Factors.G,
                }
              , new UnitChoice
                {
                  UnitName = "inch per hour per second",
                  UnitLabel = "in/(h•s)",
                  ID = new Guid("16cc4dc1-0fb0-4bfa-acc2-55a754ab47f9"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Inch",
                  ConversionFactorFromSI = Factors.Hour/Factors.Inch,
                }
              , new UnitChoice
                {
                  UnitName = "inch per minute per second",
                  UnitLabel = "in/(min•s)",
                  ID = new Guid("e33ae152-f371-4b4c-aaf7-51e5635cbcaa"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Inch",
                  ConversionFactorFromSI = Factors.Minute/Factors.Inch,
                }
              , new UnitChoice
                {
                  UnitName = "inch per second squared",
                  UnitLabel = "in/s²",
                  ID = new Guid("2c872353-889f-444a-a182-1a1d3fd09bb3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Inch",
                  ConversionFactorFromSI = 1.0/Factors.Inch,
                }
              , new UnitChoice
                {
                  UnitName = "knot per second",
                  UnitLabel = "kn/s",
                  ID = new Guid("eefbcd14-1031-4763-8a5d-a9fc8c4fc833"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Knot",
                  ConversionFactorFromSI = 1.0/Factors.Knot,
                }
              , new UnitChoice
                {
                  UnitName = "metre per second per millisecond",
                  UnitLabel = "m/(s•ms)",
                  ID = new Guid("ecefe9c4-9d38-4fd8-8f56-482f7c54874e"),
                  ConversionFactorFromSIFormula = "Factors.Milli /Factors.Unit",
                  ConversionFactorFromSI = Factors.Milli /Factors.Unit,
                }
              , new UnitChoice
                {
                  UnitName = "mile per hour per second",
                  UnitLabel = "mi/(h•s)",
                  ID = new Guid("622bde1c-57b2-4845-8a14-c252a0f6c0df"),
                  ConversionFactorFromSIFormula = "Factors.Hour / Factors.Mile",
                  ConversionFactorFromSI = Factors.Hour / Factors.Mile,
                }
              , new UnitChoice
                {
                  UnitName = "mile per minute per second",
                  UnitLabel = "mi/(min•s)",
                  ID = new Guid("f58cace4-7e55-4218-ad64-5c3e420efe02"),
                  ConversionFactorFromSIFormula = "Factors.Minute /Factors.Mile",
                  ConversionFactorFromSI = Factors.Minute /Factors.Mile,
                }
              , new UnitChoice
                {
                  UnitName = "mile per second squared",
                  UnitLabel = "mi/s²",
                  ID = new Guid("4f91adee-52ad-420b-94a8-5b45ab0399a9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mile",
                  ConversionFactorFromSI = 1.0/Factors.Mile,
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per second squared",
                  UnitLabel = "km/s²",
                  ID = new Guid("8b77b272-564a-4637-83cf-bf9d08d231db"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per hour per second",
                  UnitLabel = "km/(h•s)",
                  ID = new Guid("9f74f510-f9ce-4393-9d9d-83518519e42a"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Hour/Factors.Kilo,
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per minute per second",
                  UnitLabel = "km/(min•s)",
                  ID = new Guid("aaaba47c-f11e-44fa-b5df-e981f6356f5a"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Minute/Factors.Kilo,
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class AmountSubstanceQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "mole",
                  UnitLabel = "mol",
                  ID = new Guid("d1072bb3-265e-400a-91b2-9c49616dc3de"),
                  ConversionFactorFromSIFormula = "Factors.Unit",
                  ConversionFactorFromSI = Factors.Unit,
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "decimole",
                  UnitLabel = "dmol",
                  ID = new Guid("b458e56b-edc3-48c3-8858-75d507f1f1f2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deci",
                  ConversionFactorFromSI = 1.0/Factors.Deci,
                }
              , new UnitChoice
                {
                  UnitName = "centimole",
                  UnitLabel = "cmol",
                  ID = new Guid("4d83c0db-ddc4-4087-ae50-076148976cad"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "millimole",
                  UnitLabel = "mmol",
                  ID = new Guid("0a83a1b6-cef4-4899-bcd4-4aa1e10d232a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                }
              , new UnitChoice
                {
                  UnitName = "micromole",
                  UnitLabel = "µmol",
                  ID = new Guid("ec2669ad-9742-4667-8a14-76e00c47a41e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                }
              , new UnitChoice
                {
                  UnitName = "nanomole",
                  UnitLabel = "nmol",
                  ID = new Guid("dc8d0034-ecfa-4dbf-a24c-f1851c4aaf9c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                }
              , new UnitChoice
                {
                  UnitName = "picomole",
                  UnitLabel = "pmol",
                  ID = new Guid("642555ea-37f0-49b9-9f21-8dd616d477c4"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                }
              , new UnitChoice
                {
                  UnitName = "kilomole",
                  UnitLabel = "kmol",
                  ID = new Guid("01157606-070e-41a2-8c78-84a7ae950bd6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class AngleMagneticFluxDensityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "radian tesla",
                  UnitLabel = "rad•T",
                  ID = new Guid("242bd328-96ef-4a1b-9a78-1e2eb8366955"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "radian gauss",
                  UnitLabel = "rad•G",
                  ID = new Guid("aa726b90-bd4b-420c-ae71-6f2f1fde3b58"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Gauss",
                  ConversionFactorFromSI = 1.0/Factors.Gauss,
                }
              , new UnitChoice
                {
                  UnitName = "radian milligauss",
                  UnitLabel = "rad•mG",
                  ID = new Guid("352a5b84-306d-4e38-898a-58705683fdf0"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Gauss)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Gauss),
                }
              , new UnitChoice
                {
                  UnitName = "radian millitesla",
                  UnitLabel = "rad•mT",
                  ID = new Guid("663639b3-48b8-4c04-a2eb-6ae2e16daa9b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                }
              , new UnitChoice
                {
                  UnitName = "radian microtesla",
                  UnitLabel = "rad•µT",
                  ID = new Guid("b445e592-e0ca-490f-8880-9708e4e96a01"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                }
              , new UnitChoice
                {
                  UnitName = "radian nanotesla",
                  UnitLabel = "rad•nT",
                  ID = new Guid("b4aeee40-29fa-463a-80a4-e10fa42c743f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                }
              , new UnitChoice
                {
                  UnitName = "radian maxwell per square centimetre",
                  UnitLabel = "rad•Mx/cm²",
                  ID = new Guid("02d06899-5d89-4669-a4c2-35adb9ec3924"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Centi*Factors.Centi)",
                  ConversionFactorFromSI = 1.0/(Factors.Centi*Factors.Centi),
                }
              , new UnitChoice
                {
                  UnitName = "radian weber per square metre",
                  UnitLabel = "rad•Wb/m²",
                  ID = new Guid("409e8e85-0870-4529-ae0c-95ab6506c445"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                }
              , new UnitChoice
                {
                  UnitName = "degree tesla",
                  UnitLabel = "°•T",
                  ID = new Guid("13df770f-6e77-4de4-91c6-137206e53fbb"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Unit",
                  ConversionFactorFromSI = Factors.Degree/Factors.Unit,
                }
              , new UnitChoice
                {
                  UnitName = "degree gauss",
                  UnitLabel = "°•G",
                  ID = new Guid("73bb1de0-ccc0-42e6-b88e-44ecfb6fe7e4"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Gauss",
                  ConversionFactorFromSI = Factors.Degree/Factors.Gauss,
                }
              , new UnitChoice
                {
                  UnitName = "degree milligauss",
                  UnitLabel = "°•mG",
                  ID = new Guid("e74c9ae3-6e17-48e1-896b-e6c1877d68d7"),
                  ConversionFactorFromSIFormula = "Factors.Degree/(Factors.Milli*Factors.Gauss)",
                  ConversionFactorFromSI = Factors.Degree/(Factors.Milli*Factors.Gauss),
                }
              , new UnitChoice
                {
                  UnitName = "degree millitesla",
                  UnitLabel = "°•mT",
                  ID = new Guid("812a3461-ae4a-405b-ae5d-73eb23e8a71f"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Milli",
                  ConversionFactorFromSI = Factors.Degree/Factors.Milli,
                }
              , new UnitChoice
                {
                  UnitName = "degree microtesla",
                  UnitLabel = "°•µT",
                  ID = new Guid("50782201-236e-4537-843b-121e8dca28c6"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Micro",
                  ConversionFactorFromSI = Factors.Degree/Factors.Micro,
                }
              , new UnitChoice
                {
                  UnitName = "degree nanotesla",
                  UnitLabel = "°•nT",
                  ID = new Guid("0d9bf20d-2b10-4e73-ae8e-3d3e91862ec0"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Nano",
                  ConversionFactorFromSI = Factors.Degree/Factors.Nano,
                }
              , new UnitChoice
                {
                  UnitName = "degree maxwell per square centimetre",
                  UnitLabel = "°•Mx/cm²",
                  ID = new Guid("092e8231-a6e6-4b29-bdd6-2ae490aa583a"),
                  ConversionFactorFromSIFormula = "Factors.Degree/(Factors.Centi*Factors.Centi)",
                  ConversionFactorFromSI = Factors.Degree/(Factors.Centi*Factors.Centi),
                }
              , new UnitChoice
                {
                  UnitName = "degree weber per square metre",
                  UnitLabel = "°•Wb/m²",
                  ID = new Guid("2d7e1d60-6401-41c0-b436-612116be9ad4"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Unit",
                  ConversionFactorFromSI = Factors.Degree/Factors.Unit,
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class AngleVariationGradientQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "radian per metre",
                  UnitLabel = "rad/m",
                  ID = new Guid("5d9782b6-c4c7-47ca-a86b-dce3f63c3747"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "degree per metre",
                  UnitLabel = "°/m",
                  ID = new Guid("2fcd4219-8879-4494-9563-5173ec2292fa"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per centimetre",
                  UnitLabel = "°/cm",
                  ID = new Guid("7f4f63d6-5ea8-4c6b-8be4-81f52b7060c7"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Centi",
                  ConversionFactorFromSI = Factors.Degree*Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "degree per foot",
                  UnitLabel = "°/ft",
                  ID = new Guid("23bf7716-5779-4607-aef7-1e0eeb7f201b"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Foot",
                  ConversionFactorFromSI = Factors.Degree*Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "degree per inch",
                  UnitLabel = "°/in",
                  ID = new Guid("271db65d-2a9f-4fec-a52a-21e13e106dd4"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Inch",
                  ConversionFactorFromSI = Factors.Degree*Factors.Inch,
                }
              , new UnitChoice
                {
                  UnitName = "degree per decimetre",
                  UnitLabel = "°/dm",
                  ID = new Guid("452edd17-d501-487b-8cc1-90c08f7b1417"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Deci",
                  ConversionFactorFromSI = Factors.Degree*Factors.Deci,
                }
              , new UnitChoice
                {
                  UnitName = "degree per millimetre",
                  UnitLabel = "°/mm",
                  ID = new Guid("5cc72a73-70c0-4ccf-83ae-38e8a45391b4"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Milli",
                  ConversionFactorFromSI = Factors.Degree*Factors.Milli,
                }
              , new UnitChoice
                {
                  UnitName = "radian per millimetre",
                  UnitLabel = "rad/mm",
                  ID = new Guid("dbd20525-128b-43c5-9de4-a8e604cbf6bf"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                }
              , new UnitChoice
                {
                  UnitName = "radian per centimetre",
                  UnitLabel = "rad/cm",
                  ID = new Guid("5552abca-e21b-48ca-aedc-4518a32b8de3"),
                  ConversionFactorFromSIFormula = "Factors.Centi",
                  ConversionFactorFromSI = Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "radian per decimetre",
                  UnitLabel = "rad/dm",
                  ID = new Guid("47e72ab7-444d-4d4b-8cd2-01d2fb8efa2d"),
                  ConversionFactorFromSIFormula = "Factors.Deci",
                  ConversionFactorFromSI = Factors.Deci,
                }
              , new UnitChoice
                {
                  UnitName = "radian per foot",
                  UnitLabel = "rad/ft",
                  ID = new Guid("e1ab7dd2-48c7-4ac8-ac5e-bc50fdcae5df"),
                  ConversionFactorFromSIFormula = "Factors.Foot",
                  ConversionFactorFromSI = Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "radian per inch",
                  UnitLabel = "rad/in",
                  ID = new Guid("c36cf9c1-d4f2-4654-99eb-5d84eac21c66"),
                  ConversionFactorFromSIFormula = "Factors.Inch",
                  ConversionFactorFromSI = Factors.Inch,
                }
            };
      }
  }
}
