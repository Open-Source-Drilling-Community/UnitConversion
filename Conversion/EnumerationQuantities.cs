using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
  public partial class BasePhysicalQuantity : Object
  {
     public new enum QuantityEnum 
       {
         Acceleration,  // Acceleration
         AmountSubstance,  // AmountSubstance
         AngleGradientPerLength,  // AngleGradientPerLength
         AngleMagneticFluxDensity,  // AngleMagneticFluxDensity
         AngularAcceleration,  // AngularAcceleration
         AngularVelocity,  // AngularVelocity
         Area,  // Area
         Compressibility,  // Compressibility
         ConsistencyIndexRheology,  // ConsistencyIndexRheology
         Curvature,  // Curvature
         MassDensityGradientPerLength,  // MassDensityGradientPerLength
         MassDensityGradientPerTemperature,  // MassDensityGradientPerTemperature
         MassDensity,  // MassDensity
         MassDensityRateOfChange,  // MassDensityRateOfChange
         Dimensionless,  // Dimensionless
         DynamicViscosity,  // DynamicViscosity
         ElectricCapacitance,  // ElectricCapacitance
         ElectricCurrent,  // ElectricCurrent
         ElectricTension,  // ElectricTension
         ElongationGradientPerLength,  // ElongationGradientPerLength
         EnergyDensity,  // EnergyDensity
         ForceGradientPerLength,  // ForceGradientPerLength
         Force,  // Force
         Frequency,  // Frequency
         FrequencyRateOfChange,  // FrequencyRateOfChange
         HeatTransferCoefficient,  // HeatTransferCoefficient
         ImageScale,  // ImageScale
         InterfacialTension,  // InterfacialTension
         Length,  // Length
         LuminousIntensity,  // LuminousIntensity
         MagneticFluxDensity,  // MagneticFluxDensity
         MagneticFlux,  // MagneticFlux
         MassGradientPerLength,  // MassGradientPerLength
         MassRate,  // MassRate
         MaterialStrength,  // MaterialStrength
         PorousMediumPermeability,  // PorousMediumPermeability
         PlaneAngle,  // PlaneAngle
         Power,  // Power
         PressureGradientPerLength,  // PressureGradientPerLength
         PressureLossConstant,  // PressureLossConstant
         Pressure,  // Pressure
         Proportion,  // Proportion
         RandomWalk,  // RandomWalk
         RelativeTemperature,  // RelativeTemperature
         Resistivity,  // Resistivity
         SolidAngle,  // SolidAngle
         SpecificHeatCapacity,  // SpecificHeatCapacity
         SpecificHeatCapacityGradientPerTemperature,  // SpecificHeatCapacityGradientPerTemperature
         Stress,  // Stress
         TemperatureGradientPerLength,  // TemperatureGradientPerLength
         Temperature,  // Temperature
         ThermalConductivity,  // ThermalConductivity
         ThermalConductivityGradientPerTemperature,  // ThermalConductivityGradientPerTemperature
         Time,  // Time
         TorqueGradientPerLength,  // TorqueGradientPerLength
         Torque,  // Torque
         Velocity,  // Velocity
         Volume,  // Volume
         VolumetricFlowRateOfChange,  // VolumetricFlowRateOfChange
         VolumetricFlowRate,  // VolumetricFlowRate
         WaveNumber,  // WaveNumber
         Mass,  // Mass
         Energy,  // Energy
         DiameterSmall,  // DiameterSmall
         DimensionLessStandard,  // DimensionLessStandard
         EarthMagneticFluxDensity,  // EarthMagneticFluxDensity
         ElasticModulus,  // ElasticModulus
         LengthSmall,  // LengthSmall
         RotationalFrequency,  // RotationalFrequency
         GravitationalLoad,  // GravitationalLoad
         HydraulicConductivity,  // HydraulicConductivity
         VolumeLarge,  // VolumeLarge
         RotationalFrequencyRateOfChange,  // RotationalFrequencyRateOfChange
         Tension,  // Tension
         ProportionStandard,  // ProportionStandard
         LengthStandard,  // LengthStandard
         FluidShearRate,  // FluidShearRate
         FluidShearStress,  // FluidShearStress
         TorqueSmall,  // TorqueSmall
         RotationalFrequencySmall,  // RotationalFrequencySmall
         ProportionSmall,  // ProportionSmall
         Porosity,  // Porosity
         StrokeFrequency,  // StrokeFrequency
         ShockRate // ShockRate
       }
    protected static new Dictionary<QuantityEnum, Guid> enumLookUp_ = new Dictionary<QuantityEnum, Guid>()
    {
         {QuantityEnum.Acceleration, new Guid("454a7b6b-a921-428e-8aa7-a4a636a58e34")},  // Acceleration
         {QuantityEnum.AmountSubstance, new Guid("200be1eb-c278-447c-9b15-32d20fc778b9")},  // AmountSubstance
         {QuantityEnum.AngleGradientPerLength, new Guid("aed9c464-1073-448b-be62-a6a0c2a53dbc")},  // AngleGradientPerLength
         {QuantityEnum.AngleMagneticFluxDensity, new Guid("03bb57e6-ca8b-4741-a211-9cf57c8fd177")},  // AngleMagneticFluxDensity
         {QuantityEnum.AngularAcceleration, new Guid("8b33d305-f77e-4631-9818-7ef574bd0c02")},  // AngularAcceleration
         {QuantityEnum.AngularVelocity, new Guid("688ccd2b-6a30-4ccc-8580-a80c3a5803fa")},  // AngularVelocity
         {QuantityEnum.Area, new Guid("2a892bab-1b39-4ae4-b2d2-989621b09557")},  // Area
         {QuantityEnum.Compressibility, new Guid("1e7af8b8-0267-4d5d-a162-59123a8fde14")},  // Compressibility
         {QuantityEnum.ConsistencyIndexRheology, new Guid("05571702-00e6-47d7-8590-fd3983645406")},  // ConsistencyIndexRheology
         {QuantityEnum.Curvature, new Guid("bbfe7349-8cf5-4ca0-8a84-ffe66d7f33d0")},  // Curvature
         {QuantityEnum.MassDensityGradientPerLength, new Guid("037e0326-5095-4c82-ba1b-4df594243cda")},  // MassDensityGradientPerLength
         {QuantityEnum.MassDensityGradientPerTemperature, new Guid("2d788f1e-db66-49c3-8eb6-313152cd8e3c")},  // MassDensityGradientPerTemperature
         {QuantityEnum.MassDensity, new Guid("5754358c-9359-4bb0-8eb4-08602d19c6af")},  // MassDensity
         {QuantityEnum.MassDensityRateOfChange, new Guid("be272506-8c7a-4eff-9a05-ad4d07f36e11")},  // MassDensityRateOfChange
         {QuantityEnum.Dimensionless, new Guid("790ae2cd-170c-4908-b2b9-163ba95f5b43")},  // Dimensionless
         {QuantityEnum.DynamicViscosity, new Guid("c830517f-5915-4a8f-ba83-bd102c0a935f")},  // DynamicViscosity
         {QuantityEnum.ElectricCapacitance, new Guid("9b284ff7-57bb-4ee0-bdbc-5fb7b80f3ae3")},  // ElectricCapacitance
         {QuantityEnum.ElectricCurrent, new Guid("a322deae-e965-41bf-b4fe-a7530d33c9a0")},  // ElectricCurrent
         {QuantityEnum.ElectricTension, new Guid("da5094a4-7481-4246-9def-1bd3b6f893a1")},  // ElectricTension
         {QuantityEnum.ElongationGradientPerLength, new Guid("3c6176f8-8f74-4fbf-bb65-207ed8b0a120")},  // ElongationGradientPerLength
         {QuantityEnum.EnergyDensity, new Guid("9e82436a-392e-428a-8ee9-0998027c3c46")},  // EnergyDensity
         {QuantityEnum.ForceGradientPerLength, new Guid("e5212340-1147-4cad-9f71-5cd9d4208ffd")},  // ForceGradientPerLength
         {QuantityEnum.Force, new Guid("af9fd237-14d8-4b75-8d0b-34ea8961c20b")},  // Force
         {QuantityEnum.Frequency, new Guid("8a1ff3d9-95c9-43e1-abb4-4ae9b8df861e")},  // Frequency
         {QuantityEnum.FrequencyRateOfChange, new Guid("e9d5bfe9-428b-4df0-9fe5-d9ad17e6a0cb")},  // FrequencyRateOfChange
         {QuantityEnum.HeatTransferCoefficient, new Guid("08c247bc-a55b-460e-a9a7-150faf10bdff")},  // HeatTransferCoefficient
         {QuantityEnum.ImageScale, new Guid("a3f230b0-a70b-40dd-9305-39e63bb1821b")},  // ImageScale
         {QuantityEnum.InterfacialTension, new Guid("6c2da24b-fa92-415d-9161-150de87dad4c")},  // InterfacialTension
         {QuantityEnum.Length, new Guid("96058475-80c4-4394-b21a-afd2fb1594c8")},  // Length
         {QuantityEnum.LuminousIntensity, new Guid("fd02d171-cd96-4a41-84cc-431b50ba879b")},  // LuminousIntensity
         {QuantityEnum.MagneticFluxDensity, new Guid("b9a3f96b-8861-4b03-9c8a-3c0d7d6ec139")},  // MagneticFluxDensity
         {QuantityEnum.MagneticFlux, new Guid("0d36345b-624d-47c1-9d20-e627a6c6c13a")},  // MagneticFlux
         {QuantityEnum.MassGradientPerLength, new Guid("b8694592-8f8d-4684-b0ba-c88de50c8486")},  // MassGradientPerLength
         {QuantityEnum.MassRate, new Guid("3dd05c4c-3d6d-49ae-a878-5a5e4a6e7acf")},  // MassRate
         {QuantityEnum.MaterialStrength, new Guid("d9ca8230-a07a-45c0-ba67-051b70607c40")},  // MaterialStrength
         {QuantityEnum.PorousMediumPermeability, new Guid("413da2c1-ebad-454a-ae14-1a8620f8f59c")},  // PorousMediumPermeability
         {QuantityEnum.PlaneAngle, new Guid("751a8f44-d938-4319-a422-a753962fd91f")},  // PlaneAngle
         {QuantityEnum.Power, new Guid("6fd69f30-a219-4d56-a1dd-000d8175e2ed")},  // Power
         {QuantityEnum.PressureGradientPerLength, new Guid("62eb6afe-bd7d-48dd-b4fd-de40e9f3c632")},  // PressureGradientPerLength
         {QuantityEnum.PressureLossConstant, new Guid("6417f6e0-969d-43f2-bee6-249199ec1697")},  // PressureLossConstant
         {QuantityEnum.Pressure, new Guid("0f282508-9223-489d-86e6-36307f987045")},  // Pressure
         {QuantityEnum.Proportion, new Guid("10d2d588-19b8-4822-9240-e1d278d99e32")},  // Proportion
         {QuantityEnum.RandomWalk, new Guid("e3d17133-1c98-4ef2-8b1b-f0d935a4c1e4")},  // RandomWalk
         {QuantityEnum.RelativeTemperature, new Guid("58dadec7-7858-414b-8d7b-66504d5c2793")},  // RelativeTemperature
         {QuantityEnum.Resistivity, new Guid("c6c87a27-c04d-4658-8a71-1e46eb3bfd80")},  // Resistivity
         {QuantityEnum.SolidAngle, new Guid("26a7767a-ea4d-417e-a1ef-b7fe674dcd3f")},  // SolidAngle
         {QuantityEnum.SpecificHeatCapacity, new Guid("e5c75fa9-0102-42dc-bb0c-830fe9fca2b9")},  // SpecificHeatCapacity
         {QuantityEnum.SpecificHeatCapacityGradientPerTemperature, new Guid("3a317540-3db4-47a1-a566-33b6f39b7540")},  // SpecificHeatCapacityGradientPerTemperature
         {QuantityEnum.Stress, new Guid("e4aa819b-a385-418b-bbca-cfb1421093f5")},  // Stress
         {QuantityEnum.TemperatureGradientPerLength, new Guid("4c1819d5-008b-4613-b62a-3f5d91b08ee7")},  // TemperatureGradientPerLength
         {QuantityEnum.Temperature, new Guid("16130f2d-72a8-44a5-beaa-adbb5a1a7b21")},  // Temperature
         {QuantityEnum.ThermalConductivity, new Guid("ca23212e-8f2d-4041-89f6-ac8bfa8604fa")},  // ThermalConductivity
         {QuantityEnum.ThermalConductivityGradientPerTemperature, new Guid("5e509f43-8fb4-490e-b9a5-59d7393761c0")},  // ThermalConductivityGradientPerTemperature
         {QuantityEnum.Time, new Guid("7106f7cb-ddf2-4e2f-9e21-b19bc83eb248")},  // Time
         {QuantityEnum.TorqueGradientPerLength, new Guid("002104cd-25d6-438d-afe3-065ff392b294")},  // TorqueGradientPerLength
         {QuantityEnum.Torque, new Guid("3eb9e01e-48fa-430e-82c6-3aee4d359ac4")},  // Torque
         {QuantityEnum.Velocity, new Guid("b3fd17fe-ce71-4ef3-ac99-cf4f5756e81a")},  // Velocity
         {QuantityEnum.Volume, new Guid("69151432-d2ed-4473-a3dc-334f8e6daaa6")},  // Volume
         {QuantityEnum.VolumetricFlowRateOfChange, new Guid("7f4f645c-e23e-41bc-bbcc-1dbcef53318e")},  // VolumetricFlowRateOfChange
         {QuantityEnum.VolumetricFlowRate, new Guid("9c4eb2bc-413f-456e-ae6b-b1055be8e839")},  // VolumetricFlowRate
         {QuantityEnum.WaveNumber, new Guid("3709c98d-d471-41dd-bfde-81c4458757e5")},  // WaveNumber
         {QuantityEnum.Mass, new Guid("99d13248-c303-4b3d-b062-af98de701d6f")},  // Mass
         {QuantityEnum.Energy, new Guid("3be49c73-d2d1-40a2-b15f-07a1606d8179")},  // Energy
         {QuantityEnum.DiameterSmall, new Guid("d07d00aa-35aa-41c6-a52d-ad51c3f4e97f")},  // DiameterSmall
         {QuantityEnum.DimensionLessStandard, new Guid("5d356437-ab4e-4de7-8219-1f4988315dee")},  // DimensionLessStandard
         {QuantityEnum.EarthMagneticFluxDensity, new Guid("ed95aca5-aaf9-4822-b045-342ffcd06ca7")},  // EarthMagneticFluxDensity
         {QuantityEnum.ElasticModulus, new Guid("7ffbcc35-b46f-4656-baf5-c92be501f0ec")},  // ElasticModulus
         {QuantityEnum.LengthSmall, new Guid("3bb73c6f-c40e-4e54-b59a-962bec9aafed")},  // LengthSmall
         {QuantityEnum.RotationalFrequency, new Guid("f6f7ab6f-3003-49d2-a17d-92a0f81938f2")},  // RotationalFrequency
         {QuantityEnum.GravitationalLoad, new Guid("55682046-ff04-4a77-9311-a9f738f790b6")},  // GravitationalLoad
         {QuantityEnum.HydraulicConductivity, new Guid("04df2b82-aff0-485a-855e-3d2aa53e12eb")},  // HydraulicConductivity
         {QuantityEnum.VolumeLarge, new Guid("f8ab1afa-7b99-403b-9410-93598bbb4089")},  // VolumeLarge
         {QuantityEnum.RotationalFrequencyRateOfChange, new Guid("ed24a9f7-b70d-4f39-a992-241f25e1a77e")},  // RotationalFrequencyRateOfChange
         {QuantityEnum.Tension, new Guid("7c4e127d-aa65-4796-a962-c2c666c4fdd0")},  // Tension
         {QuantityEnum.ProportionStandard, new Guid("97555d61-9fc3-4769-9143-6bc2bf51b2d7")},  // ProportionStandard
         {QuantityEnum.LengthStandard, new Guid("3716ad37-2b0c-4c0b-8936-6c9cdb47ad1d")},  // LengthStandard
         {QuantityEnum.FluidShearRate, new Guid("d3aa72c5-2fc0-4024-902e-6775d63f3231")},  // FluidShearRate
         {QuantityEnum.FluidShearStress, new Guid("b8f8f4f5-1925-4eaf-87c2-2adfdf618454")},  // FluidShearStress
         {QuantityEnum.TorqueSmall, new Guid("adf7b170-8d24-4c9f-93e1-40179f361d8c")},  // TorqueSmall
         {QuantityEnum.RotationalFrequencySmall, new Guid("b7ab1664-3d56-4ae5-842a-e4d6d0475ef9")},  // RotationalFrequencySmall
         {QuantityEnum.ProportionSmall, new Guid("875392e2-ef43-45f7-a19b-19c51eaba248")},  // ProportionSmall
         {QuantityEnum.Porosity, new Guid("2f6516a1-47cc-498f-8271-e84150183665")},  // Porosity
         {QuantityEnum.StrokeFrequency, new Guid("86fd37e4-3ebf-42ec-9eb2-1e65f7abf29e")},  // StrokeFrequency
         {QuantityEnum.ShockRate, new Guid("0076d96f-bfc3-4f98-8541-4fd12e4bcbff")} // ShockRate
    };
  }
}

