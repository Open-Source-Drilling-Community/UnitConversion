using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingPhysicalQuantity : PhysicalQuantity
  {
     public new enum QuantityEnum 
       {
         BlockVelocity,  // BlockVelocity
         CableDiameter,  // Cable Diameter
         CapillaryPressure,  // CapillaryPressure
         Depth,  // Depth
         DrillingAcceleration,  // DrillingAcceleration
         DrillingAngleVariationGradient,  // DrillingAngleVariationGradient
         DrillingAngularVelocity,  // DrillingAngularVelocity
         DrillingArea,  // DrillingArea
         DrillingAxialVelocity,  // DrillingAxialVelocity
         DrillingCompressibility,  // DrillingCompressibility
         DrillingCurvature,  // DrillingCurvature
         DrillingDensityGradientDepth,  // DrillingDensityGradientDepth
         DrillingDensityGradientTemperature,  // DrillingDensityGradientTemperature
         DrillingDensity,  // DrillingDensity
         DrillingDensitySpeed,  // DrillingDensitySpeed
         DrillingDrillStringMagneticFlux,  // DrillingDrillStringMagneticFlux
         DrillingDuration,  // DrillingDuration
         DrillingDynamicViscosity,  // DrillingDynamicViscosity
         DrillingElongationGradient,  // DrillingElongationGradient
         DrillingFluidVelocity,  // DrillingFluidVelocity
         DrillingForceGradient,  // DrillingForceGradient
         DrillingForce,  // DrillingForce
         DrillingHeatTransferCoefficient,  // DrillingHeatTransferCoefficient
         DrillingHydraulicConductivity,  // DrillingHydraulicConductivity
         DrillingInterfacialTension,  // DrillingInterfacialTension
         DrillingMassGradient,  // DrillingMassGradient
         DrillingMass,  // DrillingMass
         DrillingMassRate,  // DrillingMassRate
         DrillingPlaneAngle,  // DrillingPlaneAngle
         DrillingPower,  // DrillingPower
         DrillingPressureGradient,  // DrillingPressureGradient
         DrillingPressureLossConstant,  // DrillingPressureLossConstant
         DrillingPressure,  // DrillingPressure
         DrillingRandomWalk,  // DrillingRandomWalk
         DrillingRotationFrequencyRateOfChange,  // DrillingRotationFrequencyRateOfChange
         DrillingSpecificHeatCapacity,  // DrillingSpecificHeatCapacity
         DrillingSpecificHeatCapacityTemperatureGradient,  // DrillingSpecificHeatCapacityTemperatureGradient
         DrillingStickDuration,  // DrillingStickDuration
         DrillingSurveyInstrumentMagneticFluxDensity,  // DrillingSurveyInstrumentMagneticFluxDensity
         DrillingSurveyInstrumentAngularVelocity,  // DrillingSurveyInstrumentAngularVelocity
         DrillingSurveyInstrumentReciprocalLength,  // DrillingSurveyInstrumentReciprocalLength
         DrillingTemperatureGradient,  // DrillingTemperatureGradient
         DrillingTemperature,  // DrillingTemperature
         DrillingTension,  // DrillingTension
         DrillingThermalConductivity,  // DrillingThermalConductivity
         DrillingThermalConductivityTemperatureGradient,  // DrillingThermalConductivityTemperatureGradient
         DrillingTorque,  // DrillingTorque
         DrillingVolume,  // DrillingVolume
         DrillingVolumetricFlowRateOfChange,  // DrillingVolumetricFlowRateOfChange
         DrillingVolumetricFlowrate,  // DrillingVolumetricFlowrate
         DrillStemMaterialStrength,  // DrillStemMaterialStrength
         FormationResistivity,  // FormationResistivity
         FormationStrength,  // FormationStrength
         GammaRay,  // GammaRay
         GasShow,  // GasShow
         GasVolmetricFlowRate,  // GasVolmetricFlowRate
         Height,  // Height
         HookLoad,  // HookLoad
         NozzleDiameter,  // Nozzle Diameter
         PipeDiameter,  // Pipe Diameter
         PoreDiameter,  // Pore Diameter
         PoreSurface,  // PoreSurface
         Position,  // Position
         RateOfPenetration,  // RateOfPenetration
         WeightOnBit,  // WeightOnBit
         ShockRate // ShockRate
       }
    protected static new Dictionary<QuantityEnum, Guid> enumLookUp_ = new Dictionary<QuantityEnum, Guid>()
    {
         {QuantityEnum.BlockVelocity, new Guid("82a2b5fc-9edd-45ea-80cb-1cd46d516fdb")},  // BlockVelocity
         {QuantityEnum.CableDiameter, new Guid("6b3db5b2-7e30-47f7-91c5-5951dd3f9246")},  // Cable Diameter
         {QuantityEnum.CapillaryPressure, new Guid("72228ff1-9ba8-44f0-b9b1-85fa8dfb32ea")},  // CapillaryPressure
         {QuantityEnum.Depth, new Guid("c0d965b2-a153-420a-9d03-7a2a272d619e")},  // Depth
         {QuantityEnum.DrillingAcceleration, new Guid("b6c99136-8e57-4eea-9a31-fb804bc8ae4b")},  // DrillingAcceleration
         {QuantityEnum.DrillingAngleVariationGradient, new Guid("e6f22876-ca88-4d0e-a4a5-c76b0db3556f")},  // DrillingAngleVariationGradient
         {QuantityEnum.DrillingAngularVelocity, new Guid("046cb449-8cab-4d0c-bb28-3e2060f292e5")},  // DrillingAngularVelocity
         {QuantityEnum.DrillingArea, new Guid("21fc0373-6eda-460b-bacb-070abf2f3add")},  // DrillingArea
         {QuantityEnum.DrillingAxialVelocity, new Guid("e278ace8-d577-4fb4-8d1d-dd8a3d072027")},  // DrillingAxialVelocity
         {QuantityEnum.DrillingCompressibility, new Guid("bfec67e2-839f-47d7-968c-69287567835d")},  // DrillingCompressibility
         {QuantityEnum.DrillingCurvature, new Guid("0e41ce3a-a0e4-44a3-bf6e-6c2a70f4a28b")},  // DrillingCurvature
         {QuantityEnum.DrillingDensityGradientDepth, new Guid("787c3f65-b6d5-4866-885b-12571b1d9734")},  // DrillingDensityGradientDepth
         {QuantityEnum.DrillingDensityGradientTemperature, new Guid("b5ccd49c-a9fd-4cfd-8dd1-fb4d3f8c3ad5")},  // DrillingDensityGradientTemperature
         {QuantityEnum.DrillingDensity, new Guid("60f2af98-56e4-4f9c-8438-59646a35fc0d")},  // DrillingDensity
         {QuantityEnum.DrillingDensitySpeed, new Guid("af63f164-0fb7-42c0-ac55-06e40b6c12e5")},  // DrillingDensitySpeed
         {QuantityEnum.DrillingDrillStringMagneticFlux, new Guid("3a58147b-88db-4474-8390-dd0e0f7d206b")},  // DrillingDrillStringMagneticFlux
         {QuantityEnum.DrillingDuration, new Guid("22443197-6bcf-45f7-9079-4f710585af60")},  // DrillingDuration
         {QuantityEnum.DrillingDynamicViscosity, new Guid("e9b32538-f7f4-4f99-a206-0601a4e4a5f8")},  // DrillingDynamicViscosity
         {QuantityEnum.DrillingElongationGradient, new Guid("4410a514-a65a-48ca-82d1-ab788b3d2df9")},  // DrillingElongationGradient
         {QuantityEnum.DrillingFluidVelocity, new Guid("dac9cee1-59a3-42d5-98c6-0c7baf5083bb")},  // DrillingFluidVelocity
         {QuantityEnum.DrillingForceGradient, new Guid("78942f39-d764-42f1-b270-47a3b35e5112")},  // DrillingForceGradient
         {QuantityEnum.DrillingForce, new Guid("30c08b42-6a89-4d99-879b-882eb7ed46d0")},  // DrillingForce
         {QuantityEnum.DrillingHeatTransferCoefficient, new Guid("c99547c5-b545-4060-bd82-eadc13772493")},  // DrillingHeatTransferCoefficient
         {QuantityEnum.DrillingHydraulicConductivity, new Guid("6cc821d6-b979-4bf9-b1cc-ac266b221330")},  // DrillingHydraulicConductivity
         {QuantityEnum.DrillingInterfacialTension, new Guid("1bf5cf90-84c4-4dcc-ac74-92223d3c3c46")},  // DrillingInterfacialTension
         {QuantityEnum.DrillingMassGradient, new Guid("dc474098-a2b5-44fb-b56a-0ae20ff62ad6")},  // DrillingMassGradient
         {QuantityEnum.DrillingMass, new Guid("f4c0a6fd-5000-4507-8612-ae4374c0cacc")},  // DrillingMass
         {QuantityEnum.DrillingMassRate, new Guid("0e218b8e-bc7c-4902-b88d-1cdab4a5dc94")},  // DrillingMassRate
         {QuantityEnum.DrillingPlaneAngle, new Guid("94ad3e73-2a44-4c60-bbca-188b941f3357")},  // DrillingPlaneAngle
         {QuantityEnum.DrillingPower, new Guid("d7f0d3a8-2d15-4ae9-897a-5d1ef7feef8a")},  // DrillingPower
         {QuantityEnum.DrillingPressureGradient, new Guid("92a284e7-9898-41f7-950d-4ba9f1ec550b")},  // DrillingPressureGradient
         {QuantityEnum.DrillingPressureLossConstant, new Guid("fd799f5c-0963-4201-aec3-e531df6b226e")},  // DrillingPressureLossConstant
         {QuantityEnum.DrillingPressure, new Guid("d9db6bb4-77af-4fc3-a683-7bedd781fcba")},  // DrillingPressure
         {QuantityEnum.DrillingRandomWalk, new Guid("8817dc80-eb46-42d5-b85f-703fa8845f32")},  // DrillingRandomWalk
         {QuantityEnum.DrillingRotationFrequencyRateOfChange, new Guid("4950170a-7882-4673-9d27-3402dbbca2bb")},  // DrillingRotationFrequencyRateOfChange
         {QuantityEnum.DrillingSpecificHeatCapacity, new Guid("05c59293-4e3b-4fc0-b579-12c241109610")},  // DrillingSpecificHeatCapacity
         {QuantityEnum.DrillingSpecificHeatCapacityTemperatureGradient, new Guid("5f180166-bc44-4855-916f-236a5a31893d")},  // DrillingSpecificHeatCapacityTemperatureGradient
         {QuantityEnum.DrillingStickDuration, new Guid("1e9bafaa-bbf1-4a29-9811-39b5e2280499")},  // DrillingStickDuration
         {QuantityEnum.DrillingSurveyInstrumentMagneticFluxDensity, new Guid("a3ad9fd6-a516-42c8-98a5-14e178dc62f2")},  // DrillingSurveyInstrumentMagneticFluxDensity
         {QuantityEnum.DrillingSurveyInstrumentAngularVelocity, new Guid("76dd6ac8-8b67-416c-b41f-07bbf4065cdb")},  // DrillingSurveyInstrumentAngularVelocity
         {QuantityEnum.DrillingSurveyInstrumentReciprocalLength, new Guid("c198aa3b-3b24-402d-b60b-f54ff9430f33")},  // DrillingSurveyInstrumentReciprocalLength
         {QuantityEnum.DrillingTemperatureGradient, new Guid("82b91f3f-d1ec-476b-98e0-eedbba6281ec")},  // DrillingTemperatureGradient
         {QuantityEnum.DrillingTemperature, new Guid("84ce5a77-fd76-4014-ad8e-03f194c3e329")},  // DrillingTemperature
         {QuantityEnum.DrillingTension, new Guid("fe8fd6fd-814c-44c9-9462-f034dd46dc85")},  // DrillingTension
         {QuantityEnum.DrillingThermalConductivity, new Guid("186eef6a-9da3-4b97-a6d0-d496bdf59321")},  // DrillingThermalConductivity
         {QuantityEnum.DrillingThermalConductivityTemperatureGradient, new Guid("559ae484-42ed-4379-86f5-67dae451a9c9")},  // DrillingThermalConductivityTemperatureGradient
         {QuantityEnum.DrillingTorque, new Guid("eff33c0e-1e92-49e4-a7ab-716d9d66a157")},  // DrillingTorque
         {QuantityEnum.DrillingVolume, new Guid("b8c9f810-d576-4523-a26f-921305c7f7b4")},  // DrillingVolume
         {QuantityEnum.DrillingVolumetricFlowRateOfChange, new Guid("244ade8c-591d-44d4-bca6-3798046d90a1")},  // DrillingVolumetricFlowRateOfChange
         {QuantityEnum.DrillingVolumetricFlowrate, new Guid("7b12c115-3c20-4d45-b4cf-86af29255b14")},  // DrillingVolumetricFlowrate
         {QuantityEnum.DrillStemMaterialStrength, new Guid("fd58fca3-6221-4e85-a7aa-a021ee04e8a8")},  // DrillStemMaterialStrength
         {QuantityEnum.FormationResistivity, new Guid("ed01d6da-225d-4bcc-beac-55ccdb6fb0b9")},  // FormationResistivity
         {QuantityEnum.FormationStrength, new Guid("55a8119f-4609-4d51-91b4-e2281c46c779")},  // FormationStrength
         {QuantityEnum.GammaRay, new Guid("15280017-0ac6-4dad-a6e1-1efdb05e64c5")},  // GammaRay
         {QuantityEnum.GasShow, new Guid("c81adbce-b90b-4889-8b79-921d95b35179")},  // GasShow
         {QuantityEnum.GasVolmetricFlowRate, new Guid("453bbddf-4979-4557-ba76-3fd3420fd97e")},  // GasVolmetricFlowRate
         {QuantityEnum.Height, new Guid("8ec20e78-3307-4363-9fc1-97c64a4b6e6e")},  // Height
         {QuantityEnum.HookLoad, new Guid("126be5e9-ed09-459e-92ce-32a5fcd81f0a")},  // HookLoad
         {QuantityEnum.NozzleDiameter, new Guid("1fbe2318-851d-4fd7-b711-9c23ffe544c7")},  // Nozzle Diameter
         {QuantityEnum.PipeDiameter, new Guid("28a2fe65-db50-46ec-8b1d-2a26286a5813")},  // Pipe Diameter
         {QuantityEnum.PoreDiameter, new Guid("781affbc-fae3-40a0-a110-fd3bdfd7d41f")},  // Pore Diameter
         {QuantityEnum.PoreSurface, new Guid("c88cc254-b870-44a6-b896-5863472bdcd0")},  // PoreSurface
         {QuantityEnum.Position, new Guid("20f58500-7e00-41e7-acc4-99e9de9bfd07")},  // Position
         {QuantityEnum.RateOfPenetration, new Guid("c2581b41-944c-410b-9805-62c4b54de510")},  // RateOfPenetration
         {QuantityEnum.WeightOnBit, new Guid("5e75da44-a675-4f0e-a0fb-52b2cb6797ce")},  // WeightOnBit
         {QuantityEnum.ShockRate, new Guid("0076d96f-bfc3-4f98-8541-4fd12e4bcbff")} // ShockRate
    };
  }
}

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class BlockVelocityQuantity : VelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerSecond,  // MeterPerSecond
         MeterPerMinute,  // MeterPerMinute
         MeterPerHour,  // MeterPerHour
         FootPerHour,  // FootPerHour
         FootPerMinute,  // FootPerMinute
         FootPerSecond // FootPerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // MeterPerSecond
         {UnitChoicesEnum.MeterPerMinute, new Guid("824d3b5b-1e51-446a-99a4-39c02377f303")},  // MeterPerMinute
         {UnitChoicesEnum.MeterPerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // MeterPerHour
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")},  // FootPerHour
         {UnitChoicesEnum.FootPerMinute, new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076")},  // FootPerMinute
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")} // FootPerSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class CableDiameterQuantity : SmallLengthQuantity
  {
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class CapillaryPressureQuantity : PressureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // Pascal
         Bar,  // Bar
         PoundPerSquareInch,  // PoundPerSquareInch
         KiloPascal,  // KiloPascal
         MegaPascal,  // MegaPascal
         KiloPoundPerSquareInch // KiloPoundPerSquareInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // Pascal
         {UnitChoicesEnum.Bar, new Guid("0d182739-f8f6-47a6-afcb-71feac973307")},  // Bar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // PoundPerSquareInch
         {UnitChoicesEnum.KiloPascal, new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29")},  // KiloPascal
         {UnitChoicesEnum.MegaPascal, new Guid("4ef28797-f416-4d97-b36a-711ea848bcc0")},  // MegaPascal
         {UnitChoicesEnum.KiloPoundPerSquareInch, new Guid("a07b5fe5-87e3-4422-afe1-f54de24deeb8")} // KiloPoundPerSquareInch
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DepthQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Metre,  // metre
         Feet // feet
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingAccelerationQuantity : AccelerationQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerSecondSquare,  // MeterPerSecondSquare
         FootPerSecondSquare // FootPerSecondSquare
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerSecondSquare, new Guid("20515c0b-8a90-4e76-a2b3-cab213db5a06")},  // MeterPerSecondSquare
         {UnitChoicesEnum.FootPerSecondSquare, new Guid("74f20b52-6c15-40e2-ae23-5493326fc879")} // FootPerSecondSquare
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingAngleVariationGradientQuantity : AngleVariationGradientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerMeter,  // RadianPerMeter
         DegreePerMeter,  // DegreePerMeter
         DegreePerFoot,  // DegreePerFoot
         DegreePerCentimeter,  // DegreePerCentimeter
         DegreePerInch // DegreePerInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerMeter, new Guid("5d9782b6-c4c7-47ca-a86b-dce3f63c3747")},  // RadianPerMeter
         {UnitChoicesEnum.DegreePerMeter, new Guid("2fcd4219-8879-4494-9563-5173ec2292fa")},  // DegreePerMeter
         {UnitChoicesEnum.DegreePerFoot, new Guid("23bf7716-5779-4607-aef7-1e0eeb7f201b")},  // DegreePerFoot
         {UnitChoicesEnum.DegreePerCentimeter, new Guid("7f4f63d6-5ea8-4c6b-8be4-81f52b7060c7")},  // DegreePerCentimeter
         {UnitChoicesEnum.DegreePerInch, new Guid("271db65d-2a9f-4fec-a52a-21e13e106dd4")} // DegreePerInch
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingAngularVelocityQuantity : AngularVelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSecond,  // RadianPerSecond
         DegreePerSecond // DegreePerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSecond, new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a")},  // RadianPerSecond
         {UnitChoicesEnum.DegreePerSecond, new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e")} // DegreePerSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingAreaQuantity : AreaQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMeter,  // SquareMeter
         SquareFoot,  // SquareFoot
         SquareDecimeter,  // SquareDecimeter
         SquareYard,  // SquareYard
         SquareCentimeter,  // SquareCentimeter
         SquareInch // SquareInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMeter, new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee")},  // SquareMeter
         {UnitChoicesEnum.SquareFoot, new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248")},  // SquareFoot
         {UnitChoicesEnum.SquareDecimeter, new Guid("125fd8d6-d1eb-4826-a952-5219603409ab")},  // SquareDecimeter
         {UnitChoicesEnum.SquareYard, new Guid("ae3df24c-e5db-4b88-9e81-228f29855f1b")},  // SquareYard
         {UnitChoicesEnum.SquareCentimeter, new Guid("d74bb2bc-9c86-4be4-bff1-88cac7b1049b")},  // SquareCentimeter
         {UnitChoicesEnum.SquareInch, new Guid("294bc6d0-5be7-4c70-95f3-ad9dc50f02cf")} // SquareInch
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingAxialVelocityQuantity : VelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerSecond,  // MeterPerSecond
         MeterPerMinute,  // MeterPerMinute
         MeterPerHour,  // MeterPerHour
         FootPerHour,  // FootPerHour
         FootPerMinute,  // FootPerMinute
         FootPerSecond // FootPerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // MeterPerSecond
         {UnitChoicesEnum.MeterPerMinute, new Guid("824d3b5b-1e51-446a-99a4-39c02377f303")},  // MeterPerMinute
         {UnitChoicesEnum.MeterPerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // MeterPerHour
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")},  // FootPerHour
         {UnitChoicesEnum.FootPerMinute, new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076")},  // FootPerMinute
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")} // FootPerSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingCompressibilityQuantity : CompressibilityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         InverseBar,  // InverseBar
         InversePascal,  // InversePascal
         InversePoundPerSquareInch // InversePoundPerSquareInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.InverseBar, new Guid("4a0f6df4-0d2d-489b-80f1-511be7713101")},  // InverseBar
         {UnitChoicesEnum.InversePascal, new Guid("0e259998-c8bb-4a4d-b281-afb8008b2693")},  // InversePascal
         {UnitChoicesEnum.InversePoundPerSquareInch, new Guid("282ab24c-6c43-4710-8e52-433bdf90cc2e")} // InversePoundPerSquareInch
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingCurvatureQuantity : CurvatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerMeter,  // RadianPerMeter
         DegreePer10m,  // DegreePer10m
         DegreePer30m,  // DegreePer30m
         DegreePer30ft,  // DegreePer30ft
         DegreePer100ft // DegreePer100ft
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerMeter, new Guid("cbba2f64-9914-4c00-a3fe-3c2aef560225")},  // RadianPerMeter
         {UnitChoicesEnum.DegreePer10m, new Guid("c62408d6-c3c5-47bd-8cb0-4fa9faf51598")},  // DegreePer10m
         {UnitChoicesEnum.DegreePer30m, new Guid("98a4d593-c959-49fb-ba1a-b1aa61830cd7")},  // DegreePer30m
         {UnitChoicesEnum.DegreePer30ft, new Guid("284dca7d-b1fc-4e40-ab08-a3e0fa2ef9d0")},  // DegreePer30ft
         {UnitChoicesEnum.DegreePer100ft, new Guid("5aa20ab5-6800-48db-abb1-4c3538b0972d")} // DegreePer100ft
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingDensityGradientDepthQuantity : DensityGradientDepthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMeterPerMeter,  // KilogramPerCubicMeterPerMeter
         GramPerCubicCentimeterPer100Meter,  // GramPerCubicCentimeterPer100Meter
         PoundPerGallonUKPer100Foot,  // PoundPerGallonUKPer100Foot
         PoundPerGallonUKPer30Foot,  // PoundPerGallonUKPer30Foot
         PoundPerGallonUKPerFoot,  // PoundPerGallonUKPerFoot
         PoundPerGallonUSPer100Foot,  // PoundPerGallonUSPer100Foot
         PoundPerGallonUSPer30Foot,  // PoundPerGallonUSPer30Foot
         PoundPerGallonUSPerFoot,  // PoundPerGallonUSPerFoot
         SpecificGravityPer100Meter,  // SpecificGravityPer100Meter
         SpecificGravityPer10Meter,  // SpecificGravityPer10Meter
         SpecificGravityPer30Meter,  // SpecificGravityPer30Meter
         SpecificGravityPerMeter // SpecificGravityPerMeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMeterPerMeter, new Guid("00707a6a-2e33-4214-9f8c-3e64eaa82ec1")},  // KilogramPerCubicMeterPerMeter
         {UnitChoicesEnum.GramPerCubicCentimeterPer100Meter, new Guid("361f976c-6271-41d2-8da3-6b4009cf5e06")},  // GramPerCubicCentimeterPer100Meter
         {UnitChoicesEnum.PoundPerGallonUKPer100Foot, new Guid("f4b6b8a9-c222-4ac9-a6bb-072a9ca7d567")},  // PoundPerGallonUKPer100Foot
         {UnitChoicesEnum.PoundPerGallonUKPer30Foot, new Guid("684acd16-b420-4952-bc42-ffb47044074d")},  // PoundPerGallonUKPer30Foot
         {UnitChoicesEnum.PoundPerGallonUKPerFoot, new Guid("f2e67c73-3706-4c14-b23a-afe474b2ecbe")},  // PoundPerGallonUKPerFoot
         {UnitChoicesEnum.PoundPerGallonUSPer100Foot, new Guid("658a9698-d34b-4a56-9ee3-3cf6e46a52a3")},  // PoundPerGallonUSPer100Foot
         {UnitChoicesEnum.PoundPerGallonUSPer30Foot, new Guid("389150f0-4602-4468-bba3-a8eaf1d36ca0")},  // PoundPerGallonUSPer30Foot
         {UnitChoicesEnum.PoundPerGallonUSPerFoot, new Guid("56128f8e-f59e-4f30-927b-35acb6ab44b1")},  // PoundPerGallonUSPerFoot
         {UnitChoicesEnum.SpecificGravityPer100Meter, new Guid("af987ef2-c8e5-470a-bc53-b2fff05d2c6a")},  // SpecificGravityPer100Meter
         {UnitChoicesEnum.SpecificGravityPer10Meter, new Guid("4af1c9f0-480c-4e80-a62b-c6b57b486c3f")},  // SpecificGravityPer10Meter
         {UnitChoicesEnum.SpecificGravityPer30Meter, new Guid("f8499728-220b-4b2d-94b2-3dc2cdfa6a92")},  // SpecificGravityPer30Meter
         {UnitChoicesEnum.SpecificGravityPerMeter, new Guid("07964c1e-b0d5-4785-bee4-8b4b8882b8b2")} // SpecificGravityPerMeter
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingDensityGradientTemperatureQuantity : DensityGradientTemperatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMeterPerKelvin,  // KilogramPerCubicMeterPerKelvin
         GramPerCubicCentimeterPerCelsius,  // GramPerCubicCentimeterPerCelsius
         PoundPerGallonUKPerCelsius,  // PoundPerGallonUKPerCelsius
         PoundPerGallonUSPerFarenheit,  // PoundPerGallonUSPerFarenheit
         SpecificGravityPerCelsius // SpecificGravityPerCelsius
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMeterPerKelvin, new Guid("8b947453-ebe8-4fa9-b59a-87557150e1cf")},  // KilogramPerCubicMeterPerKelvin
         {UnitChoicesEnum.GramPerCubicCentimeterPerCelsius, new Guid("e78e2b25-e0a7-4c06-b6df-60f97f767a20")},  // GramPerCubicCentimeterPerCelsius
         {UnitChoicesEnum.PoundPerGallonUKPerCelsius, new Guid("edac57eb-7535-447f-bcf9-0c6709b6ae3b")},  // PoundPerGallonUKPerCelsius
         {UnitChoicesEnum.PoundPerGallonUSPerFarenheit, new Guid("397a5f98-842e-4d86-8fb7-f4f2f82e720b")},  // PoundPerGallonUSPerFarenheit
         {UnitChoicesEnum.SpecificGravityPerCelsius, new Guid("2b1d68c0-4e75-4e9d-92a1-37d501e7cb3e")} // SpecificGravityPerCelsius
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingDensityQuantity : DensityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         GramPerCubicCentimeter,  // GramPerCubicCentimeter
         GramPerCubicMeter,  // GramPerCubicMeter
         KilogramPerCubicMeter,  // KilogramPerCubicMeter
         PoundPerCubicFoot,  // PoundPerCubicFoot
         PoundPerGallonUK,  // PoundPerGallonUK
         PoundPerGallonUS,  // PoundPerGallonUS
         SpecificGravity // SpecificGravity
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.GramPerCubicCentimeter, new Guid("64f1b0d8-609f-4ed9-99da-52e18fe97450")},  // GramPerCubicCentimeter
         {UnitChoicesEnum.GramPerCubicMeter, new Guid("8c5b7fc3-0ade-4e85-9646-71ec5fcb869a")},  // GramPerCubicMeter
         {UnitChoicesEnum.KilogramPerCubicMeter, new Guid("8e175ca0-08f6-441d-afcf-a58bbe429abf")},  // KilogramPerCubicMeter
         {UnitChoicesEnum.PoundPerCubicFoot, new Guid("f7479c8c-8d03-460b-bfa3-2b68808be935")},  // PoundPerCubicFoot
         {UnitChoicesEnum.PoundPerGallonUK, new Guid("75ecf787-8778-4d74-afc7-498e117d27bf")},  // PoundPerGallonUK
         {UnitChoicesEnum.PoundPerGallonUS, new Guid("dcc01dd0-4610-42c7-9a55-2ddeb45ef6da")},  // PoundPerGallonUS
         {UnitChoicesEnum.SpecificGravity, new Guid("da94ba95-4494-45af-bf99-31f00031c680")} // SpecificGravity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingDensityRateOfChangeQuantity : DensityRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         GramPerCubicCentimeterPerHour,  // GramPerCubicCentimeterPerHour
         KilogramPerCubicMeterPerSecond,  // KilogramPerCubicMeterPerSecond
         PoundPerGallonUKPerHour,  // PoundPerGallonUKPerHour
         PoundPerGallonUKPerMinute,  // PoundPerGallonUKPerMinute
         PoundPerGallonUKPerSecond,  // PoundPerGallonUKPerSecond
         PoundPerGallonUSPerHour,  // PoundPerGallonUSPerHour
         PoundPerGallonUSPerMinute,  // PoundPerGallonUSPerMinute
         PoundPerGallonUSPerSecond,  // PoundPerGallonUSPerSecond
         SpecificGravityPerHour,  // SpecificGravityPerHour
         SpecificGravityPerMinute,  // SpecificGravityPerMinute
         SpecificGravityPerSecond // SpecificGravityPerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.GramPerCubicCentimeterPerHour, new Guid("c8d6a682-00ca-4d0f-b603-bf2d755f4b31")},  // GramPerCubicCentimeterPerHour
         {UnitChoicesEnum.KilogramPerCubicMeterPerSecond, new Guid("d80197aa-f0b2-4a26-a5a4-b132a248c377")},  // KilogramPerCubicMeterPerSecond
         {UnitChoicesEnum.PoundPerGallonUKPerHour, new Guid("5b461e39-d632-4f5e-b7e7-ef30745e5070")},  // PoundPerGallonUKPerHour
         {UnitChoicesEnum.PoundPerGallonUKPerMinute, new Guid("e79c74b9-774d-4695-81d5-75042f268b96")},  // PoundPerGallonUKPerMinute
         {UnitChoicesEnum.PoundPerGallonUKPerSecond, new Guid("e5a712d2-b874-4e7a-873e-a4f4f3ec7a67")},  // PoundPerGallonUKPerSecond
         {UnitChoicesEnum.PoundPerGallonUSPerHour, new Guid("822327d4-9f7c-4e91-9528-4eff5dfc9643")},  // PoundPerGallonUSPerHour
         {UnitChoicesEnum.PoundPerGallonUSPerMinute, new Guid("c047d53d-38f3-4dce-b590-1c9ab700a3ea")},  // PoundPerGallonUSPerMinute
         {UnitChoicesEnum.PoundPerGallonUSPerSecond, new Guid("eee6814a-d701-4cd8-b392-ebfedde20e11")},  // PoundPerGallonUSPerSecond
         {UnitChoicesEnum.SpecificGravityPerHour, new Guid("ce5d34b0-d7ab-48a4-87c1-9a43fabf5c06")},  // SpecificGravityPerHour
         {UnitChoicesEnum.SpecificGravityPerMinute, new Guid("9c314f49-3297-4f7b-9cf3-5da32ba2f1cc")},  // SpecificGravityPerMinute
         {UnitChoicesEnum.SpecificGravityPerSecond, new Guid("dec0a290-ffd8-4fc0-ae11-3a6068469791")} // SpecificGravityPerSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingDrillStringMagneticFluxQuantity : MagneticFluxQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Weber,  // Weber
         Milliweber,  // Milliweber
         MicroWeber,  // MicroWeber
         TeslaSquareMeter,  // TeslaSquareMeter
         TeslaSquareCentimeter,  // TeslaSquareCentimeter
         GaussSquareCentimeter // GaussSquareCentimeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Weber, new Guid("d790689d-e7dd-43d8-a3c0-c17ccc8073e5")},  // Weber
         {UnitChoicesEnum.Milliweber, new Guid("94f03fc7-b0bb-4356-8787-c9e33f6559d2")},  // Milliweber
         {UnitChoicesEnum.MicroWeber, new Guid("200b9de7-0635-40eb-8ebd-9cef7c01ac10")},  // MicroWeber
         {UnitChoicesEnum.TeslaSquareMeter, new Guid("f6da9f32-0738-4014-aac6-fdc5935fd436")},  // TeslaSquareMeter
         {UnitChoicesEnum.TeslaSquareCentimeter, new Guid("312b97ea-6167-47b5-a046-c6c202fb7eb4")},  // TeslaSquareCentimeter
         {UnitChoicesEnum.GaussSquareCentimeter, new Guid("a0dc1e92-7e84-401f-bca2-a6eb618ef604")} // GaussSquareCentimeter
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingDurationQuantity : TimeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Second,  // second
         Minute,  // minute
         Hour,  // hour
         Day // day
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Second, new Guid("eac42b09-cc85-4e29-9aaf-05fe73bca2aa")},  // second
         {UnitChoicesEnum.Minute, new Guid("4b9dc241-388b-4b7a-b862-48db43234c4a")},  // minute
         {UnitChoicesEnum.Hour, new Guid("f0d815e4-9bef-4422-94e6-1de52216b611")},  // hour
         {UnitChoicesEnum.Day, new Guid("85442621-bb56-4e2a-8e77-2b72409ff84f")} // day
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingDynamicViscosityQuantity : DynamicViscosityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalSecond,  // PascalSecond
         CentiPoise,  // CentiPoise
         MicroPoise,  // MicroPoise
         MicroPascalSecond // MicroPascalSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalSecond, new Guid("5707caa4-e293-430d-9575-425305060fcc")},  // PascalSecond
         {UnitChoicesEnum.CentiPoise, new Guid("a71ef873-6ea2-4922-a100-231177de0e85")},  // CentiPoise
         {UnitChoicesEnum.MicroPoise, new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8")},  // MicroPoise
         {UnitChoicesEnum.MicroPascalSecond, new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d")} // MicroPascalSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingElongationGradientQuantity : ElongationGradientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerMeter,  // MeterPerMeter
         MillimeterPerMeter,  // millimeter per meter
         InchPerFoot // inch per foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerMeter, new Guid("cc12967b-4c7d-4c70-95cf-d2f23bd6f76b")},  // MeterPerMeter
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingFluidVelocityQuantity : VelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerSecond,  // MeterPerSecond
         FootPerSecond // FootPerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // MeterPerSecond
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")} // FootPerSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingForceGradientQuantity : ForceGradientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonPerMeter,  // NewtonPerMeter
         NewtonPer30Meter,  // NewtonPer30Meter
         DecaNewtonPerMeter // decaNewtonPerMeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonPerMeter, new Guid("e503a1d3-1815-4321-8087-6e3d6dc641c8")},  // NewtonPerMeter
         {UnitChoicesEnum.NewtonPer30Meter, new Guid("be16e271-5ce7-445b-a8db-9014a6acc22b")},  // NewtonPer30Meter
         {UnitChoicesEnum.DecaNewtonPerMeter, new Guid("46defe0c-4a00-45d1-83bb-f898e00a78c5")} // decaNewtonPerMeter
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingForceQuantity : ForceQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Newton,  // Newton
         DecaNewton,  // DecaNewton
         KiloDecaNewton,  // KiloDecaNewton
         KilogramForce,  // KilogramForce
         KiloNewton,  // KiloNewton
         KiloPoundForce,  // KiloPoundForce
         PoundForce // PoundForce
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // Newton
         {UnitChoicesEnum.DecaNewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // DecaNewton
         {UnitChoicesEnum.KiloDecaNewton, new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266")},  // KiloDecaNewton
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // KilogramForce
         {UnitChoicesEnum.KiloNewton, new Guid("e30d6f94-7887-4746-8d4f-eb720239b702")},  // KiloNewton
         {UnitChoicesEnum.KiloPoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")},  // KiloPoundForce
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")} // PoundForce
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingHeatTransferCoefficientQuantity : HeatTransferCoefficientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         WattPerMeterSquaredPerKelvin,  // WattPerMeterSquaredPerKelvin
         BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit // BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.WattPerMeterSquaredPerKelvin, new Guid("e1737353-c10b-46cd-aa4e-9c90afb2f01e")},  // WattPerMeterSquaredPerKelvin
         {UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit, new Guid("6963db25-2bd9-4017-9c83-cc578a11abbf")} // BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingHydraulicConductivityQuantity : HydraulicConductivityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerSecond,  // MeterPerSecond
         MeterPerMinute,  // MeterPerMinute
         MeterPerHour,  // MeterPerHour
         MeterPerDay,  // MeterPerDay
         FootPerSecond,  // FootPerSecond
         FootPerMinute,  // FootPerMinute
         FootPerHour,  // FootPerHour
         FootPerDay,  // FootPerDay
         CentimeterPerSecond,  // CentimeterPerSecond
         InchPerSecond // InchPerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // MeterPerSecond
         {UnitChoicesEnum.MeterPerMinute, new Guid("824d3b5b-1e51-446a-99a4-39c02377f303")},  // MeterPerMinute
         {UnitChoicesEnum.MeterPerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // MeterPerHour
         {UnitChoicesEnum.MeterPerDay, new Guid("aa10055f-1ef6-460d-841c-b6dc69f6a7f2")},  // MeterPerDay
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")},  // FootPerSecond
         {UnitChoicesEnum.FootPerMinute, new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076")},  // FootPerMinute
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")},  // FootPerHour
         {UnitChoicesEnum.FootPerDay, new Guid("aa58ec87-0dbc-4ed4-b8aa-8553b02c7b14")},  // FootPerDay
         {UnitChoicesEnum.CentimeterPerSecond, new Guid("d32f84d7-f076-49ab-8bd5-1ccd27e0eba6")},  // CentimeterPerSecond
         {UnitChoicesEnum.InchPerSecond, new Guid("8cd16c97-5c7a-4ee9-b59b-cbe2decd8ff9")} // InchPerSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingInterfacialTensionQuantity : InterfacialTensionQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonPerMeter,  // NewtonPerMeter
         MilliNewtonPerMeter,  // MilliNewtonPerMeter
         DynesPerCentimeter,  // DynesPerCentimeter
         PoundPerSecondSquared // PoundPerSecondSquared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonPerMeter, new Guid("7ee9eca6-2704-442a-bd50-c8a0826da932")},  // NewtonPerMeter
         {UnitChoicesEnum.MilliNewtonPerMeter, new Guid("7b1b363c-cbb0-4499-9d7c-762adc43e690")},  // MilliNewtonPerMeter
         {UnitChoicesEnum.DynesPerCentimeter, new Guid("a3c12fb9-6936-44bf-ad66-f4139163d11b")},  // DynesPerCentimeter
         {UnitChoicesEnum.PoundPerSecondSquared, new Guid("03db472b-b8e8-4ad0-b2b1-b8970686210c")} // PoundPerSecondSquared
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingMassGradientQuantity : MassGradientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerMeter,  // kilogramPerMeter
         PoundPerFoot // PoundPerFoot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerMeter, new Guid("c8b4a6ea-29bf-4e5a-b7ce-9142cefc0752")},  // kilogramPerMeter
         {UnitChoicesEnum.PoundPerFoot, new Guid("6fdf4cb6-a43b-482d-9bc8-d4ad49770f9e")} // PoundPerFoot
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingMassQuantity : MassQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Kilogram,  // kilogram
         TonneMetric,  // tonne metric
         Pound,  // pound
         KiloPound,  // KiloPound
         TonUK // ton UK
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kilogram, new Guid("ef4c5fc1-8774-4aea-b772-35aeae56413d")},  // kilogram
         {UnitChoicesEnum.TonneMetric, new Guid("320b99ba-3115-42f5-939c-15a04d9e7e3c")},  // tonne metric
         {UnitChoicesEnum.Pound, new Guid("e9e313ad-cb28-43fe-93fd-7f94dfee1878")},  // pound
         {UnitChoicesEnum.KiloPound, new Guid("777ff8ee-edc2-46d1-ac40-f097c1e1cd69")},  // KiloPound
         {UnitChoicesEnum.TonUK, new Guid("059c7b81-ed11-410e-9466-4661011372d2")} // ton UK
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingMassRateQuantity : MassRateQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerSecond,  // KilogramPerSecond
         KilogramPerMinute // KilogramPerMinute
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerSecond, new Guid("a2daceb8-7705-4c97-9945-b354ea1ff78d")},  // KilogramPerSecond
         {UnitChoicesEnum.KilogramPerMinute, new Guid("b776ae6f-5b86-462c-b815-2608d7e98192")} // KilogramPerMinute
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingPlaneAngleQuantity : PlaneAngleQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Radian,  // radian
         Degree // degree
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Radian, new Guid("a71fc712-342a-48c2-8e45-b56ee31c7ae0")},  // radian
         {UnitChoicesEnum.Degree, new Guid("023a3393-a01e-499f-967a-a76b1a78d586")} // degree
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingPowerQuantity : PowerQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Watt,  // Watt
         KiloWatt,  // KiloWatt
         MegaWatt // MegaWatt
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Watt, new Guid("9d986a0c-700f-4448-a48c-a028bbd22049")},  // Watt
         {UnitChoicesEnum.KiloWatt, new Guid("016b23c7-0231-45bb-8723-5d3d4cc5c054")},  // KiloWatt
         {UnitChoicesEnum.MegaWatt, new Guid("5719b5f3-5c24-46d2-8ccd-0a06cc6b49ae")} // MegaWatt
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingPressureGradientQuantity : PressureGradientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalPerMeter,  // PascalPerMeter
         BarPerMeter,  // BarPerMeter
         PSIPerFoot,  // PSIPerFoot
         PSIPerMeter // PSIPerMeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalPerMeter, new Guid("f5a37831-4a70-44de-af34-4f6ce1a54af3")},  // PascalPerMeter
         {UnitChoicesEnum.BarPerMeter, new Guid("73a70891-87cf-44fc-8437-94938f034eec")},  // BarPerMeter
         {UnitChoicesEnum.PSIPerFoot, new Guid("b99cef5c-d6df-4803-b52b-6050cf7e7ff8")},  // PSIPerFoot
         {UnitChoicesEnum.PSIPerMeter, new Guid("2235a51b-cdf2-4f53-9664-b7a968dbbba3")} // PSIPerMeter
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingPressureLossConstantQuantity : PressureLossConstantQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PressureLossConstantSI,  // PressureLossConstantSI
         PressureLossConstantMetric,  // PressureLossConstantMetric
         PressureLossConstantUK,  // PressureLossConstantUK
         PressureLossConstantUS // PressureLossConstantUS
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PressureLossConstantSI, new Guid("e0b334c4-2e44-4b1b-891f-9deae86a4d17")},  // PressureLossConstantSI
         {UnitChoicesEnum.PressureLossConstantMetric, new Guid("043fbd34-1e4f-45bc-9935-b1797b606fd6")},  // PressureLossConstantMetric
         {UnitChoicesEnum.PressureLossConstantUK, new Guid("d5a97f2d-cb2f-449f-8f60-0ad292a01b87")},  // PressureLossConstantUK
         {UnitChoicesEnum.PressureLossConstantUS, new Guid("b5cb21d1-0e71-4ab2-8d9d-42de21753edc")} // PressureLossConstantUS
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingPressureQuantity : PressureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // Pascal
         Bar,  // Bar
         PoundPerSquareInch,  // PoundPerSquareInch
         KiloPascal,  // KiloPascal
         MegaPascal,  // MegaPascal
         KiloPoundPerSquareInch // KiloPoundPerSquareInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // Pascal
         {UnitChoicesEnum.Bar, new Guid("0d182739-f8f6-47a6-afcb-71feac973307")},  // Bar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // PoundPerSquareInch
         {UnitChoicesEnum.KiloPascal, new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29")},  // KiloPascal
         {UnitChoicesEnum.MegaPascal, new Guid("4ef28797-f416-4d97-b36a-711ea848bcc0")},  // MegaPascal
         {UnitChoicesEnum.KiloPoundPerSquareInch, new Guid("a07b5fe5-87e3-4422-afe1-f54de24deeb8")} // KiloPoundPerSquareInch
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingRandomWalkQuantity : RandomWalkQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSqrtSecond,  // RadianPerSqrtSecond
         RadianPerSqrtMinute,  // RadianPerSqrtMinute
         RadianPerSqrtHour,  // RadianPerSqrtHour
         RadianPerSqrtDay,  // RadianPerSqrtDay
         DegreePerSqrtSecond,  // DegreePerSqrtSecond
         DegreePerSqrtMinute,  // DegreePerSqrtMinute
         DegreePerSqrtHour,  // DegreePerSqrtHour
         DegreePerSqrtDay // DegreePerSqrtDay
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSqrtSecond, new Guid("557ea59e-a1da-438b-b04d-ccfc5539f87f")},  // RadianPerSqrtSecond
         {UnitChoicesEnum.RadianPerSqrtMinute, new Guid("ccc41b4e-2efb-4760-969f-94614248374f")},  // RadianPerSqrtMinute
         {UnitChoicesEnum.RadianPerSqrtHour, new Guid("e296c410-e278-4586-af95-bae6fe4f0673")},  // RadianPerSqrtHour
         {UnitChoicesEnum.RadianPerSqrtDay, new Guid("fb4a74f9-a648-4310-a424-9c85036bbc41")},  // RadianPerSqrtDay
         {UnitChoicesEnum.DegreePerSqrtSecond, new Guid("87a0a4e3-a2f5-4f84-b845-c7e6276e1655")},  // DegreePerSqrtSecond
         {UnitChoicesEnum.DegreePerSqrtMinute, new Guid("e8e3a988-4219-44a5-ae89-ce115a239d04")},  // DegreePerSqrtMinute
         {UnitChoicesEnum.DegreePerSqrtHour, new Guid("ab6b85cf-54e5-4c3b-a330-f65d7e3bb926")},  // DegreePerSqrtHour
         {UnitChoicesEnum.DegreePerSqrtDay, new Guid("8f806d0f-3741-4aa8-9f37-54b4f80e307c")} // DegreePerSqrtDay
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingRotationFrequencyRateOfChangeQuantity : RotationFrequencyRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         HertzPerSecond,  // HertzPerSecond
         RPMPerSecond // RPMPerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.HertzPerSecond, new Guid("4d7e4b49-df76-4259-a96c-8c1250d5ecdd")},  // HertzPerSecond
         {UnitChoicesEnum.RPMPerSecond, new Guid("762b5d58-a1ba-40cb-8776-2004613d15fb")} // RPMPerSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingSpecificHeatCapacityQuantity : SpecificHeatCapacityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         JoulePerKilogramKelvin,  // JoulePerKilogramKelvin
         JoulePerGramKelvin,  // JoulePerGramKelvin
         JoulePerGramDegreeCelsius,  // JoulePerGramDegreeCelsius
         CaloriePerGramDegreeCelsius,  // CaloriePerGramDegreeCelsius
         BritishThermalUnitPerPoundDegreeFarenheit // BritishThermalUnitPerPoundDegreeFarenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.JoulePerKilogramKelvin, new Guid("52d9523e-546b-41dd-b283-a125447433a3")},  // JoulePerKilogramKelvin
         {UnitChoicesEnum.JoulePerGramKelvin, new Guid("0c38001b-ecba-4920-ac75-e4644d8feced")},  // JoulePerGramKelvin
         {UnitChoicesEnum.JoulePerGramDegreeCelsius, new Guid("5b620d63-2269-42d3-8385-edca04c7ea70")},  // JoulePerGramDegreeCelsius
         {UnitChoicesEnum.CaloriePerGramDegreeCelsius, new Guid("bb241c58-e76c-4d96-81c1-356b3f2ad397")},  // CaloriePerGramDegreeCelsius
         {UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit, new Guid("ad9274f2-4c1a-45fe-97c1-710f00deca16")} // BritishThermalUnitPerPoundDegreeFarenheit
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingSpecificHeatCapacityTemperatureGradientQuantity : SpecificHeatCapacityTemperatureGradientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         JoulePerKilogramKelvinPerKelvin,  // JoulePerKilogramKelvinPerKelvin
         JoulePerGramKelvinPerKelvin,  // JoulePerGramKelvinPerKelvin
         JoulePerGramDegreeCelsiusPerCelsius,  // JoulePerGramDegreeCelsiusPerCelsius
         CaloriePerGramDegreeCelsiusPerCelsius,  // CaloriePerGramDegreeCelsiusPerCelsius
         BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit // BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.JoulePerKilogramKelvinPerKelvin, new Guid("9570fd84-ff2e-4a74-93b7-39bcf6558301")},  // JoulePerKilogramKelvinPerKelvin
         {UnitChoicesEnum.JoulePerGramKelvinPerKelvin, new Guid("69520d03-c7c3-483f-bbbb-6bdf3cf74463")},  // JoulePerGramKelvinPerKelvin
         {UnitChoicesEnum.JoulePerGramDegreeCelsiusPerCelsius, new Guid("9ed03436-3032-4bee-a145-fd03b6236816")},  // JoulePerGramDegreeCelsiusPerCelsius
         {UnitChoicesEnum.CaloriePerGramDegreeCelsiusPerCelsius, new Guid("ad3fe4d1-3286-4313-9f45-f2110b7ca6f2")},  // CaloriePerGramDegreeCelsiusPerCelsius
         {UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit, new Guid("57264532-79b7-4a19-8ffe-617bba781be3")} // BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingStickDurationQuantity : TimeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Second,  // second
         Millisecond // millisecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Second, new Guid("eac42b09-cc85-4e29-9aaf-05fe73bca2aa")},  // second
         {UnitChoicesEnum.Millisecond, new Guid("1c1b150f-80a0-47da-836c-a583c4fa4b74")} // millisecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity : AngleMagneticFluxDensityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianTesla,  // RadianTesla
         DegreeGauss,  // DegreeGauss
         DegreeMaxwellPerSquareCentimeter,  // DegreeMaxwellPerSquareCentimeter
         DegreeMicroTesla,  // DegreeMicroTesla
         DegreeMilliGauss,  // DegreeMilliGauss
         DegreeMilliTesla,  // DegreeMilliTesla
         DegreeNanoTesla,  // DegreeNanoTesla
         DegreeTesla,  // DegreeTesla
         DegreeWeberPerSquareMeter,  // DegreeWeberPerSquareMeter
         RadianGauss,  // RadianGauss
         RadianMaxwellPerSquareCentimeter,  // RadianMaxwellPerSquareCentimeter
         RadianMicroTesla,  // RadianMicroTesla
         RadianMilliGauss,  // RadianMilliGauss
         RadianMilliTesla,  // RadianMilliTesla
         RadianNanoTesla,  // RadianNanoTesla
         RadianWeberPerSquareMeter // RadianWeberPerSquareMeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianTesla, new Guid("242bd328-96ef-4a1b-9a78-1e2eb8366955")},  // RadianTesla
         {UnitChoicesEnum.DegreeGauss, new Guid("73bb1de0-ccc0-42e6-b88e-44ecfb6fe7e4")},  // DegreeGauss
         {UnitChoicesEnum.DegreeMaxwellPerSquareCentimeter, new Guid("092e8231-a6e6-4b29-bdd6-2ae490aa583a")},  // DegreeMaxwellPerSquareCentimeter
         {UnitChoicesEnum.DegreeMicroTesla, new Guid("50782201-236e-4537-843b-121e8dca28c6")},  // DegreeMicroTesla
         {UnitChoicesEnum.DegreeMilliGauss, new Guid("e74c9ae3-6e17-48e1-896b-e6c1877d68d7")},  // DegreeMilliGauss
         {UnitChoicesEnum.DegreeMilliTesla, new Guid("812a3461-ae4a-405b-ae5d-73eb23e8a71f")},  // DegreeMilliTesla
         {UnitChoicesEnum.DegreeNanoTesla, new Guid("0d9bf20d-2b10-4e73-ae8e-3d3e91862ec0")},  // DegreeNanoTesla
         {UnitChoicesEnum.DegreeTesla, new Guid("13df770f-6e77-4de4-91c6-137206e53fbb")},  // DegreeTesla
         {UnitChoicesEnum.DegreeWeberPerSquareMeter, new Guid("2d7e1d60-6401-41c0-b436-612116be9ad4")},  // DegreeWeberPerSquareMeter
         {UnitChoicesEnum.RadianGauss, new Guid("aa726b90-bd4b-420c-ae71-6f2f1fde3b58")},  // RadianGauss
         {UnitChoicesEnum.RadianMaxwellPerSquareCentimeter, new Guid("02d06899-5d89-4669-a4c2-35adb9ec3924")},  // RadianMaxwellPerSquareCentimeter
         {UnitChoicesEnum.RadianMicroTesla, new Guid("b445e592-e0ca-490f-8880-9708e4e96a01")},  // RadianMicroTesla
         {UnitChoicesEnum.RadianMilliGauss, new Guid("352a5b84-306d-4e38-898a-58705683fdf0")},  // RadianMilliGauss
         {UnitChoicesEnum.RadianMilliTesla, new Guid("663639b3-48b8-4c04-a2eb-6ae2e16daa9b")},  // RadianMilliTesla
         {UnitChoicesEnum.RadianNanoTesla, new Guid("b4aeee40-29fa-463a-80a4-e10fa42c743f")},  // RadianNanoTesla
         {UnitChoicesEnum.RadianWeberPerSquareMeter, new Guid("409e8e85-0870-4529-ae0c-95ab6506c445")} // RadianWeberPerSquareMeter
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingSurveyInstrumentAngularVelocityQuantity : AngularVelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSecond,  // RadianPerSecond
         DegreePerSecond,  // DegreePerSecond
         DegreePerMinute,  // DegreePerMinute
         DegreePerHour,  // DegreePerHour
         DegreePerDay // DegreePerDay
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSecond, new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a")},  // RadianPerSecond
         {UnitChoicesEnum.DegreePerSecond, new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e")},  // DegreePerSecond
         {UnitChoicesEnum.DegreePerMinute, new Guid("0a3ad50c-bbfa-456c-9613-84f37b4a80f1")},  // DegreePerMinute
         {UnitChoicesEnum.DegreePerHour, new Guid("44cc8b17-2f87-49c9-8ab7-7f4ed36d9eb6")},  // DegreePerHour
         {UnitChoicesEnum.DegreePerDay, new Guid("ec049b3d-134b-44a3-9746-0419a368beef")} // DegreePerDay
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingSurveyInstrumentReciprocalLengthQuantity : WaveNumberQuantity
  {
    public new enum UnitChoicesEnum 
      {
         ReciprocalMetre,  // ReciprocalMetre
         ReciprocalDecameter,  // ReciprocalDecameter
         ReciprocalHectometer,  // ReciprocalHectometer
         ReciprocalKilometer,  // ReciprocalKilometer
         ReciprocalFeet,  // ReciprocalFeet
         ReciprocalYard,  // ReciprocalYard
         ReciprocalMile // ReciprocalMile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.ReciprocalMetre, new Guid("3cd38922-b99f-45bb-af6e-a38ebf1240f0")},  // ReciprocalMetre
         {UnitChoicesEnum.ReciprocalDecameter, new Guid("a691338d-1916-4355-b6e1-3b1bff086c14")},  // ReciprocalDecameter
         {UnitChoicesEnum.ReciprocalHectometer, new Guid("4da19df4-0ff6-424b-a2ab-9d5811ba48ca")},  // ReciprocalHectometer
         {UnitChoicesEnum.ReciprocalKilometer, new Guid("a4b4ed8e-a1c6-4e3f-9421-8770cec6ff42")},  // ReciprocalKilometer
         {UnitChoicesEnum.ReciprocalFeet, new Guid("1d6a5284-d32f-4f5a-ad27-bfc0f71069aa")},  // ReciprocalFeet
         {UnitChoicesEnum.ReciprocalYard, new Guid("be5f64c0-592a-4f3b-b2b5-6df8b9d2a31b")},  // ReciprocalYard
         {UnitChoicesEnum.ReciprocalMile, new Guid("acbb10a5-602f-423b-bc15-bdfd80cb7008")} // ReciprocalMile
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingTemperatureGradientQuantity : TemperatureGradientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KelvinPerMeter,  // KelvinPerMeter
         CelsiusPerMeter,  // CelsiusPerMeter
         CelsiusPer10Meter,  // CelsiusPer10Meter
         CelsiusPer30Meter,  // CelsiusPer30Meter
         CelsiusPer100Meter,  // CelsiusPer100Meter
         CelsiusPerFoot,  // CelsiusPerFoot
         CelsiusPer30Foot,  // CelsiusPer30Foot
         CelsiusPer100Foot,  // CelsiusPer100Foot
         FahrenheitPerFoot,  // FahrenheitPerFoot
         FahrenheitPer30Foot,  // FahrenheitPer30Foot
         FahrenheitPer100Foot // FahrenheitPer100Foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KelvinPerMeter, new Guid("f1fe19d2-12e3-43d1-ba97-3ef9e8ec9e73")},  // KelvinPerMeter
         {UnitChoicesEnum.CelsiusPerMeter, new Guid("40dbbdfe-b680-403a-8326-2c217ba85d52")},  // CelsiusPerMeter
         {UnitChoicesEnum.CelsiusPer10Meter, new Guid("5e4ff2bf-4788-4258-bd4a-7b18a13364ff")},  // CelsiusPer10Meter
         {UnitChoicesEnum.CelsiusPer30Meter, new Guid("d17464c4-a7ef-4dcd-b783-bafe6e9b92de")},  // CelsiusPer30Meter
         {UnitChoicesEnum.CelsiusPer100Meter, new Guid("b47f299a-913a-46b7-ad20-c683fa0f02d0")},  // CelsiusPer100Meter
         {UnitChoicesEnum.CelsiusPerFoot, new Guid("e7b05420-41f6-4812-bc54-9c14f05a9cbd")},  // CelsiusPerFoot
         {UnitChoicesEnum.CelsiusPer30Foot, new Guid("bea3df4f-78e9-4e1a-bbee-22086da043b4")},  // CelsiusPer30Foot
         {UnitChoicesEnum.CelsiusPer100Foot, new Guid("f9bae95a-b282-44a7-8ae0-54728ef3c7a3")},  // CelsiusPer100Foot
         {UnitChoicesEnum.FahrenheitPerFoot, new Guid("d08596f1-77c4-4a8e-9245-6bf563fa7345")},  // FahrenheitPerFoot
         {UnitChoicesEnum.FahrenheitPer30Foot, new Guid("a1664cb0-db5c-4933-9b57-d075c4975f46")},  // FahrenheitPer30Foot
         {UnitChoicesEnum.FahrenheitPer100Foot, new Guid("232e2d6d-cb65-4b56-9277-457e4ff678fa")} // FahrenheitPer100Foot
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingTemperatureQuantity : TemperatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Kelvin,  // kelvin
         Celsius,  // celsius
         Fahrenheit // fahrenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kelvin, new Guid("8fc5fa10-2d89-4064-8ace-b852d9a8d31f")},  // kelvin
         {UnitChoicesEnum.Celsius, new Guid("5d69048e-fe18-4923-9341-cb80c2ccf8cc")},  // celsius
         {UnitChoicesEnum.Fahrenheit, new Guid("55c289ab-6975-439f-9b7a-fdca6d219a9f")} // fahrenheit
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingTensionQuantity : TensionQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Newton,  // Newton
         DecaNewton,  // DecaNewton
         KiloDecaNewton,  // KiloDecaNewton
         KilogramForce,  // KilogramForce
         KiloNewton,  // KiloNewton
         KiloPoundForce,  // KiloPoundForce
         PoundForce // PoundForce
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // Newton
         {UnitChoicesEnum.DecaNewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // DecaNewton
         {UnitChoicesEnum.KiloDecaNewton, new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266")},  // KiloDecaNewton
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // KilogramForce
         {UnitChoicesEnum.KiloNewton, new Guid("e30d6f94-7887-4746-8d4f-eb720239b702")},  // KiloNewton
         {UnitChoicesEnum.KiloPoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")},  // KiloPoundForce
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")} // PoundForce
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingThermalConductivityQuantity : ThermalConductivityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         WattPerMetreKelvin,  // WattPerMetreKelvin
         CaloriePerMetreSecondDegreeCelsius,  // CaloriePerMetreSecondDegreeCelsius
         CaloriePerCentimetreSecondDegreeCelsius,  // CaloriePerCentimetreSecondDegreeCelsius
         BritishThermalUnitPerHourFootDegreeFarenheit,  // BritishThermalUnitPerHourFootDegreeFarenheit
         BritishThermalUnitInchPerHourSquareFootDegreeFarenheit // BritishThermalUnitInchPerHourSquareFootDegreeFarenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.WattPerMetreKelvin, new Guid("3ddba24f-4ccf-4cb1-af6c-2829cac3b88f")},  // WattPerMetreKelvin
         {UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsius, new Guid("d0386fc4-b97b-4874-8c8d-66e093c391ea")},  // CaloriePerMetreSecondDegreeCelsius
         {UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsius, new Guid("5f8706ed-d938-4715-a0ca-2afff423f6e6")},  // CaloriePerCentimetreSecondDegreeCelsius
         {UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit, new Guid("43169695-8f6e-42ad-8c07-566dc7651edb")},  // BritishThermalUnitPerHourFootDegreeFarenheit
         {UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFarenheit, new Guid("c79c2b27-c956-49a3-9caf-8653017777ca")} // BritishThermalUnitInchPerHourSquareFootDegreeFarenheit
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingThermalConductivityTemperatureGradientQuantity : ThermalConductivityTemperatureGradientQuantity
  {
    public new enum UnitChoicesEnum 
      {
         WattPerMetreKelvinPerKelvin,  // WattPerMetreKelvinPerKelvin
         BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit,  // BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit
         BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit,  // BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit
         CaloriePerCentimetreSecondDegreeCelsiusPerCelsius,  // CaloriePerCentimetreSecondDegreeCelsiusPerCelsius
         CaloriePerMetreSecondDegreeCelsiusPerCelsius // CaloriePerMetreSecondDegreeCelsiusPerCelsius
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.WattPerMetreKelvinPerKelvin, new Guid("0459940e-d71f-4b01-9ea6-eeb05d754af2")},  // WattPerMetreKelvinPerKelvin
         {UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit, new Guid("918b4e34-3986-427f-8bb6-c09740a7c299")},  // BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit
         {UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit, new Guid("b79509ea-8c03-4538-9974-208f7e0ee40e")},  // BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit
         {UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsiusPerCelsius, new Guid("6c21a6cd-61fe-4086-95a7-ad6d6820c96e")},  // CaloriePerCentimetreSecondDegreeCelsiusPerCelsius
         {UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsiusPerCelsius, new Guid("eb08ff8c-d542-440f-a4c7-610653018910")} // CaloriePerMetreSecondDegreeCelsiusPerCelsius
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingTorqueQuantity : TorqueQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterNewton,  // MeterNewton
         FootPound,  // FootPound
         KiloFootPound,  // KiloFootPound
         MeterDecaNewton,  // MeterDecaNewton
         MeterKilogramForce,  // MeterKilogramForce
         MeterKiloNewton // MeterKiloNewton
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterNewton, new Guid("50b017fa-8d81-4076-a485-61de1d8301b5")},  // MeterNewton
         {UnitChoicesEnum.FootPound, new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51")},  // FootPound
         {UnitChoicesEnum.KiloFootPound, new Guid("ee9be6ed-df75-4915-be6a-e3941dacd6bd")},  // KiloFootPound
         {UnitChoicesEnum.MeterDecaNewton, new Guid("501ce02c-8a5d-46e6-9ab6-ce443df70402")},  // MeterDecaNewton
         {UnitChoicesEnum.MeterKilogramForce, new Guid("282f97a0-df2a-4016-9ab0-796db49ff384")},  // MeterKilogramForce
         {UnitChoicesEnum.MeterKiloNewton, new Guid("2e417a6e-1acc-4901-8704-7dfeb3f67546")} // MeterKiloNewton
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingVolumeQuantity : VolumeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMeter,  // CubicMeter
         Liter,  // Liter
         USGallon,  // USGallon
         UKGallon // UKGallon
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMeter, new Guid("a465ba87-53d6-456c-8e74-315a1a212498")},  // CubicMeter
         {UnitChoicesEnum.Liter, new Guid("3f713743-6248-4b0b-8f3b-c97b6fab76b1")},  // Liter
         {UnitChoicesEnum.USGallon, new Guid("1377d8ac-d203-48ed-bad4-733b0dc9d496")},  // USGallon
         {UnitChoicesEnum.UKGallon, new Guid("78f1cef7-c489-498c-96fb-d37474e242a9")} // UKGallon
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingVolumetricFlowRateOfChangeQuantity : VolumetricFlowRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMeterPerSecondSquare,  // CubicMeterPerSecondSquare
         LiterPerMinutePerSecond,  // LiterPerMinutePerSecond
         UKGallonPerMinutePerSecond,  // UKGallonPerMinutePerSecond
         USGallonPerMinutePerSecond // USGallonPerMinutePerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMeterPerSecondSquare, new Guid("aef20431-be0b-44ea-8770-a59db19b7f94")},  // CubicMeterPerSecondSquare
         {UnitChoicesEnum.LiterPerMinutePerSecond, new Guid("e5a265b6-a9ba-4a09-ba08-b8c417b28ffb")},  // LiterPerMinutePerSecond
         {UnitChoicesEnum.UKGallonPerMinutePerSecond, new Guid("298e7a16-07a5-4b5b-a0de-3e49b31254b4")},  // UKGallonPerMinutePerSecond
         {UnitChoicesEnum.USGallonPerMinutePerSecond, new Guid("3c530e9a-9376-49d1-a6b5-0a6f93f4184b")} // USGallonPerMinutePerSecond
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingVolumetricFlowrateQuantity : VolumetricFlowRateQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMeterPerSecond,  // CubicMeterPerSecond
         LiterPerMinute,  // LiterPerMinute
         UKGallonPerMinute,  // UKGallonPerMinute
         USGallonPerMinute // USGallonPerMinute
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMeterPerSecond, new Guid("fabe7a23-1ba2-4f5d-b3f5-d5729166c7a0")},  // CubicMeterPerSecond
         {UnitChoicesEnum.LiterPerMinute, new Guid("e1ff1684-02ed-41c0-a82c-40b4a6d348b5")},  // LiterPerMinute
         {UnitChoicesEnum.UKGallonPerMinute, new Guid("bb1d3fbc-efc1-4cf7-9c13-33c25a874224")},  // UKGallonPerMinute
         {UnitChoicesEnum.USGallonPerMinute, new Guid("ceca76e7-fd1e-4220-b072-9f40467a05e3")} // USGallonPerMinute
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillStemMaterialStrengthQuantity : MaterialStrengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // Pascal
         GigaPascal,  // GigaPascal
         MegaPascal,  // MegaPascal
         MegapoundPerSquareInch,  // MegapoundPerSquareInch
         PoundPer100SquareFoot,  // PoundPer100SquareFoot
         PSI // PSI
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("159e99d3-c79d-4dc6-974f-05cc38af001e")},  // Pascal
         {UnitChoicesEnum.GigaPascal, new Guid("c9aa0a18-02ac-42a0-9afe-8a08b4f03331")},  // GigaPascal
         {UnitChoicesEnum.MegaPascal, new Guid("38b95b61-a825-4393-a0e8-ecd686575735")},  // MegaPascal
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("197a8b98-190d-4d45-91d7-85af12deab02")},  // MegapoundPerSquareInch
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("eb1e2a52-3de3-4338-ad4d-40e8ce90e40b")},  // PoundPer100SquareFoot
         {UnitChoicesEnum.PSI, new Guid("4adf2a33-05c3-49bb-ba61-59dd76f4621e")} // PSI
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class FormationResistivityQuantity : ResistivityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         OhmMeter // OhmMeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.OhmMeter, new Guid("fb07d86d-d69f-46ca-892c-17ec45adffcb")} // OhmMeter
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class FormationStrengthQuantity : MaterialStrengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         GigaPascal,  // GigaPascal
         MegaPascal,  // MegaPascal
         MegapoundPerSquareInch,  // MegapoundPerSquareInch
         Pascal,  // Pascal
         PoundPer100SquareFoot,  // PoundPer100SquareFoot
         PSI // PSI
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.GigaPascal, new Guid("c9aa0a18-02ac-42a0-9afe-8a08b4f03331")},  // GigaPascal
         {UnitChoicesEnum.MegaPascal, new Guid("38b95b61-a825-4393-a0e8-ecd686575735")},  // MegaPascal
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("197a8b98-190d-4d45-91d7-85af12deab02")},  // MegapoundPerSquareInch
         {UnitChoicesEnum.Pascal, new Guid("159e99d3-c79d-4dc6-974f-05cc38af001e")},  // Pascal
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("eb1e2a52-3de3-4338-ad4d-40e8ce90e40b")},  // PoundPer100SquareFoot
         {UnitChoicesEnum.PSI, new Guid("4adf2a33-05c3-49bb-ba61-59dd76f4621e")} // PSI
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class GammaRayQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         GammaAPI // GammaAPI
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.GammaAPI, new Guid("526a7d9b-514c-4b2d-9ff3-e69d64c299a9")} // GammaAPI
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class GasShowQuantity : ProportionQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Proportion,  // Proportion
         Percent,  // Percent
         PerThousand,  // PerThousand
         PartPerMillion // PartPerMillion
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Proportion, new Guid("03eb339b-61aa-4b42-aa35-4a20c547fdb9")},  // Proportion
         {UnitChoicesEnum.Percent, new Guid("1a825e84-bc53-4da8-a089-118fdf40b8f7")},  // Percent
         {UnitChoicesEnum.PerThousand, new Guid("141465a2-9c3c-4dda-82ec-eb35e72250c2")},  // PerThousand
         {UnitChoicesEnum.PartPerMillion, new Guid("af33bf27-c3b8-4746-8b08-826ed1d21792")} // PartPerMillion
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class GasVolumetricFlowRateQuantity : VolumetricFlowRateQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMeterPerSecond,  // CubicMeterPerSecond
         CubicFootPerSecond,  // CubicFootPerSecond
         LiterPerSecond,  // LiterPerSecond
         UKGallonPerSecond,  // UKGallonPerSecond
         USGallonPerSecond,  // USGallonPerSecond
         BarrelPerSecond,  // BarrelPerSecond
         CubicMeterPerMinute,  // CubicMeterPerMinute
         CubicFootPerMinute,  // CubicFootPerMinute
         LiterPerMinute,  // LiterPerMinute
         UKGallonPerMinute,  // UKGallonPerMinute
         USGallonPerMinute,  // USGallonPerMinute
         BarrelPerMinute,  // BarrelPerMinute
         CubicMeterPerHour,  // CubicMeterPerHour
         CubicFootPerHour,  // CubicFootPerHour
         LiterPerHour,  // LiterPerHour
         UKGallonPerHour,  // UKGallonPerHour
         USGallonPerHour,  // USGallonPerHour
         BarrelPerHour,  // BarrelPerHour
         CubicMeterPerDay,  // CubicMeterPerDay
         CubicFootPerDay,  // CubicFootPerDay
         LiterPerDay,  // LiterPerDay
         UKGallonPerDay,  // UKGallonPerDay
         USGallonPerDay,  // USGallonPerDay
         BarrelPerDay,  // BarrelPerDay
         ThousandStandardCubicFootPerDay,  // ThousandStandardCubicFootPerDay
         MillionCubicMeterPerDay,  // MillionCubicMeterPerDay
         MillionLiterPerDay,  // MillionLiterPerDay
         MillionStandardCubicFootPerDay,  // MillionStandardCubicFootPerDay
         MillionUKGallonPerDay,  // MillionUKGallonPerDay
         MillionUSGallonPerDay // MillionUSGallonPerDay
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMeterPerSecond, new Guid("fabe7a23-1ba2-4f5d-b3f5-d5729166c7a0")},  // CubicMeterPerSecond
         {UnitChoicesEnum.CubicFootPerSecond, new Guid("a02fc355-34da-447b-ad1f-66cef4cc96d5")},  // CubicFootPerSecond
         {UnitChoicesEnum.LiterPerSecond, new Guid("6dafb683-0f61-42ba-a22c-7bd5c9cea4ae")},  // LiterPerSecond
         {UnitChoicesEnum.UKGallonPerSecond, new Guid("21ca44f5-ed4e-414d-b285-b38730600794")},  // UKGallonPerSecond
         {UnitChoicesEnum.USGallonPerSecond, new Guid("21fe7e3a-bf92-4c94-b6d7-e2d30dfc4cd3")},  // USGallonPerSecond
         {UnitChoicesEnum.BarrelPerSecond, new Guid("a73caac6-062e-4f79-8374-8fb2598b6842")},  // BarrelPerSecond
         {UnitChoicesEnum.CubicMeterPerMinute, new Guid("98eec130-224c-457a-a5dd-50b55a3a28ab")},  // CubicMeterPerMinute
         {UnitChoicesEnum.CubicFootPerMinute, new Guid("a81e08db-d8fd-4379-bc8e-c223c3fb71b3")},  // CubicFootPerMinute
         {UnitChoicesEnum.LiterPerMinute, new Guid("e1ff1684-02ed-41c0-a82c-40b4a6d348b5")},  // LiterPerMinute
         {UnitChoicesEnum.UKGallonPerMinute, new Guid("bb1d3fbc-efc1-4cf7-9c13-33c25a874224")},  // UKGallonPerMinute
         {UnitChoicesEnum.USGallonPerMinute, new Guid("ceca76e7-fd1e-4220-b072-9f40467a05e3")},  // USGallonPerMinute
         {UnitChoicesEnum.BarrelPerMinute, new Guid("3672c640-3924-4921-861b-d14c99643615")},  // BarrelPerMinute
         {UnitChoicesEnum.CubicMeterPerHour, new Guid("d6607bed-0235-4838-87c8-2ff6c76be2ad")},  // CubicMeterPerHour
         {UnitChoicesEnum.CubicFootPerHour, new Guid("54f30d1c-670a-4566-bfb2-3ce644d68878")},  // CubicFootPerHour
         {UnitChoicesEnum.LiterPerHour, new Guid("fe2d8a01-fd2b-4652-80bd-f0da2ce990fd")},  // LiterPerHour
         {UnitChoicesEnum.UKGallonPerHour, new Guid("85d47672-e1ce-4b33-be1d-eabc2ec1c4c1")},  // UKGallonPerHour
         {UnitChoicesEnum.USGallonPerHour, new Guid("36892d41-4a11-4d32-9a8c-1e43ac1f8c6d")},  // USGallonPerHour
         {UnitChoicesEnum.BarrelPerHour, new Guid("af1bd583-3a13-4d3a-8f65-ede4f8fe9789")},  // BarrelPerHour
         {UnitChoicesEnum.CubicMeterPerDay, new Guid("f512755c-166c-4346-a0f7-74f09703410f")},  // CubicMeterPerDay
         {UnitChoicesEnum.CubicFootPerDay, new Guid("6b9a886b-b96a-473b-8dea-e850583ad5d8")},  // CubicFootPerDay
         {UnitChoicesEnum.LiterPerDay, new Guid("67628fe2-6a64-4ea6-94fe-5a34e7568b53")},  // LiterPerDay
         {UnitChoicesEnum.UKGallonPerDay, new Guid("334cf647-375e-4423-8ef4-e1171f938f9a")},  // UKGallonPerDay
         {UnitChoicesEnum.USGallonPerDay, new Guid("c0a47cc8-8ba1-47a1-ab94-d3e4361dd063")},  // USGallonPerDay
         {UnitChoicesEnum.BarrelPerDay, new Guid("9d36ce54-5bdc-4f4b-9948-dd65c58c9db3")},  // BarrelPerDay
         {UnitChoicesEnum.ThousandStandardCubicFootPerDay, new Guid("627a75ed-2ab8-480a-96be-b9266d34ba5d")},  // ThousandStandardCubicFootPerDay
         {UnitChoicesEnum.MillionCubicMeterPerDay, new Guid("d09b4db7-9fbe-4018-aeb7-15286ccff8d6")},  // MillionCubicMeterPerDay
         {UnitChoicesEnum.MillionLiterPerDay, new Guid("1889c1dd-5aa3-45fe-b6cb-79a760e44832")},  // MillionLiterPerDay
         {UnitChoicesEnum.MillionStandardCubicFootPerDay, new Guid("f1c76ab3-8e54-4ad1-a7fe-a09be2a61285")},  // MillionStandardCubicFootPerDay
         {UnitChoicesEnum.MillionUKGallonPerDay, new Guid("f083576e-1d99-4243-bcfa-5ca6093b6931")},  // MillionUKGallonPerDay
         {UnitChoicesEnum.MillionUSGallonPerDay, new Guid("ffe9958a-3daa-472d-87ab-0b1217dcb1c5")} // MillionUSGallonPerDay
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class HeightQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Metre,  // metre
         Millimeter,  // millimeter
         Centimeter,  // centimeter
         Decimeter,  // decimeter
         Hectometer,  // hectometer
         Kilometer,  // kilometer
         Inch,  // inch
         Feet,  // feet
         Yard,  // yard
         Mile // mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Millimeter, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimeter
         {UnitChoicesEnum.Centimeter, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimeter
         {UnitChoicesEnum.Decimeter, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimeter
         {UnitChoicesEnum.Hectometer, new Guid("cb5c81a3-b9da-42b5-a2ea-0509df445d01")},  // hectometer
         {UnitChoicesEnum.Kilometer, new Guid("93aee1b8-653d-4841-b948-10460cb84334")},  // kilometer
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.Yard, new Guid("7b9156e4-7cce-41cf-a251-95412f4d91a5")},  // yard
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class HookLoadQuantity : GravitationalLoadQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Kilogram,  // kilogram
         TonneMetric,  // tonne metric
         Pound,  // pound
         KiloPound,  // KiloPound
         TonUK // ton UK
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kilogram, new Guid("ef4c5fc1-8774-4aea-b772-35aeae56413d")},  // kilogram
         {UnitChoicesEnum.TonneMetric, new Guid("320b99ba-3115-42f5-939c-15a04d9e7e3c")},  // tonne metric
         {UnitChoicesEnum.Pound, new Guid("e9e313ad-cb28-43fe-93fd-7f94dfee1878")},  // pound
         {UnitChoicesEnum.KiloPound, new Guid("777ff8ee-edc2-46d1-ac40-f097c1e1cd69")},  // KiloPound
         {UnitChoicesEnum.TonUK, new Guid("059c7b81-ed11-410e-9466-4661011372d2")} // ton UK
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class NozzleDiameterQuantity : SmallLengthQuantity
  {
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class PipeDiameterQuantity : SmallLengthQuantity
  {
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class PoreDiameterQuantity : SmallLengthQuantity
  {
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class PoreSurfaceQuantity : AreaQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMeter,  // SquareMeter
         SquareMillimeter,  // SquareMillimeter
         SquareMicrometer,  // SquareMicrometer
         SquareFoot // SquareFoot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMeter, new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee")},  // SquareMeter
         {UnitChoicesEnum.SquareMillimeter, new Guid("0b87d221-284a-4e8c-8a60-50c522f9ade4")},  // SquareMillimeter
         {UnitChoicesEnum.SquareMicrometer, new Guid("bec98c97-72c7-4485-9138-058ed14e7fbe")},  // SquareMicrometer
         {UnitChoicesEnum.SquareFoot, new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248")} // SquareFoot
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class PositionQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Metre,  // metre
         Kilometer,  // kilometer
         Feet,  // feet
         USSurveyFeet,  // US survey feet
         Yard,  // yard
         Surveyor_sChain,  // surveyor's chain
         Mile // mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class RateOfPenetrationQuantity : VelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerSecond,  // MeterPerSecond
         MeterPerHour,  // MeterPerHour
         FootPerSecond,  // FootPerSecond
         FootPerHour // FootPerHour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // MeterPerSecond
         {UnitChoicesEnum.MeterPerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // MeterPerHour
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")},  // FootPerSecond
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")} // FootPerHour
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class WeightOnBitQuantity : GravitationalLoadQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Kilogram,  // kilogram
         TonneMetric,  // tonne metric
         Pound,  // pound
         KiloPound,  // KiloPound
         TonUK // ton UK
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kilogram, new Guid("ef4c5fc1-8774-4aea-b772-35aeae56413d")},  // kilogram
         {UnitChoicesEnum.TonneMetric, new Guid("320b99ba-3115-42f5-939c-15a04d9e7e3c")},  // tonne metric
         {UnitChoicesEnum.Pound, new Guid("e9e313ad-cb28-43fe-93fd-7f94dfee1878")},  // pound
         {UnitChoicesEnum.KiloPound, new Guid("777ff8ee-edc2-46d1-ac40-f097c1e1cd69")},  // KiloPound
         {UnitChoicesEnum.TonUK, new Guid("059c7b81-ed11-410e-9466-4661011372d2")} // ton UK
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class ShockRateQuantity : FrequencyQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // Hertz
         ShockPerMinute,  // ShockPerMinute
         ShockPerHour // ShockPerHour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("8acb8ee8-4cb7-44ef-b702-81c9f3008bf3")},  // Hertz
         {UnitChoicesEnum.ShockPerMinute, new Guid("6ccbee46-cb8a-4777-b1d2-e88eedd24f73")},  // ShockPerMinute
         {UnitChoicesEnum.ShockPerHour, new Guid("0c0d4ecb-ee11-4b57-9bc7-70860637232e")} // ShockPerHour
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
