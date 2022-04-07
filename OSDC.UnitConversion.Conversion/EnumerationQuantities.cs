using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
  public partial class PhysicalQuantity : Object
  {
     public enum QuantityEnum 
       {
         AmountSubstance,  // Amount Substance
         CableDiameter,  // Cable Diameter
         Depth,  // Depth
         ElectricalCurrent,  // Electrical Current
         ImageScale,  // Image Scale
         Length,  // Length
         LinearElongation,  // Linear Elongation
         LuminousIntensity,  // Luminous Intensity
         Mass,  // Mass
         NozzleDiameter,  // Nozzle Diameter
         PipeDiameter,  // Pipe Diameter
         PlaneAngle,  // Plane Angle
         Position,  // Position
         RelativeTemperature,  // Relative Temperature
         SmallLength,  // Small Length
         SolidAngle,  // Solid Angle
         Temperature,  // Temperature
         Time,  // Time
         PoreDiameter // Pore Diameter
       }
    protected static Dictionary<QuantityEnum, Guid> enumLookUp_ = new Dictionary<QuantityEnum, Guid>()
    {
         {QuantityEnum.AmountSubstance, new Guid("200be1eb-c278-447c-9b15-32d20fc778b9")},  // Amount Substance
         {QuantityEnum.CableDiameter, new Guid("6b3db5b2-7e30-47f7-91c5-5951dd3f9246")},  // Cable Diameter
         {QuantityEnum.Depth, new Guid("c0d965b2-a153-420a-9d03-7a2a272d619e")},  // Depth
         {QuantityEnum.ElectricalCurrent, new Guid("a322deae-e965-41bf-b4fe-a7530d33c9a0")},  // Electrical Current
         {QuantityEnum.ImageScale, new Guid("a3f230b0-a70b-40dd-9305-39e63bb1821b")},  // Image Scale
         {QuantityEnum.Length, new Guid("96058475-80c4-4394-b21a-afd2fb1594c8")},  // Length
         {QuantityEnum.LinearElongation, new Guid("3c6176f8-8f74-4fbf-bb65-207ed8b0a120")},  // Linear Elongation
         {QuantityEnum.LuminousIntensity, new Guid("fd02d171-cd96-4a41-84cc-431b50ba879b")},  // Luminous Intensity
         {QuantityEnum.Mass, new Guid("99d13248-c303-4b3d-b062-af98de701d6f")},  // Mass
         {QuantityEnum.NozzleDiameter, new Guid("1fbe2318-851d-4fd7-b711-9c23ffe544c7")},  // Nozzle Diameter
         {QuantityEnum.PipeDiameter, new Guid("28a2fe65-db50-46ec-8b1d-2a26286a5813")},  // Pipe Diameter
         {QuantityEnum.PlaneAngle, new Guid("751a8f44-d938-4319-a422-a753962fd91f")},  // Plane Angle
         {QuantityEnum.Position, new Guid("20f58500-7e00-41e7-acc4-99e9de9bfd07")},  // Position
         {QuantityEnum.RelativeTemperature, new Guid("58dadec7-7858-414b-8d7b-66504d5c2793")},  // Relative Temperature
         {QuantityEnum.SmallLength, new Guid("3bb73c6f-c40e-4e54-b59a-962bec9aafed")},  // Small Length
         {QuantityEnum.SolidAngle, new Guid("26a7767a-ea4d-417e-a1ef-b7fe674dcd3f")},  // Solid Angle
         {QuantityEnum.Temperature, new Guid("16130f2d-72a8-44a5-beaa-adbb5a1a7b21")},  // Temperature
         {QuantityEnum.Time, new Guid("7106f7cb-ddf2-4e2f-9e21-b19bc83eb248")},  // Time
         {QuantityEnum.PoreDiameter, new Guid("781affbc-fae3-40a0-a110-fd3bdfd7d41f")} // Pore Diameter
    };
  }
}

