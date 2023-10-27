using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
  public partial class PhysicalQuantity : Object
  {
     public new enum QuantityEnum 
       {
         Acceleration,  // Acceleration
         AmountSubstance,  // Amount Substance
         AngleVariationGradient,  // AngleVariationGradient
         AngularVelocity,  // AngularVelocity
         Area,  // Area
         Compressibility,  // Compressibility
         Curvature,  // Curvature
         DensityGradientDepth,  // DensityGradientDepth
         DensityGradientTemperature,  // DensityGradientTemperature
         Density,  // Density
         DensitySpeed,  // DensitySpeed
         Dimensionless,  // Dimensionless
         DynamicViscosity,  // DynamicViscosity
         EarthMagneticFluxDensity,  // EarthMagneticFluxDensity
         Capacitance,  // Capacitance
         ElectricalCurrent,  // Electrical Current
         ElectricTension,  // ElectricTension
         ElongationGradient,  // ElongationGradient
         Energy,  // Energy
         ImageScale,  // Image Scale
         Length,  // Length
         LuminousIntensity,  // Luminous Intensity
         Mass,  // Mass
         PlaneAngle,  // Plane Angle
         RelativeTemperature,  // Relative Temperature
         SmallLength,  // Small Length
         SolidAngle,  // Solid Angle
         Temperature,  // Temperature
         Time,  // Time
         Pressure,  // Pressure
         FlowRate,  // FlowRate
         VolumetricFlowRateRateOfChange,  // VolumetricFlowRateRateOfChange
         Velocity,  // Velocity
         ForceGradient,  // ForceGradient
         Force,  // Force
         MaterialStrength,  // MaterialStrength
         Frequency,  // Frequency
         RotationFrequency,  // RotationFrequency
         Proportion,  // Proportion
         HeatTransferCoefficient,  // HeatTransferCoefficient
         GravitationalLoad,  // GravitationalLoad
         HydraulicConductivity,  // HydraulicConductivity
         InterfacialTension,  // InterfacialTension
         Volume,  // Volume
         LargeVolume,  // LargeVolume
         MagneticFluxDensity,  // MagneticFluxDensity
         MassRate,  // MassRate
         Permeability,  // Permeability
         PressureGradient,  // PressureGradient
         PressureLossConstant,  // PressureLossConstant
         Resistivity,  // Resistivity
         FrequencyRateOfChange,  // FrequencyRateOfChange
         RotationFreqencyRateOfChange,  // RotationFreqencyRateOfChange
         SpecificHeatCapacity,  // SpecificHeatCapacity
         SpecificHeatCapcityTemperatureGradient,  // SpecificHeatCapcityTemperatureGradient
         TemperatureGradient,  // TemperatureGradient
         Tension,  // Tension
         ThermalConductivity,  // ThermalConductivity
         MassGradient,  // MassGradient
         ThermalConductivityTemperatureGradient,  // ThermalConductivityTemperatureGradient
         Torque,  // Torque
         YoungModulus,  // YoungModulus
         StandardProportion,  // StandardProportion
         StandardDimensionless,  // StandardDimensionless
         StandardLength,  // Standard Length
         FluidShearRate,  // FluidShearRate
         FluidShearStress,  // FluidShearStress
         RheologyConsistencyIndex,  // RheologyConsistencyIndex
         SmallDiameter,  // Small Diameter
         SmallTorque,  // Small Torque
         SmallRotationFrequency,  // Small Rotation Frequency
         MagneticFlux,  // MagneticFlux
         RandomWalk // RandomWalk
       }
    protected static new Dictionary<QuantityEnum, Guid> enumLookUp_ = new Dictionary<QuantityEnum, Guid>()
    {
         {QuantityEnum.Acceleration, new Guid("454a7b6b-a921-428e-8aa7-a4a636a58e34")},  // Acceleration
         {QuantityEnum.AmountSubstance, new Guid("200be1eb-c278-447c-9b15-32d20fc778b9")},  // Amount Substance
         {QuantityEnum.AngleVariationGradient, new Guid("aed9c464-1073-448b-be62-a6a0c2a53dbc")},  // AngleVariationGradient
         {QuantityEnum.AngularVelocity, new Guid("688ccd2b-6a30-4ccc-8580-a80c3a5803fa")},  // AngularVelocity
         {QuantityEnum.Area, new Guid("2a892bab-1b39-4ae4-b2d2-989621b09557")},  // Area
         {QuantityEnum.Compressibility, new Guid("1e7af8b8-0267-4d5d-a162-59123a8fde14")},  // Compressibility
         {QuantityEnum.Curvature, new Guid("bbfe7349-8cf5-4ca0-8a84-ffe66d7f33d0")},  // Curvature
         {QuantityEnum.DensityGradientDepth, new Guid("037e0326-5095-4c82-ba1b-4df594243cda")},  // DensityGradientDepth
         {QuantityEnum.DensityGradientTemperature, new Guid("2d788f1e-db66-49c3-8eb6-313152cd8e3c")},  // DensityGradientTemperature
         {QuantityEnum.Density, new Guid("5754358c-9359-4bb0-8eb4-08602d19c6af")},  // Density
         {QuantityEnum.DensitySpeed, new Guid("be272506-8c7a-4eff-9a05-ad4d07f36e11")},  // DensitySpeed
         {QuantityEnum.Dimensionless, new Guid("790ae2cd-170c-4908-b2b9-163ba95f5b43")},  // Dimensionless
         {QuantityEnum.DynamicViscosity, new Guid("c830517f-5915-4a8f-ba83-bd102c0a935f")},  // DynamicViscosity
         {QuantityEnum.EarthMagneticFluxDensity, new Guid("ed95aca5-aaf9-4822-b045-342ffcd06ca7")},  // EarthMagneticFluxDensity
         {QuantityEnum.Capacitance, new Guid("9b284ff7-57bb-4ee0-bdbc-5fb7b80f3ae3")},  // Capacitance
         {QuantityEnum.ElectricalCurrent, new Guid("a322deae-e965-41bf-b4fe-a7530d33c9a0")},  // Electrical Current
         {QuantityEnum.ElectricTension, new Guid("da5094a4-7481-4246-9def-1bd3b6f893a1")},  // ElectricTension
         {QuantityEnum.ElongationGradient, new Guid("3c6176f8-8f74-4fbf-bb65-207ed8b0a120")},  // ElongationGradient
         {QuantityEnum.Energy, new Guid("3be49c73-d2d1-40a2-b15f-07a1606d8179")},  // Energy
         {QuantityEnum.ImageScale, new Guid("a3f230b0-a70b-40dd-9305-39e63bb1821b")},  // Image Scale
         {QuantityEnum.Length, new Guid("96058475-80c4-4394-b21a-afd2fb1594c8")},  // Length
         {QuantityEnum.LuminousIntensity, new Guid("fd02d171-cd96-4a41-84cc-431b50ba879b")},  // Luminous Intensity
         {QuantityEnum.Mass, new Guid("99d13248-c303-4b3d-b062-af98de701d6f")},  // Mass
         {QuantityEnum.PlaneAngle, new Guid("751a8f44-d938-4319-a422-a753962fd91f")},  // Plane Angle
         {QuantityEnum.RelativeTemperature, new Guid("58dadec7-7858-414b-8d7b-66504d5c2793")},  // Relative Temperature
         {QuantityEnum.SmallLength, new Guid("3bb73c6f-c40e-4e54-b59a-962bec9aafed")},  // Small Length
         {QuantityEnum.SolidAngle, new Guid("26a7767a-ea4d-417e-a1ef-b7fe674dcd3f")},  // Solid Angle
         {QuantityEnum.Temperature, new Guid("16130f2d-72a8-44a5-beaa-adbb5a1a7b21")},  // Temperature
         {QuantityEnum.Time, new Guid("7106f7cb-ddf2-4e2f-9e21-b19bc83eb248")},  // Time
         {QuantityEnum.Pressure, new Guid("0f282508-9223-489d-86e6-36307f987045")},  // Pressure
         {QuantityEnum.FlowRate, new Guid("9c4eb2bc-413f-456e-ae6b-b1055be8e839")},  // FlowRate
         {QuantityEnum.VolumetricFlowRateRateOfChange, new Guid("7f4f645c-e23e-41bc-bbcc-1dbcef53318e")},  // VolumetricFlowRateRateOfChange
         {QuantityEnum.Velocity, new Guid("b3fd17fe-ce71-4ef3-ac99-cf4f5756e81a")},  // Velocity
         {QuantityEnum.ForceGradient, new Guid("e5212340-1147-4cad-9f71-5cd9d4208ffd")},  // ForceGradient
         {QuantityEnum.Force, new Guid("af9fd237-14d8-4b75-8d0b-34ea8961c20b")},  // Force
         {QuantityEnum.MaterialStrength, new Guid("d9ca8230-a07a-45c0-ba67-051b70607c40")},  // MaterialStrength
         {QuantityEnum.Frequency, new Guid("8a1ff3d9-95c9-43e1-abb4-4ae9b8df861e")},  // Frequency
         {QuantityEnum.RotationFrequency, new Guid("f6f7ab6f-3003-49d2-a17d-92a0f81938f2")},  // RotationFrequency
         {QuantityEnum.Proportion, new Guid("10d2d588-19b8-4822-9240-e1d278d99e32")},  // Proportion
         {QuantityEnum.HeatTransferCoefficient, new Guid("08c247bc-a55b-460e-a9a7-150faf10bdff")},  // HeatTransferCoefficient
         {QuantityEnum.GravitationalLoad, new Guid("55682046-ff04-4a77-9311-a9f738f790b6")},  // GravitationalLoad
         {QuantityEnum.HydraulicConductivity, new Guid("04df2b82-aff0-485a-855e-3d2aa53e12eb")},  // HydraulicConductivity
         {QuantityEnum.InterfacialTension, new Guid("6c2da24b-fa92-415d-9161-150de87dad4c")},  // InterfacialTension
         {QuantityEnum.Volume, new Guid("69151432-d2ed-4473-a3dc-334f8e6daaa6")},  // Volume
         {QuantityEnum.LargeVolume, new Guid("f8ab1afa-7b99-403b-9410-93598bbb4089")},  // LargeVolume
         {QuantityEnum.MagneticFluxDensity, new Guid("b9a3f96b-8861-4b03-9c8a-3c0d7d6ec139")},  // MagneticFluxDensity
         {QuantityEnum.MassRate, new Guid("3dd05c4c-3d6d-49ae-a878-5a5e4a6e7acf")},  // MassRate
         {QuantityEnum.Permeability, new Guid("413da2c1-ebad-454a-ae14-1a8620f8f59c")},  // Permeability
         {QuantityEnum.PressureGradient, new Guid("62eb6afe-bd7d-48dd-b4fd-de40e9f3c632")},  // PressureGradient
         {QuantityEnum.PressureLossConstant, new Guid("6417f6e0-969d-43f2-bee6-249199ec1697")},  // PressureLossConstant
         {QuantityEnum.Resistivity, new Guid("c6c87a27-c04d-4658-8a71-1e46eb3bfd80")},  // Resistivity
         {QuantityEnum.FrequencyRateOfChange, new Guid("e9d5bfe9-428b-4df0-9fe5-d9ad17e6a0cb")},  // FrequencyRateOfChange
         {QuantityEnum.RotationFreqencyRateOfChange, new Guid("ed24a9f7-b70d-4f39-a992-241f25e1a77e")},  // RotationFreqencyRateOfChange
         {QuantityEnum.SpecificHeatCapacity, new Guid("e5c75fa9-0102-42dc-bb0c-830fe9fca2b9")},  // SpecificHeatCapacity
         {QuantityEnum.SpecificHeatCapcityTemperatureGradient, new Guid("3a317540-3db4-47a1-a566-33b6f39b7540")},  // SpecificHeatCapcityTemperatureGradient
         {QuantityEnum.TemperatureGradient, new Guid("4c1819d5-008b-4613-b62a-3f5d91b08ee7")},  // TemperatureGradient
         {QuantityEnum.Tension, new Guid("7c4e127d-aa65-4796-a962-c2c666c4fdd0")},  // Tension
         {QuantityEnum.ThermalConductivity, new Guid("ca23212e-8f2d-4041-89f6-ac8bfa8604fa")},  // ThermalConductivity
         {QuantityEnum.MassGradient, new Guid("b8694592-8f8d-4684-b0ba-c88de50c8486")},  // MassGradient
         {QuantityEnum.ThermalConductivityTemperatureGradient, new Guid("5e509f43-8fb4-490e-b9a5-59d7393761c0")},  // ThermalConductivityTemperatureGradient
         {QuantityEnum.Torque, new Guid("3eb9e01e-48fa-430e-82c6-3aee4d359ac4")},  // Torque
         {QuantityEnum.YoungModulus, new Guid("7ffbcc35-b46f-4656-baf5-c92be501f0ec")},  // YoungModulus
         {QuantityEnum.StandardProportion, new Guid("97555d61-9fc3-4769-9143-6bc2bf51b2d7")},  // StandardProportion
         {QuantityEnum.StandardDimensionless, new Guid("5d356437-ab4e-4de7-8219-1f4988315dee")},  // StandardDimensionless
         {QuantityEnum.StandardLength, new Guid("3716ad37-2b0c-4c0b-8936-6c9cdb47ad1d")},  // Standard Length
         {QuantityEnum.FluidShearRate, new Guid("d3aa72c5-2fc0-4024-902e-6775d63f3231")},  // FluidShearRate
         {QuantityEnum.FluidShearStress, new Guid("b8f8f4f5-1925-4eaf-87c2-2adfdf618454")},  // FluidShearStress
         {QuantityEnum.RheologyConsistencyIndex, new Guid("05571702-00e6-47d7-8590-fd3983645406")},  // RheologyConsistencyIndex
         {QuantityEnum.SmallDiameter, new Guid("d07d00aa-35aa-41c6-a52d-ad51c3f4e97f")},  // Small Diameter
         {QuantityEnum.SmallTorque, new Guid("adf7b170-8d24-4c9f-93e1-40179f361d8c")},  // Small Torque
         {QuantityEnum.SmallRotationFrequency, new Guid("b7ab1664-3d56-4ae5-842a-e4d6d0475ef9")},  // Small Rotation Frequency
         {QuantityEnum.MagneticFlux, new Guid("0d36345b-624d-47c1-9d20-e627a6c6c13a")},  // MagneticFlux
         {QuantityEnum.RandomWalk, new Guid("e3d17133-1c98-4ef2-8b1b-f0d935a4c1e4")} // RandomWalk
    };
  }
}

