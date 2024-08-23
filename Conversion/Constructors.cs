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
                  SIUnitName = "metre per second squared",
                  ID = new Guid("20515c0b-8a90-4e76-a2b3-cab213db5a06"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "foot per second squared",
                  UnitLabel = "ft/s²",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("74f20b52-6c15-40e2-ae23-5493326fc879"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Foot",
                  ConversionFactorFromSI = 1.0/Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per second squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Foot, i.e., 3.280839895013124"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per second squared",
                  UnitLabel = "cm/s²",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("4dc923c6-81db-4bd1-aa2c-933966ebbef4"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per second squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per hour per second",
                  UnitLabel = "cm/(h•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("b469c349-fd35-4802-b408-dd6f86d62d27"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Centi",
                  ConversionFactorFromSI = Factors.Hour/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per hour per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Centi, i.e., 360000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per minute per second",
                  UnitLabel = "cm/(min•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("e681e123-03d7-42eb-9ef5-33da76a6d78c"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Centi",
                  ConversionFactorFromSI = Factors.Minute/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Centi, i.e., 6000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per hour per second",
                  UnitLabel = "ft/(h•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("ccdc1097-4386-4e78-beff-438807b0d52c"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Foot",
                  ConversionFactorFromSI = Factors.Hour/Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per hour per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Foot, i.e., 11811.023622047245"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per minute per second",
                  UnitLabel = "ft/(min•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("eea429f4-ada7-4c40-adc0-4054dde8549a"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Foot",
                  ConversionFactorFromSI = Factors.Minute/Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Foot, i.e., 196.85039370078744"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "galileo",
                  UnitLabel = "Gal",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("a88f1f6d-e025-47b8-802a-0c802f730824"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in galileo"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gravity standard",
                  UnitLabel = "gn",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("94dcb02d-04d9-4613-b3c0-d3bdcc3ce382"),
                  ConversionFactorFromSIFormula = "1.0/Factors.G",
                  ConversionFactorFromSI = 1.0/Factors.G,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gravity standard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/G, i.e., 0.10197162129779283"
 + Environment.NewLine + "and"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per hour per second",
                  UnitLabel = "in/(h•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("16cc4dc1-0fb0-4bfa-acc2-55a754ab47f9"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Inch",
                  ConversionFactorFromSI = Factors.Hour/Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per hour per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Inch, i.e., 141732.28346456692"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per minute per second",
                  UnitLabel = "in/(min•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("e33ae152-f371-4b4c-aaf7-51e5635cbcaa"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Inch",
                  ConversionFactorFromSI = Factors.Minute/Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Inch, i.e., 2362.2047244094488"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per second squared",
                  UnitLabel = "in/s²",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("2c872353-889f-444a-a182-1a1d3fd09bb3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Inch",
                  ConversionFactorFromSI = 1.0/Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per second squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Inch, i.e., 39.37007874015748"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "knot per second",
                  UnitLabel = "kn/s",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("eefbcd14-1031-4763-8a5d-a9fc8c4fc833"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Knot",
                  ConversionFactorFromSI = 1.0/Factors.Knot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in knot per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Knot, i.e., 1.9438444924406046"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Knot = 1.852 * Kilo / Hour reference: https://en.wikipedia.org/wiki/Knot_(unit)"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "metre per second per millisecond",
                  UnitLabel = "m/(s•ms)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("ecefe9c4-9d38-4fd8-8f56-482f7c54874e"),
                  ConversionFactorFromSIFormula = "Factors.Milli /Factors.Unit",
                  ConversionFactorFromSI = Factors.Milli /Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in metre per second per millisecond"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli /Unit, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mile per hour per second",
                  UnitLabel = "mi/(h•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("622bde1c-57b2-4845-8a14-c252a0f6c0df"),
                  ConversionFactorFromSIFormula = "Factors.Hour / Factors.Mile",
                  ConversionFactorFromSI = Factors.Hour / Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mile per hour per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour / Mile, i.e., 2.2369362920544025"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mile per minute per second",
                  UnitLabel = "mi/(min•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("f58cace4-7e55-4218-ad64-5c3e420efe02"),
                  ConversionFactorFromSIFormula = "Factors.Minute /Factors.Mile",
                  ConversionFactorFromSI = Factors.Minute /Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mile per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute /Mile, i.e., 0.03728227153424004"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mile per second squared",
                  UnitLabel = "mi/s²",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("4f91adee-52ad-420b-94a8-5b45ab0399a9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mile",
                  ConversionFactorFromSI = 1.0/Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mile per second squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mile, i.e., 0.000621371192237334"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per second squared",
                  UnitLabel = "km/s²",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("8b77b272-564a-4637-83cf-bf9d08d231db"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilometre per second squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per hour per second",
                  UnitLabel = "km/(h•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("9f74f510-f9ce-4393-9d9d-83518519e42a"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Hour/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilometre per hour per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Kilo, i.e., 3.6"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per minute per second",
                  UnitLabel = "km/(min•s)",
                  SIUnitName = "metre per second squared",
                  ID = new Guid("aaaba47c-f11e-44fa-b5df-e981f6356f5a"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Minute/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilometre per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Kilo, i.e., 0.06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
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
                  SIUnitName = "mole",
                  ID = new Guid("d1072bb3-265e-400a-91b2-9c49616dc3de"),
                  ConversionFactorFromSIFormula = "Factors.Unit",
                  ConversionFactorFromSI = Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "decimole",
                  UnitLabel = "dmol",
                  SIUnitName = "mole",
                  ID = new Guid("b458e56b-edc3-48c3-8858-75d507f1f1f2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deci",
                  ConversionFactorFromSI = 1.0/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimole"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimole",
                  UnitLabel = "cmol",
                  SIUnitName = "mole",
                  ID = new Guid("4d83c0db-ddc4-4087-ae50-076148976cad"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimole"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimole",
                  UnitLabel = "mmol",
                  SIUnitName = "mole",
                  ID = new Guid("0a83a1b6-cef4-4899-bcd4-4aa1e10d232a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimole"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "micromole",
                  UnitLabel = "µmol",
                  SIUnitName = "mole",
                  ID = new Guid("ec2669ad-9742-4667-8a14-76e00c47a41e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in micromole"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanomole",
                  UnitLabel = "nmol",
                  SIUnitName = "mole",
                  ID = new Guid("dc8d0034-ecfa-4dbf-a24c-f1851c4aaf9c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanomole"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "picomole",
                  UnitLabel = "pmol",
                  SIUnitName = "mole",
                  ID = new Guid("642555ea-37f0-49b9-9f21-8dd616d477c4"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in picomole"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pico, i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilomole",
                  UnitLabel = "kmol",
                  SIUnitName = "mole",
                  ID = new Guid("01157606-070e-41a2-8c78-84a7ae950bd6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilomole"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class AngleGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "radian per metre",
                  UnitLabel = "rad/m",
                  SIUnitName = "radian per metre",
                  ID = new Guid("5d9782b6-c4c7-47ca-a86b-dce3f63c3747"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "degree per metre",
                  UnitLabel = "°/m",
                  SIUnitName = "radian per metre",
                  ID = new Guid("2fcd4219-8879-4494-9563-5173ec2292fa"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree, i.e., 57.29577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per centimetre",
                  UnitLabel = "°/cm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("7f4f63d6-5ea8-4c6b-8be4-81f52b7060c7"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Centi",
                  ConversionFactorFromSI = Factors.Degree*Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Centi, i.e., 0.5729577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per foot",
                  UnitLabel = "°/ft",
                  SIUnitName = "radian per metre",
                  ID = new Guid("23bf7716-5779-4607-aef7-1e0eeb7f201b"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Foot",
                  ConversionFactorFromSI = Factors.Degree*Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Foot, i.e., 17.46375359558749"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per inch",
                  UnitLabel = "°/in",
                  SIUnitName = "radian per metre",
                  ID = new Guid("271db65d-2a9f-4fec-a52a-21e13e106dd4"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Inch",
                  ConversionFactorFromSI = Factors.Degree*Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Inch, i.e., 1.455312799632291"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per decimetre",
                  UnitLabel = "°/dm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("452edd17-d501-487b-8cc1-90c08f7b1417"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Deci",
                  ConversionFactorFromSI = Factors.Degree*Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Deci, i.e., 5.729577951308233"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per millimetre",
                  UnitLabel = "°/mm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("5cc72a73-70c0-4ccf-83ae-38e8a45391b4"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Milli",
                  ConversionFactorFromSI = Factors.Degree*Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Milli, i.e., 0.057295779513082325"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per millimetre",
                  UnitLabel = "rad/mm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("dbd20525-128b-43c5-9de4-a8e604cbf6bf"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per centimetre",
                  UnitLabel = "rad/cm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("5552abca-e21b-48ca-aedc-4518a32b8de3"),
                  ConversionFactorFromSIFormula = "Factors.Centi",
                  ConversionFactorFromSI = Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per decimetre",
                  UnitLabel = "rad/dm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("47e72ab7-444d-4d4b-8cd2-01d2fb8efa2d"),
                  ConversionFactorFromSIFormula = "Factors.Deci",
                  ConversionFactorFromSI = Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per foot",
                  UnitLabel = "rad/ft",
                  SIUnitName = "radian per metre",
                  ID = new Guid("e1ab7dd2-48c7-4ac8-ac5e-bc50fdcae5df"),
                  ConversionFactorFromSIFormula = "Factors.Foot",
                  ConversionFactorFromSI = Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot, i.e., 0.30479999999999996"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per inch",
                  UnitLabel = "rad/in",
                  SIUnitName = "radian per metre",
                  ID = new Guid("c36cf9c1-d4f2-4654-99eb-5d84eac21c66"),
                  ConversionFactorFromSIFormula = "Factors.Inch",
                  ConversionFactorFromSI = Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch, i.e., 0.0254"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
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
                  SIUnitName = "radian tesla",
                  ID = new Guid("242bd328-96ef-4a1b-9a78-1e2eb8366955"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "radian gauss",
                  UnitLabel = "rad•G",
                  SIUnitName = "radian tesla",
                  ID = new Guid("aa726b90-bd4b-420c-ae71-6f2f1fde3b58"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Gauss",
                  ConversionFactorFromSI = 1.0/Factors.Gauss,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian gauss"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Gauss, i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian milligauss",
                  UnitLabel = "rad•mG",
                  SIUnitName = "radian tesla",
                  ID = new Guid("352a5b84-306d-4e38-898a-58705683fdf0"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Gauss)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Gauss),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian milligauss"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Milli*Gauss), i.e., 10000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian millitesla",
                  UnitLabel = "rad•mT",
                  SIUnitName = "radian tesla",
                  ID = new Guid("663639b3-48b8-4c04-a2eb-6ae2e16daa9b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian millitesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian microtesla",
                  UnitLabel = "rad•µT",
                  SIUnitName = "radian tesla",
                  ID = new Guid("b445e592-e0ca-490f-8880-9708e4e96a01"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian microtesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian nanotesla",
                  UnitLabel = "rad•nT",
                  SIUnitName = "radian tesla",
                  ID = new Guid("b4aeee40-29fa-463a-80a4-e10fa42c743f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian nanotesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian maxwell per square centimetre",
                  UnitLabel = "rad•Mx/cm²",
                  SIUnitName = "radian tesla",
                  ID = new Guid("02d06899-5d89-4669-a4c2-35adb9ec3924"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Centi*Factors.Centi)",
                  ConversionFactorFromSI = 1.0/(Factors.Centi*Factors.Centi),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian maxwell per square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Centi*Centi), i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian weber per square metre",
                  UnitLabel = "rad•Wb/m²",
                  SIUnitName = "radian tesla",
                  ID = new Guid("409e8e85-0870-4529-ae0c-95ab6506c445"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian weber per square metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree tesla",
                  UnitLabel = "°•T",
                  SIUnitName = "radian tesla",
                  ID = new Guid("13df770f-6e77-4de4-91c6-137206e53fbb"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Unit",
                  ConversionFactorFromSI = Factors.Degree/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree tesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree/Unit, i.e., 57.29577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree gauss",
                  UnitLabel = "°•G",
                  SIUnitName = "radian tesla",
                  ID = new Guid("73bb1de0-ccc0-42e6-b88e-44ecfb6fe7e4"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Gauss",
                  ConversionFactorFromSI = Factors.Degree/Factors.Gauss,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree gauss"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree/Gauss, i.e., 572957.7951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree milligauss",
                  UnitLabel = "°•mG",
                  SIUnitName = "radian tesla",
                  ID = new Guid("e74c9ae3-6e17-48e1-896b-e6c1877d68d7"),
                  ConversionFactorFromSIFormula = "Factors.Degree/(Factors.Milli*Factors.Gauss)",
                  ConversionFactorFromSI = Factors.Degree/(Factors.Milli*Factors.Gauss),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree milligauss"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree/(Milli*Gauss), i.e., 572957795.1308231"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree millitesla",
                  UnitLabel = "°•mT",
                  SIUnitName = "radian tesla",
                  ID = new Guid("812a3461-ae4a-405b-ae5d-73eb23e8a71f"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Milli",
                  ConversionFactorFromSI = Factors.Degree/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree millitesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree/Milli, i.e., 57295.77951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree microtesla",
                  UnitLabel = "°•µT",
                  SIUnitName = "radian tesla",
                  ID = new Guid("50782201-236e-4537-843b-121e8dca28c6"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Micro",
                  ConversionFactorFromSI = Factors.Degree/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree microtesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree/Micro, i.e., 57295779.513082325"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree nanotesla",
                  UnitLabel = "°•nT",
                  SIUnitName = "radian tesla",
                  ID = new Guid("0d9bf20d-2b10-4e73-ae8e-3d3e91862ec0"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Nano",
                  ConversionFactorFromSI = Factors.Degree/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree nanotesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree/Nano, i.e., 57295779513.08232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree maxwell per square centimetre",
                  UnitLabel = "°•Mx/cm²",
                  SIUnitName = "radian tesla",
                  ID = new Guid("092e8231-a6e6-4b29-bdd6-2ae490aa583a"),
                  ConversionFactorFromSIFormula = "Factors.Degree/(Factors.Centi*Factors.Centi)",
                  ConversionFactorFromSI = Factors.Degree/(Factors.Centi*Factors.Centi),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree maxwell per square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree/(Centi*Centi), i.e., 572957.7951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree weber per square metre",
                  UnitLabel = "°•Wb/m²",
                  SIUnitName = "radian tesla",
                  ID = new Guid("2d7e1d60-6401-41c0-b436-612116be9ad4"),
                  ConversionFactorFromSIFormula = "Factors.Degree/Factors.Unit",
                  ConversionFactorFromSI = Factors.Degree/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree weber per square metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree/Unit, i.e., 57.29577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
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
                  SIUnitName = "radian per second squared",
                  ID = new Guid("15d7ab2b-c0c3-4d33-8242-670ba2f937ff"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "degree per second squared",
                  UnitLabel = "°/s²",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("6fcc944b-fd7e-4368-baa4-3bb8eeba63a2"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per second squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree, i.e., 57.29577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per day per second",
                  UnitLabel = "rad/d/s",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("76b421a7-87e5-4fdf-a280-8e5aea80e0d0"),
                  ConversionFactorFromSIFormula = "Factors.Day",
                  ConversionFactorFromSI = Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per day per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day, i.e., 86400"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour per second",
                  UnitLabel = "rad/h/s",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("70b2f838-b8d2-425f-bea1-0a841c520ba8"),
                  ConversionFactorFromSIFormula = "Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per hour per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute per second",
                  UnitLabel = "rad/min/s",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("fdf50c96-cef9-466a-80d6-747b99dad734"),
                  ConversionFactorFromSIFormula = "Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per day per second",
                  UnitLabel = "°/d/s",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("838a73aa-fd19-42ac-9c72-c62573cda91b"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Degree",
                  ConversionFactorFromSI = Factors.Day*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per day per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day*Degree, i.e., 4950355.3499303125"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour per second",
                  UnitLabel = "°/h/s",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("cbfff738-14e6-47ad-8b21-41eeeea41439"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Hour*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per hour per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Degree, i.e., 206264.80624709636"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute per second",
                  UnitLabel = "°/min/s",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("f6b4276b-64a8-46f9-a831-fd14a61c34a0"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Degree",
                  ConversionFactorFromSI = Factors.Minute*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Degree, i.e., 3437.746770784939"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per second per minute",
                  UnitLabel = "rad/s/min",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("6bc32ba1-3a66-415a-bc0f-d9292ac77ab6"),
                  ConversionFactorFromSIFormula = "Factors.Unit * Factors.Minute",
                  ConversionFactorFromSI = Factors.Unit * Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per second per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit * Minute, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per second per minute",
                  UnitLabel = "°/s/min",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("2bb42b52-ab2d-4d2f-8ebb-1294f9b35b89"),
                  ConversionFactorFromSIFormula = "Factors.Unit * Factors.Minute * Factors.Degree",
                  ConversionFactorFromSI = Factors.Unit * Factors.Minute * Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per second per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit * Minute * Degree, i.e., 3437.746770784939"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per day per minute",
                  UnitLabel = "rad/d/min",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("62a8e46b-3701-4375-be57-f5d53df23d87"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Minute",
                  ConversionFactorFromSI = Factors.Day*Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per day per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day*Minute, i.e., 5184000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour per minute",
                  UnitLabel = "rad/h/min",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("77f3ea1e-8280-4881-befe-08dc1065a94f"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Minute",
                  ConversionFactorFromSI = Factors.Hour*Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per hour per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Minute, i.e., 216000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute squared",
                  UnitLabel = "rad/min²",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("61ec8b9b-f1c7-4798-bf37-d7f697d0ea8e"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per minute squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Minute, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per day per minute",
                  UnitLabel = "°/d/min",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("22b8d910-ce73-4ce4-87b3-761aa17059d6"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Minute*Factors.Degree",
                  ConversionFactorFromSI = Factors.Day*Factors.Minute*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per day per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day*Minute*Degree, i.e., 297021320.99581873"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour per minute",
                  UnitLabel = "°/h/min",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("414785c2-4d81-472e-a020-7eca9913ebd2"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Minute*Factors.Degree",
                  ConversionFactorFromSI = Factors.Hour*Factors.Minute*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per hour per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Minute*Degree, i.e., 12375888.374825781"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute squared",
                  UnitLabel = "°/min²",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("49b1ab89-8a0c-4bd9-b693-7db0e14b86e9"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute*Factors.Degree",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per minute squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Minute*Degree, i.e., 206264.80624709636"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per second per hour",
                  UnitLabel = "rad/s/h",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("6bb6033c-3391-4e68-9cc3-63e9d8b03eb3"),
                  ConversionFactorFromSIFormula = "Factors.Unit*Factors.Hour",
                  ConversionFactorFromSI = Factors.Unit*Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per second per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit*Hour, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per second per hour",
                  UnitLabel = "°/s/h",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("cdd641f0-2b50-4cb4-88c1-256ac2f5e2b5"),
                  ConversionFactorFromSIFormula = "Factors.Unit*Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Unit*Factors.Hour*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per second per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit*Hour*Degree, i.e., 206264.80624709636"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per day per hour",
                  UnitLabel = "rad/d/h",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("1ff0952d-4395-4dd6-b101-99b890a46ee8"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Hour",
                  ConversionFactorFromSI = Factors.Day*Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per day per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day*Hour, i.e., 311040000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour squared",
                  UnitLabel = "rad/h²",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("f105faab-2b48-402a-98f2-004b99adb5a7"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour*Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per hour squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Hour, i.e., 12960000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute per hour",
                  UnitLabel = "rad/min/h",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("c5713507-731e-482a-bd4e-d86ef21d4ae5"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Hour",
                  ConversionFactorFromSI = Factors.Minute*Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per minute per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Hour, i.e., 216000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per day per hour",
                  UnitLabel = "°/d/h",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("7e8596f9-657f-4eb6-937d-091a55bd0e34"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Day*Factors.Hour*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per day per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day*Hour*Degree, i.e., 17821279259.749126"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour squared",
                  UnitLabel = "°/h²",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("fad47c71-53d9-4a88-b720-6a953092b41b"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Hour*Factors.Hour*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per hour squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Hour*Degree, i.e., 742553302.4895469"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute per hour",
                  UnitLabel = "°/min/h",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("a4870e3b-95b7-4c8c-b86a-ffe1d2d6e524"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Hour*Factors.Degree",
                  ConversionFactorFromSI = Factors.Minute*Factors.Hour*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per minute per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Hour*Degree, i.e., 12375888.374825781"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per second per day",
                  UnitLabel = "rad/s/d",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("52462419-b494-473f-a46d-270ae253f076"),
                  ConversionFactorFromSIFormula = "Factors.Unit*Factors.Day",
                  ConversionFactorFromSI = Factors.Unit*Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per second per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit*Day, i.e., 86400"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per second per day",
                  UnitLabel = "°/s/d",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("dab003cb-6906-4f9f-8551-e8f72d3a1c4d"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Unit*Factors.Day",
                  ConversionFactorFromSI = Factors.Degree*Factors.Unit*Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per second per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Unit*Day, i.e., 4950355.3499303125"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per day squared",
                  UnitLabel = "rad/d²",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("6027756a-1c1e-47e8-b938-0bc4e4b25a24"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Day",
                  ConversionFactorFromSI = Factors.Day*Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per day squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day*Day, i.e., 7464960000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour per day",
                  UnitLabel = "rad/h/d",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("a31be21e-1f83-4e9b-aaa7-56a2f797c3d6"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Day",
                  ConversionFactorFromSI = Factors.Hour*Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per hour per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Day, i.e., 311040000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute per day",
                  UnitLabel = "rad/min/d",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("3335414d-1a69-477b-b27f-61f464a7ca13"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Day",
                  ConversionFactorFromSI = Factors.Minute*Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per minute per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Day, i.e., 5184000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per day squared",
                  UnitLabel = "°/d²",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("a77c1dea-6fe9-43cc-9f53-75d87e00e458"),
                  ConversionFactorFromSIFormula = "Factors.Day*Factors.Day*Factors.Degree",
                  ConversionFactorFromSI = Factors.Day*Factors.Day*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per day squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day*Day*Degree, i.e., 427710702233.979"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour per day",
                  UnitLabel = "°/h/d",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("69437581-725e-4a66-b945-abaac133be0a"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Day*Factors.Degree",
                  ConversionFactorFromSI = Factors.Hour*Factors.Day*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per hour per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Day*Degree, i.e., 17821279259.749126"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute per day",
                  UnitLabel = "°/min/d",
                  SIUnitName = "radian per second squared",
                  ID = new Guid("5a8a9fe1-9866-4c71-95a5-23dcb4726235"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Day*Factors.Degree",
                  ConversionFactorFromSI = Factors.Minute*Factors.Day*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per minute per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Day*Degree, i.e., 297021320.99581873"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "",
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
                  SIUnitName = "radian per second",
                  ID = new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "degree per second",
                  UnitLabel = "°/s",
                  SIUnitName = "radian per second",
                  ID = new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree, i.e., 57.29577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per day",
                  UnitLabel = "rad/d",
                  SIUnitName = "radian per second",
                  ID = new Guid("53f2a55b-beb6-4e4d-b696-e817c5b0eaed"),
                  ConversionFactorFromSIFormula = "Factors.Day",
                  ConversionFactorFromSI = Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day, i.e., 86400"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per hour",
                  UnitLabel = "rad/h",
                  SIUnitName = "radian per second",
                  ID = new Guid("c2f0e82b-236b-4eb5-9c77-b2c500ab60ab"),
                  ConversionFactorFromSIFormula = "Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per minute",
                  UnitLabel = "rad/min",
                  SIUnitName = "radian per second",
                  ID = new Guid("5267eb8c-36bc-4ab9-bd62-26f05f852c35"),
                  ConversionFactorFromSIFormula = "Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per day",
                  UnitLabel = "°/d",
                  SIUnitName = "radian per second",
                  ID = new Guid("ec049b3d-134b-44a3-9746-0419a368beef"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Day",
                  ConversionFactorFromSI = Factors.Degree*Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Day, i.e., 4950355.3499303125"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per hour",
                  UnitLabel = "°/h",
                  SIUnitName = "radian per second",
                  ID = new Guid("44cc8b17-2f87-49c9-8ab7-7f4ed36d9eb6"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Hour",
                  ConversionFactorFromSI = Factors.Degree*Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Hour, i.e., 206264.80624709636"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per minute",
                  UnitLabel = "°/min",
                  SIUnitName = "radian per second",
                  ID = new Guid("0a3ad50c-bbfa-456c-9613-84f37b4a80f1"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Minute",
                  ConversionFactorFromSI = Factors.Degree*Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Minute, i.e., 3437.746770784939"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
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
                  SIUnitName = "square metre",
                  ID = new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Unit*Factors.Unit)",
                  ConversionFactorFromSI = 1.0/(Factors.Unit*Factors.Unit),
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "square kilometre",
                  UnitLabel = "km²",
                  SIUnitName = "square metre",
                  ID = new Guid("6353513a-6e38-4a58-b20c-d3e8d7b70fb8"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.Kilo)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.Kilo),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square kilometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*Kilo), i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hectare",
                  UnitLabel = "ha",
                  SIUnitName = "square metre",
                  ID = new Guid("14313265-7985-4010-a19a-5ffaebe05092"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Hecto*Factors.Hecto)",
                  ConversionFactorFromSI = 1.0/(Factors.Hecto*Factors.Hecto),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hectare"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Hecto*Hecto), i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square decametre",
                  UnitLabel = "dam²",
                  SIUnitName = "square metre",
                  ID = new Guid("df9417fc-1c08-4c76-a177-e8ea803b2e2f"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deca*Factors.Deca)",
                  ConversionFactorFromSI = 1.0/(Factors.Deca*Factors.Deca),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square decametre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Deca*Deca), i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square decimetre",
                  UnitLabel = "dm²",
                  SIUnitName = "square metre",
                  ID = new Guid("125fd8d6-d1eb-4826-a952-5219603409ab"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deci*Factors.Deci)",
                  ConversionFactorFromSI = 1.0/(Factors.Deci*Factors.Deci),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Deci*Deci), i.e., 99.99999999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square centimetre",
                  UnitLabel = "cm²",
                  SIUnitName = "square metre",
                  ID = new Guid("d74bb2bc-9c86-4be4-bff1-88cac7b1049b"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Centi*Factors.Centi)",
                  ConversionFactorFromSI = 1.0/(Factors.Centi*Factors.Centi),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Centi*Centi), i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square millimetre",
                  UnitLabel = "mm²",
                  SIUnitName = "square metre",
                  ID = new Guid("0b87d221-284a-4e8c-8a60-50c522f9ade4"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Milli)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Milli),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Milli*Milli), i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square micrometre",
                  UnitLabel = "µm²",
                  SIUnitName = "square metre",
                  ID = new Guid("bec98c97-72c7-4485-9138-058ed14e7fbe"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Micro*Factors.Micro)",
                  ConversionFactorFromSI = 1.0/(Factors.Micro*Factors.Micro),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square micrometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Micro*Micro), i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square foot",
                  UnitLabel = "ft²",
                  SIUnitName = "square metre",
                  ID = new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = 1.0/(Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Foot*Foot), i.e., 10.763910416709725"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square inch",
                  UnitLabel = "in²",
                  SIUnitName = "square metre",
                  ID = new Guid("294bc6d0-5be7-4c70-95f3-ad9dc50f02cf"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Inch*Factors.Inch)",
                  ConversionFactorFromSI = 1.0/(Factors.Inch*Factors.Inch),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Inch*Inch), i.e., 1550.0031000062002"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square yard",
                  UnitLabel = "yd²",
                  SIUnitName = "square metre",
                  ID = new Guid("ae3df24c-e5db-4b88-9e81-228f29855f1b"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Yard*Factors.Yard)",
                  ConversionFactorFromSI = 1.0/(Factors.Yard*Factors.Yard),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Yard*Yard), i.e., 1.1959900463010806"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "acre",
                  UnitLabel = "ac",
                  SIUnitName = "square metre",
                  ID = new Guid("bc94456a-b8b9-49ac-b349-eaded6c984c6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Acre",
                  ConversionFactorFromSI = 1.0/Factors.Acre,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in acre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Acre, i.e., 0.0002471053814671654"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Acre = SurveyorChain * Furlong reference: https://en.wikipedia.org/wiki/Acre"
 + Environment.NewLine + "SurveyorChain = 22.0 * Yard reference: https://www.britannica.com/technology/surveyors-chain"
 + Environment.NewLine + "Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "square mile",
                  UnitLabel = "mi²",
                  SIUnitName = "square metre",
                  ID = new Guid("5bbe8c59-cce9-47c8-b357-c5a15610af72"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mile*Factors.Mile)",
                  ConversionFactorFromSI = 1.0/(Factors.Mile*Factors.Mile),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in square mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mile*Mile), i.e., 3.861021585424459E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
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
                  SIUnitName = "inverse pascal",
                  ID = new Guid("0e259998-c8bb-4a4d-b281-afb8008b2693"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "inverse bar",
                  UnitLabel = "1/bar",
                  SIUnitName = "inverse pascal",
                  ID = new Guid("4a0f6df4-0d2d-489b-80f1-511be7713101"),
                  ConversionFactorFromSIFormula = "Factors.Bar",
                  ConversionFactorFromSI = Factors.Bar,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inverse bar"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Bar, i.e., 100000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inverse pound per square inch",
                  UnitLabel = "1/psi",
                  SIUnitName = "inverse pascal",
                  ID = new Guid("282ab24c-6c43-4710-8e52-433bdf90cc2e"),
                  ConversionFactorFromSIFormula = "Factors.PSI",
                  ConversionFactorFromSI = Factors.PSI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inverse pound per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = PSI, i.e., 6894.757293168361"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inverse atmosphere",
                  UnitLabel = "1/atm",
                  SIUnitName = "inverse pascal",
                  ID = new Guid("92c19398-ac0f-41fc-8a22-516c3dc59c82"),
                  ConversionFactorFromSIFormula = "Factors.Atmosphere",
                  ConversionFactorFromSI = Factors.Atmosphere,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inverse atmosphere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Atmosphere, i.e., 101325"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure"
 + Environment.NewLine + "",
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
                  SIUnitName = "radian per metre",
                  ID = new Guid("cbba2f64-9914-4c00-a3fe-3c2aef560225"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "degree per 10m",
                  UnitLabel = "°/10m",
                  SIUnitName = "radian per metre",
                  ID = new Guid("c62408d6-c3c5-47bd-8cb0-4fa9faf51598"),
                  ConversionFactorFromSIFormula = "Factors.Degree*10.0",
                  ConversionFactorFromSI = Factors.Degree*10.0,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per 10m"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*10.0, i.e., 572.9577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per 30m",
                  UnitLabel = "°/30m",
                  SIUnitName = "radian per metre",
                  ID = new Guid("98a4d593-c959-49fb-ba1a-b1aa61830cd7"),
                  ConversionFactorFromSIFormula = "Factors.Degree*30.0",
                  ConversionFactorFromSI = Factors.Degree*30.0,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per 30m"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*30.0, i.e., 1718.8733853924696"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per 30ft",
                  UnitLabel = "°/30ft",
                  SIUnitName = "radian per metre",
                  ID = new Guid("284dca7d-b1fc-4e40-ab08-a3e0fa2ef9d0"),
                  ConversionFactorFromSIFormula = "Factors.Degree*30.0*Factors.Foot",
                  ConversionFactorFromSI = Factors.Degree*30.0*Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per 30ft"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*30.0*Foot, i.e., 523.9126078676246"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per 100ft",
                  UnitLabel = "°/100ft",
                  SIUnitName = "radian per metre",
                  ID = new Guid("5aa20ab5-6800-48db-abb1-4c3538b0972d"),
                  ConversionFactorFromSIFormula = "Factors.Degree*100.0*Factors.Foot",
                  ConversionFactorFromSI = Factors.Degree*100.0*Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per 100ft"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*100.0*Foot, i.e., 1746.375359558749"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per foot",
                  UnitLabel = "°/ft",
                  SIUnitName = "radian per metre",
                  ID = new Guid("363a6781-5829-4046-95d8-ce1e844343fc"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Foot",
                  ConversionFactorFromSI = Factors.Degree*Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Foot, i.e., 17.46375359558749"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per foot",
                  UnitLabel = "rad/ft",
                  SIUnitName = "radian per metre",
                  ID = new Guid("1428743e-927c-4f7a-9e15-62d37790ad51"),
                  ConversionFactorFromSIFormula = "Factors.Foot",
                  ConversionFactorFromSI = Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot, i.e., 0.30479999999999996"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per metre",
                  UnitLabel = "°/m",
                  SIUnitName = "radian per metre",
                  ID = new Guid("7c47f046-0499-4108-937d-abb504883259"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree, i.e., 57.29577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per decimeter",
                  UnitLabel = "°/dm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("ed1db27f-5f42-4678-8d0b-8e4e91208a83"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Deci",
                  ConversionFactorFromSI = Factors.Degree*Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per decimeter"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Deci, i.e., 5.729577951308233"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per centimeter",
                  UnitLabel = "°/cm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("0440cec4-b070-4b03-a065-453c2fafbf24"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Centi",
                  ConversionFactorFromSI = Factors.Degree*Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per centimeter"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Centi, i.e., 0.5729577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per millimeter",
                  UnitLabel = "°/mm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("c6e0bc05-2ee5-4dd1-85fa-71de7a235ef4"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Milli",
                  ConversionFactorFromSI = Factors.Degree*Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per millimeter"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Milli, i.e., 0.057295779513082325"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per micrometer",
                  UnitLabel = "°/mm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("996e89d6-3b4a-4893-81f5-e4f539e93cf8"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Micro",
                  ConversionFactorFromSI = Factors.Degree*Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per micrometer"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Micro, i.e., 5.729577951308232E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per nanometer",
                  UnitLabel = "°/mm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("e15c78f0-7a6c-47e5-bd3f-4f02571fabe5"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Nano",
                  ConversionFactorFromSI = Factors.Degree*Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per nanometer"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Nano, i.e., 5.7295779513082324E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per decameter",
                  UnitLabel = "°/dam",
                  SIUnitName = "radian per metre",
                  ID = new Guid("970e611b-87ee-4006-aee7-c6d500c33ff0"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Deca",
                  ConversionFactorFromSI = Factors.Degree*Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per decameter"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Deca, i.e., 572.9577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per hectometer",
                  UnitLabel = "°/hm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("5cca6250-fd0e-47a7-a64f-01b8025950ad"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Hecto",
                  ConversionFactorFromSI = Factors.Degree*Factors.Hecto,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per hectometer"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Hecto, i.e., 5729.5779513082325"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per kilometer",
                  UnitLabel = "°/km",
                  SIUnitName = "radian per metre",
                  ID = new Guid("91ef582e-ee8b-4f48-a1f6-c5d96eb634ca"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Kilo",
                  ConversionFactorFromSI = Factors.Degree*Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per kilometer"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Kilo, i.e., 57295.77951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per decimeter",
                  UnitLabel = "rad/dm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("c6d2c02d-83a6-4043-9a7d-392415a74b12"),
                  ConversionFactorFromSIFormula = "Factors.Deci",
                  ConversionFactorFromSI = Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per decimeter"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per centimeter",
                  UnitLabel = "rad/cm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("f101a0b8-f710-4010-b9a5-6ced681bcf0a"),
                  ConversionFactorFromSIFormula = "Factors.Centi",
                  ConversionFactorFromSI = Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per centimeter"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per millimeter",
                  UnitLabel = "rad/mm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("80e5d9d6-c1fa-4273-8134-33ff4bc46b40"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per millimeter"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per micrometer",
                  UnitLabel = "rad/mm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("777ca6bc-48da-4353-a00d-0bf0931a4328"),
                  ConversionFactorFromSIFormula = "Factors.Micro",
                  ConversionFactorFromSI = Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per micrometer"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Micro, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per nanometer",
                  UnitLabel = "rad/mm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("eceb51ee-d3ad-4a42-a877-6b20f927fc01"),
                  ConversionFactorFromSIFormula = "Factors.Nano",
                  ConversionFactorFromSI = Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per nanometer"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Nano, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per decameter",
                  UnitLabel = "rad/dam",
                  SIUnitName = "radian per metre",
                  ID = new Guid("2e8079f1-260e-4524-be2f-cee1195c7fdd"),
                  ConversionFactorFromSIFormula = "Factors.Deca",
                  ConversionFactorFromSI = Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per decameter"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deca, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per hectometer",
                  UnitLabel = "rad/hm",
                  SIUnitName = "radian per metre",
                  ID = new Guid("cb2c22fb-ac24-4c65-96d3-2437c8942662"),
                  ConversionFactorFromSIFormula = "Factors.Hecto",
                  ConversionFactorFromSI = Factors.Hecto,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per hectometer"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hecto, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per kilometer",
                  UnitLabel = "rad/km",
                  SIUnitName = "radian per metre",
                  ID = new Guid("e9a7a647-092a-4349-bb58-0d096a1477c7"),
                  ConversionFactorFromSIFormula = "Factors.Kilo",
                  ConversionFactorFromSI = Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per kilometer"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Kilo, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per yard",
                  UnitLabel = "°/yd",
                  SIUnitName = "radian per metre",
                  ID = new Guid("9cb7c45f-56d8-4b03-b514-6b5fc687919c"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Yard",
                  ConversionFactorFromSI = Factors.Degree*Factors.Yard,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Yard, i.e., 52.391260786762466"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per mile",
                  UnitLabel = "°/mi",
                  SIUnitName = "radian per metre",
                  ID = new Guid("d155bdde-da22-4f3a-9050-9f5f7e69b57d"),
                  ConversionFactorFromSIFormula = "Factors.Degree*Factors.Mile",
                  ConversionFactorFromSI = Factors.Degree*Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree*Mile, i.e., 92208.61898470194"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per yard",
                  UnitLabel = "rad/yd",
                  SIUnitName = "radian per metre",
                  ID = new Guid("7409e987-f5cb-4d24-93a8-50fc993fe949"),
                  ConversionFactorFromSIFormula = "Factors.Yard",
                  ConversionFactorFromSI = Factors.Yard,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard, i.e., 0.9143999999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per mile",
                  UnitLabel = "rad/mi",
                  SIUnitName = "radian per metre",
                  ID = new Guid("59e78258-2739-41b4-aa50-8e077bad6678"),
                  ConversionFactorFromSIFormula = "Factors.Mile",
                  ConversionFactorFromSI = Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Mile, i.e., 1609.3439999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassDensityGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per metre",
                  UnitLabel = "kg/m³/m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("00707a6a-2e33-4214-9f8c-3e64eaa82ec1"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity per metre",
                  UnitLabel = "sg/m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("07964c1e-b0d5-4785-bee4-8b4b8882b8b2"),
                  ConversionFactorFromSIFormula = "Factors.SpecificGavity4degC",
                  ConversionFactorFromSI = Factors.SpecificGavity4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = SpecificGavity4degC, i.e., 0.001000028000784022"
 + Environment.NewLine + "and"
 + Environment.NewLine + "SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity per 10 metre",
                  UnitLabel = "sg/10m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("4af1c9f0-480c-4e80-a62b-c6b57b486c3f"),
                  ConversionFactorFromSIFormula = "Factors.Deca*Factors.SpecificGavity4degC",
                  ConversionFactorFromSI = Factors.Deca*Factors.SpecificGavity4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity per 10 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deca*SpecificGavity4degC, i.e., 0.01000028000784022"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity per 30 metre",
                  UnitLabel = "sg/30m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("f8499728-220b-4b2d-94b2-3dc2cdfa6a92"),
                  ConversionFactorFromSIFormula = "3.0*Factors.Deca*Factors.SpecificGavity4degC",
                  ConversionFactorFromSI = 3.0*Factors.Deca*Factors.SpecificGavity4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity per 30 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 3.0*Deca*SpecificGavity4degC, i.e., 0.03000084002352066"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity per 100 metre",
                  UnitLabel = "sg/100m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("af987ef2-c8e5-470a-bc53-b2fff05d2c6a"),
                  ConversionFactorFromSIFormula = "Factors.Hecto*Factors.SpecificGavity4degC",
                  ConversionFactorFromSI = Factors.Hecto*Factors.SpecificGavity4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity per 100 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hecto*SpecificGavity4degC, i.e., 0.10000280007840219"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per 100 metre",
                  UnitLabel = "g/cm³/100m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("361f976c-6271-41d2-8da3-6b4009cf5e06"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi*Factors.Hecto/Factors.Milli",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi*Factors.Hecto/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre per 100 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi*Centi*Hecto/Milli, i.e., 0.10000000000000002"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per foot",
                  UnitLabel = "ppgUK/ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("f2e67c73-3706-4c14-b23a-afe474b2ecbe"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUK*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK) per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK*Foot/Pound, i.e., 0.00305483143819196"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per 30 foot",
                  UnitLabel = "ppgUK/30ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("684acd16-b420-4952-bc42-ffb47044074d"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK*30.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUK*30.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK) per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK*30.0*Foot/Pound, i.e., 0.0916449431457588"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per 100 foot",
                  UnitLabel = "ppgUK/100ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("f4b6b8a9-c222-4ac9-a6bb-072a9ca7d567"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK*100.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUK*100.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK) per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK*100.0*Foot/Pound, i.e., 0.305483143819196"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US) per foot",
                  UnitLabel = "ppgUS/ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("56128f8e-f59e-4f30-927b-35acb6ab44b1"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUS*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US) per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS*Foot/Pound, i.e., 0.0025436792769754917"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US) per 30 foot",
                  UnitLabel = "ppgUS/30ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("389150f0-4602-4468-bba3-a8eaf1d36ca0"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS*30.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUS*30.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US) per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS*30.0*Foot/Pound, i.e., 0.07631037830926475"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US) per 100 foot",
                  UnitLabel = "ppgUS/100ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("658a9698-d34b-4a56-9ee3-3cf6e46a52a3"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS*100.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUS*100.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US) per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS*100.0*Foot/Pound, i.e., 0.2543679276975492"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per 10 metre",
                  UnitLabel = "kg/m³/10m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("2d0ed7e8-2b80-46ff-9566-bd1429aa3129"),
                  ConversionFactorFromSIFormula = "Factors.Deca/Factors.Unit",
                  ConversionFactorFromSI = Factors.Deca/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram per cubic metre per 10 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deca/Unit, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per 30 metre",
                  UnitLabel = "kg/m³/30m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("dccaa4b1-cf9f-4075-a9f2-50931e38af01"),
                  ConversionFactorFromSIFormula = "3.0 *Factors.Deca/Factors.Unit",
                  ConversionFactorFromSI = 3.0 *Factors.Deca/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram per cubic metre per 30 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 3.0 *Deca/Unit, i.e., 30"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per 100 metre",
                  UnitLabel = "kg/m³/30m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("ccca234e-8626-4f75-beed-4da4abad1317"),
                  ConversionFactorFromSIFormula = "Factors.Hecto/Factors.Unit",
                  ConversionFactorFromSI = Factors.Hecto/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram per cubic metre per 100 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hecto/Unit, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per metre",
                  UnitLabel = "g/cm³/m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("91fe264e-6f5f-4a4d-b7f7-1532810ad5bd"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi/Factors.Milli",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi*Centi/Milli, i.e., 0.0010000000000000002"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per 10 metre",
                  UnitLabel = "g/cm³/10m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("836701f1-1fbd-4ae3-aba8-17a97379272c"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi*Factors.Deca/Factors.Milli",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi*Factors.Deca/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre per 10 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi*Centi*Deca/Milli, i.e., 0.010000000000000002"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per 30 metre",
                  UnitLabel = "g/cm³/30m",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("faaa4f2f-4dd4-419a-a985-ea16c5fc6d49"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi*3.0*Factors.Deca/Factors.Milli",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi*3.0*Factors.Deca/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre per 30 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi*Centi*3.0*Deca/Milli, i.e., 0.030000000000000002"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic foot per foot",
                  UnitLabel = "lb/ft³/ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("2c75c006-8ab5-475e-87aa-f5b0501b5ad7"),
                  ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic foot per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot*Foot*Foot*Foot/Pound, i.e., 0.019028042383608865"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic foot per 30 foot",
                  UnitLabel = "lb/ft³/30ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("cd7e9b61-06e9-41ca-b1dd-c2dd0b2cce55"),
                  ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot*30.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot*30.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic foot per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot*Foot*Foot*30.0*Foot/Pound, i.e., 0.570841271508266"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic foot per 100 foot",
                  UnitLabel = "lb/ft³/100ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("bd3c10c7-aa1b-438a-a61d-791f05de5a64"),
                  ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot*100.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot*100.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic foot per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot*Foot*Foot*100.0*Foot/Pound, i.e., 1.902804238360887"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic inch per foot",
                  UnitLabel = "lb/in³/ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("8997f813-9692-4f1a-b281-42260799f2ab"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic inch per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch*Foot/Pound, i.e., 1.1011598601625506E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic inch per 30 foot",
                  UnitLabel = "lb/in³/30ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("394876ee-1779-4ac0-a306-ad64fd9b640f"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch*30.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch*30.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic inch per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch*30.0*Foot/Pound, i.e., 0.00033034795804876514"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic inch per 100 foot",
                  UnitLabel = "lb/in³/100ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("11826f55-a121-498c-b03d-e51431f00476"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch*100.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch*100.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic inch per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch*100.0*Foot/Pound, i.e., 0.0011011598601625506"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic yard per foot",
                  UnitLabel = "lb/yd³/ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("09c728a5-da92-4a0c-a5bb-3aa166c2564d"),
                  ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic yard per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard*Yard*Yard*Foot/Pound, i.e., 0.5137571443574394"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic yard per 30 foot",
                  UnitLabel = "lb/yd³/30ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("82a23b2f-56a9-4345-97ec-61e6ec250915"),
                  ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard*30.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard*30.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic yard per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard*Yard*Yard*30.0*Foot/Pound, i.e., 15.412714330723183"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic yard per 100 foot",
                  UnitLabel = "lb/yd³/100ft",
                  SIUnitName = "kilogram per cubic metre per metre",
                  ID = new Guid("6f82e6f2-2cb8-467f-8baa-6d766056acf7"),
                  ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard*100.0*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard*100.0*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic yard per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard*Yard*Yard*100.0*Foot/Pound, i.e., 51.37571443574393"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassDensityGradientPerTemperatureQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per kelvin",
                  UnitLabel = "kg/m³/K",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("8b947453-ebe8-4fa9-b59a-87557150e1cf"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity per celsius",
                  UnitLabel = "sg/°C",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("2b1d68c0-4e75-4e9d-92a1-37d501e7cb3e"),
                  ConversionFactorFromSIFormula = "Factors.SpecificGavity4degC",
                  ConversionFactorFromSI = Factors.SpecificGavity4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity per celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = SpecificGavity4degC, i.e., 0.001000028000784022"
 + Environment.NewLine + "and"
 + Environment.NewLine + "SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per celsius",
                  UnitLabel = "g/cm³/°C",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("e78e2b25-e0a7-4c06-b6df-60f97f767a20"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi/Factors.Milli",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre per celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi*Centi/Milli, i.e., 0.0010000000000000002"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per celsius",
                  UnitLabel = "ppgUK/°C",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("edac57eb-7535-447f-bcf9-0c6709b6ae3b"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUK/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK) per celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK/Pound, i.e., 0.010022412854960501"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US) per fahrenheit",
                  UnitLabel = "ppgUS/°F",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("397a5f98-842e-4d86-8fb7-f4f2f82e720b"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS*Factors.FahrenheitSlope/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUS*Factors.FahrenheitSlope/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US) per fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS*FahrenheitSlope/Pound, i.e., 0.004636335806677406"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per fahrenheit",
                  UnitLabel = "ppgUK/°F",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("24485846-7944-4903-a5c5-975298daf450"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK*Factors.FahrenheitSlope/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUK*Factors.FahrenheitSlope/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK) per fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK*FahrenheitSlope/Pound, i.e., 0.005568007141644723"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US) per celsius",
                  UnitLabel = "ppgUS/°C",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("8b642465-acee-4a4a-9cb5-6fc16ace5bc3"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS/Factors.Pound",
                  ConversionFactorFromSI = Factors.GallonUS/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US) per celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS/Pound, i.e., 0.00834540445201933"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic foot per celsius",
                  UnitLabel = "lb/ft³/°C",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("592a60a7-71e1-40dc-bfe0-573e407b893c"),
                  ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic foot per celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot*Foot*Foot/Pound, i.e., 0.06242796057614459"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic foot per fahrenheit",
                  UnitLabel = "lb/ft³/°F",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("64b97848-5c42-49ec-a09e-05c7bd0cea6b"),
                  ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot*Factors.FahrenheitSlope/Factors.Pound",
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot*Factors.FahrenheitSlope/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic foot per fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot*Foot*Foot*FahrenheitSlope/Pound, i.e., 0.03468220032008033"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic inch per celsius",
                  UnitLabel = "lb/in³/°C",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("10e845fe-c8c1-4847-bf6a-874c1f746325"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Pound",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic inch per celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/Pound, i.e., 3.612729200008369E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic inch per fahrenheit",
                  UnitLabel = "lb/in³/°F",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("586d023b-3c87-4354-bce9-5704c8d1ae0a"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch*Factors.FahrenheitSlope/Factors.Pound",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch*Factors.FahrenheitSlope/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic inch per fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch*FahrenheitSlope/Pound, i.e., 2.0070717777824268E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic yard per celsius",
                  UnitLabel = "lb/yd³/°C",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("ea5147c2-d35b-4e0c-8c47-e9f04a6e0fa1"),
                  ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard/Factors.Pound",
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic yard per celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard*Yard*Yard/Pound, i.e., 1.6855549355559039"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic yeard per fahrenheit",
                  UnitLabel = "lb/yd³/°F",
                  SIUnitName = "kilogram per cubic metre per kelvin",
                  ID = new Guid("e15f8f82-0d58-487a-9d70-8f14f3606177"),
                  ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard*Factors.FahrenheitSlope/Factors.Pound",
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard*Factors.FahrenheitSlope/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic yeard per fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard*Yard*Yard*FahrenheitSlope/Pound, i.e., 0.9364194086421688"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassDensityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kilogram per cubic metre",
                  UnitLabel = "kg/m³",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("8e175ca0-08f6-441d-afcf-a58bbe429abf"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic metre",
                  UnitLabel = "g/m³",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("8c5b7fc3-0ade-4e85-9646-71ec5fcb869a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity",
                  UnitLabel = "s.g.",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("da94ba95-4494-45af-bf99-31f00031c680"),
                  ConversionFactorFromSIFormula = "1.0/Factors.SpecificGavity4degC",
                  ConversionFactorFromSI = 1.0/Factors.SpecificGavity4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/SpecificGavity4degC, i.e., 999.972"
 + Environment.NewLine + "and"
 + Environment.NewLine + "SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre",
                  UnitLabel = "g/cm³",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("64f1b0d8-609f-4ed9-99da-52e18fe97450"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi / Factors.Milli",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi*Factors.Centi / Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi*Centi / Milli, i.e., 0.0010000000000000002"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK)",
                  UnitLabel = "ppgUK",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("75ecf787-8778-4d74-afc7-498e117d27bf"),
                  ConversionFactorFromSIFormula = "1.0/Factors.PPGUK",
                  ConversionFactorFromSI = 1.0/Factors.PPGUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/PPGUK, i.e., 0.010022412854960501"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PPGUK = Pound / GallonUK"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US)",
                  UnitLabel = "ppgUS",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("dcc01dd0-4610-42c7-9a55-2ddeb45ef6da"),
                  ConversionFactorFromSIFormula = "1.0/Factors.PPGUS",
                  ConversionFactorFromSI = 1.0/Factors.PPGUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/PPGUS, i.e., 0.00834540445201933"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PPGUS = Pound / GallonUS"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic foot",
                  UnitLabel = "lb/ft³",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("f7479c8c-8d03-460b-bfa3-2b68808be935"),
                  ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot*Foot*Foot/Pound, i.e., 0.06242796057614459"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic inch",
                  UnitLabel = "lb/in³",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("d549658a-76ab-4507-8a9e-e62a5cf47e23"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Pound",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/Pound, i.e., 3.612729200008369E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per cubic yard",
                  UnitLabel = "lb/yd³",
                  SIUnitName = "kilogram per cubic metre",
                  ID = new Guid("8199e187-5283-42cc-891e-b3887c3aa450"),
                  ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard/Factors.Pound",
                  ConversionFactorFromSI = Factors.Yard*Factors.Yard*Factors.Yard/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per cubic yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard*Yard*Yard/Pound, i.e., 1.6855549355559039"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassDensityRateOfChangeQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kilogram per cubic metre per second",
                  UnitLabel = "kg/m³/s",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("d80197aa-f0b2-4a26-a5a4-b132a248c377"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity per second",
                  UnitLabel = "sg/s",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("dec0a290-ffd8-4fc0-ae11-3a6068469791"),
                  ConversionFactorFromSIFormula = "1.0/Factors.WaterDensity4degC1Atm",
                  ConversionFactorFromSI = 1.0/Factors.WaterDensity4degC1Atm,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/WaterDensity4degC1Atm, i.e., 0.001000028000784022"
 + Environment.NewLine + "and"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity per minute",
                  UnitLabel = "sg/min",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("9c314f49-3297-4f7b-9cf3-5da32ba2f1cc"),
                  ConversionFactorFromSIFormula = "Factors.Minute / Factors.WaterDensity4degC1Atm",
                  ConversionFactorFromSI = Factors.Minute / Factors.WaterDensity4degC1Atm,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute / WaterDensity4degC1Atm, i.e., 0.06000168004704132"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "specific gravity per hour",
                  UnitLabel = "sg/h",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("ce5d34b0-d7ab-48a4-87c1-9a43fabf5c06"),
                  ConversionFactorFromSIFormula = "Factors.Hour / Factors.WaterDensity4degC1Atm",
                  ConversionFactorFromSI = Factors.Hour / Factors.WaterDensity4degC1Atm,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in specific gravity per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour / WaterDensity4degC1Atm, i.e., 3.600100802822479"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per second",
                  UnitLabel = "g/cm³/s",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("e26f57a2-9659-40fd-a670-38a3b83fd36f"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per minute",
                  UnitLabel = "g/cm³/min",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("93777f41-0e47-46aa-9ab6-413987553817"),
                  ConversionFactorFromSIFormula = "Factors.Minute * Factors.Milli",
                  ConversionFactorFromSI = Factors.Minute * Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute * Milli, i.e., 0.06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per cubic centimetre per hour",
                  UnitLabel = "g/cm³/h",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("c8d6a682-00ca-4d0f-b603-bf2d755f4b31"),
                  ConversionFactorFromSIFormula = "Factors.Hour *Factors.Milli",
                  ConversionFactorFromSI = Factors.Hour *Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per cubic centimetre per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour *Milli, i.e., 3.6"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per second",
                  UnitLabel = "ppgUK/s",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("e5a712d2-b874-4e7a-873e-a4f4f3ec7a67"),
                  ConversionFactorFromSIFormula = "1.0 / Factors.PPGUK",
                  ConversionFactorFromSI = 1.0 / Factors.PPGUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK) per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0 / PPGUK, i.e., 0.010022412854960501"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PPGUK = Pound / GallonUK"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per minute",
                  UnitLabel = "ppgUK/min",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("e79c74b9-774d-4695-81d5-75042f268b96"),
                  ConversionFactorFromSIFormula = "Factors.Minute / Factors.PPGUK",
                  ConversionFactorFromSI = Factors.Minute / Factors.PPGUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK) per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute / PPGUK, i.e., 0.6013447712976301"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "PPGUK = Pound / GallonUK"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (UK) per hour",
                  UnitLabel = "ppgUK/h",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("5b461e39-d632-4f5e-b7e7-ef30745e5070"),
                  ConversionFactorFromSIFormula = "Factors.Hour / Factors.PPGUK",
                  ConversionFactorFromSI = Factors.Hour / Factors.PPGUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (UK) per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour / PPGUK, i.e., 36.08068627785781"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "PPGUK = Pound / GallonUK"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US) per second",
                  UnitLabel = "ppgUS/s",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("eee6814a-d701-4cd8-b392-ebfedde20e11"),
                  ConversionFactorFromSIFormula = "1.0 /Factors.PPGUS",
                  ConversionFactorFromSI = 1.0 /Factors.PPGUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US) per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0 /PPGUS, i.e., 0.00834540445201933"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PPGUS = Pound / GallonUS"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US) per minute",
                  UnitLabel = "ppgUS/min",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("c047d53d-38f3-4dce-b590-1c9ab700a3ea"),
                  ConversionFactorFromSIFormula = "Factors.Minute / Factors.PPGUS",
                  ConversionFactorFromSI = Factors.Minute / Factors.PPGUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US) per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute / PPGUS, i.e., 0.5007242671211598"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "PPGUS = Pound / GallonUS"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per gallon (US) per hour",
                  UnitLabel = "ppgUS/h",
                  SIUnitName = "kilogram per cubic metre per second",
                  ID = new Guid("822327d4-9f7c-4e91-9528-4eff5dfc9643"),
                  ConversionFactorFromSIFormula = "Factors.Hour / Factors.PPGUS",
                  ConversionFactorFromSI = Factors.Hour / Factors.PPGUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per gallon (US) per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour / PPGUS, i.e., 30.043456027269592"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "PPGUS = Pound / GallonUS"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class DimensionlessQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "dimensionless",
                  UnitLabel = "",
                  SIUnitName = "dimensionless",
                  ID = new Guid("8744b0f7-2866-42d8-bf6c-b619ac87b945"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class DynamicViscosityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "pascal second",
                  UnitLabel = "Pa•s",
                  SIUnitName = "pascal second",
                  ID = new Guid("5707caa4-e293-430d-9575-425305060fcc"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "millipascal second",
                  UnitLabel = "mPa•s",
                  SIUnitName = "pascal second",
                  ID = new Guid("640f2693-dd92-472b-b2ec-0052fc7b7a11"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millipascal second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "micropascal second",
                  UnitLabel = "µPa•s",
                  SIUnitName = "pascal second",
                  ID = new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in micropascal second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "poise",
                  UnitLabel = "P",
                  SIUnitName = "pascal second",
                  ID = new Guid("79e600d1-05f1-46ef-b47a-951b04f6666e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Poise",
                  ConversionFactorFromSI = 1.0/Factors.Poise,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in poise"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Poise, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centipoise",
                  UnitLabel = "cP",
                  SIUnitName = "pascal second",
                  ID = new Guid("a71ef873-6ea2-4922-a100-231177de0e85"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Centi * Factors.Poise)",
                  ConversionFactorFromSI = 1.0/(Factors.Centi * Factors.Poise),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centipoise"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Centi * Poise), i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millipoise",
                  UnitLabel = "mP",
                  SIUnitName = "pascal second",
                  ID = new Guid("f20c7109-bf60-413b-8f41-6f1d2f3bff45"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli* Factors.Poise)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli* Factors.Poise),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millipoise"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Milli* Poise), i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "micropoise",
                  UnitLabel = "µP",
                  SIUnitName = "pascal second",
                  ID = new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Micro* Factors.Poise)",
                  ConversionFactorFromSI = 1.0/(Factors.Micro* Factors.Poise),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in micropoise"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Micro* Poise), i.e., 10000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound second per square foot",
                  UnitLabel = "lb•s/ft²",
                  SIUnitName = "pascal second",
                  ID = new Guid("1397525b-b5b6-4b3c-82e8-b562f01e9a42"),
                  ConversionFactorFromSIFormula = "(Factors.Foot*Factors.Foot)/(Factors.Pound * Factors.G)",
                  ConversionFactorFromSI = (Factors.Foot*Factors.Foot)/(Factors.Pound * Factors.G),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound second per square foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = (Foot*Foot)/(Pound * G), i.e., 0.020885434233150126"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound second per 100 square foot",
                  UnitLabel = "lb•s/100ft²",
                  SIUnitName = "pascal second",
                  ID = new Guid("b48720b9-8eb5-4b5c-8da1-ca2312fdff01"),
                  ConversionFactorFromSIFormula = "(100.0*Factors.Foot*Factors.Foot)/(Factors.Pound * Factors.G)",
                  ConversionFactorFromSI = (100.0*Factors.Foot*Factors.Foot)/(Factors.Pound * Factors.G),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound second per 100 square foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = (100.0*Foot*Foot)/(Pound * G), i.e., 2.0885434233150124"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound second per square inch",
                  UnitLabel = "lb•s/in²",
                  SIUnitName = "pascal second",
                  ID = new Guid("70b7471d-6a62-4ce9-8def-ceb3d6d7495f"),
                  ConversionFactorFromSIFormula = "(Factors.Inch*Factors.Inch)/(Factors.Pound * Factors.G)",
                  ConversionFactorFromSI = (Factors.Inch*Factors.Inch)/(Factors.Pound * Factors.G),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound second per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = (Inch*Inch)/(Pound * G), i.e., 0.0001450377377302092"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "dyne second per square centimetre",
                  UnitLabel = "dyne•s/cm²",
                  SIUnitName = "pascal second",
                  ID = new Guid("90ce61e5-46db-47f9-9c22-1c0f19068132"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Poise",
                  ConversionFactorFromSI = 1.0/Factors.Poise,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in dyne second per square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Poise, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ElectricCapacitanceQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "farad",
                  UnitLabel = "F",
                  SIUnitName = "farad",
                  ID = new Guid("11dd208b-bcf2-4415-b7a9-4161791166c7"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "coulomb per volt",
                  UnitLabel = "C/V",
                  SIUnitName = "farad",
                  ID = new Guid("81ae5717-d834-4f25-800e-c42c3bcb48af"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in coulomb per volt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millifarad",
                  UnitLabel = "mF",
                  SIUnitName = "farad",
                  ID = new Guid("12c8b1ad-d38a-4dbe-b418-7f3b31c23ff6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millifarad"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microfarad",
                  UnitLabel = "μF",
                  SIUnitName = "farad",
                  ID = new Guid("a5974c82-68ac-4166-81b0-123f3ae84701"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microfarad"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanofarad",
                  UnitLabel = "nF",
                  SIUnitName = "farad",
                  ID = new Guid("c1af9df8-69d5-41d3-9027-3c89aa151777"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanofarad"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "picofarad",
                  UnitLabel = "pF",
                  SIUnitName = "farad",
                  ID = new Guid("1a9b9112-8a9f-4c80-a2ad-ebe5d9af5eef"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in picofarad"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pico, i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ElectricCurrentQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "ampere",
                  UnitLabel = "A",
                  SIUnitName = "ampere",
                  ID = new Guid("1cd2ef0e-baf8-43fb-9fac-64f84560d0a9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "coulomb per second",
                  UnitLabel = "C/s",
                  SIUnitName = "ampere",
                  ID = new Guid("0a9cc349-3bac-4f44-9a9b-3940ae595f03"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in coulomb per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "siemens volt",
                  UnitLabel = "S•V",
                  SIUnitName = "ampere",
                  ID = new Guid("52bc6bd9-f25d-470b-9068-b6e87f1f2ed0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in siemens volt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "volt per ohm",
                  UnitLabel = "V/Ω",
                  SIUnitName = "ampere",
                  ID = new Guid("100dd38e-19ad-465c-a995-0fb1174e506b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in volt per ohm"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "watt per volt",
                  UnitLabel = "W/V",
                  SIUnitName = "ampere",
                  ID = new Guid("29464509-67a2-4062-b78a-8156e54cfa88"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in watt per volt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "weber per henry",
                  UnitLabel = "Wb/H",
                  SIUnitName = "ampere",
                  ID = new Guid("bf3285f5-34be-4592-822d-f6ffc3ce4858"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in weber per henry"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "deciampere",
                  UnitLabel = "dA",
                  SIUnitName = "ampere",
                  ID = new Guid("fdca0a23-f088-4a93-8bfa-4776d19dc26e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deci",
                  ConversionFactorFromSI = 1.0/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in deciampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centiampere",
                  UnitLabel = "cA",
                  SIUnitName = "ampere",
                  ID = new Guid("f057be23-0f56-4a5f-bb39-3ec032b66ff8"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centiampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "milliampere",
                  UnitLabel = "mA",
                  SIUnitName = "ampere",
                  ID = new Guid("a2b3179e-3003-48eb-82aa-80fbfb2cfe39"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in milliampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microampere",
                  UnitLabel = "µA",
                  SIUnitName = "ampere",
                  ID = new Guid("fb4dfa70-2011-468a-9c4a-06aba3754fc2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanoampere",
                  UnitLabel = "nA",
                  SIUnitName = "ampere",
                  ID = new Guid("f5f75652-d393-4328-87f0-6132fd8dc786"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanoampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "picoampere",
                  UnitLabel = "pA",
                  SIUnitName = "ampere",
                  ID = new Guid("9c5c1ea2-89bc-48f8-83ab-fbde7b1f3721"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in picoampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pico, i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "biot",
                  UnitLabel = "Bi",
                  SIUnitName = "ampere",
                  ID = new Guid("4648ec96-2c82-4aa2-8de3-d6eb105f470e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deca",
                  ConversionFactorFromSI = 1.0/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in biot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deca, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "abampere",
                  UnitLabel = "abA",
                  SIUnitName = "ampere",
                  ID = new Guid("d589a05d-d6a4-4d2d-9ec7-3a02d0de2ef0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deca",
                  ConversionFactorFromSI = 1.0/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in abampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deca, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kiloampere",
                  UnitLabel = "kA",
                  SIUnitName = "ampere",
                  ID = new Guid("5a500f57-a5d1-41c2-9b8d-b08757420bb8"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kiloampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megaampere",
                  UnitLabel = "MA",
                  SIUnitName = "ampere",
                  ID = new Guid("978af2aa-e776-43d6-bfe6-4055b6d602e8"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megaampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigaampere",
                  UnitLabel = "GA",
                  SIUnitName = "ampere",
                  ID = new Guid("eb1b76cd-4863-4cf3-b421-1cd80d2fb0b4"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigaampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "teraampere",
                  UnitLabel = "TA",
                  SIUnitName = "ampere",
                  ID = new Guid("4bf45d0a-e177-45b9-8a40-f8f51d5b15c6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Tera",
                  ConversionFactorFromSI = 1.0/Factors.Tera,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in teraampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Tera, i.e., 1E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Tera = 1e12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "statampere",
                  UnitLabel = "stA",
                  SIUnitName = "ampere",
                  ID = new Guid("7d9a22ac-62d8-476d-8429-bc41febbe707"),
                  ConversionFactorFromSIFormula = "Factors.C_cgs/10.0",
                  ConversionFactorFromSI = Factors.C_cgs/10.0,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in statampere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = C_cgs/10.0, i.e., 2997924580"
 + Environment.NewLine + "and"
 + Environment.NewLine + "C_cgs = 2.99792458e10 reference: https://en.wikipedia.org/wiki/Statampere"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ElectricTensionQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "volt",
                  UnitLabel = "V",
                  SIUnitName = "volt",
                  ID = new Guid("618fafff-fc9c-4d22-a64d-b7579931aa93"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "millivolt",
                  UnitLabel = "mV",
                  SIUnitName = "volt",
                  ID = new Guid("f186f5d4-2b0b-4cfe-b24c-0c02d3155cf8"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millivolt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centivolt",
                  UnitLabel = "cV",
                  SIUnitName = "volt",
                  ID = new Guid("ee01194e-dee3-4b50-8312-5fde3c8f774e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centivolt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microvolt",
                  UnitLabel = "µV",
                  SIUnitName = "volt",
                  ID = new Guid("ede7e093-3e7d-429a-8c22-3b35ab5b20f2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microvolt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanovolt",
                  UnitLabel = "nV",
                  SIUnitName = "volt",
                  ID = new Guid("86dfcbe1-af8c-4081-b6ed-481eb44ab890"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanovolt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "picovolt",
                  UnitLabel = "pV",
                  SIUnitName = "volt",
                  ID = new Guid("19fb81d7-4991-4902-a1fd-55420789ac59"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in picovolt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pico, i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilovolt",
                  UnitLabel = "kV",
                  SIUnitName = "volt",
                  ID = new Guid("6ffc60bc-ec9f-44d4-961b-79d9e593bf64"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilovolt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megavolt",
                  UnitLabel = "MV",
                  SIUnitName = "volt",
                  ID = new Guid("3342ddbc-b1b2-46f8-addc-216ce94a616a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megavolt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigavolt",
                  UnitLabel = "GV",
                  SIUnitName = "volt",
                  ID = new Guid("640f2693-dd92-472b-b2ec-0052fc7b7a11"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigavolt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ElongationGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "metre per metre",
                  UnitLabel = "m/m",
                  SIUnitName = "metre per metre",
                  ID = new Guid("cc12967b-4c7d-4c70-95cf-d2f23bd6f76b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "decimetre per metre",
                  UnitLabel = "dm/m",
                  SIUnitName = "metre per metre",
                  ID = new Guid("337d67e2-b28c-4ab8-9817-3f9951fdb67b"),
                  ConversionFactorFromSIFormula = "1.0 / Factors.Deci",
                  ConversionFactorFromSI = 1.0 / Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimetre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0 / Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per metre",
                  UnitLabel = "cm/m",
                  SIUnitName = "metre per metre",
                  ID = new Guid("4a7ce144-b35f-401f-bfbc-276b7c4ec4a9"),
                  ConversionFactorFromSIFormula = "1.0 / Factors.Centi",
                  ConversionFactorFromSI = 1.0 / Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0 / Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre per metre",
                  UnitLabel = "mm/m",
                  SIUnitName = "metre per metre",
                  ID = new Guid("4e241b59-388a-428f-82e7-b9971f9e1df5"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "micrometre per metre",
                  UnitLabel = "µm/m",
                  SIUnitName = "metre per metre",
                  ID = new Guid("bbd912b2-06e2-46fe-82da-af87bab150dc"),
                  ConversionFactorFromSIFormula = "1.0 / Factors.Micro",
                  ConversionFactorFromSI = 1.0 / Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in micrometre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0 / Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "metre per kilometre",
                  UnitLabel = "m/km",
                  SIUnitName = "metre per metre",
                  ID = new Guid("5b583a4c-7838-48e7-8201-420f43eef9e1"),
                  ConversionFactorFromSIFormula = "Factors.Kilo/Factors.Unit",
                  ConversionFactorFromSI = Factors.Kilo/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in metre per kilometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Kilo/Unit, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decimetre per kilometre",
                  UnitLabel = "dm/km",
                  SIUnitName = "metre per metre",
                  ID = new Guid("7dc93254-9a25-4215-b2bc-9f2d8dc14d6e"),
                  ConversionFactorFromSIFormula = "Factors.Kilo / Factors.Deci",
                  ConversionFactorFromSI = Factors.Kilo / Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimetre per kilometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Kilo / Deci, i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per kilometre",
                  UnitLabel = "cm/km",
                  SIUnitName = "metre per metre",
                  ID = new Guid("f539c676-e969-4235-9524-42e860e84966"),
                  ConversionFactorFromSIFormula = "Factors.Kilo / Factors.Centi",
                  ConversionFactorFromSI = Factors.Kilo / Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per kilometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Kilo / Centi, i.e., 100000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre per kilometre",
                  UnitLabel = "mm/km",
                  SIUnitName = "metre per metre",
                  ID = new Guid("59f50e71-7796-4559-9e55-7fc420d9c20c"),
                  ConversionFactorFromSIFormula = "Factors.Kilo / Factors.Milli",
                  ConversionFactorFromSI = Factors.Kilo / Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre per kilometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Kilo / Milli, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "micrometre per kilometre",
                  UnitLabel = "µm/km",
                  SIUnitName = "metre per metre",
                  ID = new Guid("73d8d799-d9f5-40f9-9216-4bc0bbf1c044"),
                  ConversionFactorFromSIFormula = "Factors.Kilo / Factors.Micro",
                  ConversionFactorFromSI = Factors.Kilo / Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in micrometre per kilometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Kilo / Micro, i.e., 1000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per foot",
                  UnitLabel = "in/ft",
                  SIUnitName = "metre per metre",
                  ID = new Guid("3df1af23-afd0-41ed-9442-a3af6ae944d2"),
                  ConversionFactorFromSIFormula = "Factors.Foot / Factors.Inch",
                  ConversionFactorFromSI = Factors.Foot / Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot / Inch, i.e., 11.999999999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per yard",
                  UnitLabel = "in/yd",
                  SIUnitName = "metre per metre",
                  ID = new Guid("ec1fbeee-cbf4-41f0-94d8-573e241c22b2"),
                  ConversionFactorFromSIFormula = "Factors.Yard / Factors.Inch",
                  ConversionFactorFromSI = Factors.Yard / Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard / Inch, i.e., 36"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per mile",
                  UnitLabel = "in/mi",
                  SIUnitName = "metre per metre",
                  ID = new Guid("998afd92-de3a-4f10-90b6-a252b8e59181"),
                  ConversionFactorFromSIFormula = "Factors.Mile / Factors.Inch",
                  ConversionFactorFromSI = Factors.Mile / Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Mile / Inch, i.e., 63359.99999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per foot",
                  UnitLabel = "ft/ft",
                  SIUnitName = "metre per metre",
                  ID = new Guid("a53ffdb6-a2db-4984-85aa-53763ba3aabb"),
                  ConversionFactorFromSIFormula = "Factors.Foot / Factors.Foot",
                  ConversionFactorFromSI = Factors.Foot / Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot / Foot, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per yard",
                  UnitLabel = "ft/yd",
                  SIUnitName = "metre per metre",
                  ID = new Guid("ba9062f9-68be-4b9c-ba61-57c8543ed6f9"),
                  ConversionFactorFromSIFormula = "Factors.Yard / Factors.Foot",
                  ConversionFactorFromSI = Factors.Yard / Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard / Foot, i.e., 3"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per mile",
                  UnitLabel = "ft/mi",
                  SIUnitName = "metre per metre",
                  ID = new Guid("89b73d98-2818-43c5-8d31-8aa1bb78d3bc"),
                  ConversionFactorFromSIFormula = "Factors.Mile / Factors.Foot",
                  ConversionFactorFromSI = Factors.Mile / Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Mile / Foot, i.e., 5280"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "yard per foot",
                  UnitLabel = "yd/ft",
                  SIUnitName = "metre per metre",
                  ID = new Guid("a6c2cf06-e21a-4387-90db-89d7d46b1b28"),
                  ConversionFactorFromSIFormula = "Factors.Foot / Factors.Yard",
                  ConversionFactorFromSI = Factors.Foot / Factors.Yard,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in yard per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot / Yard, i.e., 0.3333333333333333"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "yard per yard",
                  UnitLabel = "yd/yd",
                  SIUnitName = "metre per metre",
                  ID = new Guid("56f75af0-7213-43d9-b23f-bc74da6382e9"),
                  ConversionFactorFromSIFormula = "Factors.Yard / Factors.Yard",
                  ConversionFactorFromSI = Factors.Yard / Factors.Yard,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in yard per yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard / Yard, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "yard per mile",
                  UnitLabel = "yd/mi",
                  SIUnitName = "metre per metre",
                  ID = new Guid("3283a57e-ec6d-4487-ab32-cdc0c5de2020"),
                  ConversionFactorFromSIFormula = "Factors.Mile / Factors.Yard",
                  ConversionFactorFromSI = Factors.Mile / Factors.Yard,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in yard per mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Mile / Yard, i.e., 1760"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class EnergyDensityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "joule per cubic metre",
                  UnitLabel = "J/m³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("bac0aae1-8b3b-403d-b1ea-874a74da849a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "joule per litre",
                  UnitLabel = "J/L",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("c3ae0b19-e3b1-4433-8075-ffb1444f447d"),
                  ConversionFactorFromSIFormula = "Factors.Litre/Factors.Unit",
                  ConversionFactorFromSI = Factors.Litre/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Litre/Unit, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Litre = 0.001"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilojoule per cubic metre",
                  UnitLabel = "kJ/m³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("ebc0ab24-af1b-4315-a41e-c66ef83e02f0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilojoule per cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilojoule per litre",
                  UnitLabel = "kJ/L",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("5cfaa1c0-7155-4eb6-b1ab-48db0dab2043"),
                  ConversionFactorFromSIFormula = "Factors.Litre/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Litre/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilojoule per litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Litre/Kilo, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Litre = 0.001"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megajoule per cubic metre",
                  UnitLabel = "MJ/m³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("a5d1096b-9900-46ff-8a81-17313266dfdd"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megajoule per cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megajoule per litre",
                  UnitLabel = "MJ/L",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("f57f2f8d-3998-4ff3-ab50-bf1e8fdf99f4"),
                  ConversionFactorFromSIFormula = "Factors.Litre/Factors.Mega",
                  ConversionFactorFromSI = Factors.Litre/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megajoule per litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Litre/Mega, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Litre = 0.001"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigajoule per cubic metre",
                  UnitLabel = "GJ/m³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("7728780b-66c7-4832-b905-25cb4e0b3edf"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigajoule per cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigajoule per litre",
                  UnitLabel = "GJ/L",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("37e4f478-4e24-4735-9c31-30047d48828b"),
                  ConversionFactorFromSIFormula = "Factors.Litre/Factors.Giga",
                  ConversionFactorFromSI = Factors.Litre/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigajoule per litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Litre/Giga, i.e., 1E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Litre = 0.001"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per cubic metre",
                  UnitLabel = "cal/m³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("ea4ac69b-351f-43d6-b6f0-847e6a73a069"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Calorie",
                  ConversionFactorFromSI = 1.0/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Calorie, i.e., 0.2390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per litre",
                  UnitLabel = "cal/L",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("66d4c95b-5281-45d2-ba67-ee513f64f8dc"),
                  ConversionFactorFromSIFormula = "Factors.Litre/Factors.Calorie",
                  ConversionFactorFromSI = Factors.Litre/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Litre/Calorie, i.e., 0.0002390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Litre = 0.001"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocalorie per cubic metre",
                  UnitLabel = "Cal/m³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("b8d2b560-8541-4ad0-bb63-e2f755e92cb3"),
                  ConversionFactorFromSIFormula = "1.0 / (Factors.Kilo * Factors.Calorie)",
                  ConversionFactorFromSI = 1.0 / (Factors.Kilo * Factors.Calorie),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocalorie per cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0 / (Kilo * Calorie), i.e., 0.0002390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocalorie per litre",
                  UnitLabel = "Cal/L",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("5bb757ee-b4b4-4340-b05b-d15988369ea0"),
                  ConversionFactorFromSIFormula = "Factors.Litre/(Factors.Kilo * Factors.Calorie)",
                  ConversionFactorFromSI = Factors.Litre/(Factors.Kilo * Factors.Calorie),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocalorie per litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Litre/(Kilo * Calorie), i.e., 2.390057361376673E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Litre = 0.001"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "joule per cubic foot",
                  UnitLabel = "J/ft³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("5c91efe6-c268-4d31-bff8-768344290db6"),
                  ConversionFactorFromSIFormula = "Factors.Foot * Factors.Foot * Factors.Foot / Factors.Unit",
                  ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot * Foot * Foot / Unit, i.e., 0.02831684659199999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilojoule per cubic foot",
                  UnitLabel = "kJ/ft³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("2b21249b-3eb3-4f86-9d05-407e42d8d1c5"),
                  ConversionFactorFromSIFormula = "Factors.Foot * Factors.Foot * Factors.Foot / Factors.Kilo",
                  ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilojoule per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot * Foot * Foot / Kilo, i.e., 2.831684659199999E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megajoule per cubic foot",
                  UnitLabel = "MJ/ft³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("6bf78807-e679-4930-9e73-e52968821d9b"),
                  ConversionFactorFromSIFormula = "Factors.Foot * Factors.Foot * Factors.Foot / Factors.Mega",
                  ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megajoule per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot * Foot * Foot / Mega, i.e., 2.831684659199999E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigajoule per cubic foot",
                  UnitLabel = "GJ/ft³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("97e4a46b-11f6-4cb5-a24f-f2b004ad06cd"),
                  ConversionFactorFromSIFormula = "Factors.Foot * Factors.Foot * Factors.Foot / Factors.Giga",
                  ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigajoule per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot * Foot * Foot / Giga, i.e., 2.831684659199999E-11"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per cubic foot",
                  UnitLabel = "cal/ft³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("3efcbcd4-9f17-476d-9a47-43600ab93236"),
                  ConversionFactorFromSIFormula = "Factors.Foot * Factors.Foot * Factors.Foot / Factors.Calorie",
                  ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot * Foot * Foot / Calorie, i.e., 0.006767888764818353"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocalorie per cubic foot",
                  UnitLabel = "Cal/ft³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("ff0ebc90-50fa-4c50-8583-0879a5b2380c"),
                  ConversionFactorFromSIFormula = "Factors.Foot * Factors.Foot * Factors.Foot / (Factors.Kilo * Factors.Calorie)",
                  ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / (Factors.Kilo * Factors.Calorie),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocalorie per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot * Foot * Foot / (Kilo * Calorie), i.e., 6.767888764818354E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "joule per cubic inch",
                  UnitLabel = "J/in³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("daba8c83-b6f5-40bb-8c9d-e476e5d1bce2"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Unit",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/Unit, i.e., 1.6387064E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilojoule per cubic inch",
                  UnitLabel = "kJ/in³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("5beeb10a-314a-4c15-858d-0e900d4803e1"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilojoule per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/Kilo, i.e., 1.6387064E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megajoule per cubic inch",
                  UnitLabel = "MJ/in³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("309da835-8bcb-4bdf-bbd7-aad194ade23a"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Mega",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megajoule per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/Mega, i.e., 1.6387064E-11"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigajoule per cubic inch",
                  UnitLabel = "GJ/in³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("698b690d-b747-48da-8433-5ac0b25598d3"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Giga",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigajoule per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/Giga, i.e., 1.6387064E-14"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per cubic inch",
                  UnitLabel = "cal/in³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("6ae5cf98-0fcc-4426-9c72-481d1b1992ce"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Calorie",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/Calorie, i.e., 3.916602294455067E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocalorie per cubic inch",
                  UnitLabel = "Cal/in³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("66375de4-842e-4813-b79e-3e62cf7a97cc"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/(Factors.Kilo * Factors.Calorie)",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/(Factors.Kilo * Factors.Calorie),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocalorie per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/(Kilo * Calorie), i.e., 3.916602294455067E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "joule per gallon (UK)",
                  UnitLabel = "J/gal(UK)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("1c3b4a46-1cfa-44e4-b10e-4ed0f74e2994"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK / Factors.Unit",
                  ConversionFactorFromSI = Factors.GallonUK / Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK / Unit, i.e., 0.00454609"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilojoule per gallon (UK)",
                  UnitLabel = "kJ/gal(UK)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("a5086581-3c86-43f5-acd2-845bc35ebc33"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK / Factors.Kilo",
                  ConversionFactorFromSI = Factors.GallonUK / Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilojoule per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK / Kilo, i.e., 4.54609E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megajoule per gallon (UK)",
                  UnitLabel = "MJ/gal(UK)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("45c985ee-25be-4bd6-88de-38c98f042dbe"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK / Factors.Mega",
                  ConversionFactorFromSI = Factors.GallonUK / Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megajoule per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK / Mega, i.e., 4.54609E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigajoule per gallon (UK)",
                  UnitLabel = "GJ/gal(UK)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("e09aff93-785e-4bae-b9c5-17961bfd6642"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK / Factors.Giga",
                  ConversionFactorFromSI = Factors.GallonUK / Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigajoule per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK / Giga, i.e., 4.54609E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per gallon (UK)",
                  UnitLabel = "cal/gal(UK)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("c36ef596-5a06-4ace-a119-baae9f761e29"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK / Factors.Calorie",
                  ConversionFactorFromSI = Factors.GallonUK / Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK / Calorie, i.e., 0.0010865415869980878"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocalorie per gallon (UK)",
                  UnitLabel = "Cal/gal(UK)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("92c90ba8-7b15-4f6c-980f-f1ca44fb556a"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK / (Factors.Kilo * Factors.Calorie)",
                  ConversionFactorFromSI = Factors.GallonUK / (Factors.Kilo * Factors.Calorie),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocalorie per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK / (Kilo * Calorie), i.e., 1.086541586998088E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "joule per gallon (US)",
                  UnitLabel = "J/gal(US)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("357a5df6-6df1-43fa-8be8-652e8d97db7c"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS / Factors.Unit",
                  ConversionFactorFromSI = Factors.GallonUS / Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS / Unit, i.e., 0.0037854117839999997"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilojoule per gallon (US)",
                  UnitLabel = "kJ/gal(US)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("5d74db73-4d3f-49b8-9a6b-c8eef3b9e287"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS / Factors.Kilo",
                  ConversionFactorFromSI = Factors.GallonUS / Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilojoule per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS / Kilo, i.e., 3.7854117839999998E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megajoule per gallon (US)",
                  UnitLabel = "MJ/gal(US)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("38d388bf-bbb8-4c84-9ec8-e78c6d81ae07"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS / Factors.Mega",
                  ConversionFactorFromSI = Factors.GallonUS / Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megajoule per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS / Mega, i.e., 3.7854117839999995E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigajoule per gallon (US)",
                  UnitLabel = "GJ/gal(US)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("b3360ab2-cd97-4e2f-b29d-1470c0b34c1f"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS / Factors.Giga",
                  ConversionFactorFromSI = Factors.GallonUS / Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigajoule per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS / Giga, i.e., 3.785411784E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per gallon (US)",
                  UnitLabel = "cal/gal(US)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("30d202d9-0a80-4d71-b4c8-e434d714ee9a"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS / Factors.Calorie",
                  ConversionFactorFromSI = Factors.GallonUS / Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS / Calorie, i.e., 0.0009047351300191204"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocalorie per gallon (US)",
                  UnitLabel = "Cal/gal(US)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("05fa77bf-3dcb-4df0-bf4d-7394e9f8854d"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS / (Factors.Kilo * Factors.Calorie)",
                  ConversionFactorFromSI = Factors.GallonUS / (Factors.Kilo * Factors.Calorie),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocalorie per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS / (Kilo * Calorie), i.e., 9.047351300191203E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per cubic metre",
                  UnitLabel = "BTU/m³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("550355a8-bfbe-4045-ab32-28325513db51"),
                  ConversionFactorFromSIFormula = "1.0/Factors.BTU",
                  ConversionFactorFromSI = 1.0/Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/BTU, i.e., 0.0009484516526770049"
 + Environment.NewLine + "and"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per litre",
                  UnitLabel = "BTU/L",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("2458887d-ee5f-4502-9446-cb6a7ae55c9d"),
                  ConversionFactorFromSIFormula = "Factors.Litre/Factors.BTU",
                  ConversionFactorFromSI = Factors.Litre/Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Litre/BTU, i.e., 9.484516526770049E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Litre = 0.001"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per cubic foot",
                  UnitLabel = "BTU/ft³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("ce9d74ec-ecfc-454a-a00f-818e59c55895"),
                  ConversionFactorFromSIFormula = "Factors.Foot * Factors.Foot * Factors.Foot / Factors.BTU",
                  ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot * Foot * Foot / BTU, i.e., 2.6857159948783606E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per cubic inch",
                  UnitLabel = "BTU/in³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("dd01b982-428b-4798-9cf6-091317d8fe93"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.BTU",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/BTU, i.e., 1.554233793332385E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per gallon (UK)",
                  UnitLabel = "BTU/gal(UK)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("49e1a251-6a46-4715-a399-8953b25b7ce8"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK / Factors.BTU",
                  ConversionFactorFromSI = Factors.GallonUK / Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK / BTU, i.e., 4.311746573718405E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per gallon (US)",
                  UnitLabel = "BTU/gal(US)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("f03e145b-26fc-4597-8cd6-1f468e574644"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS / Factors.BTU",
                  ConversionFactorFromSI = Factors.GallonUS / Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS / BTU, i.e., 3.5902800625978092E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo british thermal unit per cubic metre",
                  UnitLabel = "kBTU/m³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("982cde20-c1a6-4dcf-8e37-c3784a427bc0"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo * Factors.BTU)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo * Factors.BTU),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo british thermal unit per cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo * BTU), i.e., 9.484516526770048E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo british thermal unit per litre",
                  UnitLabel = "kBTU/L",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("2a64cc42-f2ab-43df-858f-04659d9a1306"),
                  ConversionFactorFromSIFormula = "Factors.Litre/(Factors.Kilo * Factors.BTU)",
                  ConversionFactorFromSI = Factors.Litre/(Factors.Kilo * Factors.BTU),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo british thermal unit per litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Litre/(Kilo * BTU), i.e., 9.48451652677005E-10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Litre = 0.001"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo british thermal unit per cubic foot",
                  UnitLabel = "kBTU/ft³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("fdf14475-d109-4450-b5c0-9462c7ef8ec8"),
                  ConversionFactorFromSIFormula = "Factors.Foot * Factors.Foot * Factors.Foot / (Factors.Kilo * Factors.BTU)",
                  ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / (Factors.Kilo * Factors.BTU),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo british thermal unit per cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot * Foot * Foot / (Kilo * BTU), i.e., 2.6857159948783602E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo british thermal unit per cubic inch",
                  UnitLabel = "kBTU/in³",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("8d6b0b9d-8f02-4a6a-9df5-575ebebaaba3"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/(Factors.Kilo * Factors.BTU)",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/(Factors.Kilo * Factors.BTU),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo british thermal unit per cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch*Inch/(Kilo * BTU), i.e., 1.5542337933323848E-11"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo british thermal unit per gallon (UK)",
                  UnitLabel = "kBTU/gal(UK)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("24f9799f-4918-4f1c-9155-6b87c99703b0"),
                  ConversionFactorFromSIFormula = "Factors.GallonUK / (Factors.Kilo * Factors.BTU)",
                  ConversionFactorFromSI = Factors.GallonUK / (Factors.Kilo * Factors.BTU),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo british thermal unit per gallon (UK)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUK / (Kilo * BTU), i.e., 4.311746573718405E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo british thermal unit per gallon (US)",
                  UnitLabel = "kBTU/gal(US)",
                  SIUnitName = "joule per cubic metre",
                  ID = new Guid("d8751a32-b0bd-425a-a9df-0ef7f5f0cb1f"),
                  ConversionFactorFromSIFormula = "Factors.GallonUS / (Factors.Kilo * Factors.BTU)",
                  ConversionFactorFromSI = Factors.GallonUS / (Factors.Kilo * Factors.BTU),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo british thermal unit per gallon (US)"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = GallonUS / (Kilo * BTU), i.e., 3.5902800625978087E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ForceGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "newton per metre",
                  UnitLabel = "N/m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("e503a1d3-1815-4321-8087-6e3d6dc641c8"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "newton per 30 metre",
                  UnitLabel = "N/30m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("be16e271-5ce7-445b-a8db-9014a6acc22b"),
                  ConversionFactorFromSIFormula = "3*Factors.Deca/Factors.Unit",
                  ConversionFactorFromSI = 3*Factors.Deca/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per 30 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 3*Deca/Unit, i.e., 30"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per 10 metre",
                  UnitLabel = "N/10m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("46defe0c-4a00-45d1-83bb-f898e00a78c5"),
                  ConversionFactorFromSIFormula = "Factors.Deca/Factors.Unit",
                  ConversionFactorFromSI = Factors.Deca/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per 10 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deca/Unit, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per decimetre",
                  UnitLabel = "N/dm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("dcd21076-ecb6-481e-8b8b-1cd5ccc68915"),
                  ConversionFactorFromSIFormula = "Factors.Deci/Factors.Unit",
                  ConversionFactorFromSI = Factors.Deci/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/Unit, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per centimetre",
                  UnitLabel = "N/cm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("739cb2cd-2c9f-4efc-ad17-306b8f09de57"),
                  ConversionFactorFromSIFormula = "Factors.Centi/Factors.Unit",
                  ConversionFactorFromSI = Factors.Centi/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/Unit, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per millimetre",
                  UnitLabel = "N/mm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("9375f700-72fb-4212-a51d-0f4500e7b13c"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Unit",
                  ConversionFactorFromSI = Factors.Milli/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Unit, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton per metre",
                  UnitLabel = "daN/m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("2566918f-f1b1-4ffb-906b-adb3680812e1"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deca",
                  ConversionFactorFromSI = 1.0/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deca, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton per 30 metre",
                  UnitLabel = "daN/30m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("20de7177-2099-4f86-89da-fdfa68bf67ed"),
                  ConversionFactorFromSIFormula = "3*Factors.Deca/Factors.Deca",
                  ConversionFactorFromSI = 3*Factors.Deca/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton per 30 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 3*Deca/Deca, i.e., 3"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton per 10 metre",
                  UnitLabel = "daN/10m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("4f30206a-b381-4a28-9e2d-fafc026e71d5"),
                  ConversionFactorFromSIFormula = "Factors.Deca/Factors.Deca",
                  ConversionFactorFromSI = Factors.Deca/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton per 10 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deca/Deca, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton per decimetre",
                  UnitLabel = "daN/dm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("cf20b9bb-aab1-4f1a-832c-1cfbe8ffc825"),
                  ConversionFactorFromSIFormula = "Factors.Deci/Factors.Deca",
                  ConversionFactorFromSI = Factors.Deci/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/Deca, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton per centimetre",
                  UnitLabel = "daN/cm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("47704d55-35cc-4bfc-9f93-7cf7f29c81ac"),
                  ConversionFactorFromSIFormula = "Factors.Centi/Factors.Deca",
                  ConversionFactorFromSI = Factors.Centi/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/Deca, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton per millimetre",
                  UnitLabel = "daN/mm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("1f418c90-f2e6-4bc8-8c06-f281e56ef6cc"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Deca",
                  ConversionFactorFromSI = Factors.Milli/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Deca, i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton per metre",
                  UnitLabel = "kN/m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("9ec7912e-9506-43ce-9089-80000d7ddd3f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton per 30 metre",
                  UnitLabel = "kN/30m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("b08fae49-fdc3-409e-8b0f-3349ab189dc9"),
                  ConversionFactorFromSIFormula = "3*Factors.Deca/Factors.Kilo",
                  ConversionFactorFromSI = 3*Factors.Deca/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton per 30 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 3*Deca/Kilo, i.e., 0.03"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton per 10 metre",
                  UnitLabel = "kN/10m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("f57cb3e9-4da5-4960-aff6-a27167276e4a"),
                  ConversionFactorFromSIFormula = "Factors.Deca/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Deca/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton per 10 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deca/Kilo, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton per decimetre",
                  UnitLabel = "kN/dm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("f3033c1b-1be8-4110-832a-4b60c31043e6"),
                  ConversionFactorFromSIFormula = "Factors.Deci/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Deci/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/Kilo, i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton per centimetre",
                  UnitLabel = "kN/cm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("4db740c5-df92-4f65-b0da-2119ad80cbfc"),
                  ConversionFactorFromSIFormula = "Factors.Centi/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Centi/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/Kilo, i.e., 1E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton per millimetre",
                  UnitLabel = "kN/mm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("14578d1b-6d43-441a-8f1b-aa77ab10a9bf"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Milli/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Kilo, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per foot",
                  UnitLabel = "lbf/ft",
                  SIUnitName = "newton per metre",
                  ID = new Guid("516e4b02-2f1a-49a7-8cd9-3fa4e28c8fce"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.PoundForce",
                  ConversionFactorFromSI = Factors.Foot/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/PoundForce, i.e., 0.06852176585679175"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per inch",
                  UnitLabel = "lbf/in",
                  SIUnitName = "newton per metre",
                  ID = new Guid("8a5772d2-1253-4269-958a-af9f779aecc6"),
                  ConversionFactorFromSIFormula = "Factors.Inch/Factors.PoundForce",
                  ConversionFactorFromSI = Factors.Inch/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/PoundForce, i.e., 0.0057101471547326465"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilopound per foot",
                  UnitLabel = "klbf/ft",
                  SIUnitName = "newton per metre",
                  ID = new Guid("bf63e80f-97df-48d1-afbf-c83415654e44"),
                  ConversionFactorFromSIFormula = "Factors.Foot/(Factors.Kilo*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Foot/(Factors.Kilo*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopound per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/(Kilo*PoundForce), i.e., 6.852176585679175E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilopound per inch",
                  UnitLabel = "klbf/in",
                  SIUnitName = "newton per metre",
                  ID = new Guid("fa6a4a38-b070-48d1-a747-be22ab0e57b6"),
                  ConversionFactorFromSIFormula = "Factors.Inch/(Factors.Kilo*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Inch/(Factors.Kilo*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopound per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/(Kilo*PoundForce), i.e., 5.7101471547326466E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per 30 foot",
                  UnitLabel = "lbf/30ft",
                  SIUnitName = "newton per metre",
                  ID = new Guid("0d0926be-19fa-4687-88d1-35f1acc58717"),
                  ConversionFactorFromSIFormula = "30.0*Factors.Foot/Factors.PoundForce",
                  ConversionFactorFromSI = 30.0*Factors.Foot/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 30.0*Foot/PoundForce, i.e., 2.0556529757037523"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per 100 foot",
                  UnitLabel = "lbf/100ft",
                  SIUnitName = "newton per metre",
                  ID = new Guid("dcaa5f41-da2f-49d2-be41-80fb6f0a06ec"),
                  ConversionFactorFromSIFormula = "100.0*Factors.Foot/Factors.PoundForce",
                  ConversionFactorFromSI = 100.0*Factors.Foot/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 100.0*Foot/PoundForce, i.e., 6.852176585679175"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilopound per 30 foot",
                  UnitLabel = "klbf/30ft",
                  SIUnitName = "newton per metre",
                  ID = new Guid("27a355cf-36ae-458d-acbd-2a5ad931bbab"),
                  ConversionFactorFromSIFormula = "30.0*Factors.Foot/(Factors.Kilo*Factors.PoundForce)",
                  ConversionFactorFromSI = 30.0*Factors.Foot/(Factors.Kilo*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopound per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 30.0*Foot/(Kilo*PoundForce), i.e., 0.0020556529757037524"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilopound per 100 foot",
                  UnitLabel = "klbf/100ft",
                  SIUnitName = "newton per metre",
                  ID = new Guid("0d5c841e-b259-4fdf-93d7-e39cca391adb"),
                  ConversionFactorFromSIFormula = "100.0*Factors.Foot/(Factors.Kilo*Factors.PoundForce)",
                  ConversionFactorFromSI = 100.0*Factors.Foot/(Factors.Kilo*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopound per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 100.0*Foot/(Kilo*PoundForce), i.e., 0.006852176585679175"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ForceQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "newton",
                  UnitLabel = "N",
                  SIUnitName = "newton",
                  ID = new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "decanewton",
                  UnitLabel = "daN",
                  SIUnitName = "newton",
                  ID = new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deca)",
                  ConversionFactorFromSI = 1.0/(Factors.Deca),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Deca), i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton",
                  UnitLabel = "kN",
                  SIUnitName = "newton",
                  ID = new Guid("e30d6f94-7887-4746-8d4f-eb720239b702"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilodecanewton",
                  UnitLabel = "kdaN",
                  SIUnitName = "newton",
                  ID = new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.Deca)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.Deca),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilodecanewton"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*Deca), i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram force",
                  UnitLabel = "kgf",
                  SIUnitName = "newton",
                  ID = new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad"),
                  ConversionFactorFromSIFormula = "1.0/Factors.KilogramForce",
                  ConversionFactorFromSI = 1.0/Factors.KilogramForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram force"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/KilogramForce, i.e., 0.10197162129779283"
 + Environment.NewLine + "and"
 + Environment.NewLine + "KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound force",
                  UnitLabel = "lbf",
                  SIUnitName = "newton",
                  ID = new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa"),
                  ConversionFactorFromSIFormula = "1.0/Factors.PoundForce",
                  ConversionFactorFromSI = 1.0/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound force"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/PoundForce, i.e., 0.2248089430997105"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilopound force",
                  UnitLabel = "klbf",
                  SIUnitName = "newton",
                  ID = new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.PoundForce)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopound force"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*PoundForce), i.e., 0.0002248089430997105"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class FrequencyQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "hertz",
                  UnitLabel = "Hz",
                  SIUnitName = "hertz",
                  ID = new Guid("7c572c06-0699-4187-9d0c-397f479fe93d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal second",
                  UnitLabel = "1/s",
                  SIUnitName = "hertz",
                  ID = new Guid("39240f8f-8c82-4026-9db7-f72ec60cb4c9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilohertz",
                  UnitLabel = "kHz",
                  SIUnitName = "hertz",
                  ID = new Guid("acf483c1-5d7a-4914-afa2-de7abed9be3e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilohertz"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megahertz",
                  UnitLabel = "MHz",
                  SIUnitName = "hertz",
                  ID = new Guid("6dea9f29-d4f4-49a7-86fe-0205d4bab45e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megahertz"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigahertz",
                  UnitLabel = "GHz",
                  SIUnitName = "hertz",
                  ID = new Guid("655ee4f9-1782-4ec0-894a-afff9b75cac7"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigahertz"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "terahertz",
                  UnitLabel = "THz",
                  SIUnitName = "hertz",
                  ID = new Guid("9ca52ae4-2fc5-4e60-b774-79c73442de13"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Tera",
                  ConversionFactorFromSI = 1.0/Factors.Tera,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in terahertz"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Tera, i.e., 1E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Tera = 1e12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "rpm",
                  UnitLabel = "rpm",
                  SIUnitName = "hertz",
                  ID = new Guid("30880b5f-803d-412e-9736-62dca3ba5bbd"),
                  ConversionFactorFromSIFormula = "Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in rpm"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "spm",
                  UnitLabel = "spm",
                  SIUnitName = "hertz",
                  ID = new Guid("426b000b-235f-41d5-8806-b2e47fbfb53b"),
                  ConversionFactorFromSIFormula = "Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in spm"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "rotation per second",
                  UnitLabel = "rps",
                  SIUnitName = "hertz",
                  ID = new Guid("6e0ff63e-ef67-440d-a0f7-a17ff73cfff2"),
                  ConversionFactorFromSIFormula = "Factors.Unit",
                  ConversionFactorFromSI = Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in rotation per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "stroke per second",
                  UnitLabel = "sps",
                  SIUnitName = "hertz",
                  ID = new Guid("fe114eaf-117a-480e-9dbc-2db244b6d210"),
                  ConversionFactorFromSIFormula = "Factors.Unit",
                  ConversionFactorFromSI = Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in stroke per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "stroke per hour",
                  UnitLabel = "sph",
                  SIUnitName = "hertz",
                  ID = new Guid("b0f63a0c-9a53-4bdc-9166-03eb4254d3d8"),
                  ConversionFactorFromSIFormula = "Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in stroke per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "rotation per hour",
                  UnitLabel = "rph",
                  SIUnitName = "hertz",
                  ID = new Guid("cdc5dd34-dc2d-4bd8-85ac-13f6d71ea188"),
                  ConversionFactorFromSIFormula = "Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in rotation per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "shock per second",
                  UnitLabel = "sps",
                  SIUnitName = "hertz",
                  ID = new Guid("b5318133-64e9-43c7-b7bf-3c86140fe7aa"),
                  ConversionFactorFromSIFormula = "Factors.Unit",
                  ConversionFactorFromSI = Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in shock per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "shock per minute",
                  UnitLabel = "spm",
                  SIUnitName = "hertz",
                  ID = new Guid("6ccbee46-cb8a-4777-b1d2-e88eedd24f73"),
                  ConversionFactorFromSIFormula = "Factors.Minute",
                  ConversionFactorFromSI = Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in shock per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "shock per hour",
                  UnitLabel = "spm",
                  SIUnitName = "hertz",
                  ID = new Guid("0c0d4ecb-ee11-4b57-9bc7-70860637232e"),
                  ConversionFactorFromSIFormula = "Factors.Hour",
                  ConversionFactorFromSI = Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in shock per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class FrequencyRateOfChangeQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "hertz per second",
                  UnitLabel = "Hz/s",
                  SIUnitName = "hertz per second",
                  ID = new Guid("4d7e4b49-df76-4259-a96c-8c1250d5ecdd"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "kilo hertz per second",
                  UnitLabel = "kHz/s",
                  SIUnitName = "hertz per second",
                  ID = new Guid("e197e7ca-93f7-4348-9508-74e61ce97f94"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo hertz per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mega hertz per second",
                  UnitLabel = "MHz/s",
                  SIUnitName = "hertz per second",
                  ID = new Guid("8c9671f4-54b6-40a0-94c1-5cfb25378f88"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mega hertz per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "giga hertz per second",
                  UnitLabel = "GHz/s",
                  SIUnitName = "hertz per second",
                  ID = new Guid("46ad2062-982c-461f-95d8-ddd888e5d4f8"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in giga hertz per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hertz per minute",
                  UnitLabel = "Hz/min",
                  SIUnitName = "hertz per second",
                  ID = new Guid("af3fcbbf-4fc8-4b5d-b555-33340d3c2f0f"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Unit",
                  ConversionFactorFromSI = Factors.Minute/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hertz per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Unit, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo hertz per minute",
                  UnitLabel = "kHz/min",
                  SIUnitName = "hertz per second",
                  ID = new Guid("0fabfb82-03fb-4855-aaea-578e36c9c7cf"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Minute/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo hertz per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Kilo, i.e., 0.06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mega hertz per minute",
                  UnitLabel = "MHz/min",
                  SIUnitName = "hertz per second",
                  ID = new Guid("97c4e6e3-a8b3-4aa6-a742-1900a239e282"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Mega",
                  ConversionFactorFromSI = Factors.Minute/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mega hertz per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Mega, i.e., 6E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "giga hertz per minute",
                  UnitLabel = "GHz/min",
                  SIUnitName = "hertz per second",
                  ID = new Guid("8d8d140d-00cd-4e80-aaa5-8d2d5ddcbc73"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Giga",
                  ConversionFactorFromSI = Factors.Minute/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in giga hertz per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Giga, i.e., 6E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hertz per hour",
                  UnitLabel = "Hz/h",
                  SIUnitName = "hertz per second",
                  ID = new Guid("424100d5-ab81-4061-9429-74a9e3638453"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Unit",
                  ConversionFactorFromSI = Factors.Hour/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hertz per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Unit, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo hertz per hour",
                  UnitLabel = "kHz/h",
                  SIUnitName = "hertz per second",
                  ID = new Guid("0963dc43-168a-483c-be3f-3c9054b0c692"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Hour/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo hertz per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Kilo, i.e., 3.6"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mega hertz per hour",
                  UnitLabel = "MHz/h",
                  SIUnitName = "hertz per second",
                  ID = new Guid("a1b30880-ba44-4675-b808-6d93ba8aa8d2"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Mega",
                  ConversionFactorFromSI = Factors.Hour/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mega hertz per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Mega, i.e., 0.0036"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "giga hertz per hour",
                  UnitLabel = "GHz/h",
                  SIUnitName = "hertz per second",
                  ID = new Guid("cd42ca67-9d8b-411c-bcce-e9e5ce6d1259"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Giga",
                  ConversionFactorFromSI = Factors.Hour/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in giga hertz per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Giga, i.e., 3.6E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hertz per day",
                  UnitLabel = "Hz/d",
                  SIUnitName = "hertz per second",
                  ID = new Guid("fe28723d-23e5-45f3-b286-50705746d643"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Unit",
                  ConversionFactorFromSI = Factors.Day/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hertz per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Unit, i.e., 86400"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo hertz per day",
                  UnitLabel = "kHz/d",
                  SIUnitName = "hertz per second",
                  ID = new Guid("0dc10fed-83a5-4570-a997-f2422d71d7fd"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Day/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo hertz per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Kilo, i.e., 86.4"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mega hertz per day",
                  UnitLabel = "MHz/d",
                  SIUnitName = "hertz per second",
                  ID = new Guid("c5743df5-a0be-41d2-99a1-b1f760940007"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Mega",
                  ConversionFactorFromSI = Factors.Day/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mega hertz per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Mega, i.e., 0.0864"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "giga hertz per day",
                  UnitLabel = "GHz/d",
                  SIUnitName = "hertz per second",
                  ID = new Guid("56e88229-8197-4ca2-aa69-e4100234d344"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Giga",
                  ConversionFactorFromSI = Factors.Day/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in giga hertz per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Giga, i.e., 8.64E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hertz per year",
                  UnitLabel = "Hz/y",
                  SIUnitName = "hertz per second",
                  ID = new Guid("1195a495-ea6e-4b5a-92b6-6ef0d2ca23d5"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian/Factors.Unit",
                  ConversionFactorFromSI = Factors.YearJulian/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hertz per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian/Unit, i.e., 31557600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo hertz per year",
                  UnitLabel = "kHz/y",
                  SIUnitName = "hertz per second",
                  ID = new Guid("2e2a0d0f-5658-4ba2-8799-53bb06f197e7"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian/Factors.Kilo",
                  ConversionFactorFromSI = Factors.YearJulian/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo hertz per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian/Kilo, i.e., 31557.6"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mega hertz per year",
                  UnitLabel = "MHz/y",
                  SIUnitName = "hertz per second",
                  ID = new Guid("665c1c2a-57f6-4696-8b7b-524f8ad6084f"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian/Factors.Mega",
                  ConversionFactorFromSI = Factors.YearJulian/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mega hertz per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian/Mega, i.e., 31.5576"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "giga hertz per year",
                  UnitLabel = "GHz/y",
                  SIUnitName = "hertz per second",
                  ID = new Guid("2c756b88-bbed-4650-8307-86bc7513caee"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian/Factors.Giga",
                  ConversionFactorFromSI = Factors.YearJulian/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in giga hertz per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian/Giga, i.e., 0.0315576"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "rpm per second",
                  UnitLabel = "rpm/s",
                  SIUnitName = "hertz per second",
                  ID = new Guid("762b5d58-a1ba-40cb-8776-2004613d15fb"),
                }
              , new UnitChoice
                {
                  UnitName = "spm per second",
                  UnitLabel = "spm/s",
                  SIUnitName = "hertz per second",
                  ID = new Guid("abcb24f7-c949-41dd-bf7d-acc23dc7e5e3"),
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class HeatTransferCoefficientQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "watt per square metre per kelvin",
                  UnitLabel = "W/m²/K",
                  SIUnitName = "watt per square metre per kelvin",
                  ID = new Guid("e1737353-c10b-46cd-aa4e-9c90afb2f01e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per hour per square foot per degree fahrenheit",
                  UnitLabel = "BTU/h/ft²/°F",
                  SIUnitName = "watt per square metre per kelvin",
                  ID = new Guid("6963db25-2bd9-4017-9c83-cc578a11abbf"),
                  ConversionFactorFromSIFormula = "Factors.Hour * Factors.Foot*Factors.Foot * Factors.FahrenheitSlope / Factors.BTU",
                  ConversionFactorFromSI = Factors.Hour * Factors.Foot*Factors.Foot * Factors.FahrenheitSlope / Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per hour per square foot per degree fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour * Foot*Foot * FahrenheitSlope / BTU, i.e., 0.17622808365343573"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ImageScaleQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "dot per metre",
                  UnitLabel = "dpm",
                  SIUnitName = "dot per metre",
                  ID = new Guid("acc723b8-083c-49f3-a208-184d2da3347d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "dot per inch",
                  UnitLabel = "dpi",
                  SIUnitName = "dot per metre",
                  ID = new Guid("e042b571-b7d0-477d-abf6-8b8998e5ba6c"),
                  ConversionFactorFromSIFormula = "Factors.Inch",
                  ConversionFactorFromSI = Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in dot per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch, i.e., 0.0254"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "dot per millimetre",
                  UnitLabel = "dpmm",
                  SIUnitName = "dot per metre",
                  ID = new Guid("6d4d5f26-8812-4002-a2bf-27ec7871c1f4"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in dot per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "dot per micrometre",
                  UnitLabel = "dpµm",
                  SIUnitName = "dot per metre",
                  ID = new Guid("76e21d1d-54f5-4bbb-81c6-1b92b8b30bfe"),
                  ConversionFactorFromSIFormula = "Factors.Micro",
                  ConversionFactorFromSI = Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in dot per micrometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Micro, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class InterfacialTensionQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "newton per metre",
                  UnitLabel = "N/m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("7ee9eca6-2704-442a-bd50-c8a0826da932"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "millinewton per metre",
                  UnitLabel = "mN/m",
                  SIUnitName = "newton per metre",
                  ID = new Guid("7b1b363c-cbb0-4499-9d7c-762adc43e690"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millinewton per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "dyne per centimetre",
                  UnitLabel = "dyne/cm",
                  SIUnitName = "newton per metre",
                  ID = new Guid("a3c12fb9-6936-44bf-ad66-f4139163d11b"),
                  ConversionFactorFromSIFormula = "Factors.Centi/Factors.Dyne",
                  ConversionFactorFromSI = Factors.Centi/Factors.Dyne,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in dyne per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/Dyne, i.e., 999.9999999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Dyne = 1e-5 reference: https://en.wikipedia.org/wiki/Dyne"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per second squared",
                  UnitLabel = "lb/s²",
                  SIUnitName = "newton per metre",
                  ID = new Guid("03db472b-b8e8-4ad0-b2b1-b8970686210c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pound",
                  ConversionFactorFromSI = 1.0/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per second squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pound, i.e., 2.2046226218487757"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class LengthQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "metre",
                  UnitLabel = "m",
                  SIUnitName = "metre",
                  ID = new Guid("cc442e11-bb28-4e51-9074-87df66050d8a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "decimetre",
                  UnitLabel = "dm",
                  SIUnitName = "metre",
                  ID = new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deci",
                  ConversionFactorFromSI = 1.0/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre",
                  UnitLabel = "cm",
                  SIUnitName = "metre",
                  ID = new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre",
                  UnitLabel = "mm",
                  SIUnitName = "metre",
                  ID = new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "micrometre",
                  UnitLabel = "µm",
                  SIUnitName = "metre",
                  ID = new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in micrometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanometre",
                  UnitLabel = "nm",
                  SIUnitName = "metre",
                  ID = new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "ångstrøm",
                  UnitLabel = "Å",
                  SIUnitName = "metre",
                  ID = new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Angstrom",
                  ConversionFactorFromSI = 1.0/Factors.Angstrom,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in ångstrøm"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Angstrom, i.e., 10000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Angstrom = 1e-10"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "picometre",
                  UnitLabel = "pm",
                  SIUnitName = "metre",
                  ID = new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in picometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pico, i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decametre",
                  UnitLabel = "dam",
                  SIUnitName = "metre",
                  ID = new Guid("0ff9e118-e7d5-4ace-b140-eb3383812b21"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deca",
                  ConversionFactorFromSI = 1.0/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decametre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deca, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hectometre",
                  UnitLabel = "hm",
                  SIUnitName = "metre",
                  ID = new Guid("cb5c81a3-b9da-42b5-a2ea-0509df445d01"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Hecto",
                  ConversionFactorFromSI = 1.0/Factors.Hecto,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hectometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Hecto, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilometre",
                  UnitLabel = "km",
                  SIUnitName = "metre",
                  ID = new Guid("93aee1b8-653d-4841-b948-10460cb84334"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "astronomical unit",
                  UnitLabel = "au",
                  SIUnitName = "metre",
                  ID = new Guid("0471d74c-cc44-45bd-be0a-aaad6c05f0d0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.AstronomicalUnit",
                  ConversionFactorFromSI = 1.0/Factors.AstronomicalUnit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in astronomical unit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/AstronomicalUnit, i.e., 6.684587122268445E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "AstronomicalUnit = 149597870700.0 reference: https://www.iau.org/static/resolutions/IAU2012_English.pdf"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "light year",
                  UnitLabel = "ly",
                  SIUnitName = "metre",
                  ID = new Guid("fc43d439-576f-430c-855e-60b28f70856e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.LightYear",
                  ConversionFactorFromSI = 1.0/Factors.LightYear,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in light year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/LightYear, i.e., 1.0570008340246154E-16"
 + Environment.NewLine + "and"
 + Environment.NewLine + "LightYear = 9460730472580800.0 reference: https://www.iau.org/public/themes/measuring/"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "parsec",
                  UnitLabel = "pc",
                  SIUnitName = "metre",
                  ID = new Guid("0565c7e8-11cb-48de-8d7a-d58c89955d0f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Parsec",
                  ConversionFactorFromSI = 1.0/Factors.Parsec,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in parsec"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Parsec, i.e., 3.240779289444365E-17"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Parsec = (60.0*60.0*180.0 / System.Math.PI) * AstronomicalUnit reference: https://imagine.gsfc.nasa.gov/features/cosmic/milkyway_info.html"
 + Environment.NewLine + "AstronomicalUnit = 149597870700.0 reference: https://www.iau.org/static/resolutions/IAU2012_English.pdf"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot",
                  UnitLabel = "ft",
                  SIUnitName = "metre",
                  ID = new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Foot",
                  ConversionFactorFromSI = 1.0/Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Foot, i.e., 3.280839895013124"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US survey foot",
                  UnitLabel = "ft",
                  SIUnitName = "metre",
                  ID = new Guid("eaf5909f-c68e-4346-9517-1dafad48b161"),
                  ConversionFactorFromSIFormula = "1.0/Factors.USSurveyFoot",
                  ConversionFactorFromSI = 1.0/Factors.USSurveyFoot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US survey foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/USSurveyFoot, i.e., 3.2808333333333337"
 + Environment.NewLine + "and"
 + Environment.NewLine + "USSurveyFoot = 1200.0 / 3937.0 reference: https://www.nist.gov/pml/us-surveyfoot"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch",
                  UnitLabel = "in",
                  SIUnitName = "metre",
                  ID = new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Inch",
                  ConversionFactorFromSI = 1.0/Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Inch, i.e., 39.37007874015748"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "yard",
                  UnitLabel = "yd",
                  SIUnitName = "metre",
                  ID = new Guid("7b9156e4-7cce-41cf-a251-95412f4d91a5"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Yard",
                  ConversionFactorFromSI = 1.0/Factors.Yard,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Yard, i.e., 1.093613298337708"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "fathom",
                  UnitLabel = "fathom",
                  SIUnitName = "metre",
                  ID = new Guid("6be602af-ea19-41cc-af7f-8263564c3c3b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Fathom",
                  ConversionFactorFromSI = 1.0/Factors.Fathom,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in fathom"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Fathom, i.e., 0.546806649168854"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Fathom = 6.0 * Foot reference: https://www.britannica.com/science/fathom"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "surveyor's chain",
                  UnitLabel = "chain",
                  SIUnitName = "metre",
                  ID = new Guid("f101708b-ab63-4f21-ac87-4b5b3615eb30"),
                  ConversionFactorFromSIFormula = "1.0/Factors.SurveyorChain",
                  ConversionFactorFromSI = 1.0/Factors.SurveyorChain,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in surveyor's chain"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/SurveyorChain, i.e., 0.04970969537898672"
 + Environment.NewLine + "and"
 + Environment.NewLine + "SurveyorChain = 22.0 * Yard reference: https://www.britannica.com/technology/surveyors-chain"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mile",
                  UnitLabel = "mi",
                  SIUnitName = "metre",
                  ID = new Guid("95736fd3-878b-4d93-9a78-ee6f20619628"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mile",
                  ConversionFactorFromSI = 1.0/Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mile, i.e., 0.000621371192237334"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "international nautical mile",
                  UnitLabel = "nmi",
                  SIUnitName = "metre",
                  ID = new Guid("4c297035-e0cf-4bfe-aa63-d835170e8e25"),
                  ConversionFactorFromSIFormula = "1.0/Factors.InternationalNauticalMile",
                  ConversionFactorFromSI = 1.0/Factors.InternationalNauticalMile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in international nautical mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/InternationalNauticalMile, i.e., 0.0005399568034557236"
 + Environment.NewLine + "and"
 + Environment.NewLine + "InternationalNauticalMile = 1852.0 reference: https://www.merriam-webster.com/dictionary/nautical%20mile"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK nautical mile",
                  UnitLabel = "UK nmi",
                  SIUnitName = "metre",
                  ID = new Guid("3b7a50d6-dc58-4cd7-9a5b-96dba59eceaa"),
                  ConversionFactorFromSIFormula = "1.0/Factors.UKNauticalMile",
                  ConversionFactorFromSI = 1.0/Factors.UKNauticalMile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK nautical mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/UKNauticalMile, i.e., 0.0005396118248376849"
 + Environment.NewLine + "and"
 + Environment.NewLine + "UKNauticalMile = 6080 * Foot reference: https://www.rmg.co.uk/stories/topics/nautical-mile"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "scandinavian mile",
                  UnitLabel = "mil",
                  SIUnitName = "metre",
                  ID = new Guid("22e6763c-4105-4a4c-9dfe-044256a107d1"),
                  ConversionFactorFromSIFormula = "1.0/Factors.ScandinavianMile",
                  ConversionFactorFromSI = 1.0/Factors.ScandinavianMile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in scandinavian mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/ScandinavianMile, i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "ScandinavianMile = 10000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per 32",
                  UnitLabel = "in/32",
                  SIUnitName = "metre",
                  ID = new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.InchPer32",
                  ConversionFactorFromSI = 1.0/Factors.InchPer32,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per 32"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/InchPer32, i.e., 1259.8425196850394"
 + Environment.NewLine + "and"
 + Environment.NewLine + "InchPer32 = Inch / 32.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mil",
                  UnitLabel = "mil",
                  SIUnitName = "metre",
                  ID = new Guid("648502a7-47e0-42dc-aacc-2e1789b0f1ce"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mil",
                  ConversionFactorFromSI = 1.0/Factors.Mil,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mil"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mil, i.e., 39370.07874015748"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mil = 0.001 * Inch reference: https://en.wikipedia.org/wiki/Thousandth_of_an_inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "thou",
                  UnitLabel = "thou",
                  SIUnitName = "metre",
                  ID = new Guid("2ce1b2d1-8157-4ad5-ae85-5d6c634f5c68"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Thou",
                  ConversionFactorFromSI = 1.0/Factors.Thou,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in thou"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Thou, i.e., 39370.07874015748"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Thou = Mil"
 + Environment.NewLine + "Mil = 0.001 * Inch reference: https://en.wikipedia.org/wiki/Thousandth_of_an_inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hand",
                  UnitLabel = "hand",
                  SIUnitName = "metre",
                  ID = new Guid("608205f3-8c52-40f2-9796-a586d1cd62da"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Hand",
                  ConversionFactorFromSI = 1.0/Factors.Hand,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hand"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Hand, i.e., 9.84251968503937"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hand = 4.0 * Inch reference: https://en.wikipedia.org/wiki/Hand_(unit)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "furlong",
                  UnitLabel = "furlong",
                  SIUnitName = "metre",
                  ID = new Guid("7ce130d1-8147-409f-99b3-bf22b0aae4cc"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Furlong",
                  ConversionFactorFromSI = 1.0/Factors.Furlong,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in furlong"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Furlong, i.e., 0.004970969537898672"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class LuminousIntensityQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "candela",
                  UnitLabel = "cd",
                  SIUnitName = "candela",
                  ID = new Guid("28411995-11f2-4967-92ed-5077237f17e1"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "lumen per steradian",
                  UnitLabel = "lm/st",
                  SIUnitName = "candela",
                  ID = new Guid("5683bf23-cd97-4141-9bf4-62a43750ceda"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in lumen per steradian"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millicandela",
                  UnitLabel = "mcd",
                  SIUnitName = "candela",
                  ID = new Guid("b722e2e1-bcc4-4d6c-ad47-dfd24bb66543"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millicandela"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocandela",
                  UnitLabel = "kcd",
                  SIUnitName = "candela",
                  ID = new Guid("f1159794-14ab-49bb-80de-0164c8172c1f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocandela"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hefnerkerze",
                  UnitLabel = "hefnerkerze",
                  SIUnitName = "candela",
                  ID = new Guid("8059d89c-1ed5-43d3-a9dc-a11de6cd0f8d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Hefnerkerze",
                  ConversionFactorFromSI = 1.0/Factors.Hefnerkerze,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hefnerkerze"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Hefnerkerze, i.e., 1.0869565217391304"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hefnerkerze = 0.92 reference: https://en.wikipedia.org/wiki/Hefner_lamp"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "international candle",
                  UnitLabel = "int. candle",
                  SIUnitName = "candela",
                  ID = new Guid("fa25c6d3-c832-42a1-8490-c31131378ee2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.InternationalCandle",
                  ConversionFactorFromSI = 1.0/Factors.InternationalCandle,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in international candle"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/InternationalCandle, i.e., 0.9803921568627451"
 + Environment.NewLine + "and"
 + Environment.NewLine + "InternationalCandle = 1.02"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decimal candle",
                  UnitLabel = "dec. candle",
                  SIUnitName = "candela",
                  ID = new Guid("a07a3c15-4679-4a6a-a79b-64fe27fa5799"),
                  ConversionFactorFromSIFormula = "1.0 / Factors.Unit",
                  ConversionFactorFromSI = 1.0 / Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimal candle"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0 / Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "berliner lichteinheit",
                  UnitLabel = "berliner lichteinheit",
                  SIUnitName = "candela",
                  ID = new Guid("ffd07aaa-486b-495d-bb63-a93d122c35e4"),
                  ConversionFactorFromSIFormula = "1.0/ Factors.Hefnerkerze",
                  ConversionFactorFromSI = 1.0/ Factors.Hefnerkerze,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in berliner lichteinheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/ Hefnerkerze, i.e., 1.0869565217391304"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hefnerkerze = 0.92 reference: https://en.wikipedia.org/wiki/Hefner_lamp"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "DVWG candle",
                  UnitLabel = "DVWG candle",
                  SIUnitName = "candela",
                  ID = new Guid("b2fa4a9a-4c5d-4a31-8002-a7bc9e857af5"),
                  ConversionFactorFromSIFormula = "1.0/Factors.DVGWCandle",
                  ConversionFactorFromSI = 1.0/Factors.DVGWCandle,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in DVWG candle"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/DVGWCandle, i.e., 0.9354186934071691"
 + Environment.NewLine + "and"
 + Environment.NewLine + "DVGWCandle = 1.162 * Hefnerkerze reference: https://fr.wikipedia.org/wiki/Bougie_(unit%C3%A9)"
 + Environment.NewLine + "Hefnerkerze = 0.92 reference: https://en.wikipedia.org/wiki/Hefner_lamp"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "violle",
                  UnitLabel = "violle",
                  SIUnitName = "candela",
                  ID = new Guid("1e53e27a-3e4f-4b68-833f-c7a05fdf094e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Violle",
                  ConversionFactorFromSI = 1.0/Factors.Violle,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in violle"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Violle, i.e., 0.016666666666666666"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Violle = 60.0 reference: https://en.wikipedia.org/wiki/Jules_Violle"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "carcel",
                  UnitLabel = "carcel",
                  SIUnitName = "candela",
                  ID = new Guid("70b8902f-8a35-4398-b4ba-1e2b4858264f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Carcel",
                  ConversionFactorFromSI = 1.0/Factors.Carcel,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in carcel"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Carcel, i.e., 0.1026694045174538"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Carcel = 9.74 reference: https://en.wikipedia.org/wiki/Carcel"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MagneticFluxDensityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "tesla",
                  UnitLabel = "T",
                  SIUnitName = "tesla",
                  ID = new Guid("33c3b59d-9876-4918-9f31-f22de88d7bde"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "gauss",
                  UnitLabel = "G",
                  SIUnitName = "tesla",
                  ID = new Guid("c09cd87d-8a84-45d0-88d3-20bb5cc48559"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Gauss",
                  ConversionFactorFromSI = 1.0/Factors.Gauss,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gauss"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Gauss, i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "milligauss",
                  UnitLabel = "mG",
                  SIUnitName = "tesla",
                  ID = new Guid("41ace729-a2ff-4047-adc3-375829de64c6"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Gauss)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Gauss),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in milligauss"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Milli*Gauss), i.e., 10000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millitesla",
                  UnitLabel = "mT",
                  SIUnitName = "tesla",
                  ID = new Guid("9b6d864e-6775-4668-a59d-e1ab432f8960"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millitesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microtesla",
                  UnitLabel = "µT",
                  SIUnitName = "tesla",
                  ID = new Guid("c6b30197-be6b-41b7-803d-a8de61338612"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microtesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanotesla",
                  UnitLabel = "nT",
                  SIUnitName = "tesla",
                  ID = new Guid("9bef9def-8cd3-4f7b-b991-290d3441b3d4"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanotesla"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "maxwell per square centimetre",
                  UnitLabel = "Mx/cm²",
                  SIUnitName = "tesla",
                  ID = new Guid("d1b202cb-87c6-417a-947c-5247e5cdfe82"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi/Factors.Unit",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in maxwell per square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi/Unit, i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "weber per square metre",
                  UnitLabel = "Wb/m²",
                  SIUnitName = "tesla",
                  ID = new Guid("fefe997a-f3a6-4663-a1de-32889ee0cf15"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in weber per square metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MagneticFluxQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "weber",
                  UnitLabel = "Wb",
                  SIUnitName = "weber",
                  ID = new Guid("d790689d-e7dd-43d8-a3c0-c17ccc8073e5"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "milliweber",
                  UnitLabel = "mWb",
                  SIUnitName = "weber",
                  ID = new Guid("94f03fc7-b0bb-4356-8787-c9e33f6559d2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in milliweber"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microweber",
                  UnitLabel = "µWb",
                  SIUnitName = "weber",
                  ID = new Guid("200b9de7-0635-40eb-8ebd-9cef7c01ac10"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microweber"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "volt second",
                  UnitLabel = "V•s",
                  SIUnitName = "weber",
                  ID = new Guid("430305c3-d672-4d68-9b16-d0517243a870"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in volt second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "unit pole",
                  UnitLabel = "unit pole",
                  SIUnitName = "weber",
                  ID = new Guid("3bac78d4-5601-4cb2-bea1-01d952597a4d"),
                  ConversionFactorFromSIFormula = "1e16/(4.0*System.Math.PI)",
                  ConversionFactorFromSI = 1e16/(4.0*System.Math.PI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in unit pole"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1e16/(4.0*PI), i.e., 795774715459476.8"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megaline",
                  UnitLabel = "megaline",
                  SIUnitName = "weber",
                  ID = new Guid("cca39e15-ee2e-4b8f-8843-527b329f3e81"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega*Factors.Line)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega*Factors.Line),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megaline"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega*Line), i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Line = 1e-8 reference: https://en.wikipedia.org/wiki/Maxwell_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kiloline",
                  UnitLabel = "kiloline",
                  SIUnitName = "weber",
                  ID = new Guid("85862477-e913-4bcf-9d24-8248ec975d43"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.Line)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.Line),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kiloline"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*Line), i.e., 99999.99999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Line = 1e-8 reference: https://en.wikipedia.org/wiki/Maxwell_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "line",
                  UnitLabel = "line",
                  SIUnitName = "weber",
                  ID = new Guid("40d608dd-b19f-4489-aac3-a3a6b7a55413"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Line",
                  ConversionFactorFromSI = 1.0/Factors.Line,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in line"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Line, i.e., 100000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Line = 1e-8 reference: https://en.wikipedia.org/wiki/Maxwell_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "maxwell",
                  UnitLabel = "Mx",
                  SIUnitName = "weber",
                  ID = new Guid("8c1fcd01-4a3d-469a-a019-d3b35f7ef8b5"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Maxwell",
                  ConversionFactorFromSI = 1.0/Factors.Maxwell,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in maxwell"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Maxwell, i.e., 100000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Maxwell = 1e-8 reference: https://en.wikipedia.org/wiki/Maxwell_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "tesla square metre",
                  UnitLabel = "T•m²",
                  SIUnitName = "weber",
                  ID = new Guid("f6da9f32-0738-4014-aac6-fdc5935fd436"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in tesla square metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "tesla square centimetre",
                  UnitLabel = "T•cm²",
                  SIUnitName = "weber",
                  ID = new Guid("312b97ea-6167-47b5-a046-c6c202fb7eb4"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Unit *Factors.Centi*Factors.Centi)",
                  ConversionFactorFromSI = 1.0/(Factors.Unit *Factors.Centi*Factors.Centi),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in tesla square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Unit *Centi*Centi), i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gauss square centimetre",
                  UnitLabel = "G•cm²",
                  SIUnitName = "weber",
                  ID = new Guid("a0dc1e92-7e84-401f-bca2-a6eb618ef604"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Gauss *Factors.Centi*Factors.Centi)",
                  ConversionFactorFromSI = 1.0/(Factors.Gauss *Factors.Centi*Factors.Centi),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gauss square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Gauss *Centi*Centi), i.e., 99999999.99999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "magnetic flux quantum",
                  UnitLabel = "mag flux quant",
                  SIUnitName = "weber",
                  ID = new Guid("f768bd79-1119-401c-b0df-39a5207273e0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.MagneticFluxQuantum",
                  ConversionFactorFromSI = 1.0/Factors.MagneticFluxQuantum,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in magnetic flux quantum"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/MagneticFluxQuantum, i.e., 483597848416983.56"
 + Environment.NewLine + "and"
 + Environment.NewLine + "MagneticFluxQuantum = PlanckConstant / (2.0*ElectronCharge) reference: https://en.wikipedia.org/wiki/Magnetic_flux_quantum"
 + Environment.NewLine + "PlanckConstant = 6.62607015e-34 reference: https://en.wikipedia.org/wiki/Planck_constant"
 + Environment.NewLine + "ElectronCharge = 1.602176634e-19 reference: https://en.wikipedia.org/wiki/Elementary_charge"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kilogram per metre",
                  UnitLabel = "kg/m",
                  SIUnitName = "kilogram per metre",
                  ID = new Guid("c8b4a6ea-29bf-4e5a-b7ce-9142cefc0752"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "pound per foot",
                  UnitLabel = "lb/ft",
                  SIUnitName = "kilogram per metre",
                  ID = new Guid("6fdf4cb6-a43b-482d-9bc8-d4ad49770f9e"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.Pound",
                  ConversionFactorFromSI = Factors.Foot/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/Pound, i.e., 0.6719689751395067"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram per metre",
                  UnitLabel = "g/m",
                  SIUnitName = "kilogram per metre",
                  ID = new Guid("0cea1e32-9adb-4882-9070-d027cd0eef8e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassRateQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kilogram per second",
                  UnitLabel = "kg/s",
                  SIUnitName = "kilogram per second",
                  ID = new Guid("a2daceb8-7705-4c97-9945-b354ea1ff78d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "kilogram per minute",
                  UnitLabel = "kg/min",
                  SIUnitName = "kilogram per second",
                  ID = new Guid("b776ae6f-5b86-462c-b815-2608d7e98192"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Unit",
                  ConversionFactorFromSI = Factors.Minute/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Unit, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram per hour",
                  UnitLabel = "kg/h",
                  SIUnitName = "kilogram per second",
                  ID = new Guid("736e4fcd-434f-4442-b025-a480a1532543"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Unit",
                  ConversionFactorFromSI = Factors.Hour/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Unit, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram per year",
                  UnitLabel = "kg/y",
                  SIUnitName = "kilogram per second",
                  ID = new Guid("0ce50feb-a755-4a62-a50b-4af417bc2702"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian/Factors.Unit",
                  ConversionFactorFromSI = Factors.YearJulian/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian/Unit, i.e., 31557600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per second",
                  UnitLabel = "lb/s",
                  SIUnitName = "kilogram per second",
                  ID = new Guid("48ac7515-ce4e-4ed6-a198-fe3ed3451a38"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Pound",
                  ConversionFactorFromSI = Factors.Unit/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Pound, i.e., 2.2046226218487757"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per minute",
                  UnitLabel = "lb/min",
                  SIUnitName = "kilogram per second",
                  ID = new Guid("92d18443-9357-42cf-86d2-fa78996c838a"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Pound",
                  ConversionFactorFromSI = Factors.Minute/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Pound, i.e., 132.27735731092653"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per hour",
                  UnitLabel = "lb/h",
                  SIUnitName = "kilogram per second",
                  ID = new Guid("d4e0791c-eb4c-47a4-9e71-af3ad1b707cc"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Pound",
                  ConversionFactorFromSI = Factors.Hour/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Pound, i.e., 7936.6414386555925"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per year",
                  UnitLabel = "lb/y",
                  SIUnitName = "kilogram per second",
                  ID = new Guid("a461e40b-48ea-49b1-8a55-8e75b26fbb8e"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian/Factors.Pound",
                  ConversionFactorFromSI = Factors.YearJulian/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian/Pound, i.e., 69572598.85125493"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MaterialStrengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "pascal",
                  UnitLabel = "Pa",
                  SIUnitName = "pascal",
                  ID = new Guid("159e99d3-c79d-4dc6-974f-05cc38af001e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "megapascal",
                  UnitLabel = "MPa",
                  SIUnitName = "pascal",
                  ID = new Guid("38b95b61-a825-4393-a0e8-ecd686575735"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megapascal"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigapascal",
                  UnitLabel = "GPa",
                  SIUnitName = "pascal",
                  ID = new Guid("c9aa0a18-02ac-42a0-9afe-8a08b4f03331"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigapascal"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "psi",
                  UnitLabel = "psi",
                  SIUnitName = "pascal",
                  ID = new Guid("4adf2a33-05c3-49bb-ba61-59dd76f4621e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.PSI",
                  ConversionFactorFromSI = 1.0/Factors.PSI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in psi"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/PSI, i.e., 0.00014503773773020924"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per 100 square foot",
                  UnitLabel = "lbf/100ft²",
                  SIUnitName = "pascal",
                  ID = new Guid("eb1e2a52-3de3-4338-ad4d-40e8ce90e40b"),
                  ConversionFactorFromSIFormula = "100.0*Factors.Foot*Factors.Foot/(Factors.PoundForce)",
                  ConversionFactorFromSI = 100.0*Factors.Foot*Factors.Foot/(Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per 100 square foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 100.0*Foot*Foot/(PoundForce), i.e., 2.0885434233150124"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megapound per square inch",
                  UnitLabel = "Mpsi",
                  SIUnitName = "pascal",
                  ID = new Guid("197a8b98-190d-4d45-91d7-85af12deab02"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega*Factors.PSI)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega*Factors.PSI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megapound per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega*PSI), i.e., 1.4503773773020922E-10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PorousMediumPermeabilityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "square metre",
                  UnitLabel = "m²",
                  SIUnitName = "square metre",
                  ID = new Guid("5e27ad4a-b541-4807-9a36-4bd159b33f52"),
                  ConversionFactorFromSIFormula = "1.0 / Factors.Unit",
                  ConversionFactorFromSI = 1.0 / Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "darcy",
                  UnitLabel = "D",
                  SIUnitName = "square metre",
                  ID = new Guid("9a89bcc3-dc77-4e3a-a492-fcdabc24ec41"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Darcy",
                  ConversionFactorFromSI = 1.0/Factors.Darcy,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in darcy"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Darcy, i.e., 1013250000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Darcy = 0.0000001 / Atmosphere reference: https://en.wikipedia.org/wiki/Darcy_(unit)"
 + Environment.NewLine + "Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millidarcy",
                  UnitLabel = "mD",
                  SIUnitName = "square metre",
                  ID = new Guid("8d7a6767-6c6b-4daf-8617-d35e4055d457"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Darcy)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Darcy),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millidarcy"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Milli*Darcy), i.e., 1013250000000000.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Darcy = 0.0000001 / Atmosphere reference: https://en.wikipedia.org/wiki/Darcy_(unit)"
 + Environment.NewLine + "Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microdarcy",
                  UnitLabel = "µD",
                  SIUnitName = "square metre",
                  ID = new Guid("b552f28d-c68a-4c59-853c-fe6e03dd5f4c"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Micro*Factors.Darcy)",
                  ConversionFactorFromSI = 1.0/(Factors.Micro*Factors.Darcy),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microdarcy"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Micro*Darcy), i.e., 1.01325E+18"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "Darcy = 0.0000001 / Atmosphere reference: https://en.wikipedia.org/wiki/Darcy_(unit)"
 + Environment.NewLine + "Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanodarcy",
                  UnitLabel = "nD",
                  SIUnitName = "square metre",
                  ID = new Guid("f35b05c7-8b2f-4194-9336-d42cec5f3ba5"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Nano*Factors.Darcy)",
                  ConversionFactorFromSI = 1.0/(Factors.Nano*Factors.Darcy),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanodarcy"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Nano*Darcy), i.e., 1.01325E+21"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "Darcy = 0.0000001 / Atmosphere reference: https://en.wikipedia.org/wiki/Darcy_(unit)"
 + Environment.NewLine + "Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PlaneAngleQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "radian",
                  UnitLabel = "rad",
                  SIUnitName = "radian",
                  ID = new Guid("a71fc712-342a-48c2-8e45-b56ee31c7ae0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "milliradian",
                  UnitLabel = "mrad",
                  SIUnitName = "radian",
                  ID = new Guid("34a37faf-dfb9-4a34-899c-c9fa78f295a5"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in milliradian"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree",
                  UnitLabel = "°",
                  SIUnitName = "radian",
                  ID = new Guid("023a3393-a01e-499f-967a-a76b1a78d586"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree, i.e., 57.29577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "grad",
                  UnitLabel = "grad",
                  SIUnitName = "radian",
                  ID = new Guid("584314cf-a10f-49b6-a5e9-1cfa0ec0f355"),
                  ConversionFactorFromSIFormula = "Factors.Grad",
                  ConversionFactorFromSI = Factors.Grad,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in grad"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Grad, i.e., 63.66197723675813"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Grad = 200.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gon",
                  UnitLabel = "gon",
                  SIUnitName = "radian",
                  ID = new Guid("feefeed5-2df2-4c66-84f1-0de998ba44db"),
                  ConversionFactorFromSIFormula = "Factors.Grad",
                  ConversionFactorFromSI = Factors.Grad,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gon"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Grad, i.e., 63.66197723675813"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Grad = 200.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "circle",
                  UnitLabel = "circle",
                  SIUnitName = "radian",
                  ID = new Guid("e27aeec3-667d-41bb-9bd2-60bf213f8b7b"),
                  ConversionFactorFromSIFormula = "1.0/(2.0*System.Math.PI)",
                  ConversionFactorFromSI = 1.0/(2.0*System.Math.PI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in circle"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(2.0*PI), i.e., 0.15915494309189535"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "revolution",
                  UnitLabel = "revolution",
                  SIUnitName = "radian",
                  ID = new Guid("e613477b-f8bc-45c7-8ccc-391a7f33af05"),
                  ConversionFactorFromSIFormula = "1.0/(2.0*System.Math.PI)",
                  ConversionFactorFromSI = 1.0/(2.0*System.Math.PI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in revolution"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(2.0*PI), i.e., 0.15915494309189535"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "quadrant",
                  UnitLabel = "quadrant",
                  SIUnitName = "radian",
                  ID = new Guid("dedbbea6-40e7-439a-9409-220fee4c148a"),
                  ConversionFactorFromSIFormula = "2.0/System.Math.PI",
                  ConversionFactorFromSI = 2.0/System.Math.PI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in quadrant"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 2.0/PI, i.e., 0.6366197723675814"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "sextant",
                  UnitLabel = "sextant",
                  SIUnitName = "radian",
                  ID = new Guid("ce4197b4-6d9d-488b-a360-98899a82837e"),
                  ConversionFactorFromSIFormula = "3.0/System.Math.PI",
                  ConversionFactorFromSI = 3.0/System.Math.PI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in sextant"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 3.0/PI, i.e., 0.954929658551372"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "octant",
                  UnitLabel = "octant",
                  SIUnitName = "radian",
                  ID = new Guid("8f78bfce-cad9-4a77-aa5f-3a5fecc89364"),
                  ConversionFactorFromSIFormula = "4.0/System.Math.PI",
                  ConversionFactorFromSI = 4.0/System.Math.PI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in octant"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 4.0/PI, i.e., 1.2732395447351628"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "arc minute",
                  UnitLabel = "'",
                  SIUnitName = "radian",
                  ID = new Guid("e1ce9562-ecd0-46e2-82e2-bcec1b6ac113"),
                  ConversionFactorFromSIFormula = "60.0*Factors.Degree",
                  ConversionFactorFromSI = 60.0*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in arc minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 60.0*Degree, i.e., 3437.746770784939"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "arc second",
                  UnitLabel = "\"",
                  SIUnitName = "radian",
                  ID = new Guid("bea092da-34d6-4130-bc65-41fb7702597a"),
                  ConversionFactorFromSIFormula = "60.0*60.0*Factors.Degree",
                  ConversionFactorFromSI = 60.0*60.0*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in arc second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 60.0*60.0*Degree, i.e., 206264.80624709636"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PowerQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "watt",
                  UnitLabel = "W",
                  SIUnitName = "watt",
                  ID = new Guid("9d986a0c-700f-4448-a48c-a028bbd22049"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "decawatt",
                  UnitLabel = "daW",
                  SIUnitName = "watt",
                  ID = new Guid("fa888306-f2ef-420a-9ce2-8c56fe64ea3c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deca",
                  ConversionFactorFromSI = 1.0/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decawatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deca, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hectowatt",
                  UnitLabel = "hW",
                  SIUnitName = "watt",
                  ID = new Guid("1f159f0d-635a-4bc8-9020-6c09d72b3f63"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Hecto",
                  ConversionFactorFromSI = 1.0/Factors.Hecto,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hectowatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Hecto, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilowatt",
                  UnitLabel = "kW",
                  SIUnitName = "watt",
                  ID = new Guid("016b23c7-0231-45bb-8723-5d3d4cc5c054"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilowatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megawatt",
                  UnitLabel = "MW",
                  SIUnitName = "watt",
                  ID = new Guid("5719b5f3-5c24-46d2-8ccd-0a06cc6b49ae"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megawatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigawatt",
                  UnitLabel = "GW",
                  SIUnitName = "watt",
                  ID = new Guid("ba67ba92-cdf5-46a8-a5f5-56c1ad102417"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigawatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "terawatt",
                  UnitLabel = "TW",
                  SIUnitName = "watt",
                  ID = new Guid("b3e60a20-9e0f-479b-903b-16b22d86a515"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Tera",
                  ConversionFactorFromSI = 1.0/Factors.Tera,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in terawatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Tera, i.e., 1E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Tera = 1e12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "petawatt",
                  UnitLabel = "PW",
                  SIUnitName = "watt",
                  ID = new Guid("bafba6b7-8a58-46b0-b4c7-c9a008c5e8f4"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Peta",
                  ConversionFactorFromSI = 1.0/Factors.Peta,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in petawatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Peta, i.e., 1E-15"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Peta = 1e15"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "exawatt",
                  UnitLabel = "EW",
                  SIUnitName = "watt",
                  ID = new Guid("457950e4-0d4c-4f18-87ae-c35a7d2f512a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Exa",
                  ConversionFactorFromSI = 1.0/Factors.Exa,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in exawatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Exa, i.e., 1E-18"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Exa = 1e18"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "deciwatt",
                  UnitLabel = "dW",
                  SIUnitName = "watt",
                  ID = new Guid("6a3cd886-1c2c-41c8-8214-b21aff588b1e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deci",
                  ConversionFactorFromSI = 1.0/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in deciwatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centiwatt",
                  UnitLabel = "cW",
                  SIUnitName = "watt",
                  ID = new Guid("ac6c67e1-0912-44f2-9496-ed82aca2b925"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centiwatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "milliwatt",
                  UnitLabel = "mW",
                  SIUnitName = "watt",
                  ID = new Guid("4b9e8b24-6c84-423e-8f79-b2bec161f219"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in milliwatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microwatt",
                  UnitLabel = "µW",
                  SIUnitName = "watt",
                  ID = new Guid("f0345b17-3e67-4c27-a787-69cd6feb7b1b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microwatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanowatt",
                  UnitLabel = "nW",
                  SIUnitName = "watt",
                  ID = new Guid("622ee208-1b04-42c4-ba6e-552e6e328e02"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanowatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "picowatt",
                  UnitLabel = "pW",
                  SIUnitName = "watt",
                  ID = new Guid("5b46567b-0571-4ca7-90d5-6304a0b7f938"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in picowatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pico, i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "femtowatt",
                  UnitLabel = "fW",
                  SIUnitName = "watt",
                  ID = new Guid("325622ea-c161-4f4f-9ee4-86d9e802f21c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Femto",
                  ConversionFactorFromSI = 1.0/Factors.Femto,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in femtowatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Femto, i.e., 999999999999999.9"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Femto = 1e-15"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "attowatt",
                  UnitLabel = "aW",
                  SIUnitName = "watt",
                  ID = new Guid("7bc1807f-90ac-41b0-a15f-9d1c81101f6d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Atto",
                  ConversionFactorFromSI = 1.0/Factors.Atto,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in attowatt"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Atto, i.e., 9.999999999999999E+17"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Atto = 1e-18"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PressureGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "pascal per metre",
                  UnitLabel = "Pa/m",
                  SIUnitName = "pascal per metre",
                  ID = new Guid("f5a37831-4a70-44de-af34-4f6ce1a54af3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "bar per metre",
                  UnitLabel = "bar/m",
                  SIUnitName = "pascal per metre",
                  ID = new Guid("73a70891-87cf-44fc-8437-94938f034eec"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Bar",
                  ConversionFactorFromSI = 1.0/Factors.Bar,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in bar per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Bar, i.e., 1E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "psi per metre",
                  UnitLabel = "psi/m",
                  SIUnitName = "pascal per metre",
                  ID = new Guid("2235a51b-cdf2-4f53-9664-b7a968dbbba3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.PSI",
                  ConversionFactorFromSI = 1.0/Factors.PSI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in psi per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/PSI, i.e., 0.00014503773773020924"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "psi per foot",
                  UnitLabel = "psi/ft",
                  SIUnitName = "pascal per metre",
                  ID = new Guid("b99cef5c-d6df-4803-b52b-6050cf7e7ff8"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.PSI",
                  ConversionFactorFromSI = Factors.Foot/Factors.PSI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in psi per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/PSI, i.e., 4.4207502460167764E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PressureLossConstantQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "pressure loss constant SI",
                  UnitLabel = "(m³/s)²•(kg/m³)/Pa",
                  SIUnitName = "pressure loss constant SI",
                  ID = new Guid("e0b334c4-2e44-4b1b-891f-9deae86a4d17"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "pressure loss constant metric",
                  UnitLabel = "(l/min)²•sg/bar",
                  SIUnitName = "pressure loss constant SI",
                  ID = new Guid("043fbd34-1e4f-45bc-9935-b1797b606fd6"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute*Factors.Bar*Factors.SpecificGavity4degC/(Factors.Milli*Factors.Milli)",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute*Factors.Bar*Factors.SpecificGavity4degC/(Factors.Milli*Factors.Milli),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pressure loss constant metric"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Minute*Bar*SpecificGavity4degC/(Milli*Milli), i.e., 360010080282.2479"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pressure loss constant UK",
                  UnitLabel = "gpmuk²•ppguk/psi",
                  SIUnitName = "pressure loss constant SI",
                  ID = new Guid("d5a97f2d-cb2f-449f-8f60-0ad292a01b87"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute*Factors.PSI/(Factors.PPGUK*Factors.GallonUK*Factors.GallonUK)",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute*Factors.PSI/(Factors.PPGUK*Factors.GallonUK*Factors.GallonUK),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pressure loss constant UK"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Minute*PSI/(PPGUK*GallonUK*GallonUK), i.e., 12036984846.853645"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PPGUK = Pound / GallonUK"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pressure loss constant US",
                  UnitLabel = "gpmus²•ppgus/psi",
                  SIUnitName = "pressure loss constant SI",
                  ID = new Guid("b5cb21d1-0e71-4ab2-8d9d-42de21753edc"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute*Factors.PSI/(Factors.PPGUS*Factors.GallonUS*Factors.GallonUS)",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute*Factors.PSI/(Factors.PPGUS*Factors.GallonUS*Factors.GallonUS),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pressure loss constant US"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Minute*PSI/(PPGUS*GallonUS*GallonUS), i.e., 14455816055.131952"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PPGUS = Pound / GallonUS"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PressureQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "pascal",
                  UnitLabel = "Pa",
                  SIUnitName = "pascal",
                  ID = new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "kilopascal",
                  UnitLabel = "KPa",
                  SIUnitName = "pascal",
                  ID = new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopascal"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "bar",
                  UnitLabel = "bar",
                  SIUnitName = "pascal",
                  ID = new Guid("0d182739-f8f6-47a6-afcb-71feac973307"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Bar",
                  ConversionFactorFromSI = 1.0/Factors.Bar,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in bar"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Bar, i.e., 1E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millibar",
                  UnitLabel = "mbar",
                  SIUnitName = "pascal",
                  ID = new Guid("43e4fe86-948d-4765-a69d-513ce6dc2b5b"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Bar)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Bar),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millibar"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Milli*Bar), i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microbar",
                  UnitLabel = "µbar",
                  SIUnitName = "pascal",
                  ID = new Guid("7fb9e41f-4748-4457-b8b9-efb73da52d94"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Micro*Factors.Bar)",
                  ConversionFactorFromSI = 1.0/(Factors.Micro*Factors.Bar),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microbar"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Micro*Bar), i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per square inch",
                  UnitLabel = "psi",
                  SIUnitName = "pascal",
                  ID = new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485"),
                  ConversionFactorFromSIFormula = "1.0/Factors.PSI",
                  ConversionFactorFromSI = 1.0/Factors.PSI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/PSI, i.e., 0.00014503773773020924"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per 100 square foot",
                  UnitLabel = "lbf/100ft²",
                  SIUnitName = "pascal",
                  ID = new Guid("e3b95821-d782-4f12-a492-489cbcd6d2a1"),
                  ConversionFactorFromSIFormula = "100.0*Factors.Foot*Factors.Foot/Factors.PoundForce",
                  ConversionFactorFromSI = 100.0*Factors.Foot*Factors.Foot/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per 100 square foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 100.0*Foot*Foot/PoundForce, i.e., 2.0885434233150124"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilopound per square inch",
                  UnitLabel = "ksi",
                  SIUnitName = "pascal",
                  ID = new Guid("a07b5fe5-87e3-4422-afe1-f54de24deeb8"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.PSI)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.PSI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopound per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*PSI), i.e., 1.4503773773020924E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "standard atmosphere",
                  UnitLabel = "atm",
                  SIUnitName = "pascal",
                  ID = new Guid("93839971-33f2-43e9-82eb-9f869846f999"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Atmosphere",
                  ConversionFactorFromSI = 1.0/Factors.Atmosphere,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in standard atmosphere"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Atmosphere, i.e., 9.869232667160129E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per square foot",
                  UnitLabel = "lb/ft²",
                  SIUnitName = "pascal",
                  ID = new Guid("35b28889-c076-4274-b200-cf7732b17aa3"),
                  ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot/Factors.PoundForce",
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per square foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot*Foot/PoundForce, i.e., 0.020885434233150126"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megapascal",
                  UnitLabel = "MPa",
                  SIUnitName = "pascal",
                  ID = new Guid("4ef28797-f416-4d97-b36a-711ea848bcc0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megapascal"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigapascal",
                  UnitLabel = "GPa",
                  SIUnitName = "pascal",
                  ID = new Guid("5c81fb9b-36ad-47b7-9a8e-c999f7fdbfe3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigapascal"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per square metre",
                  UnitLabel = "N/m²",
                  SIUnitName = "pascal",
                  ID = new Guid("101e92c3-47ab-4d55-8982-93061bc82dea"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per square metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per square centimetre",
                  UnitLabel = "N/cm²",
                  SIUnitName = "pascal",
                  ID = new Guid("2aa59deb-84d9-41c5-969f-8c8bb9d0c369"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi, i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per square millimetre",
                  UnitLabel = "N/mm²",
                  SIUnitName = "pascal",
                  ID = new Guid("e5e9cb06-38a8-4ac2-a8a5-8b74689a31a8"),
                  ConversionFactorFromSIFormula = "Factors.Milli*Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli*Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per square millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli*Milli, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton per square metre",
                  UnitLabel = "kN/m²",
                  SIUnitName = "pascal",
                  ID = new Guid("eaa46677-af1c-4922-bf61-d82f2925534b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton per square metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megapound per square inch",
                  UnitLabel = "Mpsi",
                  SIUnitName = "pascal",
                  ID = new Guid("bb49de0a-fbf3-4914-b6b9-fc60ab502522"),
                  ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch/(Factors.Mega*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Inch*Factors.Inch/(Factors.Mega*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megapound per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch*Inch/(Mega*PoundForce), i.e., 1.4503773773020922E-10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "torr",
                  UnitLabel = "Torr",
                  SIUnitName = "pascal",
                  ID = new Guid("f5afdfee-624e-46fa-b798-0ab1b04d2181"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Torr",
                  ConversionFactorFromSI = 1.0/Factors.Torr,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in torr"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Torr, i.e., 0.007500616827041697"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Torr = (1.0 / 760.0) * Atmosphere reference: https://en.wikipedia.org/wiki/Torr"
 + Environment.NewLine + "Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre mercury at zero degree celsius",
                  UnitLabel = "cm Hg 0°C",
                  SIUnitName = "pascal",
                  ID = new Guid("412602dc-837b-4fab-afc9-3bf4798a9bed"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deca*Factors.MillimetreMercury)",
                  ConversionFactorFromSI = 1.0/(Factors.Deca*Factors.MillimetreMercury),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre mercury at zero degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Deca*MillimetreMercury), i.e., 0.0007500615758456563"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "MillimetreMercury = 133.322387415 reference: https://en.wikipedia.org/wiki/Millimetre_of_mercury"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre mercury at zero degree celsius",
                  UnitLabel = "mm Hg 0°C",
                  SIUnitName = "pascal",
                  ID = new Guid("d91f64fe-4df4-4ddd-943c-d985fbd1659b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.MillimetreMercury",
                  ConversionFactorFromSI = 1.0/Factors.MillimetreMercury,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre mercury at zero degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/MillimetreMercury, i.e., 0.007500615758456563"
 + Environment.NewLine + "and"
 + Environment.NewLine + "MillimetreMercury = 133.322387415 reference: https://en.wikipedia.org/wiki/Millimetre_of_mercury"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch mercury at 32 degree fahrenheit",
                  UnitLabel = "in Hg 32°F",
                  SIUnitName = "pascal",
                  ID = new Guid("ab729585-0716-4f24-9502-fcd07ba051bc"),
                  ConversionFactorFromSIFormula = "1.0/Factors.InchMercury32degF",
                  ConversionFactorFromSI = 1.0/Factors.InchMercury32degF,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch mercury at 32 degree fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/InchMercury32degF, i.e., 3386.3890000000006"
 + Environment.NewLine + "and"
 + Environment.NewLine + "InchMercury32degF = 1.0/3386.389 reference: https://en.wikipedia.org/wiki/Inch_of_mercury"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch mercury at 60 degree fahrenheit",
                  UnitLabel = "in Hg 60°F",
                  SIUnitName = "pascal",
                  ID = new Guid("83ed97cc-526c-41cc-be78-ea0c86412080"),
                  ConversionFactorFromSIFormula = "1.0/Factors.InchMercury60degF",
                  ConversionFactorFromSI = 1.0/Factors.InchMercury60degF,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch mercury at 60 degree fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/InchMercury60degF, i.e., 3376.85"
 + Environment.NewLine + "and"
 + Environment.NewLine + "InchMercury60degF = 1.0 / 3376.85 reference: https://en.wikipedia.org/wiki/Inch_of_mercury"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre water at 4 degree celsius",
                  UnitLabel = "cm Aq 4°C",
                  SIUnitName = "pascal",
                  ID = new Guid("a1bac4cc-f37c-4aa5-aec6-ede0b4c52f09"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deca*Factors.MillimetreWater4degC)",
                  ConversionFactorFromSI = 1.0/(Factors.Deca*Factors.MillimetreWater4degC),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre water at 4 degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Deca*MillimetreWater4degC), i.e., 0.010104429276573386"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "MillimetreWater4degC = 9.89665 reference: https://en.wikipedia.org/wiki/Centimetre_or_millimetre_of_water"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre water at 4 degree celsius",
                  UnitLabel = "mm Aq 4°C",
                  SIUnitName = "pascal",
                  ID = new Guid("a46b3ef6-fe2a-4ff3-bc2d-7a26661ce45e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.MillimetreWater4degC",
                  ConversionFactorFromSI = 1.0/Factors.MillimetreWater4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre water at 4 degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/MillimetreWater4degC, i.e., 0.10104429276573387"
 + Environment.NewLine + "and"
 + Environment.NewLine + "MillimetreWater4degC = 9.89665 reference: https://en.wikipedia.org/wiki/Centimetre_or_millimetre_of_water"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch water at 4 degree celsius",
                  UnitLabel = "in Aq 4°C",
                  SIUnitName = "pascal",
                  ID = new Guid("3015f436-b35d-455c-af23-b9bc4dd857da"),
                  ConversionFactorFromSIFormula = "1.0/Factors.InchWater4degC",
                  ConversionFactorFromSI = 1.0/Factors.InchWater4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch water at 4 degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/InchWater4degC, i.e., 0.00401474213311279"
 + Environment.NewLine + "and"
 + Environment.NewLine + "InchWater4degC = 249.082 reference: https://en.wikipedia.org/wiki/Inch_of_water"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot water at 4 degree celsius",
                  UnitLabel = "ft Aq 4°C",
                  SIUnitName = "pascal",
                  ID = new Guid("52de6721-dfec-4a54-861c-e74da72c8470"),
                  ConversionFactorFromSIFormula = "1.0/Factors.FootWater4degC",
                  ConversionFactorFromSI = 1.0/Factors.FootWater4degC,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot water at 4 degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/FootWater4degC, i.e., 0.0003345525543589354"
 + Environment.NewLine + "and"
 + Environment.NewLine + "FootWater4degC = 2989.067 reference: https://en.wikipedia.org/wiki/Inch_of_water"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "dyne per square centimetre",
                  UnitLabel = "dyne/cm²",
                  SIUnitName = "pascal",
                  ID = new Guid("04ca59b8-90e1-4903-ac82-ee95cac0ca38"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi/Factors.Dyne",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi/Factors.Dyne,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in dyne per square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi/Dyne, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Dyne = 1e-5 reference: https://en.wikipedia.org/wiki/Dyne"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ProportionQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "proportion",
                  UnitLabel = "",
                  SIUnitName = "proportion",
                  ID = new Guid("03eb339b-61aa-4b42-aa35-4a20c547fdb9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "percent",
                  UnitLabel = "%",
                  SIUnitName = "proportion",
                  ID = new Guid("1a825e84-bc53-4da8-a089-118fdf40b8f7"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in percent"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "per thousand",
                  UnitLabel = "‰",
                  SIUnitName = "proportion",
                  ID = new Guid("141465a2-9c3c-4dda-82ec-eb35e72250c2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in per thousand"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "part per million",
                  UnitLabel = "ppm",
                  SIUnitName = "proportion",
                  ID = new Guid("af33bf27-c3b8-4746-8b08-826ed1d21792"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in part per million"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class RandomWalkQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "radian per square root second",
                  UnitLabel = "rad/√s",
                  SIUnitName = "radian per square root second",
                  ID = new Guid("557ea59e-a1da-438b-b04d-ccfc5539f87f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "radian per square root minute",
                  UnitLabel = "rad/√min",
                  SIUnitName = "radian per square root second",
                  ID = new Guid("ccc41b4e-2efb-4760-969f-94614248374f"),
                  ConversionFactorFromSIFormula = "System.Math.Sqrt(Factors.Minute)",
                  ConversionFactorFromSI = System.Math.Sqrt(Factors.Minute),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per square root minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Sqrt(Minute), i.e., 7.745966692414834"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per square root hour",
                  UnitLabel = "rad/√h",
                  SIUnitName = "radian per square root second",
                  ID = new Guid("e296c410-e278-4586-af95-bae6fe4f0673"),
                  ConversionFactorFromSIFormula = "System.Math.Sqrt(Factors.Hour)",
                  ConversionFactorFromSI = System.Math.Sqrt(Factors.Hour),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per square root hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Sqrt(Hour), i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "radian per square root day",
                  UnitLabel = "rad/√d",
                  SIUnitName = "radian per square root second",
                  ID = new Guid("fb4a74f9-a648-4310-a424-9c85036bbc41"),
                  ConversionFactorFromSIFormula = "System.Math.Sqrt(Factors.Day)",
                  ConversionFactorFromSI = System.Math.Sqrt(Factors.Day),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in radian per square root day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Sqrt(Day), i.e., 293.9387691339814"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per square root second",
                  UnitLabel = "°/√s",
                  SIUnitName = "radian per square root second",
                  ID = new Guid("87a0a4e3-a2f5-4f84-b845-c7e6276e1655"),
                  ConversionFactorFromSIFormula = "Factors.Degree",
                  ConversionFactorFromSI = Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per square root second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Degree, i.e., 57.29577951308232"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per square root minute",
                  UnitLabel = "°/√min",
                  SIUnitName = "radian per square root second",
                  ID = new Guid("e8e3a988-4219-44a5-ae89-ce115a239d04"),
                  ConversionFactorFromSIFormula = "System.Math.Sqrt(Factors.Minute)*Factors.Degree",
                  ConversionFactorFromSI = System.Math.Sqrt(Factors.Minute)*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per square root minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Sqrt(Minute)*Degree, i.e., 443.8111997242799"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per square root hour",
                  UnitLabel = "°/√h",
                  SIUnitName = "radian per square root second",
                  ID = new Guid("ab6b85cf-54e5-4c3b-a330-f65d7e3bb926"),
                  ConversionFactorFromSIFormula = "System.Math.Sqrt(Factors.Hour)*Factors.Degree",
                  ConversionFactorFromSI = System.Math.Sqrt(Factors.Hour)*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per square root hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Sqrt(Hour)*Degree, i.e., 3437.746770784939"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree per square root day",
                  UnitLabel = "°/√d",
                  SIUnitName = "radian per square root second",
                  ID = new Guid("8f806d0f-3741-4aa8-9f37-54b4f80e307c"),
                  ConversionFactorFromSIFormula = "System.Math.Sqrt(Factors.Day)*Factors.Degree",
                  ConversionFactorFromSI = System.Math.Sqrt(Factors.Day)*Factors.Degree,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree per square root day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Sqrt(Day)*Degree, i.e., 16841.450906647406"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Degree = 180.0 / System.Math.PI"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class RelativeTemperatureQuantity : TemperatureQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kelvin",
                  UnitLabel = "K",
                  SIUnitName = "kelvin",
                  ID = new Guid("8fc5fa10-2d89-4064-8ace-b852d9a8d31f"),
                  ConversionFactorFromSIFormula = "Factors.Unit",
                  ConversionFactorFromSI = Factors.Unit,
                  ConversionBiasFromSIFormula = "0",
                  ConversionBiasFromSI = 0,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "relative celsius",
                  UnitLabel = "°C",
                  SIUnitName = "kelvin",
                  ID = new Guid("10ea31a1-e661-41c9-9a3d-245904b73599"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in relative celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "rankine",
                  UnitLabel = "°R",
                  SIUnitName = "kelvin",
                  ID = new Guid("62f3ffbc-eda3-400a-9fb7-8d021771f0fa"),
                  ConversionFactorFromSIFormula = "1.0/Factors.FahrenheitSlope",
                  ConversionFactorFromSI = 1.0/Factors.FahrenheitSlope,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in rankine"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/FahrenheitSlope, i.e., 1.7999999999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ResistivityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "ohm metre",
                  UnitLabel = "Ω•m",
                  SIUnitName = "ohm metre",
                  ID = new Guid("fb07d86d-d69f-46ca-892c-17ec45adffcb"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "kilo ohm metre",
                  UnitLabel = "kΩ•m",
                  SIUnitName = "ohm metre",
                  ID = new Guid("c58ce3f0-7389-4c36-b291-55fa5ceb9962"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo ohm metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mega ohm metre",
                  UnitLabel = "MΩ•m",
                  SIUnitName = "ohm metre",
                  ID = new Guid("cf90cab7-e973-469a-9727-08bfa7f708e6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mega ohm metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "giga ohm metre",
                  UnitLabel = "GΩ•m",
                  SIUnitName = "ohm metre",
                  ID = new Guid("eecfdf24-7a8e-4783-a627-d4387831767d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in giga ohm metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class SolidAngleQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "steradian",
                  UnitLabel = "sr",
                  SIUnitName = "steradian",
                  ID = new Guid("aee057f5-3235-4976-b6e6-a57179f0173e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "spat",
                  UnitLabel = "spat",
                  SIUnitName = "steradian",
                  ID = new Guid("44abc0c0-d564-442a-ac80-b08c9d499867"),
                  ConversionFactorFromSIFormula = "1/(4.0*System.Math.PI)",
                  ConversionFactorFromSI = 1/(4.0*System.Math.PI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in spat"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1/(4.0*PI), i.e., 0.07957747154594767"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "degree squared",
                  UnitLabel = "(°)²",
                  SIUnitName = "steradian",
                  ID = new Guid("ad4b94e8-1a86-42ab-bfc6-9cc7ff7a835f"),
                  ConversionFactorFromSIFormula = "(180.0*180.0)/(System.Math.PI*System.Math.PI)",
                  ConversionFactorFromSI = (180.0*180.0)/(System.Math.PI*System.Math.PI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in degree squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = (180.0*180.0)/(PI*PI), i.e., 3282.806350011744"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class SpecificHeatCapacityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "joule per kilogram kelvin",
                  UnitLabel = "J/kg•K",
                  SIUnitName = "joule per kilogram kelvin",
                  ID = new Guid("52d9523e-546b-41dd-b283-a125447433a3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "joule per gram kelvin",
                  UnitLabel = "J/g•K",
                  SIUnitName = "joule per kilogram kelvin",
                  ID = new Guid("0c38001b-ecba-4920-ac75-e4644d8feced"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Unit",
                  ConversionFactorFromSI = Factors.Milli/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per gram kelvin"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Unit, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "joule per gram degree celsius",
                  UnitLabel = "J/g•°C",
                  SIUnitName = "joule per kilogram kelvin",
                  ID = new Guid("5b620d63-2269-42d3-8385-edca04c7ea70"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Unit",
                  ConversionFactorFromSI = Factors.Milli/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per gram degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Unit, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per gram degree celsius",
                  UnitLabel = "cal/g•°C",
                  SIUnitName = "joule per kilogram kelvin",
                  ID = new Guid("bb241c58-e76c-4d96-81c1-356b3f2ad397"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Calorie",
                  ConversionFactorFromSI = Factors.Milli/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per gram degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Calorie, i.e., 0.0002390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per pound degree fahrenheit",
                  UnitLabel = "BTU/lb•°F",
                  SIUnitName = "joule per kilogram kelvin",
                  ID = new Guid("ad9274f2-4c1a-45fe-97c1-710f00deca16"),
                  ConversionFactorFromSIFormula = "Factors.Pound*Factors.FahrenheitSlope/Factors.BTU",
                  ConversionFactorFromSI = Factors.Pound*Factors.FahrenheitSlope/Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per pound degree fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Pound*FahrenheitSlope/BTU, i.e., 0.0002390057960934331"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocalorie per gram degree celsius",
                  UnitLabel = "Cal/g•°C",
                  SIUnitName = "joule per kilogram kelvin",
                  ID = new Guid("b283ecf7-20e4-4a6c-b62b-b07f56fa6614"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.Kilo*Factors.Calorie)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.Kilo*Factors.Calorie),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocalorie per gram degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(Kilo*Calorie), i.e., 2.390057361376673E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class SpecificHeatCapacityGradientPerTemperatureQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "joule per kilogram squared kelvin",
                  UnitLabel = "J/kg•K²",
                  SIUnitName = "joule per kilogram squared kelvin",
                  ID = new Guid("9570fd84-ff2e-4a74-93b7-39bcf6558301"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "joule per gram squared kelvin",
                  UnitLabel = "J/g•K²",
                  SIUnitName = "joule per kilogram squared kelvin",
                  ID = new Guid("69520d03-c7c3-483f-bbbb-6bdf3cf74463"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per gram squared kelvin"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "joule per gram degree squared celsius",
                  UnitLabel = "J/g•°C²",
                  SIUnitName = "joule per kilogram squared kelvin",
                  ID = new Guid("9ed03436-3032-4bee-a145-fd03b6236816"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in joule per gram degree squared celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per gram degree squared celsius",
                  UnitLabel = "cal/g•°C²",
                  SIUnitName = "joule per kilogram squared kelvin",
                  ID = new Guid("ad3fe4d1-3286-4313-9f45-f2110b7ca6f2"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Calorie",
                  ConversionFactorFromSI = Factors.Milli/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per gram degree squared celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Calorie, i.e., 0.0002390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per pound squared degree fahrenheit ",
                  UnitLabel = "BTU/lb•°F²",
                  SIUnitName = "joule per kilogram squared kelvin",
                  ID = new Guid("57264532-79b7-4a19-8ffe-617bba781be3"),
                  ConversionFactorFromSIFormula = "Factors.Pound*Factors.FahrenheitSlope*Factors.FahrenheitSlope/Factors.BTU",
                  ConversionFactorFromSI = Factors.Pound*Factors.FahrenheitSlope*Factors.FahrenheitSlope/Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per pound squared degree fahrenheit "
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Pound*FahrenheitSlope*FahrenheitSlope/BTU, i.e., 0.00013278099782968505"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class StressQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "pascal",
                  UnitLabel = "Pa",
                  SIUnitName = "pascal",
                  ID = new Guid("7a4c7d2e-62f1-43c7-9c9d-8ff8664b0d98"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "kilopascal",
                  UnitLabel = "KPa",
                  SIUnitName = "pascal",
                  ID = new Guid("8f070021-4cc7-424d-a325-e2e57fc82874"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopascal"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "bar",
                  UnitLabel = "bar",
                  SIUnitName = "pascal",
                  ID = new Guid("69864a1c-bb6b-400e-be3b-527bc94a9a96"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Bar",
                  ConversionFactorFromSI = 1.0/Factors.Bar,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in bar"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Bar, i.e., 1E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millibar",
                  UnitLabel = "mbar",
                  SIUnitName = "pascal",
                  ID = new Guid("cf58a57a-381b-4864-9ab3-bbe42589d871"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Bar)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Bar),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millibar"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Milli*Bar), i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microbar",
                  UnitLabel = "µbar",
                  SIUnitName = "pascal",
                  ID = new Guid("b3ae1880-5d17-4f4b-b837-c6dc13c44cae"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Micro*Factors.Bar)",
                  ConversionFactorFromSI = 1.0/(Factors.Micro*Factors.Bar),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microbar"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Micro*Bar), i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per square inch",
                  UnitLabel = "psi",
                  SIUnitName = "pascal",
                  ID = new Guid("0e385d5b-5d3a-4360-8695-a934f0152a09"),
                  ConversionFactorFromSIFormula = "1.0/Factors.PSI",
                  ConversionFactorFromSI = 1.0/Factors.PSI,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/PSI, i.e., 0.00014503773773020924"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per 100 square foot",
                  UnitLabel = "lbf/100ft²",
                  SIUnitName = "pascal",
                  ID = new Guid("d1aade96-1038-4902-9c4a-95f96933d54d"),
                  ConversionFactorFromSIFormula = "100.0*Factors.Foot*Factors.Foot/Factors.PoundForce",
                  ConversionFactorFromSI = 100.0*Factors.Foot*Factors.Foot/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per 100 square foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 100.0*Foot*Foot/PoundForce, i.e., 2.0885434233150124"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilopound per square inch",
                  UnitLabel = "ksi",
                  SIUnitName = "pascal",
                  ID = new Guid("02b3acd6-0715-4ef6-b8e4-6134a3cdc3a6"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.PSI)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.PSI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopound per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*PSI), i.e., 1.4503773773020924E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound per square foot",
                  UnitLabel = "lb/ft²",
                  SIUnitName = "pascal",
                  ID = new Guid("2d835d44-2ffd-4239-b0dd-c9c36a763d4a"),
                  ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot/Factors.PoundForce",
                  ConversionFactorFromSI = Factors.Foot*Factors.Foot/Factors.PoundForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound per square foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot*Foot/PoundForce, i.e., 0.020885434233150126"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megapascal",
                  UnitLabel = "MPa",
                  SIUnitName = "pascal",
                  ID = new Guid("b6de095b-2800-4faf-931b-e8b2b9b2e35f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megapascal"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigapascal",
                  UnitLabel = "GPa",
                  SIUnitName = "pascal",
                  ID = new Guid("213a896e-47e4-4745-baed-c28861f938bb"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigapascal"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per square metre",
                  UnitLabel = "N/m²",
                  SIUnitName = "pascal",
                  ID = new Guid("23d4c68e-a606-4fc0-a2b8-74998f6c2862"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per square metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per square centimetre",
                  UnitLabel = "N/cm²",
                  SIUnitName = "pascal",
                  ID = new Guid("b42eccea-4c35-42af-ba98-5101a3c10b6b"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi/Factors.Unit",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi/Unit, i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton per square millimetre",
                  UnitLabel = "N/mm²",
                  SIUnitName = "pascal",
                  ID = new Guid("9f96d22c-9021-4ed6-9904-344d6cd2417a"),
                  ConversionFactorFromSIFormula = "Factors.Milli*Factors.Milli/Factors.Unit",
                  ConversionFactorFromSI = Factors.Milli*Factors.Milli/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton per square millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli*Milli/Unit, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton per square metre",
                  UnitLabel = "kN/m²",
                  SIUnitName = "pascal",
                  ID = new Guid("ff05dc39-74f1-4bc8-b2d4-e9ee518d3e43"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.Unit)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.Unit),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton per square metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*Unit), i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megapound per square inch",
                  UnitLabel = "Mpsi",
                  SIUnitName = "pascal",
                  ID = new Guid("c1b8c4db-7a1e-4201-b0aa-e23d1df40871"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega*Factors.PSI)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega*Factors.PSI),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megapound per square inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega*PSI), i.e., 1.4503773773020922E-10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "dyne per square centimetre",
                  UnitLabel = "dyne/cm²",
                  SIUnitName = "pascal",
                  ID = new Guid("eee0197b-0fbd-4a21-8023-61403c9417fe"),
                  ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi/Factors.Dyne",
                  ConversionFactorFromSI = Factors.Centi*Factors.Centi/Factors.Dyne,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in dyne per square centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi*Centi/Dyne, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Dyne = 1e-5 reference: https://en.wikipedia.org/wiki/Dyne"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class TemperatureGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kelvin per metre",
                  UnitLabel = "K/m",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("f1fe19d2-12e3-43d1-ba97-3ef9e8ec9e73"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "celsius per metre",
                  UnitLabel = "°C/m",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("40dbbdfe-b680-403a-8326-2c217ba85d52"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in celsius per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Unit, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "celsius per 10 metre",
                  UnitLabel = "°C/10m",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("5e4ff2bf-4788-4258-bd4a-7b18a13364ff"),
                  ConversionFactorFromSIFormula = "Factors.Deca/Factors.Unit",
                  ConversionFactorFromSI = Factors.Deca/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in celsius per 10 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deca/Unit, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "celsius per 30 metre",
                  UnitLabel = "°C/30m",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("d17464c4-a7ef-4dcd-b783-bafe6e9b92de"),
                  ConversionFactorFromSIFormula = "3.0*Factors.Deca/Factors.Unit",
                  ConversionFactorFromSI = 3.0*Factors.Deca/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in celsius per 30 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 3.0*Deca/Unit, i.e., 30"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "celsius per 100 metre",
                  UnitLabel = "°C/100m",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("b47f299a-913a-46b7-ad20-c683fa0f02d0"),
                  ConversionFactorFromSIFormula = "Factors.Hecto/Factors.Unit",
                  ConversionFactorFromSI = Factors.Hecto/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in celsius per 100 metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hecto/Unit, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "celsius per foot",
                  UnitLabel = "°C/ft",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("e7b05420-41f6-4812-bc54-9c14f05a9cbd"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.Unit",
                  ConversionFactorFromSI = Factors.Foot/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in celsius per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/Unit, i.e., 0.30479999999999996"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "celsius per 30 foot",
                  UnitLabel = "°C/30ft",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("bea3df4f-78e9-4e1a-bbee-22086da043b4"),
                  ConversionFactorFromSIFormula = "30.0*Factors.Foot/Factors.Unit",
                  ConversionFactorFromSI = 30.0*Factors.Foot/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in celsius per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 30.0*Foot/Unit, i.e., 9.143999999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "celsius per 100 foot",
                  UnitLabel = "°C/100ft",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("f9bae95a-b282-44a7-8ae0-54728ef3c7a3"),
                  ConversionFactorFromSIFormula = "100.0*Factors.Foot/Factors.Unit",
                  ConversionFactorFromSI = 100.0*Factors.Foot/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in celsius per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 100.0*Foot/Unit, i.e., 30.479999999999997"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "fahrenheit per foot",
                  UnitLabel = "°F/ft",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("d08596f1-77c4-4a8e-9245-6bf563fa7345"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.FahrenheitSlope",
                  ConversionFactorFromSI = Factors.Foot/Factors.FahrenheitSlope,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in fahrenheit per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/FahrenheitSlope, i.e., 0.5486399999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "fahrenheit per 30 foot",
                  UnitLabel = "°F/30ft",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("a1664cb0-db5c-4933-9b57-d075c4975f46"),
                  ConversionFactorFromSIFormula = "30.0*Factors.Foot/Factors.FahrenheitSlope",
                  ConversionFactorFromSI = 30.0*Factors.Foot/Factors.FahrenheitSlope,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in fahrenheit per 30 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 30.0*Foot/FahrenheitSlope, i.e., 16.459199999999996"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "fahrenheit per 100 foot",
                  UnitLabel = "°F/100ft",
                  SIUnitName = "kelvin per metre",
                  ID = new Guid("232e2d6d-cb65-4b56-9277-457e4ff678fa"),
                  ConversionFactorFromSIFormula = "100.0*Factors.Foot/Factors.FahrenheitSlope",
                  ConversionFactorFromSI = 100.0*Factors.Foot/Factors.FahrenheitSlope,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in fahrenheit per 100 foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 100.0*Foot/FahrenheitSlope, i.e., 54.86399999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class TemperatureQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kelvin",
                  UnitLabel = "K",
                  SIUnitName = "kelvin",
                  ID = new Guid("8fc5fa10-2d89-4064-8ace-b852d9a8d31f"),
                  ConversionFactorFromSIFormula = "Factors.Unit",
                  ConversionFactorFromSI = Factors.Unit,
                  ConversionBiasFromSIFormula = "0",
                  ConversionBiasFromSI = 0,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "celsius",
                  UnitLabel = "°C",
                  SIUnitName = "kelvin",
                  ID = new Guid("5d69048e-fe18-4923-9341-cb80c2ccf8cc"),
                  ConversionFactorFromSIFormula = "Factors.Unit",
                  ConversionFactorFromSI = Factors.Unit,
                  ConversionBiasFromSIFormula = "-Factors.ZeroCelsius",
                  ConversionBiasFromSI = -Factors.ZeroCelsius,
                  ConversionDescription = 
"[v] = a * [SI] + b"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit, i.e., 1"
 + Environment.NewLine + "b = -ZeroCelsius, i.e., -273.15"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "ZeroCelsius = 273.15 reference: https://www.nist.gov/pml/owm/si-units-temperature"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "fahrenheit",
                  UnitLabel = "°F",
                  SIUnitName = "kelvin",
                  ID = new Guid("55c289ab-6975-439f-9b7a-fdca6d219a9f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.FahrenheitSlope",
                  ConversionFactorFromSI = 1.0/Factors.FahrenheitSlope,
                  ConversionBiasFromSIFormula = "-Factors.FahrenheitBias",
                  ConversionBiasFromSI = -Factors.FahrenheitBias,
                  ConversionDescription = 
"[v] = a * [SI] + b"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/FahrenheitSlope, i.e., 1.7999999999999998"
 + Environment.NewLine + "b = -FahrenheitBias, i.e., -459.67"
 + Environment.NewLine + "and"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "FahrenheitBias = 459.67 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "rankine",
                  UnitLabel = "°R",
                  SIUnitName = "kelvin",
                  ID = new Guid("b4d6c55d-cf05-46e1-a09b-d0b26eba634a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.FahrenheitSlope",
                  ConversionFactorFromSI = 1.0/Factors.FahrenheitSlope,
                  ConversionBiasFromSIFormula = "0",
                  ConversionBiasFromSI = 0,
                  ConversionDescription = 
"[v] = a * [SI] + b"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in rankine"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/FahrenheitSlope, i.e., 1.7999999999999998"
 + Environment.NewLine + "b = 0, i.e., 0"
 + Environment.NewLine + "and"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "réaumur",
                  UnitLabel = "°Ré",
                  SIUnitName = "kelvin",
                  ID = new Guid("968def6c-bc85-49b0-84a8-3ac7ad37efc6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.ReaumurSlope",
                  ConversionFactorFromSI = 1.0/Factors.ReaumurSlope,
                  ConversionBiasFromSIFormula = "-Factors.ReaumurBias",
                  ConversionBiasFromSI = -Factors.ReaumurBias,
                  ConversionDescription = 
"[v] = a * [SI] + b"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in réaumur"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/ReaumurSlope, i.e., 0.8"
 + Environment.NewLine + "b = -ReaumurBias, i.e., -218.51999999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "ReaumurSlope = 5.0 / 4.0 reference: https://en.wikipedia.org/wiki/R%C3%A9aumur_scale"
 + Environment.NewLine + "ReaumurBias = ZeroCelsius / ReaumurSlope"
 + Environment.NewLine + "ZeroCelsius = 273.15 reference: https://www.nist.gov/pml/owm/si-units-temperature"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ThermalConductivityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "watt per metre kelvin",
                  UnitLabel = "W/m•K",
                  SIUnitName = "watt per metre kelvin",
                  ID = new Guid("3ddba24f-4ccf-4cb1-af6c-2829cac3b88f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "calorie per metre second degree celsius",
                  UnitLabel = "cal/m•s•°C",
                  SIUnitName = "watt per metre kelvin",
                  ID = new Guid("d0386fc4-b97b-4874-8c8d-66e093c391ea"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Calorie",
                  ConversionFactorFromSI = 1.0/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per metre second degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Calorie, i.e., 0.2390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per centimetre second degree celsius",
                  UnitLabel = "cal/cm•s•°C",
                  SIUnitName = "watt per metre kelvin",
                  ID = new Guid("5f8706ed-d938-4715-a0ca-2afff423f6e6"),
                  ConversionFactorFromSIFormula = "Factors.Centi/Factors.Calorie",
                  ConversionFactorFromSI = Factors.Centi/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per centimetre second degree celsius"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/Calorie, i.e., 0.002390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per hour foot degree fahrenheit",
                  UnitLabel = "BTU/h•ft•°F",
                  SIUnitName = "watt per metre kelvin",
                  ID = new Guid("43169695-8f6e-42ad-8c07-566dc7651edb"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Foot*Factors.FahrenheitSlope/Factors.BTU",
                  ConversionFactorFromSI = Factors.Hour*Factors.Foot*Factors.FahrenheitSlope/Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per hour foot degree fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Foot*FahrenheitSlope/BTU, i.e., 0.5781761274719021"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit inch per hour square foot degree fahrenheit",
                  UnitLabel = "BTU•in/h•ft²•°F",
                  SIUnitName = "watt per metre kelvin",
                  ID = new Guid("c79c2b27-c956-49a3-9caf-8653017777ca"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Foot*Factors.Foot*Factors.FahrenheitSlope/(Factors.BTU*Factors.Inch)",
                  ConversionFactorFromSI = Factors.Hour*Factors.Foot*Factors.Foot*Factors.FahrenheitSlope/(Factors.BTU*Factors.Inch),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit inch per hour square foot degree fahrenheit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Foot*Foot*FahrenheitSlope/(BTU*Inch), i.e., 6.938113529662824"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ThermalConductivityGradientPerTemperatureQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "watt per metre kelvin per kelvin",
                  UnitLabel = "(W/(m•K))/K",
                  SIUnitName = "watt per metre kelvin per kelvin",
                  ID = new Guid("0459940e-d71f-4b01-9ea6-eeb05d754af2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "calorie per metre second degree celsius squared",
                  UnitLabel = "Cal/m•s•°C²",
                  SIUnitName = "watt per metre kelvin per kelvin",
                  ID = new Guid("eb08ff8c-d542-440f-a4c7-610653018910"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Calorie",
                  ConversionFactorFromSI = 1.0/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per metre second degree celsius squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Calorie, i.e., 0.2390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie per centimetre second degree celsius squared",
                  UnitLabel = "Cal/cm•s•°C²",
                  SIUnitName = "watt per metre kelvin per kelvin",
                  ID = new Guid("6c21a6cd-61fe-4086-95a7-ad6d6820c96e"),
                  ConversionFactorFromSIFormula = "Factors.Centi/Factors.Calorie",
                  ConversionFactorFromSI = Factors.Centi/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie per centimetre second degree celsius squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/Calorie, i.e., 0.002390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit per hour foot degree fahrenheit squared",
                  UnitLabel = "BTU/h•ft•°F²",
                  SIUnitName = "watt per metre kelvin per kelvin",
                  ID = new Guid("b79509ea-8c03-4538-9974-208f7e0ee40e"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Foot*Factors.FahrenheitSlope*Factors.FahrenheitSlope/Factors.BTU",
                  ConversionFactorFromSI = Factors.Hour*Factors.Foot*Factors.FahrenheitSlope*Factors.FahrenheitSlope/Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit per hour foot degree fahrenheit squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Foot*FahrenheitSlope*FahrenheitSlope/BTU, i.e., 0.3212089597066123"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit inch per hour square foot degree fahrenheit squared",
                  UnitLabel = "BTU•in/h•ft²•°F²",
                  SIUnitName = "watt per metre kelvin per kelvin",
                  ID = new Guid("918b4e34-3986-427f-8bb6-c09740a7c299"),
                  ConversionFactorFromSIFormula = "Factors.Hour*Factors.Foot*Factors.Foot*Factors.FahrenheitSlope*Factors.FahrenheitSlope/(Factors.BTU*Factors.Inch)",
                  ConversionFactorFromSI = Factors.Hour*Factors.Foot*Factors.Foot*Factors.FahrenheitSlope*Factors.FahrenheitSlope/(Factors.BTU*Factors.Inch),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit inch per hour square foot degree fahrenheit squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour*Foot*Foot*FahrenheitSlope*FahrenheitSlope/(BTU*Inch), i.e., 3.8545075164793468"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class TimeQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "second",
                  UnitLabel = "s",
                  SIUnitName = "second",
                  ID = new Guid("eac42b09-cc85-4e29-9aaf-05fe73bca2aa"),
                  ConversionFactorFromSIFormula = "1.0",
                  ConversionFactorFromSI = 1.0,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "millisecond",
                  UnitLabel = "ms",
                  SIUnitName = "second",
                  ID = new Guid("1c1b150f-80a0-47da-836c-a583c4fa4b74"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millisecond"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microsecond",
                  UnitLabel = "µs",
                  SIUnitName = "second",
                  ID = new Guid("18cf5c8f-bdd4-4575-a74b-f8321c567edb"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microsecond"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "shake",
                  UnitLabel = "shake",
                  SIUnitName = "second",
                  ID = new Guid("f2b06fdd-ddfe-430b-8107-11597bdfdf2f"),
                  ConversionFactorFromSIFormula = "1.0/(10.0*Factors.Nano)",
                  ConversionFactorFromSI = 1.0/(10.0*Factors.Nano),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in shake"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(10.0*Nano), i.e., 100000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanosecond",
                  UnitLabel = "ns",
                  SIUnitName = "second",
                  ID = new Guid("6bf1a718-637c-4e86-ae3e-426d2a1a9195"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanosecond"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "picosecond",
                  UnitLabel = "ps",
                  SIUnitName = "second",
                  ID = new Guid("9e10f905-4dc5-4670-9adf-278afd7d4131"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in picosecond"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pico, i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "minute",
                  UnitLabel = "min",
                  SIUnitName = "second",
                  ID = new Guid("4b9dc241-388b-4b7a-b862-48db43234c4a"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Minute",
                  ConversionFactorFromSI = 1.0/Factors.Minute,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Minute, i.e., 0.016666666666666666"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hour",
                  UnitLabel = "h",
                  SIUnitName = "second",
                  ID = new Guid("f0d815e4-9bef-4422-94e6-1de52216b611"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Hour",
                  ConversionFactorFromSI = 1.0/Factors.Hour,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Hour, i.e., 0.0002777777777777778"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "day",
                  UnitLabel = "d",
                  SIUnitName = "second",
                  ID = new Guid("85442621-bb56-4e2a-8e77-2b72409ff84f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Day",
                  ConversionFactorFromSI = 1.0/Factors.Day,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Day, i.e., 1.1574074074074073E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "week",
                  UnitLabel = "week",
                  SIUnitName = "second",
                  ID = new Guid("4dd50f01-60b3-4d44-82ea-ff8ededd797d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Week",
                  ConversionFactorFromSI = 1.0/Factors.Week,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in week"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Week, i.e., 1.6534391534391535E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Week = 7.0 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "fortnight",
                  UnitLabel = "14d",
                  SIUnitName = "second",
                  ID = new Guid("bc87f864-3dc1-4f1a-87bc-4123a47c53dc"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Fortnight",
                  ConversionFactorFromSI = 1.0/Factors.Fortnight,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in fortnight"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Fortnight, i.e., 8.267195767195768E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Fortnight = 14.0 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "month common",
                  UnitLabel = "month common",
                  SIUnitName = "second",
                  ID = new Guid("41cceaa2-1a1d-40f1-9195-5183be9770d4"),
                  ConversionFactorFromSIFormula = "1.0/Factors.MonthCommon",
                  ConversionFactorFromSI = 1.0/Factors.MonthCommon,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in month common"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/MonthCommon, i.e., 3.802570537683474E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "MonthCommon = YearJulian / 12.0"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "month sideral",
                  UnitLabel = "month sideral",
                  SIUnitName = "second",
                  ID = new Guid("2e7446c0-5b0e-44e1-9a27-f0bc7d8aeb98"),
                  ConversionFactorFromSIFormula = "1.0/Factors.MonthSideral",
                  ConversionFactorFromSI = 1.0/Factors.MonthSideral,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in month sideral"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/MonthSideral, i.e., 4.2362265228665E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "MonthSideral = 27.32166 * Day reference: https://en.wikipedia.org/wiki/Month"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "month synodic",
                  UnitLabel = "month synodic",
                  SIUnitName = "second",
                  ID = new Guid("31edcda9-df8f-4d15-83a9-7dafd8a7e404"),
                  ConversionFactorFromSIFormula = "1.0/Factors.MonthSynodic",
                  ConversionFactorFromSI = 1.0/Factors.MonthSynodic,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in month synodic"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/MonthSynodic, i.e., 3.9193507729016165E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "MonthSynodic = 29.53059 * Day reference: https://en.wikipedia.org/wiki/Month"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "quarter common",
                  UnitLabel = "quarter common",
                  SIUnitName = "second",
                  ID = new Guid("71f0e01a-c1a2-49ba-a25b-c11854f8867c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.QuarterCommon",
                  ConversionFactorFromSI = 1.0/Factors.QuarterCommon,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in quarter common"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/QuarterCommon, i.e., 1.267523512561158E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "QuarterCommon = YearJulian / 4.0"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "year common",
                  UnitLabel = "y",
                  SIUnitName = "second",
                  ID = new Guid("38481414-3b9d-472d-ac31-04b00dcc9d5c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.YearCommon",
                  ConversionFactorFromSI = 1.0/Factors.YearCommon,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in year common"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/YearCommon, i.e., 3.1709791983764586E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearCommon = 365 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "year average gregorian",
                  UnitLabel = "year average gregorian",
                  SIUnitName = "second",
                  ID = new Guid("fc33008b-9517-440f-a56b-189c5d80621b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.YearAverageGregorian",
                  ConversionFactorFromSI = 1.0/Factors.YearAverageGregorian,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in year average gregorian"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/YearAverageGregorian, i.e., 3.1709791983764586E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearAverageGregorian = (365.0 + 97 / 400) * Day reference: https://en.wikipedia.org/wiki/Gregorian_calendar"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "year julian",
                  UnitLabel = "year julian",
                  SIUnitName = "second",
                  ID = new Guid("281f6c7b-da23-4aab-89e1-994e52280658"),
                  ConversionFactorFromSIFormula = "1.0/Factors.YearJulian",
                  ConversionFactorFromSI = 1.0/Factors.YearJulian,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in year julian"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/YearJulian, i.e., 3.168808781402895E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "year leap",
                  UnitLabel = "year leap",
                  SIUnitName = "second",
                  ID = new Guid("c84c1293-82d4-481b-8f6e-8bb8b81e6273"),
                  ConversionFactorFromSIFormula = "1.0/Factors.YearLeap",
                  ConversionFactorFromSI = 1.0/Factors.YearLeap,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in year leap"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/YearLeap, i.e., 3.1623153207852664E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearLeap = 366 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "year tropical",
                  UnitLabel = "year tropical",
                  SIUnitName = "second",
                  ID = new Guid("e93c0b95-68b1-4ecc-9b27-f07a9a53ad49"),
                  ConversionFactorFromSIFormula = "1.0/Factors.YearTropical",
                  ConversionFactorFromSI = 1.0/Factors.YearTropical,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in year tropical"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/YearTropical, i.e., 3.1688764535078565E-08"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearTropical = 365.2422 * Day reference: https://www.grc.nasa.gov/www/k-12/Numbers/Math/Mathematical_Thinking/calendar_calculations.htm"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decade",
                  UnitLabel = "decade",
                  SIUnitName = "second",
                  ID = new Guid("b7d3b041-7119-45a6-a5ea-e05d7cb3c68b"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Decade",
                  ConversionFactorFromSI = 1.0/Factors.Decade,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decade"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Decade, i.e., 3.168808781402895E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Decade = 10.0 * YearJulian"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "century",
                  UnitLabel = "century",
                  SIUnitName = "second",
                  ID = new Guid("5cf296b6-48bf-4cc1-bf79-0220100ef1db"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Century",
                  ConversionFactorFromSI = 1.0/Factors.Century,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in century"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Century, i.e., 3.168808781402895E-10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Century = 10.0 * Decade"
 + Environment.NewLine + "Decade = 10.0 * YearJulian"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millenia",
                  UnitLabel = "millenia",
                  SIUnitName = "second",
                  ID = new Guid("c235c8fc-f15b-45ff-a1b7-aab46ccea159"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Millenia",
                  ConversionFactorFromSI = 1.0/Factors.Millenia,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millenia"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Millenia, i.e., 3.168808781402895E-11"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Millenia = 10.0 * Century"
 + Environment.NewLine + "Century = 10.0 * Decade"
 + Environment.NewLine + "Decade = 10.0 * YearJulian"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million year",
                  UnitLabel = "My",
                  SIUnitName = "second",
                  ID = new Guid("d0281a3c-86dd-4d05-b856-cb7fa67c0f4d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.MillionYear",
                  ConversionFactorFromSI = 1.0/Factors.MillionYear,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/MillionYear, i.e., 3.168808781402895E-14"
 + Environment.NewLine + "and"
 + Environment.NewLine + "MillionYear = 1000.0 * Millenia"
 + Environment.NewLine + "Millenia = 10.0 * Century"
 + Environment.NewLine + "Century = 10.0 * Decade"
 + Environment.NewLine + "Decade = 10.0 * YearJulian"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class TorqueGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "newton metre per metre",
                  UnitLabel = "N•m/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("33baa8d7-6987-4217-959b-1e3aa5b04752"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "decanewton metre per metre",
                  UnitLabel = "daN•m/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("50a1ea8d-9a46-4e24-9e9f-dad66e8bb9ca"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Deca",
                  ConversionFactorFromSI = Factors.Unit/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton metre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Deca, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram force metre per metre",
                  UnitLabel = "kgf•m/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("66f7449d-5a06-4dd0-bf27-0bed2d2e4bed"),
                  ConversionFactorFromSIFormula = "Factors.Unit/(Factors.KilogramForce)",
                  ConversionFactorFromSI = Factors.Unit/(Factors.KilogramForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram force metre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/(KilogramForce), i.e., 0.10197162129779283"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton metre per metre",
                  UnitLabel = "kN•m/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("d07e4c6c-fea3-4545-b020-9cc2402e1ca5"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Unit/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton metre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot pound per metre",
                  UnitLabel = "ft•lbf/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("e3b4fe22-6590-4b2d-b2fa-0250f1ca8b26"),
                  ConversionFactorFromSIFormula = "Factors.Unit/(Factors.PoundForce*Factors.Foot)",
                  ConversionFactorFromSI = Factors.Unit/(Factors.PoundForce*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot pound per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/(PoundForce*Foot), i.e., 0.7375621492772655"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilofoot pound per metre",
                  UnitLabel = "kft•lbf/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("e9bff76e-5388-4ea0-85af-62c772d919c5"),
                  ConversionFactorFromSIFormula = "Factors.Unit/(Factors.Kilo*Factors.PoundForce*Factors.Foot)",
                  ConversionFactorFromSI = Factors.Unit/(Factors.Kilo*Factors.PoundForce*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilofoot pound per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/(Kilo*PoundForce*Foot), i.e., 0.0007375621492772654"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton decimetre per metre",
                  UnitLabel = "N•dm/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("87ef9e2b-7e3b-4bda-a406-9f0b7f06e8fa"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Deci",
                  ConversionFactorFromSI = Factors.Unit/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton decimetre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton centimetre per metre",
                  UnitLabel = "N•cm/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("c03b845d-f2e5-4a16-afca-efab2591c526"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Centi",
                  ConversionFactorFromSI = Factors.Unit/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton centimetre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton millimetre per metre",
                  UnitLabel = "N•mm/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("fb1bb6bb-9c4a-4ecd-99fc-4af502271614"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Milli",
                  ConversionFactorFromSI = Factors.Unit/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton millimetre per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch pound per metre",
                  UnitLabel = "in•lbf/m",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("18259cf1-1f96-4ace-b7ad-657a78254baf"),
                  ConversionFactorFromSIFormula = "Factors.Unit/(Factors.Inch*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Unit/(Factors.Inch*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch pound per metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/(Inch*PoundForce), i.e., 8.850745791327185"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "Newton metre per decimetre",
                  UnitLabel = "N•m/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("5ceaa09f-0de4-4025-ba23-d3b76f55a8b1"),
                  ConversionFactorFromSIFormula = "Factors.Deci/Factors.Unit",
                  ConversionFactorFromSI = Factors.Deci/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in Newton metre per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/Unit, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton metre per decimetre",
                  UnitLabel = "daN•m/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("902dd7b3-0b4f-40a3-a089-02bb39367219"),
                  ConversionFactorFromSIFormula = "Factors.Deci/Factors.Deca",
                  ConversionFactorFromSI = Factors.Deci/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton metre per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/Deca, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram force metre per decimetre",
                  UnitLabel = "kgf•m/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("2c83dced-5b36-49f1-bd4a-c95d558fb868"),
                  ConversionFactorFromSIFormula = "Factors.Deci/(Factors.KilogramForce)",
                  ConversionFactorFromSI = Factors.Deci/(Factors.KilogramForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram force metre per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/(KilogramForce), i.e., 0.010197162129779284"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton metre per decimetre",
                  UnitLabel = "kN•m/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("a3949720-a023-4c5d-9a5e-4194af30005f"),
                  ConversionFactorFromSIFormula = "Factors.Deci/(Factors.Kilo*Factors.Unit)",
                  ConversionFactorFromSI = Factors.Deci/(Factors.Kilo*Factors.Unit),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton metre per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/(Kilo*Unit), i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot pound per decimetre",
                  UnitLabel = "ft•lbf/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("a6b11edb-e9bc-4a7e-9af9-ace7ca62b93b"),
                  ConversionFactorFromSIFormula = "Factors.Deci/(Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Deci/(Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot pound per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/(Foot*PoundForce), i.e., 0.07375621492772655"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilofoot pound per decimetre",
                  UnitLabel = "kft•lbf/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("92cb8e61-c58d-461a-a69c-ad9fe7324e2a"),
                  ConversionFactorFromSIFormula = "Factors.Deci/(Factors.Kilo*Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Deci/(Factors.Kilo*Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilofoot pound per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/(Kilo*Foot*PoundForce), i.e., 7.375621492772657E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton decimetre per decimetre",
                  UnitLabel = "N•dm/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("61261367-5cb0-4038-bcfb-6c8395758a21"),
                  ConversionFactorFromSIFormula = "Factors.Deci/(Factors.Deci*Factors.Unit)",
                  ConversionFactorFromSI = Factors.Deci/(Factors.Deci*Factors.Unit),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton decimetre per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/(Deci*Unit), i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton centimetre per decimetre",
                  UnitLabel = "N•cm/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("1eee8ef4-cb7b-451a-9658-d1704ccf81d2"),
                  ConversionFactorFromSIFormula = "Factors.Deci/(Factors.Centi*Factors.Unit)",
                  ConversionFactorFromSI = Factors.Deci/(Factors.Centi*Factors.Unit),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton centimetre per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/(Centi*Unit), i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton millimetre per decimetre",
                  UnitLabel = "N•mm/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("6c49e6aa-7d4c-4c92-96e5-5e3f26c3a367"),
                  ConversionFactorFromSIFormula = "Factors.Deci/(Factors.Milli*Factors.Unit)",
                  ConversionFactorFromSI = Factors.Deci/(Factors.Milli*Factors.Unit),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton millimetre per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/(Milli*Unit), i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch pound per decimetre",
                  UnitLabel = "in•lbf/dm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("e638f5ee-bbf9-4e7b-ae6a-9613eb9792cc"),
                  ConversionFactorFromSIFormula = "Factors.Deci/(Factors.Inch*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Deci/(Factors.Inch*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch pound per decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci/(Inch*PoundForce), i.e., 0.8850745791327186"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "Newton metre per centimetre",
                  UnitLabel = "N•m/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("d8c63694-bf19-48be-b9bd-0f5b462ce2ec"),
                  ConversionFactorFromSIFormula = "Factors.Centi/(Factors.Unit*Factors.Unit)",
                  ConversionFactorFromSI = Factors.Centi/(Factors.Unit*Factors.Unit),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in Newton metre per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/(Unit*Unit), i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton metre per centimetre",
                  UnitLabel = "daN•m/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("e87d21e6-2191-4cee-aea8-1929df1d8bd0"),
                  ConversionFactorFromSIFormula = "Factors.Centi/(Factors.Deca)",
                  ConversionFactorFromSI = Factors.Centi/(Factors.Deca),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton metre per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/(Deca), i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram force metre per centimetre",
                  UnitLabel = "kgf•m/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("6ee38a6b-907d-4de9-94f1-0d979ef58340"),
                  ConversionFactorFromSIFormula = "Factors.Centi/(Factors.KilogramForce)",
                  ConversionFactorFromSI = Factors.Centi/(Factors.KilogramForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram force metre per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/(KilogramForce), i.e., 0.0010197162129779284"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton metre per centimetre",
                  UnitLabel = "kN•m/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("2149c60b-d6a8-4056-9818-f7fe6d10c409"),
                  ConversionFactorFromSIFormula = "Factors.Centi/(Factors.Kilo)",
                  ConversionFactorFromSI = Factors.Centi/(Factors.Kilo),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton metre per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/(Kilo), i.e., 1E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot pound per centimetre",
                  UnitLabel = "ft•lbf/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("730e5c03-816e-4f88-b7bf-632a8a30c3ca"),
                  ConversionFactorFromSIFormula = "Factors.Centi/(Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Centi/(Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot pound per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/(Foot*PoundForce), i.e., 0.007375621492772655"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilofoot pound per centimetre",
                  UnitLabel = "kft•lbf/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("6249a894-93d9-45b6-a188-eb2d4bef800e"),
                  ConversionFactorFromSIFormula = "Factors.Centi/(Factors.Kilo*Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Centi/(Factors.Kilo*Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilofoot pound per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/(Kilo*Foot*PoundForce), i.e., 7.3756214927726565E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton decimetre per centimetre",
                  UnitLabel = "N•dm/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("0dbdd140-66d3-4f47-bbea-f5025b804b20"),
                  ConversionFactorFromSIFormula = "Factors.Centi/(Factors.Deci)",
                  ConversionFactorFromSI = Factors.Centi/(Factors.Deci),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton decimetre per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/(Deci), i.e., 0.09999999999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton centimetre per centimetre",
                  UnitLabel = "N•cm/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("2f7c8e32-f865-4b68-8a3c-4d8c862fd5f2"),
                  ConversionFactorFromSIFormula = "Factors.Centi/Factors.Centi",
                  ConversionFactorFromSI = Factors.Centi/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton centimetre per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/Centi, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton millimetre per centimetre",
                  UnitLabel = "N•mm/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("830ae4b8-76d5-404a-b0c7-90db357a68ec"),
                  ConversionFactorFromSIFormula = "Factors.Centi/Factors.Milli",
                  ConversionFactorFromSI = Factors.Centi/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton millimetre per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/Milli, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch pound per centimetre",
                  UnitLabel = "in•lbf/cm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("6822172d-adf0-4a71-b883-f4bc825ee9ea"),
                  ConversionFactorFromSIFormula = "Factors.Centi/(Factors.Inch*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Centi/(Factors.Inch*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch pound per centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi/(Inch*PoundForce), i.e., 0.08850745791327186"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "Newton metre per millimetre",
                  UnitLabel = "N•m/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("a6416087-d525-4d98-aa45-2006ceb4a474"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.Unit*Factors.Unit)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.Unit*Factors.Unit),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in Newton metre per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(Unit*Unit), i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton metre per millimetre",
                  UnitLabel = "daN•m/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("6acab23d-3952-4eed-b1a0-7c38f03109b0"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.Deca)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.Deca),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton metre per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(Deca), i.e., 0.0001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram force metre per millimetre",
                  UnitLabel = "kgf•m/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("cdd4e6aa-ee0b-4679-97be-82553960efd1"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.KilogramForce)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.KilogramForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram force metre per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(KilogramForce), i.e., 0.00010197162129779284"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton metre per millimetre",
                  UnitLabel = "kN•m/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("1335bebf-fcda-4a39-afa8-7de3ed24fa0c"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.Kilo)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.Kilo),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton metre per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(Kilo), i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot pound per millimetre",
                  UnitLabel = "ft•lbf/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("73a284d2-8900-44bb-96ab-897416a525e1"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot pound per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(Foot*PoundForce), i.e., 0.0007375621492772656"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilofoot pound per millimetre",
                  UnitLabel = "kft•lbf/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("bad7b651-25f9-4687-875f-7624388228d6"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.Kilo*Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.Kilo*Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilofoot pound per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(Kilo*Foot*PoundForce), i.e., 7.375621492772656E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton decimetre per millimetre",
                  UnitLabel = "N•dm/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("ecfa262e-1242-4c36-8325-b98de1ef4ffd"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.Deci)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.Deci),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton decimetre per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(Deci), i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton centimetre per millimetre",
                  UnitLabel = "N•cm/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("0f0cd3a8-84ec-4b58-b100-3f413bea1e05"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Centi",
                  ConversionFactorFromSI = Factors.Milli/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton centimetre per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Centi, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton millimetre per millimetre",
                  UnitLabel = "N•mm/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("b20d7cec-c1f6-4f64-9b60-e77ea699d940"),
                  ConversionFactorFromSIFormula = "Factors.Milli/Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton millimetre per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/Milli, i.e., 1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch pound per millimetre",
                  UnitLabel = "in•lbf/mm",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("cd28eba2-c7ea-40d0-ac32-fb67a8f581bc"),
                  ConversionFactorFromSIFormula = "Factors.Milli/(Factors.Inch*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Milli/(Factors.Inch*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch pound per millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli/(Inch*PoundForce), i.e., 0.008850745791327186"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "Newton metre per foot",
                  UnitLabel = "N•m/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("2ce8e697-3a8a-4a73-ac23-4730790b4812"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.Unit",
                  ConversionFactorFromSI = Factors.Foot/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in Newton metre per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/Unit, i.e., 0.30479999999999996"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton metre per foot",
                  UnitLabel = "daN•m/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("c6e8f7e7-0239-47bc-b230-0f5870c94b82"),
                  ConversionFactorFromSIFormula = "Factors.Foot/(Factors.Deca)",
                  ConversionFactorFromSI = Factors.Foot/(Factors.Deca),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton metre per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/(Deca), i.e., 0.030479999999999997"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram force metre per foot",
                  UnitLabel = "kgf•m/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("7b2d82cc-0ac5-4945-9914-c91e62ac61dd"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.KilogramForce",
                  ConversionFactorFromSI = Factors.Foot/Factors.KilogramForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram force metre per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/KilogramForce, i.e., 0.03108095017156725"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton metre per foot",
                  UnitLabel = "kN•m/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("8b5be3db-bc7a-4107-b751-53d3d2772eb8"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Foot/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton metre per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/Kilo, i.e., 0.0003048"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot pound per foot",
                  UnitLabel = "ft•lbf/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("85a75741-c967-4e10-b195-01e5e7297eda"),
                  ConversionFactorFromSIFormula = "Factors.Foot/(Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Foot/(Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot pound per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/(Foot*PoundForce), i.e., 0.2248089430997105"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilofoot pound per foot",
                  UnitLabel = "kft•lbf/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("65606e85-199d-4fee-8cd4-97715431d868"),
                  ConversionFactorFromSIFormula = "Factors.Foot/(Factors.Kilo*Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Foot/(Factors.Kilo*Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilofoot pound per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/(Kilo*Foot*PoundForce), i.e., 0.00022480894309971053"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton decimetre per foot",
                  UnitLabel = "N•dm/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("cdd6f7a0-954c-4826-8263-bb2d7fb06764"),
                  ConversionFactorFromSIFormula = "Factors.Foot/(Factors.Deci)",
                  ConversionFactorFromSI = Factors.Foot/(Factors.Deci),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton decimetre per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/(Deci), i.e., 3.0479999999999996"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton centimetre per foot",
                  UnitLabel = "N•cm/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("1767c385-e868-457a-b0be-aac0a4db42ff"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.Centi",
                  ConversionFactorFromSI = Factors.Foot/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton centimetre per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/Centi, i.e., 30.479999999999997"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton millimetre per foot",
                  UnitLabel = "N•mm/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("ba4691ad-7575-4b9d-a6c6-9c98dde239ca"),
                  ConversionFactorFromSIFormula = "Factors.Foot/Factors.Milli",
                  ConversionFactorFromSI = Factors.Foot/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton millimetre per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/Milli, i.e., 304.79999999999995"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch pound per foot",
                  UnitLabel = "in•lbf/ft",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("d5f1dfc6-80ec-4780-a4ad-8df68c179eee"),
                  ConversionFactorFromSIFormula = "Factors.Foot/(Factors.Inch*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Foot/(Factors.Inch*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch pound per foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot/(Inch*PoundForce), i.e., 2.697707317196526"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "Newton metre per inch",
                  UnitLabel = "N•m/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("394cc997-ae71-47d1-91be-8aa69fdb71d7"),
                  ConversionFactorFromSIFormula = "Factors.Inch/Factors.Unit",
                  ConversionFactorFromSI = Factors.Inch/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in Newton metre per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/Unit, i.e., 0.0254"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decanewton metre per inch",
                  UnitLabel = "daN•m/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("1f8786b1-4aae-45b9-9875-7fe63bddb6cb"),
                  ConversionFactorFromSIFormula = "Factors.Inch/Factors.Deca",
                  ConversionFactorFromSI = Factors.Inch/Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton metre per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/Deca, i.e., 0.0025399999999999997"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram force metre per inch",
                  UnitLabel = "kgf•m/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("df62fa6d-b983-4960-ad7b-853e00ccf45c"),
                  ConversionFactorFromSIFormula = "Factors.Inch/Factors.KilogramForce",
                  ConversionFactorFromSI = Factors.Inch/Factors.KilogramForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram force metre per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/KilogramForce, i.e., 0.0025900791809639378"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton metre per inch",
                  UnitLabel = "kN•m/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("cbc02a54-98e8-4b10-a028-152a5c92f2ce"),
                  ConversionFactorFromSIFormula = "Factors.Inch/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Inch/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton metre per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/Kilo, i.e., 2.5399999999999997E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot pound per inch",
                  UnitLabel = "ft•lbf/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("9c9771ff-d194-4e9f-b663-7f817da4d207"),
                  ConversionFactorFromSIFormula = "Factors.Inch/(Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Inch/(Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot pound per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/(Foot*PoundForce), i.e., 0.018734078591642542"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilofoot pound per inch",
                  UnitLabel = "kft•lbf/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("70978437-cf05-4138-8389-ec633fdc1fce"),
                  ConversionFactorFromSIFormula = "Factors.Inch/(Factors.Kilo*Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Inch/(Factors.Kilo*Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilofoot pound per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/(Kilo*Foot*PoundForce), i.e., 1.8734078591642546E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton decimetre per inch",
                  UnitLabel = "N•dm/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("0f34a9e2-dc04-4ce7-ac42-6cc12e2c98b5"),
                  ConversionFactorFromSIFormula = "Factors.Inch/Factors.Deci",
                  ConversionFactorFromSI = Factors.Inch/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton decimetre per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/Deci, i.e., 0.25399999999999995"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton centimetre per inch",
                  UnitLabel = "N•cm/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("622d36f4-6fed-4d16-a246-14477f724bca"),
                  ConversionFactorFromSIFormula = "Factors.Inch/Factors.Centi",
                  ConversionFactorFromSI = Factors.Inch/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton centimetre per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/Centi, i.e., 2.54"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton millimetre per inch",
                  UnitLabel = "N•mm/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("31169945-1b67-4225-a2c6-6e850c39cb2f"),
                  ConversionFactorFromSIFormula = "Factors.Inch/Factors.Milli",
                  ConversionFactorFromSI = Factors.Inch/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton millimetre per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/Milli, i.e., 25.4"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch pound per inch",
                  UnitLabel = "in•lbf/in",
                  SIUnitName = "newton metre per metre",
                  ID = new Guid("2e16e0be-2037-413d-9f43-6316a24d1fca"),
                  ConversionFactorFromSIFormula = "Factors.Inch/(Factors.Inch*Factors.PoundForce)",
                  ConversionFactorFromSI = Factors.Inch/(Factors.Inch*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch pound per inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch/(Inch*PoundForce), i.e., 0.2248089430997105"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class TorqueQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "newton metre",
                  UnitLabel = "N•m",
                  SIUnitName = "newton metre",
                  ID = new Guid("50b017fa-8d81-4076-a485-61de1d8301b5"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "decanewton metre",
                  UnitLabel = "daN•m",
                  SIUnitName = "newton metre",
                  ID = new Guid("501ce02c-8a5d-46e6-9ab6-ce443df70402"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deca)",
                  ConversionFactorFromSI = 1.0/(Factors.Deca),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decanewton metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Deca), i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilogram force metre",
                  UnitLabel = "kgf•m",
                  SIUnitName = "newton metre",
                  ID = new Guid("282f97a0-df2a-4016-9ab0-796db49ff384"),
                  ConversionFactorFromSIFormula = "1.0/ Factors.KilogramForce",
                  ConversionFactorFromSI = 1.0/ Factors.KilogramForce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilogram force metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/ KilogramForce, i.e., 0.10197162129779283"
 + Environment.NewLine + "and"
 + Environment.NewLine + "KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilonewton metre",
                  UnitLabel = "kN•m",
                  SIUnitName = "newton metre",
                  ID = new Guid("2e417a6e-1acc-4901-8704-7dfeb3f67546"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilonewton metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot pound",
                  UnitLabel = "ft•lbf",
                  SIUnitName = "newton metre",
                  ID = new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = 1.0/(Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot pound"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Foot*PoundForce), i.e., 0.7375621492772655"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilofoot pound",
                  UnitLabel = "kft•lbf",
                  SIUnitName = "newton metre",
                  ID = new Guid("ee9be6ed-df75-4915-be6a-e3941dacd6bd"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.Foot*Factors.PoundForce)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.Foot*Factors.PoundForce),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilofoot pound"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*Foot*PoundForce), i.e., 0.0007375621492772656"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton decimetre",
                  UnitLabel = "N•dm",
                  SIUnitName = "newton metre",
                  ID = new Guid("e70db590-c5fb-4ab9-a2c4-3ad611cb7f63"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deci",
                  ConversionFactorFromSI = 1.0/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton centimetre",
                  UnitLabel = "N•cm",
                  SIUnitName = "newton metre",
                  ID = new Guid("4acf4542-8df0-4f57-a852-7c0184dbeec9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "newton millimetre",
                  UnitLabel = "N•mm",
                  SIUnitName = "newton metre",
                  ID = new Guid("a933225d-7c8e-4ce4-b0ea-4c1c6e9f7e34"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in newton millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch pound",
                  UnitLabel = "in•lbf",
                  SIUnitName = "newton metre",
                  ID = new Guid("0d40553e-d8c4-4b75-ad05-61199b15a0a1"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.PoundForce*Factors.Inch)",
                  ConversionFactorFromSI = 1.0/(Factors.PoundForce*Factors.Inch),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch pound"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(PoundForce*Inch), i.e., 8.850745791327185"
 + Environment.NewLine + "and"
 + Environment.NewLine + "PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class VelocityQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "metre per second",
                  UnitLabel = "m/s",
                  SIUnitName = "metre per second",
                  ID = new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "metre per minute",
                  UnitLabel = "m/min",
                  SIUnitName = "metre per second",
                  ID = new Guid("824d3b5b-1e51-446a-99a4-39c02377f303"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Unit",
                  ConversionFactorFromSI = Factors.Minute/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in metre per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Unit, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per second",
                  UnitLabel = "cm/s",
                  SIUnitName = "metre per second",
                  ID = new Guid("d32f84d7-f076-49ab-8bd5-1ccd27e0eba6"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Centi",
                  ConversionFactorFromSI = Factors.Unit/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "metre per hour",
                  UnitLabel = "m/h",
                  SIUnitName = "metre per second",
                  ID = new Guid("b4867c19-0668-4043-b3b9-f666f7552b02"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Unit",
                  ConversionFactorFromSI = Factors.Hour/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in metre per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Unit, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "metre per day",
                  UnitLabel = "m/d",
                  SIUnitName = "metre per second",
                  ID = new Guid("aa10055f-1ef6-460d-841c-b6dc69f6a7f2"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Unit",
                  ConversionFactorFromSI = Factors.Day/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in metre per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Unit, i.e., 86400"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per hour",
                  UnitLabel = "ft/h",
                  SIUnitName = "metre per second",
                  ID = new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Foot",
                  ConversionFactorFromSI = Factors.Hour/Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Foot, i.e., 11811.023622047245"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per day",
                  UnitLabel = "ft/d",
                  SIUnitName = "metre per second",
                  ID = new Guid("aa58ec87-0dbc-4ed4-b8aa-8553b02c7b14"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Foot",
                  ConversionFactorFromSI = Factors.Day/Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Foot, i.e., 283464.5669291339"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per minute",
                  UnitLabel = "ft/m",
                  SIUnitName = "metre per second",
                  ID = new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Foot",
                  ConversionFactorFromSI = Factors.Minute/Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Foot, i.e., 196.85039370078744"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "foot per second",
                  UnitLabel = "ft/s",
                  SIUnitName = "metre per second",
                  ID = new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Foot",
                  ConversionFactorFromSI = Factors.Unit/Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in foot per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Foot, i.e., 3.280839895013124"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per second",
                  UnitLabel = "in/s",
                  SIUnitName = "metre per second",
                  ID = new Guid("8cd16c97-5c7a-4ee9-b59b-cbe2decd8ff9"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Inch",
                  ConversionFactorFromSI = Factors.Unit/Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Inch, i.e., 39.37007874015748"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mile per hour",
                  UnitLabel = "mph",
                  SIUnitName = "metre per second",
                  ID = new Guid("6c6d0be3-5b60-4b8a-9fd6-8b7afb261081"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Mile",
                  ConversionFactorFromSI = Factors.Hour/Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mile per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Mile, i.e., 2.2369362920544025"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per hour",
                  UnitLabel = "km/h",
                  SIUnitName = "metre per second",
                  ID = new Guid("a1bab5e0-221c-4555-bd37-cf2b8004fd53"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Hour/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilometre per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Kilo, i.e., 3.6"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per minute",
                  UnitLabel = "km/min",
                  SIUnitName = "metre per second",
                  ID = new Guid("b37519e1-5d78-4d34-ad7b-37bc3f0bc775"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Minute/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilometre per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Kilo, i.e., 0.06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per second",
                  UnitLabel = "km/s",
                  SIUnitName = "metre per second",
                  ID = new Guid("3944bb76-5675-49bf-ae2f-143d3ff8e41a"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Unit/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilometre per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilometre per day",
                  UnitLabel = "km/d",
                  SIUnitName = "metre per second",
                  ID = new Guid("2d09bf7b-0f99-42c0-9732-f9923c11bde1"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Kilo",
                  ConversionFactorFromSI = Factors.Day/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilometre per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Kilo, i.e., 86.4"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mile per minute",
                  UnitLabel = "mi/min",
                  SIUnitName = "metre per second",
                  ID = new Guid("959dcb48-193b-48a9-9b86-554ea6b6e755"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Mile",
                  ConversionFactorFromSI = Factors.Minute/Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mile per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Mile, i.e., 0.03728227153424004"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mile per second",
                  UnitLabel = "mi/s",
                  SIUnitName = "metre per second",
                  ID = new Guid("5ec77a90-200b-4e6e-877b-8df0edb7adc2"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Mile",
                  ConversionFactorFromSI = Factors.Unit/Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mile per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Mile, i.e., 0.000621371192237334"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mile per day",
                  UnitLabel = "mi/d",
                  SIUnitName = "metre per second",
                  ID = new Guid("340ef6b0-53c2-447c-b8dd-f8f184bce71d"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Mile",
                  ConversionFactorFromSI = Factors.Day/Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mile per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Mile, i.e., 53.68647100930566"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per minute",
                  UnitLabel = "in/min",
                  SIUnitName = "metre per second",
                  ID = new Guid("d6421f59-0d0f-49e3-9f2c-37590569beb4"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Inch",
                  ConversionFactorFromSI = Factors.Minute/Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Inch, i.e., 2362.2047244094488"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per hour",
                  UnitLabel = "in/h",
                  SIUnitName = "metre per second",
                  ID = new Guid("06115ddb-4f51-41cd-a502-8c4f443d66b2"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Inch",
                  ConversionFactorFromSI = Factors.Hour/Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Inch, i.e., 141732.28346456692"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "inch per day",
                  UnitLabel = "in/d",
                  SIUnitName = "metre per second",
                  ID = new Guid("38991fcc-56f6-4447-bd1e-86159681e8d0"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Inch",
                  ConversionFactorFromSI = Factors.Day/Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in inch per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Inch, i.e., 3401574.8031496066"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per minute",
                  UnitLabel = "cm/min",
                  SIUnitName = "metre per second",
                  ID = new Guid("b52fb69d-f8f7-4e46-9223-626e7497854d"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Centi",
                  ConversionFactorFromSI = Factors.Minute/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Centi, i.e., 6000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per hour",
                  UnitLabel = "cm/h",
                  SIUnitName = "metre per second",
                  ID = new Guid("9a4d693e-cb18-4587-a465-48aec69369bf"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Centi",
                  ConversionFactorFromSI = Factors.Hour/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Centi, i.e., 360000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centimetre per day",
                  UnitLabel = "cm/d",
                  SIUnitName = "metre per second",
                  ID = new Guid("d34eba86-b8e2-4f28-92bb-8a26132ccfc6"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Centi",
                  ConversionFactorFromSI = Factors.Day/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centimetre per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Centi, i.e., 8640000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre per second",
                  UnitLabel = "mm/s",
                  SIUnitName = "metre per second",
                  ID = new Guid("8d787bbf-81b0-4ba4-b913-c71cfe4b7025"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Milli",
                  ConversionFactorFromSI = Factors.Unit/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre per minute",
                  UnitLabel = "mm/min",
                  SIUnitName = "metre per second",
                  ID = new Guid("87a2da8b-a5e8-43f4-af18-859f6e8dc822"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Milli",
                  ConversionFactorFromSI = Factors.Minute/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Milli, i.e., 60000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre per hour",
                  UnitLabel = "mm/h",
                  SIUnitName = "metre per second",
                  ID = new Guid("4628ccfb-2837-40b3-9141-222af23fa7be"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Milli",
                  ConversionFactorFromSI = Factors.Hour/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Milli, i.e., 3600000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millimetre per day",
                  UnitLabel = "mm/d",
                  SIUnitName = "metre per second",
                  ID = new Guid("c1540a11-a20e-43e2-9d1b-e173b928c94b"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Milli",
                  ConversionFactorFromSI = Factors.Day/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millimetre per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Milli, i.e., 86400000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decimetre per second",
                  UnitLabel = "dm/s",
                  SIUnitName = "metre per second",
                  ID = new Guid("0f9aa2e1-b66f-4728-bf57-79526ffce563"),
                  ConversionFactorFromSIFormula = "Factors.Unit/Factors.Deci",
                  ConversionFactorFromSI = Factors.Unit/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimetre per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Unit/Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decimetre per minute",
                  UnitLabel = "dm/min",
                  SIUnitName = "metre per second",
                  ID = new Guid("980c51cc-a185-44a6-a69c-34f52e2b1fe2"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Deci",
                  ConversionFactorFromSI = Factors.Minute/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimetre per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Deci, i.e., 600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decimetre per hour",
                  UnitLabel = "dm/h",
                  SIUnitName = "metre per second",
                  ID = new Guid("1d3b5a3c-81ff-4698-b92f-9b721f946220"),
                  ConversionFactorFromSIFormula = "Factors.Hour/Factors.Deci",
                  ConversionFactorFromSI = Factors.Hour/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimetre per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/Deci, i.e., 36000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decimetre per day",
                  UnitLabel = "dm/d",
                  SIUnitName = "metre per second",
                  ID = new Guid("dcb77826-7550-4681-b3ce-a59cfdb7620d"),
                  ConversionFactorFromSIFormula = "Factors.Day/Factors.Deci",
                  ConversionFactorFromSI = Factors.Day/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decimetre per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day/Deci, i.e., 864000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "furlong per fortnight",
                  UnitLabel = "furlong/14d",
                  SIUnitName = "metre per second",
                  ID = new Guid("028ad001-b80d-49d8-8d18-8e10c1f0239f"),
                  ConversionFactorFromSIFormula = "Factors.Fortnight/Factors.Furlong",
                  ConversionFactorFromSI = Factors.Fortnight/Factors.Furlong,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in furlong per fortnight"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Fortnight/Furlong, i.e., 6012.884753042234"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Fortnight = 14.0 * Day"
 + Environment.NewLine + "Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class VolumeQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "cubic metre",
                  UnitLabel = "m³",
                  SIUnitName = "cubic metre",
                  ID = new Guid("a465ba87-53d6-456c-8e74-315a1a212498"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "litre",
                  UnitLabel = "l",
                  SIUnitName = "cubic metre",
                  ID = new Guid("3f713743-6248-4b0b-8f3b-c97b6fab76b1"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decilitre",
                  UnitLabel = "dl",
                  SIUnitName = "cubic metre",
                  ID = new Guid("3d7dde61-a9e9-4df6-8ee4-1eb4a4be1147"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Deci*Factors.Milli)",
                  ConversionFactorFromSI = 1.0/(Factors.Deci*Factors.Milli),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decilitre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Deci*Milli), i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centilitre",
                  UnitLabel = "cl",
                  SIUnitName = "cubic metre",
                  ID = new Guid("8d9baa02-5c3e-46f8-b909-7ca92d7bfa7a"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Centi*Factors.Milli)",
                  ConversionFactorFromSI = 1.0/(Factors.Centi*Factors.Milli),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centilitre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Centi*Milli), i.e., 99999.99999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "millilitre",
                  UnitLabel = "ml",
                  SIUnitName = "cubic metre",
                  ID = new Guid("6eb0d045-36e5-448d-be94-96a24a03f3e6"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Milli*Factors.Milli)",
                  ConversionFactorFromSI = 1.0/(Factors.Milli*Factors.Milli),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in millilitre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Milli*Milli), i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US gallon",
                  UnitLabel = "US Gal.",
                  SIUnitName = "cubic metre",
                  ID = new Guid("1377d8ac-d203-48ed-bad4-733b0dc9d496"),
                  ConversionFactorFromSIFormula = "1.0/Factors.GallonUS",
                  ConversionFactorFromSI = 1.0/Factors.GallonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US gallon"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/GallonUS, i.e., 264.17205235814845"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK gallon",
                  UnitLabel = "UK Gal.",
                  SIUnitName = "cubic metre",
                  ID = new Guid("78f1cef7-c489-498c-96fb-d37474e242a9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.GallonUK",
                  ConversionFactorFromSI = 1.0/Factors.GallonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK gallon"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/GallonUK, i.e., 219.96924829908778"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "barrel",
                  UnitLabel = "bbl",
                  SIUnitName = "cubic metre",
                  ID = new Guid("b0f03925-d158-48ee-8c33-bf72c08cae68"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Barrel",
                  ConversionFactorFromSI = 1.0/Factors.Barrel,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in barrel"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Barrel, i.e., 6.289810770432106"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million cubic metre",
                  UnitLabel = "Mm³",
                  SIUnitName = "cubic metre",
                  ID = new Guid("4c021db5-327b-44d3-9c4f-5a9b84af602f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million cubic metre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million litre",
                  UnitLabel = "Ml",
                  SIUnitName = "cubic metre",
                  ID = new Guid("4f3f67df-28af-4398-966f-b23de678f50c"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega*Factors.Milli)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega*Factors.Milli),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million litre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega*Milli), i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million UK gallon",
                  UnitLabel = "M UK Gal.",
                  SIUnitName = "cubic metre",
                  ID = new Guid("ab9a2938-f519-47c0-bcaa-d61c8fa23c7b"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega*Factors.GallonUK)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega*Factors.GallonUK),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million UK gallon"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega*GallonUK), i.e., 0.0002199692482990878"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million barrel",
                  UnitLabel = "Mbbl",
                  SIUnitName = "cubic metre",
                  ID = new Guid("9d03120c-2c74-4666-8e24-98e143ab88db"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega*Factors.Barrel)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega*Factors.Barrel),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million barrel"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega*Barrel), i.e., 6.289810770432106E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "thousand standard cubic foot",
                  UnitLabel = "Mscf",
                  SIUnitName = "cubic metre",
                  ID = new Guid("e50b6a47-cf4c-4a74-8c1c-758000df5d67"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo*Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo*Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in thousand standard cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo*Foot*Foot*Foot), i.e., 0.0353146667214886"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million standard cubic foot",
                  UnitLabel = "MMscf",
                  SIUnitName = "cubic metre",
                  ID = new Guid("387b78ff-d51b-4684-b059-4c813407d767"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega*Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega*Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million standard cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega*Foot*Foot*Foot), i.e., 3.531466672148861E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic foot",
                  UnitLabel = "ft³",
                  SIUnitName = "cubic metre",
                  ID = new Guid("1da2384d-f463-4b08-9c0b-1de06b51268c"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = 1.0/(Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Foot*Foot*Foot), i.e., 35.3146667214886"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic inch",
                  UnitLabel = "in³",
                  SIUnitName = "cubic metre",
                  ID = new Guid("dacec282-dacd-4687-9943-8fa741124116"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Inch*Factors.Inch*Factors.Inch)",
                  ConversionFactorFromSI = 1.0/(Factors.Inch*Factors.Inch*Factors.Inch),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Inch*Inch*Inch), i.e., 61023.74409473229"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million US gallon",
                  UnitLabel = "M US Gal.",
                  SIUnitName = "cubic metre",
                  ID = new Guid("a1d1c28d-8d55-417e-93af-e7302b68ed13"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega*Factors.GallonUS)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega*Factors.GallonUS),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million US gallon"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega*GallonUS), i.e., 0.00026417205235814843"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class VolumetricFlowRateOfChangeQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "cubic metre per second squared",
                  UnitLabel = "m³/s²",
                  SIUnitName = "cubic metre per second squared",
                  ID = new Guid("aef20431-be0b-44ea-8770-a59db19b7f94"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "litre per minute squared",
                  UnitLabel = "L/min²",
                  SIUnitName = "cubic metre per second squared",
                  ID = new Guid("b27d2f54-a1f3-4abb-ba6d-a2a8b530049a"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute/Factors.Milli",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre per minute squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Minute/Milli, i.e., 3600000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "litre per minute per second",
                  UnitLabel = "L/min/s",
                  SIUnitName = "cubic metre per second squared",
                  ID = new Guid("e5a265b6-a9ba-4a09-ba08-b8c417b28ffb"),
                  ConversionFactorFromSIFormula = "Factors.Minute/Factors.Milli",
                  ConversionFactorFromSI = Factors.Minute/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute/Milli, i.e., 60000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "litre per second squared",
                  UnitLabel = "L/s²",
                  SIUnitName = "cubic metre per second squared",
                  ID = new Guid("a899c06f-18dd-4d2a-9743-489f0af5be91"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre per second squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK gallon per minute squared",
                  UnitLabel = "UKGal/min²",
                  SIUnitName = "cubic metre per second squared",
                  ID = new Guid("c7c61175-e527-4403-8425-32f681367985"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute/Factors.GallonUK",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute/Factors.GallonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK gallon per minute squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Minute/GallonUK, i.e., 791889.293876716"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK gallon per minute per second",
                  UnitLabel = "UKGal/min/s",
                  SIUnitName = "cubic metre per second squared",
                  ID = new Guid("298e7a16-07a5-4b5b-a0de-3e49b31254b4"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Unit/Factors.GallonUK",
                  ConversionFactorFromSI = Factors.Minute*Factors.Unit/Factors.GallonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK gallon per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Unit/GallonUK, i.e., 13198.154897945267"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US gallon per minute squared",
                  UnitLabel = "USGal/min²",
                  SIUnitName = "cubic metre per second squared",
                  ID = new Guid("61885289-823d-4b26-bdf2-bc4744567bef"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Minute/Factors.GallonUS",
                  ConversionFactorFromSI = Factors.Minute*Factors.Minute/Factors.GallonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US gallon per minute squared"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Minute/GallonUS, i.e., 951019.3884893344"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US gallon per minute per second",
                  UnitLabel = "USGal/min/s",
                  SIUnitName = "cubic metre per second squared",
                  ID = new Guid("3c530e9a-9376-49d1-a6b5-0a6f93f4184b"),
                  ConversionFactorFromSIFormula = "Factors.Minute*Factors.Unit/Factors.GallonUS",
                  ConversionFactorFromSI = Factors.Minute*Factors.Unit/Factors.GallonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US gallon per minute per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute*Unit/GallonUS, i.e., 15850.323141488907"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class VolumetricFlowRateQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "cubic metre per second",
                  UnitLabel = "m³/s",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("fabe7a23-1ba2-4f5d-b3f5-d5729166c7a0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "litre per second",
                  UnitLabel = "L/s",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("6dafb683-0f61-42ba-a22c-7bd5c9cea4ae"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic foot per second",
                  UnitLabel = "ft³/s",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("a02fc355-34da-447b-ad1f-66cef4cc96d5"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = 1.0/(Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic foot per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Foot*Foot*Foot), i.e., 35.3146667214886"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK gallon per second",
                  UnitLabel = "gpsUK",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("21ca44f5-ed4e-414d-b285-b38730600794"),
                  ConversionFactorFromSIFormula = "1.0/Factors.GallonUK",
                  ConversionFactorFromSI = 1.0/Factors.GallonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK gallon per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/GallonUK, i.e., 219.96924829908778"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US gallon per second",
                  UnitLabel = "gpsUS",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("21fe7e3a-bf92-4c94-b6d7-e2d30dfc4cd3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.GallonUS",
                  ConversionFactorFromSI = 1.0/Factors.GallonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US gallon per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/GallonUS, i.e., 264.17205235814845"
 + Environment.NewLine + "and"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "barrel per second",
                  UnitLabel = "bbl/s",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("a73caac6-062e-4f79-8374-8fb2598b6842"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Barrel",
                  ConversionFactorFromSI = 1.0/Factors.Barrel,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in barrel per second"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Barrel, i.e., 6.289810770432106"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic metre per minute",
                  UnitLabel = "m³/min",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("98eec130-224c-457a-a5dd-50b55a3a28ab"),
                  ConversionFactorFromSIFormula = "Factors.Minute / Factors.Unit",
                  ConversionFactorFromSI = Factors.Minute / Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic metre per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute / Unit, i.e., 60"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "litre per minute",
                  UnitLabel = "L/min",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("e1ff1684-02ed-41c0-a82c-40b4a6d348b5"),
                  ConversionFactorFromSIFormula = "Factors.Minute / Factors.Milli",
                  ConversionFactorFromSI = Factors.Minute / Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute / Milli, i.e., 60000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic foot per minute",
                  UnitLabel = "ft³/min",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("a81e08db-d8fd-4379-bc8e-c223c3fb71b3"),
                  ConversionFactorFromSIFormula = "Factors.Minute / (Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = Factors.Minute / (Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic foot per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute / (Foot*Foot*Foot), i.e., 2118.880003289316"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK gallon per minute",
                  UnitLabel = "gpmUK",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("bb1d3fbc-efc1-4cf7-9c13-33c25a874224"),
                  ConversionFactorFromSIFormula = "Factors.Minute / Factors.GallonUK",
                  ConversionFactorFromSI = Factors.Minute / Factors.GallonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK gallon per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute / GallonUK, i.e., 13198.154897945267"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US gallon per minute",
                  UnitLabel = "gpmUS",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("ceca76e7-fd1e-4220-b072-9f40467a05e3"),
                  ConversionFactorFromSIFormula = "Factors.Minute / Factors.GallonUS",
                  ConversionFactorFromSI = Factors.Minute / Factors.GallonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US gallon per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute / GallonUS, i.e., 15850.323141488907"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "barrel per minute",
                  UnitLabel = "bbl/m",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("3672c640-3924-4921-861b-d14c99643615"),
                  ConversionFactorFromSIFormula = "Factors.Minute /Factors.Barrel",
                  ConversionFactorFromSI = Factors.Minute /Factors.Barrel,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in barrel per minute"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Minute /Barrel, i.e., 377.3886462259263"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic metre per hour",
                  UnitLabel = "m³/h",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("d6607bed-0235-4838-87c8-2ff6c76be2ad"),
                  ConversionFactorFromSIFormula = "Factors.Hour/ Factors.Unit",
                  ConversionFactorFromSI = Factors.Hour/ Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic metre per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/ Unit, i.e., 3600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "litre per hour",
                  UnitLabel = "L/h",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("fe2d8a01-fd2b-4652-80bd-f0da2ce990fd"),
                  ConversionFactorFromSIFormula = "Factors.Hour/ Factors.Milli",
                  ConversionFactorFromSI = Factors.Hour/ Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/ Milli, i.e., 3600000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic foot per hour",
                  UnitLabel = "ft³/h",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("54f30d1c-670a-4566-bfb2-3ce644d68878"),
                  ConversionFactorFromSIFormula = "Factors.Hour / (Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = Factors.Hour / (Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic foot per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour / (Foot*Foot*Foot), i.e., 127132.80019735897"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK gallon per hour",
                  UnitLabel = "gphUK",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("85d47672-e1ce-4b33-be1d-eabc2ec1c4c1"),
                  ConversionFactorFromSIFormula = "Factors.Hour/ Factors.GallonUK",
                  ConversionFactorFromSI = Factors.Hour/ Factors.GallonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK gallon per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/ GallonUK, i.e., 791889.293876716"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US gallon per hour",
                  UnitLabel = "gphUS",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("36892d41-4a11-4d32-9a8c-1e43ac1f8c6d"),
                  ConversionFactorFromSIFormula = "Factors.Hour/ Factors.GallonUS",
                  ConversionFactorFromSI = Factors.Hour/ Factors.GallonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US gallon per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/ GallonUS, i.e., 951019.3884893344"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "barrel per hour",
                  UnitLabel = "bbl/h",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("af1bd583-3a13-4d3a-8f65-ede4f8fe9789"),
                  ConversionFactorFromSIFormula = "Factors.Hour/ Factors.Barrel",
                  ConversionFactorFromSI = Factors.Hour/ Factors.Barrel,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in barrel per hour"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hour/ Barrel, i.e., 22643.31877355558"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic metre per day",
                  UnitLabel = "m³/d",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("f512755c-166c-4346-a0f7-74f09703410f"),
                  ConversionFactorFromSIFormula = "Factors.Day / Factors.Unit",
                  ConversionFactorFromSI = Factors.Day / Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic metre per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / Unit, i.e., 86400"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million cubic metre per day",
                  UnitLabel = "Mm³/d",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("d09b4db7-9fbe-4018-aeb7-15286ccff8d6"),
                  ConversionFactorFromSIFormula = "Factors.Day / Factors.Mega",
                  ConversionFactorFromSI = Factors.Day / Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million cubic metre per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / Mega, i.e., 0.0864"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK gallon per day",
                  UnitLabel = "gpdUK",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("334cf647-375e-4423-8ef4-e1171f938f9a"),
                  ConversionFactorFromSIFormula = "Factors.Day / Factors.GallonUK",
                  ConversionFactorFromSI = Factors.Day / Factors.GallonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK gallon per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / GallonUK, i.e., 19005343.053041186"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US gallon per day",
                  UnitLabel = "gpdUS",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("c0a47cc8-8ba1-47a1-ab94-d3e4361dd063"),
                  ConversionFactorFromSIFormula = "Factors.Day / Factors.GallonUS",
                  ConversionFactorFromSI = Factors.Day / Factors.GallonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US gallon per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / GallonUS, i.e., 22824465.323744025"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million UK gallon per day",
                  UnitLabel = "MillionUKGallonPerDay",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("f083576e-1d99-4243-bcfa-5ca6093b6931"),
                  ConversionFactorFromSIFormula = "Factors.Day / (Factors.Mega*Factors.GallonUK)",
                  ConversionFactorFromSI = Factors.Day / (Factors.Mega*Factors.GallonUK),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million UK gallon per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / (Mega*GallonUK), i.e., 19.005343053041184"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million US gallon per day",
                  UnitLabel = "MillionUSGallonPerDay",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("ffe9958a-3daa-472d-87ab-0b1217dcb1c5"),
                  ConversionFactorFromSIFormula = "Factors.Day / (Factors.Mega*Factors.GallonUS)",
                  ConversionFactorFromSI = Factors.Day / (Factors.Mega*Factors.GallonUS),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million US gallon per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / (Mega*GallonUS), i.e., 22.824465323744025"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "litre per day",
                  UnitLabel = "L/d",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("67628fe2-6a64-4ea6-94fe-5a34e7568b53"),
                  ConversionFactorFromSIFormula = "Factors.Day / Factors.Milli",
                  ConversionFactorFromSI = Factors.Day / Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / Milli, i.e., 86400000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million liter per day",
                  UnitLabel = "MillionLiterPerDay",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("1889c1dd-5aa3-45fe-b6cb-79a760e44832"),
                  ConversionFactorFromSIFormula = "Factors.Day / (Factors.Mega*Factors.Milli)",
                  ConversionFactorFromSI = Factors.Day / (Factors.Mega*Factors.Milli),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million liter per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / (Mega*Milli), i.e., 86.4"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic foot per day",
                  UnitLabel = "ft³/d",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("6b9a886b-b96a-473b-8dea-e850583ad5d8"),
                  ConversionFactorFromSIFormula = "Factors.Day / (Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = Factors.Day / (Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic foot per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / (Foot*Foot*Foot), i.e., 3051187.204736615"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "thousand standard cubic foot per day",
                  UnitLabel = "Mscf/d",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("627a75ed-2ab8-480a-96be-b9266d34ba5d"),
                  ConversionFactorFromSIFormula = "Factors.Day / (1000.0*Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = Factors.Day / (1000.0*Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in thousand standard cubic foot per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / (1000.0*Foot*Foot*Foot), i.e., 3051.187204736615"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "million standard cubic foot per day",
                  UnitLabel = "MMscf/d",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("f1c76ab3-8e54-4ad1-a7fe-a09be2a61285"),
                  ConversionFactorFromSIFormula = "Factors.Day / (Factors.Mega*Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = Factors.Day / (Factors.Mega*Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in million standard cubic foot per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / (Mega*Foot*Foot*Foot), i.e., 3.0511872047366158"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "barrel per day",
                  UnitLabel = "bbl/d",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("9d36ce54-5bdc-4f4b-9948-dd65c58c9db3"),
                  ConversionFactorFromSIFormula = "Factors.Day / Factors.Barrel",
                  ConversionFactorFromSI = Factors.Day / Factors.Barrel,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in barrel per day"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Day / Barrel, i.e., 543439.6505653339"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic metre per year",
                  UnitLabel = "m³/year",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("f0e95734-b6a0-4081-b022-8c5bc0e7dd64"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian/Factors.Unit",
                  ConversionFactorFromSI = Factors.YearJulian/Factors.Unit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic metre per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian/Unit, i.e., 31557600"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Unit = 1.0"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "litre per year",
                  UnitLabel = "L/year",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("d2b8abd2-cd97-4933-8e0a-54d8a4eef7ce"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian/Factors.Milli",
                  ConversionFactorFromSI = Factors.YearJulian/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in litre per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian/Milli, i.e., 31557600000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "cubic foot per year",
                  UnitLabel = "ft³/year",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("5ae7fcd3-fae0-4d81-abca-4c3d36d49e6d"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian / (Factors.Foot*Factors.Foot*Factors.Foot)",
                  ConversionFactorFromSI = Factors.YearJulian / (Factors.Foot*Factors.Foot*Factors.Foot),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in cubic foot per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian / (Foot*Foot*Foot), i.e., 1114446126.5300486"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "UK gallon per year",
                  UnitLabel = "gpyUK",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("b7f54c43-a2ee-4b27-bccb-4c0e752e4caf"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian /Factors.GallonUK",
                  ConversionFactorFromSI = Factors.YearJulian /Factors.GallonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in UK gallon per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian /GallonUK, i.e., 6941701550.123293"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "US gallon per year",
                  UnitLabel = "gpyUS",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("94558d1e-fbe2-4f06-a985-44210a1f0bc8"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian /Factors.GallonUS",
                  ConversionFactorFromSI = Factors.YearJulian /Factors.GallonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in US gallon per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian /GallonUS, i.e., 8336635959.497505"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "barrel per year",
                  UnitLabel = "bbl/year",
                  SIUnitName = "cubic metre per second",
                  ID = new Guid("0360ea30-fbf5-4dda-bf99-670dd6983420"),
                  ConversionFactorFromSIFormula = "Factors.YearJulian /Factors.Barrel",
                  ConversionFactorFromSI = Factors.YearJulian /Factors.Barrel,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in barrel per year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = YearJulian /Barrel, i.e., 198491332.36898822"
 + Environment.NewLine + "and"
 + Environment.NewLine + "YearJulian = 365.25 * Day"
 + Environment.NewLine + "Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)"
 + Environment.NewLine + "Day = 24.0 * Hour"
 + Environment.NewLine + "GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon"
 + Environment.NewLine + "Hour = 60.0 * Minute"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "Minute = 60.0"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class WaveNumberQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "reciprocal metre",
                  UnitLabel = "1/m",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("3cd38922-b99f-45bb-af6e-a38ebf1240f0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal decimetre",
                  UnitLabel = "1/dm",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("cf8a931b-eaa9-4b0c-8894-53d54e93cba1"),
                  ConversionFactorFromSIFormula = "Factors.Deci",
                  ConversionFactorFromSI = Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal decimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deci, i.e., 0.1"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal centimetre",
                  UnitLabel = "1/cm",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("4f2c38c2-86ff-4842-afdd-3a9fcf8a623e"),
                  ConversionFactorFromSIFormula = "Factors.Centi",
                  ConversionFactorFromSI = Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal centimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Centi, i.e., 0.01"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal millimetre",
                  UnitLabel = "1/mm",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("2d484d0f-7d29-48e9-8d5b-ff82fca6f1c5"),
                  ConversionFactorFromSIFormula = "Factors.Milli",
                  ConversionFactorFromSI = Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal millimetre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Milli, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal micrometre",
                  UnitLabel = "1/µm",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("ddbbb734-ddd2-4d26-84ba-9995fff479e6"),
                  ConversionFactorFromSIFormula = "Factors.Micro",
                  ConversionFactorFromSI = Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal micrometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Micro, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal nanometre",
                  UnitLabel = "1/nm",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("25412abd-9c3e-4b67-b809-d92926eb2b58"),
                  ConversionFactorFromSIFormula = "Factors.Nano",
                  ConversionFactorFromSI = Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal nanometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Nano, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal ångstrøm",
                  UnitLabel = "1/Å",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("7c28c943-c084-48f6-804c-87e6c6902b35"),
                  ConversionFactorFromSIFormula = "Factors.Angstrom",
                  ConversionFactorFromSI = Factors.Angstrom,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal ångstrøm"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Angstrom, i.e., 1E-10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Angstrom = 1e-10"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal picometre",
                  UnitLabel = "1/pm",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("bca4fde9-e17a-4a27-9a3f-34beab644ee2"),
                  ConversionFactorFromSIFormula = "Factors.Pico",
                  ConversionFactorFromSI = Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal picometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Pico, i.e., 1E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal decametre",
                  UnitLabel = "1/dam",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("a691338d-1916-4355-b6e1-3b1bff086c14"),
                  ConversionFactorFromSIFormula = "Factors.Deca",
                  ConversionFactorFromSI = Factors.Deca,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal decametre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Deca, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deca = 10.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal hectometre",
                  UnitLabel = "1/hm",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("4da19df4-0ff6-424b-a2ab-9d5811ba48ca"),
                  ConversionFactorFromSIFormula = "Factors.Hecto",
                  ConversionFactorFromSI = Factors.Hecto,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal hectometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hecto, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hecto = 100.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal kilometre",
                  UnitLabel = "1/km",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("a4b4ed8e-a1c6-4e3f-9421-8770cec6ff42"),
                  ConversionFactorFromSIFormula = "Factors.Kilo",
                  ConversionFactorFromSI = Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal kilometre"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Kilo, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal astronomical unit",
                  UnitLabel = "1/au",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("4d58ee46-e637-4f5a-a1ff-33f002154fec"),
                  ConversionFactorFromSIFormula = "Factors.AstronomicalUnit",
                  ConversionFactorFromSI = Factors.AstronomicalUnit,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal astronomical unit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = AstronomicalUnit, i.e., 149597870700"
 + Environment.NewLine + "and"
 + Environment.NewLine + "AstronomicalUnit = 149597870700.0 reference: https://www.iau.org/static/resolutions/IAU2012_English.pdf"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal light year",
                  UnitLabel = "1/ly",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("81c8c5d9-a892-4702-921b-9946abbef6b0"),
                  ConversionFactorFromSIFormula = "Factors.LightYear",
                  ConversionFactorFromSI = Factors.LightYear,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal light year"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = LightYear, i.e., 9460730472580800"
 + Environment.NewLine + "and"
 + Environment.NewLine + "LightYear = 9460730472580800.0 reference: https://www.iau.org/public/themes/measuring/"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal parsec",
                  UnitLabel = "1/pc",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("b8f6a954-7fe6-4f31-94cc-e53bb5603cd5"),
                  ConversionFactorFromSIFormula = "Factors.Parsec",
                  ConversionFactorFromSI = Factors.Parsec,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal parsec"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Parsec, i.e., 30856775814913670"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Parsec = (60.0*60.0*180.0 / System.Math.PI) * AstronomicalUnit reference: https://imagine.gsfc.nasa.gov/features/cosmic/milkyway_info.html"
 + Environment.NewLine + "AstronomicalUnit = 149597870700.0 reference: https://www.iau.org/static/resolutions/IAU2012_English.pdf"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal foot",
                  UnitLabel = "1/ft",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("1d6a5284-d32f-4f5a-ad27-bfc0f71069aa"),
                  ConversionFactorFromSIFormula = "Factors.Foot",
                  ConversionFactorFromSI = Factors.Foot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Foot, i.e., 0.30479999999999996"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal US survey foot",
                  UnitLabel = "1/ft",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("16c3f209-e890-4b35-807e-7115545406e0"),
                  ConversionFactorFromSIFormula = "Factors.USSurveyFoot",
                  ConversionFactorFromSI = Factors.USSurveyFoot,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal US survey foot"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = USSurveyFoot, i.e., 0.3048006096012192"
 + Environment.NewLine + "and"
 + Environment.NewLine + "USSurveyFoot = 1200.0 / 3937.0 reference: https://www.nist.gov/pml/us-surveyfoot"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal inch",
                  UnitLabel = "1/in",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("95cd773d-b6da-4148-bd9c-bed66b4a72d8"),
                  ConversionFactorFromSIFormula = "Factors.Inch",
                  ConversionFactorFromSI = Factors.Inch,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal inch"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Inch, i.e., 0.0254"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal yard",
                  UnitLabel = "1/yd",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("be5f64c0-592a-4f3b-b2b5-6df8b9d2a31b"),
                  ConversionFactorFromSIFormula = "Factors.Yard",
                  ConversionFactorFromSI = Factors.Yard,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal yard"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Yard, i.e., 0.9143999999999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal fathom",
                  UnitLabel = "1/fathom",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("ae9e314e-de19-405e-a897-6a68cd4845f6"),
                  ConversionFactorFromSIFormula = "Factors.Fathom",
                  ConversionFactorFromSI = Factors.Fathom,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal fathom"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Fathom, i.e., 1.8287999999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Fathom = 6.0 * Foot reference: https://www.britannica.com/science/fathom"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal surveyors chain",
                  UnitLabel = "1/chain",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("90da0d97-195c-4c30-85d8-51d70b75f071"),
                  ConversionFactorFromSIFormula = "Factors.SurveyorChain",
                  ConversionFactorFromSI = Factors.SurveyorChain,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal surveyors chain"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = SurveyorChain, i.e., 20.116799999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "SurveyorChain = 22.0 * Yard reference: https://www.britannica.com/technology/surveyors-chain"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal mile",
                  UnitLabel = "1/mi",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("acbb10a5-602f-423b-bc15-bdfd80cb7008"),
                  ConversionFactorFromSIFormula = "Factors.Mile",
                  ConversionFactorFromSI = Factors.Mile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Mile, i.e., 1609.3439999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile"
 + Environment.NewLine + "Yard = 3.0 * Foot"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal international nautical mile",
                  UnitLabel = "1/nmi",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("78474000-3cd8-4102-b7b4-360b4c2130fc"),
                  ConversionFactorFromSIFormula = "Factors.InternationalNauticalMile",
                  ConversionFactorFromSI = Factors.InternationalNauticalMile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal international nautical mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = InternationalNauticalMile, i.e., 1852"
 + Environment.NewLine + "and"
 + Environment.NewLine + "InternationalNauticalMile = 1852.0 reference: https://www.merriam-webster.com/dictionary/nautical%20mile"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal UK nautical mile",
                  UnitLabel = "1/(UK nmi)",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("8a55784f-b5f4-4aa7-b5f9-d19742857349"),
                  ConversionFactorFromSIFormula = "Factors.UKNauticalMile",
                  ConversionFactorFromSI = Factors.UKNauticalMile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal UK nautical mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = UKNauticalMile, i.e., 1853.1839999999997"
 + Environment.NewLine + "and"
 + Environment.NewLine + "UKNauticalMile = 6080 * Foot reference: https://www.rmg.co.uk/stories/topics/nautical-mile"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal scandinavian mile",
                  UnitLabel = "1/mil",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("f766575d-9bfa-45fb-8bfd-50f12a0e6a6a"),
                  ConversionFactorFromSIFormula = "Factors.ScandinavianMile",
                  ConversionFactorFromSI = Factors.ScandinavianMile,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal scandinavian mile"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = ScandinavianMile, i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "ScandinavianMile = 10000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal inch per 32",
                  UnitLabel = "1/in/32",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("ac9c8b52-22f0-476d-a038-023695c24f25"),
                  ConversionFactorFromSIFormula = "Factors.InchPer32",
                  ConversionFactorFromSI = Factors.InchPer32,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal inch per 32"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = InchPer32, i.e., 0.00079375"
 + Environment.NewLine + "and"
 + Environment.NewLine + "InchPer32 = Inch / 32.0"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal mil",
                  UnitLabel = "1/mil",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("09d27104-6452-4976-98e0-6fd087e22eb1"),
                  ConversionFactorFromSIFormula = "Factors.Mil",
                  ConversionFactorFromSI = Factors.Mil,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal mil"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Mil, i.e., 2.54E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mil = 0.001 * Inch reference: https://en.wikipedia.org/wiki/Thousandth_of_an_inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal thou",
                  UnitLabel = "1/thou",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("e732fd46-ddf3-433e-8baf-cc531ca69160"),
                  ConversionFactorFromSIFormula = "Factors.Thou",
                  ConversionFactorFromSI = Factors.Thou,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal thou"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Thou, i.e., 2.54E-05"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Thou = Mil"
 + Environment.NewLine + "Mil = 0.001 * Inch reference: https://en.wikipedia.org/wiki/Thousandth_of_an_inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal hand",
                  UnitLabel = "1/hand",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("844ed023-9f47-4147-8b50-cf03c99071b5"),
                  ConversionFactorFromSIFormula = "Factors.Hand",
                  ConversionFactorFromSI = Factors.Hand,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal hand"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Hand, i.e., 0.1016"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Hand = 4.0 * Inch reference: https://en.wikipedia.org/wiki/Hand_(unit)"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "reciprocal furlong",
                  UnitLabel = "1/furlong",
                  SIUnitName = "reciprocal metre",
                  ID = new Guid("79a3f3db-0ac8-4bcb-b93c-fca2a673147b"),
                  ConversionFactorFromSIFormula = "Factors.Furlong",
                  ConversionFactorFromSI = Factors.Furlong,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in reciprocal furlong"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = Furlong, i.e., 201.16799999999998"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong"
 + Environment.NewLine + "Foot = 12.0 * Inch"
 + Environment.NewLine + "Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassQuantity : SymbolizedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "kilogram",
                  UnitLabel = "kg",
                  SIUnitName = "kilogram",
                  ID = new Guid("ef4c5fc1-8774-4aea-b772-35aeae56413d"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "hectogram",
                  UnitLabel = "hg",
                  SIUnitName = "kilogram",
                  ID = new Guid("2fb79e4b-3eb5-4aa3-9f12-2c66b1784902"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Deci",
                  ConversionFactorFromSI = 1.0/Factors.Deci,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hectogram"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Deci, i.e., 10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Deci = 0.1"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "decagram",
                  UnitLabel = "dag",
                  SIUnitName = "kilogram",
                  ID = new Guid("1b3f72cb-55b1-4027-b6ad-309cd7d6c1a3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Centi",
                  ConversionFactorFromSI = 1.0/Factors.Centi,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in decagram"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Centi, i.e., 100"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Centi = 0.01"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gram",
                  UnitLabel = "g",
                  SIUnitName = "kilogram",
                  ID = new Guid("049ba04e-4c70-41f5-bb29-6b54bb5b2103"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Milli",
                  ConversionFactorFromSI = 1.0/Factors.Milli,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gram"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Milli, i.e., 1000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "centigram",
                  UnitLabel = "cg",
                  SIUnitName = "kilogram",
                  ID = new Guid("e56aa2fa-80b7-417f-8e08-91b9b8a1198c"),
                  ConversionFactorFromSIFormula = "1.0/(0.1*Factors.Milli)",
                  ConversionFactorFromSI = 1.0/(0.1*Factors.Milli),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in centigram"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(0.1*Milli), i.e., 10000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Milli = 0.001"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "milligram",
                  UnitLabel = "mg",
                  SIUnitName = "kilogram",
                  ID = new Guid("322b0e70-c8e5-482e-a9db-682d15baacf9"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Micro",
                  ConversionFactorFromSI = 1.0/Factors.Micro,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in milligram"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Micro, i.e., 1000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Micro = 1e-6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "microgram",
                  UnitLabel = "µg",
                  SIUnitName = "kilogram",
                  ID = new Guid("eb831d52-2690-4b8a-a1a4-83e9bdb07dbc"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Nano",
                  ConversionFactorFromSI = 1.0/Factors.Nano,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in microgram"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Nano, i.e., 999999999.9999999"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Nano = 1e-9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "nanogram",
                  UnitLabel = "ng",
                  SIUnitName = "kilogram",
                  ID = new Guid("93db8c40-4dd0-46a4-ade6-db51bcbca66f"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pico",
                  ConversionFactorFromSI = 1.0/Factors.Pico,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in nanogram"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pico, i.e., 1000000000000"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pico = 1e-12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "atom mass unit",
                  UnitLabel = "u",
                  SIUnitName = "kilogram",
                  ID = new Guid("f470168e-1e20-458e-b6da-6bee551cb6d6"),
                  ConversionFactorFromSIFormula = "1.0/Factors.AtomicMass",
                  ConversionFactorFromSI = 1.0/Factors.AtomicMass,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in atom mass unit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/AtomicMass, i.e., 6.022140762081123E+26"
 + Environment.NewLine + "and"
 + Environment.NewLine + "AtomicMass = 1.66053906660e-27 reference: https://en.wikipedia.org/wiki/Atomic_mass"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "tonne metric",
                  UnitLabel = "t",
                  SIUnitName = "kilogram",
                  ID = new Guid("320b99ba-3115-42f5-939c-15a04d9e7e3c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in tonne metric"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilotonne",
                  UnitLabel = "kt",
                  SIUnitName = "kilogram",
                  ID = new Guid("2a767cda-fc61-4aa4-81dd-1a4f6d6af755"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilotonne"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megatonne",
                  UnitLabel = "Mt",
                  SIUnitName = "kilogram",
                  ID = new Guid("92c4b624-4205-4596-aabf-1dd4aa442718"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megatonne"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigatonne",
                  UnitLabel = "Gt",
                  SIUnitName = "kilogram",
                  ID = new Guid("51cd0591-d741-4769-bd22-e36959d1adcf"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Tera",
                  ConversionFactorFromSI = 1.0/Factors.Tera,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigatonne"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Tera, i.e., 1E-12"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Tera = 1e12"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "pound",
                  UnitLabel = "lb",
                  SIUnitName = "kilogram",
                  ID = new Guid("e9e313ad-cb28-43fe-93fd-7f94dfee1878"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Pound",
                  ConversionFactorFromSI = 1.0/Factors.Pound,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in pound"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Pound, i.e., 2.2046226218487757"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilopound",
                  UnitLabel = "klb",
                  SIUnitName = "kilogram",
                  ID = new Guid("777ff8ee-edc2-46d1-ac40-f097c1e1cd69"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo * Factors.Pound)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo * Factors.Pound),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilopound"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo * Pound), i.e., 0.002204622621848776"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "ounce",
                  UnitLabel = "oz",
                  SIUnitName = "kilogram",
                  ID = new Guid("4e64e69b-2276-46c8-a918-06ab6980178c"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Ounce",
                  ConversionFactorFromSI = 1.0/Factors.Ounce,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in ounce"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Ounce, i.e., 35.27396194958041"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Ounce = (1.0 / 16.0) * Pound reference: https://en.wikipedia.org/wiki/Ounce"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "stone",
                  UnitLabel = "st",
                  SIUnitName = "kilogram",
                  ID = new Guid("6894dc1c-21e2-42aa-9569-759c0e6e6d6e"),
                  ConversionFactorFromSIFormula = "1.0/ Factors.Stone",
                  ConversionFactorFromSI = 1.0/ Factors.Stone,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in stone"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/ Stone, i.e., 0.1574730444177697"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Stone = 14.0 * Pound reference: https://simple.wikipedia.org/wiki/Stone_(unit)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "ton UK",
                  UnitLabel = "LT",
                  SIUnitName = "kilogram",
                  ID = new Guid("059c7b81-ed11-410e-9466-4661011372d2"),
                  ConversionFactorFromSIFormula = "1.0 / Factors.TonUK",
                  ConversionFactorFromSI = 1.0 / Factors.TonUK,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in ton UK"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0 / TonUK, i.e., 0.0009842065276110606"
 + Environment.NewLine + "and"
 + Environment.NewLine + "TonUK = 2240.0 * Pound reference: https://en.wikipedia.org/wiki/Ton"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "ton US",
                  UnitLabel = "ST",
                  SIUnitName = "kilogram",
                  ID = new Guid("443af797-a62f-4137-a852-ad1c9163dd7b"),
                  ConversionFactorFromSIFormula = "1.0/ Factors.TonUS",
                  ConversionFactorFromSI = 1.0/ Factors.TonUS,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in ton US"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/ TonUS, i.e., 0.001102311310924388"
 + Environment.NewLine + "and"
 + Environment.NewLine + "TonUS = 2000.0 * Pound reference: https://en.wikipedia.org/wiki/Ton"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "solar mass",
                  UnitLabel = "M☉",
                  SIUnitName = "kilogram",
                  ID = new Guid("432e73bf-a448-47f6-9c65-9339d5bac5a3"),
                  ConversionFactorFromSIFormula = "1.0/Factors.SolarMass",
                  ConversionFactorFromSI = 1.0/Factors.SolarMass,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in solar mass"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/SolarMass, i.e., 5.0291176051105175E-31"
 + Environment.NewLine + "and"
 + Environment.NewLine + "SolarMass = 332946.0487 * EarthMass reference: https://en.wikipedia.org/wiki/Earth_mass"
 + Environment.NewLine + "EarthMass = 5.9722e24 reference: https://en.wikipedia.org/wiki/Earth_mass"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "earth mass",
                  UnitLabel = "M🜨",
                  SIUnitName = "kilogram",
                  ID = new Guid("f9303406-dfce-45c4-9a1e-299d9bac1d4e"),
                  ConversionFactorFromSIFormula = "1.0/Factors.EarthMass",
                  ConversionFactorFromSI = 1.0/Factors.EarthMass,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in earth mass"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/EarthMass, i.e., 1.6744248350691536E-25"
 + Environment.NewLine + "and"
 + Environment.NewLine + "EarthMass = 5.9722e24 reference: https://en.wikipedia.org/wiki/Earth_mass"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "grain",
                  UnitLabel = "gr",
                  SIUnitName = "kilogram",
                  ID = new Guid("dad9b0a5-ce14-4132-b571-6365ab336bc2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Grain",
                  ConversionFactorFromSI = 1.0/Factors.Grain,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in grain"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Grain, i.e., 15432.358352941428"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Grain = (1.0 / 7000.0) * Pound reference: https://en.wikipedia.org/wiki/Grain_(unit)"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "hundred weights",
                  UnitLabel = "cwt",
                  SIUnitName = "kilogram",
                  ID = new Guid("83810f2a-b260-41b3-bc13-5ef60290f214"),
                  ConversionFactorFromSIFormula = "1.0/(100.0*Factors.Pound)",
                  ConversionFactorFromSI = 1.0/(100.0*Factors.Pound),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in hundred weights"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(100.0*Pound), i.e., 0.022046226218487758"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class EnergyQuantity : DerivedBasePhysicalQuantity
  {
      protected override void InitializeUnitChoices()
      {
          UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                  UnitName = "joule",
                  UnitLabel = "J",
                  SIUnitName = "joule",
                  ID = new Guid("c653b7de-0386-467c-8d25-60bb0f6a7076"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                  ConversionFactorFromSI = 1.0/Factors.Unit,
                  ConversionDescription = 
"No conversion necessary as the unit choice is SI"
 + Environment.NewLine + "",
                  IsSI = true
                }
              , new UnitChoice
                {
                  UnitName = "kilojoule",
                  UnitLabel = "kJ",
                  SIUnitName = "joule",
                  ID = new Guid("4b0cf63a-84af-4232-b7a1-7531ec1d47b0"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Kilo",
                  ConversionFactorFromSI = 1.0/Factors.Kilo,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilojoule"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Kilo, i.e., 0.001"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "megajoule",
                  UnitLabel = "MJ",
                  SIUnitName = "joule",
                  ID = new Guid("c4fdba05-7269-4098-8b33-bd8e50c67126"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Mega",
                  ConversionFactorFromSI = 1.0/Factors.Mega,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in megajoule"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Mega, i.e., 1E-06"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "gigajoule",
                  UnitLabel = "GJ",
                  SIUnitName = "joule",
                  ID = new Guid("c8781145-3c6c-4d87-9567-b0e6ec2821a2"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Giga",
                  ConversionFactorFromSI = 1.0/Factors.Giga,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in gigajoule"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Giga, i.e., 1E-09"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Giga = 1e9"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "calorie",
                  UnitLabel = "cal",
                  SIUnitName = "joule",
                  ID = new Guid("3f020e89-3146-4f3f-9b9b-eecda4400b12"),
                  ConversionFactorFromSIFormula = "1.0/Factors.Calorie",
                  ConversionFactorFromSI = 1.0/Factors.Calorie,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in calorie"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/Calorie, i.e., 0.2390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilocalorie",
                  UnitLabel = "Cal",
                  SIUnitName = "joule",
                  ID = new Guid("e4e916fe-9e79-47c9-97e5-3e8458358578"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo * Factors.Calorie)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo * Factors.Calorie),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilocalorie"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo * Calorie), i.e., 0.0002390057361376673"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "british thermal unit",
                  UnitLabel = "BTU",
                  SIUnitName = "joule",
                  ID = new Guid("8548500e-e3a9-4e36-aecb-024836b8a012"),
                  ConversionFactorFromSIFormula = "1.0/Factors.BTU",
                  ConversionFactorFromSI = 1.0/Factors.BTU,
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in british thermal unit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/BTU, i.e., 0.0009484516526770049"
 + Environment.NewLine + "and"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "kilo british thermal unit",
                  UnitLabel = "kBTU",
                  SIUnitName = "joule",
                  ID = new Guid("b8e1ba3f-d374-4220-85a6-7a066d91dd26"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Kilo * Factors.BTU)",
                  ConversionFactorFromSI = 1.0/(Factors.Kilo * Factors.BTU),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in kilo british thermal unit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Kilo * BTU), i.e., 9.484516526770048E-07"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Kilo = 1000.0"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
              , new UnitChoice
                {
                  UnitName = "mega british thermal unit",
                  UnitLabel = "MMBTU",
                  SIUnitName = "joule",
                  ID = new Guid("329c7fef-b5da-489f-a973-9ec2efb82a19"),
                  ConversionFactorFromSIFormula = "1.0/(Factors.Mega * Factors.BTU)",
                  ConversionFactorFromSI = 1.0/(Factors.Mega * Factors.BTU),
                  ConversionDescription = 
"[v] = a * [SI]"
 + Environment.NewLine + "where"
 + Environment.NewLine + "[v] is the value in mega british thermal unit"
 + Environment.NewLine + "[SI] is the value in SI"
 + Environment.NewLine + "a = 1.0/(Mega * BTU), i.e., 9.48451652677005E-10"
 + Environment.NewLine + "and"
 + Environment.NewLine + "Mega = 1e6"
 + Environment.NewLine + "BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit"
 + Environment.NewLine + "",
                }
            };
      }
  }
}