namespace OSDC.UnitConversion.Conversion
{
  public partial class AccelerationQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerSecondSquared,  // metre per second squared
         FootPerSecondSquared,  // foot per second squared
         CentimetrePerSecondSquared,  // centimetre per second squared
         CentimetrePerHourPerSecond,  // centimetre per hour per second
         CentimetrePerMinutePerSecond,  // centimetre per minute per second
         FootPerHourPerSecond,  // foot per hour per second
         FootPerMinutePerSecond,  // foot per minute per second
         Galileo,  // galileo
         GravityStandard,  // gravity standard
         InchPerHourPerSecond,  // inch per hour per second
         InchPerMinutePerSecond,  // inch per minute per second
         InchPerSecondSquared,  // inch per second squared
         KnotPerSecond,  // knot per second
         MetrePerSecondPerMillisecond,  // metre per second per millisecond
         MilePerHourPerSecond,  // mile per hour per second
         MilePerMinutePerSecond,  // mile per minute per second
         MilePerSecondSquared,  // mile per second squared
         KilometrePerSecondSquared,  // kilometre per second squared
         KilometrePerHourPerSecond,  // kilometre per hour per second
         KilometrePerMinutePerSecond // kilometre per minute per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerSecondSquared, new Guid("20515c0b-8a90-4e76-a2b3-cab213db5a06")},  // metre per second squared
         {UnitChoicesEnum.FootPerSecondSquared, new Guid("74f20b52-6c15-40e2-ae23-5493326fc879")},  // foot per second squared
         {UnitChoicesEnum.CentimetrePerSecondSquared, new Guid("4dc923c6-81db-4bd1-aa2c-933966ebbef4")},  // centimetre per second squared
         {UnitChoicesEnum.CentimetrePerHourPerSecond, new Guid("b469c349-fd35-4802-b408-dd6f86d62d27")},  // centimetre per hour per second
         {UnitChoicesEnum.CentimetrePerMinutePerSecond, new Guid("e681e123-03d7-42eb-9ef5-33da76a6d78c")},  // centimetre per minute per second
         {UnitChoicesEnum.FootPerHourPerSecond, new Guid("ccdc1097-4386-4e78-beff-438807b0d52c")},  // foot per hour per second
         {UnitChoicesEnum.FootPerMinutePerSecond, new Guid("eea429f4-ada7-4c40-adc0-4054dde8549a")},  // foot per minute per second
         {UnitChoicesEnum.Galileo, new Guid("a88f1f6d-e025-47b8-802a-0c802f730824")},  // galileo
         {UnitChoicesEnum.GravityStandard, new Guid("94dcb02d-04d9-4613-b3c0-d3bdcc3ce382")},  // gravity standard
         {UnitChoicesEnum.InchPerHourPerSecond, new Guid("16cc4dc1-0fb0-4bfa-acc2-55a754ab47f9")},  // inch per hour per second
         {UnitChoicesEnum.InchPerMinutePerSecond, new Guid("e33ae152-f371-4b4c-aaf7-51e5635cbcaa")},  // inch per minute per second
         {UnitChoicesEnum.InchPerSecondSquared, new Guid("2c872353-889f-444a-a182-1a1d3fd09bb3")},  // inch per second squared
         {UnitChoicesEnum.KnotPerSecond, new Guid("eefbcd14-1031-4763-8a5d-a9fc8c4fc833")},  // knot per second
         {UnitChoicesEnum.MetrePerSecondPerMillisecond, new Guid("ecefe9c4-9d38-4fd8-8f56-482f7c54874e")},  // metre per second per millisecond
         {UnitChoicesEnum.MilePerHourPerSecond, new Guid("622bde1c-57b2-4845-8a14-c252a0f6c0df")},  // mile per hour per second
         {UnitChoicesEnum.MilePerMinutePerSecond, new Guid("f58cace4-7e55-4218-ad64-5c3e420efe02")},  // mile per minute per second
         {UnitChoicesEnum.MilePerSecondSquared, new Guid("4f91adee-52ad-420b-94a8-5b45ab0399a9")},  // mile per second squared
         {UnitChoicesEnum.KilometrePerSecondSquared, new Guid("8b77b272-564a-4637-83cf-bf9d08d231db")},  // kilometre per second squared
         {UnitChoicesEnum.KilometrePerHourPerSecond, new Guid("9f74f510-f9ce-4393-9d9d-83518519e42a")},  // kilometre per hour per second
         {UnitChoicesEnum.KilometrePerMinutePerSecond, new Guid("aaaba47c-f11e-44fa-b5df-e981f6356f5a")} // kilometre per minute per second
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
  public partial class AmountSubstanceQuantity : SymbolizedBasePhysicalQuantity
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
  public partial class AngleGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerMetre,  // radian per metre
         DegreePerMetre,  // degree per metre
         DegreePerCentimetre,  // degree per centimetre
         DegreePerFoot,  // degree per foot
         DegreePerInch,  // degree per inch
         DegreePerDecimetre,  // degree per decimetre
         DegreePerMillimetre,  // degree per millimetre
         RadianPerMillimetre,  // radian per millimetre
         RadianPerCentimetre,  // radian per centimetre
         RadianPerDecimetre,  // radian per decimetre
         RadianPerFoot,  // radian per foot
         RadianPerInch // radian per inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerMetre, new Guid("5d9782b6-c4c7-47ca-a86b-dce3f63c3747")},  // radian per metre
         {UnitChoicesEnum.DegreePerMetre, new Guid("2fcd4219-8879-4494-9563-5173ec2292fa")},  // degree per metre
         {UnitChoicesEnum.DegreePerCentimetre, new Guid("7f4f63d6-5ea8-4c6b-8be4-81f52b7060c7")},  // degree per centimetre
         {UnitChoicesEnum.DegreePerFoot, new Guid("23bf7716-5779-4607-aef7-1e0eeb7f201b")},  // degree per foot
         {UnitChoicesEnum.DegreePerInch, new Guid("271db65d-2a9f-4fec-a52a-21e13e106dd4")},  // degree per inch
         {UnitChoicesEnum.DegreePerDecimetre, new Guid("452edd17-d501-487b-8cc1-90c08f7b1417")},  // degree per decimetre
         {UnitChoicesEnum.DegreePerMillimetre, new Guid("5cc72a73-70c0-4ccf-83ae-38e8a45391b4")},  // degree per millimetre
         {UnitChoicesEnum.RadianPerMillimetre, new Guid("dbd20525-128b-43c5-9de4-a8e604cbf6bf")},  // radian per millimetre
         {UnitChoicesEnum.RadianPerCentimetre, new Guid("5552abca-e21b-48ca-aedc-4518a32b8de3")},  // radian per centimetre
         {UnitChoicesEnum.RadianPerDecimetre, new Guid("47e72ab7-444d-4d4b-8cd2-01d2fb8efa2d")},  // radian per decimetre
         {UnitChoicesEnum.RadianPerFoot, new Guid("e1ab7dd2-48c7-4ac8-ac5e-bc50fdcae5df")},  // radian per foot
         {UnitChoicesEnum.RadianPerInch, new Guid("c36cf9c1-d4f2-4654-99eb-5d84eac21c66")} // radian per inch
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
  public partial class AngleMagneticFluxDensityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianTesla,  // radian tesla
         RadianGauss,  // radian gauss
         RadianMilligauss,  // radian milligauss
         RadianMillitesla,  // radian millitesla
         RadianMicrotesla,  // radian microtesla
         RadianNanotesla,  // radian nanotesla
         RadianMaxwellPerSquareCentimetre,  // radian maxwell per square centimetre
         RadianWeberPerSquareMetre,  // radian weber per square metre
         DegreeTesla,  // degree tesla
         DegreeGauss,  // degree gauss
         DegreeMilligauss,  // degree milligauss
         DegreeMillitesla,  // degree millitesla
         DegreeMicrotesla,  // degree microtesla
         DegreeNanotesla,  // degree nanotesla
         DegreeMaxwellPerSquareCentimetre,  // degree maxwell per square centimetre
         DegreeWeberPerSquareMetre // degree weber per square metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianTesla, new Guid("242bd328-96ef-4a1b-9a78-1e2eb8366955")},  // radian tesla
         {UnitChoicesEnum.RadianGauss, new Guid("aa726b90-bd4b-420c-ae71-6f2f1fde3b58")},  // radian gauss
         {UnitChoicesEnum.RadianMilligauss, new Guid("352a5b84-306d-4e38-898a-58705683fdf0")},  // radian milligauss
         {UnitChoicesEnum.RadianMillitesla, new Guid("663639b3-48b8-4c04-a2eb-6ae2e16daa9b")},  // radian millitesla
         {UnitChoicesEnum.RadianMicrotesla, new Guid("b445e592-e0ca-490f-8880-9708e4e96a01")},  // radian microtesla
         {UnitChoicesEnum.RadianNanotesla, new Guid("b4aeee40-29fa-463a-80a4-e10fa42c743f")},  // radian nanotesla
         {UnitChoicesEnum.RadianMaxwellPerSquareCentimetre, new Guid("02d06899-5d89-4669-a4c2-35adb9ec3924")},  // radian maxwell per square centimetre
         {UnitChoicesEnum.RadianWeberPerSquareMetre, new Guid("409e8e85-0870-4529-ae0c-95ab6506c445")},  // radian weber per square metre
         {UnitChoicesEnum.DegreeTesla, new Guid("13df770f-6e77-4de4-91c6-137206e53fbb")},  // degree tesla
         {UnitChoicesEnum.DegreeGauss, new Guid("73bb1de0-ccc0-42e6-b88e-44ecfb6fe7e4")},  // degree gauss
         {UnitChoicesEnum.DegreeMilligauss, new Guid("e74c9ae3-6e17-48e1-896b-e6c1877d68d7")},  // degree milligauss
         {UnitChoicesEnum.DegreeMillitesla, new Guid("812a3461-ae4a-405b-ae5d-73eb23e8a71f")},  // degree millitesla
         {UnitChoicesEnum.DegreeMicrotesla, new Guid("50782201-236e-4537-843b-121e8dca28c6")},  // degree microtesla
         {UnitChoicesEnum.DegreeNanotesla, new Guid("0d9bf20d-2b10-4e73-ae8e-3d3e91862ec0")},  // degree nanotesla
         {UnitChoicesEnum.DegreeMaxwellPerSquareCentimetre, new Guid("092e8231-a6e6-4b29-bdd6-2ae490aa583a")},  // degree maxwell per square centimetre
         {UnitChoicesEnum.DegreeWeberPerSquareMetre, new Guid("2d7e1d60-6401-41c0-b436-612116be9ad4")} // degree weber per square metre
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
  public partial class AngularAccelerationQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSecondSquared,  // radian per second squared
         DegreePerSecondSquared,  // degree per second squared
         RadianPerDayPerSecond,  // radian per day per second
         RadianPerHourPerSecond,  // radian per hour per second
         RadianPerMinutePerSecond,  // radian per minute per second
         DegreePerDayPerSecond,  // degree per day per second
         DegreePerHourPerSecond,  // degree per hour per second
         DegreePerMinutePerSecond,  // degree per minute per second
         RadianPerSecondPerMinute,  // radian per second per minute
         DegreePerSecondPerMinute,  // degree per second per minute
         RadianPerDayPerMinute,  // radian per day per minute
         RadianPerHourPerMinute,  // radian per hour per minute
         RadianPerMinuteSquared,  // radian per minute squared
         DegreePerDayPerMinute,  // degree per day per minute
         DegreePerHourPerMinute,  // degree per hour per minute
         DegreePerMinuteSquared,  // degree per minute squared
         RadianPerSecondPerHour,  // radian per second per hour
         DegreePerSecondPerHour,  // degree per second per hour
         RadianPerDayPerHour,  // radian per day per hour
         RadianPerHourSquared,  // radian per hour squared
         RadianPerMinutePerHour,  // radian per minute per hour
         DegreePerDayPerHour,  // degree per day per hour
         DegreePerHourSquared,  // degree per hour squared
         DegreePerMinutePerHour,  // degree per minute per hour
         RadianPerSecondPerDay,  // radian per second per day
         DegreePerSecondPerDay,  // degree per second per day
         RadianPerDaySquared,  // radian per day squared
         RadianPerHourPerDay,  // radian per hour per day
         RadianPerMinutePerDay,  // radian per minute per day
         DegreePerDaySquared,  // degree per day squared
         DegreePerHourPerDay,  // degree per hour per day
         DegreePerMinutePerDay // degree per minute per day
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSecondSquared, new Guid("15d7ab2b-c0c3-4d33-8242-670ba2f937ff")},  // radian per second squared
         {UnitChoicesEnum.DegreePerSecondSquared, new Guid("6fcc944b-fd7e-4368-baa4-3bb8eeba63a2")},  // degree per second squared
         {UnitChoicesEnum.RadianPerDayPerSecond, new Guid("76b421a7-87e5-4fdf-a280-8e5aea80e0d0")},  // radian per day per second
         {UnitChoicesEnum.RadianPerHourPerSecond, new Guid("70b2f838-b8d2-425f-bea1-0a841c520ba8")},  // radian per hour per second
         {UnitChoicesEnum.RadianPerMinutePerSecond, new Guid("fdf50c96-cef9-466a-80d6-747b99dad734")},  // radian per minute per second
         {UnitChoicesEnum.DegreePerDayPerSecond, new Guid("838a73aa-fd19-42ac-9c72-c62573cda91b")},  // degree per day per second
         {UnitChoicesEnum.DegreePerHourPerSecond, new Guid("cbfff738-14e6-47ad-8b21-41eeeea41439")},  // degree per hour per second
         {UnitChoicesEnum.DegreePerMinutePerSecond, new Guid("f6b4276b-64a8-46f9-a831-fd14a61c34a0")},  // degree per minute per second
         {UnitChoicesEnum.RadianPerSecondPerMinute, new Guid("6bc32ba1-3a66-415a-bc0f-d9292ac77ab6")},  // radian per second per minute
         {UnitChoicesEnum.DegreePerSecondPerMinute, new Guid("2bb42b52-ab2d-4d2f-8ebb-1294f9b35b89")},  // degree per second per minute
         {UnitChoicesEnum.RadianPerDayPerMinute, new Guid("62a8e46b-3701-4375-be57-f5d53df23d87")},  // radian per day per minute
         {UnitChoicesEnum.RadianPerHourPerMinute, new Guid("77f3ea1e-8280-4881-befe-08dc1065a94f")},  // radian per hour per minute
         {UnitChoicesEnum.RadianPerMinuteSquared, new Guid("61ec8b9b-f1c7-4798-bf37-d7f697d0ea8e")},  // radian per minute squared
         {UnitChoicesEnum.DegreePerDayPerMinute, new Guid("22b8d910-ce73-4ce4-87b3-761aa17059d6")},  // degree per day per minute
         {UnitChoicesEnum.DegreePerHourPerMinute, new Guid("414785c2-4d81-472e-a020-7eca9913ebd2")},  // degree per hour per minute
         {UnitChoicesEnum.DegreePerMinuteSquared, new Guid("49b1ab89-8a0c-4bd9-b693-7db0e14b86e9")},  // degree per minute squared
         {UnitChoicesEnum.RadianPerSecondPerHour, new Guid("6bb6033c-3391-4e68-9cc3-63e9d8b03eb3")},  // radian per second per hour
         {UnitChoicesEnum.DegreePerSecondPerHour, new Guid("cdd641f0-2b50-4cb4-88c1-256ac2f5e2b5")},  // degree per second per hour
         {UnitChoicesEnum.RadianPerDayPerHour, new Guid("1ff0952d-4395-4dd6-b101-99b890a46ee8")},  // radian per day per hour
         {UnitChoicesEnum.RadianPerHourSquared, new Guid("f105faab-2b48-402a-98f2-004b99adb5a7")},  // radian per hour squared
         {UnitChoicesEnum.RadianPerMinutePerHour, new Guid("c5713507-731e-482a-bd4e-d86ef21d4ae5")},  // radian per minute per hour
         {UnitChoicesEnum.DegreePerDayPerHour, new Guid("7e8596f9-657f-4eb6-937d-091a55bd0e34")},  // degree per day per hour
         {UnitChoicesEnum.DegreePerHourSquared, new Guid("fad47c71-53d9-4a88-b720-6a953092b41b")},  // degree per hour squared
         {UnitChoicesEnum.DegreePerMinutePerHour, new Guid("a4870e3b-95b7-4c8c-b86a-ffe1d2d6e524")},  // degree per minute per hour
         {UnitChoicesEnum.RadianPerSecondPerDay, new Guid("52462419-b494-473f-a46d-270ae253f076")},  // radian per second per day
         {UnitChoicesEnum.DegreePerSecondPerDay, new Guid("dab003cb-6906-4f9f-8551-e8f72d3a1c4d")},  // degree per second per day
         {UnitChoicesEnum.RadianPerDaySquared, new Guid("6027756a-1c1e-47e8-b938-0bc4e4b25a24")},  // radian per day squared
         {UnitChoicesEnum.RadianPerHourPerDay, new Guid("a31be21e-1f83-4e9b-aaa7-56a2f797c3d6")},  // radian per hour per day
         {UnitChoicesEnum.RadianPerMinutePerDay, new Guid("3335414d-1a69-477b-b27f-61f464a7ca13")},  // radian per minute per day
         {UnitChoicesEnum.DegreePerDaySquared, new Guid("a77c1dea-6fe9-43cc-9f53-75d87e00e458")},  // degree per day squared
         {UnitChoicesEnum.DegreePerHourPerDay, new Guid("69437581-725e-4a66-b945-abaac133be0a")},  // degree per hour per day
         {UnitChoicesEnum.DegreePerMinutePerDay, new Guid("5a8a9fe1-9866-4c71-95a5-23dcb4726235")} // degree per minute per day
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
  public partial class AngularVelocityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSecond,  // radian per second
         DegreePerSecond,  // degree per second
         RadianPerDay,  // radian per day
         RadianPerHour,  // radian per hour
         RadianPerMinute,  // radian per minute
         DegreePerDay,  // degree per day
         DegreePerHour,  // degree per hour
         DegreePerMinute // degree per minute
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSecond, new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a")},  // radian per second
         {UnitChoicesEnum.DegreePerSecond, new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e")},  // degree per second
         {UnitChoicesEnum.RadianPerDay, new Guid("53f2a55b-beb6-4e4d-b696-e817c5b0eaed")},  // radian per day
         {UnitChoicesEnum.RadianPerHour, new Guid("c2f0e82b-236b-4eb5-9c77-b2c500ab60ab")},  // radian per hour
         {UnitChoicesEnum.RadianPerMinute, new Guid("5267eb8c-36bc-4ab9-bd62-26f05f852c35")},  // radian per minute
         {UnitChoicesEnum.DegreePerDay, new Guid("ec049b3d-134b-44a3-9746-0419a368beef")},  // degree per day
         {UnitChoicesEnum.DegreePerHour, new Guid("44cc8b17-2f87-49c9-8ab7-7f4ed36d9eb6")},  // degree per hour
         {UnitChoicesEnum.DegreePerMinute, new Guid("0a3ad50c-bbfa-456c-9613-84f37b4a80f1")} // degree per minute
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
  public partial class AreaQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMetre,  // square metre
         SquareKilometre,  // square kilometre
         Hectare,  // hectare
         SquareDecametre,  // square decametre
         SquareDecimetre,  // square decimetre
         SquareCentimetre,  // square centimetre
         SquareMillimetre,  // square millimetre
         SquareMicrometre,  // square micrometre
         SquareFoot,  // square foot
         SquareInch,  // square inch
         SquareYard,  // square yard
         Acre,  // acre
         SquareMile // square mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMetre, new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee")},  // square metre
         {UnitChoicesEnum.SquareKilometre, new Guid("6353513a-6e38-4a58-b20c-d3e8d7b70fb8")},  // square kilometre
         {UnitChoicesEnum.Hectare, new Guid("14313265-7985-4010-a19a-5ffaebe05092")},  // hectare
         {UnitChoicesEnum.SquareDecametre, new Guid("df9417fc-1c08-4c76-a177-e8ea803b2e2f")},  // square decametre
         {UnitChoicesEnum.SquareDecimetre, new Guid("125fd8d6-d1eb-4826-a952-5219603409ab")},  // square decimetre
         {UnitChoicesEnum.SquareCentimetre, new Guid("d74bb2bc-9c86-4be4-bff1-88cac7b1049b")},  // square centimetre
         {UnitChoicesEnum.SquareMillimetre, new Guid("0b87d221-284a-4e8c-8a60-50c522f9ade4")},  // square millimetre
         {UnitChoicesEnum.SquareMicrometre, new Guid("bec98c97-72c7-4485-9138-058ed14e7fbe")},  // square micrometre
         {UnitChoicesEnum.SquareFoot, new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248")},  // square foot
         {UnitChoicesEnum.SquareInch, new Guid("294bc6d0-5be7-4c70-95f3-ad9dc50f02cf")},  // square inch
         {UnitChoicesEnum.SquareYard, new Guid("ae3df24c-e5db-4b88-9e81-228f29855f1b")},  // square yard
         {UnitChoicesEnum.Acre, new Guid("bc94456a-b8b9-49ac-b349-eaded6c984c6")},  // acre
         {UnitChoicesEnum.SquareMile, new Guid("5bbe8c59-cce9-47c8-b357-c5a15610af72")} // square mile
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
  public partial class CompressibilityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         InversePascal,  // inverse pascal
         InverseBar,  // inverse bar
         InversePoundPerSquareInch,  // inverse pound per square inch
         InverseAtmosphere // inverse atmosphere
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.InversePascal, new Guid("0e259998-c8bb-4a4d-b281-afb8008b2693")},  // inverse pascal
         {UnitChoicesEnum.InverseBar, new Guid("4a0f6df4-0d2d-489b-80f1-511be7713101")},  // inverse bar
         {UnitChoicesEnum.InversePoundPerSquareInch, new Guid("282ab24c-6c43-4710-8e52-433bdf90cc2e")},  // inverse pound per square inch
         {UnitChoicesEnum.InverseAtmosphere, new Guid("92c19398-ac0f-41fc-8a22-516c3dc59c82")} // inverse atmosphere
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
  public partial class ConsistencyIndexRheologyQuantity : DynamicViscosityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalSecond,  // pascal second
         MicropascalSecond,  // micropascal second
         Centipoise,  // centipoise
         Micropoise,  // micropoise
         PoundSecondPer100SquareFoot,  // pound second per 100 square foot
         DyneSecondPerSquareCentimetre // dyne second per square centimetre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalSecond, new Guid("5707caa4-e293-430d-9575-425305060fcc")},  // pascal second
         {UnitChoicesEnum.MicropascalSecond, new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d")},  // micropascal second
         {UnitChoicesEnum.Centipoise, new Guid("a71ef873-6ea2-4922-a100-231177de0e85")},  // centipoise
         {UnitChoicesEnum.Micropoise, new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8")},  // micropoise
         {UnitChoicesEnum.PoundSecondPer100SquareFoot, new Guid("b48720b9-8eb5-4b5c-8da1-ca2312fdff01")},  // pound second per 100 square foot
         {UnitChoicesEnum.DyneSecondPerSquareCentimetre, new Guid("90ce61e5-46db-47f9-9c22-1c0f19068132")} // dyne second per square centimetre
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
  public partial class CurvatureQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerMetre,  // radian per metre
         DegreePer10m,  // degree per 10m
         DegreePer30m,  // degree per 30m
         DegreePer30ft,  // degree per 30ft
         DegreePer100ft,  // degree per 100ft
         DegreePerFoot,  // degree per foot
         RadianPerFoot,  // radian per foot
         DegreePerMetre,  // degree per metre
         DegreePerDecimeter,  // degree per decimeter
         DegreePerCentimeter,  // degree per centimeter
         DegreePerMillimeter,  // degree per millimeter
         DegreePerMicrometer,  // degree per micrometer
         DegreePerNanometer,  // degree per nanometer
         DegreePerDecameter,  // degree per decameter
         DegreePerHectometer,  // degree per hectometer
         DegreePerKilometer,  // degree per kilometer
         RadianPerDecimeter,  // radian per decimeter
         RadianPerCentimeter,  // radian per centimeter
         RadianPerMillimeter,  // radian per millimeter
         RadianPerMicrometer,  // radian per micrometer
         RadianPerNanometer,  // radian per nanometer
         RadianPerDecameter,  // radian per decameter
         RadianPerHectometer,  // radian per hectometer
         RadianPerKilometer,  // radian per kilometer
         DegreePerYard,  // degree per yard
         DegreePerMile,  // degree per mile
         RadianPerYard,  // radian per yard
         RadianPerMile // radian per mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerMetre, new Guid("cbba2f64-9914-4c00-a3fe-3c2aef560225")},  // radian per metre
         {UnitChoicesEnum.DegreePer10m, new Guid("c62408d6-c3c5-47bd-8cb0-4fa9faf51598")},  // degree per 10m
         {UnitChoicesEnum.DegreePer30m, new Guid("98a4d593-c959-49fb-ba1a-b1aa61830cd7")},  // degree per 30m
         {UnitChoicesEnum.DegreePer30ft, new Guid("284dca7d-b1fc-4e40-ab08-a3e0fa2ef9d0")},  // degree per 30ft
         {UnitChoicesEnum.DegreePer100ft, new Guid("5aa20ab5-6800-48db-abb1-4c3538b0972d")},  // degree per 100ft
         {UnitChoicesEnum.DegreePerFoot, new Guid("363a6781-5829-4046-95d8-ce1e844343fc")},  // degree per foot
         {UnitChoicesEnum.RadianPerFoot, new Guid("1428743e-927c-4f7a-9e15-62d37790ad51")},  // radian per foot
         {UnitChoicesEnum.DegreePerMetre, new Guid("7c47f046-0499-4108-937d-abb504883259")},  // degree per metre
         {UnitChoicesEnum.DegreePerDecimeter, new Guid("ed1db27f-5f42-4678-8d0b-8e4e91208a83")},  // degree per decimeter
         {UnitChoicesEnum.DegreePerCentimeter, new Guid("0440cec4-b070-4b03-a065-453c2fafbf24")},  // degree per centimeter
         {UnitChoicesEnum.DegreePerMillimeter, new Guid("c6e0bc05-2ee5-4dd1-85fa-71de7a235ef4")},  // degree per millimeter
         {UnitChoicesEnum.DegreePerMicrometer, new Guid("996e89d6-3b4a-4893-81f5-e4f539e93cf8")},  // degree per micrometer
         {UnitChoicesEnum.DegreePerNanometer, new Guid("e15c78f0-7a6c-47e5-bd3f-4f02571fabe5")},  // degree per nanometer
         {UnitChoicesEnum.DegreePerDecameter, new Guid("970e611b-87ee-4006-aee7-c6d500c33ff0")},  // degree per decameter
         {UnitChoicesEnum.DegreePerHectometer, new Guid("5cca6250-fd0e-47a7-a64f-01b8025950ad")},  // degree per hectometer
         {UnitChoicesEnum.DegreePerKilometer, new Guid("91ef582e-ee8b-4f48-a1f6-c5d96eb634ca")},  // degree per kilometer
         {UnitChoicesEnum.RadianPerDecimeter, new Guid("c6d2c02d-83a6-4043-9a7d-392415a74b12")},  // radian per decimeter
         {UnitChoicesEnum.RadianPerCentimeter, new Guid("f101a0b8-f710-4010-b9a5-6ced681bcf0a")},  // radian per centimeter
         {UnitChoicesEnum.RadianPerMillimeter, new Guid("80e5d9d6-c1fa-4273-8134-33ff4bc46b40")},  // radian per millimeter
         {UnitChoicesEnum.RadianPerMicrometer, new Guid("777ca6bc-48da-4353-a00d-0bf0931a4328")},  // radian per micrometer
         {UnitChoicesEnum.RadianPerNanometer, new Guid("eceb51ee-d3ad-4a42-a877-6b20f927fc01")},  // radian per nanometer
         {UnitChoicesEnum.RadianPerDecameter, new Guid("2e8079f1-260e-4524-be2f-cee1195c7fdd")},  // radian per decameter
         {UnitChoicesEnum.RadianPerHectometer, new Guid("cb2c22fb-ac24-4c65-96d3-2437c8942662")},  // radian per hectometer
         {UnitChoicesEnum.RadianPerKilometer, new Guid("e9a7a647-092a-4349-bb58-0d096a1477c7")},  // radian per kilometer
         {UnitChoicesEnum.DegreePerYard, new Guid("9cb7c45f-56d8-4b03-b514-6b5fc687919c")},  // degree per yard
         {UnitChoicesEnum.DegreePerMile, new Guid("d155bdde-da22-4f3a-9050-9f5f7e69b57d")},  // degree per mile
         {UnitChoicesEnum.RadianPerYard, new Guid("7409e987-f5cb-4d24-93a8-50fc993fe949")},  // radian per yard
         {UnitChoicesEnum.RadianPerMile, new Guid("59e78258-2739-41b4-aa50-8e077bad6678")} // radian per mile
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
  public partial class MassDensityGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerMetre,  // kilogram per cubic metre per metre
         SpecificGravityPerMetre,  // specific gravity per metre
         SpecificGravityPer10Metre,  // specific gravity per 10 metre
         SpecificGravityPer30Metre,  // specific gravity per 30 metre
         SpecificGravityPer100Metre,  // specific gravity per 100 metre
         GramPerCubicCentimetrePer100Metre,  // gram per cubic centimetre per 100 metre
         PoundPerGallonUKPerFoot,  // pound per gallon (UK) per foot
         PoundPerGallonUKPer30Foot,  // pound per gallon (UK) per 30 foot
         PoundPerGallonUKPer100Foot,  // pound per gallon (UK) per 100 foot
         PoundPerGallonUSPerFoot,  // pound per gallon (US) per foot
         PoundPerGallonUSPer30Foot,  // pound per gallon (US) per 30 foot
         PoundPerGallonUSPer100Foot,  // pound per gallon (US) per 100 foot
         KilogramPerCubicMetrePer10Metre,  // kilogram per cubic metre per 10 metre
         KilogramPerCubicMetrePer30Metre,  // kilogram per cubic metre per 30 metre
         KilogramPerCubicMetrePer100Metre,  // kilogram per cubic metre per 100 metre
         GramPerCubicCentimetrePerMetre,  // gram per cubic centimetre per metre
         GramPerCubicCentimetrePer10Metre,  // gram per cubic centimetre per 10 metre
         GramPerCubicCentimetrePer30Metre,  // gram per cubic centimetre per 30 metre
         PoundPerCubicFootPerFoot,  // pound per cubic foot per foot
         PoundPerCubicFootPer30Foot,  // pound per cubic foot per 30 foot
         PoundPerCubicFootPer100Foot,  // pound per cubic foot per 100 foot
         PoundPerCubicInchPerFoot,  // pound per cubic inch per foot
         PoundPerCubicInchPer30Foot,  // pound per cubic inch per 30 foot
         PoundPerCubicInchPer100Foot,  // pound per cubic inch per 100 foot
         PoundPerCubicYardPerFoot,  // pound per cubic yard per foot
         PoundPerCubicYardPer30Foot,  // pound per cubic yard per 30 foot
         PoundPerCubicYardPer100Foot // pound per cubic yard per 100 foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerMetre, new Guid("00707a6a-2e33-4214-9f8c-3e64eaa82ec1")},  // kilogram per cubic metre per metre
         {UnitChoicesEnum.SpecificGravityPerMetre, new Guid("07964c1e-b0d5-4785-bee4-8b4b8882b8b2")},  // specific gravity per metre
         {UnitChoicesEnum.SpecificGravityPer10Metre, new Guid("4af1c9f0-480c-4e80-a62b-c6b57b486c3f")},  // specific gravity per 10 metre
         {UnitChoicesEnum.SpecificGravityPer30Metre, new Guid("f8499728-220b-4b2d-94b2-3dc2cdfa6a92")},  // specific gravity per 30 metre
         {UnitChoicesEnum.SpecificGravityPer100Metre, new Guid("af987ef2-c8e5-470a-bc53-b2fff05d2c6a")},  // specific gravity per 100 metre
         {UnitChoicesEnum.GramPerCubicCentimetrePer100Metre, new Guid("361f976c-6271-41d2-8da3-6b4009cf5e06")},  // gram per cubic centimetre per 100 metre
         {UnitChoicesEnum.PoundPerGallonUKPerFoot, new Guid("f2e67c73-3706-4c14-b23a-afe474b2ecbe")},  // pound per gallon (UK) per foot
         {UnitChoicesEnum.PoundPerGallonUKPer30Foot, new Guid("684acd16-b420-4952-bc42-ffb47044074d")},  // pound per gallon (UK) per 30 foot
         {UnitChoicesEnum.PoundPerGallonUKPer100Foot, new Guid("f4b6b8a9-c222-4ac9-a6bb-072a9ca7d567")},  // pound per gallon (UK) per 100 foot
         {UnitChoicesEnum.PoundPerGallonUSPerFoot, new Guid("56128f8e-f59e-4f30-927b-35acb6ab44b1")},  // pound per gallon (US) per foot
         {UnitChoicesEnum.PoundPerGallonUSPer30Foot, new Guid("389150f0-4602-4468-bba3-a8eaf1d36ca0")},  // pound per gallon (US) per 30 foot
         {UnitChoicesEnum.PoundPerGallonUSPer100Foot, new Guid("658a9698-d34b-4a56-9ee3-3cf6e46a52a3")},  // pound per gallon (US) per 100 foot
         {UnitChoicesEnum.KilogramPerCubicMetrePer10Metre, new Guid("2d0ed7e8-2b80-46ff-9566-bd1429aa3129")},  // kilogram per cubic metre per 10 metre
         {UnitChoicesEnum.KilogramPerCubicMetrePer30Metre, new Guid("dccaa4b1-cf9f-4075-a9f2-50931e38af01")},  // kilogram per cubic metre per 30 metre
         {UnitChoicesEnum.KilogramPerCubicMetrePer100Metre, new Guid("ccca234e-8626-4f75-beed-4da4abad1317")},  // kilogram per cubic metre per 100 metre
         {UnitChoicesEnum.GramPerCubicCentimetrePerMetre, new Guid("91fe264e-6f5f-4a4d-b7f7-1532810ad5bd")},  // gram per cubic centimetre per metre
         {UnitChoicesEnum.GramPerCubicCentimetrePer10Metre, new Guid("836701f1-1fbd-4ae3-aba8-17a97379272c")},  // gram per cubic centimetre per 10 metre
         {UnitChoicesEnum.GramPerCubicCentimetrePer30Metre, new Guid("faaa4f2f-4dd4-419a-a985-ea16c5fc6d49")},  // gram per cubic centimetre per 30 metre
         {UnitChoicesEnum.PoundPerCubicFootPerFoot, new Guid("2c75c006-8ab5-475e-87aa-f5b0501b5ad7")},  // pound per cubic foot per foot
         {UnitChoicesEnum.PoundPerCubicFootPer30Foot, new Guid("cd7e9b61-06e9-41ca-b1dd-c2dd0b2cce55")},  // pound per cubic foot per 30 foot
         {UnitChoicesEnum.PoundPerCubicFootPer100Foot, new Guid("bd3c10c7-aa1b-438a-a61d-791f05de5a64")},  // pound per cubic foot per 100 foot
         {UnitChoicesEnum.PoundPerCubicInchPerFoot, new Guid("8997f813-9692-4f1a-b281-42260799f2ab")},  // pound per cubic inch per foot
         {UnitChoicesEnum.PoundPerCubicInchPer30Foot, new Guid("394876ee-1779-4ac0-a306-ad64fd9b640f")},  // pound per cubic inch per 30 foot
         {UnitChoicesEnum.PoundPerCubicInchPer100Foot, new Guid("11826f55-a121-498c-b03d-e51431f00476")},  // pound per cubic inch per 100 foot
         {UnitChoicesEnum.PoundPerCubicYardPerFoot, new Guid("09c728a5-da92-4a0c-a5bb-3aa166c2564d")},  // pound per cubic yard per foot
         {UnitChoicesEnum.PoundPerCubicYardPer30Foot, new Guid("82a23b2f-56a9-4345-97ec-61e6ec250915")},  // pound per cubic yard per 30 foot
         {UnitChoicesEnum.PoundPerCubicYardPer100Foot, new Guid("6f82e6f2-2cb8-467f-8baa-6d766056acf7")} // pound per cubic yard per 100 foot
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
  public partial class MassDensityGradientPerTemperatureQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerKelvin,  // kilogram per cubic metre per kelvin
         SpecificGravityPerCelsius,  // specific gravity per celsius
         GramPerCubicCentimetrePerCelsius,  // gram per cubic centimetre per celsius
         PoundPerGallonUKPerCelsius,  // pound per gallon (UK) per celsius
         PoundPerGallonUSPerFahrenheit,  // pound per gallon (US) per fahrenheit
         PoundPerGallonUKPerFahrenheit,  // pound per gallon (UK) per fahrenheit
         PoundPerGallonUSPerCelsius,  // pound per gallon (US) per celsius
         PoundPerCubicFootPerCelsius,  // pound per cubic foot per celsius
         PoundPerCubicFootPerFahrenheit,  // pound per cubic foot per fahrenheit
         PoundPerCubicInchPerCelsius,  // pound per cubic inch per celsius
         PoundPerCubicInchPerFahrenheit,  // pound per cubic inch per fahrenheit
         PoundPerCubicYardPerCelsius,  // pound per cubic yard per celsius
         PoundPerCubicYeardPerFahrenheit // pound per cubic yeard per fahrenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerKelvin, new Guid("8b947453-ebe8-4fa9-b59a-87557150e1cf")},  // kilogram per cubic metre per kelvin
         {UnitChoicesEnum.SpecificGravityPerCelsius, new Guid("2b1d68c0-4e75-4e9d-92a1-37d501e7cb3e")},  // specific gravity per celsius
         {UnitChoicesEnum.GramPerCubicCentimetrePerCelsius, new Guid("e78e2b25-e0a7-4c06-b6df-60f97f767a20")},  // gram per cubic centimetre per celsius
         {UnitChoicesEnum.PoundPerGallonUKPerCelsius, new Guid("edac57eb-7535-447f-bcf9-0c6709b6ae3b")},  // pound per gallon (UK) per celsius
         {UnitChoicesEnum.PoundPerGallonUSPerFahrenheit, new Guid("397a5f98-842e-4d86-8fb7-f4f2f82e720b")},  // pound per gallon (US) per fahrenheit
         {UnitChoicesEnum.PoundPerGallonUKPerFahrenheit, new Guid("24485846-7944-4903-a5c5-975298daf450")},  // pound per gallon (UK) per fahrenheit
         {UnitChoicesEnum.PoundPerGallonUSPerCelsius, new Guid("8b642465-acee-4a4a-9cb5-6fc16ace5bc3")},  // pound per gallon (US) per celsius
         {UnitChoicesEnum.PoundPerCubicFootPerCelsius, new Guid("592a60a7-71e1-40dc-bfe0-573e407b893c")},  // pound per cubic foot per celsius
         {UnitChoicesEnum.PoundPerCubicFootPerFahrenheit, new Guid("64b97848-5c42-49ec-a09e-05c7bd0cea6b")},  // pound per cubic foot per fahrenheit
         {UnitChoicesEnum.PoundPerCubicInchPerCelsius, new Guid("10e845fe-c8c1-4847-bf6a-874c1f746325")},  // pound per cubic inch per celsius
         {UnitChoicesEnum.PoundPerCubicInchPerFahrenheit, new Guid("586d023b-3c87-4354-bce9-5704c8d1ae0a")},  // pound per cubic inch per fahrenheit
         {UnitChoicesEnum.PoundPerCubicYardPerCelsius, new Guid("ea5147c2-d35b-4e0c-8c47-e9f04a6e0fa1")},  // pound per cubic yard per celsius
         {UnitChoicesEnum.PoundPerCubicYeardPerFahrenheit, new Guid("e15f8f82-0d58-487a-9d70-8f14f3606177")} // pound per cubic yeard per fahrenheit
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
  public partial class MassDensityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetre,  // kilogram per cubic metre
         GramPerCubicMetre,  // gram per cubic metre
         SpecificGravity,  // specific gravity
         GramPerCubicCentimetre,  // gram per cubic centimetre
         PoundPerGallonUK,  // pound per gallon (UK)
         PoundPerGallonUS,  // pound per gallon (US)
         PoundPerCubicFoot,  // pound per cubic foot
         PoundPerCubicInch,  // pound per cubic inch
         PoundPerCubicYard // pound per cubic yard
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetre, new Guid("8e175ca0-08f6-441d-afcf-a58bbe429abf")},  // kilogram per cubic metre
         {UnitChoicesEnum.GramPerCubicMetre, new Guid("8c5b7fc3-0ade-4e85-9646-71ec5fcb869a")},  // gram per cubic metre
         {UnitChoicesEnum.SpecificGravity, new Guid("da94ba95-4494-45af-bf99-31f00031c680")},  // specific gravity
         {UnitChoicesEnum.GramPerCubicCentimetre, new Guid("64f1b0d8-609f-4ed9-99da-52e18fe97450")},  // gram per cubic centimetre
         {UnitChoicesEnum.PoundPerGallonUK, new Guid("75ecf787-8778-4d74-afc7-498e117d27bf")},  // pound per gallon (UK)
         {UnitChoicesEnum.PoundPerGallonUS, new Guid("dcc01dd0-4610-42c7-9a55-2ddeb45ef6da")},  // pound per gallon (US)
         {UnitChoicesEnum.PoundPerCubicFoot, new Guid("f7479c8c-8d03-460b-bfa3-2b68808be935")},  // pound per cubic foot
         {UnitChoicesEnum.PoundPerCubicInch, new Guid("d549658a-76ab-4507-8a9e-e62a5cf47e23")},  // pound per cubic inch
         {UnitChoicesEnum.PoundPerCubicYard, new Guid("8199e187-5283-42cc-891e-b3887c3aa450")} // pound per cubic yard
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
  public partial class MassDensityRateOfChangeQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerSecond,  // kilogram per cubic metre per second
         SpecificGravityPerSecond,  // specific gravity per second
         SpecificGravityPerMinute,  // specific gravity per minute
         SpecificGravityPerHour,  // specific gravity per hour
         GramPerCubicCentimetrePerSecond,  // gram per cubic centimetre per second
         GramPerCubicCentimetrePerMinute,  // gram per cubic centimetre per minute
         GramPerCubicCentimetrePerHour,  // gram per cubic centimetre per hour
         PoundPerGallonUKPerSecond,  // pound per gallon (UK) per second
         PoundPerGallonUKPerMinute,  // pound per gallon (UK) per minute
         PoundPerGallonUKPerHour,  // pound per gallon (UK) per hour
         PoundPerGallonUSPerSecond,  // pound per gallon (US) per second
         PoundPerGallonUSPerMinute,  // pound per gallon (US) per minute
         PoundPerGallonUSPerHour // pound per gallon (US) per hour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerSecond, new Guid("d80197aa-f0b2-4a26-a5a4-b132a248c377")},  // kilogram per cubic metre per second
         {UnitChoicesEnum.SpecificGravityPerSecond, new Guid("dec0a290-ffd8-4fc0-ae11-3a6068469791")},  // specific gravity per second
         {UnitChoicesEnum.SpecificGravityPerMinute, new Guid("9c314f49-3297-4f7b-9cf3-5da32ba2f1cc")},  // specific gravity per minute
         {UnitChoicesEnum.SpecificGravityPerHour, new Guid("ce5d34b0-d7ab-48a4-87c1-9a43fabf5c06")},  // specific gravity per hour
         {UnitChoicesEnum.GramPerCubicCentimetrePerSecond, new Guid("e26f57a2-9659-40fd-a670-38a3b83fd36f")},  // gram per cubic centimetre per second
         {UnitChoicesEnum.GramPerCubicCentimetrePerMinute, new Guid("93777f41-0e47-46aa-9ab6-413987553817")},  // gram per cubic centimetre per minute
         {UnitChoicesEnum.GramPerCubicCentimetrePerHour, new Guid("c8d6a682-00ca-4d0f-b603-bf2d755f4b31")},  // gram per cubic centimetre per hour
         {UnitChoicesEnum.PoundPerGallonUKPerSecond, new Guid("e5a712d2-b874-4e7a-873e-a4f4f3ec7a67")},  // pound per gallon (UK) per second
         {UnitChoicesEnum.PoundPerGallonUKPerMinute, new Guid("e79c74b9-774d-4695-81d5-75042f268b96")},  // pound per gallon (UK) per minute
         {UnitChoicesEnum.PoundPerGallonUKPerHour, new Guid("5b461e39-d632-4f5e-b7e7-ef30745e5070")},  // pound per gallon (UK) per hour
         {UnitChoicesEnum.PoundPerGallonUSPerSecond, new Guid("eee6814a-d701-4cd8-b392-ebfedde20e11")},  // pound per gallon (US) per second
         {UnitChoicesEnum.PoundPerGallonUSPerMinute, new Guid("c047d53d-38f3-4dce-b590-1c9ab700a3ea")},  // pound per gallon (US) per minute
         {UnitChoicesEnum.PoundPerGallonUSPerHour, new Guid("822327d4-9f7c-4e91-9528-4eff5dfc9643")} // pound per gallon (US) per hour
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
  public partial class DimensionlessQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Dimensionless // dimensionless
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Dimensionless, new Guid("8744b0f7-2866-42d8-bf6c-b619ac87b945")} // dimensionless
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
  public partial class DynamicViscosityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalSecond,  // pascal second
         MillipascalSecond,  // millipascal second
         MicropascalSecond,  // micropascal second
         Poise,  // poise
         Centipoise,  // centipoise
         Millipoise,  // millipoise
         Micropoise,  // micropoise
         PoundSecondPerSquareFoot,  // pound second per square foot
         PoundSecondPer100SquareFoot,  // pound second per 100 square foot
         PoundSecondPerSquareInch,  // pound second per square inch
         DyneSecondPerSquareCentimetre // dyne second per square centimetre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalSecond, new Guid("5707caa4-e293-430d-9575-425305060fcc")},  // pascal second
         {UnitChoicesEnum.MillipascalSecond, new Guid("640f2693-dd92-472b-b2ec-0052fc7b7a11")},  // millipascal second
         {UnitChoicesEnum.MicropascalSecond, new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d")},  // micropascal second
         {UnitChoicesEnum.Poise, new Guid("79e600d1-05f1-46ef-b47a-951b04f6666e")},  // poise
         {UnitChoicesEnum.Centipoise, new Guid("a71ef873-6ea2-4922-a100-231177de0e85")},  // centipoise
         {UnitChoicesEnum.Millipoise, new Guid("f20c7109-bf60-413b-8f41-6f1d2f3bff45")},  // millipoise
         {UnitChoicesEnum.Micropoise, new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8")},  // micropoise
         {UnitChoicesEnum.PoundSecondPerSquareFoot, new Guid("1397525b-b5b6-4b3c-82e8-b562f01e9a42")},  // pound second per square foot
         {UnitChoicesEnum.PoundSecondPer100SquareFoot, new Guid("b48720b9-8eb5-4b5c-8da1-ca2312fdff01")},  // pound second per 100 square foot
         {UnitChoicesEnum.PoundSecondPerSquareInch, new Guid("70b7471d-6a62-4ce9-8def-ceb3d6d7495f")},  // pound second per square inch
         {UnitChoicesEnum.DyneSecondPerSquareCentimetre, new Guid("90ce61e5-46db-47f9-9c22-1c0f19068132")} // dyne second per square centimetre
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
  public partial class ElectricCapacitanceQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Farad,  // farad
         CoulombPerVolt,  // coulomb per volt
         Millifarad,  // millifarad
         Microfarad,  // microfarad
         Nanofarad,  // nanofarad
         Picofarad // picofarad
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Farad, new Guid("11dd208b-bcf2-4415-b7a9-4161791166c7")},  // farad
         {UnitChoicesEnum.CoulombPerVolt, new Guid("81ae5717-d834-4f25-800e-c42c3bcb48af")},  // coulomb per volt
         {UnitChoicesEnum.Millifarad, new Guid("12c8b1ad-d38a-4dbe-b418-7f3b31c23ff6")},  // millifarad
         {UnitChoicesEnum.Microfarad, new Guid("a5974c82-68ac-4166-81b0-123f3ae84701")},  // microfarad
         {UnitChoicesEnum.Nanofarad, new Guid("c1af9df8-69d5-41d3-9027-3c89aa151777")},  // nanofarad
         {UnitChoicesEnum.Picofarad, new Guid("1a9b9112-8a9f-4c80-a2ad-ebe5d9af5eef")} // picofarad
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
  public partial class ElectricCurrentQuantity : SymbolizedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Ampere,  // ampere
         CoulombPerSecond,  // coulomb per second
         SiemensVolt,  // siemens volt
         VoltPerOhm,  // volt per ohm
         WattPerVolt,  // watt per volt
         WeberPerHenry,  // weber per henry
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
         Statampere // statampere
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Ampere, new Guid("1cd2ef0e-baf8-43fb-9fac-64f84560d0a9")},  // ampere
         {UnitChoicesEnum.CoulombPerSecond, new Guid("0a9cc349-3bac-4f44-9a9b-3940ae595f03")},  // coulomb per second
         {UnitChoicesEnum.SiemensVolt, new Guid("52bc6bd9-f25d-470b-9068-b6e87f1f2ed0")},  // siemens volt
         {UnitChoicesEnum.VoltPerOhm, new Guid("100dd38e-19ad-465c-a995-0fb1174e506b")},  // volt per ohm
         {UnitChoicesEnum.WattPerVolt, new Guid("29464509-67a2-4062-b78a-8156e54cfa88")},  // watt per volt
         {UnitChoicesEnum.WeberPerHenry, new Guid("bf3285f5-34be-4592-822d-f6ffc3ce4858")},  // weber per henry
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
  public partial class ElectricTensionQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Volt,  // volt
         Millivolt,  // millivolt
         Centivolt,  // centivolt
         Microvolt,  // microvolt
         Nanovolt,  // nanovolt
         Picovolt,  // picovolt
         Kilovolt,  // kilovolt
         Megavolt,  // megavolt
         Gigavolt // gigavolt
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Volt, new Guid("618fafff-fc9c-4d22-a64d-b7579931aa93")},  // volt
         {UnitChoicesEnum.Millivolt, new Guid("f186f5d4-2b0b-4cfe-b24c-0c02d3155cf8")},  // millivolt
         {UnitChoicesEnum.Centivolt, new Guid("ee01194e-dee3-4b50-8312-5fde3c8f774e")},  // centivolt
         {UnitChoicesEnum.Microvolt, new Guid("ede7e093-3e7d-429a-8c22-3b35ab5b20f2")},  // microvolt
         {UnitChoicesEnum.Nanovolt, new Guid("86dfcbe1-af8c-4081-b6ed-481eb44ab890")},  // nanovolt
         {UnitChoicesEnum.Picovolt, new Guid("19fb81d7-4991-4902-a1fd-55420789ac59")},  // picovolt
         {UnitChoicesEnum.Kilovolt, new Guid("6ffc60bc-ec9f-44d4-961b-79d9e593bf64")},  // kilovolt
         {UnitChoicesEnum.Megavolt, new Guid("3342ddbc-b1b2-46f8-addc-216ce94a616a")},  // megavolt
         {UnitChoicesEnum.Gigavolt, new Guid("640f2693-dd92-472b-b2ec-0052fc7b7a11")} // gigavolt
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
  public partial class ElongationGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerMetre,  // metre per metre
         DecimetrePerMetre,  // decimetre per metre
         CentimetrePerMetre,  // centimetre per metre
         MillimetrePerMetre,  // millimetre per metre
         MicrometrePerMetre,  // micrometre per metre
         MetrePerKilometre,  // metre per kilometre
         DecimetrePerKilometre,  // decimetre per kilometre
         CentimetrePerKilometre,  // centimetre per kilometre
         MillimetrePerKilometre,  // millimetre per kilometre
         MicrometrePerKilometre,  // micrometre per kilometre
         InchPerFoot,  // inch per foot
         InchPerYard,  // inch per yard
         InchPerMile,  // inch per mile
         FootPerFoot,  // foot per foot
         FootPerYard,  // foot per yard
         FootPerMile,  // foot per mile
         YardPerFoot,  // yard per foot
         YardPerYard,  // yard per yard
         YardPerMile // yard per mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerMetre, new Guid("cc12967b-4c7d-4c70-95cf-d2f23bd6f76b")},  // metre per metre
         {UnitChoicesEnum.DecimetrePerMetre, new Guid("337d67e2-b28c-4ab8-9817-3f9951fdb67b")},  // decimetre per metre
         {UnitChoicesEnum.CentimetrePerMetre, new Guid("4a7ce144-b35f-401f-bfbc-276b7c4ec4a9")},  // centimetre per metre
         {UnitChoicesEnum.MillimetrePerMetre, new Guid("4e241b59-388a-428f-82e7-b9971f9e1df5")},  // millimetre per metre
         {UnitChoicesEnum.MicrometrePerMetre, new Guid("bbd912b2-06e2-46fe-82da-af87bab150dc")},  // micrometre per metre
         {UnitChoicesEnum.MetrePerKilometre, new Guid("5b583a4c-7838-48e7-8201-420f43eef9e1")},  // metre per kilometre
         {UnitChoicesEnum.DecimetrePerKilometre, new Guid("7dc93254-9a25-4215-b2bc-9f2d8dc14d6e")},  // decimetre per kilometre
         {UnitChoicesEnum.CentimetrePerKilometre, new Guid("f539c676-e969-4235-9524-42e860e84966")},  // centimetre per kilometre
         {UnitChoicesEnum.MillimetrePerKilometre, new Guid("59f50e71-7796-4559-9e55-7fc420d9c20c")},  // millimetre per kilometre
         {UnitChoicesEnum.MicrometrePerKilometre, new Guid("73d8d799-d9f5-40f9-9216-4bc0bbf1c044")},  // micrometre per kilometre
         {UnitChoicesEnum.InchPerFoot, new Guid("3df1af23-afd0-41ed-9442-a3af6ae944d2")},  // inch per foot
         {UnitChoicesEnum.InchPerYard, new Guid("ec1fbeee-cbf4-41f0-94d8-573e241c22b2")},  // inch per yard
         {UnitChoicesEnum.InchPerMile, new Guid("998afd92-de3a-4f10-90b6-a252b8e59181")},  // inch per mile
         {UnitChoicesEnum.FootPerFoot, new Guid("a53ffdb6-a2db-4984-85aa-53763ba3aabb")},  // foot per foot
         {UnitChoicesEnum.FootPerYard, new Guid("ba9062f9-68be-4b9c-ba61-57c8543ed6f9")},  // foot per yard
         {UnitChoicesEnum.FootPerMile, new Guid("89b73d98-2818-43c5-8d31-8aa1bb78d3bc")},  // foot per mile
         {UnitChoicesEnum.YardPerFoot, new Guid("a6c2cf06-e21a-4387-90db-89d7d46b1b28")},  // yard per foot
         {UnitChoicesEnum.YardPerYard, new Guid("56f75af0-7213-43d9-b23f-bc74da6382e9")},  // yard per yard
         {UnitChoicesEnum.YardPerMile, new Guid("3283a57e-ec6d-4487-ab32-cdc0c5de2020")} // yard per mile
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
  public partial class EnergyDensityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         JoulePerCubicMetre,  // joule per cubic metre
         JoulePerLitre,  // joule per litre
         KilojoulePerCubicMetre,  // kilojoule per cubic metre
         KilojoulePerLitre,  // kilojoule per litre
         MegajoulePerCubicMetre,  // megajoule per cubic metre
         MegajoulePerLitre,  // megajoule per litre
         GigajoulePerCubicMetre,  // gigajoule per cubic metre
         GigajoulePerLitre,  // gigajoule per litre
         CaloriePerCubicMetre,  // calorie per cubic metre
         CaloriePerLitre,  // calorie per litre
         KilocaloriePerCubicMetre,  // kilocalorie per cubic metre
         KilocaloriePerLitre,  // kilocalorie per litre
         JoulePerCubicFoot,  // joule per cubic foot
         KilojoulePerCubicFoot,  // kilojoule per cubic foot
         MegajoulePerCubicFoot,  // megajoule per cubic foot
         GigajoulePerCubicFoot,  // gigajoule per cubic foot
         CaloriePerCubicFoot,  // calorie per cubic foot
         KilocaloriePerCubicFoot,  // kilocalorie per cubic foot
         JoulePerCubicInch,  // joule per cubic inch
         KilojoulePerCubicInch,  // kilojoule per cubic inch
         MegajoulePerCubicInch,  // megajoule per cubic inch
         GigajoulePerCubicInch,  // gigajoule per cubic inch
         CaloriePerCubicInch,  // calorie per cubic inch
         KilocaloriePerCubicInch,  // kilocalorie per cubic inch
         JoulePerGallonUK,  // joule per gallon (UK)
         KilojoulePerGallonUK,  // kilojoule per gallon (UK)
         MegajoulePerGallonUK,  // megajoule per gallon (UK)
         GigajoulePerGallonUK,  // gigajoule per gallon (UK)
         CaloriePerGallonUK,  // calorie per gallon (UK)
         KilocaloriePerGallonUK,  // kilocalorie per gallon (UK)
         JoulePerGallonUS,  // joule per gallon (US)
         KilojoulePerGallonUS,  // kilojoule per gallon (US)
         MegajoulePerGallonUS,  // megajoule per gallon (US)
         GigajoulePerGallonUS,  // gigajoule per gallon (US)
         CaloriePerGallonUS,  // calorie per gallon (US)
         KilocaloriePerGallonUS,  // kilocalorie per gallon (US)
         BritishThermalUnitPerCubicMetre,  // british thermal unit per cubic metre
         BritishThermalUnitPerLitre,  // british thermal unit per litre
         BritishThermalUnitPerCubicFoot,  // british thermal unit per cubic foot
         BritishThermalUnitPerCubicInch,  // british thermal unit per cubic inch
         BritishThermalUnitPerGallonUK,  // british thermal unit per gallon (UK)
         BritishThermalUnitPerGallonUS,  // british thermal unit per gallon (US)
         KiloBritishThermalUnitPerCubicMetre,  // kilo british thermal unit per cubic metre
         KiloBritishThermalUnitPerLitre,  // kilo british thermal unit per litre
         KiloBritishThermalUnitPerCubicFoot,  // kilo british thermal unit per cubic foot
         KiloBritishThermalUnitPerCubicInch,  // kilo british thermal unit per cubic inch
         KiloBritishThermalUnitPerGallonUK,  // kilo british thermal unit per gallon (UK)
         KiloBritishThermalUnitPerGallonUS // kilo british thermal unit per gallon (US)
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.JoulePerCubicMetre, new Guid("bac0aae1-8b3b-403d-b1ea-874a74da849a")},  // joule per cubic metre
         {UnitChoicesEnum.JoulePerLitre, new Guid("c3ae0b19-e3b1-4433-8075-ffb1444f447d")},  // joule per litre
         {UnitChoicesEnum.KilojoulePerCubicMetre, new Guid("ebc0ab24-af1b-4315-a41e-c66ef83e02f0")},  // kilojoule per cubic metre
         {UnitChoicesEnum.KilojoulePerLitre, new Guid("5cfaa1c0-7155-4eb6-b1ab-48db0dab2043")},  // kilojoule per litre
         {UnitChoicesEnum.MegajoulePerCubicMetre, new Guid("a5d1096b-9900-46ff-8a81-17313266dfdd")},  // megajoule per cubic metre
         {UnitChoicesEnum.MegajoulePerLitre, new Guid("f57f2f8d-3998-4ff3-ab50-bf1e8fdf99f4")},  // megajoule per litre
         {UnitChoicesEnum.GigajoulePerCubicMetre, new Guid("7728780b-66c7-4832-b905-25cb4e0b3edf")},  // gigajoule per cubic metre
         {UnitChoicesEnum.GigajoulePerLitre, new Guid("37e4f478-4e24-4735-9c31-30047d48828b")},  // gigajoule per litre
         {UnitChoicesEnum.CaloriePerCubicMetre, new Guid("ea4ac69b-351f-43d6-b6f0-847e6a73a069")},  // calorie per cubic metre
         {UnitChoicesEnum.CaloriePerLitre, new Guid("66d4c95b-5281-45d2-ba67-ee513f64f8dc")},  // calorie per litre
         {UnitChoicesEnum.KilocaloriePerCubicMetre, new Guid("b8d2b560-8541-4ad0-bb63-e2f755e92cb3")},  // kilocalorie per cubic metre
         {UnitChoicesEnum.KilocaloriePerLitre, new Guid("5bb757ee-b4b4-4340-b05b-d15988369ea0")},  // kilocalorie per litre
         {UnitChoicesEnum.JoulePerCubicFoot, new Guid("5c91efe6-c268-4d31-bff8-768344290db6")},  // joule per cubic foot
         {UnitChoicesEnum.KilojoulePerCubicFoot, new Guid("2b21249b-3eb3-4f86-9d05-407e42d8d1c5")},  // kilojoule per cubic foot
         {UnitChoicesEnum.MegajoulePerCubicFoot, new Guid("6bf78807-e679-4930-9e73-e52968821d9b")},  // megajoule per cubic foot
         {UnitChoicesEnum.GigajoulePerCubicFoot, new Guid("97e4a46b-11f6-4cb5-a24f-f2b004ad06cd")},  // gigajoule per cubic foot
         {UnitChoicesEnum.CaloriePerCubicFoot, new Guid("3efcbcd4-9f17-476d-9a47-43600ab93236")},  // calorie per cubic foot
         {UnitChoicesEnum.KilocaloriePerCubicFoot, new Guid("ff0ebc90-50fa-4c50-8583-0879a5b2380c")},  // kilocalorie per cubic foot
         {UnitChoicesEnum.JoulePerCubicInch, new Guid("daba8c83-b6f5-40bb-8c9d-e476e5d1bce2")},  // joule per cubic inch
         {UnitChoicesEnum.KilojoulePerCubicInch, new Guid("5beeb10a-314a-4c15-858d-0e900d4803e1")},  // kilojoule per cubic inch
         {UnitChoicesEnum.MegajoulePerCubicInch, new Guid("309da835-8bcb-4bdf-bbd7-aad194ade23a")},  // megajoule per cubic inch
         {UnitChoicesEnum.GigajoulePerCubicInch, new Guid("698b690d-b747-48da-8433-5ac0b25598d3")},  // gigajoule per cubic inch
         {UnitChoicesEnum.CaloriePerCubicInch, new Guid("6ae5cf98-0fcc-4426-9c72-481d1b1992ce")},  // calorie per cubic inch
         {UnitChoicesEnum.KilocaloriePerCubicInch, new Guid("66375de4-842e-4813-b79e-3e62cf7a97cc")},  // kilocalorie per cubic inch
         {UnitChoicesEnum.JoulePerGallonUK, new Guid("1c3b4a46-1cfa-44e4-b10e-4ed0f74e2994")},  // joule per gallon (UK)
         {UnitChoicesEnum.KilojoulePerGallonUK, new Guid("a5086581-3c86-43f5-acd2-845bc35ebc33")},  // kilojoule per gallon (UK)
         {UnitChoicesEnum.MegajoulePerGallonUK, new Guid("45c985ee-25be-4bd6-88de-38c98f042dbe")},  // megajoule per gallon (UK)
         {UnitChoicesEnum.GigajoulePerGallonUK, new Guid("e09aff93-785e-4bae-b9c5-17961bfd6642")},  // gigajoule per gallon (UK)
         {UnitChoicesEnum.CaloriePerGallonUK, new Guid("c36ef596-5a06-4ace-a119-baae9f761e29")},  // calorie per gallon (UK)
         {UnitChoicesEnum.KilocaloriePerGallonUK, new Guid("92c90ba8-7b15-4f6c-980f-f1ca44fb556a")},  // kilocalorie per gallon (UK)
         {UnitChoicesEnum.JoulePerGallonUS, new Guid("357a5df6-6df1-43fa-8be8-652e8d97db7c")},  // joule per gallon (US)
         {UnitChoicesEnum.KilojoulePerGallonUS, new Guid("5d74db73-4d3f-49b8-9a6b-c8eef3b9e287")},  // kilojoule per gallon (US)
         {UnitChoicesEnum.MegajoulePerGallonUS, new Guid("38d388bf-bbb8-4c84-9ec8-e78c6d81ae07")},  // megajoule per gallon (US)
         {UnitChoicesEnum.GigajoulePerGallonUS, new Guid("b3360ab2-cd97-4e2f-b29d-1470c0b34c1f")},  // gigajoule per gallon (US)
         {UnitChoicesEnum.CaloriePerGallonUS, new Guid("30d202d9-0a80-4d71-b4c8-e434d714ee9a")},  // calorie per gallon (US)
         {UnitChoicesEnum.KilocaloriePerGallonUS, new Guid("05fa77bf-3dcb-4df0-bf4d-7394e9f8854d")},  // kilocalorie per gallon (US)
         {UnitChoicesEnum.BritishThermalUnitPerCubicMetre, new Guid("550355a8-bfbe-4045-ab32-28325513db51")},  // british thermal unit per cubic metre
         {UnitChoicesEnum.BritishThermalUnitPerLitre, new Guid("2458887d-ee5f-4502-9446-cb6a7ae55c9d")},  // british thermal unit per litre
         {UnitChoicesEnum.BritishThermalUnitPerCubicFoot, new Guid("ce9d74ec-ecfc-454a-a00f-818e59c55895")},  // british thermal unit per cubic foot
         {UnitChoicesEnum.BritishThermalUnitPerCubicInch, new Guid("dd01b982-428b-4798-9cf6-091317d8fe93")},  // british thermal unit per cubic inch
         {UnitChoicesEnum.BritishThermalUnitPerGallonUK, new Guid("49e1a251-6a46-4715-a399-8953b25b7ce8")},  // british thermal unit per gallon (UK)
         {UnitChoicesEnum.BritishThermalUnitPerGallonUS, new Guid("f03e145b-26fc-4597-8cd6-1f468e574644")},  // british thermal unit per gallon (US)
         {UnitChoicesEnum.KiloBritishThermalUnitPerCubicMetre, new Guid("982cde20-c1a6-4dcf-8e37-c3784a427bc0")},  // kilo british thermal unit per cubic metre
         {UnitChoicesEnum.KiloBritishThermalUnitPerLitre, new Guid("2a64cc42-f2ab-43df-858f-04659d9a1306")},  // kilo british thermal unit per litre
         {UnitChoicesEnum.KiloBritishThermalUnitPerCubicFoot, new Guid("fdf14475-d109-4450-b5c0-9462c7ef8ec8")},  // kilo british thermal unit per cubic foot
         {UnitChoicesEnum.KiloBritishThermalUnitPerCubicInch, new Guid("8d6b0b9d-8f02-4a6a-9df5-575ebebaaba3")},  // kilo british thermal unit per cubic inch
         {UnitChoicesEnum.KiloBritishThermalUnitPerGallonUK, new Guid("24f9799f-4918-4f1c-9155-6b87c99703b0")},  // kilo british thermal unit per gallon (UK)
         {UnitChoicesEnum.KiloBritishThermalUnitPerGallonUS, new Guid("d8751a32-b0bd-425a-a9df-0ef7f5f0cb1f")} // kilo british thermal unit per gallon (US)
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
  public partial class ForceGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonPerMetre,  // newton per metre
         NewtonPer30Metre,  // newton per 30 metre
         NewtonPer10Metre,  // newton per 10 metre
         NewtonPerDecimetre,  // newton per decimetre
         NewtonPerCentimetre,  // newton per centimetre
         NewtonPerMillimetre,  // newton per millimetre
         DecanewtonPerMetre,  // decanewton per metre
         DecanewtonPer30Metre,  // decanewton per 30 metre
         DecanewtonPer10Metre,  // decanewton per 10 metre
         DecanewtonPerDecimetre,  // decanewton per decimetre
         DecanewtonPerCentimetre,  // decanewton per centimetre
         DecanewtonPerMillimetre,  // decanewton per millimetre
         KilonewtonPerMetre,  // kilonewton per metre
         KilonewtonPer30Metre,  // kilonewton per 30 metre
         KilonewtonPer10Metre,  // kilonewton per 10 metre
         KilonewtonPerDecimetre,  // kilonewton per decimetre
         KilonewtonPerCentimetre,  // kilonewton per centimetre
         KilonewtonPerMillimetre,  // kilonewton per millimetre
         PoundPerFoot,  // pound per foot
         PoundPerInch,  // pound per inch
         KilopoundPerFoot,  // kilopound per foot
         KilopoundPerInch,  // kilopound per inch
         PoundPer30Foot,  // pound per 30 foot
         PoundPer100Foot,  // pound per 100 foot
         KilopoundPer30Foot,  // kilopound per 30 foot
         KilopoundPer100Foot // kilopound per 100 foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonPerMetre, new Guid("e503a1d3-1815-4321-8087-6e3d6dc641c8")},  // newton per metre
         {UnitChoicesEnum.NewtonPer30Metre, new Guid("be16e271-5ce7-445b-a8db-9014a6acc22b")},  // newton per 30 metre
         {UnitChoicesEnum.NewtonPer10Metre, new Guid("46defe0c-4a00-45d1-83bb-f898e00a78c5")},  // newton per 10 metre
         {UnitChoicesEnum.NewtonPerDecimetre, new Guid("dcd21076-ecb6-481e-8b8b-1cd5ccc68915")},  // newton per decimetre
         {UnitChoicesEnum.NewtonPerCentimetre, new Guid("739cb2cd-2c9f-4efc-ad17-306b8f09de57")},  // newton per centimetre
         {UnitChoicesEnum.NewtonPerMillimetre, new Guid("9375f700-72fb-4212-a51d-0f4500e7b13c")},  // newton per millimetre
         {UnitChoicesEnum.DecanewtonPerMetre, new Guid("2566918f-f1b1-4ffb-906b-adb3680812e1")},  // decanewton per metre
         {UnitChoicesEnum.DecanewtonPer30Metre, new Guid("20de7177-2099-4f86-89da-fdfa68bf67ed")},  // decanewton per 30 metre
         {UnitChoicesEnum.DecanewtonPer10Metre, new Guid("4f30206a-b381-4a28-9e2d-fafc026e71d5")},  // decanewton per 10 metre
         {UnitChoicesEnum.DecanewtonPerDecimetre, new Guid("cf20b9bb-aab1-4f1a-832c-1cfbe8ffc825")},  // decanewton per decimetre
         {UnitChoicesEnum.DecanewtonPerCentimetre, new Guid("47704d55-35cc-4bfc-9f93-7cf7f29c81ac")},  // decanewton per centimetre
         {UnitChoicesEnum.DecanewtonPerMillimetre, new Guid("1f418c90-f2e6-4bc8-8c06-f281e56ef6cc")},  // decanewton per millimetre
         {UnitChoicesEnum.KilonewtonPerMetre, new Guid("9ec7912e-9506-43ce-9089-80000d7ddd3f")},  // kilonewton per metre
         {UnitChoicesEnum.KilonewtonPer30Metre, new Guid("b08fae49-fdc3-409e-8b0f-3349ab189dc9")},  // kilonewton per 30 metre
         {UnitChoicesEnum.KilonewtonPer10Metre, new Guid("f57cb3e9-4da5-4960-aff6-a27167276e4a")},  // kilonewton per 10 metre
         {UnitChoicesEnum.KilonewtonPerDecimetre, new Guid("f3033c1b-1be8-4110-832a-4b60c31043e6")},  // kilonewton per decimetre
         {UnitChoicesEnum.KilonewtonPerCentimetre, new Guid("4db740c5-df92-4f65-b0da-2119ad80cbfc")},  // kilonewton per centimetre
         {UnitChoicesEnum.KilonewtonPerMillimetre, new Guid("14578d1b-6d43-441a-8f1b-aa77ab10a9bf")},  // kilonewton per millimetre
         {UnitChoicesEnum.PoundPerFoot, new Guid("516e4b02-2f1a-49a7-8cd9-3fa4e28c8fce")},  // pound per foot
         {UnitChoicesEnum.PoundPerInch, new Guid("8a5772d2-1253-4269-958a-af9f779aecc6")},  // pound per inch
         {UnitChoicesEnum.KilopoundPerFoot, new Guid("bf63e80f-97df-48d1-afbf-c83415654e44")},  // kilopound per foot
         {UnitChoicesEnum.KilopoundPerInch, new Guid("fa6a4a38-b070-48d1-a747-be22ab0e57b6")},  // kilopound per inch
         {UnitChoicesEnum.PoundPer30Foot, new Guid("0d0926be-19fa-4687-88d1-35f1acc58717")},  // pound per 30 foot
         {UnitChoicesEnum.PoundPer100Foot, new Guid("dcaa5f41-da2f-49d2-be41-80fb6f0a06ec")},  // pound per 100 foot
         {UnitChoicesEnum.KilopoundPer30Foot, new Guid("27a355cf-36ae-458d-acbd-2a5ad931bbab")},  // kilopound per 30 foot
         {UnitChoicesEnum.KilopoundPer100Foot, new Guid("0d5c841e-b259-4fdf-93d7-e39cca391adb")} // kilopound per 100 foot
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
  public partial class ForceQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Newton,  // newton
         Decanewton,  // decanewton
         Kilonewton,  // kilonewton
         Kilodecanewton,  // kilodecanewton
         KilogramForce,  // kilogram force
         PoundForce,  // pound force
         KilopoundForce // kilopound force
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // newton
         {UnitChoicesEnum.Decanewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // decanewton
         {UnitChoicesEnum.Kilonewton, new Guid("e30d6f94-7887-4746-8d4f-eb720239b702")},  // kilonewton
         {UnitChoicesEnum.Kilodecanewton, new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266")},  // kilodecanewton
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // kilogram force
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")},  // pound force
         {UnitChoicesEnum.KilopoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")} // kilopound force
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
  public partial class FrequencyQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // hertz
         ReciprocalSecond,  // reciprocal second
         Kilohertz,  // kilohertz
         Megahertz,  // megahertz
         Gigahertz,  // gigahertz
         Terahertz,  // terahertz
         Rpm,  // rpm
         Spm,  // spm
         RotationPerSecond,  // rotation per second
         StrokePerSecond,  // stroke per second
         StrokePerHour,  // stroke per hour
         RotationPerHour,  // rotation per hour
         ShockPerSecond,  // shock per second
         ShockPerMinute,  // shock per minute
         ShockPerHour // shock per hour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("7c572c06-0699-4187-9d0c-397f479fe93d")},  // hertz
         {UnitChoicesEnum.ReciprocalSecond, new Guid("39240f8f-8c82-4026-9db7-f72ec60cb4c9")},  // reciprocal second
         {UnitChoicesEnum.Kilohertz, new Guid("acf483c1-5d7a-4914-afa2-de7abed9be3e")},  // kilohertz
         {UnitChoicesEnum.Megahertz, new Guid("6dea9f29-d4f4-49a7-86fe-0205d4bab45e")},  // megahertz
         {UnitChoicesEnum.Gigahertz, new Guid("655ee4f9-1782-4ec0-894a-afff9b75cac7")},  // gigahertz
         {UnitChoicesEnum.Terahertz, new Guid("9ca52ae4-2fc5-4e60-b774-79c73442de13")},  // terahertz
         {UnitChoicesEnum.Rpm, new Guid("30880b5f-803d-412e-9736-62dca3ba5bbd")},  // rpm
         {UnitChoicesEnum.Spm, new Guid("426b000b-235f-41d5-8806-b2e47fbfb53b")},  // spm
         {UnitChoicesEnum.RotationPerSecond, new Guid("6e0ff63e-ef67-440d-a0f7-a17ff73cfff2")},  // rotation per second
         {UnitChoicesEnum.StrokePerSecond, new Guid("fe114eaf-117a-480e-9dbc-2db244b6d210")},  // stroke per second
         {UnitChoicesEnum.StrokePerHour, new Guid("b0f63a0c-9a53-4bdc-9166-03eb4254d3d8")},  // stroke per hour
         {UnitChoicesEnum.RotationPerHour, new Guid("cdc5dd34-dc2d-4bd8-85ac-13f6d71ea188")},  // rotation per hour
         {UnitChoicesEnum.ShockPerSecond, new Guid("b5318133-64e9-43c7-b7bf-3c86140fe7aa")},  // shock per second
         {UnitChoicesEnum.ShockPerMinute, new Guid("6ccbee46-cb8a-4777-b1d2-e88eedd24f73")},  // shock per minute
         {UnitChoicesEnum.ShockPerHour, new Guid("0c0d4ecb-ee11-4b57-9bc7-70860637232e")} // shock per hour
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
  public partial class FrequencyRateOfChangeQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         HertzPerSecond,  // hertz per second
         KiloHertzPerSecond,  // kilo hertz per second
         MegaHertzPerSecond,  // mega hertz per second
         GigaHertzPerSecond,  // giga hertz per second
         HertzPerMinute,  // hertz per minute
         KiloHertzPerMinute,  // kilo hertz per minute
         MegaHertzPerMinute,  // mega hertz per minute
         GigaHertzPerMinute,  // giga hertz per minute
         HertzPerHour,  // hertz per hour
         KiloHertzPerHour,  // kilo hertz per hour
         MegaHertzPerHour,  // mega hertz per hour
         GigaHertzPerHour,  // giga hertz per hour
         HertzPerDay,  // hertz per day
         KiloHertzPerDay,  // kilo hertz per day
         MegaHertzPerDay,  // mega hertz per day
         GigaHertzPerDay,  // giga hertz per day
         HertzPerYear,  // hertz per year
         KiloHertzPerYear,  // kilo hertz per year
         MegaHertzPerYear,  // mega hertz per year
         GigaHertzPerYear,  // giga hertz per year
         RpmPerSecond,  // rpm per second
         SpmPerSecond // spm per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.HertzPerSecond, new Guid("4d7e4b49-df76-4259-a96c-8c1250d5ecdd")},  // hertz per second
         {UnitChoicesEnum.KiloHertzPerSecond, new Guid("e197e7ca-93f7-4348-9508-74e61ce97f94")},  // kilo hertz per second
         {UnitChoicesEnum.MegaHertzPerSecond, new Guid("8c9671f4-54b6-40a0-94c1-5cfb25378f88")},  // mega hertz per second
         {UnitChoicesEnum.GigaHertzPerSecond, new Guid("46ad2062-982c-461f-95d8-ddd888e5d4f8")},  // giga hertz per second
         {UnitChoicesEnum.HertzPerMinute, new Guid("af3fcbbf-4fc8-4b5d-b555-33340d3c2f0f")},  // hertz per minute
         {UnitChoicesEnum.KiloHertzPerMinute, new Guid("0fabfb82-03fb-4855-aaea-578e36c9c7cf")},  // kilo hertz per minute
         {UnitChoicesEnum.MegaHertzPerMinute, new Guid("97c4e6e3-a8b3-4aa6-a742-1900a239e282")},  // mega hertz per minute
         {UnitChoicesEnum.GigaHertzPerMinute, new Guid("8d8d140d-00cd-4e80-aaa5-8d2d5ddcbc73")},  // giga hertz per minute
         {UnitChoicesEnum.HertzPerHour, new Guid("424100d5-ab81-4061-9429-74a9e3638453")},  // hertz per hour
         {UnitChoicesEnum.KiloHertzPerHour, new Guid("0963dc43-168a-483c-be3f-3c9054b0c692")},  // kilo hertz per hour
         {UnitChoicesEnum.MegaHertzPerHour, new Guid("a1b30880-ba44-4675-b808-6d93ba8aa8d2")},  // mega hertz per hour
         {UnitChoicesEnum.GigaHertzPerHour, new Guid("cd42ca67-9d8b-411c-bcce-e9e5ce6d1259")},  // giga hertz per hour
         {UnitChoicesEnum.HertzPerDay, new Guid("fe28723d-23e5-45f3-b286-50705746d643")},  // hertz per day
         {UnitChoicesEnum.KiloHertzPerDay, new Guid("0dc10fed-83a5-4570-a997-f2422d71d7fd")},  // kilo hertz per day
         {UnitChoicesEnum.MegaHertzPerDay, new Guid("c5743df5-a0be-41d2-99a1-b1f760940007")},  // mega hertz per day
         {UnitChoicesEnum.GigaHertzPerDay, new Guid("56e88229-8197-4ca2-aa69-e4100234d344")},  // giga hertz per day
         {UnitChoicesEnum.HertzPerYear, new Guid("1195a495-ea6e-4b5a-92b6-6ef0d2ca23d5")},  // hertz per year
         {UnitChoicesEnum.KiloHertzPerYear, new Guid("2e2a0d0f-5658-4ba2-8799-53bb06f197e7")},  // kilo hertz per year
         {UnitChoicesEnum.MegaHertzPerYear, new Guid("665c1c2a-57f6-4696-8b7b-524f8ad6084f")},  // mega hertz per year
         {UnitChoicesEnum.GigaHertzPerYear, new Guid("2c756b88-bbed-4650-8307-86bc7513caee")},  // giga hertz per year
         {UnitChoicesEnum.RpmPerSecond, new Guid("762b5d58-a1ba-40cb-8776-2004613d15fb")},  // rpm per second
         {UnitChoicesEnum.SpmPerSecond, new Guid("abcb24f7-c949-41dd-bf7d-acc23dc7e5e3")} // spm per second
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
  public partial class HeatTransferCoefficientQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         WattPerSquareMetrePerKelvin,  // watt per square metre per kelvin
         BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit // british thermal unit per hour per square foot per degree fahrenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.WattPerSquareMetrePerKelvin, new Guid("e1737353-c10b-46cd-aa4e-9c90afb2f01e")},  // watt per square metre per kelvin
         {UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit, new Guid("6963db25-2bd9-4017-9c83-cc578a11abbf")} // british thermal unit per hour per square foot per degree fahrenheit
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
  public partial class ImageScaleQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         DotPerMetre,  // dot per metre
         DotPerInch,  // dot per inch
         DotPerMillimetre,  // dot per millimetre
         DotPerMicrometre // dot per micrometre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.DotPerMetre, new Guid("acc723b8-083c-49f3-a208-184d2da3347d")},  // dot per metre
         {UnitChoicesEnum.DotPerInch, new Guid("e042b571-b7d0-477d-abf6-8b8998e5ba6c")},  // dot per inch
         {UnitChoicesEnum.DotPerMillimetre, new Guid("6d4d5f26-8812-4002-a2bf-27ec7871c1f4")},  // dot per millimetre
         {UnitChoicesEnum.DotPerMicrometre, new Guid("76e21d1d-54f5-4bbb-81c6-1b92b8b30bfe")} // dot per micrometre
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
  public partial class InterfacialTensionQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonPerMetre,  // newton per metre
         MillinewtonPerMetre,  // millinewton per metre
         DynePerCentimetre,  // dyne per centimetre
         PoundPerSecondSquared // pound per second squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonPerMetre, new Guid("7ee9eca6-2704-442a-bd50-c8a0826da932")},  // newton per metre
         {UnitChoicesEnum.MillinewtonPerMetre, new Guid("7b1b363c-cbb0-4499-9d7c-762adc43e690")},  // millinewton per metre
         {UnitChoicesEnum.DynePerCentimetre, new Guid("a3c12fb9-6936-44bf-ad66-f4139163d11b")},  // dyne per centimetre
         {UnitChoicesEnum.PoundPerSecondSquared, new Guid("03db472b-b8e8-4ad0-b2b1-b8970686210c")} // pound per second squared
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
  public partial class LengthQuantity : SymbolizedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Metre,  // metre
         Decimetre,  // decimetre
         Centimetre,  // centimetre
         Millimetre,  // millimetre
         Micrometre,  // micrometre
         Nanometre,  // nanometre
         Ångstrøm,  // ångstrøm
         Picometre,  // picometre
         Decametre,  // decametre
         Hectometre,  // hectometre
         Kilometre,  // kilometre
         AstronomicalUnit,  // astronomical unit
         LightYear,  // light year
         Parsec,  // parsec
         Foot,  // foot
         USSurveyFoot,  // US survey foot
         Inch,  // inch
         Yard,  // yard
         Fathom,  // fathom
         Surveyor_sChain,  // surveyor's chain
         Mile,  // mile
         InternationalNauticalMile,  // international nautical mile
         UKNauticalMile,  // UK nautical mile
         ScandinavianMile,  // scandinavian mile
         InchPer32,  // inch per 32
         Mil,  // mil
         Thou,  // thou
         Hand,  // hand
         Furlong // furlong
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Decimetre, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimetre
         {UnitChoicesEnum.Centimetre, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimetre
         {UnitChoicesEnum.Millimetre, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimetre
         {UnitChoicesEnum.Micrometre, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometre
         {UnitChoicesEnum.Nanometre, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometre
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.Picometre, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometre
         {UnitChoicesEnum.Decametre, new Guid("0ff9e118-e7d5-4ace-b140-eb3383812b21")},  // decametre
         {UnitChoicesEnum.Hectometre, new Guid("cb5c81a3-b9da-42b5-a2ea-0509df445d01")},  // hectometre
         {UnitChoicesEnum.Kilometre, new Guid("93aee1b8-653d-4841-b948-10460cb84334")},  // kilometre
         {UnitChoicesEnum.AstronomicalUnit, new Guid("0471d74c-cc44-45bd-be0a-aaad6c05f0d0")},  // astronomical unit
         {UnitChoicesEnum.LightYear, new Guid("fc43d439-576f-430c-855e-60b28f70856e")},  // light year
         {UnitChoicesEnum.Parsec, new Guid("0565c7e8-11cb-48de-8d7a-d58c89955d0f")},  // parsec
         {UnitChoicesEnum.Foot, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // foot
         {UnitChoicesEnum.USSurveyFoot, new Guid("eaf5909f-c68e-4346-9517-1dafad48b161")},  // US survey foot
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Yard, new Guid("7b9156e4-7cce-41cf-a251-95412f4d91a5")},  // yard
         {UnitChoicesEnum.Fathom, new Guid("6be602af-ea19-41cc-af7f-8263564c3c3b")},  // fathom
         {UnitChoicesEnum.Surveyor_sChain, new Guid("f101708b-ab63-4f21-ac87-4b5b3615eb30")},  // surveyor's chain
         {UnitChoicesEnum.Mile, new Guid("95736fd3-878b-4d93-9a78-ee6f20619628")},  // mile
         {UnitChoicesEnum.InternationalNauticalMile, new Guid("4c297035-e0cf-4bfe-aa63-d835170e8e25")},  // international nautical mile
         {UnitChoicesEnum.UKNauticalMile, new Guid("3b7a50d6-dc58-4cd7-9a5b-96dba59eceaa")},  // UK nautical mile
         {UnitChoicesEnum.ScandinavianMile, new Guid("22e6763c-4105-4a4c-9dfe-044256a107d1")},  // scandinavian mile
         {UnitChoicesEnum.InchPer32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")},  // inch per 32
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
  public partial class LuminousIntensityQuantity : SymbolizedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Candela,  // candela
         LumenPerSteradian,  // lumen per steradian
         Millicandela,  // millicandela
         Kilocandela,  // kilocandela
         Hefnerkerze,  // hefnerkerze
         InternationalCandle,  // international candle
         DecimalCandle,  // decimal candle
         BerlinerLichteinheit,  // berliner lichteinheit
         DVWGCandle,  // DVWG candle
         Violle,  // violle
         Carcel // carcel
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Candela, new Guid("28411995-11f2-4967-92ed-5077237f17e1")},  // candela
         {UnitChoicesEnum.LumenPerSteradian, new Guid("5683bf23-cd97-4141-9bf4-62a43750ceda")},  // lumen per steradian
         {UnitChoicesEnum.Millicandela, new Guid("b722e2e1-bcc4-4d6c-ad47-dfd24bb66543")},  // millicandela
         {UnitChoicesEnum.Kilocandela, new Guid("f1159794-14ab-49bb-80de-0164c8172c1f")},  // kilocandela
         {UnitChoicesEnum.Hefnerkerze, new Guid("8059d89c-1ed5-43d3-a9dc-a11de6cd0f8d")},  // hefnerkerze
         {UnitChoicesEnum.InternationalCandle, new Guid("fa25c6d3-c832-42a1-8490-c31131378ee2")},  // international candle
         {UnitChoicesEnum.DecimalCandle, new Guid("a07a3c15-4679-4a6a-a79b-64fe27fa5799")},  // decimal candle
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
  public partial class MagneticFluxDensityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Tesla,  // tesla
         Gauss,  // gauss
         Milligauss,  // milligauss
         Millitesla,  // millitesla
         Microtesla,  // microtesla
         Nanotesla,  // nanotesla
         MaxwellPerSquareCentimetre,  // maxwell per square centimetre
         WeberPerSquareMetre // weber per square metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Tesla, new Guid("33c3b59d-9876-4918-9f31-f22de88d7bde")},  // tesla
         {UnitChoicesEnum.Gauss, new Guid("c09cd87d-8a84-45d0-88d3-20bb5cc48559")},  // gauss
         {UnitChoicesEnum.Milligauss, new Guid("41ace729-a2ff-4047-adc3-375829de64c6")},  // milligauss
         {UnitChoicesEnum.Millitesla, new Guid("9b6d864e-6775-4668-a59d-e1ab432f8960")},  // millitesla
         {UnitChoicesEnum.Microtesla, new Guid("c6b30197-be6b-41b7-803d-a8de61338612")},  // microtesla
         {UnitChoicesEnum.Nanotesla, new Guid("9bef9def-8cd3-4f7b-b991-290d3441b3d4")},  // nanotesla
         {UnitChoicesEnum.MaxwellPerSquareCentimetre, new Guid("d1b202cb-87c6-417a-947c-5247e5cdfe82")},  // maxwell per square centimetre
         {UnitChoicesEnum.WeberPerSquareMetre, new Guid("fefe997a-f3a6-4663-a1de-32889ee0cf15")} // weber per square metre
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
  public partial class MagneticFluxQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Weber,  // weber
         Milliweber,  // milliweber
         Microweber,  // microweber
         VoltSecond,  // volt second
         UnitPole,  // unit pole
         Megaline,  // megaline
         Kiloline,  // kiloline
         Line,  // line
         Maxwell,  // maxwell
         TeslaSquareMetre,  // tesla square metre
         TeslaSquareCentimetre,  // tesla square centimetre
         GaussSquareCentimetre,  // gauss square centimetre
         MagneticFluxQuantum // magnetic flux quantum
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Weber, new Guid("d790689d-e7dd-43d8-a3c0-c17ccc8073e5")},  // weber
         {UnitChoicesEnum.Milliweber, new Guid("94f03fc7-b0bb-4356-8787-c9e33f6559d2")},  // milliweber
         {UnitChoicesEnum.Microweber, new Guid("200b9de7-0635-40eb-8ebd-9cef7c01ac10")},  // microweber
         {UnitChoicesEnum.VoltSecond, new Guid("430305c3-d672-4d68-9b16-d0517243a870")},  // volt second
         {UnitChoicesEnum.UnitPole, new Guid("3bac78d4-5601-4cb2-bea1-01d952597a4d")},  // unit pole
         {UnitChoicesEnum.Megaline, new Guid("cca39e15-ee2e-4b8f-8843-527b329f3e81")},  // megaline
         {UnitChoicesEnum.Kiloline, new Guid("85862477-e913-4bcf-9d24-8248ec975d43")},  // kiloline
         {UnitChoicesEnum.Line, new Guid("40d608dd-b19f-4489-aac3-a3a6b7a55413")},  // line
         {UnitChoicesEnum.Maxwell, new Guid("8c1fcd01-4a3d-469a-a019-d3b35f7ef8b5")},  // maxwell
         {UnitChoicesEnum.TeslaSquareMetre, new Guid("f6da9f32-0738-4014-aac6-fdc5935fd436")},  // tesla square metre
         {UnitChoicesEnum.TeslaSquareCentimetre, new Guid("312b97ea-6167-47b5-a046-c6c202fb7eb4")},  // tesla square centimetre
         {UnitChoicesEnum.GaussSquareCentimetre, new Guid("a0dc1e92-7e84-401f-bca2-a6eb618ef604")},  // gauss square centimetre
         {UnitChoicesEnum.MagneticFluxQuantum, new Guid("f768bd79-1119-401c-b0df-39a5207273e0")} // magnetic flux quantum
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
  public partial class MassGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerMetre,  // kilogram per metre
         PoundPerFoot,  // pound per foot
         GramPerMetre // gram per metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerMetre, new Guid("c8b4a6ea-29bf-4e5a-b7ce-9142cefc0752")},  // kilogram per metre
         {UnitChoicesEnum.PoundPerFoot, new Guid("6fdf4cb6-a43b-482d-9bc8-d4ad49770f9e")},  // pound per foot
         {UnitChoicesEnum.GramPerMetre, new Guid("0cea1e32-9adb-4882-9070-d027cd0eef8e")} // gram per metre
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
  public partial class MassRateQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerSecond,  // kilogram per second
         KilogramPerMinute,  // kilogram per minute
         KilogramPerHour,  // kilogram per hour
         KilogramPerYear,  // kilogram per year
         PoundPerSecond,  // pound per second
         PoundPerMinute,  // pound per minute
         PoundPerHour,  // pound per hour
         PoundPerYear // pound per year
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerSecond, new Guid("a2daceb8-7705-4c97-9945-b354ea1ff78d")},  // kilogram per second
         {UnitChoicesEnum.KilogramPerMinute, new Guid("b776ae6f-5b86-462c-b815-2608d7e98192")},  // kilogram per minute
         {UnitChoicesEnum.KilogramPerHour, new Guid("736e4fcd-434f-4442-b025-a480a1532543")},  // kilogram per hour
         {UnitChoicesEnum.KilogramPerYear, new Guid("0ce50feb-a755-4a62-a50b-4af417bc2702")},  // kilogram per year
         {UnitChoicesEnum.PoundPerSecond, new Guid("48ac7515-ce4e-4ed6-a198-fe3ed3451a38")},  // pound per second
         {UnitChoicesEnum.PoundPerMinute, new Guid("92d18443-9357-42cf-86d2-fa78996c838a")},  // pound per minute
         {UnitChoicesEnum.PoundPerHour, new Guid("d4e0791c-eb4c-47a4-9e71-af3ad1b707cc")},  // pound per hour
         {UnitChoicesEnum.PoundPerYear, new Guid("a461e40b-48ea-49b1-8a55-8e75b26fbb8e")} // pound per year
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
  public partial class MaterialStrengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // pascal
         Megapascal,  // megapascal
         Gigapascal,  // gigapascal
         Psi,  // psi
         PoundPer100SquareFoot,  // pound per 100 square foot
         MegapoundPerSquareInch // megapound per square inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("159e99d3-c79d-4dc6-974f-05cc38af001e")},  // pascal
         {UnitChoicesEnum.Megapascal, new Guid("38b95b61-a825-4393-a0e8-ecd686575735")},  // megapascal
         {UnitChoicesEnum.Gigapascal, new Guid("c9aa0a18-02ac-42a0-9afe-8a08b4f03331")},  // gigapascal
         {UnitChoicesEnum.Psi, new Guid("4adf2a33-05c3-49bb-ba61-59dd76f4621e")},  // psi
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("eb1e2a52-3de3-4338-ad4d-40e8ce90e40b")},  // pound per 100 square foot
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("197a8b98-190d-4d45-91d7-85af12deab02")} // megapound per square inch
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
  public partial class PorousMediumPermeabilityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMetre,  // square metre
         Darcy,  // darcy
         Millidarcy,  // millidarcy
         Microdarcy,  // microdarcy
         Nanodarcy // nanodarcy
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMetre, new Guid("5e27ad4a-b541-4807-9a36-4bd159b33f52")},  // square metre
         {UnitChoicesEnum.Darcy, new Guid("9a89bcc3-dc77-4e3a-a492-fcdabc24ec41")},  // darcy
         {UnitChoicesEnum.Millidarcy, new Guid("8d7a6767-6c6b-4daf-8617-d35e4055d457")},  // millidarcy
         {UnitChoicesEnum.Microdarcy, new Guid("b552f28d-c68a-4c59-853c-fe6e03dd5f4c")},  // microdarcy
         {UnitChoicesEnum.Nanodarcy, new Guid("f35b05c7-8b2f-4194-9336-d42cec5f3ba5")} // nanodarcy
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
  public partial class PlaneAngleQuantity : SymbolizedBasePhysicalQuantity
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
  public partial class PowerQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Watt,  // watt
         Decawatt,  // decawatt
         Hectowatt,  // hectowatt
         Kilowatt,  // kilowatt
         Megawatt,  // megawatt
         Gigawatt,  // gigawatt
         Terawatt,  // terawatt
         Petawatt,  // petawatt
         Exawatt,  // exawatt
         Deciwatt,  // deciwatt
         Centiwatt,  // centiwatt
         Milliwatt,  // milliwatt
         Microwatt,  // microwatt
         Nanowatt,  // nanowatt
         Picowatt,  // picowatt
         Femtowatt,  // femtowatt
         Attowatt // attowatt
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Watt, new Guid("9d986a0c-700f-4448-a48c-a028bbd22049")},  // watt
         {UnitChoicesEnum.Decawatt, new Guid("fa888306-f2ef-420a-9ce2-8c56fe64ea3c")},  // decawatt
         {UnitChoicesEnum.Hectowatt, new Guid("1f159f0d-635a-4bc8-9020-6c09d72b3f63")},  // hectowatt
         {UnitChoicesEnum.Kilowatt, new Guid("016b23c7-0231-45bb-8723-5d3d4cc5c054")},  // kilowatt
         {UnitChoicesEnum.Megawatt, new Guid("5719b5f3-5c24-46d2-8ccd-0a06cc6b49ae")},  // megawatt
         {UnitChoicesEnum.Gigawatt, new Guid("ba67ba92-cdf5-46a8-a5f5-56c1ad102417")},  // gigawatt
         {UnitChoicesEnum.Terawatt, new Guid("b3e60a20-9e0f-479b-903b-16b22d86a515")},  // terawatt
         {UnitChoicesEnum.Petawatt, new Guid("bafba6b7-8a58-46b0-b4c7-c9a008c5e8f4")},  // petawatt
         {UnitChoicesEnum.Exawatt, new Guid("457950e4-0d4c-4f18-87ae-c35a7d2f512a")},  // exawatt
         {UnitChoicesEnum.Deciwatt, new Guid("6a3cd886-1c2c-41c8-8214-b21aff588b1e")},  // deciwatt
         {UnitChoicesEnum.Centiwatt, new Guid("ac6c67e1-0912-44f2-9496-ed82aca2b925")},  // centiwatt
         {UnitChoicesEnum.Milliwatt, new Guid("4b9e8b24-6c84-423e-8f79-b2bec161f219")},  // milliwatt
         {UnitChoicesEnum.Microwatt, new Guid("f0345b17-3e67-4c27-a787-69cd6feb7b1b")},  // microwatt
         {UnitChoicesEnum.Nanowatt, new Guid("622ee208-1b04-42c4-ba6e-552e6e328e02")},  // nanowatt
         {UnitChoicesEnum.Picowatt, new Guid("5b46567b-0571-4ca7-90d5-6304a0b7f938")},  // picowatt
         {UnitChoicesEnum.Femtowatt, new Guid("325622ea-c161-4f4f-9ee4-86d9e802f21c")},  // femtowatt
         {UnitChoicesEnum.Attowatt, new Guid("7bc1807f-90ac-41b0-a15f-9d1c81101f6d")} // attowatt
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
  public partial class PressureGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalPerMetre,  // pascal per metre
         BarPerMetre,  // bar per metre
         PsiPerMetre,  // psi per metre
         PsiPerFoot // psi per foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalPerMetre, new Guid("f5a37831-4a70-44de-af34-4f6ce1a54af3")},  // pascal per metre
         {UnitChoicesEnum.BarPerMetre, new Guid("73a70891-87cf-44fc-8437-94938f034eec")},  // bar per metre
         {UnitChoicesEnum.PsiPerMetre, new Guid("2235a51b-cdf2-4f53-9664-b7a968dbbba3")},  // psi per metre
         {UnitChoicesEnum.PsiPerFoot, new Guid("b99cef5c-d6df-4803-b52b-6050cf7e7ff8")} // psi per foot
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
  public partial class PressureLossConstantQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PressureLossConstantSI,  // pressure loss constant SI
         PressureLossConstantMetric,  // pressure loss constant metric
         PressureLossConstantUK,  // pressure loss constant UK
         PressureLossConstantUS // pressure loss constant US
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PressureLossConstantSI, new Guid("e0b334c4-2e44-4b1b-891f-9deae86a4d17")},  // pressure loss constant SI
         {UnitChoicesEnum.PressureLossConstantMetric, new Guid("043fbd34-1e4f-45bc-9935-b1797b606fd6")},  // pressure loss constant metric
         {UnitChoicesEnum.PressureLossConstantUK, new Guid("d5a97f2d-cb2f-449f-8f60-0ad292a01b87")},  // pressure loss constant UK
         {UnitChoicesEnum.PressureLossConstantUS, new Guid("b5cb21d1-0e71-4ab2-8d9d-42de21753edc")} // pressure loss constant US
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
  public partial class PressureQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // pascal
         Kilopascal,  // kilopascal
         Bar,  // bar
         Millibar,  // millibar
         Microbar,  // microbar
         PoundPerSquareInch,  // pound per square inch
         PoundPer100SquareFoot,  // pound per 100 square foot
         KilopoundPerSquareInch,  // kilopound per square inch
         StandardAtmosphere,  // standard atmosphere
         PoundPerSquareFoot,  // pound per square foot
         Megapascal,  // megapascal
         Gigapascal,  // gigapascal
         NewtonPerSquareMetre,  // newton per square metre
         NewtonPerSquareCentimetre,  // newton per square centimetre
         NewtonPerSquareMillimetre,  // newton per square millimetre
         KilonewtonPerSquareMetre,  // kilonewton per square metre
         MegapoundPerSquareInch,  // megapound per square inch
         Torr,  // torr
         CentimetreMercuryAtZeroDegreeCelsius,  // centimetre mercury at zero degree celsius
         MillimetreMercuryAtZeroDegreeCelsius,  // millimetre mercury at zero degree celsius
         InchMercuryAt32DegreeFahrenheit,  // inch mercury at 32 degree fahrenheit
         InchMercuryAt60DegreeFahrenheit,  // inch mercury at 60 degree fahrenheit
         CentimetreWaterAt4DegreeCelsius,  // centimetre water at 4 degree celsius
         MillimetreWaterAt4DegreeCelsius,  // millimetre water at 4 degree celsius
         InchWaterAt4DegreeCelsius,  // inch water at 4 degree celsius
         FootWaterAt4DegreeCelsius,  // foot water at 4 degree celsius
         DynePerSquareCentimetre // dyne per square centimetre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // pascal
         {UnitChoicesEnum.Kilopascal, new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29")},  // kilopascal
         {UnitChoicesEnum.Bar, new Guid("0d182739-f8f6-47a6-afcb-71feac973307")},  // bar
         {UnitChoicesEnum.Millibar, new Guid("43e4fe86-948d-4765-a69d-513ce6dc2b5b")},  // millibar
         {UnitChoicesEnum.Microbar, new Guid("7fb9e41f-4748-4457-b8b9-efb73da52d94")},  // microbar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // pound per square inch
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("e3b95821-d782-4f12-a492-489cbcd6d2a1")},  // pound per 100 square foot
         {UnitChoicesEnum.KilopoundPerSquareInch, new Guid("a07b5fe5-87e3-4422-afe1-f54de24deeb8")},  // kilopound per square inch
         {UnitChoicesEnum.StandardAtmosphere, new Guid("93839971-33f2-43e9-82eb-9f869846f999")},  // standard atmosphere
         {UnitChoicesEnum.PoundPerSquareFoot, new Guid("35b28889-c076-4274-b200-cf7732b17aa3")},  // pound per square foot
         {UnitChoicesEnum.Megapascal, new Guid("4ef28797-f416-4d97-b36a-711ea848bcc0")},  // megapascal
         {UnitChoicesEnum.Gigapascal, new Guid("5c81fb9b-36ad-47b7-9a8e-c999f7fdbfe3")},  // gigapascal
         {UnitChoicesEnum.NewtonPerSquareMetre, new Guid("101e92c3-47ab-4d55-8982-93061bc82dea")},  // newton per square metre
         {UnitChoicesEnum.NewtonPerSquareCentimetre, new Guid("2aa59deb-84d9-41c5-969f-8c8bb9d0c369")},  // newton per square centimetre
         {UnitChoicesEnum.NewtonPerSquareMillimetre, new Guid("e5e9cb06-38a8-4ac2-a8a5-8b74689a31a8")},  // newton per square millimetre
         {UnitChoicesEnum.KilonewtonPerSquareMetre, new Guid("eaa46677-af1c-4922-bf61-d82f2925534b")},  // kilonewton per square metre
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("bb49de0a-fbf3-4914-b6b9-fc60ab502522")},  // megapound per square inch
         {UnitChoicesEnum.Torr, new Guid("f5afdfee-624e-46fa-b798-0ab1b04d2181")},  // torr
         {UnitChoicesEnum.CentimetreMercuryAtZeroDegreeCelsius, new Guid("412602dc-837b-4fab-afc9-3bf4798a9bed")},  // centimetre mercury at zero degree celsius
         {UnitChoicesEnum.MillimetreMercuryAtZeroDegreeCelsius, new Guid("d91f64fe-4df4-4ddd-943c-d985fbd1659b")},  // millimetre mercury at zero degree celsius
         {UnitChoicesEnum.InchMercuryAt32DegreeFahrenheit, new Guid("ab729585-0716-4f24-9502-fcd07ba051bc")},  // inch mercury at 32 degree fahrenheit
         {UnitChoicesEnum.InchMercuryAt60DegreeFahrenheit, new Guid("83ed97cc-526c-41cc-be78-ea0c86412080")},  // inch mercury at 60 degree fahrenheit
         {UnitChoicesEnum.CentimetreWaterAt4DegreeCelsius, new Guid("a1bac4cc-f37c-4aa5-aec6-ede0b4c52f09")},  // centimetre water at 4 degree celsius
         {UnitChoicesEnum.MillimetreWaterAt4DegreeCelsius, new Guid("a46b3ef6-fe2a-4ff3-bc2d-7a26661ce45e")},  // millimetre water at 4 degree celsius
         {UnitChoicesEnum.InchWaterAt4DegreeCelsius, new Guid("3015f436-b35d-455c-af23-b9bc4dd857da")},  // inch water at 4 degree celsius
         {UnitChoicesEnum.FootWaterAt4DegreeCelsius, new Guid("52de6721-dfec-4a54-861c-e74da72c8470")},  // foot water at 4 degree celsius
         {UnitChoicesEnum.DynePerSquareCentimetre, new Guid("04ca59b8-90e1-4903-ac82-ee95cac0ca38")} // dyne per square centimetre
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
  public partial class ProportionQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Proportion,  // proportion
         Percent,  // percent
         PerThousand,  // per thousand
         PartPerMillion // part per million
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Proportion, new Guid("03eb339b-61aa-4b42-aa35-4a20c547fdb9")},  // proportion
         {UnitChoicesEnum.Percent, new Guid("1a825e84-bc53-4da8-a089-118fdf40b8f7")},  // percent
         {UnitChoicesEnum.PerThousand, new Guid("141465a2-9c3c-4dda-82ec-eb35e72250c2")},  // per thousand
         {UnitChoicesEnum.PartPerMillion, new Guid("af33bf27-c3b8-4746-8b08-826ed1d21792")} // part per million
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
  public partial class RandomWalkQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSquareRootSecond,  // radian per square root second
         RadianPerSquareRootMinute,  // radian per square root minute
         RadianPerSquareRootHour,  // radian per square root hour
         RadianPerSquareRootDay,  // radian per square root day
         DegreePerSquareRootSecond,  // degree per square root second
         DegreePerSquareRootMinute,  // degree per square root minute
         DegreePerSquareRootHour,  // degree per square root hour
         DegreePerSquareRootDay // degree per square root day
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSquareRootSecond, new Guid("557ea59e-a1da-438b-b04d-ccfc5539f87f")},  // radian per square root second
         {UnitChoicesEnum.RadianPerSquareRootMinute, new Guid("ccc41b4e-2efb-4760-969f-94614248374f")},  // radian per square root minute
         {UnitChoicesEnum.RadianPerSquareRootHour, new Guid("e296c410-e278-4586-af95-bae6fe4f0673")},  // radian per square root hour
         {UnitChoicesEnum.RadianPerSquareRootDay, new Guid("fb4a74f9-a648-4310-a424-9c85036bbc41")},  // radian per square root day
         {UnitChoicesEnum.DegreePerSquareRootSecond, new Guid("87a0a4e3-a2f5-4f84-b845-c7e6276e1655")},  // degree per square root second
         {UnitChoicesEnum.DegreePerSquareRootMinute, new Guid("e8e3a988-4219-44a5-ae89-ce115a239d04")},  // degree per square root minute
         {UnitChoicesEnum.DegreePerSquareRootHour, new Guid("ab6b85cf-54e5-4c3b-a330-f65d7e3bb926")},  // degree per square root hour
         {UnitChoicesEnum.DegreePerSquareRootDay, new Guid("8f806d0f-3741-4aa8-9f37-54b4f80e307c")} // degree per square root day
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
         RelativeCelsius,  // relative celsius
         Rankine // rankine
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kelvin, new Guid("8fc5fa10-2d89-4064-8ace-b852d9a8d31f")},  // kelvin
         {UnitChoicesEnum.RelativeCelsius, new Guid("10ea31a1-e661-41c9-9a3d-245904b73599")},  // relative celsius
         {UnitChoicesEnum.Rankine, new Guid("62f3ffbc-eda3-400a-9fb7-8d021771f0fa")} // rankine
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
  public partial class ResistivityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         OhmMetre,  // ohm metre
         KiloOhmMetre,  // kilo ohm metre
         MegaOhmMetre,  // mega ohm metre
         GigaOhmMetre // giga ohm metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.OhmMetre, new Guid("fb07d86d-d69f-46ca-892c-17ec45adffcb")},  // ohm metre
         {UnitChoicesEnum.KiloOhmMetre, new Guid("c58ce3f0-7389-4c36-b291-55fa5ceb9962")},  // kilo ohm metre
         {UnitChoicesEnum.MegaOhmMetre, new Guid("cf90cab7-e973-469a-9727-08bfa7f708e6")},  // mega ohm metre
         {UnitChoicesEnum.GigaOhmMetre, new Guid("eecfdf24-7a8e-4783-a627-d4387831767d")} // giga ohm metre
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
  public partial class SolidAngleQuantity : SymbolizedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Steradian,  // steradian
         Spat,  // spat
         DegreeSquared // degree squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Steradian, new Guid("aee057f5-3235-4976-b6e6-a57179f0173e")},  // steradian
         {UnitChoicesEnum.Spat, new Guid("44abc0c0-d564-442a-ac80-b08c9d499867")},  // spat
         {UnitChoicesEnum.DegreeSquared, new Guid("ad4b94e8-1a86-42ab-bfc6-9cc7ff7a835f")} // degree squared
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
  public partial class SpecificHeatCapacityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         JoulePerKilogramKelvin,  // joule per kilogram kelvin
         JoulePerGramKelvin,  // joule per gram kelvin
         JoulePerGramDegreeCelsius,  // joule per gram degree celsius
         CaloriePerGramDegreeCelsius,  // calorie per gram degree celsius
         BritishThermalUnitPerPoundDegreeFahrenheit,  // british thermal unit per pound degree fahrenheit
         KilocaloriePerGramDegreeCelsius // kilocalorie per gram degree celsius
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.JoulePerKilogramKelvin, new Guid("52d9523e-546b-41dd-b283-a125447433a3")},  // joule per kilogram kelvin
         {UnitChoicesEnum.JoulePerGramKelvin, new Guid("0c38001b-ecba-4920-ac75-e4644d8feced")},  // joule per gram kelvin
         {UnitChoicesEnum.JoulePerGramDegreeCelsius, new Guid("5b620d63-2269-42d3-8385-edca04c7ea70")},  // joule per gram degree celsius
         {UnitChoicesEnum.CaloriePerGramDegreeCelsius, new Guid("bb241c58-e76c-4d96-81c1-356b3f2ad397")},  // calorie per gram degree celsius
         {UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFahrenheit, new Guid("ad9274f2-4c1a-45fe-97c1-710f00deca16")},  // british thermal unit per pound degree fahrenheit
         {UnitChoicesEnum.KilocaloriePerGramDegreeCelsius, new Guid("b283ecf7-20e4-4a6c-b62b-b07f56fa6614")} // kilocalorie per gram degree celsius
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
  public partial class SpecificHeatCapacityGradientPerTemperatureQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         JoulePerKilogramSquaredKelvin,  // joule per kilogram squared kelvin
         JoulePerGramSquaredKelvin,  // joule per gram squared kelvin
         JoulePerGramDegreeSquaredCelsius,  // joule per gram degree squared celsius
         CaloriePerGramDegreeSquaredCelsius,  // calorie per gram degree squared celsius
         BritishThermalUnitPerPoundSquaredDegreeFahrenheit // british thermal unit per pound squared degree fahrenheit 
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.JoulePerKilogramSquaredKelvin, new Guid("9570fd84-ff2e-4a74-93b7-39bcf6558301")},  // joule per kilogram squared kelvin
         {UnitChoicesEnum.JoulePerGramSquaredKelvin, new Guid("69520d03-c7c3-483f-bbbb-6bdf3cf74463")},  // joule per gram squared kelvin
         {UnitChoicesEnum.JoulePerGramDegreeSquaredCelsius, new Guid("9ed03436-3032-4bee-a145-fd03b6236816")},  // joule per gram degree squared celsius
         {UnitChoicesEnum.CaloriePerGramDegreeSquaredCelsius, new Guid("ad3fe4d1-3286-4313-9f45-f2110b7ca6f2")},  // calorie per gram degree squared celsius
         {UnitChoicesEnum.BritishThermalUnitPerPoundSquaredDegreeFahrenheit, new Guid("57264532-79b7-4a19-8ffe-617bba781be3")} // british thermal unit per pound squared degree fahrenheit 
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
  public partial class StressQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // pascal
         Kilopascal,  // kilopascal
         Bar,  // bar
         Millibar,  // millibar
         Microbar,  // microbar
         PoundPerSquareInch,  // pound per square inch
         PoundPer100SquareFoot,  // pound per 100 square foot
         KilopoundPerSquareInch,  // kilopound per square inch
         PoundPerSquareFoot,  // pound per square foot
         Megapascal,  // megapascal
         Gigapascal,  // gigapascal
         NewtonPerSquareMetre,  // newton per square metre
         NewtonPerSquareCentimetre,  // newton per square centimetre
         NewtonPerSquareMillimetre,  // newton per square millimetre
         KilonewtonPerSquareMetre,  // kilonewton per square metre
         MegapoundPerSquareInch,  // megapound per square inch
         DynePerSquareCentimetre // dyne per square centimetre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("7a4c7d2e-62f1-43c7-9c9d-8ff8664b0d98")},  // pascal
         {UnitChoicesEnum.Kilopascal, new Guid("8f070021-4cc7-424d-a325-e2e57fc82874")},  // kilopascal
         {UnitChoicesEnum.Bar, new Guid("69864a1c-bb6b-400e-be3b-527bc94a9a96")},  // bar
         {UnitChoicesEnum.Millibar, new Guid("cf58a57a-381b-4864-9ab3-bbe42589d871")},  // millibar
         {UnitChoicesEnum.Microbar, new Guid("b3ae1880-5d17-4f4b-b837-c6dc13c44cae")},  // microbar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("0e385d5b-5d3a-4360-8695-a934f0152a09")},  // pound per square inch
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("d1aade96-1038-4902-9c4a-95f96933d54d")},  // pound per 100 square foot
         {UnitChoicesEnum.KilopoundPerSquareInch, new Guid("02b3acd6-0715-4ef6-b8e4-6134a3cdc3a6")},  // kilopound per square inch
         {UnitChoicesEnum.PoundPerSquareFoot, new Guid("2d835d44-2ffd-4239-b0dd-c9c36a763d4a")},  // pound per square foot
         {UnitChoicesEnum.Megapascal, new Guid("b6de095b-2800-4faf-931b-e8b2b9b2e35f")},  // megapascal
         {UnitChoicesEnum.Gigapascal, new Guid("213a896e-47e4-4745-baed-c28861f938bb")},  // gigapascal
         {UnitChoicesEnum.NewtonPerSquareMetre, new Guid("23d4c68e-a606-4fc0-a2b8-74998f6c2862")},  // newton per square metre
         {UnitChoicesEnum.NewtonPerSquareCentimetre, new Guid("b42eccea-4c35-42af-ba98-5101a3c10b6b")},  // newton per square centimetre
         {UnitChoicesEnum.NewtonPerSquareMillimetre, new Guid("9f96d22c-9021-4ed6-9904-344d6cd2417a")},  // newton per square millimetre
         {UnitChoicesEnum.KilonewtonPerSquareMetre, new Guid("ff05dc39-74f1-4bc8-b2d4-e9ee518d3e43")},  // kilonewton per square metre
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("c1b8c4db-7a1e-4201-b0aa-e23d1df40871")},  // megapound per square inch
         {UnitChoicesEnum.DynePerSquareCentimetre, new Guid("eee0197b-0fbd-4a21-8023-61403c9417fe")} // dyne per square centimetre
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
  public partial class TemperatureGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KelvinPerMetre,  // kelvin per metre
         CelsiusPerMetre,  // celsius per metre
         CelsiusPer10Metre,  // celsius per 10 metre
         CelsiusPer30Metre,  // celsius per 30 metre
         CelsiusPer100Metre,  // celsius per 100 metre
         CelsiusPerFoot,  // celsius per foot
         CelsiusPer30Foot,  // celsius per 30 foot
         CelsiusPer100Foot,  // celsius per 100 foot
         FahrenheitPerFoot,  // fahrenheit per foot
         FahrenheitPer30Foot,  // fahrenheit per 30 foot
         FahrenheitPer100Foot // fahrenheit per 100 foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KelvinPerMetre, new Guid("f1fe19d2-12e3-43d1-ba97-3ef9e8ec9e73")},  // kelvin per metre
         {UnitChoicesEnum.CelsiusPerMetre, new Guid("40dbbdfe-b680-403a-8326-2c217ba85d52")},  // celsius per metre
         {UnitChoicesEnum.CelsiusPer10Metre, new Guid("5e4ff2bf-4788-4258-bd4a-7b18a13364ff")},  // celsius per 10 metre
         {UnitChoicesEnum.CelsiusPer30Metre, new Guid("d17464c4-a7ef-4dcd-b783-bafe6e9b92de")},  // celsius per 30 metre
         {UnitChoicesEnum.CelsiusPer100Metre, new Guid("b47f299a-913a-46b7-ad20-c683fa0f02d0")},  // celsius per 100 metre
         {UnitChoicesEnum.CelsiusPerFoot, new Guid("e7b05420-41f6-4812-bc54-9c14f05a9cbd")},  // celsius per foot
         {UnitChoicesEnum.CelsiusPer30Foot, new Guid("bea3df4f-78e9-4e1a-bbee-22086da043b4")},  // celsius per 30 foot
         {UnitChoicesEnum.CelsiusPer100Foot, new Guid("f9bae95a-b282-44a7-8ae0-54728ef3c7a3")},  // celsius per 100 foot
         {UnitChoicesEnum.FahrenheitPerFoot, new Guid("d08596f1-77c4-4a8e-9245-6bf563fa7345")},  // fahrenheit per foot
         {UnitChoicesEnum.FahrenheitPer30Foot, new Guid("a1664cb0-db5c-4933-9b57-d075c4975f46")},  // fahrenheit per 30 foot
         {UnitChoicesEnum.FahrenheitPer100Foot, new Guid("232e2d6d-cb65-4b56-9277-457e4ff678fa")} // fahrenheit per 100 foot
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
  public partial class TemperatureQuantity : SymbolizedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Kelvin,  // kelvin
         Celsius,  // celsius
         Fahrenheit,  // fahrenheit
         Rankine,  // rankine
         Réaumur // réaumur
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kelvin, new Guid("8fc5fa10-2d89-4064-8ace-b852d9a8d31f")},  // kelvin
         {UnitChoicesEnum.Celsius, new Guid("5d69048e-fe18-4923-9341-cb80c2ccf8cc")},  // celsius
         {UnitChoicesEnum.Fahrenheit, new Guid("55c289ab-6975-439f-9b7a-fdca6d219a9f")},  // fahrenheit
         {UnitChoicesEnum.Rankine, new Guid("b4d6c55d-cf05-46e1-a09b-d0b26eba634a")},  // rankine
         {UnitChoicesEnum.Réaumur, new Guid("968def6c-bc85-49b0-84a8-3ac7ad37efc6")} // réaumur
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
  public partial class ThermalConductivityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         WattPerMetreKelvin,  // watt per metre kelvin
         CaloriePerMetreSecondDegreeCelsius,  // calorie per metre second degree celsius
         CaloriePerCentimetreSecondDegreeCelsius,  // calorie per centimetre second degree celsius
         BritishThermalUnitPerHourFootDegreeFahrenheit,  // british thermal unit per hour foot degree fahrenheit
         BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit // british thermal unit inch per hour square foot degree fahrenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.WattPerMetreKelvin, new Guid("3ddba24f-4ccf-4cb1-af6c-2829cac3b88f")},  // watt per metre kelvin
         {UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsius, new Guid("d0386fc4-b97b-4874-8c8d-66e093c391ea")},  // calorie per metre second degree celsius
         {UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsius, new Guid("5f8706ed-d938-4715-a0ca-2afff423f6e6")},  // calorie per centimetre second degree celsius
         {UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheit, new Guid("43169695-8f6e-42ad-8c07-566dc7651edb")},  // british thermal unit per hour foot degree fahrenheit
         {UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit, new Guid("c79c2b27-c956-49a3-9caf-8653017777ca")} // british thermal unit inch per hour square foot degree fahrenheit
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
  public partial class ThermalConductivityGradientPerTemperatureQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         WattPerMetreKelvinPerKelvin,  // watt per metre kelvin per kelvin
         CaloriePerMetreSecondDegreeCelsiusSquared,  // calorie per metre second degree celsius squared
         CaloriePerCentimetreSecondDegreeCelsiusSquared,  // calorie per centimetre second degree celsius squared
         BritishThermalUnitPerHourFootDegreeFahrenheitSquared,  // british thermal unit per hour foot degree fahrenheit squared
         BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared // british thermal unit inch per hour square foot degree fahrenheit squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.WattPerMetreKelvinPerKelvin, new Guid("0459940e-d71f-4b01-9ea6-eeb05d754af2")},  // watt per metre kelvin per kelvin
         {UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsiusSquared, new Guid("eb08ff8c-d542-440f-a4c7-610653018910")},  // calorie per metre second degree celsius squared
         {UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsiusSquared, new Guid("6c21a6cd-61fe-4086-95a7-ad6d6820c96e")},  // calorie per centimetre second degree celsius squared
         {UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheitSquared, new Guid("b79509ea-8c03-4538-9974-208f7e0ee40e")},  // british thermal unit per hour foot degree fahrenheit squared
         {UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared, new Guid("918b4e34-3986-427f-8bb6-c09740a7c299")} // british thermal unit inch per hour square foot degree fahrenheit squared
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
  public partial class TimeQuantity : SymbolizedBasePhysicalQuantity
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
         MonthSideral,  // month sideral
         MonthSynodic,  // month synodic
         QuarterCommon,  // quarter common
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
         {UnitChoicesEnum.MonthSideral, new Guid("2e7446c0-5b0e-44e1-9a27-f0bc7d8aeb98")},  // month sideral
         {UnitChoicesEnum.MonthSynodic, new Guid("31edcda9-df8f-4d15-83a9-7dafd8a7e404")},  // month synodic
         {UnitChoicesEnum.QuarterCommon, new Guid("71f0e01a-c1a2-49ba-a25b-c11854f8867c")},  // quarter common
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
  public partial class TorqueGradientPerLengthQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonMetrePerMetre,  // newton metre per metre
         DecanewtonMetrePerMetre,  // decanewton metre per metre
         KilogramForceMetrePerMetre,  // kilogram force metre per metre
         KilonewtonMetrePerMetre,  // kilonewton metre per metre
         FootPoundPerMetre,  // foot pound per metre
         KilofootPoundPerMetre,  // kilofoot pound per metre
         NewtonDecimetrePerMetre,  // newton decimetre per metre
         NewtonCentimetrePerMetre,  // newton centimetre per metre
         NewtonMillimetrePerMetre,  // newton millimetre per metre
         InchPoundPerMetre,  // inch pound per metre
         NewtonMetrePerDecimetre,  // Newton metre per decimetre
         DecanewtonMetrePerDecimetre,  // decanewton metre per decimetre
         KilogramForceMetrePerDecimetre,  // kilogram force metre per decimetre
         KilonewtonMetrePerDecimetre,  // kilonewton metre per decimetre
         FootPoundPerDecimetre,  // foot pound per decimetre
         KilofootPoundPerDecimetre,  // kilofoot pound per decimetre
         NewtonDecimetrePerDecimetre,  // newton decimetre per decimetre
         NewtonCentimetrePerDecimetre,  // newton centimetre per decimetre
         NewtonMillimetrePerDecimetre,  // newton millimetre per decimetre
         InchPoundPerDecimetre,  // inch pound per decimetre
         NewtonMetrePerCentimetre,  // Newton metre per centimetre
         DecanewtonMetrePerCentimetre,  // decanewton metre per centimetre
         KilogramForceMetrePerCentimetre,  // kilogram force metre per centimetre
         KilonewtonMetrePerCentimetre,  // kilonewton metre per centimetre
         FootPoundPerCentimetre,  // foot pound per centimetre
         KilofootPoundPerCentimetre,  // kilofoot pound per centimetre
         NewtonDecimetrePerCentimetre,  // newton decimetre per centimetre
         NewtonCentimetrePerCentimetre,  // newton centimetre per centimetre
         NewtonMillimetrePerCentimetre,  // newton millimetre per centimetre
         InchPoundPerCentimetre,  // inch pound per centimetre
         NewtonMetrePerMillimetre,  // Newton metre per millimetre
         DecanewtonMetrePerMillimetre,  // decanewton metre per millimetre
         KilogramForceMetrePerMillimetre,  // kilogram force metre per millimetre
         KilonewtonMetrePerMillimetre,  // kilonewton metre per millimetre
         FootPoundPerMillimetre,  // foot pound per millimetre
         KilofootPoundPerMillimetre,  // kilofoot pound per millimetre
         NewtonDecimetrePerMillimetre,  // newton decimetre per millimetre
         NewtonCentimetrePerMillimetre,  // newton centimetre per millimetre
         NewtonMillimetrePerMillimetre,  // newton millimetre per millimetre
         InchPoundPerMillimetre,  // inch pound per millimetre
         NewtonMetrePerFoot,  // Newton metre per foot
         DecanewtonMetrePerFoot,  // decanewton metre per foot
         KilogramForceMetrePerFoot,  // kilogram force metre per foot
         KilonewtonMetrePerFoot,  // kilonewton metre per foot
         FootPoundPerFoot,  // foot pound per foot
         KilofootPoundPerFoot,  // kilofoot pound per foot
         NewtonDecimetrePerFoot,  // newton decimetre per foot
         NewtonCentimetrePerFoot,  // newton centimetre per foot
         NewtonMillimetrePerFoot,  // newton millimetre per foot
         InchPoundPerFoot,  // inch pound per foot
         NewtonMetrePerInch,  // Newton metre per inch
         DecanewtonMetrePerInch,  // decanewton metre per inch
         KilogramForceMetrePerInch,  // kilogram force metre per inch
         KilonewtonMetrePerInch,  // kilonewton metre per inch
         FootPoundPerInch,  // foot pound per inch
         KilofootPoundPerInch,  // kilofoot pound per inch
         NewtonDecimetrePerInch,  // newton decimetre per inch
         NewtonCentimetrePerInch,  // newton centimetre per inch
         NewtonMillimetrePerInch,  // newton millimetre per inch
         InchPoundPerInch // inch pound per inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonMetrePerMetre, new Guid("33baa8d7-6987-4217-959b-1e3aa5b04752")},  // newton metre per metre
         {UnitChoicesEnum.DecanewtonMetrePerMetre, new Guid("50a1ea8d-9a46-4e24-9e9f-dad66e8bb9ca")},  // decanewton metre per metre
         {UnitChoicesEnum.KilogramForceMetrePerMetre, new Guid("66f7449d-5a06-4dd0-bf27-0bed2d2e4bed")},  // kilogram force metre per metre
         {UnitChoicesEnum.KilonewtonMetrePerMetre, new Guid("d07e4c6c-fea3-4545-b020-9cc2402e1ca5")},  // kilonewton metre per metre
         {UnitChoicesEnum.FootPoundPerMetre, new Guid("e3b4fe22-6590-4b2d-b2fa-0250f1ca8b26")},  // foot pound per metre
         {UnitChoicesEnum.KilofootPoundPerMetre, new Guid("e9bff76e-5388-4ea0-85af-62c772d919c5")},  // kilofoot pound per metre
         {UnitChoicesEnum.NewtonDecimetrePerMetre, new Guid("87ef9e2b-7e3b-4bda-a406-9f0b7f06e8fa")},  // newton decimetre per metre
         {UnitChoicesEnum.NewtonCentimetrePerMetre, new Guid("c03b845d-f2e5-4a16-afca-efab2591c526")},  // newton centimetre per metre
         {UnitChoicesEnum.NewtonMillimetrePerMetre, new Guid("fb1bb6bb-9c4a-4ecd-99fc-4af502271614")},  // newton millimetre per metre
         {UnitChoicesEnum.InchPoundPerMetre, new Guid("18259cf1-1f96-4ace-b7ad-657a78254baf")},  // inch pound per metre
         {UnitChoicesEnum.NewtonMetrePerDecimetre, new Guid("5ceaa09f-0de4-4025-ba23-d3b76f55a8b1")},  // Newton metre per decimetre
         {UnitChoicesEnum.DecanewtonMetrePerDecimetre, new Guid("902dd7b3-0b4f-40a3-a089-02bb39367219")},  // decanewton metre per decimetre
         {UnitChoicesEnum.KilogramForceMetrePerDecimetre, new Guid("2c83dced-5b36-49f1-bd4a-c95d558fb868")},  // kilogram force metre per decimetre
         {UnitChoicesEnum.KilonewtonMetrePerDecimetre, new Guid("a3949720-a023-4c5d-9a5e-4194af30005f")},  // kilonewton metre per decimetre
         {UnitChoicesEnum.FootPoundPerDecimetre, new Guid("a6b11edb-e9bc-4a7e-9af9-ace7ca62b93b")},  // foot pound per decimetre
         {UnitChoicesEnum.KilofootPoundPerDecimetre, new Guid("92cb8e61-c58d-461a-a69c-ad9fe7324e2a")},  // kilofoot pound per decimetre
         {UnitChoicesEnum.NewtonDecimetrePerDecimetre, new Guid("61261367-5cb0-4038-bcfb-6c8395758a21")},  // newton decimetre per decimetre
         {UnitChoicesEnum.NewtonCentimetrePerDecimetre, new Guid("1eee8ef4-cb7b-451a-9658-d1704ccf81d2")},  // newton centimetre per decimetre
         {UnitChoicesEnum.NewtonMillimetrePerDecimetre, new Guid("6c49e6aa-7d4c-4c92-96e5-5e3f26c3a367")},  // newton millimetre per decimetre
         {UnitChoicesEnum.InchPoundPerDecimetre, new Guid("e638f5ee-bbf9-4e7b-ae6a-9613eb9792cc")},  // inch pound per decimetre
         {UnitChoicesEnum.NewtonMetrePerCentimetre, new Guid("d8c63694-bf19-48be-b9bd-0f5b462ce2ec")},  // Newton metre per centimetre
         {UnitChoicesEnum.DecanewtonMetrePerCentimetre, new Guid("e87d21e6-2191-4cee-aea8-1929df1d8bd0")},  // decanewton metre per centimetre
         {UnitChoicesEnum.KilogramForceMetrePerCentimetre, new Guid("6ee38a6b-907d-4de9-94f1-0d979ef58340")},  // kilogram force metre per centimetre
         {UnitChoicesEnum.KilonewtonMetrePerCentimetre, new Guid("2149c60b-d6a8-4056-9818-f7fe6d10c409")},  // kilonewton metre per centimetre
         {UnitChoicesEnum.FootPoundPerCentimetre, new Guid("730e5c03-816e-4f88-b7bf-632a8a30c3ca")},  // foot pound per centimetre
         {UnitChoicesEnum.KilofootPoundPerCentimetre, new Guid("6249a894-93d9-45b6-a188-eb2d4bef800e")},  // kilofoot pound per centimetre
         {UnitChoicesEnum.NewtonDecimetrePerCentimetre, new Guid("0dbdd140-66d3-4f47-bbea-f5025b804b20")},  // newton decimetre per centimetre
         {UnitChoicesEnum.NewtonCentimetrePerCentimetre, new Guid("2f7c8e32-f865-4b68-8a3c-4d8c862fd5f2")},  // newton centimetre per centimetre
         {UnitChoicesEnum.NewtonMillimetrePerCentimetre, new Guid("830ae4b8-76d5-404a-b0c7-90db357a68ec")},  // newton millimetre per centimetre
         {UnitChoicesEnum.InchPoundPerCentimetre, new Guid("6822172d-adf0-4a71-b883-f4bc825ee9ea")},  // inch pound per centimetre
         {UnitChoicesEnum.NewtonMetrePerMillimetre, new Guid("a6416087-d525-4d98-aa45-2006ceb4a474")},  // Newton metre per millimetre
         {UnitChoicesEnum.DecanewtonMetrePerMillimetre, new Guid("6acab23d-3952-4eed-b1a0-7c38f03109b0")},  // decanewton metre per millimetre
         {UnitChoicesEnum.KilogramForceMetrePerMillimetre, new Guid("cdd4e6aa-ee0b-4679-97be-82553960efd1")},  // kilogram force metre per millimetre
         {UnitChoicesEnum.KilonewtonMetrePerMillimetre, new Guid("1335bebf-fcda-4a39-afa8-7de3ed24fa0c")},  // kilonewton metre per millimetre
         {UnitChoicesEnum.FootPoundPerMillimetre, new Guid("73a284d2-8900-44bb-96ab-897416a525e1")},  // foot pound per millimetre
         {UnitChoicesEnum.KilofootPoundPerMillimetre, new Guid("bad7b651-25f9-4687-875f-7624388228d6")},  // kilofoot pound per millimetre
         {UnitChoicesEnum.NewtonDecimetrePerMillimetre, new Guid("ecfa262e-1242-4c36-8325-b98de1ef4ffd")},  // newton decimetre per millimetre
         {UnitChoicesEnum.NewtonCentimetrePerMillimetre, new Guid("0f0cd3a8-84ec-4b58-b100-3f413bea1e05")},  // newton centimetre per millimetre
         {UnitChoicesEnum.NewtonMillimetrePerMillimetre, new Guid("b20d7cec-c1f6-4f64-9b60-e77ea699d940")},  // newton millimetre per millimetre
         {UnitChoicesEnum.InchPoundPerMillimetre, new Guid("cd28eba2-c7ea-40d0-ac32-fb67a8f581bc")},  // inch pound per millimetre
         {UnitChoicesEnum.NewtonMetrePerFoot, new Guid("2ce8e697-3a8a-4a73-ac23-4730790b4812")},  // Newton metre per foot
         {UnitChoicesEnum.DecanewtonMetrePerFoot, new Guid("c6e8f7e7-0239-47bc-b230-0f5870c94b82")},  // decanewton metre per foot
         {UnitChoicesEnum.KilogramForceMetrePerFoot, new Guid("7b2d82cc-0ac5-4945-9914-c91e62ac61dd")},  // kilogram force metre per foot
         {UnitChoicesEnum.KilonewtonMetrePerFoot, new Guid("8b5be3db-bc7a-4107-b751-53d3d2772eb8")},  // kilonewton metre per foot
         {UnitChoicesEnum.FootPoundPerFoot, new Guid("85a75741-c967-4e10-b195-01e5e7297eda")},  // foot pound per foot
         {UnitChoicesEnum.KilofootPoundPerFoot, new Guid("65606e85-199d-4fee-8cd4-97715431d868")},  // kilofoot pound per foot
         {UnitChoicesEnum.NewtonDecimetrePerFoot, new Guid("cdd6f7a0-954c-4826-8263-bb2d7fb06764")},  // newton decimetre per foot
         {UnitChoicesEnum.NewtonCentimetrePerFoot, new Guid("1767c385-e868-457a-b0be-aac0a4db42ff")},  // newton centimetre per foot
         {UnitChoicesEnum.NewtonMillimetrePerFoot, new Guid("ba4691ad-7575-4b9d-a6c6-9c98dde239ca")},  // newton millimetre per foot
         {UnitChoicesEnum.InchPoundPerFoot, new Guid("d5f1dfc6-80ec-4780-a4ad-8df68c179eee")},  // inch pound per foot
         {UnitChoicesEnum.NewtonMetrePerInch, new Guid("394cc997-ae71-47d1-91be-8aa69fdb71d7")},  // Newton metre per inch
         {UnitChoicesEnum.DecanewtonMetrePerInch, new Guid("1f8786b1-4aae-45b9-9875-7fe63bddb6cb")},  // decanewton metre per inch
         {UnitChoicesEnum.KilogramForceMetrePerInch, new Guid("df62fa6d-b983-4960-ad7b-853e00ccf45c")},  // kilogram force metre per inch
         {UnitChoicesEnum.KilonewtonMetrePerInch, new Guid("cbc02a54-98e8-4b10-a028-152a5c92f2ce")},  // kilonewton metre per inch
         {UnitChoicesEnum.FootPoundPerInch, new Guid("9c9771ff-d194-4e9f-b663-7f817da4d207")},  // foot pound per inch
         {UnitChoicesEnum.KilofootPoundPerInch, new Guid("70978437-cf05-4138-8389-ec633fdc1fce")},  // kilofoot pound per inch
         {UnitChoicesEnum.NewtonDecimetrePerInch, new Guid("0f34a9e2-dc04-4ce7-ac42-6cc12e2c98b5")},  // newton decimetre per inch
         {UnitChoicesEnum.NewtonCentimetrePerInch, new Guid("622d36f4-6fed-4d16-a246-14477f724bca")},  // newton centimetre per inch
         {UnitChoicesEnum.NewtonMillimetrePerInch, new Guid("31169945-1b67-4225-a2c6-6e850c39cb2f")},  // newton millimetre per inch
         {UnitChoicesEnum.InchPoundPerInch, new Guid("2e16e0be-2037-413d-9f43-6316a24d1fca")} // inch pound per inch
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
  public partial class TorqueQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonMetre,  // newton metre
         DecanewtonMetre,  // decanewton metre
         KilogramForceMetre,  // kilogram force metre
         KilonewtonMetre,  // kilonewton metre
         FootPound,  // foot pound
         KilofootPound,  // kilofoot pound
         NewtonDecimetre,  // newton decimetre
         NewtonCentimetre,  // newton centimetre
         NewtonMillimetre,  // newton millimetre
         InchPound // inch pound
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonMetre, new Guid("50b017fa-8d81-4076-a485-61de1d8301b5")},  // newton metre
         {UnitChoicesEnum.DecanewtonMetre, new Guid("501ce02c-8a5d-46e6-9ab6-ce443df70402")},  // decanewton metre
         {UnitChoicesEnum.KilogramForceMetre, new Guid("282f97a0-df2a-4016-9ab0-796db49ff384")},  // kilogram force metre
         {UnitChoicesEnum.KilonewtonMetre, new Guid("2e417a6e-1acc-4901-8704-7dfeb3f67546")},  // kilonewton metre
         {UnitChoicesEnum.FootPound, new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51")},  // foot pound
         {UnitChoicesEnum.KilofootPound, new Guid("ee9be6ed-df75-4915-be6a-e3941dacd6bd")},  // kilofoot pound
         {UnitChoicesEnum.NewtonDecimetre, new Guid("e70db590-c5fb-4ab9-a2c4-3ad611cb7f63")},  // newton decimetre
         {UnitChoicesEnum.NewtonCentimetre, new Guid("4acf4542-8df0-4f57-a852-7c0184dbeec9")},  // newton centimetre
         {UnitChoicesEnum.NewtonMillimetre, new Guid("a933225d-7c8e-4ce4-b0ea-4c1c6e9f7e34")},  // newton millimetre
         {UnitChoicesEnum.InchPound, new Guid("0d40553e-d8c4-4b75-ad05-61199b15a0a1")} // inch pound
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
  public partial class VelocityQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerSecond,  // metre per second
         MetrePerMinute,  // metre per minute
         CentimetrePerSecond,  // centimetre per second
         MetrePerHour,  // metre per hour
         MetrePerDay,  // metre per day
         FootPerHour,  // foot per hour
         FootPerDay,  // foot per day
         FootPerMinute,  // foot per minute
         FootPerSecond,  // foot per second
         InchPerSecond,  // inch per second
         MilePerHour,  // mile per hour
         KilometrePerHour,  // kilometre per hour
         KilometrePerMinute,  // kilometre per minute
         KilometrePerSecond,  // kilometre per second
         KilometrePerDay,  // kilometre per day
         MilePerMinute,  // mile per minute
         MilePerSecond,  // mile per second
         MilePerDay,  // mile per day
         InchPerMinute,  // inch per minute
         InchPerHour,  // inch per hour
         InchPerDay,  // inch per day
         CentimetrePerMinute,  // centimetre per minute
         CentimetrePerHour,  // centimetre per hour
         CentimetrePerDay,  // centimetre per day
         MillimetrePerSecond,  // millimetre per second
         MillimetrePerMinute,  // millimetre per minute
         MillimetrePerHour,  // millimetre per hour
         MillimetrePerDay,  // millimetre per day
         DecimetrePerSecond,  // decimetre per second
         DecimetrePerMinute,  // decimetre per minute
         DecimetrePerHour,  // decimetre per hour
         DecimetrePerDay,  // decimetre per day
         FurlongPerFortnight // furlong per fortnight
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // metre per second
         {UnitChoicesEnum.MetrePerMinute, new Guid("824d3b5b-1e51-446a-99a4-39c02377f303")},  // metre per minute
         {UnitChoicesEnum.CentimetrePerSecond, new Guid("d32f84d7-f076-49ab-8bd5-1ccd27e0eba6")},  // centimetre per second
         {UnitChoicesEnum.MetrePerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // metre per hour
         {UnitChoicesEnum.MetrePerDay, new Guid("aa10055f-1ef6-460d-841c-b6dc69f6a7f2")},  // metre per day
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")},  // foot per hour
         {UnitChoicesEnum.FootPerDay, new Guid("aa58ec87-0dbc-4ed4-b8aa-8553b02c7b14")},  // foot per day
         {UnitChoicesEnum.FootPerMinute, new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076")},  // foot per minute
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")},  // foot per second
         {UnitChoicesEnum.InchPerSecond, new Guid("8cd16c97-5c7a-4ee9-b59b-cbe2decd8ff9")},  // inch per second
         {UnitChoicesEnum.MilePerHour, new Guid("6c6d0be3-5b60-4b8a-9fd6-8b7afb261081")},  // mile per hour
         {UnitChoicesEnum.KilometrePerHour, new Guid("a1bab5e0-221c-4555-bd37-cf2b8004fd53")},  // kilometre per hour
         {UnitChoicesEnum.KilometrePerMinute, new Guid("b37519e1-5d78-4d34-ad7b-37bc3f0bc775")},  // kilometre per minute
         {UnitChoicesEnum.KilometrePerSecond, new Guid("3944bb76-5675-49bf-ae2f-143d3ff8e41a")},  // kilometre per second
         {UnitChoicesEnum.KilometrePerDay, new Guid("2d09bf7b-0f99-42c0-9732-f9923c11bde1")},  // kilometre per day
         {UnitChoicesEnum.MilePerMinute, new Guid("959dcb48-193b-48a9-9b86-554ea6b6e755")},  // mile per minute
         {UnitChoicesEnum.MilePerSecond, new Guid("5ec77a90-200b-4e6e-877b-8df0edb7adc2")},  // mile per second
         {UnitChoicesEnum.MilePerDay, new Guid("340ef6b0-53c2-447c-b8dd-f8f184bce71d")},  // mile per day
         {UnitChoicesEnum.InchPerMinute, new Guid("d6421f59-0d0f-49e3-9f2c-37590569beb4")},  // inch per minute
         {UnitChoicesEnum.InchPerHour, new Guid("06115ddb-4f51-41cd-a502-8c4f443d66b2")},  // inch per hour
         {UnitChoicesEnum.InchPerDay, new Guid("38991fcc-56f6-4447-bd1e-86159681e8d0")},  // inch per day
         {UnitChoicesEnum.CentimetrePerMinute, new Guid("b52fb69d-f8f7-4e46-9223-626e7497854d")},  // centimetre per minute
         {UnitChoicesEnum.CentimetrePerHour, new Guid("9a4d693e-cb18-4587-a465-48aec69369bf")},  // centimetre per hour
         {UnitChoicesEnum.CentimetrePerDay, new Guid("d34eba86-b8e2-4f28-92bb-8a26132ccfc6")},  // centimetre per day
         {UnitChoicesEnum.MillimetrePerSecond, new Guid("8d787bbf-81b0-4ba4-b913-c71cfe4b7025")},  // millimetre per second
         {UnitChoicesEnum.MillimetrePerMinute, new Guid("87a2da8b-a5e8-43f4-af18-859f6e8dc822")},  // millimetre per minute
         {UnitChoicesEnum.MillimetrePerHour, new Guid("4628ccfb-2837-40b3-9141-222af23fa7be")},  // millimetre per hour
         {UnitChoicesEnum.MillimetrePerDay, new Guid("c1540a11-a20e-43e2-9d1b-e173b928c94b")},  // millimetre per day
         {UnitChoicesEnum.DecimetrePerSecond, new Guid("0f9aa2e1-b66f-4728-bf57-79526ffce563")},  // decimetre per second
         {UnitChoicesEnum.DecimetrePerMinute, new Guid("980c51cc-a185-44a6-a69c-34f52e2b1fe2")},  // decimetre per minute
         {UnitChoicesEnum.DecimetrePerHour, new Guid("1d3b5a3c-81ff-4698-b92f-9b721f946220")},  // decimetre per hour
         {UnitChoicesEnum.DecimetrePerDay, new Guid("dcb77826-7550-4681-b3ce-a59cfdb7620d")},  // decimetre per day
         {UnitChoicesEnum.FurlongPerFortnight, new Guid("028ad001-b80d-49d8-8d18-8e10c1f0239f")} // furlong per fortnight
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
  public partial class VolumeQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetre,  // cubic metre
         Litre,  // litre
         Decilitre,  // decilitre
         Centilitre,  // centilitre
         Millilitre,  // millilitre
         USGallon,  // US gallon
         UKGallon,  // UK gallon
         Barrel,  // barrel
         MillionCubicMetre,  // million cubic metre
         MillionLitre,  // million litre
         MillionUKGallon,  // million UK gallon
         MillionBarrel,  // million barrel
         ThousandStandardCubicFoot,  // thousand standard cubic foot
         MillionStandardCubicFoot,  // million standard cubic foot
         CubicFoot,  // cubic foot
         CubicInch,  // cubic inch
         MillionUSGallon // million US gallon
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetre, new Guid("a465ba87-53d6-456c-8e74-315a1a212498")},  // cubic metre
         {UnitChoicesEnum.Litre, new Guid("3f713743-6248-4b0b-8f3b-c97b6fab76b1")},  // litre
         {UnitChoicesEnum.Decilitre, new Guid("3d7dde61-a9e9-4df6-8ee4-1eb4a4be1147")},  // decilitre
         {UnitChoicesEnum.Centilitre, new Guid("8d9baa02-5c3e-46f8-b909-7ca92d7bfa7a")},  // centilitre
         {UnitChoicesEnum.Millilitre, new Guid("6eb0d045-36e5-448d-be94-96a24a03f3e6")},  // millilitre
         {UnitChoicesEnum.USGallon, new Guid("1377d8ac-d203-48ed-bad4-733b0dc9d496")},  // US gallon
         {UnitChoicesEnum.UKGallon, new Guid("78f1cef7-c489-498c-96fb-d37474e242a9")},  // UK gallon
         {UnitChoicesEnum.Barrel, new Guid("b0f03925-d158-48ee-8c33-bf72c08cae68")},  // barrel
         {UnitChoicesEnum.MillionCubicMetre, new Guid("4c021db5-327b-44d3-9c4f-5a9b84af602f")},  // million cubic metre
         {UnitChoicesEnum.MillionLitre, new Guid("4f3f67df-28af-4398-966f-b23de678f50c")},  // million litre
         {UnitChoicesEnum.MillionUKGallon, new Guid("ab9a2938-f519-47c0-bcaa-d61c8fa23c7b")},  // million UK gallon
         {UnitChoicesEnum.MillionBarrel, new Guid("9d03120c-2c74-4666-8e24-98e143ab88db")},  // million barrel
         {UnitChoicesEnum.ThousandStandardCubicFoot, new Guid("e50b6a47-cf4c-4a74-8c1c-758000df5d67")},  // thousand standard cubic foot
         {UnitChoicesEnum.MillionStandardCubicFoot, new Guid("387b78ff-d51b-4684-b059-4c813407d767")},  // million standard cubic foot
         {UnitChoicesEnum.CubicFoot, new Guid("1da2384d-f463-4b08-9c0b-1de06b51268c")},  // cubic foot
         {UnitChoicesEnum.CubicInch, new Guid("dacec282-dacd-4687-9943-8fa741124116")},  // cubic inch
         {UnitChoicesEnum.MillionUSGallon, new Guid("a1d1c28d-8d55-417e-93af-e7302b68ed13")} // million US gallon
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
  public partial class VolumetricFlowRateOfChangeQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetrePerSecondSquared,  // cubic metre per second squared
         LitrePerMinuteSquared,  // litre per minute squared
         LitrePerMinutePerSecond,  // litre per minute per second
         LitrePerSecondSquared,  // litre per second squared
         UKGallonPerMinuteSquared,  // UK gallon per minute squared
         UKGallonPerMinutePerSecond,  // UK gallon per minute per second
         USGallonPerMinuteSquared,  // US gallon per minute squared
         USGallonPerMinutePerSecond // US gallon per minute per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetrePerSecondSquared, new Guid("aef20431-be0b-44ea-8770-a59db19b7f94")},  // cubic metre per second squared
         {UnitChoicesEnum.LitrePerMinuteSquared, new Guid("b27d2f54-a1f3-4abb-ba6d-a2a8b530049a")},  // litre per minute squared
         {UnitChoicesEnum.LitrePerMinutePerSecond, new Guid("e5a265b6-a9ba-4a09-ba08-b8c417b28ffb")},  // litre per minute per second
         {UnitChoicesEnum.LitrePerSecondSquared, new Guid("a899c06f-18dd-4d2a-9743-489f0af5be91")},  // litre per second squared
         {UnitChoicesEnum.UKGallonPerMinuteSquared, new Guid("c7c61175-e527-4403-8425-32f681367985")},  // UK gallon per minute squared
         {UnitChoicesEnum.UKGallonPerMinutePerSecond, new Guid("298e7a16-07a5-4b5b-a0de-3e49b31254b4")},  // UK gallon per minute per second
         {UnitChoicesEnum.USGallonPerMinuteSquared, new Guid("61885289-823d-4b26-bdf2-bc4744567bef")},  // US gallon per minute squared
         {UnitChoicesEnum.USGallonPerMinutePerSecond, new Guid("3c530e9a-9376-49d1-a6b5-0a6f93f4184b")} // US gallon per minute per second
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
  public partial class VolumetricFlowRateQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetrePerSecond,  // cubic metre per second
         LitrePerSecond,  // litre per second
         CubicFootPerSecond,  // cubic foot per second
         UKGallonPerSecond,  // UK gallon per second
         USGallonPerSecond,  // US gallon per second
         BarrelPerSecond,  // barrel per second
         CubicMetrePerMinute,  // cubic metre per minute
         LitrePerMinute,  // litre per minute
         CubicFootPerMinute,  // cubic foot per minute
         UKGallonPerMinute,  // UK gallon per minute
         USGallonPerMinute,  // US gallon per minute
         BarrelPerMinute,  // barrel per minute
         CubicMetrePerHour,  // cubic metre per hour
         LitrePerHour,  // litre per hour
         CubicFootPerHour,  // cubic foot per hour
         UKGallonPerHour,  // UK gallon per hour
         USGallonPerHour,  // US gallon per hour
         BarrelPerHour,  // barrel per hour
         CubicMetrePerDay,  // cubic metre per day
         MillionCubicMetrePerDay,  // million cubic metre per day
         UKGallonPerDay,  // UK gallon per day
         USGallonPerDay,  // US gallon per day
         MillionUKGallonPerDay,  // million UK gallon per day
         MillionUSGallonPerDay,  // million US gallon per day
         LitrePerDay,  // litre per day
         MillionLiterPerDay,  // million liter per day
         CubicFootPerDay,  // cubic foot per day
         ThousandStandardCubicFootPerDay,  // thousand standard cubic foot per day
         MillionStandardCubicFootPerDay,  // million standard cubic foot per day
         BarrelPerDay,  // barrel per day
         CubicMetrePerYear,  // cubic metre per year
         LitrePerYear,  // litre per year
         CubicFootPerYear,  // cubic foot per year
         UKGallonPerYear,  // UK gallon per year
         USGallonPerYear,  // US gallon per year
         BarrelPerYear // barrel per year
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetrePerSecond, new Guid("fabe7a23-1ba2-4f5d-b3f5-d5729166c7a0")},  // cubic metre per second
         {UnitChoicesEnum.LitrePerSecond, new Guid("6dafb683-0f61-42ba-a22c-7bd5c9cea4ae")},  // litre per second
         {UnitChoicesEnum.CubicFootPerSecond, new Guid("a02fc355-34da-447b-ad1f-66cef4cc96d5")},  // cubic foot per second
         {UnitChoicesEnum.UKGallonPerSecond, new Guid("21ca44f5-ed4e-414d-b285-b38730600794")},  // UK gallon per second
         {UnitChoicesEnum.USGallonPerSecond, new Guid("21fe7e3a-bf92-4c94-b6d7-e2d30dfc4cd3")},  // US gallon per second
         {UnitChoicesEnum.BarrelPerSecond, new Guid("a73caac6-062e-4f79-8374-8fb2598b6842")},  // barrel per second
         {UnitChoicesEnum.CubicMetrePerMinute, new Guid("98eec130-224c-457a-a5dd-50b55a3a28ab")},  // cubic metre per minute
         {UnitChoicesEnum.LitrePerMinute, new Guid("e1ff1684-02ed-41c0-a82c-40b4a6d348b5")},  // litre per minute
         {UnitChoicesEnum.CubicFootPerMinute, new Guid("a81e08db-d8fd-4379-bc8e-c223c3fb71b3")},  // cubic foot per minute
         {UnitChoicesEnum.UKGallonPerMinute, new Guid("bb1d3fbc-efc1-4cf7-9c13-33c25a874224")},  // UK gallon per minute
         {UnitChoicesEnum.USGallonPerMinute, new Guid("ceca76e7-fd1e-4220-b072-9f40467a05e3")},  // US gallon per minute
         {UnitChoicesEnum.BarrelPerMinute, new Guid("3672c640-3924-4921-861b-d14c99643615")},  // barrel per minute
         {UnitChoicesEnum.CubicMetrePerHour, new Guid("d6607bed-0235-4838-87c8-2ff6c76be2ad")},  // cubic metre per hour
         {UnitChoicesEnum.LitrePerHour, new Guid("fe2d8a01-fd2b-4652-80bd-f0da2ce990fd")},  // litre per hour
         {UnitChoicesEnum.CubicFootPerHour, new Guid("54f30d1c-670a-4566-bfb2-3ce644d68878")},  // cubic foot per hour
         {UnitChoicesEnum.UKGallonPerHour, new Guid("85d47672-e1ce-4b33-be1d-eabc2ec1c4c1")},  // UK gallon per hour
         {UnitChoicesEnum.USGallonPerHour, new Guid("36892d41-4a11-4d32-9a8c-1e43ac1f8c6d")},  // US gallon per hour
         {UnitChoicesEnum.BarrelPerHour, new Guid("af1bd583-3a13-4d3a-8f65-ede4f8fe9789")},  // barrel per hour
         {UnitChoicesEnum.CubicMetrePerDay, new Guid("f512755c-166c-4346-a0f7-74f09703410f")},  // cubic metre per day
         {UnitChoicesEnum.MillionCubicMetrePerDay, new Guid("d09b4db7-9fbe-4018-aeb7-15286ccff8d6")},  // million cubic metre per day
         {UnitChoicesEnum.UKGallonPerDay, new Guid("334cf647-375e-4423-8ef4-e1171f938f9a")},  // UK gallon per day
         {UnitChoicesEnum.USGallonPerDay, new Guid("c0a47cc8-8ba1-47a1-ab94-d3e4361dd063")},  // US gallon per day
         {UnitChoicesEnum.MillionUKGallonPerDay, new Guid("f083576e-1d99-4243-bcfa-5ca6093b6931")},  // million UK gallon per day
         {UnitChoicesEnum.MillionUSGallonPerDay, new Guid("ffe9958a-3daa-472d-87ab-0b1217dcb1c5")},  // million US gallon per day
         {UnitChoicesEnum.LitrePerDay, new Guid("67628fe2-6a64-4ea6-94fe-5a34e7568b53")},  // litre per day
         {UnitChoicesEnum.MillionLiterPerDay, new Guid("1889c1dd-5aa3-45fe-b6cb-79a760e44832")},  // million liter per day
         {UnitChoicesEnum.CubicFootPerDay, new Guid("6b9a886b-b96a-473b-8dea-e850583ad5d8")},  // cubic foot per day
         {UnitChoicesEnum.ThousandStandardCubicFootPerDay, new Guid("627a75ed-2ab8-480a-96be-b9266d34ba5d")},  // thousand standard cubic foot per day
         {UnitChoicesEnum.MillionStandardCubicFootPerDay, new Guid("f1c76ab3-8e54-4ad1-a7fe-a09be2a61285")},  // million standard cubic foot per day
         {UnitChoicesEnum.BarrelPerDay, new Guid("9d36ce54-5bdc-4f4b-9948-dd65c58c9db3")},  // barrel per day
         {UnitChoicesEnum.CubicMetrePerYear, new Guid("f0e95734-b6a0-4081-b022-8c5bc0e7dd64")},  // cubic metre per year
         {UnitChoicesEnum.LitrePerYear, new Guid("d2b8abd2-cd97-4933-8e0a-54d8a4eef7ce")},  // litre per year
         {UnitChoicesEnum.CubicFootPerYear, new Guid("5ae7fcd3-fae0-4d81-abca-4c3d36d49e6d")},  // cubic foot per year
         {UnitChoicesEnum.UKGallonPerYear, new Guid("b7f54c43-a2ee-4b27-bccb-4c0e752e4caf")},  // UK gallon per year
         {UnitChoicesEnum.USGallonPerYear, new Guid("94558d1e-fbe2-4f06-a985-44210a1f0bc8")},  // US gallon per year
         {UnitChoicesEnum.BarrelPerYear, new Guid("0360ea30-fbf5-4dda-bf99-670dd6983420")} // barrel per year
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
  public partial class WaveNumberQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         ReciprocalMetre,  // reciprocal metre
         ReciprocalDecimetre,  // reciprocal decimetre
         ReciprocalCentimetre,  // reciprocal centimetre
         ReciprocalMillimetre,  // reciprocal millimetre
         ReciprocalMicrometre,  // reciprocal micrometre
         ReciprocalNanometre,  // reciprocal nanometre
         ReciprocalÅngstrøm,  // reciprocal ångstrøm
         ReciprocalPicometre,  // reciprocal picometre
         ReciprocalDecametre,  // reciprocal decametre
         ReciprocalHectometre,  // reciprocal hectometre
         ReciprocalKilometre,  // reciprocal kilometre
         ReciprocalAstronomicalUnit,  // reciprocal astronomical unit
         ReciprocalLightYear,  // reciprocal light year
         ReciprocalParsec,  // reciprocal parsec
         ReciprocalFoot,  // reciprocal foot
         ReciprocalUSSurveyFoot,  // reciprocal US survey foot
         ReciprocalInch,  // reciprocal inch
         ReciprocalYard,  // reciprocal yard
         ReciprocalFathom,  // reciprocal fathom
         ReciprocalSurveyorsChain,  // reciprocal surveyors chain
         ReciprocalMile,  // reciprocal mile
         ReciprocalInternationalNauticalMile,  // reciprocal international nautical mile
         ReciprocalUKNauticalMile,  // reciprocal UK nautical mile
         ReciprocalScandinavianMile,  // reciprocal scandinavian mile
         ReciprocalInchPer32,  // reciprocal inch per 32
         ReciprocalMil,  // reciprocal mil
         ReciprocalThou,  // reciprocal thou
         ReciprocalHand,  // reciprocal hand
         ReciprocalFurlong // reciprocal furlong
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.ReciprocalMetre, new Guid("3cd38922-b99f-45bb-af6e-a38ebf1240f0")},  // reciprocal metre
         {UnitChoicesEnum.ReciprocalDecimetre, new Guid("cf8a931b-eaa9-4b0c-8894-53d54e93cba1")},  // reciprocal decimetre
         {UnitChoicesEnum.ReciprocalCentimetre, new Guid("4f2c38c2-86ff-4842-afdd-3a9fcf8a623e")},  // reciprocal centimetre
         {UnitChoicesEnum.ReciprocalMillimetre, new Guid("2d484d0f-7d29-48e9-8d5b-ff82fca6f1c5")},  // reciprocal millimetre
         {UnitChoicesEnum.ReciprocalMicrometre, new Guid("ddbbb734-ddd2-4d26-84ba-9995fff479e6")},  // reciprocal micrometre
         {UnitChoicesEnum.ReciprocalNanometre, new Guid("25412abd-9c3e-4b67-b809-d92926eb2b58")},  // reciprocal nanometre
         {UnitChoicesEnum.ReciprocalÅngstrøm, new Guid("7c28c943-c084-48f6-804c-87e6c6902b35")},  // reciprocal ångstrøm
         {UnitChoicesEnum.ReciprocalPicometre, new Guid("bca4fde9-e17a-4a27-9a3f-34beab644ee2")},  // reciprocal picometre
         {UnitChoicesEnum.ReciprocalDecametre, new Guid("a691338d-1916-4355-b6e1-3b1bff086c14")},  // reciprocal decametre
         {UnitChoicesEnum.ReciprocalHectometre, new Guid("4da19df4-0ff6-424b-a2ab-9d5811ba48ca")},  // reciprocal hectometre
         {UnitChoicesEnum.ReciprocalKilometre, new Guid("a4b4ed8e-a1c6-4e3f-9421-8770cec6ff42")},  // reciprocal kilometre
         {UnitChoicesEnum.ReciprocalAstronomicalUnit, new Guid("4d58ee46-e637-4f5a-a1ff-33f002154fec")},  // reciprocal astronomical unit
         {UnitChoicesEnum.ReciprocalLightYear, new Guid("81c8c5d9-a892-4702-921b-9946abbef6b0")},  // reciprocal light year
         {UnitChoicesEnum.ReciprocalParsec, new Guid("b8f6a954-7fe6-4f31-94cc-e53bb5603cd5")},  // reciprocal parsec
         {UnitChoicesEnum.ReciprocalFoot, new Guid("1d6a5284-d32f-4f5a-ad27-bfc0f71069aa")},  // reciprocal foot
         {UnitChoicesEnum.ReciprocalUSSurveyFoot, new Guid("16c3f209-e890-4b35-807e-7115545406e0")},  // reciprocal US survey foot
         {UnitChoicesEnum.ReciprocalInch, new Guid("95cd773d-b6da-4148-bd9c-bed66b4a72d8")},  // reciprocal inch
         {UnitChoicesEnum.ReciprocalYard, new Guid("be5f64c0-592a-4f3b-b2b5-6df8b9d2a31b")},  // reciprocal yard
         {UnitChoicesEnum.ReciprocalFathom, new Guid("ae9e314e-de19-405e-a897-6a68cd4845f6")},  // reciprocal fathom
         {UnitChoicesEnum.ReciprocalSurveyorsChain, new Guid("90da0d97-195c-4c30-85d8-51d70b75f071")},  // reciprocal surveyors chain
         {UnitChoicesEnum.ReciprocalMile, new Guid("acbb10a5-602f-423b-bc15-bdfd80cb7008")},  // reciprocal mile
         {UnitChoicesEnum.ReciprocalInternationalNauticalMile, new Guid("78474000-3cd8-4102-b7b4-360b4c2130fc")},  // reciprocal international nautical mile
         {UnitChoicesEnum.ReciprocalUKNauticalMile, new Guid("8a55784f-b5f4-4aa7-b5f9-d19742857349")},  // reciprocal UK nautical mile
         {UnitChoicesEnum.ReciprocalScandinavianMile, new Guid("f766575d-9bfa-45fb-8bfd-50f12a0e6a6a")},  // reciprocal scandinavian mile
         {UnitChoicesEnum.ReciprocalInchPer32, new Guid("ac9c8b52-22f0-476d-a038-023695c24f25")},  // reciprocal inch per 32
         {UnitChoicesEnum.ReciprocalMil, new Guid("09d27104-6452-4976-98e0-6fd087e22eb1")},  // reciprocal mil
         {UnitChoicesEnum.ReciprocalThou, new Guid("e732fd46-ddf3-433e-8baf-cc531ca69160")},  // reciprocal thou
         {UnitChoicesEnum.ReciprocalHand, new Guid("844ed023-9f47-4147-8b50-cf03c99071b5")},  // reciprocal hand
         {UnitChoicesEnum.ReciprocalFurlong, new Guid("79a3f3db-0ac8-4bcb-b93c-fca2a673147b")} // reciprocal furlong
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
  public partial class MassQuantity : SymbolizedBasePhysicalQuantity
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
         Kilopound,  // kilopound
         Ounce,  // ounce
         Stone,  // stone
         TonUK,  // ton UK
         TonUS,  // ton US
         SolarMass,  // solar mass
         EarthMass,  // earth mass
         Grain,  // grain
         HundredWeights // hundred weights
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
         {UnitChoicesEnum.Kilopound, new Guid("777ff8ee-edc2-46d1-ac40-f097c1e1cd69")},  // kilopound
         {UnitChoicesEnum.Ounce, new Guid("4e64e69b-2276-46c8-a918-06ab6980178c")},  // ounce
         {UnitChoicesEnum.Stone, new Guid("6894dc1c-21e2-42aa-9569-759c0e6e6d6e")},  // stone
         {UnitChoicesEnum.TonUK, new Guid("059c7b81-ed11-410e-9466-4661011372d2")},  // ton UK
         {UnitChoicesEnum.TonUS, new Guid("443af797-a62f-4137-a852-ad1c9163dd7b")},  // ton US
         {UnitChoicesEnum.SolarMass, new Guid("432e73bf-a448-47f6-9c65-9339d5bac5a3")},  // solar mass
         {UnitChoicesEnum.EarthMass, new Guid("f9303406-dfce-45c4-9a1e-299d9bac1d4e")},  // earth mass
         {UnitChoicesEnum.Grain, new Guid("dad9b0a5-ce14-4132-b571-6365ab336bc2")},  // grain
         {UnitChoicesEnum.HundredWeights, new Guid("83810f2a-b260-41b3-bc13-5ef60290f214")} // hundred weights
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
  public partial class EnergyQuantity : DerivedBasePhysicalQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Joule,  // joule
         Kilojoule,  // kilojoule
         Megajoule,  // megajoule
         Gigajoule,  // gigajoule
         Calorie,  // calorie
         Kilocalorie,  // kilocalorie
         BritishThermalUnit,  // british thermal unit
         KiloBritishThermalUnit,  // kilo british thermal unit
         MegaBritishThermalUnit // mega british thermal unit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Joule, new Guid("c653b7de-0386-467c-8d25-60bb0f6a7076")},  // joule
         {UnitChoicesEnum.Kilojoule, new Guid("4b0cf63a-84af-4232-b7a1-7531ec1d47b0")},  // kilojoule
         {UnitChoicesEnum.Megajoule, new Guid("c4fdba05-7269-4098-8b33-bd8e50c67126")},  // megajoule
         {UnitChoicesEnum.Gigajoule, new Guid("c8781145-3c6c-4d87-9567-b0e6ec2821a2")},  // gigajoule
         {UnitChoicesEnum.Calorie, new Guid("3f020e89-3146-4f3f-9b9b-eecda4400b12")},  // calorie
         {UnitChoicesEnum.Kilocalorie, new Guid("e4e916fe-9e79-47c9-97e5-3e8458358578")},  // kilocalorie
         {UnitChoicesEnum.BritishThermalUnit, new Guid("8548500e-e3a9-4e36-aecb-024836b8a012")},  // british thermal unit
         {UnitChoicesEnum.KiloBritishThermalUnit, new Guid("b8e1ba3f-d374-4220-85a6-7a066d91dd26")},  // kilo british thermal unit
         {UnitChoicesEnum.MegaBritishThermalUnit, new Guid("329c7fef-b5da-489f-a973-9ec2efb82a19")} // mega british thermal unit
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
  public partial class DiameterSmallQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Centimetre,  // centimetre
         Decimetre,  // decimetre
         Foot,  // foot
         Inch,  // inch
         Metre,  // metre
         Micrometre,  // micrometre
         Millimetre,  // millimetre
         Nanometre,  // nanometre
         Picometre,  // picometre
         Ångstrøm,  // ångstrøm
         InchPer32 // inch per 32
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimetre, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimetre
         {UnitChoicesEnum.Decimetre, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimetre
         {UnitChoicesEnum.Foot, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // foot
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometre, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometre
         {UnitChoicesEnum.Millimetre, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimetre
         {UnitChoicesEnum.Nanometre, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometre
         {UnitChoicesEnum.Picometre, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometre
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.InchPer32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")} // inch per 32
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
  public partial class DimensionLessStandardQuantity : DimensionlessQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Dimensionless // dimensionless
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Dimensionless, new Guid("8744b0f7-2866-42d8-bf6c-b619ac87b945")} // dimensionless
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
         Tesla,  // tesla
         Gauss,  // gauss
         Milligauss,  // milligauss
         Microtesla,  // microtesla
         Nanotesla // nanotesla
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Tesla, new Guid("33c3b59d-9876-4918-9f31-f22de88d7bde")},  // tesla
         {UnitChoicesEnum.Gauss, new Guid("c09cd87d-8a84-45d0-88d3-20bb5cc48559")},  // gauss
         {UnitChoicesEnum.Milligauss, new Guid("41ace729-a2ff-4047-adc3-375829de64c6")},  // milligauss
         {UnitChoicesEnum.Microtesla, new Guid("c6b30197-be6b-41b7-803d-a8de61338612")},  // microtesla
         {UnitChoicesEnum.Nanotesla, new Guid("9bef9def-8cd3-4f7b-b991-290d3441b3d4")} // nanotesla
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
  public partial class ElasticModulusQuantity : PressureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // pascal
         Megapascal,  // megapascal
         Gigapascal,  // gigapascal
         PoundPerSquareInch,  // pound per square inch
         MegapoundPerSquareInch // megapound per square inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // pascal
         {UnitChoicesEnum.Megapascal, new Guid("4ef28797-f416-4d97-b36a-711ea848bcc0")},  // megapascal
         {UnitChoicesEnum.Gigapascal, new Guid("5c81fb9b-36ad-47b7-9a8e-c999f7fdbfe3")},  // gigapascal
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // pound per square inch
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("bb49de0a-fbf3-4914-b6b9-fc60ab502522")} // megapound per square inch
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
  public partial class LengthSmallQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Centimetre,  // centimetre
         Decimetre,  // decimetre
         Foot,  // foot
         Inch,  // inch
         Metre,  // metre
         Micrometre,  // micrometre
         Millimetre,  // millimetre
         Nanometre,  // nanometre
         Picometre,  // picometre
         Ångstrøm,  // ångstrøm
         InchPer32 // inch per 32
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimetre, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimetre
         {UnitChoicesEnum.Decimetre, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimetre
         {UnitChoicesEnum.Foot, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // foot
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometre, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometre
         {UnitChoicesEnum.Millimetre, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimetre
         {UnitChoicesEnum.Nanometre, new Guid("0d181caf-8121-46a8-bfa7-2cb7457d9db9")},  // nanometre
         {UnitChoicesEnum.Picometre, new Guid("f305ce05-7bd1-4d67-a834-e9b932ca586e")},  // picometre
         {UnitChoicesEnum.Ångstrøm, new Guid("0db6a73f-c58f-415c-ac0d-e56137b28d5a")},  // ångstrøm
         {UnitChoicesEnum.InchPer32, new Guid("758ae28a-7484-4e0c-91af-aa105bcd744f")} // inch per 32
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
  public partial class RotationalFrequencyQuantity : FrequencyQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // hertz
         Rpm // rpm
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("7c572c06-0699-4187-9d0c-397f479fe93d")},  // hertz
         {UnitChoicesEnum.Rpm, new Guid("30880b5f-803d-412e-9736-62dca3ba5bbd")} // rpm
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
         Kilopound,  // kilopound
         TonUK // ton UK
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Kilogram, new Guid("ef4c5fc1-8774-4aea-b772-35aeae56413d")},  // kilogram
         {UnitChoicesEnum.TonneMetric, new Guid("320b99ba-3115-42f5-939c-15a04d9e7e3c")},  // tonne metric
         {UnitChoicesEnum.Pound, new Guid("e9e313ad-cb28-43fe-93fd-7f94dfee1878")},  // pound
         {UnitChoicesEnum.Kilopound, new Guid("777ff8ee-edc2-46d1-ac40-f097c1e1cd69")},  // kilopound
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
         MetrePerSecond,  // metre per second
         MetrePerMinute,  // metre per minute
         MetrePerHour,  // metre per hour
         MetrePerDay,  // metre per day
         FootPerSecond,  // foot per second
         FootPerMinute,  // foot per minute
         FootPerHour,  // foot per hour
         FootPerDay,  // foot per day
         CentimetrePerSecond,  // centimetre per second
         InchPerSecond // inch per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // metre per second
         {UnitChoicesEnum.MetrePerMinute, new Guid("824d3b5b-1e51-446a-99a4-39c02377f303")},  // metre per minute
         {UnitChoicesEnum.MetrePerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // metre per hour
         {UnitChoicesEnum.MetrePerDay, new Guid("aa10055f-1ef6-460d-841c-b6dc69f6a7f2")},  // metre per day
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")},  // foot per second
         {UnitChoicesEnum.FootPerMinute, new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076")},  // foot per minute
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")},  // foot per hour
         {UnitChoicesEnum.FootPerDay, new Guid("aa58ec87-0dbc-4ed4-b8aa-8553b02c7b14")},  // foot per day
         {UnitChoicesEnum.CentimetrePerSecond, new Guid("d32f84d7-f076-49ab-8bd5-1ccd27e0eba6")},  // centimetre per second
         {UnitChoicesEnum.InchPerSecond, new Guid("8cd16c97-5c7a-4ee9-b59b-cbe2decd8ff9")} // inch per second
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
  public partial class VolumeLargeQuantity : VolumeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetre,  // cubic metre
         Litre,  // litre
         USGallon,  // US gallon
         UKGallon,  // UK gallon
         Barrel,  // barrel
         MillionCubicMetre,  // million cubic metre
         MillionLitre,  // million litre
         MillionUKGallon,  // million UK gallon
         MillionBarrel,  // million barrel
         MillionStandardCubicFoot,  // million standard cubic foot
         ThousandStandardCubicFoot // thousand standard cubic foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetre, new Guid("a465ba87-53d6-456c-8e74-315a1a212498")},  // cubic metre
         {UnitChoicesEnum.Litre, new Guid("3f713743-6248-4b0b-8f3b-c97b6fab76b1")},  // litre
         {UnitChoicesEnum.USGallon, new Guid("1377d8ac-d203-48ed-bad4-733b0dc9d496")},  // US gallon
         {UnitChoicesEnum.UKGallon, new Guid("78f1cef7-c489-498c-96fb-d37474e242a9")},  // UK gallon
         {UnitChoicesEnum.Barrel, new Guid("b0f03925-d158-48ee-8c33-bf72c08cae68")},  // barrel
         {UnitChoicesEnum.MillionCubicMetre, new Guid("4c021db5-327b-44d3-9c4f-5a9b84af602f")},  // million cubic metre
         {UnitChoicesEnum.MillionLitre, new Guid("4f3f67df-28af-4398-966f-b23de678f50c")},  // million litre
         {UnitChoicesEnum.MillionUKGallon, new Guid("ab9a2938-f519-47c0-bcaa-d61c8fa23c7b")},  // million UK gallon
         {UnitChoicesEnum.MillionBarrel, new Guid("9d03120c-2c74-4666-8e24-98e143ab88db")},  // million barrel
         {UnitChoicesEnum.MillionStandardCubicFoot, new Guid("387b78ff-d51b-4684-b059-4c813407d767")},  // million standard cubic foot
         {UnitChoicesEnum.ThousandStandardCubicFoot, new Guid("e50b6a47-cf4c-4a74-8c1c-758000df5d67")} // thousand standard cubic foot
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
  public partial class RotationalFrequencyRateOfChangeQuantity : FrequencyRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         HertzPerSecond,  // hertz per second
         RpmPerSecond // rpm per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.HertzPerSecond, new Guid("4d7e4b49-df76-4259-a96c-8c1250d5ecdd")},  // hertz per second
         {UnitChoicesEnum.RpmPerSecond, new Guid("762b5d58-a1ba-40cb-8776-2004613d15fb")} // rpm per second
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
         Newton,  // newton
         Decanewton,  // decanewton
         Kilonewton,  // kilonewton
         Kilodecanewton,  // kilodecanewton
         KilogramForce,  // kilogram force
         PoundForce,  // pound force
         KilopoundForce // kilopound force
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // newton
         {UnitChoicesEnum.Decanewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // decanewton
         {UnitChoicesEnum.Kilonewton, new Guid("e30d6f94-7887-4746-8d4f-eb720239b702")},  // kilonewton
         {UnitChoicesEnum.Kilodecanewton, new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266")},  // kilodecanewton
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // kilogram force
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")},  // pound force
         {UnitChoicesEnum.KilopoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")} // kilopound force
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
  public partial class ProportionStandardQuantity : ProportionQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Proportion,  // proportion
         Percent,  // percent
         PerThousand,  // per thousand
         PartPerMillion // part per million
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Proportion, new Guid("03eb339b-61aa-4b42-aa35-4a20c547fdb9")},  // proportion
         {UnitChoicesEnum.Percent, new Guid("1a825e84-bc53-4da8-a089-118fdf40b8f7")},  // percent
         {UnitChoicesEnum.PerThousand, new Guid("141465a2-9c3c-4dda-82ec-eb35e72250c2")},  // per thousand
         {UnitChoicesEnum.PartPerMillion, new Guid("af33bf27-c3b8-4746-8b08-826ed1d21792")} // part per million
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
  public partial class LengthStandardQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Centimetre,  // centimetre
         Decimetre,  // decimetre
         Foot,  // foot
         Inch,  // inch
         Metre,  // metre
         Micrometre,  // micrometre
         Millimetre // millimetre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Centimetre, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimetre
         {UnitChoicesEnum.Decimetre, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimetre
         {UnitChoicesEnum.Foot, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // foot
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Micrometre, new Guid("60820c6d-d721-49b8-ba40-a75343aa0f2f")},  // micrometre
         {UnitChoicesEnum.Millimetre, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")} // millimetre
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
         Hertz,  // hertz
         ReciprocalSecond // reciprocal second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("7c572c06-0699-4187-9d0c-397f479fe93d")},  // hertz
         {UnitChoicesEnum.ReciprocalSecond, new Guid("39240f8f-8c82-4026-9db7-f72ec60cb4c9")} // reciprocal second
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
         Pascal,  // pascal
         Kilopascal,  // kilopascal
         Bar,  // bar
         PoundPerSquareInch,  // pound per square inch
         PoundPerSquareFoot,  // pound per square foot
         PoundPer100SquareFoot,  // pound per 100 square foot
         DynePerSquareCentimetre // dyne per square centimetre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // pascal
         {UnitChoicesEnum.Kilopascal, new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29")},  // kilopascal
         {UnitChoicesEnum.Bar, new Guid("0d182739-f8f6-47a6-afcb-71feac973307")},  // bar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // pound per square inch
         {UnitChoicesEnum.PoundPerSquareFoot, new Guid("35b28889-c076-4274-b200-cf7732b17aa3")},  // pound per square foot
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("e3b95821-d782-4f12-a492-489cbcd6d2a1")},  // pound per 100 square foot
         {UnitChoicesEnum.DynePerSquareCentimetre, new Guid("04ca59b8-90e1-4903-ac82-ee95cac0ca38")} // dyne per square centimetre
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
  public partial class TorqueSmallQuantity : TorqueQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonMetre,  // newton metre
         FootPound,  // foot pound
         NewtonDecimetre,  // newton decimetre
         NewtonCentimetre,  // newton centimetre
         NewtonMillimetre,  // newton millimetre
         InchPound // inch pound
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonMetre, new Guid("50b017fa-8d81-4076-a485-61de1d8301b5")},  // newton metre
         {UnitChoicesEnum.FootPound, new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51")},  // foot pound
         {UnitChoicesEnum.NewtonDecimetre, new Guid("e70db590-c5fb-4ab9-a2c4-3ad611cb7f63")},  // newton decimetre
         {UnitChoicesEnum.NewtonCentimetre, new Guid("4acf4542-8df0-4f57-a852-7c0184dbeec9")},  // newton centimetre
         {UnitChoicesEnum.NewtonMillimetre, new Guid("a933225d-7c8e-4ce4-b0ea-4c1c6e9f7e34")},  // newton millimetre
         {UnitChoicesEnum.InchPound, new Guid("0d40553e-d8c4-4b75-ad05-61199b15a0a1")} // inch pound
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
  public partial class RotationalFrequencySmallQuantity : RotationalFrequencyQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // hertz
         Rpm // rpm
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("7c572c06-0699-4187-9d0c-397f479fe93d")},  // hertz
         {UnitChoicesEnum.Rpm, new Guid("30880b5f-803d-412e-9736-62dca3ba5bbd")} // rpm
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
  public partial class ProportionSmallQuantity : ProportionQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Proportion,  // proportion
         Percent,  // percent
         PerThousand,  // per thousand
         PartPerMillion // part per million
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Proportion, new Guid("03eb339b-61aa-4b42-aa35-4a20c547fdb9")},  // proportion
         {UnitChoicesEnum.Percent, new Guid("1a825e84-bc53-4da8-a089-118fdf40b8f7")},  // percent
         {UnitChoicesEnum.PerThousand, new Guid("141465a2-9c3c-4dda-82ec-eb35e72250c2")},  // per thousand
         {UnitChoicesEnum.PartPerMillion, new Guid("af33bf27-c3b8-4746-8b08-826ed1d21792")} // part per million
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
  public partial class PorosityQuantity : ProportionQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Proportion,  // proportion
         Percent,  // percent
         PerThousand // per thousand
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Proportion, new Guid("03eb339b-61aa-4b42-aa35-4a20c547fdb9")},  // proportion
         {UnitChoicesEnum.Percent, new Guid("1a825e84-bc53-4da8-a089-118fdf40b8f7")},  // percent
         {UnitChoicesEnum.PerThousand, new Guid("141465a2-9c3c-4dda-82ec-eb35e72250c2")} // per thousand
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
  public partial class StrokeFrequencyQuantity : FrequencyQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // hertz
         Spm // spm
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("7c572c06-0699-4187-9d0c-397f479fe93d")},  // hertz
         {UnitChoicesEnum.Spm, new Guid("426b000b-235f-41d5-8806-b2e47fbfb53b")} // spm
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
  public partial class ShockRateQuantity : FrequencyQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Hertz,  // hertz
         ShockPerMinute,  // shock per minute
         ShockPerHour // shock per hour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Hertz, new Guid("7c572c06-0699-4187-9d0c-397f479fe93d")},  // hertz
         {UnitChoicesEnum.ShockPerMinute, new Guid("6ccbee46-cb8a-4777-b1d2-e88eedd24f73")},  // shock per minute
         {UnitChoicesEnum.ShockPerHour, new Guid("0c0d4ecb-ee11-4b57-9bc7-70860637232e")} // shock per hour
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