namespace OSDC.UnitConversion.Conversion
{
  public partial class AccelerationQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerSecondSquare,  // MeterPerSecondSquare
         FootPerSecondSquare,  // FootPerSecondSquare
         CentimeterPerSecondSquare,  // CentimeterPerSecondSquare
         CentimeterPerHourPerSecond,  // CentimeterPerHourPerSecond
         CentimeterPerMinutePerSecond,  // CentimeterPerMinutePerSecond
         FootPerHourPerSecond,  // FootPerHourPerSecond
         FootPerMinutePerSecond,  // FootPerMinutePerSecond
         Galileo,  // Galileo
         GravityStandard,  // GravityStandard
         InchPerHourPerSecond,  // InchPerHourPerSecond
         InchPerMinutePerSecond,  // InchPerMinutePerSecond
         InchPerSecondSquare,  // InchPerSecondSquare
         KnotPerSecond,  // KnotPerSecond
         MeterPerSecondPerMillisecond,  // MeterPerSecondPerMillisecond
         MilePerHourPerSecond,  // MilePerHourPerSecond
         MilePerMinutePerSecond,  // MilePerMinutePerSecond
         MilePerSecondSquare,  // MilePerSecondSquare
         KilometerPerSecondSquare,  // KilometerPerSecondSquare
         KilometerPerHourPerSecond,  // KilometerPerHourPerSecond
         KilometerPerMinutePerSecond // KilometerPerMinutePerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerSecondSquare, new Guid("20515c0b-8a90-4e76-a2b3-cab213db5a06")},  // MeterPerSecondSquare
         {UnitChoicesEnum.FootPerSecondSquare, new Guid("74f20b52-6c15-40e2-ae23-5493326fc879")},  // FootPerSecondSquare
         {UnitChoicesEnum.CentimeterPerSecondSquare, new Guid("4dc923c6-81db-4bd1-aa2c-933966ebbef4")},  // CentimeterPerSecondSquare
         {UnitChoicesEnum.CentimeterPerHourPerSecond, new Guid("b469c349-fd35-4802-b408-dd6f86d62d27")},  // CentimeterPerHourPerSecond
         {UnitChoicesEnum.CentimeterPerMinutePerSecond, new Guid("e681e123-03d7-42eb-9ef5-33da76a6d78c")},  // CentimeterPerMinutePerSecond
         {UnitChoicesEnum.FootPerHourPerSecond, new Guid("ccdc1097-4386-4e78-beff-438807b0d52c")},  // FootPerHourPerSecond
         {UnitChoicesEnum.FootPerMinutePerSecond, new Guid("eea429f4-ada7-4c40-adc0-4054dde8549a")},  // FootPerMinutePerSecond
         {UnitChoicesEnum.Galileo, new Guid("a88f1f6d-e025-47b8-802a-0c802f730824")},  // Galileo
         {UnitChoicesEnum.GravityStandard, new Guid("94dcb02d-04d9-4613-b3c0-d3bdcc3ce382")},  // GravityStandard
         {UnitChoicesEnum.InchPerHourPerSecond, new Guid("16cc4dc1-0fb0-4bfa-acc2-55a754ab47f9")},  // InchPerHourPerSecond
         {UnitChoicesEnum.InchPerMinutePerSecond, new Guid("e33ae152-f371-4b4c-aaf7-51e5635cbcaa")},  // InchPerMinutePerSecond
         {UnitChoicesEnum.InchPerSecondSquare, new Guid("2c872353-889f-444a-a182-1a1d3fd09bb3")},  // InchPerSecondSquare
         {UnitChoicesEnum.KnotPerSecond, new Guid("eefbcd14-1031-4763-8a5d-a9fc8c4fc833")},  // KnotPerSecond
         {UnitChoicesEnum.MeterPerSecondPerMillisecond, new Guid("ecefe9c4-9d38-4fd8-8f56-482f7c54874e")},  // MeterPerSecondPerMillisecond
         {UnitChoicesEnum.MilePerHourPerSecond, new Guid("622bde1c-57b2-4845-8a14-c252a0f6c0df")},  // MilePerHourPerSecond
         {UnitChoicesEnum.MilePerMinutePerSecond, new Guid("f58cace4-7e55-4218-ad64-5c3e420efe02")},  // MilePerMinutePerSecond
         {UnitChoicesEnum.MilePerSecondSquare, new Guid("4f91adee-52ad-420b-94a8-5b45ab0399a9")},  // MilePerSecondSquare
         {UnitChoicesEnum.KilometerPerSecondSquare, new Guid("8b77b272-564a-4637-83cf-bf9d08d231db")},  // KilometerPerSecondSquare
         {UnitChoicesEnum.KilometerPerHourPerSecond, new Guid("9f74f510-f9ce-4393-9d9d-83518519e42a")},  // KilometerPerHourPerSecond
         {UnitChoicesEnum.KilometerPerMinutePerSecond, new Guid("aaaba47c-f11e-44fa-b5df-e981f6356f5a")} // KilometerPerMinutePerSecond
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
  public partial class AmountSubstanceQuantity : BasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
  public partial class AngleVariationGradientQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerMeter,  // RadianPerMeter
         DegreePerMeter,  // DegreePerMeter
         DegreePerCentimeter,  // DegreePerCentimeter
         DegreePerFoot,  // DegreePerFoot
         DegreePerInch // DegreePerInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerMeter, new Guid("5d9782b6-c4c7-47ca-a86b-dce3f63c3747")},  // RadianPerMeter
         {UnitChoicesEnum.DegreePerMeter, new Guid("2fcd4219-8879-4494-9563-5173ec2292fa")},  // DegreePerMeter
         {UnitChoicesEnum.DegreePerCentimeter, new Guid("7f4f63d6-5ea8-4c6b-8be4-81f52b7060c7")},  // DegreePerCentimeter
         {UnitChoicesEnum.DegreePerFoot, new Guid("23bf7716-5779-4607-aef7-1e0eeb7f201b")},  // DegreePerFoot
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class AngularVelocityQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSecond,  // RadianPerSecond
         DegreePerSecond,  // DegreePerSecond
         RadianPerDay,  // RadianPerDay
         RadianPerHour,  // RadianPerHour
         RadianPerMinute,  // RadianPerMinute
         DegreePerDay,  // DegreePerDay
         DegreePerHour,  // DegreePerHour
         DegreePerMinute // DegreePerMinute
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSecond, new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a")},  // RadianPerSecond
         {UnitChoicesEnum.DegreePerSecond, new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e")},  // DegreePerSecond
         {UnitChoicesEnum.RadianPerDay, new Guid("53f2a55b-beb6-4e4d-b696-e817c5b0eaed")},  // RadianPerDay
         {UnitChoicesEnum.RadianPerHour, new Guid("c2f0e82b-236b-4eb5-9c77-b2c500ab60ab")},  // RadianPerHour
         {UnitChoicesEnum.RadianPerMinute, new Guid("5267eb8c-36bc-4ab9-bd62-26f05f852c35")},  // RadianPerMinute
         {UnitChoicesEnum.DegreePerDay, new Guid("ec049b3d-134b-44a3-9746-0419a368beef")},  // DegreePerDay
         {UnitChoicesEnum.DegreePerHour, new Guid("44cc8b17-2f87-49c9-8ab7-7f4ed36d9eb6")},  // DegreePerHour
         {UnitChoicesEnum.DegreePerMinute, new Guid("0a3ad50c-bbfa-456c-9613-84f37b4a80f1")} // DegreePerMinute
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
  public partial class AreaQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMeter,  // SquareMeter
         SquareKilometer,  // SquareKilometer
         Hectar,  // Hectar
         SquareDecimeter,  // SquareDecimeter
         SquareCentimeter,  // SquareCentimeter
         SquareMillimeter,  // SquareMillimeter
         SquareMicrometer,  // SquareMicrometer
         SquareFoot,  // SquareFoot
         SquareInch,  // SquareInch
         SquareYard,  // SquareYard
         Acre,  // Acre
         SquareMile // SquareMile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMeter, new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee")},  // SquareMeter
         {UnitChoicesEnum.SquareKilometer, new Guid("6353513a-6e38-4a58-b20c-d3e8d7b70fb8")},  // SquareKilometer
         {UnitChoicesEnum.Hectar, new Guid("14313265-7985-4010-a19a-5ffaebe05092")},  // Hectar
         {UnitChoicesEnum.SquareDecimeter, new Guid("125fd8d6-d1eb-4826-a952-5219603409ab")},  // SquareDecimeter
         {UnitChoicesEnum.SquareCentimeter, new Guid("d74bb2bc-9c86-4be4-bff1-88cac7b1049b")},  // SquareCentimeter
         {UnitChoicesEnum.SquareMillimeter, new Guid("0b87d221-284a-4e8c-8a60-50c522f9ade4")},  // SquareMillimeter
         {UnitChoicesEnum.SquareMicrometer, new Guid("bec98c97-72c7-4485-9138-058ed14e7fbe")},  // SquareMicrometer
         {UnitChoicesEnum.SquareFoot, new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248")},  // SquareFoot
         {UnitChoicesEnum.SquareInch, new Guid("294bc6d0-5be7-4c70-95f3-ad9dc50f02cf")},  // SquareInch
         {UnitChoicesEnum.SquareYard, new Guid("ae3df24c-e5db-4b88-9e81-228f29855f1b")},  // SquareYard
         {UnitChoicesEnum.Acre, new Guid("bc94456a-b8b9-49ac-b349-eaded6c984c6")},  // Acre
         {UnitChoicesEnum.SquareMile, new Guid("5bbe8c59-cce9-47c8-b357-c5a15610af72")} // SquareMile
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
  public partial class CompressibilityQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         InversePascal,  // InversePascal
         InverseBar,  // InverseBar
         InversePoundPerSquareInch // InversePoundPerSquareInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.InversePascal, new Guid("0e259998-c8bb-4a4d-b281-afb8008b2693")},  // InversePascal
         {UnitChoicesEnum.InverseBar, new Guid("4a0f6df4-0d2d-489b-80f1-511be7713101")},  // InverseBar
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class CurvatureQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerMeter,  // RadianPerMeter
         DegreePer10m,  // DegreePer10m
         DegreePer30m,  // DegreePer30m
         DegreePer30ft,  // DegreePer30ft
         DegreePer100ft,  // DegreePer100ft
         DegreePerFoot,  // DegreePerFoot
         RadianPerFoot,  // RadianPerFoot
         DegreePerMeter // DegreePerMeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerMeter, new Guid("cbba2f64-9914-4c00-a3fe-3c2aef560225")},  // RadianPerMeter
         {UnitChoicesEnum.DegreePer10m, new Guid("c62408d6-c3c5-47bd-8cb0-4fa9faf51598")},  // DegreePer10m
         {UnitChoicesEnum.DegreePer30m, new Guid("98a4d593-c959-49fb-ba1a-b1aa61830cd7")},  // DegreePer30m
         {UnitChoicesEnum.DegreePer30ft, new Guid("284dca7d-b1fc-4e40-ab08-a3e0fa2ef9d0")},  // DegreePer30ft
         {UnitChoicesEnum.DegreePer100ft, new Guid("5aa20ab5-6800-48db-abb1-4c3538b0972d")},  // DegreePer100ft
         {UnitChoicesEnum.DegreePerFoot, new Guid("363a6781-5829-4046-95d8-ce1e844343fc")},  // DegreePerFoot
         {UnitChoicesEnum.RadianPerFoot, new Guid("1428743e-927c-4f7a-9e15-62d37790ad51")},  // RadianPerFoot
         {UnitChoicesEnum.DegreePerMeter, new Guid("7c47f046-0499-4108-937d-abb504883259")} // DegreePerMeter
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
  public partial class DensityGradientDepthQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMeterPerMeter,  // KilogramPerCubicMeterPerMeter
         SpecificGravityPerMeter,  // SpecificGravityPerMeter
         SpecificGravityPer10Meter,  // SpecificGravityPer10Meter
         SpecificGravityPer30Meter,  // SpecificGravityPer30Meter
         SpecificGravityPer100Meter,  // SpecificGravityPer100Meter
         GramPerCubicCentimeterPer100Meter,  // GramPerCubicCentimeterPer100Meter
         PoundPerGallonUKPerFoot,  // PoundPerGallonUKPerFoot
         PoundPerGallonUKPer30Foot,  // PoundPerGallonUKPer30Foot
         PoundPerGallonUKPer100Foot,  // PoundPerGallonUKPer100Foot
         PoundPerGallonUSPerFoot,  // PoundPerGallonUSPerFoot
         PoundPerGallonUSPer30Foot,  // PoundPerGallonUSPer30Foot
         PoundPerGallonUSPer100Foot // PoundPerGallonUSPer100Foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMeterPerMeter, new Guid("00707a6a-2e33-4214-9f8c-3e64eaa82ec1")},  // KilogramPerCubicMeterPerMeter
         {UnitChoicesEnum.SpecificGravityPerMeter, new Guid("07964c1e-b0d5-4785-bee4-8b4b8882b8b2")},  // SpecificGravityPerMeter
         {UnitChoicesEnum.SpecificGravityPer10Meter, new Guid("4af1c9f0-480c-4e80-a62b-c6b57b486c3f")},  // SpecificGravityPer10Meter
         {UnitChoicesEnum.SpecificGravityPer30Meter, new Guid("f8499728-220b-4b2d-94b2-3dc2cdfa6a92")},  // SpecificGravityPer30Meter
         {UnitChoicesEnum.SpecificGravityPer100Meter, new Guid("af987ef2-c8e5-470a-bc53-b2fff05d2c6a")},  // SpecificGravityPer100Meter
         {UnitChoicesEnum.GramPerCubicCentimeterPer100Meter, new Guid("361f976c-6271-41d2-8da3-6b4009cf5e06")},  // GramPerCubicCentimeterPer100Meter
         {UnitChoicesEnum.PoundPerGallonUKPerFoot, new Guid("f2e67c73-3706-4c14-b23a-afe474b2ecbe")},  // PoundPerGallonUKPerFoot
         {UnitChoicesEnum.PoundPerGallonUKPer30Foot, new Guid("684acd16-b420-4952-bc42-ffb47044074d")},  // PoundPerGallonUKPer30Foot
         {UnitChoicesEnum.PoundPerGallonUKPer100Foot, new Guid("f4b6b8a9-c222-4ac9-a6bb-072a9ca7d567")},  // PoundPerGallonUKPer100Foot
         {UnitChoicesEnum.PoundPerGallonUSPerFoot, new Guid("56128f8e-f59e-4f30-927b-35acb6ab44b1")},  // PoundPerGallonUSPerFoot
         {UnitChoicesEnum.PoundPerGallonUSPer30Foot, new Guid("389150f0-4602-4468-bba3-a8eaf1d36ca0")},  // PoundPerGallonUSPer30Foot
         {UnitChoicesEnum.PoundPerGallonUSPer100Foot, new Guid("658a9698-d34b-4a56-9ee3-3cf6e46a52a3")} // PoundPerGallonUSPer100Foot
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
  public partial class DensityGradientTemperatureQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMeterPerKelvin,  // KilogramPerCubicMeterPerKelvin
         SpecificGravityPerCelsius,  // SpecificGravityPerCelsius
         GramPerCubicCentimeterPerCelsius,  // GramPerCubicCentimeterPerCelsius
         PoundPerGallonUKPerCelsius,  // PoundPerGallonUKPerCelsius
         PoundPerGallonUSPerFarenheit // PoundPerGallonUSPerFarenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMeterPerKelvin, new Guid("8b947453-ebe8-4fa9-b59a-87557150e1cf")},  // KilogramPerCubicMeterPerKelvin
         {UnitChoicesEnum.SpecificGravityPerCelsius, new Guid("2b1d68c0-4e75-4e9d-92a1-37d501e7cb3e")},  // SpecificGravityPerCelsius
         {UnitChoicesEnum.GramPerCubicCentimeterPerCelsius, new Guid("e78e2b25-e0a7-4c06-b6df-60f97f767a20")},  // GramPerCubicCentimeterPerCelsius
         {UnitChoicesEnum.PoundPerGallonUKPerCelsius, new Guid("edac57eb-7535-447f-bcf9-0c6709b6ae3b")},  // PoundPerGallonUKPerCelsius
         {UnitChoicesEnum.PoundPerGallonUSPerFarenheit, new Guid("397a5f98-842e-4d86-8fb7-f4f2f82e720b")} // PoundPerGallonUSPerFarenheit
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
  public partial class DensityQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMeter,  // KilogramPerCubicMeter
         GramPerCubicMeter,  // GramPerCubicMeter
         SpecificGravity,  // SpecificGravity
         GramPerCubicCentimeter,  // GramPerCubicCentimeter
         PoundPerGallonUK,  // PoundPerGallonUK
         PoundPerGallonUS,  // PoundPerGallonUS
         PoundPerCubicFoot // PoundPerCubicFoot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMeter, new Guid("8e175ca0-08f6-441d-afcf-a58bbe429abf")},  // KilogramPerCubicMeter
         {UnitChoicesEnum.GramPerCubicMeter, new Guid("8c5b7fc3-0ade-4e85-9646-71ec5fcb869a")},  // GramPerCubicMeter
         {UnitChoicesEnum.SpecificGravity, new Guid("da94ba95-4494-45af-bf99-31f00031c680")},  // SpecificGravity
         {UnitChoicesEnum.GramPerCubicCentimeter, new Guid("64f1b0d8-609f-4ed9-99da-52e18fe97450")},  // GramPerCubicCentimeter
         {UnitChoicesEnum.PoundPerGallonUK, new Guid("75ecf787-8778-4d74-afc7-498e117d27bf")},  // PoundPerGallonUK
         {UnitChoicesEnum.PoundPerGallonUS, new Guid("dcc01dd0-4610-42c7-9a55-2ddeb45ef6da")},  // PoundPerGallonUS
         {UnitChoicesEnum.PoundPerCubicFoot, new Guid("f7479c8c-8d03-460b-bfa3-2b68808be935")} // PoundPerCubicFoot
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
  public partial class DensityRateOfChangeQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMeterPerSecond,  // KilogramPerCubicMeterPerSecond
         SpecificGravityPerSecond,  // SpecificGravityPerSecond
         SpecificGravityPerMinute,  // SpecificGravityPerMinute
         SpecificGravityPerHour,  // SpecificGravityPerHour
         GramPerCubicCentimeterPerHour,  // GramPerCubicCentimeterPerHour
         PoundPerGallonUKPerSecond,  // PoundPerGallonUKPerSecond
         PoundPerGallonUKPerMinute,  // PoundPerGallonUKPerMinute
         PoundPerGallonUKPerHour,  // PoundPerGallonUKPerHour
         PoundPerGallonUSPerSecond,  // PoundPerGallonUSPerSecond
         PoundPerGallonUSPerMinute,  // PoundPerGallonUSPerMinute
         PoundPerGallonUSPerHour // PoundPerGallonUSPerHour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMeterPerSecond, new Guid("d80197aa-f0b2-4a26-a5a4-b132a248c377")},  // KilogramPerCubicMeterPerSecond
         {UnitChoicesEnum.SpecificGravityPerSecond, new Guid("dec0a290-ffd8-4fc0-ae11-3a6068469791")},  // SpecificGravityPerSecond
         {UnitChoicesEnum.SpecificGravityPerMinute, new Guid("9c314f49-3297-4f7b-9cf3-5da32ba2f1cc")},  // SpecificGravityPerMinute
         {UnitChoicesEnum.SpecificGravityPerHour, new Guid("ce5d34b0-d7ab-48a4-87c1-9a43fabf5c06")},  // SpecificGravityPerHour
         {UnitChoicesEnum.GramPerCubicCentimeterPerHour, new Guid("c8d6a682-00ca-4d0f-b603-bf2d755f4b31")},  // GramPerCubicCentimeterPerHour
         {UnitChoicesEnum.PoundPerGallonUKPerSecond, new Guid("e5a712d2-b874-4e7a-873e-a4f4f3ec7a67")},  // PoundPerGallonUKPerSecond
         {UnitChoicesEnum.PoundPerGallonUKPerMinute, new Guid("e79c74b9-774d-4695-81d5-75042f268b96")},  // PoundPerGallonUKPerMinute
         {UnitChoicesEnum.PoundPerGallonUKPerHour, new Guid("5b461e39-d632-4f5e-b7e7-ef30745e5070")},  // PoundPerGallonUKPerHour
         {UnitChoicesEnum.PoundPerGallonUSPerSecond, new Guid("eee6814a-d701-4cd8-b392-ebfedde20e11")},  // PoundPerGallonUSPerSecond
         {UnitChoicesEnum.PoundPerGallonUSPerMinute, new Guid("c047d53d-38f3-4dce-b590-1c9ab700a3ea")},  // PoundPerGallonUSPerMinute
         {UnitChoicesEnum.PoundPerGallonUSPerHour, new Guid("822327d4-9f7c-4e91-9528-4eff5dfc9643")} // PoundPerGallonUSPerHour
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
  public partial class DimensionlessQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Dimensionless // Dimensionless
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Dimensionless, new Guid("8744b0f7-2866-42d8-bf6c-b619ac87b945")} // Dimensionless
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
  public partial class DynamicViscosityQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalSecond,  // PascalSecond
         CentiPoise,  // CentiPoise
         MicroPascalSecond,  // MicroPascalSecond
         MicroPoise,  // MicroPoise
         PoundPer100SquareFootSecond,  // PoundPer100SquareFootSecond
         DynesPerSquareCentimeterSecond // DynesPerSquareCentimeterSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalSecond, new Guid("5707caa4-e293-430d-9575-425305060fcc")},  // PascalSecond
         {UnitChoicesEnum.CentiPoise, new Guid("a71ef873-6ea2-4922-a100-231177de0e85")},  // CentiPoise
         {UnitChoicesEnum.MicroPascalSecond, new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d")},  // MicroPascalSecond
         {UnitChoicesEnum.MicroPoise, new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8")},  // MicroPoise
         {UnitChoicesEnum.PoundPer100SquareFootSecond, new Guid("b48720b9-8eb5-4b5c-8da1-ca2312fdff01")},  // PoundPer100SquareFootSecond
         {UnitChoicesEnum.DynesPerSquareCentimeterSecond, new Guid("90ce61e5-46db-47f9-9c22-1c0f19068132")} // DynesPerSquareCentimeterSecond
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
  public partial class EarthMagneticFluxDensityQuantity : MagneticFluxDensityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Tesla,  // Tesla
         Gauss,  // Gauss
         MilliGauss,  // MilliGauss
         MicroTesla,  // MicroTesla
         NanoTesla // NanoTesla
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Tesla, new Guid("33c3b59d-9876-4918-9f31-f22de88d7bde")},  // Tesla
         {UnitChoicesEnum.Gauss, new Guid("c09cd87d-8a84-45d0-88d3-20bb5cc48559")},  // Gauss
         {UnitChoicesEnum.MilliGauss, new Guid("41ace729-a2ff-4047-adc3-375829de64c6")},  // MilliGauss
         {UnitChoicesEnum.MicroTesla, new Guid("c6b30197-be6b-41b7-803d-a8de61338612")},  // MicroTesla
         {UnitChoicesEnum.NanoTesla, new Guid("9bef9def-8cd3-4f7b-b991-290d3441b3d4")} // NanoTesla
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
  public partial class ElectricalCapacitanceQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Farad,  // Farad
         CoulombPerVolt,  // CoulombPerVolt
         MilliFarad,  // MilliFarad
         MicroFarad,  // MicroFarad
         PicoFarad // PicoFarad
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Farad, new Guid("11dd208b-bcf2-4415-b7a9-4161791166c7")},  // Farad
         {UnitChoicesEnum.CoulombPerVolt, new Guid("81ae5717-d834-4f25-800e-c42c3bcb48af")},  // CoulombPerVolt
         {UnitChoicesEnum.MilliFarad, new Guid("12c8b1ad-d38a-4dbe-b418-7f3b31c23ff6")},  // MilliFarad
         {UnitChoicesEnum.MicroFarad, new Guid("a5974c82-68ac-4166-81b0-123f3ae84701")},  // MicroFarad
         {UnitChoicesEnum.PicoFarad, new Guid("1a9b9112-8a9f-4c80-a2ad-ebe5d9af5eef")} // PicoFarad
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
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
  public partial class ElectricTensionQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Volt,  // Volt
         Millivolt,  // Millivolt
         Centivolt,  // Centivolt
         Kilovolt // Kilovolt
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Volt, new Guid("618fafff-fc9c-4d22-a64d-b7579931aa93")},  // Volt
         {UnitChoicesEnum.Millivolt, new Guid("f186f5d4-2b0b-4cfe-b24c-0c02d3155cf8")},  // Millivolt
         {UnitChoicesEnum.Centivolt, new Guid("ee01194e-dee3-4b50-8312-5fde3c8f774e")},  // Centivolt
         {UnitChoicesEnum.Kilovolt, new Guid("6ffc60bc-ec9f-44d4-961b-79d9e593bf64")} // Kilovolt
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
  public partial class ElongationGradientQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class EnergyQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Joule,  // Joule
         KiloJoule,  // KiloJoule
         MegaJoule,  // MegaJoule
         GigaJoule,  // GigaJoule
         Calorie,  // calorie
         KiloCalorie // KiloCalorie
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Joule, new Guid("c653b7de-0386-467c-8d25-60bb0f6a7076")},  // Joule
         {UnitChoicesEnum.KiloJoule, new Guid("4b0cf63a-84af-4232-b7a1-7531ec1d47b0")},  // KiloJoule
         {UnitChoicesEnum.MegaJoule, new Guid("c4fdba05-7269-4098-8b33-bd8e50c67126")},  // MegaJoule
         {UnitChoicesEnum.GigaJoule, new Guid("c8781145-3c6c-4d87-9567-b0e6ec2821a2")},  // GigaJoule
         {UnitChoicesEnum.Calorie, new Guid("3f020e89-3146-4f3f-9b9b-eecda4400b12")},  // calorie
         {UnitChoicesEnum.KiloCalorie, new Guid("e4e916fe-9e79-47c9-97e5-3e8458358578")} // KiloCalorie
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
  public partial class ImageScaleQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         DotPerMeter,  // dot per meter
         DotPerInch,  // dot per inch
         DotPerMillimeter,  // dot per millimeter
         DotPerMicrometer // dot per micrometer
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
  public partial class LuminousIntensityQuantity : BasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
    public new enum UnitChoicesEnum 
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
         KiloPound,  // KiloPound
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
         {UnitChoicesEnum.KiloPound, new Guid("777ff8ee-edc2-46d1-ac40-f097c1e1cd69")},  // KiloPound
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
  public partial class PlaneAngleQuantity : BasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
  public partial class RelativeTemperatureQuantity : TemperatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Kelvin,  // kelvin
         RelativeCelcius,  // Relative Celcius
         Rankine // Rankine
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class SolidAngleQuantity : BasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Steradian,  // steradian
         Spat,  // spat
         SquareDegree // square degree
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
    public new enum UnitChoicesEnum 
      {
         Kelvin,  // kelvin
         Celsius,  // celsius
         Fahrenheit,  // fahrenheit
         Réaumure // réaumure
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
    public new enum UnitChoicesEnum 
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
         Fortnight,  // fortnight
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
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
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
         {UnitChoicesEnum.Fortnight, new Guid("bc87f864-3dc1-4f1a-87bc-4123a47c53dc")},  // fortnight
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
  public partial class PressureQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // Pascal
         KiloPascal,  // KiloPascal
         Bar,  // Bar
         Millibar,  // Millibar
         Microbar,  // Microbar
         PoundPerSquareInch,  // PoundPerSquareInch
         PoundPer100SquareFoot,  // PoundPer100SquareFoot
         KiloPoundPerSquareInch,  // KiloPoundPerSquareInch
         StandardAtmosphere,  // Standard atmosphere
         PoundPerSquareFoot,  // PoundPerSquareFoot
         MegaPascal,  // MegaPascal
         GigaPascal,  // GigaPascal
         NewtonPerSquareMeter,  // NewtonPerSquareMeter
         NewtonPerSquareCentimeter,  // NewtonPerSquareCentimeter
         NewtonPerSquareMillimeter,  // NewtonPerSquareMillimeter
         KiloNewtonPerSquareMeter,  // KiloNewtonPerSquareMeter
         MegaPoundPerSquareInch,  // MegaPoundPerSquareInch
         Torr,  // Torr
         CentimeterMercuryZeroDegC,  // CentimeterMercuryZeroDegC
         MillimeterMercuryZeroDegC,  // MillimeterMercuryZeroDegC
         InchMercury32DegF,  // InchMercury32DegF
         InchMercury60DegF,  // InchMercury60DegF
         CentimeterWater4DegC,  // CentimeterWater4DegC
         MillimeterWater4DegC,  // MillimeterWater4DegC
         InchWater4DegC,  // InchWater4DegC
         FootWater4DegC,  // FootWater4DegC
         InchWater60DegF,  // InchWater60DegF
         FootWater60DegF,  // FootWater60DegF
         DynesPerSquareCentimeter // DynesPerSquareCentimeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // Pascal
         {UnitChoicesEnum.KiloPascal, new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29")},  // KiloPascal
         {UnitChoicesEnum.Bar, new Guid("0d182739-f8f6-47a6-afcb-71feac973307")},  // Bar
         {UnitChoicesEnum.Millibar, new Guid("43e4fe86-948d-4765-a69d-513ce6dc2b5b")},  // Millibar
         {UnitChoicesEnum.Microbar, new Guid("7fb9e41f-4748-4457-b8b9-efb73da52d94")},  // Microbar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // PoundPerSquareInch
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("e3b95821-d782-4f12-a492-489cbcd6d2a1")},  // PoundPer100SquareFoot
         {UnitChoicesEnum.KiloPoundPerSquareInch, new Guid("a07b5fe5-87e3-4422-afe1-f54de24deeb8")},  // KiloPoundPerSquareInch
         {UnitChoicesEnum.StandardAtmosphere, new Guid("93839971-33f2-43e9-82eb-9f869846f999")},  // Standard atmosphere
         {UnitChoicesEnum.PoundPerSquareFoot, new Guid("35b28889-c076-4274-b200-cf7732b17aa3")},  // PoundPerSquareFoot
         {UnitChoicesEnum.MegaPascal, new Guid("4ef28797-f416-4d97-b36a-711ea848bcc0")},  // MegaPascal
         {UnitChoicesEnum.GigaPascal, new Guid("5c81fb9b-36ad-47b7-9a8e-c999f7fdbfe3")},  // GigaPascal
         {UnitChoicesEnum.NewtonPerSquareMeter, new Guid("101e92c3-47ab-4d55-8982-93061bc82dea")},  // NewtonPerSquareMeter
         {UnitChoicesEnum.NewtonPerSquareCentimeter, new Guid("2aa59deb-84d9-41c5-969f-8c8bb9d0c369")},  // NewtonPerSquareCentimeter
         {UnitChoicesEnum.NewtonPerSquareMillimeter, new Guid("e5e9cb06-38a8-4ac2-a8a5-8b74689a31a8")},  // NewtonPerSquareMillimeter
         {UnitChoicesEnum.KiloNewtonPerSquareMeter, new Guid("eaa46677-af1c-4922-bf61-d82f2925534b")},  // KiloNewtonPerSquareMeter
         {UnitChoicesEnum.MegaPoundPerSquareInch, new Guid("bb49de0a-fbf3-4914-b6b9-fc60ab502522")},  // MegaPoundPerSquareInch
         {UnitChoicesEnum.Torr, new Guid("f5afdfee-624e-46fa-b798-0ab1b04d2181")},  // Torr
         {UnitChoicesEnum.CentimeterMercuryZeroDegC, new Guid("412602dc-837b-4fab-afc9-3bf4798a9bed")},  // CentimeterMercuryZeroDegC
         {UnitChoicesEnum.MillimeterMercuryZeroDegC, new Guid("d91f64fe-4df4-4ddd-943c-d985fbd1659b")},  // MillimeterMercuryZeroDegC
         {UnitChoicesEnum.InchMercury32DegF, new Guid("ab729585-0716-4f24-9502-fcd07ba051bc")},  // InchMercury32DegF
         {UnitChoicesEnum.InchMercury60DegF, new Guid("83ed97cc-526c-41cc-be78-ea0c86412080")},  // InchMercury60DegF
         {UnitChoicesEnum.CentimeterWater4DegC, new Guid("a1bac4cc-f37c-4aa5-aec6-ede0b4c52f09")},  // CentimeterWater4DegC
         {UnitChoicesEnum.MillimeterWater4DegC, new Guid("a46b3ef6-fe2a-4ff3-bc2d-7a26661ce45e")},  // MillimeterWater4DegC
         {UnitChoicesEnum.InchWater4DegC, new Guid("3015f436-b35d-455c-af23-b9bc4dd857da")},  // InchWater4DegC
         {UnitChoicesEnum.FootWater4DegC, new Guid("52de6721-dfec-4a54-861c-e74da72c8470")},  // FootWater4DegC
         {UnitChoicesEnum.InchWater60DegF, new Guid("80b388f3-5036-42cb-8462-91a8bfbc429e")},  // InchWater60DegF
         {UnitChoicesEnum.FootWater60DegF, new Guid("5dc3d224-5a3d-410e-8348-463f802a9b27")},  // FootWater60DegF
         {UnitChoicesEnum.DynesPerSquareCentimeter, new Guid("04ca59b8-90e1-4903-ac82-ee95cac0ca38")} // DynesPerSquareCentimeter
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
  public partial class VolumetricFlowRateQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         LiterPerSecond,  // LiterPerSecond
         CubicMeterPerSecond,  // CubicMeterPerSecond
         CubicFootPerSecond,  // CubicFootPerSecond
         UKGallonPerSecond,  // UKGallonPerSecond
         USGallonPerSecond,  // USGallonPerSecond
         BarrelPerSecond,  // BarrelPerSecond
         CubicMeterPerMinute,  // CubicMeterPerMinute
         LiterPerMinute,  // LiterPerMinute
         CubicFootPerMinute,  // CubicFootPerMinute
         UKGallonPerMinute,  // UKGallonPerMinute
         USGallonPerMinute,  // USGallonPerMinute
         BarrelPerMinute,  // BarrelPerMinute
         CubicMeterPerHour,  // CubicMeterPerHour
         LiterPerHour,  // LiterPerHour
         CubicFootPerHour,  // CubicFootPerHour
         UKGallonPerHour,  // UKGallonPerHour
         USGallonPerHour,  // USGallonPerHour
         BarrelPerHour,  // BarrelPerHour
         CubicMeterPerDay,  // CubicMeterPerDay
         MillionCubicMeterPerDay,  // MillionCubicMeterPerDay
         UKGallonPerDay,  // UKGallonPerDay
         USGallonPerDay,  // USGallonPerDay
         MillionUKGallonPerDay,  // MillionUKGallonPerDay
         MillionUSGallonPerDay,  // MillionUSGallonPerDay
         LiterPerDay,  // LiterPerDay
         MillionLiterPerDay,  // MillionLiterPerDay
         CubicFootPerDay,  // CubicFootPerDay
         ThousandStandardCubicFootPerDay,  // ThousandStandardCubicFootPerDay
         MillionStandardCubicFootPerDay,  // MillionStandardCubicFootPerDay
         BarrelPerDay,  // BarrelPerDay
         CubicMeterPerYear,  // CubicMeterPerYear
         LiterPerYear,  // LiterPerYear
         CubicFootPerYear,  // CubicFootPerYear
         UKGallonPerYear,  // UKGallonPerYear
         USGallonPerYear,  // USGallonPerYear
         BarrelPerYear // BarrelPerYear
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.LiterPerSecond, new Guid("6dafb683-0f61-42ba-a22c-7bd5c9cea4ae")},  // LiterPerSecond
         {UnitChoicesEnum.CubicMeterPerSecond, new Guid("fabe7a23-1ba2-4f5d-b3f5-d5729166c7a0")},  // CubicMeterPerSecond
         {UnitChoicesEnum.CubicFootPerSecond, new Guid("a02fc355-34da-447b-ad1f-66cef4cc96d5")},  // CubicFootPerSecond
         {UnitChoicesEnum.UKGallonPerSecond, new Guid("21ca44f5-ed4e-414d-b285-b38730600794")},  // UKGallonPerSecond
         {UnitChoicesEnum.USGallonPerSecond, new Guid("21fe7e3a-bf92-4c94-b6d7-e2d30dfc4cd3")},  // USGallonPerSecond
         {UnitChoicesEnum.BarrelPerSecond, new Guid("a73caac6-062e-4f79-8374-8fb2598b6842")},  // BarrelPerSecond
         {UnitChoicesEnum.CubicMeterPerMinute, new Guid("98eec130-224c-457a-a5dd-50b55a3a28ab")},  // CubicMeterPerMinute
         {UnitChoicesEnum.LiterPerMinute, new Guid("e1ff1684-02ed-41c0-a82c-40b4a6d348b5")},  // LiterPerMinute
         {UnitChoicesEnum.CubicFootPerMinute, new Guid("a81e08db-d8fd-4379-bc8e-c223c3fb71b3")},  // CubicFootPerMinute
         {UnitChoicesEnum.UKGallonPerMinute, new Guid("bb1d3fbc-efc1-4cf7-9c13-33c25a874224")},  // UKGallonPerMinute
         {UnitChoicesEnum.USGallonPerMinute, new Guid("ceca76e7-fd1e-4220-b072-9f40467a05e3")},  // USGallonPerMinute
         {UnitChoicesEnum.BarrelPerMinute, new Guid("3672c640-3924-4921-861b-d14c99643615")},  // BarrelPerMinute
         {UnitChoicesEnum.CubicMeterPerHour, new Guid("d6607bed-0235-4838-87c8-2ff6c76be2ad")},  // CubicMeterPerHour
         {UnitChoicesEnum.LiterPerHour, new Guid("fe2d8a01-fd2b-4652-80bd-f0da2ce990fd")},  // LiterPerHour
         {UnitChoicesEnum.CubicFootPerHour, new Guid("54f30d1c-670a-4566-bfb2-3ce644d68878")},  // CubicFootPerHour
         {UnitChoicesEnum.UKGallonPerHour, new Guid("85d47672-e1ce-4b33-be1d-eabc2ec1c4c1")},  // UKGallonPerHour
         {UnitChoicesEnum.USGallonPerHour, new Guid("36892d41-4a11-4d32-9a8c-1e43ac1f8c6d")},  // USGallonPerHour
         {UnitChoicesEnum.BarrelPerHour, new Guid("af1bd583-3a13-4d3a-8f65-ede4f8fe9789")},  // BarrelPerHour
         {UnitChoicesEnum.CubicMeterPerDay, new Guid("f512755c-166c-4346-a0f7-74f09703410f")},  // CubicMeterPerDay
         {UnitChoicesEnum.MillionCubicMeterPerDay, new Guid("d09b4db7-9fbe-4018-aeb7-15286ccff8d6")},  // MillionCubicMeterPerDay
         {UnitChoicesEnum.UKGallonPerDay, new Guid("334cf647-375e-4423-8ef4-e1171f938f9a")},  // UKGallonPerDay
         {UnitChoicesEnum.USGallonPerDay, new Guid("c0a47cc8-8ba1-47a1-ab94-d3e4361dd063")},  // USGallonPerDay
         {UnitChoicesEnum.MillionUKGallonPerDay, new Guid("f083576e-1d99-4243-bcfa-5ca6093b6931")},  // MillionUKGallonPerDay
         {UnitChoicesEnum.MillionUSGallonPerDay, new Guid("ffe9958a-3daa-472d-87ab-0b1217dcb1c5")},  // MillionUSGallonPerDay
         {UnitChoicesEnum.LiterPerDay, new Guid("67628fe2-6a64-4ea6-94fe-5a34e7568b53")},  // LiterPerDay
         {UnitChoicesEnum.MillionLiterPerDay, new Guid("1889c1dd-5aa3-45fe-b6cb-79a760e44832")},  // MillionLiterPerDay
         {UnitChoicesEnum.CubicFootPerDay, new Guid("6b9a886b-b96a-473b-8dea-e850583ad5d8")},  // CubicFootPerDay
         {UnitChoicesEnum.ThousandStandardCubicFootPerDay, new Guid("627a75ed-2ab8-480a-96be-b9266d34ba5d")},  // ThousandStandardCubicFootPerDay
         {UnitChoicesEnum.MillionStandardCubicFootPerDay, new Guid("f1c76ab3-8e54-4ad1-a7fe-a09be2a61285")},  // MillionStandardCubicFootPerDay
         {UnitChoicesEnum.BarrelPerDay, new Guid("9d36ce54-5bdc-4f4b-9948-dd65c58c9db3")},  // BarrelPerDay
         {UnitChoicesEnum.CubicMeterPerYear, new Guid("f0e95734-b6a0-4081-b022-8c5bc0e7dd64")},  // CubicMeterPerYear
         {UnitChoicesEnum.LiterPerYear, new Guid("d2b8abd2-cd97-4933-8e0a-54d8a4eef7ce")},  // LiterPerYear
         {UnitChoicesEnum.CubicFootPerYear, new Guid("5ae7fcd3-fae0-4d81-abca-4c3d36d49e6d")},  // CubicFootPerYear
         {UnitChoicesEnum.UKGallonPerYear, new Guid("b7f54c43-a2ee-4b27-bccb-4c0e752e4caf")},  // UKGallonPerYear
         {UnitChoicesEnum.USGallonPerYear, new Guid("94558d1e-fbe2-4f06-a985-44210a1f0bc8")},  // USGallonPerYear
         {UnitChoicesEnum.BarrelPerYear, new Guid("0360ea30-fbf5-4dda-bf99-670dd6983420")} // BarrelPerYear
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
  public partial class VolumetricFlowRateOfChangeQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMeterPerSecondSquare,  // CubicMeterPerSecondSquare
         LiterPerMinuteSquare,  // LiterPerMinuteSquare
         LiterPerMinutePerSecond,  // LiterPerMinutePerSecond
         LiterPerSecondPerSecond,  // LiterPerSecondPerSecond
         UKGallonPerMinuteSquare,  // UKGallonPerMinuteSquare
         UKGallonPerMinutePerSecond,  // UKGallonPerMinutePerSecond
         USGallonPerMinuteSquare,  // USGallonPerMinuteSquare
         USGallonPerMinutePerSecond // USGallonPerMinutePerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMeterPerSecondSquare, new Guid("aef20431-be0b-44ea-8770-a59db19b7f94")},  // CubicMeterPerSecondSquare
         {UnitChoicesEnum.LiterPerMinuteSquare, new Guid("b27d2f54-a1f3-4abb-ba6d-a2a8b530049a")},  // LiterPerMinuteSquare
         {UnitChoicesEnum.LiterPerMinutePerSecond, new Guid("e5a265b6-a9ba-4a09-ba08-b8c417b28ffb")},  // LiterPerMinutePerSecond
         {UnitChoicesEnum.LiterPerSecondPerSecond, new Guid("a899c06f-18dd-4d2a-9743-489f0af5be91")},  // LiterPerSecondPerSecond
         {UnitChoicesEnum.UKGallonPerMinuteSquare, new Guid("c7c61175-e527-4403-8425-32f681367985")},  // UKGallonPerMinuteSquare
         {UnitChoicesEnum.UKGallonPerMinutePerSecond, new Guid("298e7a16-07a5-4b5b-a0de-3e49b31254b4")},  // UKGallonPerMinutePerSecond
         {UnitChoicesEnum.USGallonPerMinuteSquare, new Guid("61885289-823d-4b26-bdf2-bc4744567bef")},  // USGallonPerMinuteSquare
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class VelocityQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterPerSecond,  // MeterPerSecond
         MeterPerMinute,  // MeterPerMinute
         CentimeterPerSecond,  // CentimeterPerSecond
         MeterPerHour,  // MeterPerHour
         MeterPerDay,  // MeterPerDay
         FootPerHour,  // FootPerHour
         FootPerDay,  // FootPerDay
         FootPerMinute,  // FootPerMinute
         FootPerSecond,  // FootPerSecond
         InchPerSecond,  // InchPerSecond
         MilePerHour // MilePerHour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterPerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // MeterPerSecond
         {UnitChoicesEnum.MeterPerMinute, new Guid("824d3b5b-1e51-446a-99a4-39c02377f303")},  // MeterPerMinute
         {UnitChoicesEnum.CentimeterPerSecond, new Guid("d32f84d7-f076-49ab-8bd5-1ccd27e0eba6")},  // CentimeterPerSecond
         {UnitChoicesEnum.MeterPerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // MeterPerHour
         {UnitChoicesEnum.MeterPerDay, new Guid("aa10055f-1ef6-460d-841c-b6dc69f6a7f2")},  // MeterPerDay
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")},  // FootPerHour
         {UnitChoicesEnum.FootPerDay, new Guid("aa58ec87-0dbc-4ed4-b8aa-8553b02c7b14")},  // FootPerDay
         {UnitChoicesEnum.FootPerMinute, new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076")},  // FootPerMinute
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")},  // FootPerSecond
         {UnitChoicesEnum.InchPerSecond, new Guid("8cd16c97-5c7a-4ee9-b59b-cbe2decd8ff9")},  // InchPerSecond
         {UnitChoicesEnum.MilePerHour, new Guid("6c6d0be3-5b60-4b8a-9fd6-8b7afb261081")} // MilePerHour
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
  public partial class ForceGradientQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class ForceQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Newton,  // Newton
         DecaNewton,  // DecaNewton
         KiloNewton,  // KiloNewton
         KiloDecaNewton,  // KiloDecaNewton
         KilogramForce,  // KilogramForce
         PoundForce,  // PoundForce
         KiloPoundForce // KiloPoundForce
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // Newton
         {UnitChoicesEnum.DecaNewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // DecaNewton
         {UnitChoicesEnum.KiloNewton, new Guid("e30d6f94-7887-4746-8d4f-eb720239b702")},  // KiloNewton
         {UnitChoicesEnum.KiloDecaNewton, new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266")},  // KiloDecaNewton
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // KilogramForce
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")},  // PoundForce
         {UnitChoicesEnum.KiloPoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")} // KiloPoundForce
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
  public partial class MaterialStrengthQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // Pascal
         MegaPascal,  // MegaPascal
         GigaPascal,  // GigaPascal
         PSI,  // PSI
         PoundPer100SquareFoot,  // PoundPer100SquareFoot
         MegapoundPerSquareInch // MegapoundPerSquareInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("159e99d3-c79d-4dc6-974f-05cc38af001e")},  // Pascal
         {UnitChoicesEnum.MegaPascal, new Guid("38b95b61-a825-4393-a0e8-ecd686575735")},  // MegaPascal
         {UnitChoicesEnum.GigaPascal, new Guid("c9aa0a18-02ac-42a0-9afe-8a08b4f03331")},  // GigaPascal
         {UnitChoicesEnum.PSI, new Guid("4adf2a33-05c3-49bb-ba61-59dd76f4621e")},  // PSI
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("eb1e2a52-3de3-4338-ad4d-40e8ce90e40b")},  // PoundPer100SquareFoot
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("197a8b98-190d-4d45-91d7-85af12deab02")} // MegapoundPerSquareInch
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
  public partial class FrequencyQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // Hertz
         ReciprocalSecond,  // ReciprocalSecond
         KiloHertz,  // KiloHertz
         MegaHertz,  // MegaHertz
         GigaHertz // GigaHertz
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("7c572c06-0699-4187-9d0c-397f479fe93d")},  // Hertz
         {UnitChoicesEnum.ReciprocalSecond, new Guid("39240f8f-8c82-4026-9db7-f72ec60cb4c9")},  // ReciprocalSecond
         {UnitChoicesEnum.KiloHertz, new Guid("acf483c1-5d7a-4914-afa2-de7abed9be3e")},  // KiloHertz
         {UnitChoicesEnum.MegaHertz, new Guid("6dea9f29-d4f4-49a7-86fe-0205d4bab45e")},  // MegaHertz
         {UnitChoicesEnum.GigaHertz, new Guid("655ee4f9-1782-4ec0-894a-afff9b75cac7")} // GigaHertz
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
  public partial class RotationFrequencyQuantity : FrequencyQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // Hertz
         RPM // RPM
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("59d8be09-9eee-4a88-926c-72e1c7c1242e")},  // Hertz
         {UnitChoicesEnum.RPM, new Guid("30880b5f-803d-412e-9736-62dca3ba5bbd")} // RPM
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
  public partial class ProportionQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class HeatTransferCoefficientQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class GravitationalLoadQuantity : MassQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class HydraulicConductivityQuantity : VelocityQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class InterfacialTensionQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class VolumeQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMeter,  // CubicMeter
         Liter,  // Liter
         Deciliter,  // Deciliter
         Centiliter,  // Centiliter
         Milliliter,  // Milliliter
         USGallon,  // USGallon
         UKGallon,  // UKGallon
         Barrel,  // Barrel
         MillionCubicMeter,  // MillionCubicMeter
         MillionLiter,  // MillionLiter
         MillionUKGallon,  // MillionUKGallon
         MillionBarrel,  // MillionBarrel
         ThousandStandardCubicFoot,  // ThousandStandardCubicFoot
         MillionStandardCubicFoot // MillionStandardCubicFoot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMeter, new Guid("a465ba87-53d6-456c-8e74-315a1a212498")},  // CubicMeter
         {UnitChoicesEnum.Liter, new Guid("3f713743-6248-4b0b-8f3b-c97b6fab76b1")},  // Liter
         {UnitChoicesEnum.Deciliter, new Guid("3d7dde61-a9e9-4df6-8ee4-1eb4a4be1147")},  // Deciliter
         {UnitChoicesEnum.Centiliter, new Guid("8d9baa02-5c3e-46f8-b909-7ca92d7bfa7a")},  // Centiliter
         {UnitChoicesEnum.Milliliter, new Guid("6eb0d045-36e5-448d-be94-96a24a03f3e6")},  // Milliliter
         {UnitChoicesEnum.USGallon, new Guid("1377d8ac-d203-48ed-bad4-733b0dc9d496")},  // USGallon
         {UnitChoicesEnum.UKGallon, new Guid("78f1cef7-c489-498c-96fb-d37474e242a9")},  // UKGallon
         {UnitChoicesEnum.Barrel, new Guid("b0f03925-d158-48ee-8c33-bf72c08cae68")},  // Barrel
         {UnitChoicesEnum.MillionCubicMeter, new Guid("4c021db5-327b-44d3-9c4f-5a9b84af602f")},  // MillionCubicMeter
         {UnitChoicesEnum.MillionLiter, new Guid("4f3f67df-28af-4398-966f-b23de678f50c")},  // MillionLiter
         {UnitChoicesEnum.MillionUKGallon, new Guid("ab9a2938-f519-47c0-bcaa-d61c8fa23c7b")},  // MillionUKGallon
         {UnitChoicesEnum.MillionBarrel, new Guid("9d03120c-2c74-4666-8e24-98e143ab88db")},  // MillionBarrel
         {UnitChoicesEnum.ThousandStandardCubicFoot, new Guid("e50b6a47-cf4c-4a74-8c1c-758000df5d67")},  // ThousandStandardCubicFoot
         {UnitChoicesEnum.MillionStandardCubicFoot, new Guid("387b78ff-d51b-4684-b059-4c813407d767")} // MillionStandardCubicFoot
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
  public partial class LargeVolumeQuantity : VolumeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMeter,  // CubicMeter
         Liter,  // Liter
         USGallon,  // USGallon
         UKGallon,  // UKGallon
         Barrel,  // Barrel
         MillionCubicMeter,  // MillionCubicMeter
         MillionLiter,  // MillionLiter
         MillionUKGallon,  // MillionUKGallon
         MillionBarrel,  // MillionBarrel
         MillionStandardCubicFoot,  // MillionStandardCubicFoot
         ThousandStandardCubicFoot // ThousandStandardCubicFoot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMeter, new Guid("a465ba87-53d6-456c-8e74-315a1a212498")},  // CubicMeter
         {UnitChoicesEnum.Liter, new Guid("3f713743-6248-4b0b-8f3b-c97b6fab76b1")},  // Liter
         {UnitChoicesEnum.USGallon, new Guid("1377d8ac-d203-48ed-bad4-733b0dc9d496")},  // USGallon
         {UnitChoicesEnum.UKGallon, new Guid("78f1cef7-c489-498c-96fb-d37474e242a9")},  // UKGallon
         {UnitChoicesEnum.Barrel, new Guid("b0f03925-d158-48ee-8c33-bf72c08cae68")},  // Barrel
         {UnitChoicesEnum.MillionCubicMeter, new Guid("4c021db5-327b-44d3-9c4f-5a9b84af602f")},  // MillionCubicMeter
         {UnitChoicesEnum.MillionLiter, new Guid("4f3f67df-28af-4398-966f-b23de678f50c")},  // MillionLiter
         {UnitChoicesEnum.MillionUKGallon, new Guid("ab9a2938-f519-47c0-bcaa-d61c8fa23c7b")},  // MillionUKGallon
         {UnitChoicesEnum.MillionBarrel, new Guid("9d03120c-2c74-4666-8e24-98e143ab88db")},  // MillionBarrel
         {UnitChoicesEnum.MillionStandardCubicFoot, new Guid("387b78ff-d51b-4684-b059-4c813407d767")},  // MillionStandardCubicFoot
         {UnitChoicesEnum.ThousandStandardCubicFoot, new Guid("e50b6a47-cf4c-4a74-8c1c-758000df5d67")} // ThousandStandardCubicFoot
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
  public partial class MagneticFluxDensityQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Tesla,  // Tesla
         Gauss,  // Gauss
         MilliGauss,  // MilliGauss
         MilliTesla,  // MilliTesla
         MicroTesla,  // MicroTesla
         NanoTesla,  // NanoTesla
         MaxwellPerSquareCentimeter,  // MaxwellPerSquareCentimeter
         WeberPerSquareMeter // WeberPerSquareMeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Tesla, new Guid("33c3b59d-9876-4918-9f31-f22de88d7bde")},  // Tesla
         {UnitChoicesEnum.Gauss, new Guid("c09cd87d-8a84-45d0-88d3-20bb5cc48559")},  // Gauss
         {UnitChoicesEnum.MilliGauss, new Guid("41ace729-a2ff-4047-adc3-375829de64c6")},  // MilliGauss
         {UnitChoicesEnum.MilliTesla, new Guid("9b6d864e-6775-4668-a59d-e1ab432f8960")},  // MilliTesla
         {UnitChoicesEnum.MicroTesla, new Guid("c6b30197-be6b-41b7-803d-a8de61338612")},  // MicroTesla
         {UnitChoicesEnum.NanoTesla, new Guid("9bef9def-8cd3-4f7b-b991-290d3441b3d4")},  // NanoTesla
         {UnitChoicesEnum.MaxwellPerSquareCentimeter, new Guid("d1b202cb-87c6-417a-947c-5247e5cdfe82")},  // MaxwellPerSquareCentimeter
         {UnitChoicesEnum.WeberPerSquareMeter, new Guid("fefe997a-f3a6-4663-a1de-32889ee0cf15")} // WeberPerSquareMeter
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
  public partial class MassRateQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class PermeabilityQuantity : AreaQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMeter,  // SquareMeter
         Darcy,  // Darcy
         MilliDarcy,  // MilliDarcy
         MicroDarcy // MicroDarcy
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMeter, new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee")},  // SquareMeter
         {UnitChoicesEnum.Darcy, new Guid("9a89bcc3-dc77-4e3a-a492-fcdabc24ec41")},  // Darcy
         {UnitChoicesEnum.MilliDarcy, new Guid("8d7a6767-6c6b-4daf-8617-d35e4055d457")},  // MilliDarcy
         {UnitChoicesEnum.MicroDarcy, new Guid("b552f28d-c68a-4c59-853c-fe6e03dd5f4c")} // MicroDarcy
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
  public partial class PressureGradientQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalPerMeter,  // PascalPerMeter
         BarPerMeter,  // BarPerMeter
         PSIPerMeter,  // PSIPerMeter
         PSIPerFoot // PSIPerFoot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalPerMeter, new Guid("f5a37831-4a70-44de-af34-4f6ce1a54af3")},  // PascalPerMeter
         {UnitChoicesEnum.BarPerMeter, new Guid("73a70891-87cf-44fc-8437-94938f034eec")},  // BarPerMeter
         {UnitChoicesEnum.PSIPerMeter, new Guid("2235a51b-cdf2-4f53-9664-b7a968dbbba3")},  // PSIPerMeter
         {UnitChoicesEnum.PSIPerFoot, new Guid("b99cef5c-d6df-4803-b52b-6050cf7e7ff8")} // PSIPerFoot
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
  public partial class PressureLossConstantQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class ResistivityQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class FrequencyRateOfChangeQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         HertzPerSecond // HertzPerSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.HertzPerSecond, new Guid("4d7e4b49-df76-4259-a96c-8c1250d5ecdd")} // HertzPerSecond
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
  public partial class RotationFrequencyRateOfChangeQuantity : FrequencyRateOfChangeQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class SpecificHeatCapacityQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class SpecificHeatCapacityTemperatureGradientQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class TemperatureGradientQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class TensionQuantity : ForceQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Newton,  // Newton
         DecaNewton,  // DecaNewton
         KiloNewton,  // KiloNewton
         KiloDecaNewton,  // KiloDecaNewton
         KilogramForce,  // KilogramForce
         PoundForce,  // PoundForce
         KiloPoundForce // KiloPoundForce
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // Newton
         {UnitChoicesEnum.DecaNewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // DecaNewton
         {UnitChoicesEnum.KiloNewton, new Guid("e30d6f94-7887-4746-8d4f-eb720239b702")},  // KiloNewton
         {UnitChoicesEnum.KiloDecaNewton, new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266")},  // KiloDecaNewton
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // KilogramForce
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")},  // PoundForce
         {UnitChoicesEnum.KiloPoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")} // KiloPoundForce
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
  public partial class ThermalConductivityQuantity : DerivedPhysicalQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class MassGradientQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerMeter,  // kilogramPerMeter
         PoundPerFoot,  // PoundPerFoot
         GramPerMeter // gramPerMeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerMeter, new Guid("c8b4a6ea-29bf-4e5a-b7ce-9142cefc0752")},  // kilogramPerMeter
         {UnitChoicesEnum.PoundPerFoot, new Guid("6fdf4cb6-a43b-482d-9bc8-d4ad49770f9e")},  // PoundPerFoot
         {UnitChoicesEnum.GramPerMeter, new Guid("0cea1e32-9adb-4882-9070-d027cd0eef8e")} // gramPerMeter
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
  public partial class ThermalConductivityTemperatureGradientQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         WattPerMetreKelvinPerKelvin,  // WattPerMetreKelvinPerKelvin
         CaloriePerMetreSecondDegreeCelsiusPerCelsius,  // CaloriePerMetreSecondDegreeCelsiusPerCelsius
         CaloriePerCentimetreSecondDegreeCelsiusPerCelsius,  // CaloriePerCentimetreSecondDegreeCelsiusPerCelsius
         BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit,  // BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit
         BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit // BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.WattPerMetreKelvinPerKelvin, new Guid("0459940e-d71f-4b01-9ea6-eeb05d754af2")},  // WattPerMetreKelvinPerKelvin
         {UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsiusPerCelsius, new Guid("eb08ff8c-d542-440f-a4c7-610653018910")},  // CaloriePerMetreSecondDegreeCelsiusPerCelsius
         {UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsiusPerCelsius, new Guid("6c21a6cd-61fe-4086-95a7-ad6d6820c96e")},  // CaloriePerCentimetreSecondDegreeCelsiusPerCelsius
         {UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit, new Guid("b79509ea-8c03-4538-9974-208f7e0ee40e")},  // BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit
         {UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit, new Guid("918b4e34-3986-427f-8bb6-c09740a7c299")} // BritishThermalUnitInchPerHourSquareFootDegreeFarenheitPerFarenheit
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
  public partial class TorqueQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterNewton,  // MeterNewton
         MeterDecaNewton,  // MeterDecaNewton
         MeterKilogramForce,  // MeterKilogramForce
         MeterKiloNewton,  // MeterKiloNewton
         FootPound,  // FootPound
         KiloFootPound,  // KiloFootPound
         DecimeterNewton,  // DecimeterNewton
         CentimeterNewton,  // CentimeterNewton
         MillimeterNewton,  // MillimeterNewton
         InchPound // InchPound
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterNewton, new Guid("50b017fa-8d81-4076-a485-61de1d8301b5")},  // MeterNewton
         {UnitChoicesEnum.MeterDecaNewton, new Guid("501ce02c-8a5d-46e6-9ab6-ce443df70402")},  // MeterDecaNewton
         {UnitChoicesEnum.MeterKilogramForce, new Guid("282f97a0-df2a-4016-9ab0-796db49ff384")},  // MeterKilogramForce
         {UnitChoicesEnum.MeterKiloNewton, new Guid("2e417a6e-1acc-4901-8704-7dfeb3f67546")},  // MeterKiloNewton
         {UnitChoicesEnum.FootPound, new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51")},  // FootPound
         {UnitChoicesEnum.KiloFootPound, new Guid("ee9be6ed-df75-4915-be6a-e3941dacd6bd")},  // KiloFootPound
         {UnitChoicesEnum.DecimeterNewton, new Guid("e70db590-c5fb-4ab9-a2c4-3ad611cb7f63")},  // DecimeterNewton
         {UnitChoicesEnum.CentimeterNewton, new Guid("4acf4542-8df0-4f57-a852-7c0184dbeec9")},  // CentimeterNewton
         {UnitChoicesEnum.MillimeterNewton, new Guid("a933225d-7c8e-4ce4-b0ea-4c1c6e9f7e34")},  // MillimeterNewton
         {UnitChoicesEnum.InchPound, new Guid("0d40553e-d8c4-4b75-ad05-61199b15a0a1")} // InchPound
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
  public partial class YoungModulusQuantity : PressureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // Pascal
         MegaPascal,  // MegaPascal
         GigaPascal,  // GigaPascal
         PSI,  // PSI
         MegapoundPerSquareInch // MegapoundPerSquareInch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("1c02aa67-6ec3-4cd1-a61e-b3f1fe4fe0c7")},  // Pascal
         {UnitChoicesEnum.MegaPascal, new Guid("754537d8-8043-48eb-9c0c-2d5efa19562e")},  // MegaPascal
         {UnitChoicesEnum.GigaPascal, new Guid("c50313fd-59ce-429c-b525-f1d7664170c7")},  // GigaPascal
         {UnitChoicesEnum.PSI, new Guid("0305c2fe-1843-446b-badd-a2c02c367249")},  // PSI
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("39285bdf-1b8b-4038-bb33-ab585e702bf3")} // MegapoundPerSquareInch
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
  public partial class StandardProportionQuantity : ProportionQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class StandardDimensionlessQuantity : DimensionlessQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Dimensionless // Dimensionless
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Dimensionless, new Guid("8744b0f7-2866-42d8-bf6c-b619ac87b945")} // Dimensionless
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
  public partial class StandardLengthQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Centimeter,  // centimeter
         Decimeter,  // decimeter
         Feet,  // feet
         Inch,  // inch
         Metre,  // metre
         Micrometer,  // micrometer
         Millimeter // millimeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimeter, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimeter
         {UnitChoicesEnum.Decimeter, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimeter
         {UnitChoicesEnum.Feet, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // feet
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometer, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometer
         {UnitChoicesEnum.Millimeter, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")} // millimeter
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
  public partial class FluidShearRateQuantity : FrequencyQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // Hertz
         ReciprocalSecond // ReciprocalSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("7c572c06-0699-4187-9d0c-397f479fe93d")},  // Hertz
         {UnitChoicesEnum.ReciprocalSecond, new Guid("39240f8f-8c82-4026-9db7-f72ec60cb4c9")} // ReciprocalSecond
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
  public partial class FluidShearStressQuantity : PressureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // Pascal
         KiloPascal,  // KiloPascal
         Bar,  // Bar
         PoundPerSquareInch,  // PoundPerSquareInch
         PoundPerSquareFoot,  // PoundPerSquareFoot
         PoundPer100SquareFoot,  // PoundPer100SquareFoot
         DynesPerSquareCentimeter // DynesPerSquareCentimeter
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // Pascal
         {UnitChoicesEnum.KiloPascal, new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29")},  // KiloPascal
         {UnitChoicesEnum.Bar, new Guid("0d182739-f8f6-47a6-afcb-71feac973307")},  // Bar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // PoundPerSquareInch
         {UnitChoicesEnum.PoundPerSquareFoot, new Guid("35b28889-c076-4274-b200-cf7732b17aa3")},  // PoundPerSquareFoot
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("e3b95821-d782-4f12-a492-489cbcd6d2a1")},  // PoundPer100SquareFoot
         {UnitChoicesEnum.DynesPerSquareCentimeter, new Guid("04ca59b8-90e1-4903-ac82-ee95cac0ca38")} // DynesPerSquareCentimeter
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
  public partial class RheologyConsistencyIndexQuantity : DynamicViscosityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalSecond,  // PascalSecond
         MicroPascalSecond,  // MicroPascalSecond
         CentiPoise,  // CentiPoise
         MicroPoise,  // MicroPoise
         PoundPer100SquareFootSecond,  // PoundPer100SquareFootSecond
         DynesPerSquareCentimeterSecond // DynesPerSquareCentimeterSecond
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalSecond, new Guid("5707caa4-e293-430d-9575-425305060fcc")},  // PascalSecond
         {UnitChoicesEnum.MicroPascalSecond, new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d")},  // MicroPascalSecond
         {UnitChoicesEnum.CentiPoise, new Guid("a71ef873-6ea2-4922-a100-231177de0e85")},  // CentiPoise
         {UnitChoicesEnum.MicroPoise, new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8")},  // MicroPoise
         {UnitChoicesEnum.PoundPer100SquareFootSecond, new Guid("b48720b9-8eb5-4b5c-8da1-ca2312fdff01")},  // PoundPer100SquareFootSecond
         {UnitChoicesEnum.DynesPerSquareCentimeterSecond, new Guid("90ce61e5-46db-47f9-9c22-1c0f19068132")} // DynesPerSquareCentimeterSecond
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
  public partial class SmallDiameterQuantity : LengthQuantity
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
namespace OSDC.UnitConversion.Conversion
{
  public partial class SmallTorqueQuantity : TorqueQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MeterNewton,  // MeterNewton
         FootPound,  // FootPound
         DecimeterNewton,  // DecimeterNewton
         CentimeterNewton,  // CentimeterNewton
         MillimeterNewton,  // MillimeterNewton
         InchPound // InchPound
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MeterNewton, new Guid("50b017fa-8d81-4076-a485-61de1d8301b5")},  // MeterNewton
         {UnitChoicesEnum.FootPound, new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51")},  // FootPound
         {UnitChoicesEnum.DecimeterNewton, new Guid("e70db590-c5fb-4ab9-a2c4-3ad611cb7f63")},  // DecimeterNewton
         {UnitChoicesEnum.CentimeterNewton, new Guid("4acf4542-8df0-4f57-a852-7c0184dbeec9")},  // CentimeterNewton
         {UnitChoicesEnum.MillimeterNewton, new Guid("a933225d-7c8e-4ce4-b0ea-4c1c6e9f7e34")},  // MillimeterNewton
         {UnitChoicesEnum.InchPound, new Guid("0d40553e-d8c4-4b75-ad05-61199b15a0a1")} // InchPound
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
  public partial class SmallRotationFrequencyQuantity : TorqueQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // Hertz
         RPM // RPM
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("59d8be09-9eee-4a88-926c-72e1c7c1242e")},  // Hertz
         {UnitChoicesEnum.RPM, new Guid("30880b5f-803d-412e-9736-62dca3ba5bbd")} // RPM
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
  public partial class MagneticFluxQuantity : DerivedPhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Weber,  // Weber
         Milliweber,  // Milliweber
         MicroWeber,  // MicroWeber
         VoltSecond,  // VoltSecond
         UnitPole,  // UnitPole
         Megaline,  // Megaline
         Kiloline,  // Kiloline
         Line,  // Line
         Maxwell,  // Maxwell
         TeslaSquareMeter,  // TeslaSquareMeter
         TeslaSquareCentimeter,  // TeslaSquareCentimeter
         GaussSquareCentimeter,  // GaussSquareCentimeter
         MagneticFluxQuantum // MagneticFluxQuantum
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Weber, new Guid("d790689d-e7dd-43d8-a3c0-c17ccc8073e5")},  // Weber
         {UnitChoicesEnum.Milliweber, new Guid("94f03fc7-b0bb-4356-8787-c9e33f6559d2")},  // Milliweber
         {UnitChoicesEnum.MicroWeber, new Guid("200b9de7-0635-40eb-8ebd-9cef7c01ac10")},  // MicroWeber
         {UnitChoicesEnum.VoltSecond, new Guid("430305c3-d672-4d68-9b16-d0517243a870")},  // VoltSecond
         {UnitChoicesEnum.UnitPole, new Guid("3bac78d4-5601-4cb2-bea1-01d952597a4d")},  // UnitPole
         {UnitChoicesEnum.Megaline, new Guid("cca39e15-ee2e-4b8f-8843-527b329f3e81")},  // Megaline
         {UnitChoicesEnum.Kiloline, new Guid("85862477-e913-4bcf-9d24-8248ec975d43")},  // Kiloline
         {UnitChoicesEnum.Line, new Guid("40d608dd-b19f-4489-aac3-a3a6b7a55413")},  // Line
         {UnitChoicesEnum.Maxwell, new Guid("8c1fcd01-4a3d-469a-a019-d3b35f7ef8b5")},  // Maxwell
         {UnitChoicesEnum.TeslaSquareMeter, new Guid("f6da9f32-0738-4014-aac6-fdc5935fd436")},  // TeslaSquareMeter
         {UnitChoicesEnum.TeslaSquareCentimeter, new Guid("312b97ea-6167-47b5-a046-c6c202fb7eb4")},  // TeslaSquareCentimeter
         {UnitChoicesEnum.GaussSquareCentimeter, new Guid("a0dc1e92-7e84-401f-bca2-a6eb618ef604")},  // GaussSquareCentimeter
         {UnitChoicesEnum.MagneticFluxQuantum, new Guid("f768bd79-1119-401c-b0df-39a5207273e0")} // MagneticFluxQuantum
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
  public partial class RandomWalkQuantity : DerivedPhysicalQuantity
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