namespace OSDC.UnitConversion.Conversion
{
  public partial class AmountSubstanceQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Mole,  // mole
         Decimole,  // decimole
         Centimole,  // centimole
         Millimole,  // millimole
         Micromole,  // micromole
         Nanomole,  // nanomole
         Picomole,  // picomole
         Kilomole // kilomole
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Mole, new Guid("d1072bb3-265e-400a-91b2-9c49616dc3de")},  // mole
         {UnitChoicesEnum.Decimole, new Guid("b458e56b-edc3-48c3-8858-75d507f1f1f2")},  // decimole
         {UnitChoicesEnum.Centimole, new Guid("4d83c0db-ddc4-4087-ae50-076148976cad")},  // centimole
         {UnitChoicesEnum.Millimole, new Guid("0a83a1b6-cef4-4899-bcd4-4aa1e10d232a")},  // millimole
         {UnitChoicesEnum.Micromole, new Guid("ec2669ad-9742-4667-8a14-76e00c47a41e")},  // micromole
         {UnitChoicesEnum.Nanomole, new Guid("dc8d0034-ecfa-4dbf-a24c-f1851c4aaf9c")},  // nanomole
         {UnitChoicesEnum.Picomole, new Guid("642555ea-37f0-49b9-9f21-8dd616d477c4")},  // picomole
         {UnitChoicesEnum.Kilomole, new Guid("01157606-070e-41a2-8c78-84a7ae950bd6")} // kilomole
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class CableDiameterQuantity : SmallLengthQuantity
  {
    public enum UnitChoicesEnum 
      {
         Centimeter,  // centimeter
         Decimeter,  // decimeter
         Feet,  // feet
         Inch,  // inch
         Metre,  // metre
         Micrometer,  // micrometer
         Millimeter,  // millimeter
         Nanometer,  // nanometer
         Picometer,  // picometer
         Ångstrøm,  // ångstrøm
         Inch_32 // inch/32
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimeter, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimeter
         {UnitChoicesEnum.Decimeter, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimeter
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometer, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometer
         {UnitChoicesEnum.Millimeter, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimeter
         {UnitChoicesEnum.Nanometer, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometer
         {UnitChoicesEnum.Picometer, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometer
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.Inch_32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")} // inch/32
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class DepthQuantity : LengthQuantity
  {
    public enum UnitChoicesEnum 
      {
         Metre,  // metre
         Feet // feet
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")} // feet
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ElectricCurrentQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Ampere,  // ampere
         Coulomb_second,  // coulomb/second
         SiemensVolt,  // siemens volt
         Volt_ohm,  // volt/ohm
         Watt_volt,  // watt/volt
         Weber_henry,  // weber/henry
         Deciampere,  // deciampere
         Centiampere,  // centiampere
         Milliampere,  // milliampere
         Microampere,  // microampere
         Nanoampere,  // nanoampere
         Picoampere,  // picoampere
         Biot,  // biot
         Abampere,  // abampere
         Kiloampere,  // kiloampere
         Megaampere,  // megaampere
         Gigaampere,  // gigaampere
         Teraampere,  // teraampere
         Gilbert,  // gilbert
         Statampere // statampere
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Ampere, new Guid("1cd2ef0e-baf8-43fb-9fac-64f84560d0a9")},  // ampere
         {UnitChoicesEnum.Coulomb_second, new Guid("0a9cc349-3bac-4f44-9a9b-3940ae595f03")},  // coulomb/second
         {UnitChoicesEnum.SiemensVolt, new Guid("52bc6bd9-f25d-470b-9068-b6e87f1f2ed0")},  // siemens volt
         {UnitChoicesEnum.Volt_ohm, new Guid("100dd38e-19ad-465c-a995-0fb1174e506b")},  // volt/ohm
         {UnitChoicesEnum.Watt_volt, new Guid("29464509-67a2-4062-b78a-8156e54cfa88")},  // watt/volt
         {UnitChoicesEnum.Weber_henry, new Guid("bf3285f5-34be-4592-822d-f6ffc3ce4858")},  // weber/henry
         {UnitChoicesEnum.Deciampere, new Guid("fdca0a23-f088-4a93-8bfa-4776d19dc26e")},  // deciampere
         {UnitChoicesEnum.Centiampere, new Guid("f057be23-0f56-4a5f-bb39-3ec032b66ff8")},  // centiampere
         {UnitChoicesEnum.Milliampere, new Guid("a2b3179e-3003-48eb-82aa-80fbfb2cfe39")},  // milliampere
         {UnitChoicesEnum.Microampere, new Guid("fb4dfa70-2011-468a-9c4a-06aba3754fc2")},  // microampere
         {UnitChoicesEnum.Nanoampere, new Guid("f5f75652-d393-4328-87f0-6132fd8dc786")},  // nanoampere
         {UnitChoicesEnum.Picoampere, new Guid("9c5c1ea2-89bc-48f8-83ab-fbde7b1f3721")},  // picoampere
         {UnitChoicesEnum.Biot, new Guid("4648ec96-2c82-4aa2-8de3-d6eb105f470e")},  // biot
         {UnitChoicesEnum.Abampere, new Guid("d589a05d-d6a4-4d2d-9ec7-3a02d0de2ef0")},  // abampere
         {UnitChoicesEnum.Kiloampere, new Guid("5a500f57-a5d1-41c2-9b8d-b08757420bb8")},  // kiloampere
         {UnitChoicesEnum.Megaampere, new Guid("978af2aa-e776-43d6-bfe6-4055b6d602e8")},  // megaampere
         {UnitChoicesEnum.Gigaampere, new Guid("eb1b76cd-4863-4cf3-b421-1cd80d2fb0b4")},  // gigaampere
         {UnitChoicesEnum.Teraampere, new Guid("4bf45d0a-e177-45b9-8a40-f8f51d5b15c6")},  // teraampere
         {UnitChoicesEnum.Gilbert, new Guid("2f036ab5-992d-4dff-beef-2e2fad2f5379")},  // gilbert
         {UnitChoicesEnum.Statampere, new Guid("7d9a22ac-62d8-476d-8429-bc41febbe707")} // statampere
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class ImageScaleQuantity : DerivedPhysicalQuanity
  {
    public enum UnitChoicesEnum 
      {
         DotPerMeter,  // dot per meter
         DotPerInch,  // dot per inch
         DotPerMillimeter,  // dot per millimeter
         DotPerMicrometer // dot per micrometer
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.DotPerMeter, new Guid("acc723b8-083c-49f3-a208-184d2da3347d")},  // dot per meter
         {UnitChoicesEnum.DotPerInch, new Guid("e042b571-b7d0-477d-abf6-8b8998e5ba6c")},  // dot per inch
         {UnitChoicesEnum.DotPerMillimeter, new Guid("6d4d5f26-8812-4002-a2bf-27ec7871c1f4")},  // dot per millimeter
         {UnitChoicesEnum.DotPerMicrometer, new Guid("76e21d1d-54f5-4bbb-81c6-1b92b8b30bfe")} // dot per micrometer
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class LengthQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Metre,  // metre
         Decimeter,  // decimeter
         Centimeter,  // centimeter
         Millimeter,  // millimeter
         Micrometer,  // micrometer
         Nanometer,  // nanometer
         Ångstrøm,  // ångstrøm
         Picometer,  // picometer
         Decameter,  // decameter
         Hectometer,  // hectometer
         Kilometer,  // kilometer
         AstronomicalUnit,  // astronomical unit
         LightYear,  // light year
         Parsec,  // parsec
         Feet,  // feet
         USSurveyFeet,  // US survey feet
         Inch,  // inch
         Yard,  // yard
         Fathom,  // fathom
         Surveyor_sChain,  // surveyor's chain
         Mile,  // mile
         InternationalNauticalMile,  // international nautical mile
         UKNauticalMile,  // UK nautical mile
         ScandinavianMile,  // scandinavian mile
         Inch_32,  // inch/32
         Mil,  // mil
         Thou,  // thou
         Hand,  // hand
         Furlong // furlong
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Decimeter, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimeter
         {UnitChoicesEnum.Centimeter, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimeter
         {UnitChoicesEnum.Millimeter, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimeter
         {UnitChoicesEnum.Micrometer, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometer
         {UnitChoicesEnum.Nanometer, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometer
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.Picometer, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometer
         {UnitChoicesEnum.Decameter, new Guid("0ff9e118-e7d5-4ace-b140-eb3383812b21")},  // decameter
         {UnitChoicesEnum.Hectometer, new Guid("cb5c81a3-b9da-42b5-a2ea-0509df445d01")},  // hectometer
         {UnitChoicesEnum.Kilometer, new Guid("93aee1b8-653d-4841-b948-10460cb84334")},  // kilometer
         {UnitChoicesEnum.AstronomicalUnit, new Guid("0471d74c-cc44-45bd-be0a-aaad6c05f0d0")},  // astronomical unit
         {UnitChoicesEnum.LightYear, new Guid("fc43d439-576f-430c-855e-60b28f70856e")},  // light year
         {UnitChoicesEnum.Parsec, new Guid("0565c7e8-11cb-48de-8d7a-d58c89955d0f")},  // parsec
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.USSurveyFeet, new Guid("eaf5909f-c68e-4346-9517-1dafad48b161")},  // US survey feet
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Yard, new Guid("7b9156e4-7cce-41cf-a251-95412f4d91a5")},  // yard
         {UnitChoicesEnum.Fathom, new Guid("6be602af-ea19-41cc-af7f-8263564c3c3b")},  // fathom
         {UnitChoicesEnum.Surveyor_sChain, new Guid("f101708b-ab63-4f21-ac87-4b5b3615eb30")},  // surveyor's chain
         {UnitChoicesEnum.Mile, new Guid("95736fd3-878b-4d93-9a78-ee6f20619628")},  // mile
         {UnitChoicesEnum.InternationalNauticalMile, new Guid("4c297035-e0cf-4bfe-aa63-d835170e8e25")},  // international nautical mile
         {UnitChoicesEnum.UKNauticalMile, new Guid("3b7a50d6-dc58-4cd7-9a5b-96dba59eceaa")},  // UK nautical mile
         {UnitChoicesEnum.ScandinavianMile, new Guid("22e6763c-4105-4a4c-9dfe-044256a107d1")},  // scandinavian mile
         {UnitChoicesEnum.Inch_32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")},  // inch/32
         {UnitChoicesEnum.Mil, new Guid("648502a7-47e0-42dc-aacc-2e1789b0f1ce")},  // mil
         {UnitChoicesEnum.Thou, new Guid("2ce1b2d1-8157-4ad5-ae85-5d6c634f5c68")},  // thou
         {UnitChoicesEnum.Hand, new Guid("608205f3-8c52-40f2-9796-a586d1cd62da")},  // hand
         {UnitChoicesEnum.Furlong, new Guid("7ce130d1-8147-409f-99b3-bf22b0aae4cc")} // furlong
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class LinearElongationQuantity : DerivedPhysicalQuanity
  {
    public enum UnitChoicesEnum 
      {
         MeterPerMeter,  // meter per meter
         MillimeterPerMeter,  // millimeter per meter
         InchPerFoot // inch per foot
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerMeter, new Guid("cc12967b-4c7d-4c70-95cf-d2f23bd6f76b")},  // meter per meter
         {UnitChoicesEnum.MillimeterPerMeter, new Guid("4e241b59-388a-428f-82e7-b9971f9e1df5")},  // millimeter per meter
         {UnitChoicesEnum.InchPerFoot, new Guid("3df1af23-afd0-41ed-9442-a3af6ae944d2")} // inch per foot
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class LuminousIntensityQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Candela,  // candela
         Lumen_steradian,  // lumen/steradian
         Millicandela,  // millicandela
         Kilocandela,  // kilocandela
         Hefnerkerze,  // hefnerkerze
         InternationalCandle,  // international candle
         DecimalCandle,  // decimal candle
         Candlepower,  // candlepower
         BerlinerLichteinheit,  // berliner lichteinheit
         DVWGCandle,  // DVWG candle
         Violle,  // violle
         Carcel // carcel
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Candela, new Guid("28411995-11f2-4967-92ed-5077237f17e1")},  // candela
         {UnitChoicesEnum.Lumen_steradian, new Guid("5683bf23-cd97-4141-9bf4-62a43750ceda")},  // lumen/steradian
         {UnitChoicesEnum.Millicandela, new Guid("b722e2e1-bcc4-4d6c-ad47-dfd24bb66543")},  // millicandela
         {UnitChoicesEnum.Kilocandela, new Guid("f1159794-14ab-49bb-80de-0164c8172c1f")},  // kilocandela
         {UnitChoicesEnum.Hefnerkerze, new Guid("8059d89c-1ed5-43d3-a9dc-a11de6cd0f8d")},  // hefnerkerze
         {UnitChoicesEnum.InternationalCandle, new Guid("fa25c6d3-c832-42a1-8490-c31131378ee2")},  // international candle
         {UnitChoicesEnum.DecimalCandle, new Guid("a07a3c15-4679-4a6a-a79b-64fe27fa5799")},  // decimal candle
         {UnitChoicesEnum.Candlepower, new Guid("55509967-f1e5-4d79-a707-fcf27a850f98")},  // candlepower
         {UnitChoicesEnum.BerlinerLichteinheit, new Guid("ffd07aaa-486b-495d-bb63-a93d122c35e4")},  // berliner lichteinheit
         {UnitChoicesEnum.DVWGCandle, new Guid("b2fa4a9a-4c5d-4a31-8002-a7bc9e857af5")},  // DVWG candle
         {UnitChoicesEnum.Violle, new Guid("1e53e27a-3e4f-4b68-833f-c7a05fdf094e")},  // violle
         {UnitChoicesEnum.Carcel, new Guid("70b8902f-8a35-4398-b4ba-1e2b4858264f")} // carcel
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Kilogram,  // kilogram
         Hectogram,  // hectogram
         Decagram,  // decagram
         Gram,  // gram
         Centigram,  // centigram
         Milligram,  // milligram
         Microgram,  // microgram
         Nanogram,  // nanogram
         AtomMassUnit,  // atom mass unit
         TonneMetric,  // tonne metric
         Kilotonne,  // kilotonne
         Megatonne,  // megatonne
         Gigatonne,  // gigatonne
         Pound,  // pound
         Ounce,  // ounce
         Stone,  // stone
         TonUK,  // ton UK
         TonUS,  // ton US
         SolarMass,  // solar mass
         EarthMass,  // earth mass
         Cental,  // cental
         Grain,  // grain
         Hundredweights // hundredweights
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kilogram, new Guid("ef4c5fc1-8774-4aea-b772-35aeae56413d")},  // kilogram
         {UnitChoicesEnum.Hectogram, new Guid("2fb79e4b-3eb5-4aa3-9f12-2c66b1784902")},  // hectogram
         {UnitChoicesEnum.Decagram, new Guid("1b3f72cb-55b1-4027-b6ad-309cd7d6c1a3")},  // decagram
         {UnitChoicesEnum.Gram, new Guid("049ba04e-4c70-41f5-bb29-6b54bb5b2103")},  // gram
         {UnitChoicesEnum.Centigram, new Guid("e56aa2fa-80b7-417f-8e08-91b9b8a1198c")},  // centigram
         {UnitChoicesEnum.Milligram, new Guid("322b0e70-c8e5-482e-a9db-682d15baacf9")},  // milligram
         {UnitChoicesEnum.Microgram, new Guid("eb831d52-2690-4b8a-a1a4-83e9bdb07dbc")},  // microgram
         {UnitChoicesEnum.Nanogram, new Guid("93db8c40-4dd0-46a4-ade6-db51bcbca66f")},  // nanogram
         {UnitChoicesEnum.AtomMassUnit, new Guid("f470168e-1e20-458e-b6da-6bee551cb6d6")},  // atom mass unit
         {UnitChoicesEnum.TonneMetric, new Guid("320b99ba-3115-42f5-939c-15a04d9e7e3c")},  // tonne metric
         {UnitChoicesEnum.Kilotonne, new Guid("2a767cda-fc61-4aa4-81dd-1a4f6d6af755")},  // kilotonne
         {UnitChoicesEnum.Megatonne, new Guid("92c4b624-4205-4596-aabf-1dd4aa442718")},  // megatonne
         {UnitChoicesEnum.Gigatonne, new Guid("51cd0591-d741-4769-bd22-e36959d1adcf")},  // gigatonne
         {UnitChoicesEnum.Pound, new Guid("e9e313ad-cb28-43fe-93fd-7f94dfee1878")},  // pound
         {UnitChoicesEnum.Ounce, new Guid("4e64e69b-2276-46c8-a918-06ab6980178c")},  // ounce
         {UnitChoicesEnum.Stone, new Guid("6894dc1c-21e2-42aa-9569-759c0e6e6d6e")},  // stone
         {UnitChoicesEnum.TonUK, new Guid("059c7b81-ed11-410e-9466-4661011372d2")},  // ton UK
         {UnitChoicesEnum.TonUS, new Guid("443af797-a62f-4137-a852-ad1c9163dd7b")},  // ton US
         {UnitChoicesEnum.SolarMass, new Guid("432e73bf-a448-47f6-9c65-9339d5bac5a3")},  // solar mass
         {UnitChoicesEnum.EarthMass, new Guid("f9303406-dfce-45c4-9a1e-299d9bac1d4e")},  // earth mass
         {UnitChoicesEnum.Cental, new Guid("51c7e932-7cff-4c81-95a9-066241d5f010")},  // cental
         {UnitChoicesEnum.Grain, new Guid("dad9b0a5-ce14-4132-b571-6365ab336bc2")},  // grain
         {UnitChoicesEnum.Hundredweights, new Guid("83810f2a-b260-41b3-bc13-5ef60290f214")} // hundredweights
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class NozzleDiameterQuantity : SmallLengthQuantity
  {
    public enum UnitChoicesEnum 
      {
         Centimeter,  // centimeter
         Decimeter,  // decimeter
         Feet,  // feet
         Inch,  // inch
         Metre,  // metre
         Micrometer,  // micrometer
         Millimeter,  // millimeter
         Nanometer,  // nanometer
         Picometer,  // picometer
         Ångstrøm,  // ångstrøm
         Inch_32 // inch/32
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimeter, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimeter
         {UnitChoicesEnum.Decimeter, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimeter
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometer, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometer
         {UnitChoicesEnum.Millimeter, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimeter
         {UnitChoicesEnum.Nanometer, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometer
         {UnitChoicesEnum.Picometer, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometer
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.Inch_32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")} // inch/32
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PipeDiameterQuantity : SmallLengthQuantity
  {
    public enum UnitChoicesEnum 
      {
         Centimeter,  // centimeter
         Decimeter,  // decimeter
         Feet,  // feet
         Inch,  // inch
         Metre,  // metre
         Micrometer,  // micrometer
         Millimeter,  // millimeter
         Nanometer,  // nanometer
         Picometer,  // picometer
         Ångstrøm,  // ångstrøm
         Inch_32 // inch/32
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimeter, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimeter
         {UnitChoicesEnum.Decimeter, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimeter
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometer, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometer
         {UnitChoicesEnum.Millimeter, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimeter
         {UnitChoicesEnum.Nanometer, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometer
         {UnitChoicesEnum.Picometer, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometer
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.Inch_32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")} // inch/32
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PlaneAngleQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Radian,  // radian
         Milliradian,  // milliradian
         Degree,  // degree
         Grad,  // grad
         Gon,  // gon
         Circle,  // circle
         Revolution,  // revolution
         Quadrant,  // quadrant
         Sextant,  // sextant
         Octant,  // octant
         ArcMinute,  // arc minute
         ArcSecond // arc second
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Radian, new Guid("a71fc712-342a-48c2-8e45-b56ee31c7ae0")},  // radian
         {UnitChoicesEnum.Milliradian, new Guid("34a37faf-dfb9-4a34-899c-c9fa78f295a5")},  // milliradian
         {UnitChoicesEnum.Degree, new Guid("023a3393-a01e-499f-967a-a76b1a78d586")},  // degree
         {UnitChoicesEnum.Grad, new Guid("584314cf-a10f-49b6-a5e9-1cfa0ec0f355")},  // grad
         {UnitChoicesEnum.Gon, new Guid("feefeed5-2df2-4c66-84f1-0de998ba44db")},  // gon
         {UnitChoicesEnum.Circle, new Guid("e27aeec3-667d-41bb-9bd2-60bf213f8b7b")},  // circle
         {UnitChoicesEnum.Revolution, new Guid("e613477b-f8bc-45c7-8ccc-391a7f33af05")},  // revolution
         {UnitChoicesEnum.Quadrant, new Guid("dedbbea6-40e7-439a-9409-220fee4c148a")},  // quadrant
         {UnitChoicesEnum.Sextant, new Guid("ce4197b4-6d9d-488b-a360-98899a82837e")},  // sextant
         {UnitChoicesEnum.Octant, new Guid("8f78bfce-cad9-4a77-aa5f-3a5fecc89364")},  // octant
         {UnitChoicesEnum.ArcMinute, new Guid("e1ce9562-ecd0-46e2-82e2-bcec1b6ac113")},  // arc minute
         {UnitChoicesEnum.ArcSecond, new Guid("bea092da-34d6-4130-bc65-41fb7702597a")} // arc second
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PositionQuantity : LengthQuantity
  {
    public enum UnitChoicesEnum 
      {
         Metre,  // metre
         Kilometer,  // kilometer
         Feet,  // feet
         USSurveyFeet,  // US survey feet
         Yard,  // yard
         Surveyor_sChain,  // surveyor's chain
         Mile // mile
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Kilometer, new Guid("93aee1b8-653d-4841-b948-10460cb84334")},  // kilometer
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.USSurveyFeet, new Guid("eaf5909f-c68e-4346-9517-1dafad48b161")},  // US survey feet
         {UnitChoicesEnum.Yard, new Guid("7b9156e4-7cce-41cf-a251-95412f4d91a5")},  // yard
         {UnitChoicesEnum.Surveyor_sChain, new Guid("f101708b-ab63-4f21-ac87-4b5b3615eb30")},  // surveyor's chain
         {UnitChoicesEnum.Mile, new Guid("95736fd3-878b-4d93-9a78-ee6f20619628")} // mile
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class RelativeTemperatureQuantity : TemperatureQuantity
  {
    public enum UnitChoicesEnum 
      {
         Kelvin,  // kelvin
         RelativeCelcius,  // Relative Celcius
         Rankine // Rankine
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kelvin, new Guid("8fc5fa10-2d89-4064-8ace-b852d9a8d31f")},  // kelvin
         {UnitChoicesEnum.RelativeCelcius, new Guid("10ea31a1-e661-41c9-9a3d-245904b73599")},  // Relative Celcius
         {UnitChoicesEnum.Rankine, new Guid("62f3ffbc-eda3-400a-9fb7-8d021771f0fa")} // Rankine
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class SmallLengthQuantity : LengthQuantity
  {
    public enum UnitChoicesEnum 
      {
         Centimeter,  // centimeter
         Decimeter,  // decimeter
         Feet,  // feet
         Inch,  // inch
         Metre,  // metre
         Micrometer,  // micrometer
         Millimeter,  // millimeter
         Nanometer,  // nanometer
         Picometer,  // picometer
         Ångstrøm,  // ångstrøm
         Inch_32 // inch/32
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimeter, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimeter
         {UnitChoicesEnum.Decimeter, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimeter
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometer, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometer
         {UnitChoicesEnum.Millimeter, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimeter
         {UnitChoicesEnum.Nanometer, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometer
         {UnitChoicesEnum.Picometer, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometer
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.Inch_32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")} // inch/32
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class SolidAngleQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Steradian,  // steradian
         Spat,  // spat
         SquareDegree // square degree
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Steradian, new Guid("aee057f5-3235-4976-b6e6-a57179f0173e")},  // steradian
         {UnitChoicesEnum.Spat, new Guid("44abc0c0-d564-442a-ac80-b08c9d499867")},  // spat
         {UnitChoicesEnum.SquareDegree, new Guid("ad4b94e8-1a86-42ab-bfc6-9cc7ff7a835f")} // square degree
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class TemperatureQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Kelvin,  // kelvin
         Celsius,  // celsius
         Fahrenheit,  // fahrenheit
         Réaumure // réaumure
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kelvin, new Guid("8fc5fa10-2d89-4064-8ace-b852d9a8d31f")},  // kelvin
         {UnitChoicesEnum.Celsius, new Guid("5d69048e-fe18-4923-9341-cb80c2ccf8cc")},  // celsius
         {UnitChoicesEnum.Fahrenheit, new Guid("55c289ab-6975-439f-9b7a-fdca6d219a9f")},  // fahrenheit
         {UnitChoicesEnum.Réaumure, new Guid("968def6c-bc85-49b0-84a8-3ac7ad37efc6")} // réaumure
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class TimeQuantity : BasePhysicalQuantity
  {
    public enum UnitChoicesEnum 
      {
         Second,  // second
         Millisecond,  // millisecond
         Microsecond,  // microsecond
         Shake,  // shake
         Nanosecond,  // nanosecond
         Picosecond,  // picosecond
         Minute,  // minute
         Hour,  // hour
         Day,  // day
         Week,  // week
         Fornight,  // fornight
         MonthCommon,  // month common
         MonthSynodic,  // month synodic
         QuaterCommon,  // quater common
         YearCommon,  // year common
         YearAverageGregorian,  // year average gregorian
         YearJulian,  // year julian
         YearLeap,  // year leap
         YearTropical,  // year tropical
         Decade,  // decade
         Century,  // century
         Millenia,  // millenia
         MillionYear // million year
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Second, new Guid("eac42b09-cc85-4e29-9aaf-05fe73bca2aa")},  // second
         {UnitChoicesEnum.Millisecond, new Guid("1c1b150f-80a0-47da-836c-a583c4fa4b74")},  // millisecond
         {UnitChoicesEnum.Microsecond, new Guid("18cf5c8f-bdd4-4575-a74b-f8321c567edb")},  // microsecond
         {UnitChoicesEnum.Shake, new Guid("f2b06fdd-ddfe-430b-8107-11597bdfdf2f")},  // shake
         {UnitChoicesEnum.Nanosecond, new Guid("6bf1a718-637c-4e86-ae3e-426d2a1a9195")},  // nanosecond
         {UnitChoicesEnum.Picosecond, new Guid("9e10f905-4dc5-4670-9adf-278afd7d4131")},  // picosecond
         {UnitChoicesEnum.Minute, new Guid("4b9dc241-388b-4b7a-b862-48db43234c4a")},  // minute
         {UnitChoicesEnum.Hour, new Guid("f0d815e4-9bef-4422-94e6-1de52216b611")},  // hour
         {UnitChoicesEnum.Day, new Guid("85442621-bb56-4e2a-8e77-2b72409ff84f")},  // day
         {UnitChoicesEnum.Week, new Guid("4dd50f01-60b3-4d44-82ea-ff8ededd797d")},  // week
         {UnitChoicesEnum.Fornight, new Guid("bc87f864-3dc1-4f1a-87bc-4123a47c53dc")},  // fornight
         {UnitChoicesEnum.MonthCommon, new Guid("41cceaa2-1a1d-40f1-9195-5183be9770d4")},  // month common
         {UnitChoicesEnum.MonthSynodic, new Guid("31edcda9-df8f-4d15-83a9-7dafd8a7e404")},  // month synodic
         {UnitChoicesEnum.QuaterCommon, new Guid("71f0e01a-c1a2-49ba-a25b-c11854f8867c")},  // quater common
         {UnitChoicesEnum.YearCommon, new Guid("38481414-3b9d-472d-ac31-04b00dcc9d5c")},  // year common
         {UnitChoicesEnum.YearAverageGregorian, new Guid("fc33008b-9517-440f-a56b-189c5d80621b")},  // year average gregorian
         {UnitChoicesEnum.YearJulian, new Guid("281f6c7b-da23-4aab-89e1-994e52280658")},  // year julian
         {UnitChoicesEnum.YearLeap, new Guid("c84c1293-82d4-481b-8f6e-8bb8b81e6273")},  // year leap
         {UnitChoicesEnum.YearTropical, new Guid("e93c0b95-68b1-4ecc-9b27-f07a9a53ad49")},  // year tropical
         {UnitChoicesEnum.Decade, new Guid("b7d3b041-7119-45a6-a5ea-e05d7cb3c68b")},  // decade
         {UnitChoicesEnum.Century, new Guid("5cf296b6-48bf-4cc1-bf79-0220100ef1db")},  // century
         {UnitChoicesEnum.Millenia, new Guid("c235c8fc-f15b-45ff-a1b7-aab46ccea159")},  // millenia
         {UnitChoicesEnum.MillionYear, new Guid("d0281a3c-86dd-4d05-b856-cb7fa67c0f4d")} // million year
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
namespace OSDC.UnitConversion.Conversion
{
  public partial class PoreDiameterQuantity : SmallLengthQuantity
  {
    public enum UnitChoicesEnum 
      {
         Centimeter,  // centimeter
         Decimeter,  // decimeter
         Feet,  // feet
         Inch,  // inch
         Metre,  // metre
         Micrometer,  // micrometer
         Millimeter,  // millimeter
         Nanometer,  // nanometer
         Picometer,  // picometer
         Ångstrøm,  // ångstrøm
         Inch_32 // inch/32
      }
    protected Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimeter, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimeter
         {UnitChoicesEnum.Decimeter, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimeter
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometer, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometer
         {UnitChoicesEnum.Millimeter, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimeter
         {UnitChoicesEnum.Nanometer, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometer
         {UnitChoicesEnum.Picometer, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometer
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.Inch_32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")} // inch/32
    };
    public UnitChoice GetUnitChoice(UnitChoicesEnum choice)
    {
       UnitChoice c = null;
       Guid guid;
       if (enumLookUp_.TryGetValue(choice, out guid))
       {
         c = GetUnitChoice(guid);
       }
       return c;
    }
  }
}
