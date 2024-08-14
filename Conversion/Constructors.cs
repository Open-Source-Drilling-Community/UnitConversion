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
namespace OSDC.UnitConversion.Conversion
{
  public partial class AngularAccelerationQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "radian per second squared",
                  UnitLabel = "rad/s²",
                  ID = new Guid("15d7ab2b-c0c3-4d33-8242-670ba2f937ff"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "degree per second squared",
                  UnitLabel = "°/s²",
                  ID = new Guid("6fcc944b-fd7e-4368-baa4-3bb8eeba63a2"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "radian per day per second",
                  UnitLabel = "rad/d/s",
                  ID = new Guid("76b421a7-87e5-4fdf-a280-8e5aea80e0d0"),
                  ConversionFactorFromSIFormula = "Factors.Day",
                  ConversionFactorFromSI = Factors.Day,
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour per second",
                  UnitLabel = "rad/h/s",
                  ID = new Guid("70b2f838-b8d2-425f-bea1-0a841c520ba8"),
                  ConversionFactorFromSIFormula = "Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour,
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute per second",
                  UnitLabel = "rad/min/s",
                  ID = new Guid("fdf50c96-cef9-466a-80d6-747b99dad734"),
                  ConversionFactorFromSIFormula = "Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute,
                }
              , new UnitChoice
                {
                  UnitName = "degree per day per second",
                  UnitLabel = "°/d/s",
                  ID = new Guid("838a73aa-fd19-42ac-9c72-c62573cda91b"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Degree",
                  ConversionFactorFromSI = Factors.Day*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour per second",
                  UnitLabel = "°/h/s",
                  ID = new Guid("cbfff738-14e6-47ad-8b21-41eeeea41439"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Hour*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute per second",
                  UnitLabel = "°/min/s",
                  ID = new Guid("f6b4276b-64a8-46f9-a831-fd14a61c34a0"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Degree",
                  ConversionFactorFromSI = Factors.Minute*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "radian per second per minute",
                  UnitLabel = "rad/s/min",
                  ID = new Guid("6bc32ba1-3a66-415a-bc0f-d9292ac77ab6"),
                  ConversionFactorFromSIFormula = "Factors.Unit * Factors.Minute",
                  ConversionFactorFromSI = Factors.Unit * Factors.Minute,
                }
              , new UnitChoice
                {
                  UnitName = "degree per second per minute",
                  UnitLabel = "°/s/min",
                  ID = new Guid("2bb42b52-ab2d-4d2f-8ebb-1294f9b35b89"),
                  ConversionFactorFromSIFormula = "Factors.Unit * Factors.Minute * Factors.Degree",
                  ConversionFactorFromSI = Factors.Unit * Factors.Minute * Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "radian per day per minute",
                  UnitLabel = "rad/d/min",
                  ID = new Guid("62a8e46b-3701-4375-be57-f5d53df23d87"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Minute",
                  ConversionFactorFromSI = Factors.Day*Factors.Minute,
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour per minute",
                  UnitLabel = "rad/h/min",
                  ID = new Guid("77f3ea1e-8280-4881-befe-08dc1065a94f"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Minute",
                  ConversionFactorFromSI = Factors.Hour*Factors.Minute,
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute squared",
                  UnitLabel = "rad/min²",
                  ID = new Guid("61ec8b9b-f1c7-4798-bf37-d7f697d0ea8e"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute,
                }
              , new UnitChoice
                {
                  UnitName = "degree per day per minute",
                  UnitLabel = "°/d/min",
                  ID = new Guid("22b8d910-ce73-4ce4-87b3-761aa17059d6"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Minute*Factors.Degree",
                  ConversionFactorFromSI = Factors.Day*Factors.Minute*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour per minute",
                  UnitLabel = "°/h/min",
                  ID = new Guid("414785c2-4d81-472e-a020-7eca9913ebd2"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Minute*Factors.Degree",
                  ConversionFactorFromSI = Factors.Hour*Factors.Minute*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute squared",
                  UnitLabel = "°/min²",
                  ID = new Guid("49b1ab89-8a0c-4bd9-b693-7db0e14b86e9"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute*Factors.Degree",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "radian per second per hour",
                  UnitLabel = "rad/s/h",
                  ID = new Guid("6bb6033c-3391-4e68-9cc3-63e9d8b03eb3"),
                  ConversionFactorFromSIFormula = "Factors.Unit*Factors.Hour",
                  ConversionFactorFromSI = Factors.Unit*Factors.Hour,
                }
              , new UnitChoice
                {
                  UnitName = "degree per second per hour",
                  UnitLabel = "°/s/h",
                  ID = new Guid("cdd641f0-2b50-4cb4-88c1-256ac2f5e2b5"),
                  ConversionFactorFromSIFormula = "Factors.Unit*Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Unit*Factors.Hour*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "radian per day per hour",
                  UnitLabel = "rad/d/h",
                  ID = new Guid("1ff0952d-4395-4dd6-b101-99b890a46ee8"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Hour",
                  ConversionFactorFromSI = Factors.Day*Factors.Hour,
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour squared",
                  UnitLabel = "rad/h²",
                  ID = new Guid("f105faab-2b48-402a-98f2-004b99adb5a7"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour*Factors.Hour,
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute per hour",
                  UnitLabel = "rad/min/h",
                  ID = new Guid("c5713507-731e-482a-bd4e-d86ef21d4ae5"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Hour",
                  ConversionFactorFromSI = Factors.Minute*Factors.Hour,
                }
              , new UnitChoice
                {
                  UnitName = "degree per day per hour",
                  UnitLabel = "°/d/h",
                  ID = new Guid("7e8596f9-657f-4eb6-937d-091a55bd0e34"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Day*Factors.Hour*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour squared",
                  UnitLabel = "°/h²",
                  ID = new Guid("fad47c71-53d9-4a88-b720-6a953092b41b"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Hour*Factors.Hour*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute per hour",
                  UnitLabel = "°/min/h",
                  ID = new Guid("a4870e3b-95b7-4c8c-b86a-ffe1d2d6e524"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Minute*Factors.Hour*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "radian per second per day",
                  UnitLabel = "rad/s/d",
                  ID = new Guid("52462419-b494-473f-a46d-270ae253f076"),
                  ConversionFactorFromSIFormula = "Factors.Unit*Factors.Day",
                  ConversionFactorFromSI = Factors.Unit*Factors.Day,
                }
              , new UnitChoice
                {
                  UnitName = "degree per second per day",
                  UnitLabel = "°/s/d",
                  ID = new Guid("dab003cb-6906-4f9f-8551-e8f72d3a1c4d"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Unit*Factors.Day",
                  ConversionFactorFromSI = Factors.Degree*Factors.Unit*Factors.Day,
                }
              , new UnitChoice
                {
                  UnitName = "radian per day squared",
                  UnitLabel = "rad/d²",
                  ID = new Guid("6027756a-1c1e-47e8-b938-0bc4e4b25a24"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Day",
                  ConversionFactorFromSI = Factors.Day*Factors.Day,
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour per day",
                  UnitLabel = "rad/h/d",
                  ID = new Guid("a31be21e-1f83-4e9b-aaa7-56a2f797c3d6"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Day",
                  ConversionFactorFromSI = Factors.Hour*Factors.Day,
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute per day",
                  UnitLabel = "rad/min/d",
                  ID = new Guid("3335414d-1a69-477b-b27f-61f464a7ca13"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Day",
                  ConversionFactorFromSI = Factors.Minute*Factors.Day,
                }
              , new UnitChoice
                {
                  UnitName = "degree per day squared",
                  UnitLabel = "°/d²",
                  ID = new Guid("a77c1dea-6fe9-43cc-9f53-75d87e00e458"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Day*Factors.Degree",
                  ConversionFactorFromSI = Factors.Day*Factors.Day*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour per day",
                  UnitLabel = "°/h/d",
                  ID = new Guid("69437581-725e-4a66-b945-abaac133be0a"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Day*Factors.Degree",
                  ConversionFactorFromSI = Factors.Hour*Factors.Day*Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute per day",
                  UnitLabel = "°/min/d",
                  ID = new Guid("5a8a9fe1-9866-4c71-95a5-23dcb4726235"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Day*Factors.Degree",
                  ConversionFactorFromSI = Factors.Minute*Factors.Day*Factors.Degree,
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class AngularVelocityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "radian per second",
                  UnitLabel = "rad/s",
                  ID = new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "degree per second",
                  UnitLabel = "°/s",
                  ID = new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "radian per day",
                  UnitLabel = "rad/d",
                  ID = new Guid("53f2a55b-beb6-4e4d-b696-e817c5b0eaed"),
                  ConversionFactorFromSIFormula = "Factors.Day",
                  ConversionFactorFromSI = Factors.Day,
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour",
                  UnitLabel = "rad/h",
                  ID = new Guid("c2f0e82b-236b-4eb5-9c77-b2c500ab60ab"),
                  ConversionFactorFromSIFormula = "Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour,
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute",
                  UnitLabel = "rad/min",
                  ID = new Guid("5267eb8c-36bc-4ab9-bd62-26f05f852c35"),
                  ConversionFactorFromSIFormula = "Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute,
                }
              , new UnitChoice
                {
                  UnitName = "degree per day",
                  UnitLabel = "°/d",
                  ID = new Guid("ec049b3d-134b-44a3-9746-0419a368beef"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Day",
                  ConversionFactorFromSI = Factors.Degree*Factors.Day,
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour",
                  UnitLabel = "°/h",
                  ID = new Guid("44cc8b17-2f87-49c9-8ab7-7f4ed36d9eb6"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Hour",
                  ConversionFactorFromSI = Factors.Degree*Factors.Hour,
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute",
                  UnitLabel = "°/min",
                  ID = new Guid("0a3ad50c-bbfa-456c-9613-84f37b4a80f1"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Minute",
                  ConversionFactorFromSI = Factors.Degree*Factors.Minute,
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class AreaQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "square metre",
                  UnitLabel = "m²",
                  ID = new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Unit*Factors.Unit)",
                  ConversionFactorFromSI = 1.0/(Factors.Unit*Factors.Unit),
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "square kilometre",
                  UnitLabel = "km²",
                  ID = new Guid("6353513a-6e38-4a58-b20c-d3e8d7b70fb8"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.Kilo)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.Kilo),
                }
              , new UnitChoice
                {
                  UnitName = "hectare",
                  UnitLabel = "ha",
                  ID = new Guid("14313265-7985-4010-a19a-5ffaebe05092"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Hecto*Factors.Hecto)",
                  ConversionFactorFromSI = 1.0/(Factors.Hecto*Factors.Hecto),
                }
              , new UnitChoice
                {
                  UnitName = "square decametre",
                  UnitLabel = "dam²",
                  ID = new Guid("df9417fc-1c08-4c76-a177-e8ea803b2e2f"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deca*Factors.Deca)",
                  ConversionFactorFromSI = 1.0/(Factors.Deca*Factors.Deca),
                }
              , new UnitChoice
                {
                  UnitName = "square decimetre",
                  UnitLabel = "dm²",
                  ID = new Guid("125fd8d6-d1eb-4826-a952-5219603409ab"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deci*Factors.Deci)",
                  ConversionFactorFromSI = 1.0/(Factors.Deci*Factors.Deci),
                }
              , new UnitChoice
                {
                  UnitName = "square centimetre",
                  UnitLabel = "cm²",
                  ID = new Guid("d74bb2bc-9c86-4be4-bff1-88cac7b1049b"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Centi*Factors.Centi)",
                  ConversionFactorFromSI = 1.0/(Factors.Centi*Factors.Centi),
                }
              , new UnitChoice
                {
                  UnitName = "square millimetre",
                  UnitLabel = "mm²",
                  ID = new Guid("0b87d221-284a-4e8c-8a60-50c522f9ade4"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Milli)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Milli),
                }
              , new UnitChoice
                {
                  UnitName = "square micrometre",
                  UnitLabel = "µm²",
                  ID = new Guid("bec98c97-72c7-4485-9138-058ed14e7fbe"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Micro*Factors.Micro)",
                  ConversionFactorFromSI = 1.0/(Factors.Micro*Factors.Micro),
                }
              , new UnitChoice
                {
                  UnitName = "square foot",
                  UnitLabel = "ft²",
                  ID = new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = 1.0/(Factors.Foot*Factors.Foot),
                }
              , new UnitChoice
                {
                  UnitName = "square inch",
                  UnitLabel = "in²",
                  ID = new Guid("294bc6d0-5be7-4c70-95f3-ad9dc50f02cf"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Inch*Factors.Inch)",
                  ConversionFactorFromSI = 1.0/(Factors.Inch*Factors.Inch),
                }
              , new UnitChoice
                {
                  UnitName = "square yard",
                  UnitLabel = "yd²",
                  ID = new Guid("ae3df24c-e5db-4b88-9e81-228f29855f1b"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Yard*Factors.Yard)",
                  ConversionFactorFromSI = 1.0/(Factors.Yard*Factors.Yard),
                }
              , new UnitChoice
                {
                  UnitName = "acre",
                  UnitLabel = "ac",
                  ID = new Guid("bc94456a-b8b9-49ac-b349-eaded6c984c6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Acre",
                  ConversionFactorFromSI = 1.0/Factors.Acre,
                }
              , new UnitChoice
                {
                  UnitName = "square mile",
                  UnitLabel = "mi²",
                  ID = new Guid("5bbe8c59-cce9-47c8-b357-c5a15610af72"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mile*Factors.Mile)",
                  ConversionFactorFromSI = 1.0/(Factors.Mile*Factors.Mile),
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class CompressibilityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "inverse pascal",
                  UnitLabel = "1/Pa",
                  ID = new Guid("0e259998-c8bb-4a4d-b281-afb8008b2693"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "inverse bar",
                  UnitLabel = "1/bar",
                  ID = new Guid("4a0f6df4-0d2d-489b-80f1-511be7713101"),
                  ConversionFactorFromSIFormula = "Factors.Bar",
                  ConversionFactorFromSI = Factors.Bar,
                }
              , new UnitChoice
                {
                  UnitName = "inverse pound per square inch",
                  UnitLabel = "1/psi",
                  ID = new Guid("282ab24c-6c43-4710-8e52-433bdf90cc2e"),
                  ConversionFactorFromSIFormula = "Factors.PSI",
                  ConversionFactorFromSI = Factors.PSI,
                }
              , new UnitChoice
                {
                  UnitName = "inverse atmosphere",
                  UnitLabel = "1/atm",
                  ID = new Guid("92c19398-ac0f-41fc-8a22-516c3dc59c82"),
                  ConversionFactorFromSIFormula = "Factors.Atmosphere",
                  ConversionFactorFromSI = Factors.Atmosphere,
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class CurvatureQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "radian per metre",
                  UnitLabel = "rad/m",
                  ID = new Guid("cbba2f64-9914-4c00-a3fe-3c2aef560225"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "degree per 10m",
                  UnitLabel = "°/10m",
                  ID = new Guid("c62408d6-c3c5-47bd-8cb0-4fa9faf51598"),
                  ConversionFactorFromSIFormula = "Factors.Degree*10.0",
                  ConversionFactorFromSI = Factors.Degree*10.0,
                }
              , new UnitChoice
                {
                  UnitName = "degree per 30m",
                  UnitLabel = "°/30m",
                  ID = new Guid("98a4d593-c959-49fb-ba1a-b1aa61830cd7"),
                  ConversionFactorFromSIFormula = "Factors.Degree*30.0",
                  ConversionFactorFromSI = Factors.Degree*30.0,
                }
              , new UnitChoice
                {
                  UnitName = "degree per 30ft",
                  UnitLabel = "°/30ft",
                  ID = new Guid("284dca7d-b1fc-4e40-ab08-a3e0fa2ef9d0"),
                  ConversionFactorFromSIFormula = "Factors.Degree*30.0*Factors.Foot",
                  ConversionFactorFromSI = Factors.Degree*30.0*Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "degree per 100ft",
                  UnitLabel = "°/100ft",
                  ID = new Guid("5aa20ab5-6800-48db-abb1-4c3538b0972d"),
                  ConversionFactorFromSIFormula = "Factors.Degree*100.0*Factors.Foot",
                  ConversionFactorFromSI = Factors.Degree*100.0*Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "degree per foot",
                  UnitLabel = "°/ft",
                  ID = new Guid("363a6781-5829-4046-95d8-ce1e844343fc"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Foot",
                  ConversionFactorFromSI = Factors.Degree*Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "radian per foot",
                  UnitLabel = "rad/ft",
                  ID = new Guid("1428743e-927c-4f7a-9e15-62d37790ad51"),
                  ConversionFactorFromSIFormula = "Factors.Foot",
                  ConversionFactorFromSI = Factors.Foot,
                }
              , new UnitChoice
                {
                  UnitName = "degree per metre",
                  UnitLabel = "°/m",
                  ID = new Guid("7c47f046-0499-4108-937d-abb504883259"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                }
              , new UnitChoice
                {
                  UnitName = "degree per decimeter",
                  UnitLabel = "°/dm",
                  ID = new Guid("ed1db27f-5f42-4678-8d0b-8e4e91208a83"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Deci",
                  ConversionFactorFromSI = Factors.Degree*Factors.Deci,
                }
              , new UnitChoice
                {
                  UnitName = "degree per centimeter",
                  UnitLabel = "°/cm",
                  ID = new Guid("0440cec4-b070-4b03-a065-453c2fafbf24"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Centi",
                  ConversionFactorFromSI = Factors.Degree*Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "degree per millimeter",
                  UnitLabel = "°/mm",
                  ID = new Guid("c6e0bc05-2ee5-4dd1-85fa-71de7a235ef4"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Milli",
                  ConversionFactorFromSI = Factors.Degree*Factors.Milli,
                }
              , new UnitChoice
                {
                  UnitName = "degree per micrometer",
                  UnitLabel = "°/mm",
                  ID = new Guid("996e89d6-3b4a-4893-81f5-e4f539e93cf8"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Micro",
                  ConversionFactorFromSI = Factors.Degree*Factors.Micro,
                }
              , new UnitChoice
                {
                  UnitName = "degree per nanometer",
                  UnitLabel = "°/mm",
                  ID = new Guid("e15c78f0-7a6c-47e5-bd3f-4f02571fabe5"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Nano",
                  ConversionFactorFromSI = Factors.Degree*Factors.Nano,
                }
              , new UnitChoice
                {
                  UnitName = "degree per decameter",
                  UnitLabel = "°/dam",
                  ID = new Guid("970e611b-87ee-4006-aee7-c6d500c33ff0"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Deca",
                  ConversionFactorFromSI = Factors.Degree*Factors.Deca,
                }
              , new UnitChoice
                {
                  UnitName = "degree per hectometer",
                  UnitLabel = "°/hm",
                  ID = new Guid("5cca6250-fd0e-47a7-a64f-01b8025950ad"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Hecto",
                  ConversionFactorFromSI = Factors.Degree*Factors.Hecto,
                }
              , new UnitChoice
                {
                  UnitName = "degree per kilometer",
                  UnitLabel = "°/km",
                  ID = new Guid("91ef582e-ee8b-4f48-a1f6-c5d96eb634ca"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Kilo",
                  ConversionFactorFromSI = Factors.Degree*Factors.Kilo,
                }
              , new UnitChoice
                {
                  UnitName = "radian per decimeter",
                  UnitLabel = "rad/dm",
                  ID = new Guid("c6d2c02d-83a6-4043-9a7d-392415a74b12"),
                  ConversionFactorFromSIFormula = "Factors.Deci",
                  ConversionFactorFromSI = Factors.Deci,
                }
              , new UnitChoice
                {
                  UnitName = "radian per centimeter",
                  UnitLabel = "rad/cm",
                  ID = new Guid("f101a0b8-f710-4010-b9a5-6ced681bcf0a"),
                  ConversionFactorFromSIFormula = "Factors.Centi",
                  ConversionFactorFromSI = Factors.Centi,
                }
              , new UnitChoice
                {
                  UnitName = "radian per millimeter",
                  UnitLabel = "rad/mm",
                  ID = new Guid("80e5d9d6-c1fa-4273-8134-33ff4bc46b40"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                }
              , new UnitChoice
                {
                  UnitName = "radian per micrometer",
                  UnitLabel = "rad/mm",
                  ID = new Guid("777ca6bc-48da-4353-a00d-0bf0931a4328"),
                  ConversionFactorFromSIFormula = "Factors.Micro",
                  ConversionFactorFromSI = Factors.Micro,
                }
              , new UnitChoice
                {
                  UnitName = "radian per nanometer",
                  UnitLabel = "rad/mm",
                  ID = new Guid("eceb51ee-d3ad-4a42-a877-6b20f927fc01"),
                  ConversionFactorFromSIFormula = "Factors.Nano",
                  ConversionFactorFromSI = Factors.Nano,
                }
              , new UnitChoice
                {
                  UnitName = "radian per decameter",
                  UnitLabel = "rad/dam",
                  ID = new Guid("2e8079f1-260e-4524-be2f-cee1195c7fdd"),
                  ConversionFactorFromSIFormula = "Factors.Deca",
                  ConversionFactorFromSI = Factors.Deca,
                }
              , new UnitChoice
                {
                  UnitName = "radian per hectometer",
                  UnitLabel = "rad/hm",
                  ID = new Guid("cb2c22fb-ac24-4c65-96d3-2437c8942662"),
                  ConversionFactorFromSIFormula = "Factors.Hecto",
                  ConversionFactorFromSI = Factors.Hecto,
                }
              , new UnitChoice
                {
                  UnitName = "radian per kilometer",
                  UnitLabel = "rad/km",
                  ID = new Guid("e9a7a647-092a-4349-bb58-0d096a1477c7"),
                  ConversionFactorFromSIFormula = "Factors.Kilo",
                  ConversionFactorFromSI = Factors.Kilo,
                }
              , new UnitChoice
                {
                  UnitName = "degree per yard",
                  UnitLabel = "°/yd",
                  ID = new Guid("9cb7c45f-56d8-4b03-b514-6b5fc687919c"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Yard",
                  ConversionFactorFromSI = Factors.Degree*Factors.Yard,
                }
              , new UnitChoice
                {
                  UnitName = "degree per mile",
                  UnitLabel = "°/mi",
                  ID = new Guid("d155bdde-da22-4f3a-9050-9f5f7e69b57d"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Mile",
                  ConversionFactorFromSI = Factors.Degree*Factors.Mile,
                }
              , new UnitChoice
                {
                  UnitName = "radian per yard",
                  UnitLabel = "rad/yd",
                  ID = new Guid("7409e987-f5cb-4d24-93a8-50fc993fe949"),
                  ConversionFactorFromSIFormula = "Factors.Yard",
                  ConversionFactorFromSI = Factors.Yard,
                }
              , new UnitChoice
                {
                  UnitName = "radian per mile",
                  UnitLabel = "rad/mi",
                  ID = new Guid("59e78258-2739-41b4-aa50-8e077bad6678"),
                  ConversionFactorFromSIFormula = "Factors.Mile",
                  ConversionFactorFromSI = Factors.Mile,
                }
            };
      }
  }
}
