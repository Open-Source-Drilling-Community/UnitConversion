using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillingPhysicalQuantity : BasePhysicalQuantity
  {
     public new enum QuantityEnum 
       {
         AccelerationDrilling,  // AccelerationDrilling
         AngleGradientPerLengthDrilling,  // AngleGradientPerLengthDrilling
         AngleMagneticFluxDensitySurveyInstrumentDrilling,  // AngleMagneticFluxDensitySurveyInstrumentDrilling
         AngularAccelerationDrilling,  // AngularAccelerationDrilling
         AngularVelocityDrilling,  // AngularVelocityDrilling
         AngularVelocitySurveyInstrumentDrilling,  // AngularVelocitySurveyInstrumentDrilling
         AreaDrilling,  // AreaDrilling
         AxialVelocityDrilling,  // AxialVelocityDrilling
         BlockVelocityDrilling,  // BlockVelocityDrilling
         CableDiameterDrilling,  // CableDiameterDrilling
         CapillaryPressureDrilling,  // CapillaryPressureDrilling
         CompressibilityDrilling,  // CompressibilityDrilling
         CurvatureDrilling,  // CurvatureDrilling
         DepthDrilling,  // DepthDrilling
         DiameterPipeDrilling,  // DiameterPipeDrilling
         DiameterPoreDrilling,  // DiameterPoreDrilling
         DrillStemMaterialStrengthDrilling,  // DrillStemMaterialStrengthDrilling
         DrillStringMagneticFluxDrilling,  // DrillStringMagneticFluxDrilling
         DurationDrilling,  // DurationDrilling
         DynamicViscosityDrilling,  // DynamicViscosityDrilling
         ElongationGradientPerLengthDrilling,  // ElongationGradientPerLengthDrilling
         EnergyDensityDrilling,  // EnergyDensityDrilling
         FluidVelocityDrilling,  // FluidVelocityDrilling
         ForceDrilling,  // ForceDrilling
         ForceGradientPerLengthDrilling,  // ForceGradientPerLengthDrilling
         ForceRateOfChangeDrilling,  // ForceRateOfChangeDrilling
         FormationResistivityDrilling,  // FormationResistivityDrilling
         FormationStrengthDrilling,  // FormationStrengthDrilling
         GammaRayIndexDrilling,  // GammaRayIndexDrilling
         GasShowDrilling,  // GasShowDrilling
         GasVolumetricFlowRateDrilling,  // GasVolumetricFlowRateDrilling
         HeatTransferCoefficientDrilling,  // HeatTransferCoefficientDrilling
         HeightDrilling,  // HeightDrilling
         HookLoadDrilling,  // HookLoadDrilling
         HydraulicConductivityDrilling,  // HydraulicConductivityDrilling
         InterfacialTensionDrilling,  // InterfacialTensionDrilling
         IsobaricSpecificHeatCapacityDrilling,  // IsobaricSpecificHeatCapacityDrilling
         IsobaricSpecificHeatCapacityGradientPerTemperatureDrilling,  // IsobaricSpecificHeatCapacityGradientPerTemperatureDrilling
         MassDensityDrilling,  // MassDensityDrilling
         MassDensityGradientPerLengthDrilling,  // MassDensityGradientPerLengthDrilling
         MassDensityGradientPerTemperatureDrilling,  // MassDensityGradientPerTemperatureDrilling
         MassDensityRateOfChangeDrilling,  // MassDensityRateOfChangeDrilling
         MassDrilling,  // MassDrilling
         MassGradientPerLengthDrilling,  // MassGradientPerLengthDrilling
         MassRateDrilling,  // MassRateDrilling
         NozzleDiameterDrilling,  // NozzleDiameterDrilling
         PlaneAngleDrilling,  // PlaneAngleDrilling
         PorousMediumPermeabilityDrilling,  // PorousMediumPermeabilityDrilling
         PositionDrilling,  // PositionDrilling
         PowerDrilling,  // PowerDrilling
         PressureDrilling,  // PressureDrilling
         PressureGradientPerLengthDrilling,  // PressureGradientPerLengthDrilling
         PressureLossConstantDrilling,  // PressureLossConstantDrilling
         PressureRateOfChangeDrilling,  // PressureRateOfChangeDrilling
         RandomWalkDrilling,  // RandomWalkDrilling
         RateOfPenetrationDrilling,  // RateOfPenetrationDrilling
         ReciprocalLengthSurveyInstrumentDrilling,  // ReciprocalLengthSurveyInstrumentDrilling
         RotationalFrequencyRateOfChangeDrilling,  // RotationalFrequencyRateOfChangeDrilling
         StickDurationDrilling,  // StickDurationDrilling
         SurfacePoreDrilling,  // SurfacePoreDrilling
         TemperatureDrilling,  // TemperatureDrilling
         TemperatureGradientPerLengthDrilling,  // TemperatureGradientPerLengthDrilling
         TensionDrilling,  // TensionDrilling
         ThermalConductivityDrilling,  // ThermalConductivityDrilling
         ThermalConductivityGradientPerTemperatureDrilling,  // ThermalConductivityGradientPerTemperatureDrilling
         TorqueDrilling,  // TorqueDrilling
         TorqueGradientPerLengthDrilling,  // TorqueGradientPerLengthDrilling
         TorqueRateOfChangeDrilling,  // TorqueRateOfChangeDrilling
         VolumeDrilling,  // VolumeDrilling
         VolumetricFlowrateDrilling,  // VolumetricFlowrateDrilling
         VolumetricFlowRateOfChangeDrilling,  // VolumetricFlowRateOfChangeDrilling
         MomentOfInertiaDrilling,  // MomentOfInertiaDrilling
         WeightOnBitDrilling,  // WeightOnBitDrilling
         MomentOfAreaDrilling,  // MomentOfAreaDrilling
         TotalFlowAreaDrilling,  // TotalFlowAreaDrilling
         MassDensityGradientPerPressureDrilling,  // MassDensityGradientPerPressureDrilling
         MassDensityGradientPerPressureSquaredDrilling,  // MassDensityGradientPerPressureSquaredDrilling
         MassDensityGradientPerPressureSquaredTemperatureDrilling,  // MassDensityGradientPerPressureSquaredTemperatureDrilling
         MassDensityGradientPerPressureTemperatureDrilling,  // MassDensityGradientPerPressureTemperatureDrilling
         SpecificVolumeDrilling,  // SpecificVolumeDrilling
         SpecificVolumeSquaredDrilling // SpecificVolumeSquaredDrilling
       }
    protected static new Dictionary<QuantityEnum, Guid> enumLookUp_ = new Dictionary<QuantityEnum, Guid>()
    {
         {QuantityEnum.AccelerationDrilling, new Guid("b6c99136-8e57-4eea-9a31-fb804bc8ae4b")},  // AccelerationDrilling
         {QuantityEnum.AngleGradientPerLengthDrilling, new Guid("e6f22876-ca88-4d0e-a4a5-c76b0db3556f")},  // AngleGradientPerLengthDrilling
         {QuantityEnum.AngleMagneticFluxDensitySurveyInstrumentDrilling, new Guid("a3ad9fd6-a516-42c8-98a5-14e178dc62f2")},  // AngleMagneticFluxDensitySurveyInstrumentDrilling
         {QuantityEnum.AngularAccelerationDrilling, new Guid("0077dbf8-bd21-4cc7-a180-b2c75229dd87")},  // AngularAccelerationDrilling
         {QuantityEnum.AngularVelocityDrilling, new Guid("046cb449-8cab-4d0c-bb28-3e2060f292e5")},  // AngularVelocityDrilling
         {QuantityEnum.AngularVelocitySurveyInstrumentDrilling, new Guid("76dd6ac8-8b67-416c-b41f-07bbf4065cdb")},  // AngularVelocitySurveyInstrumentDrilling
         {QuantityEnum.AreaDrilling, new Guid("21fc0373-6eda-460b-bacb-070abf2f3add")},  // AreaDrilling
         {QuantityEnum.AxialVelocityDrilling, new Guid("e278ace8-d577-4fb4-8d1d-dd8a3d072027")},  // AxialVelocityDrilling
         {QuantityEnum.BlockVelocityDrilling, new Guid("82a2b5fc-9edd-45ea-80cb-1cd46d516fdb")},  // BlockVelocityDrilling
         {QuantityEnum.CableDiameterDrilling, new Guid("6b3db5b2-7e30-47f7-91c5-5951dd3f9246")},  // CableDiameterDrilling
         {QuantityEnum.CapillaryPressureDrilling, new Guid("72228ff1-9ba8-44f0-b9b1-85fa8dfb32ea")},  // CapillaryPressureDrilling
         {QuantityEnum.CompressibilityDrilling, new Guid("bfec67e2-839f-47d7-968c-69287567835d")},  // CompressibilityDrilling
         {QuantityEnum.CurvatureDrilling, new Guid("0e41ce3a-a0e4-44a3-bf6e-6c2a70f4a28b")},  // CurvatureDrilling
         {QuantityEnum.DepthDrilling, new Guid("c0d965b2-a153-420a-9d03-7a2a272d619e")},  // DepthDrilling
         {QuantityEnum.DiameterPipeDrilling, new Guid("28a2fe65-db50-46ec-8b1d-2a26286a5813")},  // DiameterPipeDrilling
         {QuantityEnum.DiameterPoreDrilling, new Guid("781affbc-fae3-40a0-a110-fd3bdfd7d41f")},  // DiameterPoreDrilling
         {QuantityEnum.DrillStemMaterialStrengthDrilling, new Guid("fd58fca3-6221-4e85-a7aa-a021ee04e8a8")},  // DrillStemMaterialStrengthDrilling
         {QuantityEnum.DrillStringMagneticFluxDrilling, new Guid("3a58147b-88db-4474-8390-dd0e0f7d206b")},  // DrillStringMagneticFluxDrilling
         {QuantityEnum.DurationDrilling, new Guid("22443197-6bcf-45f7-9079-4f710585af60")},  // DurationDrilling
         {QuantityEnum.DynamicViscosityDrilling, new Guid("e9b32538-f7f4-4f99-a206-0601a4e4a5f8")},  // DynamicViscosityDrilling
         {QuantityEnum.ElongationGradientPerLengthDrilling, new Guid("4410a514-a65a-48ca-82d1-ab788b3d2df9")},  // ElongationGradientPerLengthDrilling
         {QuantityEnum.EnergyDensityDrilling, new Guid("04bc9209-c5c0-4f42-98b1-f1f63a3bee52")},  // EnergyDensityDrilling
         {QuantityEnum.FluidVelocityDrilling, new Guid("dac9cee1-59a3-42d5-98c6-0c7baf5083bb")},  // FluidVelocityDrilling
         {QuantityEnum.ForceDrilling, new Guid("30c08b42-6a89-4d99-879b-882eb7ed46d0")},  // ForceDrilling
         {QuantityEnum.ForceGradientPerLengthDrilling, new Guid("78942f39-d764-42f1-b270-47a3b35e5112")},  // ForceGradientPerLengthDrilling
         {QuantityEnum.ForceRateOfChangeDrilling, new Guid("2f93df65-edf4-46fb-b4f0-658c854b2845")},  // ForceRateOfChangeDrilling
         {QuantityEnum.FormationResistivityDrilling, new Guid("ed01d6da-225d-4bcc-beac-55ccdb6fb0b9")},  // FormationResistivityDrilling
         {QuantityEnum.FormationStrengthDrilling, new Guid("55a8119f-4609-4d51-91b4-e2281c46c779")},  // FormationStrengthDrilling
         {QuantityEnum.GammaRayIndexDrilling, new Guid("15280017-0ac6-4dad-a6e1-1efdb05e64c5")},  // GammaRayIndexDrilling
         {QuantityEnum.GasShowDrilling, new Guid("c81adbce-b90b-4889-8b79-921d95b35179")},  // GasShowDrilling
         {QuantityEnum.GasVolumetricFlowRateDrilling, new Guid("453bbddf-4979-4557-ba76-3fd3420fd97e")},  // GasVolumetricFlowRateDrilling
         {QuantityEnum.HeatTransferCoefficientDrilling, new Guid("c99547c5-b545-4060-bd82-eadc13772493")},  // HeatTransferCoefficientDrilling
         {QuantityEnum.HeightDrilling, new Guid("8ec20e78-3307-4363-9fc1-97c64a4b6e6e")},  // HeightDrilling
         {QuantityEnum.HookLoadDrilling, new Guid("126be5e9-ed09-459e-92ce-32a5fcd81f0a")},  // HookLoadDrilling
         {QuantityEnum.HydraulicConductivityDrilling, new Guid("6cc821d6-b979-4bf9-b1cc-ac266b221330")},  // HydraulicConductivityDrilling
         {QuantityEnum.InterfacialTensionDrilling, new Guid("1bf5cf90-84c4-4dcc-ac74-92223d3c3c46")},  // InterfacialTensionDrilling
         {QuantityEnum.IsobaricSpecificHeatCapacityDrilling, new Guid("05c59293-4e3b-4fc0-b579-12c241109610")},  // IsobaricSpecificHeatCapacityDrilling
         {QuantityEnum.IsobaricSpecificHeatCapacityGradientPerTemperatureDrilling, new Guid("5f180166-bc44-4855-916f-236a5a31893d")},  // IsobaricSpecificHeatCapacityGradientPerTemperatureDrilling
         {QuantityEnum.MassDensityDrilling, new Guid("60f2af98-56e4-4f9c-8438-59646a35fc0d")},  // MassDensityDrilling
         {QuantityEnum.MassDensityGradientPerLengthDrilling, new Guid("787c3f65-b6d5-4866-885b-12571b1d9734")},  // MassDensityGradientPerLengthDrilling
         {QuantityEnum.MassDensityGradientPerTemperatureDrilling, new Guid("b5ccd49c-a9fd-4cfd-8dd1-fb4d3f8c3ad5")},  // MassDensityGradientPerTemperatureDrilling
         {QuantityEnum.MassDensityRateOfChangeDrilling, new Guid("af63f164-0fb7-42c0-ac55-06e40b6c12e5")},  // MassDensityRateOfChangeDrilling
         {QuantityEnum.MassDrilling, new Guid("f4c0a6fd-5000-4507-8612-ae4374c0cacc")},  // MassDrilling
         {QuantityEnum.MassGradientPerLengthDrilling, new Guid("dc474098-a2b5-44fb-b56a-0ae20ff62ad6")},  // MassGradientPerLengthDrilling
         {QuantityEnum.MassRateDrilling, new Guid("0e218b8e-bc7c-4902-b88d-1cdab4a5dc94")},  // MassRateDrilling
         {QuantityEnum.NozzleDiameterDrilling, new Guid("1fbe2318-851d-4fd7-b711-9c23ffe544c7")},  // NozzleDiameterDrilling
         {QuantityEnum.PlaneAngleDrilling, new Guid("94ad3e73-2a44-4c60-bbca-188b941f3357")},  // PlaneAngleDrilling
         {QuantityEnum.PorousMediumPermeabilityDrilling, new Guid("040ff93a-d03a-4d01-9c52-8e456647ccb9")},  // PorousMediumPermeabilityDrilling
         {QuantityEnum.PositionDrilling, new Guid("20f58500-7e00-41e7-acc4-99e9de9bfd07")},  // PositionDrilling
         {QuantityEnum.PowerDrilling, new Guid("d7f0d3a8-2d15-4ae9-897a-5d1ef7feef8a")},  // PowerDrilling
         {QuantityEnum.PressureDrilling, new Guid("d9db6bb4-77af-4fc3-a683-7bedd781fcba")},  // PressureDrilling
         {QuantityEnum.PressureGradientPerLengthDrilling, new Guid("92a284e7-9898-41f7-950d-4ba9f1ec550b")},  // PressureGradientPerLengthDrilling
         {QuantityEnum.PressureLossConstantDrilling, new Guid("fd799f5c-0963-4201-aec3-e531df6b226e")},  // PressureLossConstantDrilling
         {QuantityEnum.PressureRateOfChangeDrilling, new Guid("15962c4f-9163-44ed-afec-bc9f17e60983")},  // PressureRateOfChangeDrilling
         {QuantityEnum.RandomWalkDrilling, new Guid("8817dc80-eb46-42d5-b85f-703fa8845f32")},  // RandomWalkDrilling
         {QuantityEnum.RateOfPenetrationDrilling, new Guid("c2581b41-944c-410b-9805-62c4b54de510")},  // RateOfPenetrationDrilling
         {QuantityEnum.ReciprocalLengthSurveyInstrumentDrilling, new Guid("c198aa3b-3b24-402d-b60b-f54ff9430f33")},  // ReciprocalLengthSurveyInstrumentDrilling
         {QuantityEnum.RotationalFrequencyRateOfChangeDrilling, new Guid("4950170a-7882-4673-9d27-3402dbbca2bb")},  // RotationalFrequencyRateOfChangeDrilling
         {QuantityEnum.StickDurationDrilling, new Guid("1e9bafaa-bbf1-4a29-9811-39b5e2280499")},  // StickDurationDrilling
         {QuantityEnum.SurfacePoreDrilling, new Guid("c88cc254-b870-44a6-b896-5863472bdcd0")},  // SurfacePoreDrilling
         {QuantityEnum.TemperatureDrilling, new Guid("84ce5a77-fd76-4014-ad8e-03f194c3e329")},  // TemperatureDrilling
         {QuantityEnum.TemperatureGradientPerLengthDrilling, new Guid("82b91f3f-d1ec-476b-98e0-eedbba6281ec")},  // TemperatureGradientPerLengthDrilling
         {QuantityEnum.TensionDrilling, new Guid("fe8fd6fd-814c-44c9-9462-f034dd46dc85")},  // TensionDrilling
         {QuantityEnum.ThermalConductivityDrilling, new Guid("186eef6a-9da3-4b97-a6d0-d496bdf59321")},  // ThermalConductivityDrilling
         {QuantityEnum.ThermalConductivityGradientPerTemperatureDrilling, new Guid("559ae484-42ed-4379-86f5-67dae451a9c9")},  // ThermalConductivityGradientPerTemperatureDrilling
         {QuantityEnum.TorqueDrilling, new Guid("eff33c0e-1e92-49e4-a7ab-716d9d66a157")},  // TorqueDrilling
         {QuantityEnum.TorqueGradientPerLengthDrilling, new Guid("6ad57f76-fb74-4099-a257-1d47216bfe65")},  // TorqueGradientPerLengthDrilling
         {QuantityEnum.TorqueRateOfChangeDrilling, new Guid("a8053578-6cf0-4c46-b046-a6dbc7cb360f")},  // TorqueRateOfChangeDrilling
         {QuantityEnum.VolumeDrilling, new Guid("b8c9f810-d576-4523-a26f-921305c7f7b4")},  // VolumeDrilling
         {QuantityEnum.VolumetricFlowrateDrilling, new Guid("7b12c115-3c20-4d45-b4cf-86af29255b14")},  // VolumetricFlowrateDrilling
         {QuantityEnum.VolumetricFlowRateOfChangeDrilling, new Guid("244ade8c-591d-44d4-bca6-3798046d90a1")},  // VolumetricFlowRateOfChangeDrilling
         {QuantityEnum.MomentOfInertiaDrilling, new Guid("5b4e4820-9b88-43f9-9856-155846afee0e")},  // MomentOfInertiaDrilling
         {QuantityEnum.WeightOnBitDrilling, new Guid("5e75da44-a675-4f0e-a0fb-52b2cb6797ce")},  // WeightOnBitDrilling
         {QuantityEnum.MomentOfAreaDrilling, new Guid("1805e50f-3bf0-4347-9e5a-cc169a124b7e")},  // MomentOfAreaDrilling
         {QuantityEnum.TotalFlowAreaDrilling, new Guid("fc067c6d-1f34-4af9-a6f8-eb2bbf7acca5")},  // TotalFlowAreaDrilling
         {QuantityEnum.MassDensityGradientPerPressureDrilling, new Guid("e027fcd6-bc2e-4dec-a886-f6adf4446249")},  // MassDensityGradientPerPressureDrilling
         {QuantityEnum.MassDensityGradientPerPressureSquaredDrilling, new Guid("b10b7f56-ee6a-449e-badb-156b8466e6cb")},  // MassDensityGradientPerPressureSquaredDrilling
         {QuantityEnum.MassDensityGradientPerPressureSquaredTemperatureDrilling, new Guid("83831fcf-deb2-4b8e-a250-31c5c3f206cb")},  // MassDensityGradientPerPressureSquaredTemperatureDrilling
         {QuantityEnum.MassDensityGradientPerPressureTemperatureDrilling, new Guid("589f259f-28d9-405c-9b1b-18804fc3446a")},  // MassDensityGradientPerPressureTemperatureDrilling
         {QuantityEnum.SpecificVolumeDrilling, new Guid("26b08c06-b8e9-40e5-9b6c-66c93e8d8723")},  // SpecificVolumeDrilling
         {QuantityEnum.SpecificVolumeSquaredDrilling, new Guid("d6500752-b69c-4011-b8e3-b219434e690d")} // SpecificVolumeSquaredDrilling
    };
  }
}

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class AccelerationDrillingQuantity : AccelerationQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerSecondSquared,  // metre per second squared
         FootPerSecondSquared // foot per second squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerSecondSquared, new Guid("20515c0b-8a90-4e76-a2b3-cab213db5a06")},  // metre per second squared
         {UnitChoicesEnum.FootPerSecondSquared, new Guid("74f20b52-6c15-40e2-ae23-5493326fc879")} // foot per second squared
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
  public partial class AngleGradientPerLengthDrillingQuantity : AngleGradientPerLengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerMetre,  // radian per metre
         DegreePerMetre,  // degree per metre
         DegreePerFoot,  // degree per foot
         DegreePerCentimetre,  // degree per centimetre
         DegreePerInch // degree per inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerMetre, new Guid("5d9782b6-c4c7-47ca-a86b-dce3f63c3747")},  // radian per metre
         {UnitChoicesEnum.DegreePerMetre, new Guid("2fcd4219-8879-4494-9563-5173ec2292fa")},  // degree per metre
         {UnitChoicesEnum.DegreePerFoot, new Guid("23bf7716-5779-4607-aef7-1e0eeb7f201b")},  // degree per foot
         {UnitChoicesEnum.DegreePerCentimetre, new Guid("7f4f63d6-5ea8-4c6b-8be4-81f52b7060c7")},  // degree per centimetre
         {UnitChoicesEnum.DegreePerInch, new Guid("271db65d-2a9f-4fec-a52a-21e13e106dd4")} // degree per inch
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
  public partial class AngleMagneticFluxDensitySurveyInstrumentDrillingQuantity : AngleMagneticFluxDensityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianTesla,  // radian tesla
         DegreeGauss,  // degree gauss
         DegreeMaxwellPerSquareCentimetre,  // degree maxwell per square centimetre
         DegreeMicrotesla,  // degree microtesla
         DegreeMilligauss,  // degree milligauss
         DegreeMillitesla,  // degree millitesla
         DegreeNanotesla,  // degree nanotesla
         DegreeTesla,  // degree tesla
         DegreeWeberPerSquareMetre,  // degree weber per square metre
         RadianGauss,  // radian gauss
         RadianMaxwellPerSquareCentimetre,  // radian maxwell per square centimetre
         RadianMicrotesla,  // radian microtesla
         RadianMilligauss,  // radian milligauss
         RadianMillitesla,  // radian millitesla
         RadianNanotesla,  // radian nanotesla
         RadianWeberPerSquareMetre // radian weber per square metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianTesla, new Guid("242bd328-96ef-4a1b-9a78-1e2eb8366955")},  // radian tesla
         {UnitChoicesEnum.DegreeGauss, new Guid("73bb1de0-ccc0-42e6-b88e-44ecfb6fe7e4")},  // degree gauss
         {UnitChoicesEnum.DegreeMaxwellPerSquareCentimetre, new Guid("092e8231-a6e6-4b29-bdd6-2ae490aa583a")},  // degree maxwell per square centimetre
         {UnitChoicesEnum.DegreeMicrotesla, new Guid("50782201-236e-4537-843b-121e8dca28c6")},  // degree microtesla
         {UnitChoicesEnum.DegreeMilligauss, new Guid("e74c9ae3-6e17-48e1-896b-e6c1877d68d7")},  // degree milligauss
         {UnitChoicesEnum.DegreeMillitesla, new Guid("812a3461-ae4a-405b-ae5d-73eb23e8a71f")},  // degree millitesla
         {UnitChoicesEnum.DegreeNanotesla, new Guid("0d9bf20d-2b10-4e73-ae8e-3d3e91862ec0")},  // degree nanotesla
         {UnitChoicesEnum.DegreeTesla, new Guid("13df770f-6e77-4de4-91c6-137206e53fbb")},  // degree tesla
         {UnitChoicesEnum.DegreeWeberPerSquareMetre, new Guid("2d7e1d60-6401-41c0-b436-612116be9ad4")},  // degree weber per square metre
         {UnitChoicesEnum.RadianGauss, new Guid("aa726b90-bd4b-420c-ae71-6f2f1fde3b58")},  // radian gauss
         {UnitChoicesEnum.RadianMaxwellPerSquareCentimetre, new Guid("02d06899-5d89-4669-a4c2-35adb9ec3924")},  // radian maxwell per square centimetre
         {UnitChoicesEnum.RadianMicrotesla, new Guid("b445e592-e0ca-490f-8880-9708e4e96a01")},  // radian microtesla
         {UnitChoicesEnum.RadianMilligauss, new Guid("352a5b84-306d-4e38-898a-58705683fdf0")},  // radian milligauss
         {UnitChoicesEnum.RadianMillitesla, new Guid("663639b3-48b8-4c04-a2eb-6ae2e16daa9b")},  // radian millitesla
         {UnitChoicesEnum.RadianNanotesla, new Guid("b4aeee40-29fa-463a-80a4-e10fa42c743f")},  // radian nanotesla
         {UnitChoicesEnum.RadianWeberPerSquareMetre, new Guid("409e8e85-0870-4529-ae0c-95ab6506c445")} // radian weber per square metre
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
  public partial class AngularAccelerationDrillingQuantity : AngularAccelerationQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSecondSquared,  // radian per second squared
         DegreePerSecondSquared // degree per second squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSecondSquared, new Guid("15d7ab2b-c0c3-4d33-8242-670ba2f937ff")},  // radian per second squared
         {UnitChoicesEnum.DegreePerSecondSquared, new Guid("6fcc944b-fd7e-4368-baa4-3bb8eeba63a2")} // degree per second squared
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
  public partial class AngularVelocityDrillingQuantity : AngularVelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSecond,  // radian per second
         DegreePerSecond,  // degree per second
         RevolutionPerMinute,  // revolution per minute
         StrokePerMinute // stroke per minute
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSecond, new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a")},  // radian per second
         {UnitChoicesEnum.DegreePerSecond, new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e")},  // degree per second
         {UnitChoicesEnum.RevolutionPerMinute, new Guid("fe846c15-ddba-480f-93f0-16af45f7b9ce")},  // revolution per minute
         {UnitChoicesEnum.StrokePerMinute, new Guid("979b3170-be8b-42ee-a7d5-ecf9d9f1869d")} // stroke per minute
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
  public partial class AngularVelocitySurveyInstrumentDrillingQuantity : AngularVelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerSecond,  // radian per second
         DegreePerSecond,  // degree per second
         DegreePerMinute,  // degree per minute
         DegreePerHour,  // degree per hour
         DegreePerDay // degree per day
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerSecond, new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a")},  // radian per second
         {UnitChoicesEnum.DegreePerSecond, new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e")},  // degree per second
         {UnitChoicesEnum.DegreePerMinute, new Guid("0a3ad50c-bbfa-456c-9613-84f37b4a80f1")},  // degree per minute
         {UnitChoicesEnum.DegreePerHour, new Guid("44cc8b17-2f87-49c9-8ab7-7f4ed36d9eb6")},  // degree per hour
         {UnitChoicesEnum.DegreePerDay, new Guid("ec049b3d-134b-44a3-9746-0419a368beef")} // degree per day
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
  public partial class AreaDrillingQuantity : AreaQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMetre,  // square metre
         SquareFoot,  // square foot
         SquareDecimetre,  // square decimetre
         SquareYard,  // square yard
         SquareCentimetre,  // square centimetre
         SquareInch // square inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMetre, new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee")},  // square metre
         {UnitChoicesEnum.SquareFoot, new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248")},  // square foot
         {UnitChoicesEnum.SquareDecimetre, new Guid("125fd8d6-d1eb-4826-a952-5219603409ab")},  // square decimetre
         {UnitChoicesEnum.SquareYard, new Guid("ae3df24c-e5db-4b88-9e81-228f29855f1b")},  // square yard
         {UnitChoicesEnum.SquareCentimetre, new Guid("d74bb2bc-9c86-4be4-bff1-88cac7b1049b")},  // square centimetre
         {UnitChoicesEnum.SquareInch, new Guid("294bc6d0-5be7-4c70-95f3-ad9dc50f02cf")} // square inch
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
  public partial class AxialVelocityDrillingQuantity : VelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerSecond,  // metre per second
         MetrePerMinute,  // metre per minute
         MetrePerHour,  // metre per hour
         FootPerHour,  // foot per hour
         FootPerMinute,  // foot per minute
         FootPerSecond // foot per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // metre per second
         {UnitChoicesEnum.MetrePerMinute, new Guid("824d3b5b-1e51-446a-99a4-39c02377f303")},  // metre per minute
         {UnitChoicesEnum.MetrePerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // metre per hour
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")},  // foot per hour
         {UnitChoicesEnum.FootPerMinute, new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076")},  // foot per minute
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")} // foot per second
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
  public partial class BlockVelocityDrillingQuantity : VelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerSecond,  // metre per second
         MetrePerMinute,  // metre per minute
         MetrePerHour,  // metre per hour
         FootPerHour,  // foot per hour
         FootPerMinute,  // foot per minute
         FootPerSecond // foot per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // metre per second
         {UnitChoicesEnum.MetrePerMinute, new Guid("824d3b5b-1e51-446a-99a4-39c02377f303")},  // metre per minute
         {UnitChoicesEnum.MetrePerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // metre per hour
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")},  // foot per hour
         {UnitChoicesEnum.FootPerMinute, new Guid("2d139d2c-1063-4f8d-99ae-bf71a98a1076")},  // foot per minute
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")} // foot per second
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
  public partial class CableDiameterDrillingQuantity : LengthSmallQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class CapillaryPressureDrillingQuantity : PressureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // pascal
         Bar,  // bar
         PoundPerSquareInch,  // pound per square inch
         Kilopascal,  // kilopascal
         MegapoundPerSquareInch,  // megapound per square inch
         KilopoundPerSquareInch // kilopound per square inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // pascal
         {UnitChoicesEnum.Bar, new Guid("0d182739-f8f6-47a6-afcb-71feac973307")},  // bar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // pound per square inch
         {UnitChoicesEnum.Kilopascal, new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29")},  // kilopascal
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("bb49de0a-fbf3-4914-b6b9-fc60ab502522")},  // megapound per square inch
         {UnitChoicesEnum.KilopoundPerSquareInch, new Guid("a07b5fe5-87e3-4422-afe1-f54de24deeb8")} // kilopound per square inch
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
  public partial class CompressibilityDrillingQuantity : CompressibilityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         InversePascal,  // inverse pascal
         InverseBar,  // inverse bar
         InversePoundPerSquareInch // inverse pound per square inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.InversePascal, new Guid("0e259998-c8bb-4a4d-b281-afb8008b2693")},  // inverse pascal
         {UnitChoicesEnum.InverseBar, new Guid("4a0f6df4-0d2d-489b-80f1-511be7713101")},  // inverse bar
         {UnitChoicesEnum.InversePoundPerSquareInch, new Guid("282ab24c-6c43-4710-8e52-433bdf90cc2e")} // inverse pound per square inch
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
  public partial class CurvatureDrillingQuantity : CurvatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         RadianPerMetre,  // radian per metre
         DegreePer10m,  // degree per 10m
         DegreePer30m,  // degree per 30m
         DegreePer30ft,  // degree per 30ft
         DegreePer100ft // degree per 100ft
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.RadianPerMetre, new Guid("cbba2f64-9914-4c00-a3fe-3c2aef560225")},  // radian per metre
         {UnitChoicesEnum.DegreePer10m, new Guid("c62408d6-c3c5-47bd-8cb0-4fa9faf51598")},  // degree per 10m
         {UnitChoicesEnum.DegreePer30m, new Guid("98a4d593-c959-49fb-ba1a-b1aa61830cd7")},  // degree per 30m
         {UnitChoicesEnum.DegreePer30ft, new Guid("284dca7d-b1fc-4e40-ab08-a3e0fa2ef9d0")},  // degree per 30ft
         {UnitChoicesEnum.DegreePer100ft, new Guid("5aa20ab5-6800-48db-abb1-4c3538b0972d")} // degree per 100ft
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
  public partial class DepthDrillingQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Metre,  // metre
         Foot // foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Foot, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")} // foot
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
  public partial class DiameterPipeDrillingQuantity : LengthSmallQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DiameterPoreDrillingQuantity : LengthSmallQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class DrillStemMaterialStrengthDrillingQuantity : MaterialStrengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // pascal
         Gigapascal,  // gigapascal
         Megapascal,  // megapascal
         MegapoundPerSquareInch,  // megapound per square inch
         PoundPer100SquareFoot,  // pound per 100 square foot
         Psi // psi
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("159e99d3-c79d-4dc6-974f-05cc38af001e")},  // pascal
         {UnitChoicesEnum.Gigapascal, new Guid("c9aa0a18-02ac-42a0-9afe-8a08b4f03331")},  // gigapascal
         {UnitChoicesEnum.Megapascal, new Guid("38b95b61-a825-4393-a0e8-ecd686575735")},  // megapascal
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("197a8b98-190d-4d45-91d7-85af12deab02")},  // megapound per square inch
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("eb1e2a52-3de3-4338-ad4d-40e8ce90e40b")},  // pound per 100 square foot
         {UnitChoicesEnum.Psi, new Guid("4adf2a33-05c3-49bb-ba61-59dd76f4621e")} // psi
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
  public partial class DrillStringMagneticFluxDrillingQuantity : MagneticFluxQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Weber,  // weber
         Milliweber,  // milliweber
         Microweber,  // microweber
         TeslaSquareMetre,  // tesla square metre
         TeslaSquareCentimetre,  // tesla square centimetre
         GaussSquareCentimetre // gauss square centimetre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Weber, new Guid("d790689d-e7dd-43d8-a3c0-c17ccc8073e5")},  // weber
         {UnitChoicesEnum.Milliweber, new Guid("94f03fc7-b0bb-4356-8787-c9e33f6559d2")},  // milliweber
         {UnitChoicesEnum.Microweber, new Guid("200b9de7-0635-40eb-8ebd-9cef7c01ac10")},  // microweber
         {UnitChoicesEnum.TeslaSquareMetre, new Guid("f6da9f32-0738-4014-aac6-fdc5935fd436")},  // tesla square metre
         {UnitChoicesEnum.TeslaSquareCentimetre, new Guid("312b97ea-6167-47b5-a046-c6c202fb7eb4")},  // tesla square centimetre
         {UnitChoicesEnum.GaussSquareCentimetre, new Guid("a0dc1e92-7e84-401f-bca2-a6eb618ef604")} // gauss square centimetre
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
  public partial class DurationDrillingQuantity : TimeQuantity
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
  public partial class DynamicViscosityDrillingQuantity : DynamicViscosityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalSecond,  // pascal second
         Centipoise,  // centipoise
         Micropoise,  // micropoise
         MicropascalSecond // micropascal second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalSecond, new Guid("5707caa4-e293-430d-9575-425305060fcc")},  // pascal second
         {UnitChoicesEnum.Centipoise, new Guid("a71ef873-6ea2-4922-a100-231177de0e85")},  // centipoise
         {UnitChoicesEnum.Micropoise, new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8")},  // micropoise
         {UnitChoicesEnum.MicropascalSecond, new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d")} // micropascal second
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
  public partial class ElongationGradientPerLengthDrillingQuantity : ElongationGradientPerLengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerMetre,  // metre per metre
         MillimetrePerMetre,  // millimetre per metre
         MillimetrePerKilometre,  // millimetre per kilometre
         InchPerFoot,  // inch per foot
         InchPerYard,  // inch per yard
         InchPerMile // inch per mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerMetre, new Guid("cc12967b-4c7d-4c70-95cf-d2f23bd6f76b")},  // metre per metre
         {UnitChoicesEnum.MillimetrePerMetre, new Guid("4e241b59-388a-428f-82e7-b9971f9e1df5")},  // millimetre per metre
         {UnitChoicesEnum.MillimetrePerKilometre, new Guid("59f50e71-7796-4559-9e55-7fc420d9c20c")},  // millimetre per kilometre
         {UnitChoicesEnum.InchPerFoot, new Guid("3df1af23-afd0-41ed-9442-a3af6ae944d2")},  // inch per foot
         {UnitChoicesEnum.InchPerYard, new Guid("ec1fbeee-cbf4-41f0-94d8-573e241c22b2")},  // inch per yard
         {UnitChoicesEnum.InchPerMile, new Guid("998afd92-de3a-4f10-90b6-a252b8e59181")} // inch per mile
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
  public partial class EnergyDensityDrillingQuantity : EnergyDensityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         JoulePerCubicMetre,  // joule per cubic metre
         JoulePerCubicFoot,  // joule per cubic foot
         JoulePerCubicInch,  // joule per cubic inch
         JoulePerGallonUK,  // joule per gallon (UK)
         JoulePerGallonUS // joule per gallon (US)
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.JoulePerCubicMetre, new Guid("bac0aae1-8b3b-403d-b1ea-874a74da849a")},  // joule per cubic metre
         {UnitChoicesEnum.JoulePerCubicFoot, new Guid("5c91efe6-c268-4d31-bff8-768344290db6")},  // joule per cubic foot
         {UnitChoicesEnum.JoulePerCubicInch, new Guid("daba8c83-b6f5-40bb-8c9d-e476e5d1bce2")},  // joule per cubic inch
         {UnitChoicesEnum.JoulePerGallonUK, new Guid("1c3b4a46-1cfa-44e4-b10e-4ed0f74e2994")},  // joule per gallon (UK)
         {UnitChoicesEnum.JoulePerGallonUS, new Guid("357a5df6-6df1-43fa-8be8-652e8d97db7c")} // joule per gallon (US)
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
  public partial class FluidVelocityDrillingQuantity : VelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerSecond,  // metre per second
         FootPerSecond // foot per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // metre per second
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")} // foot per second
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
  public partial class ForceDrillingQuantity : ForceQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Newton,  // newton
         Decanewton,  // decanewton
         Kilodecanewton,  // kilodecanewton
         KilogramForce,  // kilogram force
         Kilonewton,  // kilonewton
         KilopoundForce,  // kilopound force
         PoundForce // pound force
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // newton
         {UnitChoicesEnum.Decanewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // decanewton
         {UnitChoicesEnum.Kilodecanewton, new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266")},  // kilodecanewton
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // kilogram force
         {UnitChoicesEnum.Kilonewton, new Guid("e30d6f94-7887-4746-8d4f-eb720239b702")},  // kilonewton
         {UnitChoicesEnum.KilopoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")},  // kilopound force
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")} // pound force
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
  public partial class ForceGradientPerLengthDrillingQuantity : ForceGradientPerLengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonPerMetre,  // newton per metre
         NewtonPer10Metre,  // newton per 10 metre
         NewtonPer30Metre,  // newton per 30 metre
         DecanewtonPerMetre,  // decanewton per metre
         DecanewtonPer10Metre,  // decanewton per 10 metre
         DecanewtonPer30Metre,  // decanewton per 30 metre
         KilonewtonPerMetre,  // kilonewton per metre
         KilonewtonPer10Metre,  // kilonewton per 10 metre
         KilonewtonPer30Metre,  // kilonewton per 30 metre
         PoundPerFoot,  // pound per foot
         PoundPer30Foot,  // pound per 30 foot
         PoundPer100Foot,  // pound per 100 foot
         KilopoundPerFoot,  // kilopound per foot
         KilopoundPer30Foot,  // kilopound per 30 foot
         KilopoundPer100Foot // kilopound per 100 foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonPerMetre, new Guid("e503a1d3-1815-4321-8087-6e3d6dc641c8")},  // newton per metre
         {UnitChoicesEnum.NewtonPer10Metre, new Guid("46defe0c-4a00-45d1-83bb-f898e00a78c5")},  // newton per 10 metre
         {UnitChoicesEnum.NewtonPer30Metre, new Guid("be16e271-5ce7-445b-a8db-9014a6acc22b")},  // newton per 30 metre
         {UnitChoicesEnum.DecanewtonPerMetre, new Guid("2566918f-f1b1-4ffb-906b-adb3680812e1")},  // decanewton per metre
         {UnitChoicesEnum.DecanewtonPer10Metre, new Guid("4f30206a-b381-4a28-9e2d-fafc026e71d5")},  // decanewton per 10 metre
         {UnitChoicesEnum.DecanewtonPer30Metre, new Guid("20de7177-2099-4f86-89da-fdfa68bf67ed")},  // decanewton per 30 metre
         {UnitChoicesEnum.KilonewtonPerMetre, new Guid("9ec7912e-9506-43ce-9089-80000d7ddd3f")},  // kilonewton per metre
         {UnitChoicesEnum.KilonewtonPer10Metre, new Guid("f57cb3e9-4da5-4960-aff6-a27167276e4a")},  // kilonewton per 10 metre
         {UnitChoicesEnum.KilonewtonPer30Metre, new Guid("b08fae49-fdc3-409e-8b0f-3349ab189dc9")},  // kilonewton per 30 metre
         {UnitChoicesEnum.PoundPerFoot, new Guid("516e4b02-2f1a-49a7-8cd9-3fa4e28c8fce")},  // pound per foot
         {UnitChoicesEnum.PoundPer30Foot, new Guid("0d0926be-19fa-4687-88d1-35f1acc58717")},  // pound per 30 foot
         {UnitChoicesEnum.PoundPer100Foot, new Guid("dcaa5f41-da2f-49d2-be41-80fb6f0a06ec")},  // pound per 100 foot
         {UnitChoicesEnum.KilopoundPerFoot, new Guid("bf63e80f-97df-48d1-afbf-c83415654e44")},  // kilopound per foot
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class ForceRateOfChangeDrillingQuantity : ForceRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonPerSecond,  // newton per second
         DecanewtonPerSecond,  // decanewton per second
         KilonewtonPerSecond,  // kilonewton per second
         KilodecanewtonPerSecond,  // kilodecanewton per second
         KilogramForcePerSecond,  // kilogram force per second
         KilopoundForcePerSecond,  // kilopound force per second
         PoundForcePerSecond,  // pound force per second
         NewtonPerMinute,  // newton per minute
         DecanewtonPerMinute,  // decanewton per minute
         KilonewtonPerMinute,  // kilonewton per minute
         KilodecanewtonPerMinute,  // kilodecanewton per minute
         KilogramForcePerMinute,  // kilogram force per minute
         KilopoundForcePerMinute,  // kilopound force per minute
         PoundForcePerMinute,  // pound force per minute
         NewtonPerHour,  // newton per hour
         DecanewtonPerHour,  // decanewton per hour
         KilonewtonPerHour,  // kilonewton per hour
         KilodecanewtonPerHour,  // kilodecanewton per hour
         KilogramForcePerHour,  // kilogram force per hour
         KilopoundForcePerHour,  // kilopound force per hour
         PoundForcePerHour // pound force per hour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonPerSecond, new Guid("c766ff54-d778-4ee6-9c65-8467932efa60")},  // newton per second
         {UnitChoicesEnum.DecanewtonPerSecond, new Guid("1b7c3f4d-30ec-4d50-8063-0d1452c88615")},  // decanewton per second
         {UnitChoicesEnum.KilonewtonPerSecond, new Guid("5c99b2ac-51b7-4f9c-b82b-036f0b02492d")},  // kilonewton per second
         {UnitChoicesEnum.KilodecanewtonPerSecond, new Guid("f0ad684b-827c-43f9-8f6e-c9097bc82dd3")},  // kilodecanewton per second
         {UnitChoicesEnum.KilogramForcePerSecond, new Guid("e5dc01f1-09d4-4304-b065-8096026647e8")},  // kilogram force per second
         {UnitChoicesEnum.KilopoundForcePerSecond, new Guid("1f45684c-4582-4d5f-a5c5-950e4c9dbff7")},  // kilopound force per second
         {UnitChoicesEnum.PoundForcePerSecond, new Guid("92ed16d5-3ea8-4102-a1cb-89f527d2b4a0")},  // pound force per second
         {UnitChoicesEnum.NewtonPerMinute, new Guid("58df085b-9f10-4148-ad09-cb05bbcfa920")},  // newton per minute
         {UnitChoicesEnum.DecanewtonPerMinute, new Guid("130a7d93-a5d2-4d9b-bdb5-4c5784f61c79")},  // decanewton per minute
         {UnitChoicesEnum.KilonewtonPerMinute, new Guid("5841d94c-2349-4f51-a965-eb8cc3cc19d9")},  // kilonewton per minute
         {UnitChoicesEnum.KilodecanewtonPerMinute, new Guid("1a80c782-8438-43ac-ba6c-46b6b7abe761")},  // kilodecanewton per minute
         {UnitChoicesEnum.KilogramForcePerMinute, new Guid("323c8871-2f8f-41bd-9df8-50e3b50bf093")},  // kilogram force per minute
         {UnitChoicesEnum.KilopoundForcePerMinute, new Guid("1b5bc3fc-3784-4508-83d5-4a21b5e9fe84")},  // kilopound force per minute
         {UnitChoicesEnum.PoundForcePerMinute, new Guid("924a79ab-743d-4c69-b5fb-b9a60bc70726")},  // pound force per minute
         {UnitChoicesEnum.NewtonPerHour, new Guid("efa69e3c-b03b-4520-8ae8-e92ab6953141")},  // newton per hour
         {UnitChoicesEnum.DecanewtonPerHour, new Guid("1b0aaee4-9d74-4289-9f08-96c2d31a19f3")},  // decanewton per hour
         {UnitChoicesEnum.KilonewtonPerHour, new Guid("edd7e626-f9a4-42c5-bce3-5b72c1f3ca55")},  // kilonewton per hour
         {UnitChoicesEnum.KilodecanewtonPerHour, new Guid("ce5ff57d-e427-4e4f-aa11-c1f02118b3e1")},  // kilodecanewton per hour
         {UnitChoicesEnum.KilogramForcePerHour, new Guid("5c638813-fe28-47de-b7b5-a65760562b12")},  // kilogram force per hour
         {UnitChoicesEnum.KilopoundForcePerHour, new Guid("6041cb2d-b49a-46b4-87ef-1f89ddd89758")},  // kilopound force per hour
         {UnitChoicesEnum.PoundForcePerHour, new Guid("a1e5538f-a653-4a4b-8240-01b6a709a0d4")} // pound force per hour
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
  public partial class FormationResistivityDrillingQuantity : ElectricResistivityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         OhmMetre // ohm metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.OhmMetre, new Guid("fb07d86d-d69f-46ca-892c-17ec45adffcb")} // ohm metre
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
  public partial class FormationStrengthDrillingQuantity : MaterialStrengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Gigapascal,  // gigapascal
         Megapascal,  // megapascal
         MegapoundPerSquareInch,  // megapound per square inch
         Pascal,  // pascal
         PoundPer100SquareFoot,  // pound per 100 square foot
         Psi // psi
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Gigapascal, new Guid("c9aa0a18-02ac-42a0-9afe-8a08b4f03331")},  // gigapascal
         {UnitChoicesEnum.Megapascal, new Guid("38b95b61-a825-4393-a0e8-ecd686575735")},  // megapascal
         {UnitChoicesEnum.MegapoundPerSquareInch, new Guid("197a8b98-190d-4d45-91d7-85af12deab02")},  // megapound per square inch
         {UnitChoicesEnum.Pascal, new Guid("159e99d3-c79d-4dc6-974f-05cc38af001e")},  // pascal
         {UnitChoicesEnum.PoundPer100SquareFoot, new Guid("eb1e2a52-3de3-4338-ad4d-40e8ce90e40b")},  // pound per 100 square foot
         {UnitChoicesEnum.Psi, new Guid("4adf2a33-05c3-49bb-ba61-59dd76f4621e")} // psi
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
  public partial class GammaRayIndexDrillingQuantity : DimensionlessQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class GasShowDrillingQuantity : ProportionQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class GasVolumetricFlowRateDrillingQuantity : VolumetricFlowRateQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetrePerSecond,  // cubic metre per second
         CubicFootPerSecond,  // cubic foot per second
         LitrePerSecond,  // litre per second
         UKGallonPerSecond,  // UK gallon per second
         USGallonPerSecond,  // US gallon per second
         BarrelPerSecond,  // barrel per second
         CubicMetrePerMinute,  // cubic metre per minute
         CubicFootPerMinute,  // cubic foot per minute
         LitrePerMinute,  // litre per minute
         UKGallonPerMinute,  // UK gallon per minute
         USGallonPerMinute,  // US gallon per minute
         BarrelPerMinute,  // barrel per minute
         CubicMetrePerHour,  // cubic metre per hour
         CubicFootPerHour,  // cubic foot per hour
         LitrePerHour,  // litre per hour
         UKGallonPerHour,  // UK gallon per hour
         USGallonPerHour,  // US gallon per hour
         BarrelPerHour,  // barrel per hour
         CubicMetrePerDay,  // cubic metre per day
         CubicFootPerDay,  // cubic foot per day
         LitrePerDay,  // litre per day
         UKGallonPerDay,  // UK gallon per day
         USGallonPerDay,  // US gallon per day
         BarrelPerDay,  // barrel per day
         ThousandStandardCubicFootPerDay,  // thousand standard cubic foot per day
         MillionCubicMetrePerDay,  // million cubic metre per day
         MillionLiterPerDay,  // million liter per day
         MillionStandardCubicFootPerDay,  // million standard cubic foot per day
         MillionUKGallonPerDay,  // million UK gallon per day
         MillionUSGallonPerDay // million US gallon per day
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetrePerSecond, new Guid("fabe7a23-1ba2-4f5d-b3f5-d5729166c7a0")},  // cubic metre per second
         {UnitChoicesEnum.CubicFootPerSecond, new Guid("a02fc355-34da-447b-ad1f-66cef4cc96d5")},  // cubic foot per second
         {UnitChoicesEnum.LitrePerSecond, new Guid("6dafb683-0f61-42ba-a22c-7bd5c9cea4ae")},  // litre per second
         {UnitChoicesEnum.UKGallonPerSecond, new Guid("21ca44f5-ed4e-414d-b285-b38730600794")},  // UK gallon per second
         {UnitChoicesEnum.USGallonPerSecond, new Guid("21fe7e3a-bf92-4c94-b6d7-e2d30dfc4cd3")},  // US gallon per second
         {UnitChoicesEnum.BarrelPerSecond, new Guid("a73caac6-062e-4f79-8374-8fb2598b6842")},  // barrel per second
         {UnitChoicesEnum.CubicMetrePerMinute, new Guid("98eec130-224c-457a-a5dd-50b55a3a28ab")},  // cubic metre per minute
         {UnitChoicesEnum.CubicFootPerMinute, new Guid("a81e08db-d8fd-4379-bc8e-c223c3fb71b3")},  // cubic foot per minute
         {UnitChoicesEnum.LitrePerMinute, new Guid("e1ff1684-02ed-41c0-a82c-40b4a6d348b5")},  // litre per minute
         {UnitChoicesEnum.UKGallonPerMinute, new Guid("bb1d3fbc-efc1-4cf7-9c13-33c25a874224")},  // UK gallon per minute
         {UnitChoicesEnum.USGallonPerMinute, new Guid("ceca76e7-fd1e-4220-b072-9f40467a05e3")},  // US gallon per minute
         {UnitChoicesEnum.BarrelPerMinute, new Guid("3672c640-3924-4921-861b-d14c99643615")},  // barrel per minute
         {UnitChoicesEnum.CubicMetrePerHour, new Guid("d6607bed-0235-4838-87c8-2ff6c76be2ad")},  // cubic metre per hour
         {UnitChoicesEnum.CubicFootPerHour, new Guid("54f30d1c-670a-4566-bfb2-3ce644d68878")},  // cubic foot per hour
         {UnitChoicesEnum.LitrePerHour, new Guid("fe2d8a01-fd2b-4652-80bd-f0da2ce990fd")},  // litre per hour
         {UnitChoicesEnum.UKGallonPerHour, new Guid("85d47672-e1ce-4b33-be1d-eabc2ec1c4c1")},  // UK gallon per hour
         {UnitChoicesEnum.USGallonPerHour, new Guid("36892d41-4a11-4d32-9a8c-1e43ac1f8c6d")},  // US gallon per hour
         {UnitChoicesEnum.BarrelPerHour, new Guid("af1bd583-3a13-4d3a-8f65-ede4f8fe9789")},  // barrel per hour
         {UnitChoicesEnum.CubicMetrePerDay, new Guid("f512755c-166c-4346-a0f7-74f09703410f")},  // cubic metre per day
         {UnitChoicesEnum.CubicFootPerDay, new Guid("6b9a886b-b96a-473b-8dea-e850583ad5d8")},  // cubic foot per day
         {UnitChoicesEnum.LitrePerDay, new Guid("67628fe2-6a64-4ea6-94fe-5a34e7568b53")},  // litre per day
         {UnitChoicesEnum.UKGallonPerDay, new Guid("334cf647-375e-4423-8ef4-e1171f938f9a")},  // UK gallon per day
         {UnitChoicesEnum.USGallonPerDay, new Guid("c0a47cc8-8ba1-47a1-ab94-d3e4361dd063")},  // US gallon per day
         {UnitChoicesEnum.BarrelPerDay, new Guid("9d36ce54-5bdc-4f4b-9948-dd65c58c9db3")},  // barrel per day
         {UnitChoicesEnum.ThousandStandardCubicFootPerDay, new Guid("627a75ed-2ab8-480a-96be-b9266d34ba5d")},  // thousand standard cubic foot per day
         {UnitChoicesEnum.MillionCubicMetrePerDay, new Guid("d09b4db7-9fbe-4018-aeb7-15286ccff8d6")},  // million cubic metre per day
         {UnitChoicesEnum.MillionLiterPerDay, new Guid("1889c1dd-5aa3-45fe-b6cb-79a760e44832")},  // million liter per day
         {UnitChoicesEnum.MillionStandardCubicFootPerDay, new Guid("f1c76ab3-8e54-4ad1-a7fe-a09be2a61285")},  // million standard cubic foot per day
         {UnitChoicesEnum.MillionUKGallonPerDay, new Guid("f083576e-1d99-4243-bcfa-5ca6093b6931")},  // million UK gallon per day
         {UnitChoicesEnum.MillionUSGallonPerDay, new Guid("ffe9958a-3daa-472d-87ab-0b1217dcb1c5")} // million US gallon per day
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
  public partial class HeatTransferCoefficientDrillingQuantity : HeatTransferCoefficientQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class HeightDrillingQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Metre,  // metre
         Millimetre,  // millimetre
         Centimetre,  // centimetre
         Decimetre,  // decimetre
         Hectometre,  // hectometre
         Kilometre,  // kilometre
         Inch,  // inch
         Foot,  // foot
         Yard,  // yard
         Mile // mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Millimetre, new Guid("0b2094f1-ba22-4b7b-888a-7a6b5da2ba25")},  // millimetre
         {UnitChoicesEnum.Centimetre, new Guid("96a3d4b4-c321-4528-92c0-7a52646b6461")},  // centimetre
         {UnitChoicesEnum.Decimetre, new Guid("e84c1968-cc63-412e-82c1-93ed39a43c01")},  // decimetre
         {UnitChoicesEnum.Hectometre, new Guid("cb5c81a3-b9da-42b5-a2ea-0509df445d01")},  // hectometre
         {UnitChoicesEnum.Kilometre, new Guid("93aee1b8-653d-4841-b948-10460cb84334")},  // kilometre
         {UnitChoicesEnum.Inch, new Guid("0a6e2349-6f90-4ac5-baed-ccdaf5e5b919")},  // inch
         {UnitChoicesEnum.Foot, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // foot
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
  public partial class HookLoadDrillingQuantity : ForceQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramForce,  // kilogram force
         Decanewton,  // decanewton
         PoundForce,  // pound force
         KilopoundForce,  // kilopound force
         Newton,  // newton
         TonneForce // tonne force
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // kilogram force
         {UnitChoicesEnum.Decanewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // decanewton
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")},  // pound force
         {UnitChoicesEnum.KilopoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")},  // kilopound force
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // newton
         {UnitChoicesEnum.TonneForce, new Guid("6d7771d3-01cf-40f0-b5bc-3165cd0e6bea")} // tonne force
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
  public partial class HydraulicConductivityDrillingQuantity : HydraulicConductivityQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class InterfacialTensionDrillingQuantity : InterfacialTensionQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class IsobaricSpecificHeatCapacityDrillingQuantity : IsobaricSpecificHeatCapacityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         JoulePerKilogramKelvin,  // joule per kilogram kelvin
         JoulePerGramKelvin,  // joule per gram kelvin
         JoulePerGramDegreeCelsius,  // joule per gram degree celsius
         CaloriePerGramDegreeCelsius,  // calorie per gram degree celsius
         BritishThermalUnitPerPoundDegreeFahrenheit // british thermal unit per pound degree fahrenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.JoulePerKilogramKelvin, new Guid("52d9523e-546b-41dd-b283-a125447433a3")},  // joule per kilogram kelvin
         {UnitChoicesEnum.JoulePerGramKelvin, new Guid("0c38001b-ecba-4920-ac75-e4644d8feced")},  // joule per gram kelvin
         {UnitChoicesEnum.JoulePerGramDegreeCelsius, new Guid("5b620d63-2269-42d3-8385-edca04c7ea70")},  // joule per gram degree celsius
         {UnitChoicesEnum.CaloriePerGramDegreeCelsius, new Guid("bb241c58-e76c-4d96-81c1-356b3f2ad397")},  // calorie per gram degree celsius
         {UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFahrenheit, new Guid("ad9274f2-4c1a-45fe-97c1-710f00deca16")} // british thermal unit per pound degree fahrenheit
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
  public partial class IsobaricSpecificHeatCapacityGradientPerTemperatureDrillingQuantity : IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class MassDensityDrillingQuantity : MassDensityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetre,  // kilogram per cubic metre
         GramPerCubicCentimetre,  // gram per cubic centimetre
         GramPerCubicMetre,  // gram per cubic metre
         PoundPerCubicFoot,  // pound per cubic foot
         PoundPerGallonUK,  // pound per gallon (UK)
         PoundPerGallonUS,  // pound per gallon (US)
         SpecificGravity // specific gravity
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetre, new Guid("8e175ca0-08f6-441d-afcf-a58bbe429abf")},  // kilogram per cubic metre
         {UnitChoicesEnum.GramPerCubicCentimetre, new Guid("64f1b0d8-609f-4ed9-99da-52e18fe97450")},  // gram per cubic centimetre
         {UnitChoicesEnum.GramPerCubicMetre, new Guid("8c5b7fc3-0ade-4e85-9646-71ec5fcb869a")},  // gram per cubic metre
         {UnitChoicesEnum.PoundPerCubicFoot, new Guid("f7479c8c-8d03-460b-bfa3-2b68808be935")},  // pound per cubic foot
         {UnitChoicesEnum.PoundPerGallonUK, new Guid("75ecf787-8778-4d74-afc7-498e117d27bf")},  // pound per gallon (UK)
         {UnitChoicesEnum.PoundPerGallonUS, new Guid("dcc01dd0-4610-42c7-9a55-2ddeb45ef6da")},  // pound per gallon (US)
         {UnitChoicesEnum.SpecificGravity, new Guid("da94ba95-4494-45af-bf99-31f00031c680")} // specific gravity
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
  public partial class MassDensityGradientPerLengthDrillingQuantity : MassDensityGradientPerLengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerMetre,  // kilogram per cubic metre per metre
         GramPerCubicCentimetrePer100Metre,  // gram per cubic centimetre per 100 metre
         PoundPerGallonUKPer100Foot,  // pound per gallon (UK) per 100 foot
         PoundPerGallonUKPer30Foot,  // pound per gallon (UK) per 30 foot
         PoundPerGallonUKPerFoot,  // pound per gallon (UK) per foot
         PoundPerGallonUSPer100Foot,  // pound per gallon (US) per 100 foot
         PoundPerGallonUSPer30Foot,  // pound per gallon (US) per 30 foot
         PoundPerGallonUSPerFoot,  // pound per gallon (US) per foot
         SpecificGravityPer100Metre,  // specific gravity per 100 metre
         SpecificGravityPer10Metre,  // specific gravity per 10 metre
         SpecificGravityPer30Metre,  // specific gravity per 30 metre
         SpecificGravityPerMetre // specific gravity per metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerMetre, new Guid("00707a6a-2e33-4214-9f8c-3e64eaa82ec1")},  // kilogram per cubic metre per metre
         {UnitChoicesEnum.GramPerCubicCentimetrePer100Metre, new Guid("361f976c-6271-41d2-8da3-6b4009cf5e06")},  // gram per cubic centimetre per 100 metre
         {UnitChoicesEnum.PoundPerGallonUKPer100Foot, new Guid("f4b6b8a9-c222-4ac9-a6bb-072a9ca7d567")},  // pound per gallon (UK) per 100 foot
         {UnitChoicesEnum.PoundPerGallonUKPer30Foot, new Guid("684acd16-b420-4952-bc42-ffb47044074d")},  // pound per gallon (UK) per 30 foot
         {UnitChoicesEnum.PoundPerGallonUKPerFoot, new Guid("f2e67c73-3706-4c14-b23a-afe474b2ecbe")},  // pound per gallon (UK) per foot
         {UnitChoicesEnum.PoundPerGallonUSPer100Foot, new Guid("658a9698-d34b-4a56-9ee3-3cf6e46a52a3")},  // pound per gallon (US) per 100 foot
         {UnitChoicesEnum.PoundPerGallonUSPer30Foot, new Guid("389150f0-4602-4468-bba3-a8eaf1d36ca0")},  // pound per gallon (US) per 30 foot
         {UnitChoicesEnum.PoundPerGallonUSPerFoot, new Guid("56128f8e-f59e-4f30-927b-35acb6ab44b1")},  // pound per gallon (US) per foot
         {UnitChoicesEnum.SpecificGravityPer100Metre, new Guid("af987ef2-c8e5-470a-bc53-b2fff05d2c6a")},  // specific gravity per 100 metre
         {UnitChoicesEnum.SpecificGravityPer10Metre, new Guid("4af1c9f0-480c-4e80-a62b-c6b57b486c3f")},  // specific gravity per 10 metre
         {UnitChoicesEnum.SpecificGravityPer30Metre, new Guid("f8499728-220b-4b2d-94b2-3dc2cdfa6a92")},  // specific gravity per 30 metre
         {UnitChoicesEnum.SpecificGravityPerMetre, new Guid("07964c1e-b0d5-4785-bee4-8b4b8882b8b2")} // specific gravity per metre
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
  public partial class MassDensityGradientPerTemperatureDrillingQuantity : MassDensityGradientPerTemperatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerKelvin,  // kilogram per cubic metre per kelvin
         GramPerCubicCentimetrePerCelsius,  // gram per cubic centimetre per celsius
         PoundPerGallonUKPerCelsius,  // pound per gallon (UK) per celsius
         PoundPerGallonUSPerFahrenheit,  // pound per gallon (US) per fahrenheit
         SpecificGravityPerCelsius // specific gravity per celsius
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerKelvin, new Guid("8b947453-ebe8-4fa9-b59a-87557150e1cf")},  // kilogram per cubic metre per kelvin
         {UnitChoicesEnum.GramPerCubicCentimetrePerCelsius, new Guid("e78e2b25-e0a7-4c06-b6df-60f97f767a20")},  // gram per cubic centimetre per celsius
         {UnitChoicesEnum.PoundPerGallonUKPerCelsius, new Guid("edac57eb-7535-447f-bcf9-0c6709b6ae3b")},  // pound per gallon (UK) per celsius
         {UnitChoicesEnum.PoundPerGallonUSPerFahrenheit, new Guid("397a5f98-842e-4d86-8fb7-f4f2f82e720b")},  // pound per gallon (US) per fahrenheit
         {UnitChoicesEnum.SpecificGravityPerCelsius, new Guid("2b1d68c0-4e75-4e9d-92a1-37d501e7cb3e")} // specific gravity per celsius
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
  public partial class MassDensityRateOfChangeDrillingQuantity : MassDensityRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerSecond,  // kilogram per cubic metre per second
         GramPerCubicCentimetrePerHour,  // gram per cubic centimetre per hour
         PoundPerGallonUKPerHour,  // pound per gallon (UK) per hour
         PoundPerGallonUKPerMinute,  // pound per gallon (UK) per minute
         PoundPerGallonUKPerSecond,  // pound per gallon (UK) per second
         PoundPerGallonUSPerHour,  // pound per gallon (US) per hour
         PoundPerGallonUSPerMinute,  // pound per gallon (US) per minute
         PoundPerGallonUSPerSecond,  // pound per gallon (US) per second
         SpecificGravityPerHour,  // specific gravity per hour
         SpecificGravityPerMinute,  // specific gravity per minute
         SpecificGravityPerSecond // specific gravity per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerSecond, new Guid("d80197aa-f0b2-4a26-a5a4-b132a248c377")},  // kilogram per cubic metre per second
         {UnitChoicesEnum.GramPerCubicCentimetrePerHour, new Guid("c8d6a682-00ca-4d0f-b603-bf2d755f4b31")},  // gram per cubic centimetre per hour
         {UnitChoicesEnum.PoundPerGallonUKPerHour, new Guid("5b461e39-d632-4f5e-b7e7-ef30745e5070")},  // pound per gallon (UK) per hour
         {UnitChoicesEnum.PoundPerGallonUKPerMinute, new Guid("e79c74b9-774d-4695-81d5-75042f268b96")},  // pound per gallon (UK) per minute
         {UnitChoicesEnum.PoundPerGallonUKPerSecond, new Guid("e5a712d2-b874-4e7a-873e-a4f4f3ec7a67")},  // pound per gallon (UK) per second
         {UnitChoicesEnum.PoundPerGallonUSPerHour, new Guid("822327d4-9f7c-4e91-9528-4eff5dfc9643")},  // pound per gallon (US) per hour
         {UnitChoicesEnum.PoundPerGallonUSPerMinute, new Guid("c047d53d-38f3-4dce-b590-1c9ab700a3ea")},  // pound per gallon (US) per minute
         {UnitChoicesEnum.PoundPerGallonUSPerSecond, new Guid("eee6814a-d701-4cd8-b392-ebfedde20e11")},  // pound per gallon (US) per second
         {UnitChoicesEnum.SpecificGravityPerHour, new Guid("ce5d34b0-d7ab-48a4-87c1-9a43fabf5c06")},  // specific gravity per hour
         {UnitChoicesEnum.SpecificGravityPerMinute, new Guid("9c314f49-3297-4f7b-9cf3-5da32ba2f1cc")},  // specific gravity per minute
         {UnitChoicesEnum.SpecificGravityPerSecond, new Guid("dec0a290-ffd8-4fc0-ae11-3a6068469791")} // specific gravity per second
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
  public partial class MassDrillingQuantity : MassQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class MassGradientPerLengthDrillingQuantity : MassGradientPerLengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerMetre,  // kilogram per metre
         PoundPerFoot // pound per foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerMetre, new Guid("c8b4a6ea-29bf-4e5a-b7ce-9142cefc0752")},  // kilogram per metre
         {UnitChoicesEnum.PoundPerFoot, new Guid("6fdf4cb6-a43b-482d-9bc8-d4ad49770f9e")} // pound per foot
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
  public partial class MassRateDrillingQuantity : MassRateQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerSecond,  // kilogram per second
         KilogramPerMinute // kilogram per minute
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerSecond, new Guid("a2daceb8-7705-4c97-9945-b354ea1ff78d")},  // kilogram per second
         {UnitChoicesEnum.KilogramPerMinute, new Guid("b776ae6f-5b86-462c-b815-2608d7e98192")} // kilogram per minute
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
  public partial class NozzleDiameterDrillingQuantity : LengthSmallQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class PlaneAngleDrillingQuantity : PlaneAngleQuantity
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
  public partial class PorousMediumPermeabilityDrillingQuantity : PorousMediumPermeabilityQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class PositionDrillingQuantity : LengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Metre,  // metre
         Kilometre,  // kilometre
         Foot,  // foot
         USSurveyFoot,  // US survey foot
         Yard,  // yard
         Surveyor_sChain,  // surveyor's chain
         Mile // mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Metre, new Guid("cc442e11-bb28-4e51-9074-87df66050d8a")},  // metre
         {UnitChoicesEnum.Kilometre, new Guid("93aee1b8-653d-4841-b948-10460cb84334")},  // kilometre
         {UnitChoicesEnum.Foot, new Guid("b4adebce-d0cd-417a-b38c-ab4a2e38233a")},  // foot
         {UnitChoicesEnum.USSurveyFoot, new Guid("eaf5909f-c68e-4346-9517-1dafad48b161")},  // US survey foot
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
  public partial class PowerDrillingQuantity : PowerQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Watt,  // watt
         Kilowatt,  // kilowatt
         Megawatt // megawatt
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Watt, new Guid("9d986a0c-700f-4448-a48c-a028bbd22049")},  // watt
         {UnitChoicesEnum.Kilowatt, new Guid("016b23c7-0231-45bb-8723-5d3d4cc5c054")},  // kilowatt
         {UnitChoicesEnum.Megawatt, new Guid("5719b5f3-5c24-46d2-8ccd-0a06cc6b49ae")} // megawatt
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
  public partial class PressureDrillingQuantity : PressureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Pascal,  // pascal
         Bar,  // bar
         PoundPerSquareInch,  // pound per square inch
         Kilopascal,  // kilopascal
         Megapascal,  // megapascal
         KilopoundPerSquareInch // kilopound per square inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Pascal, new Guid("4f8ebaf4-cd1b-4714-a609-0a9fbe44cafb")},  // pascal
         {UnitChoicesEnum.Bar, new Guid("0d182739-f8f6-47a6-afcb-71feac973307")},  // bar
         {UnitChoicesEnum.PoundPerSquareInch, new Guid("afce482e-a8cf-47f8-85c1-22595d5b5485")},  // pound per square inch
         {UnitChoicesEnum.Kilopascal, new Guid("a41c04f5-198b-4a04-b90a-5700412a2a29")},  // kilopascal
         {UnitChoicesEnum.Megapascal, new Guid("4ef28797-f416-4d97-b36a-711ea848bcc0")},  // megapascal
         {UnitChoicesEnum.KilopoundPerSquareInch, new Guid("a07b5fe5-87e3-4422-afe1-f54de24deeb8")} // kilopound per square inch
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
  public partial class PressureGradientPerLengthDrillingQuantity : PressureGradientPerLengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalPerMetre,  // pascal per metre
         BarPerMetre,  // bar per metre
         PsiPerFoot,  // psi per foot
         PsiPerMetre // psi per metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalPerMetre, new Guid("f5a37831-4a70-44de-af34-4f6ce1a54af3")},  // pascal per metre
         {UnitChoicesEnum.BarPerMetre, new Guid("73a70891-87cf-44fc-8437-94938f034eec")},  // bar per metre
         {UnitChoicesEnum.PsiPerFoot, new Guid("b99cef5c-d6df-4803-b52b-6050cf7e7ff8")},  // psi per foot
         {UnitChoicesEnum.PsiPerMetre, new Guid("2235a51b-cdf2-4f53-9664-b7a968dbbba3")} // psi per metre
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
  public partial class PressureLossConstantDrillingQuantity : PressureLossConstantQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class PressureRateOfChangeDrillingQuantity : PressureRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         PascalPerSecond,  // pascal per second
         BarPerSecond,  // bar per second
         PoundPerSquareInchPerSecond,  // pound per square inch per second
         KilopascalPerSecond,  // kilopascal per second
         MegapascalPerSecond,  // megapascal per second
         KilopoundPerSquareInchPerSecond,  // kilopound per square inch per second
         PascalPerMinute,  // pascal per minute
         BarPerMinute,  // bar per minute
         PoundPerSquareInchPerMinute,  // pound per square inch per minute
         KilopascalPerMinute,  // kilopascal per minute
         MegapascalPerMinute,  // megapascal per minute
         KilopoundPerSquareInchPerMinute,  // kilopound per square inch per minute
         PascalPerHour,  // pascal per hour
         BarPerHour,  // bar per hour
         PoundPerSquareInchPerHour,  // pound per square inch per hour
         KilopascalPerHour,  // kilopascal per hour
         MegapascalPerHour,  // megapascal per hour
         KilopoundPerSquareInchPerHour // kilopound per square inch per hour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.PascalPerSecond, new Guid("146c6da5-9de1-4c41-b6dd-9a7757b14ebf")},  // pascal per second
         {UnitChoicesEnum.BarPerSecond, new Guid("3bd0765c-d3ca-45e9-9818-d70dbd225fdc")},  // bar per second
         {UnitChoicesEnum.PoundPerSquareInchPerSecond, new Guid("6c065cb9-edcc-4093-a81e-dcba0711ab0c")},  // pound per square inch per second
         {UnitChoicesEnum.KilopascalPerSecond, new Guid("92faa8ae-3f6f-4bd3-97ef-19709f9b7a43")},  // kilopascal per second
         {UnitChoicesEnum.MegapascalPerSecond, new Guid("364ded63-6e4f-4d9b-ac57-d3bff57cc36a")},  // megapascal per second
         {UnitChoicesEnum.KilopoundPerSquareInchPerSecond, new Guid("90dd9c87-07f1-4f62-9098-029f78343309")},  // kilopound per square inch per second
         {UnitChoicesEnum.PascalPerMinute, new Guid("e598bc6c-1858-448e-b6c2-dbefdfe517a7")},  // pascal per minute
         {UnitChoicesEnum.BarPerMinute, new Guid("d5064ac5-0f02-437a-8d93-004ca9301b88")},  // bar per minute
         {UnitChoicesEnum.PoundPerSquareInchPerMinute, new Guid("34e3dd46-c61b-4109-91f9-704a94e4a827")},  // pound per square inch per minute
         {UnitChoicesEnum.KilopascalPerMinute, new Guid("1bd828ef-e6a8-4c6b-954e-83d076d81b5b")},  // kilopascal per minute
         {UnitChoicesEnum.MegapascalPerMinute, new Guid("a1442a08-69f3-461e-82c5-e53e0322b266")},  // megapascal per minute
         {UnitChoicesEnum.KilopoundPerSquareInchPerMinute, new Guid("fd5479cd-6a86-43ba-bbbf-142068a903ee")},  // kilopound per square inch per minute
         {UnitChoicesEnum.PascalPerHour, new Guid("bc8c071a-2c0a-4617-90c1-af5e00ec7e94")},  // pascal per hour
         {UnitChoicesEnum.BarPerHour, new Guid("387befbe-ad5a-46b5-a1a1-b55bebf96a12")},  // bar per hour
         {UnitChoicesEnum.PoundPerSquareInchPerHour, new Guid("94ce97e6-e2aa-4240-bb5f-e713abe880ad")},  // pound per square inch per hour
         {UnitChoicesEnum.KilopascalPerHour, new Guid("618f23ff-90af-416c-8d1a-a90bc421a6de")},  // kilopascal per hour
         {UnitChoicesEnum.MegapascalPerHour, new Guid("a7ed3518-a18f-4edf-b739-0b65961a3b60")},  // megapascal per hour
         {UnitChoicesEnum.KilopoundPerSquareInchPerHour, new Guid("837e7f8f-9e02-4438-9425-9d4aca0c227a")} // kilopound per square inch per hour
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
  public partial class RandomWalkDrillingQuantity : RandomWalkQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class RateOfPenetrationDrillingQuantity : VelocityQuantity
  {
    public new enum UnitChoicesEnum 
      {
         MetrePerSecond,  // metre per second
         MetrePerHour,  // metre per hour
         FootPerSecond,  // foot per second
         FootPerHour // foot per hour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.MetrePerSecond, new Guid("919ac736-9a37-45d1-8c02-54bc453d65dc")},  // metre per second
         {UnitChoicesEnum.MetrePerHour, new Guid("b4867c19-0668-4043-b3b9-f666f7552b02")},  // metre per hour
         {UnitChoicesEnum.FootPerSecond, new Guid("6c9eef39-29f0-4d6d-ae7a-f9161d8fd4fa")},  // foot per second
         {UnitChoicesEnum.FootPerHour, new Guid("adb3b459-aa7e-4639-ad07-6d19c80f8170")} // foot per hour
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
  public partial class ReciprocalLengthSurveyInstrumentDrillingQuantity : WaveNumberQuantity
  {
    public new enum UnitChoicesEnum 
      {
         ReciprocalMetre,  // reciprocal metre
         ReciprocalDecametre,  // reciprocal decametre
         ReciprocalHectometre,  // reciprocal hectometre
         ReciprocalKilometre,  // reciprocal kilometre
         ReciprocalFoot,  // reciprocal foot
         ReciprocalYard,  // reciprocal yard
         ReciprocalMile // reciprocal mile
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.ReciprocalMetre, new Guid("3cd38922-b99f-45bb-af6e-a38ebf1240f0")},  // reciprocal metre
         {UnitChoicesEnum.ReciprocalDecametre, new Guid("a691338d-1916-4355-b6e1-3b1bff086c14")},  // reciprocal decametre
         {UnitChoicesEnum.ReciprocalHectometre, new Guid("4da19df4-0ff6-424b-a2ab-9d5811ba48ca")},  // reciprocal hectometre
         {UnitChoicesEnum.ReciprocalKilometre, new Guid("a4b4ed8e-a1c6-4e3f-9421-8770cec6ff42")},  // reciprocal kilometre
         {UnitChoicesEnum.ReciprocalFoot, new Guid("1d6a5284-d32f-4f5a-ad27-bfc0f71069aa")},  // reciprocal foot
         {UnitChoicesEnum.ReciprocalYard, new Guid("be5f64c0-592a-4f3b-b2b5-6df8b9d2a31b")},  // reciprocal yard
         {UnitChoicesEnum.ReciprocalMile, new Guid("acbb10a5-602f-423b-bc15-bdfd80cb7008")} // reciprocal mile
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
  public partial class RotationalFrequencyRateOfChangeDrillingQuantity : RotationalFrequencyRateOfChangeQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class StickDurationDrillingQuantity : TimeQuantity
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
  public partial class SurfacePoreDrillingQuantity : AreaQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMetre,  // square metre
         SquareMillimetre,  // square millimetre
         SquareMicrometre,  // square micrometre
         SquareFoot // square foot
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMetre, new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee")},  // square metre
         {UnitChoicesEnum.SquareMillimetre, new Guid("0b87d221-284a-4e8c-8a60-50c522f9ade4")},  // square millimetre
         {UnitChoicesEnum.SquareMicrometre, new Guid("bec98c97-72c7-4485-9138-058ed14e7fbe")},  // square micrometre
         {UnitChoicesEnum.SquareFoot, new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248")} // square foot
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
  public partial class TemperatureDrillingQuantity : TemperatureQuantity
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
  public partial class TemperatureGradientPerLengthDrillingQuantity : TemperatureGradientPerLengthQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class TensionDrillingQuantity : TensionQuantity
  {
    public new enum UnitChoicesEnum 
      {
         Newton,  // newton
         Decanewton,  // decanewton
         Kilodecanewton,  // kilodecanewton
         KilogramForce,  // kilogram force
         Kilonewton,  // kilonewton
         KilopoundForce,  // kilopound force
         PoundForce // pound force
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // newton
         {UnitChoicesEnum.Decanewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // decanewton
         {UnitChoicesEnum.Kilodecanewton, new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266")},  // kilodecanewton
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // kilogram force
         {UnitChoicesEnum.Kilonewton, new Guid("e30d6f94-7887-4746-8d4f-eb720239b702")},  // kilonewton
         {UnitChoicesEnum.KilopoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")},  // kilopound force
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")} // pound force
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
  public partial class ThermalConductivityDrillingQuantity : ThermalConductivityQuantity
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class ThermalConductivityGradientPerTemperatureDrillingQuantity : ThermalConductivityGradientPerTemperatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         WattPerMetreKelvinPerKelvin,  // watt per metre kelvin per kelvin
         BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared,  // british thermal unit inch per hour square foot degree fahrenheit squared
         BritishThermalUnitPerHourFootDegreeFahrenheitSquared,  // british thermal unit per hour foot degree fahrenheit squared
         CaloriePerCentimetreSecondDegreeCelsiusSquared,  // calorie per centimetre second degree celsius squared
         CaloriePerMetreSecondDegreeCelsiusSquared // calorie per metre second degree celsius squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.WattPerMetreKelvinPerKelvin, new Guid("0459940e-d71f-4b01-9ea6-eeb05d754af2")},  // watt per metre kelvin per kelvin
         {UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared, new Guid("918b4e34-3986-427f-8bb6-c09740a7c299")},  // british thermal unit inch per hour square foot degree fahrenheit squared
         {UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheitSquared, new Guid("b79509ea-8c03-4538-9974-208f7e0ee40e")},  // british thermal unit per hour foot degree fahrenheit squared
         {UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsiusSquared, new Guid("6c21a6cd-61fe-4086-95a7-ad6d6820c96e")},  // calorie per centimetre second degree celsius squared
         {UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsiusSquared, new Guid("eb08ff8c-d542-440f-a4c7-610653018910")} // calorie per metre second degree celsius squared
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
  public partial class TorqueDrillingQuantity : TorqueQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonMetre,  // newton metre
         FootPound,  // foot pound
         KilofootPound,  // kilofoot pound
         DecanewtonMetre,  // decanewton metre
         KilogramForceMetre,  // kilogram force metre
         KilonewtonMetre // kilonewton metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonMetre, new Guid("50b017fa-8d81-4076-a485-61de1d8301b5")},  // newton metre
         {UnitChoicesEnum.FootPound, new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51")},  // foot pound
         {UnitChoicesEnum.KilofootPound, new Guid("ee9be6ed-df75-4915-be6a-e3941dacd6bd")},  // kilofoot pound
         {UnitChoicesEnum.DecanewtonMetre, new Guid("501ce02c-8a5d-46e6-9ab6-ce443df70402")},  // decanewton metre
         {UnitChoicesEnum.KilogramForceMetre, new Guid("282f97a0-df2a-4016-9ab0-796db49ff384")},  // kilogram force metre
         {UnitChoicesEnum.KilonewtonMetre, new Guid("2e417a6e-1acc-4901-8704-7dfeb3f67546")} // kilonewton metre
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
  public partial class TorqueGradientPerLengthDrillingQuantity : TorqueGradientPerLengthQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonMetrePerMetre,  // newton metre per metre
         KilonewtonMetrePerMetre,  // kilonewton metre per metre
         DecanewtonMetrePerMetre,  // decanewton metre per metre
         FootPoundPerFoot,  // foot pound per foot
         KilofootPoundPerFoot,  // kilofoot pound per foot
         FootPoundPerMetre,  // foot pound per metre
         KilofootPoundPerMetre // kilofoot pound per metre
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonMetrePerMetre, new Guid("33baa8d7-6987-4217-959b-1e3aa5b04752")},  // newton metre per metre
         {UnitChoicesEnum.KilonewtonMetrePerMetre, new Guid("d07e4c6c-fea3-4545-b020-9cc2402e1ca5")},  // kilonewton metre per metre
         {UnitChoicesEnum.DecanewtonMetrePerMetre, new Guid("50a1ea8d-9a46-4e24-9e9f-dad66e8bb9ca")},  // decanewton metre per metre
         {UnitChoicesEnum.FootPoundPerFoot, new Guid("85a75741-c967-4e10-b195-01e5e7297eda")},  // foot pound per foot
         {UnitChoicesEnum.KilofootPoundPerFoot, new Guid("65606e85-199d-4fee-8cd4-97715431d868")},  // kilofoot pound per foot
         {UnitChoicesEnum.FootPoundPerMetre, new Guid("e3b4fe22-6590-4b2d-b2fa-0250f1ca8b26")},  // foot pound per metre
         {UnitChoicesEnum.KilofootPoundPerMetre, new Guid("e9bff76e-5388-4ea0-85af-62c772d919c5")} // kilofoot pound per metre
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
  public partial class TorqueRateOfChangeDrillingQuantity : TorqueRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         NewtonMetrePerSecond,  // newton metre per second
         FootPoundPerSecond,  // foot pound per second
         KilofootPoundPerSecond,  // kilofoot pound per second
         DecanewtonMetrePerSecond,  // decanewton metre per second
         KilogramForceMetrePerSecond,  // kilogram force metre per second
         KilonewtonMetrePerSecond,  // kilonewton metre per second
         NewtonMetrePerMinute,  // newton metre per minute
         FootPoundPerMinute,  // foot pound per minute
         KilofootPoundPerMinute,  // kilofoot pound per minute
         DecanewtonMetrePerMinute,  // decanewton metre per minute
         KilogramForceMetrePerMinute,  // kilogram force metre per minute
         KilonewtonMetrePerMinute,  // kilonewton metre per minute
         NewtonMetrePerHour,  // newton metre per hour
         FootPoundPerHour,  // foot pound per hour
         KilofootPoundPerHour,  // kilofoot pound per hour
         DecanewtonMetrePerHour,  // decanewton metre per hour
         KilogramForceMetrePerHour,  // kilogram force metre per hour
         KilonewtonMetrePerHour // kilonewton metre per hour
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.NewtonMetrePerSecond, new Guid("0af9bebb-adde-49b9-bf0b-0d5002e454a2")},  // newton metre per second
         {UnitChoicesEnum.FootPoundPerSecond, new Guid("e53f2ab8-0883-4a6f-ae67-9f660eb20368")},  // foot pound per second
         {UnitChoicesEnum.KilofootPoundPerSecond, new Guid("6166acf4-c3bd-439c-b4a9-6f0282c18731")},  // kilofoot pound per second
         {UnitChoicesEnum.DecanewtonMetrePerSecond, new Guid("a6672d76-f845-47ce-9d67-7f1242ba9f60")},  // decanewton metre per second
         {UnitChoicesEnum.KilogramForceMetrePerSecond, new Guid("6150a99d-34f0-438b-a8d3-038b8864c19f")},  // kilogram force metre per second
         {UnitChoicesEnum.KilonewtonMetrePerSecond, new Guid("0875163d-a610-4e0d-8e05-5fe56896e44f")},  // kilonewton metre per second
         {UnitChoicesEnum.NewtonMetrePerMinute, new Guid("8c3ab891-e5bc-4fa1-9f14-a3250e062ef4")},  // newton metre per minute
         {UnitChoicesEnum.FootPoundPerMinute, new Guid("66567700-9838-48f0-aa21-672c21380f57")},  // foot pound per minute
         {UnitChoicesEnum.KilofootPoundPerMinute, new Guid("dfa752eb-792f-4eb1-9eaa-e32f497a1ea2")},  // kilofoot pound per minute
         {UnitChoicesEnum.DecanewtonMetrePerMinute, new Guid("a1b76c0a-7ef2-46df-8d5b-0253a5dd42e8")},  // decanewton metre per minute
         {UnitChoicesEnum.KilogramForceMetrePerMinute, new Guid("91fa2fa9-d0dc-4d26-b694-2eac6ee7ad92")},  // kilogram force metre per minute
         {UnitChoicesEnum.KilonewtonMetrePerMinute, new Guid("746fdf99-afde-483d-88d4-e512b46efe3e")},  // kilonewton metre per minute
         {UnitChoicesEnum.NewtonMetrePerHour, new Guid("c17eae23-0496-4fa1-a389-aa24828fa243")},  // newton metre per hour
         {UnitChoicesEnum.FootPoundPerHour, new Guid("b55029ec-fadc-46da-a3b8-a48a08f4d92f")},  // foot pound per hour
         {UnitChoicesEnum.KilofootPoundPerHour, new Guid("18156d8f-dd9f-4b63-a138-18827cafc14d")},  // kilofoot pound per hour
         {UnitChoicesEnum.DecanewtonMetrePerHour, new Guid("3907090e-c10e-41dc-95cf-634e1a28bb11")},  // decanewton metre per hour
         {UnitChoicesEnum.KilogramForceMetrePerHour, new Guid("6295ae90-c198-499e-a90d-8dba22c77584")},  // kilogram force metre per hour
         {UnitChoicesEnum.KilonewtonMetrePerHour, new Guid("e35e63cc-09dc-4d8a-bb5d-b0a0c24998f8")} // kilonewton metre per hour
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
  public partial class VolumeDrillingQuantity : VolumeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetre,  // cubic metre
         Litre,  // litre
         USGallon,  // US gallon
         UKGallon // UK gallon
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetre, new Guid("a465ba87-53d6-456c-8e74-315a1a212498")},  // cubic metre
         {UnitChoicesEnum.Litre, new Guid("3f713743-6248-4b0b-8f3b-c97b6fab76b1")},  // litre
         {UnitChoicesEnum.USGallon, new Guid("1377d8ac-d203-48ed-bad4-733b0dc9d496")},  // US gallon
         {UnitChoicesEnum.UKGallon, new Guid("78f1cef7-c489-498c-96fb-d37474e242a9")} // UK gallon
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
  public partial class VolumetricFlowrateDrillingQuantity : VolumetricFlowRateQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetrePerSecond,  // cubic metre per second
         LitrePerMinute,  // litre per minute
         UKGallonPerMinute,  // UK gallon per minute
         USGallonPerMinute // US gallon per minute
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetrePerSecond, new Guid("fabe7a23-1ba2-4f5d-b3f5-d5729166c7a0")},  // cubic metre per second
         {UnitChoicesEnum.LitrePerMinute, new Guid("e1ff1684-02ed-41c0-a82c-40b4a6d348b5")},  // litre per minute
         {UnitChoicesEnum.UKGallonPerMinute, new Guid("bb1d3fbc-efc1-4cf7-9c13-33c25a874224")},  // UK gallon per minute
         {UnitChoicesEnum.USGallonPerMinute, new Guid("ceca76e7-fd1e-4220-b072-9f40467a05e3")} // US gallon per minute
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
  public partial class VolumetricFlowRateOfChangeDrillingQuantity : VolumetricFlowRateOfChangeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetrePerSecondSquared,  // cubic metre per second squared
         LitrePerMinutePerSecond,  // litre per minute per second
         UKGallonPerMinutePerSecond,  // UK gallon per minute per second
         USGallonPerMinutePerSecond // US gallon per minute per second
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetrePerSecondSquared, new Guid("aef20431-be0b-44ea-8770-a59db19b7f94")},  // cubic metre per second squared
         {UnitChoicesEnum.LitrePerMinutePerSecond, new Guid("e5a265b6-a9ba-4a09-ba08-b8c417b28ffb")},  // litre per minute per second
         {UnitChoicesEnum.UKGallonPerMinutePerSecond, new Guid("298e7a16-07a5-4b5b-a0de-3e49b31254b4")},  // UK gallon per minute per second
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
namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class MomentOfInertiaDrillingQuantity : MomentOfInertiaQuantity
  {
    public new enum UnitChoicesEnum 
      {
         GramCentimetreSquared,  // gram centimetre squared
         KilogramMetreSquared,  // kilogram metre squared
         PoundFootSquared,  // pound foot squared
         PoundInchSquared // pound inch squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.GramCentimetreSquared, new Guid("71e4e230-c611-4de9-b056-a1ef732b7fce")},  // gram centimetre squared
         {UnitChoicesEnum.KilogramMetreSquared, new Guid("01c11147-677d-47d2-9167-59601d7961b2")},  // kilogram metre squared
         {UnitChoicesEnum.PoundFootSquared, new Guid("103bd4aa-494a-4ec3-bf60-c3ce5bab364e")},  // pound foot squared
         {UnitChoicesEnum.PoundInchSquared, new Guid("ce8e3a4e-2cea-471a-a0dc-846523001be2")} // pound inch squared
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
  public partial class WeightOnBitDrillingQuantity : ForceQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramForce,  // kilogram force
         Decanewton,  // decanewton
         PoundForce,  // pound force
         KilopoundForce,  // kilopound force
         Newton,  // newton
         TonneForce // tonne force
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramForce, new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad")},  // kilogram force
         {UnitChoicesEnum.Decanewton, new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972")},  // decanewton
         {UnitChoicesEnum.PoundForce, new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa")},  // pound force
         {UnitChoicesEnum.KilopoundForce, new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375")},  // kilopound force
         {UnitChoicesEnum.Newton, new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8")},  // newton
         {UnitChoicesEnum.TonneForce, new Guid("6d7771d3-01cf-40f0-b5bc-3165cd0e6bea")} // tonne force
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
  public partial class MomentOfAreaDrillingQuantity : MomentOfAreaQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CentimetresToTheFourthPower,  // centimetres to the fourth power
         FeetToTheFourthPower,  // feet to the fourth power
         InchesToTheFourthPower,  // inches to the fourth power
         MetresToTheFourthPower // metres to the fourth power
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CentimetresToTheFourthPower, new Guid("1e94dc47-7563-4fb0-9749-e4c88523e1f4")},  // centimetres to the fourth power
         {UnitChoicesEnum.FeetToTheFourthPower, new Guid("d35362a3-1352-4dcd-b425-c376afcf4d36")},  // feet to the fourth power
         {UnitChoicesEnum.InchesToTheFourthPower, new Guid("86914b8d-6a5d-43ee-ad7c-e69fbf6d5087")},  // inches to the fourth power
         {UnitChoicesEnum.MetresToTheFourthPower, new Guid("f479bbab-bdd0-4c33-b13c-6dac1d57539b")} // metres to the fourth power
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
  public partial class TotalFlowAreaDrillingQuantity : AreaQuantity
  {
    public new enum UnitChoicesEnum 
      {
         SquareMetre,  // square metre
         SquareFoot,  // square foot
         SquareDecimetre,  // square decimetre
         SquareYard,  // square yard
         SquareCentimetre,  // square centimetre
         SquareInch // square inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.SquareMetre, new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee")},  // square metre
         {UnitChoicesEnum.SquareFoot, new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248")},  // square foot
         {UnitChoicesEnum.SquareDecimetre, new Guid("125fd8d6-d1eb-4826-a952-5219603409ab")},  // square decimetre
         {UnitChoicesEnum.SquareYard, new Guid("ae3df24c-e5db-4b88-9e81-228f29855f1b")},  // square yard
         {UnitChoicesEnum.SquareCentimetre, new Guid("d74bb2bc-9c86-4be4-bff1-88cac7b1049b")},  // square centimetre
         {UnitChoicesEnum.SquareInch, new Guid("294bc6d0-5be7-4c70-95f3-ad9dc50f02cf")} // square inch
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
  public partial class MassDensityGradientPerPressureDrillingQuantity : MassDensityGradientPerPressureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerPascal,  // kilogram per cubic metre per pascal
         SpecificGravityPerPascal,  // specific gravity per pascal
         GramPerCubicCentimetrePerPascal,  // gram per cubic centimetre per pascal
         PoundPerGallonUKPerPascal,  // pound per gallon (UK) per pascal
         PoundPerGallonUSPerPascal,  // pound per gallon (US) per pascal
         PoundPerCubicFootPerPascal,  // pound per cubic foot per pascal
         PoundPerCubicInchPerPascal,  // pound per cubic inch per pascal
         PoundPerCubicYardPerPascal,  // pound per cubic yard per pascal
         KilogramPerCubicMetrePerBar,  // kilogram per cubic metre per bar
         SpecificGravityPerBar,  // specific gravity per bar
         GramPerCubicCentimetrePerBar,  // gram per cubic centimetre per bar
         PoundPerGallonUKPerBar,  // pound per gallon (UK) per bar
         PoundPerGallonUSPerBar,  // pound per gallon (US) per bar
         PoundPerCubicFootPerBar,  // pound per cubic foot per bar
         PoundPerCubicInchPerBar,  // pound per cubic inch per bar
         PoundPerCubicYardPerBar,  // pound per cubic yard per bar
         KilogramPerCubicMetrePerPoundPerSquareInch,  // kilogram per cubic metre per pound per square inch
         SpecificGravityPerPoundPerSquareInch,  // specific gravity per pound per square inch
         GramPerCubicCentimetrePerPoundPerSquareInch,  // gram per cubic centimetre per pound per square inch
         PoundPerGallonUKPerPoundPerSquareInch,  // pound per gallon (UK) per pound per square inch
         PoundPerGallonUSPerPoundPerSquareInch,  // pound per gallon (US) per pound per square inch
         PoundPerCubicFootPerPoundPerSquareInch,  // pound per cubic foot per pound per square inch
         PoundPerCubicInchPerPoundPerSquareInch,  // pound per cubic inch per pound per square inch
         PoundPerCubicYardPerPoundPerSquareInch // pound per cubic yard per pound per square inch
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerPascal, new Guid("48acbe7c-5fd3-4eaf-9667-adfbfda6c930")},  // kilogram per cubic metre per pascal
         {UnitChoicesEnum.SpecificGravityPerPascal, new Guid("619534ee-a9f5-4420-85ab-dfa218972250")},  // specific gravity per pascal
         {UnitChoicesEnum.GramPerCubicCentimetrePerPascal, new Guid("367f7fe4-b546-4963-accd-38043698916b")},  // gram per cubic centimetre per pascal
         {UnitChoicesEnum.PoundPerGallonUKPerPascal, new Guid("1dafde6f-b7f4-450c-bf9f-4d9063c53df5")},  // pound per gallon (UK) per pascal
         {UnitChoicesEnum.PoundPerGallonUSPerPascal, new Guid("0cb13b7b-d967-41ac-8d55-9dbd9c8a9004")},  // pound per gallon (US) per pascal
         {UnitChoicesEnum.PoundPerCubicFootPerPascal, new Guid("828a496b-d5be-42e2-8551-e49cd53b91e7")},  // pound per cubic foot per pascal
         {UnitChoicesEnum.PoundPerCubicInchPerPascal, new Guid("c8733719-56e5-4db2-a601-09e68bafdc18")},  // pound per cubic inch per pascal
         {UnitChoicesEnum.PoundPerCubicYardPerPascal, new Guid("4fc7d357-c230-4302-922f-05dc98c20953")},  // pound per cubic yard per pascal
         {UnitChoicesEnum.KilogramPerCubicMetrePerBar, new Guid("af23c11a-14cc-42f0-9693-dd8590db64a3")},  // kilogram per cubic metre per bar
         {UnitChoicesEnum.SpecificGravityPerBar, new Guid("c30e40c2-7fa4-47bd-8d62-4e8a33ef660c")},  // specific gravity per bar
         {UnitChoicesEnum.GramPerCubicCentimetrePerBar, new Guid("b49fd006-16ed-404f-afac-a78bd69c210d")},  // gram per cubic centimetre per bar
         {UnitChoicesEnum.PoundPerGallonUKPerBar, new Guid("0c7f7c23-6eee-4201-be51-3598b09f0ade")},  // pound per gallon (UK) per bar
         {UnitChoicesEnum.PoundPerGallonUSPerBar, new Guid("4810318e-813c-4671-92da-edfe64adc62a")},  // pound per gallon (US) per bar
         {UnitChoicesEnum.PoundPerCubicFootPerBar, new Guid("0e0ba903-3d8c-4bdd-82bc-0b4d9a79169d")},  // pound per cubic foot per bar
         {UnitChoicesEnum.PoundPerCubicInchPerBar, new Guid("4691ad34-b973-4f74-aae4-89c0af618805")},  // pound per cubic inch per bar
         {UnitChoicesEnum.PoundPerCubicYardPerBar, new Guid("bfef9341-2dfe-4567-9826-8388839e8bc2")},  // pound per cubic yard per bar
         {UnitChoicesEnum.KilogramPerCubicMetrePerPoundPerSquareInch, new Guid("243a8789-24ba-407c-956a-7665b9ea5012")},  // kilogram per cubic metre per pound per square inch
         {UnitChoicesEnum.SpecificGravityPerPoundPerSquareInch, new Guid("1e56b53b-92a2-4dbc-87cf-143650a30895")},  // specific gravity per pound per square inch
         {UnitChoicesEnum.GramPerCubicCentimetrePerPoundPerSquareInch, new Guid("11a4f910-3071-4e9a-ac07-e7d106c52fd9")},  // gram per cubic centimetre per pound per square inch
         {UnitChoicesEnum.PoundPerGallonUKPerPoundPerSquareInch, new Guid("67712637-814b-4a0e-a858-c6b8bd864fc1")},  // pound per gallon (UK) per pound per square inch
         {UnitChoicesEnum.PoundPerGallonUSPerPoundPerSquareInch, new Guid("6234aef5-1534-47fa-b96b-4d0905832217")},  // pound per gallon (US) per pound per square inch
         {UnitChoicesEnum.PoundPerCubicFootPerPoundPerSquareInch, new Guid("c1d08a1b-9832-4d68-b47b-b113b8d06bf0")},  // pound per cubic foot per pound per square inch
         {UnitChoicesEnum.PoundPerCubicInchPerPoundPerSquareInch, new Guid("28fc5b3b-c94d-4afc-995f-6680dc3125f7")},  // pound per cubic inch per pound per square inch
         {UnitChoicesEnum.PoundPerCubicYardPerPoundPerSquareInch, new Guid("3e04b954-9156-405e-a058-16541687ee43")} // pound per cubic yard per pound per square inch
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
  public partial class MassDensityGradientPerPressureSquaredDrillingQuantity : MassDensityGradientPerPressureSquaredQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerPascalSquared,  // kilogram per cubic metre per pascal squared
         SpecificGravityPerPascalSquared,  // specific gravity per pascal squared
         GramPerCubicCentimetrePerPascalSquared,  // gram per cubic centimetre per pascal squared
         PoundPerGallonUKPerPascalSquared,  // pound per gallon (UK) per pascal squared
         PoundPerGallonUSPerPascalSquared,  // pound per gallon (US) per pascal squared
         PoundPerCubicFootPerPascalSquared,  // pound per cubic foot per pascal squared
         PoundPerCubicInchPerPascalSquared,  // pound per cubic inch per pascal squared
         PoundPerCubicYardPerPascalSquared,  // pound per cubic yard per pascal squared
         KilogramPerCubicMetrePerBarSquared,  // kilogram per cubic metre per bar squared
         SpecificGravityPerBarSquared,  // specific gravity per bar squared
         GramPerCubicCentimetrePerBarSquared,  // gram per cubic centimetre per bar squared
         PoundPerGallonUKPerBarSquared,  // pound per gallon (UK) per bar squared
         PoundPerGallonUSPerBarSquared,  // pound per gallon (US) per bar squared
         PoundPerCubicFootPerBarSquared,  // pound per cubic foot per bar squared
         PoundPerCubicInchPerBarSquared,  // pound per cubic inch per bar squared
         PoundPerCubicYardPerBarSquared,  // pound per cubic yard per bar squared
         KilogramPerCubicMetrePerPoundPerSquareInchSquared,  // kilogram per cubic metre per pound per square inch squared
         SpecificGravityPerPoundPerSquareInchSquared,  // specific gravity per pound per square inch squared
         GramPerCubicCentimetrePerPoundPerSquareInchSquared,  // gram per cubic centimetre per pound per square inch squared
         PoundPerGallonUKPerPoundPerSquareInchSquared,  // pound per gallon (UK) per pound per square inch squared
         PoundPerGallonUSPerPoundPerSquareInchSquared,  // pound per gallon (US) per pound per square inch squared
         PoundPerCubicFootPerPoundPerSquareInchSquared,  // pound per cubic foot per pound per square inch squared
         PoundPerCubicInchPerPoundPerSquareInchSquared,  // pound per cubic inch per pound per square inch squared
         PoundPerCubicYardPerPoundPerSquareInchSquared // pound per cubic yard per pound per square inch squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerPascalSquared, new Guid("f5e08eda-6f5f-480f-b4a1-c678e409c6e0")},  // kilogram per cubic metre per pascal squared
         {UnitChoicesEnum.SpecificGravityPerPascalSquared, new Guid("bbf15986-4411-4187-8186-de8da731a6b4")},  // specific gravity per pascal squared
         {UnitChoicesEnum.GramPerCubicCentimetrePerPascalSquared, new Guid("157c5898-353a-41f1-9924-0d8421cd8154")},  // gram per cubic centimetre per pascal squared
         {UnitChoicesEnum.PoundPerGallonUKPerPascalSquared, new Guid("8930d03e-184e-4bfa-88fa-755f728a3be1")},  // pound per gallon (UK) per pascal squared
         {UnitChoicesEnum.PoundPerGallonUSPerPascalSquared, new Guid("f93f8382-3a4c-454c-9575-c41ed6875656")},  // pound per gallon (US) per pascal squared
         {UnitChoicesEnum.PoundPerCubicFootPerPascalSquared, new Guid("de70ab66-52d6-4e5a-a0e7-a31c442c213f")},  // pound per cubic foot per pascal squared
         {UnitChoicesEnum.PoundPerCubicInchPerPascalSquared, new Guid("4f2d5894-6dc8-4c52-b442-976b8032e04e")},  // pound per cubic inch per pascal squared
         {UnitChoicesEnum.PoundPerCubicYardPerPascalSquared, new Guid("a22f8465-a519-47f9-80c5-5f633b5a3579")},  // pound per cubic yard per pascal squared
         {UnitChoicesEnum.KilogramPerCubicMetrePerBarSquared, new Guid("86d777df-9722-4fb6-861e-025c07589743")},  // kilogram per cubic metre per bar squared
         {UnitChoicesEnum.SpecificGravityPerBarSquared, new Guid("28cb683a-d3a8-4757-8123-cf093cb1d560")},  // specific gravity per bar squared
         {UnitChoicesEnum.GramPerCubicCentimetrePerBarSquared, new Guid("e8b6cc51-e9f8-4705-b486-20999de7d84a")},  // gram per cubic centimetre per bar squared
         {UnitChoicesEnum.PoundPerGallonUKPerBarSquared, new Guid("5245397a-58a4-40d1-8ba4-aa4ea9e3d7cd")},  // pound per gallon (UK) per bar squared
         {UnitChoicesEnum.PoundPerGallonUSPerBarSquared, new Guid("22450e27-b3c7-4a71-9f6e-f979217ca724")},  // pound per gallon (US) per bar squared
         {UnitChoicesEnum.PoundPerCubicFootPerBarSquared, new Guid("d2a23cb1-3ec6-416a-9a77-2c6e4f5ccd09")},  // pound per cubic foot per bar squared
         {UnitChoicesEnum.PoundPerCubicInchPerBarSquared, new Guid("ee8aff8d-f65e-4b09-8e25-5b94d7ad739b")},  // pound per cubic inch per bar squared
         {UnitChoicesEnum.PoundPerCubicYardPerBarSquared, new Guid("e1b7ea9b-d4ba-442b-99f8-a1eeebd35c1d")},  // pound per cubic yard per bar squared
         {UnitChoicesEnum.KilogramPerCubicMetrePerPoundPerSquareInchSquared, new Guid("ed837c52-b9d2-434e-8103-bb75c60b5dee")},  // kilogram per cubic metre per pound per square inch squared
         {UnitChoicesEnum.SpecificGravityPerPoundPerSquareInchSquared, new Guid("4a1459e4-ccfa-4563-ab43-af1ed407311e")},  // specific gravity per pound per square inch squared
         {UnitChoicesEnum.GramPerCubicCentimetrePerPoundPerSquareInchSquared, new Guid("f29096ad-ad1d-4f6e-9354-b9159600b5e8")},  // gram per cubic centimetre per pound per square inch squared
         {UnitChoicesEnum.PoundPerGallonUKPerPoundPerSquareInchSquared, new Guid("41979553-6c36-4f5a-9e62-a6e05bd3c9a2")},  // pound per gallon (UK) per pound per square inch squared
         {UnitChoicesEnum.PoundPerGallonUSPerPoundPerSquareInchSquared, new Guid("6f5b0146-ec8e-4224-9cb3-9ab440b6a006")},  // pound per gallon (US) per pound per square inch squared
         {UnitChoicesEnum.PoundPerCubicFootPerPoundPerSquareInchSquared, new Guid("af1a2b8a-b330-402d-9f9d-e30399b24926")},  // pound per cubic foot per pound per square inch squared
         {UnitChoicesEnum.PoundPerCubicInchPerPoundPerSquareInchSquared, new Guid("17051250-e815-4170-aa12-c222e89742e1")},  // pound per cubic inch per pound per square inch squared
         {UnitChoicesEnum.PoundPerCubicYardPerPoundPerSquareInchSquared, new Guid("f30510ee-c4bb-434b-a185-3805a543404f")} // pound per cubic yard per pound per square inch squared
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
  public partial class MassDensityGradientPerPressureSquaredTemperatureDrillingQuantity : MassDensityGradientPerPressureSquaredTemperatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerPascalSquaredKelvin,  // kilogram per cubic metre per pascal squared kelvin
         SpecificGravityPerPascalSquaredKelvin,  // specific gravity per pascal squared kelvin
         GramPerCubicCentimetrePerPascalSquaredKelvin,  // gram per cubic centimetre per pascal squared kelvin
         PoundPerGallonUKPerPascalSquaredKelvin,  // pound per gallon (UK) per pascal squared kelvin
         PoundPerGallonUSPerPascalSquaredKelvin,  // pound per gallon (US) per pascal squared kelvin
         PoundPerCubicFootPerPascalSquaredKelvin,  // pound per cubic foot per pascal squared kelvin
         PoundPerCubicInchPerPascalSquaredKelvin,  // pound per cubic inch per pascal squared kelvin
         PoundPerCubicYardPerPascalSquaredKelvin,  // pound per cubic yard per pascal squared kelvin
         KilogramPerCubicMetrePerBarSquaredKelvin,  // kilogram per cubic metre per bar squared kelvin
         SpecificGravityPerBarSquaredKelvin,  // specific gravity per bar squared kelvin
         GramPerCubicCentimetrePerBarSquaredKelvin,  // gram per cubic centimetre per bar squared kelvin
         PoundPerGallonUKPerBarSquaredKelvin,  // pound per gallon (UK) per bar squared kelvin
         PoundPerGallonUSPerBarSquaredKelvin,  // pound per gallon (US) per bar squared kelvin
         PoundPerCubicFootPerBarSquaredKelvin,  // pound per cubic foot per bar squared kelvin
         PoundPerCubicInchPerBarSquaredKelvin,  // pound per cubic inch per bar squared kelvin
         PoundPerCubicYardPerBarSquaredKelvin,  // pound per cubic yard per bar squared kelvin
         KilogramPerCubicMetrePerPoundPerSquareInchSquaredKelvin,  // kilogram per cubic metre per pound per square inch squared kelvin
         SpecificGravityPerPoundPerSquareInchSquaredKelvin,  // specific gravity per pound per square inch squared kelvin
         GramPerCubicCentimetrePerPoundPerSquareInchSquaredKelvin,  // gram per cubic centimetre per pound per square inch squared kelvin
         PoundPerGallonUKPerPoundPerSquareInchSquaredKelvin,  // pound per gallon (UK) per pound per square inch squared kelvin
         PoundPerGallonUSPerPoundPerSquareInchSquaredKelvin,  // pound per gallon (US) per pound per square inch squared kelvin
         PoundPerCubicFootPerPoundPerSquareInchSquaredKelvin,  // pound per cubic foot per pound per square inch squared kelvin
         PoundPerCubicInchPerPoundPerSquareInchSquaredKelvin,  // pound per cubic inch per pound per square inch squared kelvin
         PoundPerCubicYardPerPoundPerSquareInchSquaredKelvin,  // pound per cubic yard per pound per square inch squared kelvin
         KilogramPerCubicMetrePerPascalSquaredCelsius,  // kilogram per cubic metre per pascal squared celsius
         SpecificGravityPerPascalSquaredCelsius,  // specific gravity per pascal squared celsius
         GramPerCubicCentimetrePerPascalSquaredCelsius,  // gram per cubic centimetre per pascal squared celsius
         PoundPerGallonUKPerPascalSquaredCelsius,  // pound per gallon (UK) per pascal squared celsius
         PoundPerGallonUSPerPascalSquaredCelsius,  // pound per gallon (US) per pascal squared celsius
         PoundPerCubicFootPerPascalSquaredCelsius,  // pound per cubic foot per pascal squared celsius
         PoundPerCubicInchPerPascalSquaredCelsius,  // pound per cubic inch per pascal squared celsius
         PoundPerCubicYardPerPascalSquaredCelsius,  // pound per cubic yard per pascal squared celsius
         KilogramPerCubicMetrePerBarSquaredCelsius,  // kilogram per cubic metre per bar squared celsius
         SpecificGravityPerBarSquaredCelsius,  // specific gravity per bar squared celsius
         GramPerCubicCentimetrePerBarSquaredCelsius,  // gram per cubic centimetre per bar squared celsius
         PoundPerGallonUKPerBarSquaredCelsius,  // pound per gallon (UK) per bar squared celsius
         PoundPerGallonUSPerBarSquaredCelsius,  // pound per gallon (US) per bar squared celsius
         PoundPerCubicFootPerBarSquaredCelsius,  // pound per cubic foot per bar squared celsius
         PoundPerCubicInchPerBarSquaredCelsius,  // pound per cubic inch per bar squared celsius
         PoundPerCubicYardPerBarSquaredCelsius,  // pound per cubic yard per bar squared celsius
         KilogramPerCubicMetrePerPoundPerSquareInchSquaredCelsius,  // kilogram per cubic metre per pound per square inch squared celsius
         SpecificGravityPerPoundPerSquareInchSquaredCelsius,  // specific gravity per pound per square inch squared celsius
         GramPerCubicCentimetrePerPoundPerSquareInchSquaredCelsius,  // gram per cubic centimetre per pound per square inch squared celsius
         PoundPerGallonUKPerPoundPerSquareInchSquaredCelsius,  // pound per gallon (UK) per pound per square inch squared celsius
         PoundPerGallonUSPerPoundPerSquareInchSquaredCelsius,  // pound per gallon (US) per pound per square inch squared celsius
         PoundPerCubicFootPerPoundPerSquareInchSquaredCelsius,  // pound per cubic foot per pound per square inch squared celsius
         PoundPerCubicInchPerPoundPerSquareInchSquaredCelsius,  // pound per cubic inch per pound per square inch squared celsius
         PoundPerCubicYardPerPoundPerSquareInchSquaredCelsius,  // pound per cubic yard per pound per square inch squared celsius
         KilogramPerCubicMetrePerPascalSquaredFahrenheit,  // kilogram per cubic metre per pascal squared fahrenheit
         SpecificGravityPerPascalSquaredFahrenheit,  // specific gravity per pascal squared fahrenheit
         GramPerCubicCentimetrePerPascalSquaredFahrenheit,  // gram per cubic centimetre per pascal squared fahrenheit
         PoundPerGallonUKPerPascalSquaredFahrenheit,  // pound per gallon (UK) per pascal squared fahrenheit
         PoundPerGallonUSPerPascalSquaredFahrenheit,  // pound per gallon (US) per pascal squared fahrenheit
         PoundPerCubicFootPerPascalSquaredFahrenheit,  // pound per cubic foot per pascal squared fahrenheit
         PoundPerCubicInchPerPascalSquaredFahrenheit,  // pound per cubic inch per pascal squared fahrenheit
         PoundPerCubicYardPerPascalSquaredFahrenheit,  // pound per cubic yard per pascal squared fahrenheit
         KilogramPerCubicMetrePerBarSquaredFahrenheit,  // kilogram per cubic metre per bar squared fahrenheit
         SpecificGravityPerBarSquaredFahrenheit,  // specific gravity per bar squared fahrenheit
         GramPerCubicCentimetrePerBarSquaredFahrenheit,  // gram per cubic centimetre per bar squared fahrenheit
         PoundPerGallonUKPerBarSquaredFahrenheit,  // pound per gallon (UK) per bar squared fahrenheit
         PoundPerGallonUSPerBarSquaredFahrenheit,  // pound per gallon (US) per bar squared fahrenheit
         PoundPerCubicFootPerBarSquaredFahrenheit,  // pound per cubic foot per bar squared fahrenheit
         PoundPerCubicInchPerBarSquaredFahrenheit,  // pound per cubic inch per bar squared fahrenheit
         PoundPerCubicYardPerBarSquaredFahrenheit,  // pound per cubic yard per bar squared fahrenheit
         KilogramPerCubicMetrePerPoundPerSquareInchSquaredFahrenheit,  // kilogram per cubic metre per pound per square inch squared fahrenheit
         SpecificGravityPerPoundPerSquareInchSquaredFahrenheit,  // specific gravity per pound per square inch squared fahrenheit
         GramPerCubicCentimetrePerPoundPerSquareInchSquaredFahrenheit,  // gram per cubic centimetre per pound per square inch squared fahrenheit
         PoundPerGallonUKPerPoundPerSquareInchSquaredFahrenheit,  // pound per gallon (UK) per pound per square inch squared fahrenheit
         PoundPerGallonUSPerPoundPerSquareInchSquaredFahrenheit,  // pound per gallon (US) per pound per square inch squared fahrenheit
         PoundPerCubicFootPerPoundPerSquareInchSquaredFahrenheit,  // pound per cubic foot per pound per square inch squared fahrenheit
         PoundPerCubicInchPerPoundPerSquareInchSquaredFahrenheit,  // pound per cubic inch per pound per square inch squared fahrenheit
         PoundPerCubicYardPerPoundPerSquareInchSquaredFahrenheit // pound per cubic yard per pound per square inch squared fahrenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerPascalSquaredKelvin, new Guid("e00b25c4-cf11-43f8-b87f-e7e482729d18")},  // kilogram per cubic metre per pascal squared kelvin
         {UnitChoicesEnum.SpecificGravityPerPascalSquaredKelvin, new Guid("111b012c-3e70-4e3b-8102-5fb0ecd0b1cd")},  // specific gravity per pascal squared kelvin
         {UnitChoicesEnum.GramPerCubicCentimetrePerPascalSquaredKelvin, new Guid("4497271d-cfe7-402e-a20a-7d4aa644d569")},  // gram per cubic centimetre per pascal squared kelvin
         {UnitChoicesEnum.PoundPerGallonUKPerPascalSquaredKelvin, new Guid("2a2cc741-54d7-4b54-bee7-616e48d9bec6")},  // pound per gallon (UK) per pascal squared kelvin
         {UnitChoicesEnum.PoundPerGallonUSPerPascalSquaredKelvin, new Guid("f09f13b4-a260-4192-9ca6-3a3b1466f6bf")},  // pound per gallon (US) per pascal squared kelvin
         {UnitChoicesEnum.PoundPerCubicFootPerPascalSquaredKelvin, new Guid("2cbb0b80-789a-4b11-8fa4-62d8f5e7c92f")},  // pound per cubic foot per pascal squared kelvin
         {UnitChoicesEnum.PoundPerCubicInchPerPascalSquaredKelvin, new Guid("da10a140-ae39-4b34-83b1-223e456a3865")},  // pound per cubic inch per pascal squared kelvin
         {UnitChoicesEnum.PoundPerCubicYardPerPascalSquaredKelvin, new Guid("63e7f7d8-a38b-4a45-937c-8567e97d71a9")},  // pound per cubic yard per pascal squared kelvin
         {UnitChoicesEnum.KilogramPerCubicMetrePerBarSquaredKelvin, new Guid("cbc5f940-560b-44cf-b652-3f0b953abe5e")},  // kilogram per cubic metre per bar squared kelvin
         {UnitChoicesEnum.SpecificGravityPerBarSquaredKelvin, new Guid("3e25dd0e-2726-4c26-922b-81c7ec8b416d")},  // specific gravity per bar squared kelvin
         {UnitChoicesEnum.GramPerCubicCentimetrePerBarSquaredKelvin, new Guid("26b11134-95aa-49f4-8959-7475ca97626b")},  // gram per cubic centimetre per bar squared kelvin
         {UnitChoicesEnum.PoundPerGallonUKPerBarSquaredKelvin, new Guid("5c136f82-a39a-4973-bb95-ca19b256bfb8")},  // pound per gallon (UK) per bar squared kelvin
         {UnitChoicesEnum.PoundPerGallonUSPerBarSquaredKelvin, new Guid("14a06bea-ee90-4a76-92b4-7186c5b1b43f")},  // pound per gallon (US) per bar squared kelvin
         {UnitChoicesEnum.PoundPerCubicFootPerBarSquaredKelvin, new Guid("f96cf481-f2bc-4f18-9119-c2d88a705cf1")},  // pound per cubic foot per bar squared kelvin
         {UnitChoicesEnum.PoundPerCubicInchPerBarSquaredKelvin, new Guid("dc4112ed-2c78-4f94-9be2-880fb9271578")},  // pound per cubic inch per bar squared kelvin
         {UnitChoicesEnum.PoundPerCubicYardPerBarSquaredKelvin, new Guid("8623f335-7ff1-4bed-8ada-5635c6c32b18")},  // pound per cubic yard per bar squared kelvin
         {UnitChoicesEnum.KilogramPerCubicMetrePerPoundPerSquareInchSquaredKelvin, new Guid("7179c84a-113f-44c1-97c2-ccda465876bd")},  // kilogram per cubic metre per pound per square inch squared kelvin
         {UnitChoicesEnum.SpecificGravityPerPoundPerSquareInchSquaredKelvin, new Guid("1700ead8-a6fa-455c-9389-6526cb099af1")},  // specific gravity per pound per square inch squared kelvin
         {UnitChoicesEnum.GramPerCubicCentimetrePerPoundPerSquareInchSquaredKelvin, new Guid("9c5f6e94-c1ca-4107-8656-29a00c575f34")},  // gram per cubic centimetre per pound per square inch squared kelvin
         {UnitChoicesEnum.PoundPerGallonUKPerPoundPerSquareInchSquaredKelvin, new Guid("5a8b846c-1fb3-4c53-b181-14d2b5806919")},  // pound per gallon (UK) per pound per square inch squared kelvin
         {UnitChoicesEnum.PoundPerGallonUSPerPoundPerSquareInchSquaredKelvin, new Guid("6f009bc6-d776-4bb5-9f34-1870f6492c45")},  // pound per gallon (US) per pound per square inch squared kelvin
         {UnitChoicesEnum.PoundPerCubicFootPerPoundPerSquareInchSquaredKelvin, new Guid("61df2832-d446-4875-b000-660e89ff1510")},  // pound per cubic foot per pound per square inch squared kelvin
         {UnitChoicesEnum.PoundPerCubicInchPerPoundPerSquareInchSquaredKelvin, new Guid("c68060f8-20b1-46ad-aed8-6612ebdbc7d2")},  // pound per cubic inch per pound per square inch squared kelvin
         {UnitChoicesEnum.PoundPerCubicYardPerPoundPerSquareInchSquaredKelvin, new Guid("2170eff8-21a6-4682-81ab-2d2834ba03d9")},  // pound per cubic yard per pound per square inch squared kelvin
         {UnitChoicesEnum.KilogramPerCubicMetrePerPascalSquaredCelsius, new Guid("0d5a8548-b83e-4a96-9550-57725a3f3e9c")},  // kilogram per cubic metre per pascal squared celsius
         {UnitChoicesEnum.SpecificGravityPerPascalSquaredCelsius, new Guid("667e0395-0678-458f-9a27-3ee726df2ea6")},  // specific gravity per pascal squared celsius
         {UnitChoicesEnum.GramPerCubicCentimetrePerPascalSquaredCelsius, new Guid("3454083c-dfe0-454d-a048-8ed9e6835fe9")},  // gram per cubic centimetre per pascal squared celsius
         {UnitChoicesEnum.PoundPerGallonUKPerPascalSquaredCelsius, new Guid("b0761965-0273-497b-843f-54faf816ad0f")},  // pound per gallon (UK) per pascal squared celsius
         {UnitChoicesEnum.PoundPerGallonUSPerPascalSquaredCelsius, new Guid("c28837e9-5bfb-4154-a33e-04f775cf71c3")},  // pound per gallon (US) per pascal squared celsius
         {UnitChoicesEnum.PoundPerCubicFootPerPascalSquaredCelsius, new Guid("7367c345-b965-43ea-94d0-7068d8eab3a3")},  // pound per cubic foot per pascal squared celsius
         {UnitChoicesEnum.PoundPerCubicInchPerPascalSquaredCelsius, new Guid("1c6f0c40-80ef-4fb3-a0b7-892ba89c35e7")},  // pound per cubic inch per pascal squared celsius
         {UnitChoicesEnum.PoundPerCubicYardPerPascalSquaredCelsius, new Guid("623d2ac0-cb0e-485e-8996-bed2b943c6fa")},  // pound per cubic yard per pascal squared celsius
         {UnitChoicesEnum.KilogramPerCubicMetrePerBarSquaredCelsius, new Guid("a7346d6e-bd4a-4f93-8c4d-39d2e70d70a1")},  // kilogram per cubic metre per bar squared celsius
         {UnitChoicesEnum.SpecificGravityPerBarSquaredCelsius, new Guid("04e257cd-c95b-46d3-ace6-3a7de12dba45")},  // specific gravity per bar squared celsius
         {UnitChoicesEnum.GramPerCubicCentimetrePerBarSquaredCelsius, new Guid("da92c1ef-6ce0-4ee8-bdf1-aa6111aac4c7")},  // gram per cubic centimetre per bar squared celsius
         {UnitChoicesEnum.PoundPerGallonUKPerBarSquaredCelsius, new Guid("bcd39cc2-603f-4663-a896-3a7d5556b51d")},  // pound per gallon (UK) per bar squared celsius
         {UnitChoicesEnum.PoundPerGallonUSPerBarSquaredCelsius, new Guid("80757949-116e-45ee-98ec-cee61c7e6175")},  // pound per gallon (US) per bar squared celsius
         {UnitChoicesEnum.PoundPerCubicFootPerBarSquaredCelsius, new Guid("731cb76b-17c1-4a7d-9a84-2bd3b90ec32a")},  // pound per cubic foot per bar squared celsius
         {UnitChoicesEnum.PoundPerCubicInchPerBarSquaredCelsius, new Guid("2d1eb56c-e8f5-46ce-bafd-0696f0b1956b")},  // pound per cubic inch per bar squared celsius
         {UnitChoicesEnum.PoundPerCubicYardPerBarSquaredCelsius, new Guid("f9ffcd7c-4479-4122-9906-4f115712a799")},  // pound per cubic yard per bar squared celsius
         {UnitChoicesEnum.KilogramPerCubicMetrePerPoundPerSquareInchSquaredCelsius, new Guid("1ce45b46-493e-4e43-9a01-da7f137822c7")},  // kilogram per cubic metre per pound per square inch squared celsius
         {UnitChoicesEnum.SpecificGravityPerPoundPerSquareInchSquaredCelsius, new Guid("b5642483-4968-41a8-addf-55f5844f24ec")},  // specific gravity per pound per square inch squared celsius
         {UnitChoicesEnum.GramPerCubicCentimetrePerPoundPerSquareInchSquaredCelsius, new Guid("bd600761-8fe6-4fc2-b3d8-f0b27e8a414c")},  // gram per cubic centimetre per pound per square inch squared celsius
         {UnitChoicesEnum.PoundPerGallonUKPerPoundPerSquareInchSquaredCelsius, new Guid("c7d1f1ba-6574-4271-927c-0983ece07f8b")},  // pound per gallon (UK) per pound per square inch squared celsius
         {UnitChoicesEnum.PoundPerGallonUSPerPoundPerSquareInchSquaredCelsius, new Guid("f3b574d7-be5d-4c41-ad56-188a175e823d")},  // pound per gallon (US) per pound per square inch squared celsius
         {UnitChoicesEnum.PoundPerCubicFootPerPoundPerSquareInchSquaredCelsius, new Guid("ca74b7e6-a4dc-419d-bdfd-75b927aaa380")},  // pound per cubic foot per pound per square inch squared celsius
         {UnitChoicesEnum.PoundPerCubicInchPerPoundPerSquareInchSquaredCelsius, new Guid("48ae377a-0eea-4b9c-b1a9-0156a2d0ff35")},  // pound per cubic inch per pound per square inch squared celsius
         {UnitChoicesEnum.PoundPerCubicYardPerPoundPerSquareInchSquaredCelsius, new Guid("eaaf6fee-8773-4ec3-a0ea-de1d8672066f")},  // pound per cubic yard per pound per square inch squared celsius
         {UnitChoicesEnum.KilogramPerCubicMetrePerPascalSquaredFahrenheit, new Guid("489deba9-0377-46ea-9577-68efb2aedbf6")},  // kilogram per cubic metre per pascal squared fahrenheit
         {UnitChoicesEnum.SpecificGravityPerPascalSquaredFahrenheit, new Guid("b57c2f62-a6b6-4a8d-a9f7-2edfb0b1651c")},  // specific gravity per pascal squared fahrenheit
         {UnitChoicesEnum.GramPerCubicCentimetrePerPascalSquaredFahrenheit, new Guid("546e2ac5-4937-433f-906f-077f010e7964")},  // gram per cubic centimetre per pascal squared fahrenheit
         {UnitChoicesEnum.PoundPerGallonUKPerPascalSquaredFahrenheit, new Guid("ec7d57e4-b2fa-40b6-9d81-743a0610baf9")},  // pound per gallon (UK) per pascal squared fahrenheit
         {UnitChoicesEnum.PoundPerGallonUSPerPascalSquaredFahrenheit, new Guid("4d8dc1f2-032f-4792-b59a-2bf25dd5990f")},  // pound per gallon (US) per pascal squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicFootPerPascalSquaredFahrenheit, new Guid("a1517641-82b9-4270-aa74-b0b2ece8c693")},  // pound per cubic foot per pascal squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicInchPerPascalSquaredFahrenheit, new Guid("8def68a4-6327-4457-9bd1-7703c405bd83")},  // pound per cubic inch per pascal squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicYardPerPascalSquaredFahrenheit, new Guid("6eec2c4d-5b2f-4aa7-ac68-18d57c81928d")},  // pound per cubic yard per pascal squared fahrenheit
         {UnitChoicesEnum.KilogramPerCubicMetrePerBarSquaredFahrenheit, new Guid("9fcb07f9-bd0c-46da-bd97-8cfd7ddaa24f")},  // kilogram per cubic metre per bar squared fahrenheit
         {UnitChoicesEnum.SpecificGravityPerBarSquaredFahrenheit, new Guid("496be92b-9b7f-447e-8bd4-ccdbfb7e5d45")},  // specific gravity per bar squared fahrenheit
         {UnitChoicesEnum.GramPerCubicCentimetrePerBarSquaredFahrenheit, new Guid("a295e2a1-736b-455f-9a1a-26b93fc3ce37")},  // gram per cubic centimetre per bar squared fahrenheit
         {UnitChoicesEnum.PoundPerGallonUKPerBarSquaredFahrenheit, new Guid("a2eab10e-27ef-409e-85dc-41770fe3bcb3")},  // pound per gallon (UK) per bar squared fahrenheit
         {UnitChoicesEnum.PoundPerGallonUSPerBarSquaredFahrenheit, new Guid("f8a5b28b-a219-4045-9c72-a65086b7c459")},  // pound per gallon (US) per bar squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicFootPerBarSquaredFahrenheit, new Guid("fac1aaa4-f129-4f0b-80d8-9706223f27af")},  // pound per cubic foot per bar squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicInchPerBarSquaredFahrenheit, new Guid("512f5c6c-717b-4532-8294-47883c881377")},  // pound per cubic inch per bar squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicYardPerBarSquaredFahrenheit, new Guid("af3daad4-a444-46a1-b046-4bb36141b5bd")},  // pound per cubic yard per bar squared fahrenheit
         {UnitChoicesEnum.KilogramPerCubicMetrePerPoundPerSquareInchSquaredFahrenheit, new Guid("7733b2c6-da6b-42d8-84d0-abf1c8dd8259")},  // kilogram per cubic metre per pound per square inch squared fahrenheit
         {UnitChoicesEnum.SpecificGravityPerPoundPerSquareInchSquaredFahrenheit, new Guid("0cb8518e-1e1b-4e3c-9f34-5e0042c9e6d7")},  // specific gravity per pound per square inch squared fahrenheit
         {UnitChoicesEnum.GramPerCubicCentimetrePerPoundPerSquareInchSquaredFahrenheit, new Guid("cd1cab93-09b5-4793-afd4-d04d01cbae69")},  // gram per cubic centimetre per pound per square inch squared fahrenheit
         {UnitChoicesEnum.PoundPerGallonUKPerPoundPerSquareInchSquaredFahrenheit, new Guid("c958922f-4a1c-4186-b08a-e642df71dde3")},  // pound per gallon (UK) per pound per square inch squared fahrenheit
         {UnitChoicesEnum.PoundPerGallonUSPerPoundPerSquareInchSquaredFahrenheit, new Guid("bcb65f47-4365-4143-a517-8db45650aa11")},  // pound per gallon (US) per pound per square inch squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicFootPerPoundPerSquareInchSquaredFahrenheit, new Guid("f3548d52-8d7d-4f67-9029-118edb2c13b9")},  // pound per cubic foot per pound per square inch squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicInchPerPoundPerSquareInchSquaredFahrenheit, new Guid("8d02dc32-3c91-4323-b840-ebea2a6cbf7b")},  // pound per cubic inch per pound per square inch squared fahrenheit
         {UnitChoicesEnum.PoundPerCubicYardPerPoundPerSquareInchSquaredFahrenheit, new Guid("5e07f626-35e9-494b-a4e1-ba7f746c627d")} // pound per cubic yard per pound per square inch squared fahrenheit
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
  public partial class MassDensityGradientPerPressureTemperatureDrillingQuantity : MassDensityGradientPerPressureTemperatureQuantity
  {
    public new enum UnitChoicesEnum 
      {
         KilogramPerCubicMetrePerPascalKelvin,  // kilogram per cubic metre per pascal kelvin
         SpecificGravityPerPascalKelvin,  // specific gravity per pascal kelvin
         GramPerCubicCentimetrePerPascalKelvin,  // gram per cubic centimetre per pascal kelvin
         PoundPerGallonUKPerPascalKelvin,  // pound per gallon (UK) per pascal kelvin
         PoundPerGallonUSPerPascalKelvin,  // pound per gallon (US) per pascal kelvin
         PoundPerCubicFootPerPascalKelvin,  // pound per cubic foot per pascal kelvin
         PoundPerCubicInchPerPascalKelvin,  // pound per cubic inch per pascal kelvin
         PoundPerCubicYardPerPascalKelvin,  // pound per cubic yard per pascal kelvin
         KilogramPerCubicMetrePerBarKelvin,  // kilogram per cubic metre per bar kelvin
         SpecificGravityPerBarKelvin,  // specific gravity per bar kelvin
         GramPerCubicCentimetrePerBarKelvin,  // gram per cubic centimetre per bar kelvin
         PoundPerGallonUKPerBarKelvin,  // pound per gallon (UK) per bar kelvin
         PoundPerGallonUSPerBarKelvin,  // pound per gallon (US) per bar kelvin
         PoundPerCubicFootPerBarKelvin,  // pound per cubic foot per bar kelvin
         PoundPerCubicInchPerBarKelvin,  // pound per cubic inch per bar kelvin
         PoundPerCubicYardPerBarKelvin,  // pound per cubic yard per bar kelvin
         KilogramPerCubicMetrePerPoundPerSquareInchKelvin,  // kilogram per cubic metre per pound per square inch kelvin
         SpecificGravityPerPoundPerSquareInchKelvin,  // specific gravity per pound per square inch kelvin
         GramPerCubicCentimetrePerPoundPerSquareInchKelvin,  // gram per cubic centimetre per pound per square inch kelvin
         PoundPerGallonUKPerPoundPerSquareInchKelvin,  // pound per gallon (UK) per pound per square inch kelvin
         PoundPerGallonUSPerPoundPerSquareInchKelvin,  // pound per gallon (US) per pound per square inch kelvin
         PoundPerCubicFootPerPoundPerSquareInchKelvin,  // pound per cubic foot per pound per square inch kelvin
         PoundPerCubicInchPerPoundPerSquareInchKelvin,  // pound per cubic inch per pound per square inch kelvin
         PoundPerCubicYardPerPoundPerSquareInchKelvin,  // pound per cubic yard per pound per square inch kelvin
         KilogramPerCubicMetrePerPascalCelsius,  // kilogram per cubic metre per pascal celsius
         SpecificGravityPerPascalCelsius,  // specific gravity per pascal celsius
         GramPerCubicCentimetrePerPascalCelsius,  // gram per cubic centimetre per pascal celsius
         PoundPerGallonUKPerPascalCelsius,  // pound per gallon (UK) per pascal celsius
         PoundPerGallonUSPerPascalCelsius,  // pound per gallon (US) per pascal celsius
         PoundPerCubicFootPerPascalCelsius,  // pound per cubic foot per pascal celsius
         PoundPerCubicInchPerPascalCelsius,  // pound per cubic inch per pascal celsius
         PoundPerCubicYardPerPascalCelsius,  // pound per cubic yard per pascal celsius
         KilogramPerCubicMetrePerBarCelsius,  // kilogram per cubic metre per bar celsius
         SpecificGravityPerBarCelsius,  // specific gravity per bar celsius
         GramPerCubicCentimetrePerBarCelsius,  // gram per cubic centimetre per bar celsius
         PoundPerGallonUKPerBarCelsius,  // pound per gallon (UK) per bar celsius
         PoundPerGallonUSPerBarCelsius,  // pound per gallon (US) per bar celsius
         PoundPerCubicFootPerBarCelsius,  // pound per cubic foot per bar celsius
         PoundPerCubicInchPerBarCelsius,  // pound per cubic inch per bar celsius
         PoundPerCubicYardPerBarCelsius,  // pound per cubic yard per bar celsius
         KilogramPerCubicMetrePerPoundPerSquareInchCelsius,  // kilogram per cubic metre per pound per square inch celsius
         SpecificGravityPerPoundPerSquareInchCelsius,  // specific gravity per pound per square inch celsius
         GramPerCubicCentimetrePerPoundPerSquareInchCelsius,  // gram per cubic centimetre per pound per square inch celsius
         PoundPerGallonUKPerPoundPerSquareInchCelsius,  // pound per gallon (UK) per pound per square inch celsius
         PoundPerGallonUSPerPoundPerSquareInchCelsius,  // pound per gallon (US) per pound per square inch celsius
         PoundPerCubicFootPerPoundPerSquareInchCelsius,  // pound per cubic foot per pound per square inch celsius
         PoundPerCubicInchPerPoundPerSquareInchCelsius,  // pound per cubic inch per pound per square inch celsius
         PoundPerCubicYardPerPoundPerSquareInchCelsius,  // pound per cubic yard per pound per square inch celsius
         KilogramPerCubicMetrePerPascalFahrenheit,  // kilogram per cubic metre per pascal fahrenheit
         SpecificGravityPerPascalFahrenheit,  // specific gravity per pascal fahrenheit
         GramPerCubicCentimetrePerPascalFahrenheit,  // gram per cubic centimetre per pascal fahrenheit
         PoundPerGallonUKPerPascalFahrenheit,  // pound per gallon (UK) per pascal fahrenheit
         PoundPerGallonUSPerPascalFahrenheit,  // pound per gallon (US) per pascal fahrenheit
         PoundPerCubicFootPerPascalFahrenheit,  // pound per cubic foot per pascal fahrenheit
         PoundPerCubicInchPerPascalFahrenheit,  // pound per cubic inch per pascal fahrenheit
         PoundPerCubicYardPerPascalFahrenheit,  // pound per cubic yard per pascal fahrenheit
         KilogramPerCubicMetrePerBarFahrenheit,  // kilogram per cubic metre per bar fahrenheit
         SpecificGravityPerBarFahrenheit,  // specific gravity per bar fahrenheit
         GramPerCubicCentimetrePerBarFahrenheit,  // gram per cubic centimetre per bar fahrenheit
         PoundPerGallonUKPerBarFahrenheit,  // pound per gallon (UK) per bar fahrenheit
         PoundPerGallonUSPerBarFahrenheit,  // pound per gallon (US) per bar fahrenheit
         PoundPerCubicFootPerBarFahrenheit,  // pound per cubic foot per bar fahrenheit
         PoundPerCubicInchPerBarFahrenheit,  // pound per cubic inch per bar fahrenheit
         PoundPerCubicYardPerBarFahrenheit,  // pound per cubic yard per bar fahrenheit
         KilogramPerCubicMetrePerPoundPerSquareInchFahrenheit,  // kilogram per cubic metre per pound per square inch fahrenheit
         SpecificGravityPerPoundPerSquareInchFahrenheit,  // specific gravity per pound per square inch fahrenheit
         GramPerCubicCentimetrePerPoundPerSquareInchFahrenheit,  // gram per cubic centimetre per pound per square inch fahrenheit
         PoundPerGallonUKPerPoundPerSquareInchFahrenheit,  // pound per gallon (UK) per pound per square inch fahrenheit
         PoundPerGallonUSPerPoundPerSquareInchFahrenheit,  // pound per gallon (US) per pound per square inch fahrenheit
         PoundPerCubicFootPerPoundPerSquareInchFahrenheit,  // pound per cubic foot per pound per square inch fahrenheit
         PoundPerCubicInchPerPoundPerSquareInchFahrenheit,  // pound per cubic inch per pound per square inch fahrenheit
         PoundPerCubicYardPerPoundPerSquareInchFahrenheit // pound per cubic yard per pound per square inch fahrenheit
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.KilogramPerCubicMetrePerPascalKelvin, new Guid("ab41e361-7ef5-488f-b121-e51afa56fcfa")},  // kilogram per cubic metre per pascal kelvin
         {UnitChoicesEnum.SpecificGravityPerPascalKelvin, new Guid("bd96fb03-de24-4171-abf8-eccfd6fcd2e8")},  // specific gravity per pascal kelvin
         {UnitChoicesEnum.GramPerCubicCentimetrePerPascalKelvin, new Guid("c2cae333-be7c-4567-a42e-00d2fa95d1aa")},  // gram per cubic centimetre per pascal kelvin
         {UnitChoicesEnum.PoundPerGallonUKPerPascalKelvin, new Guid("3ae6d54a-e365-4dc5-b5c8-083b88297719")},  // pound per gallon (UK) per pascal kelvin
         {UnitChoicesEnum.PoundPerGallonUSPerPascalKelvin, new Guid("8b5d3eec-f8ec-4233-8d99-6a99fee53ae8")},  // pound per gallon (US) per pascal kelvin
         {UnitChoicesEnum.PoundPerCubicFootPerPascalKelvin, new Guid("d6be025a-14b5-4c0e-8971-4fe5468237d5")},  // pound per cubic foot per pascal kelvin
         {UnitChoicesEnum.PoundPerCubicInchPerPascalKelvin, new Guid("e1dc7833-9369-4901-ae8c-c4c528f1d11d")},  // pound per cubic inch per pascal kelvin
         {UnitChoicesEnum.PoundPerCubicYardPerPascalKelvin, new Guid("fbb4e022-e102-436f-93c1-c9ea2c30f9e0")},  // pound per cubic yard per pascal kelvin
         {UnitChoicesEnum.KilogramPerCubicMetrePerBarKelvin, new Guid("8cbe6cb2-2a0f-400d-a659-0695eb16d508")},  // kilogram per cubic metre per bar kelvin
         {UnitChoicesEnum.SpecificGravityPerBarKelvin, new Guid("9aa8835d-e374-4527-bdd6-636ec7148e66")},  // specific gravity per bar kelvin
         {UnitChoicesEnum.GramPerCubicCentimetrePerBarKelvin, new Guid("bbb10e84-4dee-459d-b389-5127606db8cc")},  // gram per cubic centimetre per bar kelvin
         {UnitChoicesEnum.PoundPerGallonUKPerBarKelvin, new Guid("07e8b9de-be10-4750-836a-929a4b16588d")},  // pound per gallon (UK) per bar kelvin
         {UnitChoicesEnum.PoundPerGallonUSPerBarKelvin, new Guid("19804fa6-8dc6-4043-8b0a-d7cabaf98c13")},  // pound per gallon (US) per bar kelvin
         {UnitChoicesEnum.PoundPerCubicFootPerBarKelvin, new Guid("fb6f3791-8de0-42d7-a870-2b87b6a391bf")},  // pound per cubic foot per bar kelvin
         {UnitChoicesEnum.PoundPerCubicInchPerBarKelvin, new Guid("3390b64d-7959-4c92-9188-f842b1a7b4d6")},  // pound per cubic inch per bar kelvin
         {UnitChoicesEnum.PoundPerCubicYardPerBarKelvin, new Guid("2caa723f-4107-4632-ad12-3b72c3eb1174")},  // pound per cubic yard per bar kelvin
         {UnitChoicesEnum.KilogramPerCubicMetrePerPoundPerSquareInchKelvin, new Guid("f0a415eb-f811-49bb-8a08-640a976fe1cf")},  // kilogram per cubic metre per pound per square inch kelvin
         {UnitChoicesEnum.SpecificGravityPerPoundPerSquareInchKelvin, new Guid("3a2b82e9-6f53-4149-9530-b202abee4a22")},  // specific gravity per pound per square inch kelvin
         {UnitChoicesEnum.GramPerCubicCentimetrePerPoundPerSquareInchKelvin, new Guid("4a4df929-c2df-4da5-aad4-601e82945f2c")},  // gram per cubic centimetre per pound per square inch kelvin
         {UnitChoicesEnum.PoundPerGallonUKPerPoundPerSquareInchKelvin, new Guid("dd330e7b-b47c-43c9-a4fe-4259a6a74b40")},  // pound per gallon (UK) per pound per square inch kelvin
         {UnitChoicesEnum.PoundPerGallonUSPerPoundPerSquareInchKelvin, new Guid("e351b849-3d09-44b7-ac67-4380d7a6908a")},  // pound per gallon (US) per pound per square inch kelvin
         {UnitChoicesEnum.PoundPerCubicFootPerPoundPerSquareInchKelvin, new Guid("11c5c48f-a880-479f-9f8a-952433aa1105")},  // pound per cubic foot per pound per square inch kelvin
         {UnitChoicesEnum.PoundPerCubicInchPerPoundPerSquareInchKelvin, new Guid("1b9b4c68-a0f7-43e3-bc6c-65a13672e340")},  // pound per cubic inch per pound per square inch kelvin
         {UnitChoicesEnum.PoundPerCubicYardPerPoundPerSquareInchKelvin, new Guid("5d80643e-871a-41d2-b215-6bf62585a408")},  // pound per cubic yard per pound per square inch kelvin
         {UnitChoicesEnum.KilogramPerCubicMetrePerPascalCelsius, new Guid("c0602be3-4094-40af-a85f-fab2378a5d83")},  // kilogram per cubic metre per pascal celsius
         {UnitChoicesEnum.SpecificGravityPerPascalCelsius, new Guid("03cc0ee6-3c31-417a-b8e6-c40cd5b377d3")},  // specific gravity per pascal celsius
         {UnitChoicesEnum.GramPerCubicCentimetrePerPascalCelsius, new Guid("ddcc5558-7bcc-424f-8a16-42a8e3cb4a52")},  // gram per cubic centimetre per pascal celsius
         {UnitChoicesEnum.PoundPerGallonUKPerPascalCelsius, new Guid("8022319e-61bc-42aa-b7d9-1b7e33771224")},  // pound per gallon (UK) per pascal celsius
         {UnitChoicesEnum.PoundPerGallonUSPerPascalCelsius, new Guid("31baed8a-9474-414b-adf7-74df7d244e40")},  // pound per gallon (US) per pascal celsius
         {UnitChoicesEnum.PoundPerCubicFootPerPascalCelsius, new Guid("684db3d1-6610-4774-8d80-ae212241991a")},  // pound per cubic foot per pascal celsius
         {UnitChoicesEnum.PoundPerCubicInchPerPascalCelsius, new Guid("85efde7e-0ab7-44c3-adeb-1934753aea1a")},  // pound per cubic inch per pascal celsius
         {UnitChoicesEnum.PoundPerCubicYardPerPascalCelsius, new Guid("dc662923-2863-494a-a1b0-90ad30b812e9")},  // pound per cubic yard per pascal celsius
         {UnitChoicesEnum.KilogramPerCubicMetrePerBarCelsius, new Guid("e70b203c-cae0-4494-bf5d-fac95d99cb8f")},  // kilogram per cubic metre per bar celsius
         {UnitChoicesEnum.SpecificGravityPerBarCelsius, new Guid("891b9f2e-94cc-41f2-8c36-d4315d923da2")},  // specific gravity per bar celsius
         {UnitChoicesEnum.GramPerCubicCentimetrePerBarCelsius, new Guid("d59d2a23-67f3-4224-8960-3732ca7e3c19")},  // gram per cubic centimetre per bar celsius
         {UnitChoicesEnum.PoundPerGallonUKPerBarCelsius, new Guid("55531b71-6a17-41bc-ac69-def74092a04b")},  // pound per gallon (UK) per bar celsius
         {UnitChoicesEnum.PoundPerGallonUSPerBarCelsius, new Guid("c04f57ed-37d8-4f32-bedf-48616e977cf3")},  // pound per gallon (US) per bar celsius
         {UnitChoicesEnum.PoundPerCubicFootPerBarCelsius, new Guid("cd1b76ec-a7e4-4963-8a3c-cbf8d7c1a858")},  // pound per cubic foot per bar celsius
         {UnitChoicesEnum.PoundPerCubicInchPerBarCelsius, new Guid("45c0e47f-4844-49a8-bb92-a564c99eb6df")},  // pound per cubic inch per bar celsius
         {UnitChoicesEnum.PoundPerCubicYardPerBarCelsius, new Guid("82092268-2d5f-4318-9812-556f63b68089")},  // pound per cubic yard per bar celsius
         {UnitChoicesEnum.KilogramPerCubicMetrePerPoundPerSquareInchCelsius, new Guid("fd02625d-d171-4ea2-8349-488ddbf9f6c8")},  // kilogram per cubic metre per pound per square inch celsius
         {UnitChoicesEnum.SpecificGravityPerPoundPerSquareInchCelsius, new Guid("d0e994dc-68fb-41e9-84fb-a62544d16674")},  // specific gravity per pound per square inch celsius
         {UnitChoicesEnum.GramPerCubicCentimetrePerPoundPerSquareInchCelsius, new Guid("261a18c2-5f0b-4e6f-9988-e1715de29c6f")},  // gram per cubic centimetre per pound per square inch celsius
         {UnitChoicesEnum.PoundPerGallonUKPerPoundPerSquareInchCelsius, new Guid("edf9f94f-2cd9-4b76-b0f9-38576be98feb")},  // pound per gallon (UK) per pound per square inch celsius
         {UnitChoicesEnum.PoundPerGallonUSPerPoundPerSquareInchCelsius, new Guid("a3c8fa89-a1fd-46a7-bef8-7a4cde7ad585")},  // pound per gallon (US) per pound per square inch celsius
         {UnitChoicesEnum.PoundPerCubicFootPerPoundPerSquareInchCelsius, new Guid("a0e2f8d9-cf7e-454e-8722-b4777f3ecd1b")},  // pound per cubic foot per pound per square inch celsius
         {UnitChoicesEnum.PoundPerCubicInchPerPoundPerSquareInchCelsius, new Guid("33eb59dd-07fe-4826-a1a3-108246bf98e8")},  // pound per cubic inch per pound per square inch celsius
         {UnitChoicesEnum.PoundPerCubicYardPerPoundPerSquareInchCelsius, new Guid("a10eaf12-acd4-42e6-8bff-f0fe223dfcc2")},  // pound per cubic yard per pound per square inch celsius
         {UnitChoicesEnum.KilogramPerCubicMetrePerPascalFahrenheit, new Guid("81baad5f-7be5-4db4-9e64-b7df06c3babd")},  // kilogram per cubic metre per pascal fahrenheit
         {UnitChoicesEnum.SpecificGravityPerPascalFahrenheit, new Guid("1c7199e1-89e6-479e-a048-179bfbce39d8")},  // specific gravity per pascal fahrenheit
         {UnitChoicesEnum.GramPerCubicCentimetrePerPascalFahrenheit, new Guid("1a1fc347-5829-4ed7-bb2c-cf2a0a08cd3b")},  // gram per cubic centimetre per pascal fahrenheit
         {UnitChoicesEnum.PoundPerGallonUKPerPascalFahrenheit, new Guid("6af15113-8196-4dc0-8688-543e4ab5c050")},  // pound per gallon (UK) per pascal fahrenheit
         {UnitChoicesEnum.PoundPerGallonUSPerPascalFahrenheit, new Guid("06c4a7f8-e43c-4a58-be79-c0fadc2416ec")},  // pound per gallon (US) per pascal fahrenheit
         {UnitChoicesEnum.PoundPerCubicFootPerPascalFahrenheit, new Guid("240f2cae-25fc-47cf-8757-fe51552189b7")},  // pound per cubic foot per pascal fahrenheit
         {UnitChoicesEnum.PoundPerCubicInchPerPascalFahrenheit, new Guid("3f059a64-a660-4c5f-a4e6-68844da8b1c4")},  // pound per cubic inch per pascal fahrenheit
         {UnitChoicesEnum.PoundPerCubicYardPerPascalFahrenheit, new Guid("19e48858-c3a7-44f7-b9e9-c326f0fafa33")},  // pound per cubic yard per pascal fahrenheit
         {UnitChoicesEnum.KilogramPerCubicMetrePerBarFahrenheit, new Guid("83606dd6-7f81-45ea-994c-743581cd62d3")},  // kilogram per cubic metre per bar fahrenheit
         {UnitChoicesEnum.SpecificGravityPerBarFahrenheit, new Guid("070c9187-3d1c-4c1d-a26c-8370d9ac6d8f")},  // specific gravity per bar fahrenheit
         {UnitChoicesEnum.GramPerCubicCentimetrePerBarFahrenheit, new Guid("7dd71c46-d10b-407f-abc9-6597b7dec4bf")},  // gram per cubic centimetre per bar fahrenheit
         {UnitChoicesEnum.PoundPerGallonUKPerBarFahrenheit, new Guid("349ffb7c-caa0-4ee1-b8a7-8a00ec028b6f")},  // pound per gallon (UK) per bar fahrenheit
         {UnitChoicesEnum.PoundPerGallonUSPerBarFahrenheit, new Guid("cbbc44bb-a924-4e10-8c7d-9388f248722d")},  // pound per gallon (US) per bar fahrenheit
         {UnitChoicesEnum.PoundPerCubicFootPerBarFahrenheit, new Guid("2de087ee-34df-4e54-b6d2-cfe5393cda8d")},  // pound per cubic foot per bar fahrenheit
         {UnitChoicesEnum.PoundPerCubicInchPerBarFahrenheit, new Guid("c2033261-a7fe-4fe4-a99e-641db13c276e")},  // pound per cubic inch per bar fahrenheit
         {UnitChoicesEnum.PoundPerCubicYardPerBarFahrenheit, new Guid("32a9db15-caf4-40f8-9a78-e4444d1cc687")},  // pound per cubic yard per bar fahrenheit
         {UnitChoicesEnum.KilogramPerCubicMetrePerPoundPerSquareInchFahrenheit, new Guid("8bac278b-fb5c-4ab2-b58e-bda28e6b9f65")},  // kilogram per cubic metre per pound per square inch fahrenheit
         {UnitChoicesEnum.SpecificGravityPerPoundPerSquareInchFahrenheit, new Guid("9d2e9844-cf55-43ca-806b-12147ca5d981")},  // specific gravity per pound per square inch fahrenheit
         {UnitChoicesEnum.GramPerCubicCentimetrePerPoundPerSquareInchFahrenheit, new Guid("49a3a66b-c08f-48bc-b2cd-207a8a31150d")},  // gram per cubic centimetre per pound per square inch fahrenheit
         {UnitChoicesEnum.PoundPerGallonUKPerPoundPerSquareInchFahrenheit, new Guid("65be0323-b39c-4406-9a1e-91eb36a7c963")},  // pound per gallon (UK) per pound per square inch fahrenheit
         {UnitChoicesEnum.PoundPerGallonUSPerPoundPerSquareInchFahrenheit, new Guid("8b1a8cf9-ce8c-40b2-872d-ae3112b69da1")},  // pound per gallon (US) per pound per square inch fahrenheit
         {UnitChoicesEnum.PoundPerCubicFootPerPoundPerSquareInchFahrenheit, new Guid("07ba1470-7fda-43a1-81bb-8e1e0075021a")},  // pound per cubic foot per pound per square inch fahrenheit
         {UnitChoicesEnum.PoundPerCubicInchPerPoundPerSquareInchFahrenheit, new Guid("af345846-e411-416e-b97c-0119f2cb4c3b")},  // pound per cubic inch per pound per square inch fahrenheit
         {UnitChoicesEnum.PoundPerCubicYardPerPoundPerSquareInchFahrenheit, new Guid("846a356a-3ce8-4f4d-b2c1-641d2236e151")} // pound per cubic yard per pound per square inch fahrenheit
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
  public partial class SpecificVolumeDrillingQuantity : SpecificVolumeQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetrePerKilogram,  // cubic metre per kilogram
         CubicMetrePerGram,  // cubic metre per gram
         CubicDecimetrePerGram,  // cubic decimetre per gram
         LitrePerGram,  // litre per gram
         DecilitrePerGram,  // decilitre per gram
         CentilitrePerGram,  // centilitre per gram
         MillilitrePerGram,  // millilitre per gram
         CubicCentimetrePerGram,  // cubic centimetre per gram
         CubicMillimetrePerGram,  // cubic millimetre per gram
         LitrePerKilogram,  // litre per kilogram
         DecilitrePerKilogram,  // decilitre per kilogram
         CentilitrePerKilogram,  // centilitre per kilogram
         MillilitrePerKilogram,  // millilitre per kilogram
         CubicCentimetrePerKilogram,  // cubic centimetre per kilogram
         CubicMillimetrePerKilogram,  // cubic millimetre per kilogram
         CubicYardPerPound,  // cubic yard per pound
         CubicFeetPerPound,  // cubic feet per pound
         CubicInchesPerPound,  // cubic inches per pound
         CubicYardPerOunce,  // cubic yard per ounce
         CubicFeetPerOunce,  // cubic feet per ounce
         CubicInchesPerOunce,  // cubic inches per ounce
         GallonUKPerOunce,  // gallon UK per ounce
         GallonUSPerOunce,  // gallon US per ounce
         GallonUKPerPound,  // gallon UK per pound
         GallonUSPerPound // gallon US per pound
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetrePerKilogram, new Guid("0c321874-be1d-4ca7-8bfe-eac3c2b6e2f4")},  // cubic metre per kilogram
         {UnitChoicesEnum.CubicMetrePerGram, new Guid("72a258a9-bb34-46b2-8eb7-3123fb054669")},  // cubic metre per gram
         {UnitChoicesEnum.CubicDecimetrePerGram, new Guid("563b1574-04df-4285-a953-20d7da6b528f")},  // cubic decimetre per gram
         {UnitChoicesEnum.LitrePerGram, new Guid("d9206161-2a7a-45e8-9306-f5f9714bea84")},  // litre per gram
         {UnitChoicesEnum.DecilitrePerGram, new Guid("65c84088-e307-4ce2-adfa-bb380e639484")},  // decilitre per gram
         {UnitChoicesEnum.CentilitrePerGram, new Guid("e608ef34-e8b9-4134-8692-b72273ddd0af")},  // centilitre per gram
         {UnitChoicesEnum.MillilitrePerGram, new Guid("9cc34144-ca23-4d82-b725-c39e1607c356")},  // millilitre per gram
         {UnitChoicesEnum.CubicCentimetrePerGram, new Guid("5ac98a68-f85b-40b9-84d7-f6409bc79944")},  // cubic centimetre per gram
         {UnitChoicesEnum.CubicMillimetrePerGram, new Guid("a31a14cf-66d9-4789-8ea5-cca1f874a3f1")},  // cubic millimetre per gram
         {UnitChoicesEnum.LitrePerKilogram, new Guid("f4551a81-3856-434b-9247-4215d5782052")},  // litre per kilogram
         {UnitChoicesEnum.DecilitrePerKilogram, new Guid("07e7e24d-6538-4dd2-8c5d-d09e7cf2f006")},  // decilitre per kilogram
         {UnitChoicesEnum.CentilitrePerKilogram, new Guid("f0702462-ab52-4675-ba1e-0d7f86c8c3ea")},  // centilitre per kilogram
         {UnitChoicesEnum.MillilitrePerKilogram, new Guid("b87d48ef-91c1-48a8-8bac-41e774e3c3f0")},  // millilitre per kilogram
         {UnitChoicesEnum.CubicCentimetrePerKilogram, new Guid("7e258609-fb1f-4ad9-b712-9277427adaa5")},  // cubic centimetre per kilogram
         {UnitChoicesEnum.CubicMillimetrePerKilogram, new Guid("e72a515f-8edc-4049-973c-b9516aba6b61")},  // cubic millimetre per kilogram
         {UnitChoicesEnum.CubicYardPerPound, new Guid("cb0950fd-ebbb-459a-b542-f041b9388b1b")},  // cubic yard per pound
         {UnitChoicesEnum.CubicFeetPerPound, new Guid("7b5fe09f-170e-4a4f-bf30-77d4ffbbbd28")},  // cubic feet per pound
         {UnitChoicesEnum.CubicInchesPerPound, new Guid("8bf7c8f0-64fe-4785-be5f-5928906aea6a")},  // cubic inches per pound
         {UnitChoicesEnum.CubicYardPerOunce, new Guid("7027900f-a654-482a-8fc0-548f6d68c470")},  // cubic yard per ounce
         {UnitChoicesEnum.CubicFeetPerOunce, new Guid("ce834ba1-6ca8-4651-8fbd-1d008113ea1e")},  // cubic feet per ounce
         {UnitChoicesEnum.CubicInchesPerOunce, new Guid("a23d16bd-f9a2-475d-a76c-e6025940d631")},  // cubic inches per ounce
         {UnitChoicesEnum.GallonUKPerOunce, new Guid("cfe6a1db-5f38-4eb1-8a43-83dd959ee91c")},  // gallon UK per ounce
         {UnitChoicesEnum.GallonUSPerOunce, new Guid("216ba9e0-5c75-427a-8179-be65050bb773")},  // gallon US per ounce
         {UnitChoicesEnum.GallonUKPerPound, new Guid("2a509c09-5584-4df3-9b03-ef6afa56a0d3")},  // gallon UK per pound
         {UnitChoicesEnum.GallonUSPerPound, new Guid("8f6021d8-130a-4496-8a88-38b3b30aadfc")} // gallon US per pound
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
  public partial class SpecificVolumeSquaredDrillingQuantity : SpecificVolumeSquaredQuantity
  {
    public new enum UnitChoicesEnum 
      {
         CubicMetreSquaredPerKilogramSquared,  // cubic metre squared per kilogram squared
         CubicMetreSquaredPerGramSquared,  // cubic metre squared per gram squared
         CubicDecimetreSquaredPerGramSquared,  // cubic decimetre squared per gram squared
         LitreSquaredPerGramSquared,  // litre squared per gram squared
         DecilitreSquaredPerGramSquared,  // decilitre squared per gram squared
         CentilitreSquaredPerGramSquared,  // centilitre squared per gram squared
         MillilitreSquaredPerGramSquared,  // millilitre squared per gram squared
         CubicCentimetreSquaredPerGramSquared,  // cubic centimetre squared per gram squared
         CubicMillimetreSquaredPerGramSquared,  // cubic millimetre squared per gram squared
         LitreSquaredPerKilogramSquared,  // litre squared per kilogram squared
         DecilitreSquaredPerKilogramSquared,  // decilitre squared per kilogram squared
         CentilitreSquaredPerKilogramSquared,  // centilitre squared per kilogram squared
         MillilitreSquaredPerKilogramSquared,  // millilitre squared per kilogram squared
         CubicCentimetreSquaredPerKilogramSquared,  // cubic centimetre squared per kilogram squared
         CubicMillimetreSquaredPerKilogramSquared,  // cubic millimetre squared per kilogram squared
         CubicYardSquaredPerPoundSquared,  // cubic yard squared per pound squared
         CubicFeetSquaredPerPoundSquared,  // cubic feet squared per pound squared
         CubicInchesSquaredPerPoundSquared,  // cubic inches squared per pound squared
         CubicYardSquaredPerOunceSquared,  // cubic yard squared per ounce squared
         CubicFeetSquaredPerOunceSquared,  // cubic feet squared per ounce squared
         CubicInchesSquaredPerOunceSquared,  // cubic inches squared per ounce squared
         GallonUKSquaredPerOunceSquared,  // gallon UK squared per ounce squared
         GallonUSSquaredPerOunceSquared,  // gallon US squared per ounce squared
         GallonUKSquaredPerPoundSquared,  // gallon UK squared per pound squared
         GallonUSSquaredPerPoundSquared // gallon US squared per pound squared
      }
    protected new Dictionary<UnitChoicesEnum, Guid> enumLookUp_ = new Dictionary<UnitChoicesEnum, Guid>()
    {
         {UnitChoicesEnum.CubicMetreSquaredPerKilogramSquared, new Guid("9c15bf12-237d-486f-bba4-a2fbfc4e8478")},  // cubic metre squared per kilogram squared
         {UnitChoicesEnum.CubicMetreSquaredPerGramSquared, new Guid("b3e7d7b9-5671-4a15-bb70-7885bd6540c5")},  // cubic metre squared per gram squared
         {UnitChoicesEnum.CubicDecimetreSquaredPerGramSquared, new Guid("f29c66ae-2cf0-459d-af24-34e62a350904")},  // cubic decimetre squared per gram squared
         {UnitChoicesEnum.LitreSquaredPerGramSquared, new Guid("5e37afb2-6def-422c-963c-6d7377421a66")},  // litre squared per gram squared
         {UnitChoicesEnum.DecilitreSquaredPerGramSquared, new Guid("7707bae3-e596-4d4f-9e52-c862236abe40")},  // decilitre squared per gram squared
         {UnitChoicesEnum.CentilitreSquaredPerGramSquared, new Guid("7e344fe0-8487-4d24-99e8-8ef370e01c99")},  // centilitre squared per gram squared
         {UnitChoicesEnum.MillilitreSquaredPerGramSquared, new Guid("119533f4-6a22-4d16-8927-6cf60b6919c1")},  // millilitre squared per gram squared
         {UnitChoicesEnum.CubicCentimetreSquaredPerGramSquared, new Guid("d1331578-5ea9-4e15-a687-0eaef32d5197")},  // cubic centimetre squared per gram squared
         {UnitChoicesEnum.CubicMillimetreSquaredPerGramSquared, new Guid("16048716-100d-4089-af27-3ba731defa11")},  // cubic millimetre squared per gram squared
         {UnitChoicesEnum.LitreSquaredPerKilogramSquared, new Guid("0b1b47d5-fdb3-47af-9f80-ea9193a60fa4")},  // litre squared per kilogram squared
         {UnitChoicesEnum.DecilitreSquaredPerKilogramSquared, new Guid("c4fe5cce-8106-4640-b70a-a915faf84317")},  // decilitre squared per kilogram squared
         {UnitChoicesEnum.CentilitreSquaredPerKilogramSquared, new Guid("c9130aa9-0f78-4e56-91b4-e8c397e48f34")},  // centilitre squared per kilogram squared
         {UnitChoicesEnum.MillilitreSquaredPerKilogramSquared, new Guid("7d9a4f75-0e77-4eb7-9690-dadad54690cb")},  // millilitre squared per kilogram squared
         {UnitChoicesEnum.CubicCentimetreSquaredPerKilogramSquared, new Guid("037ab139-0665-489c-8b5c-8183e738059c")},  // cubic centimetre squared per kilogram squared
         {UnitChoicesEnum.CubicMillimetreSquaredPerKilogramSquared, new Guid("6c6b8e30-4a7f-496d-9884-7c65124fb09e")},  // cubic millimetre squared per kilogram squared
         {UnitChoicesEnum.CubicYardSquaredPerPoundSquared, new Guid("be485c8d-8b4f-451b-bf5a-bef3713bc4a8")},  // cubic yard squared per pound squared
         {UnitChoicesEnum.CubicFeetSquaredPerPoundSquared, new Guid("b8599a96-d1bf-4832-aafb-4e79a2f7aa2f")},  // cubic feet squared per pound squared
         {UnitChoicesEnum.CubicInchesSquaredPerPoundSquared, new Guid("55d2064c-dc72-4c25-bbab-5d94b34dfada")},  // cubic inches squared per pound squared
         {UnitChoicesEnum.CubicYardSquaredPerOunceSquared, new Guid("41aa2db9-4162-4e89-ab3e-f516eee318fb")},  // cubic yard squared per ounce squared
         {UnitChoicesEnum.CubicFeetSquaredPerOunceSquared, new Guid("985c778c-2247-48cd-bf75-8658b0cce2e4")},  // cubic feet squared per ounce squared
         {UnitChoicesEnum.CubicInchesSquaredPerOunceSquared, new Guid("ed7d6e1d-2948-4e36-a165-8bb207f320c4")},  // cubic inches squared per ounce squared
         {UnitChoicesEnum.GallonUKSquaredPerOunceSquared, new Guid("57b49ba7-1aaa-4746-a7dc-7e6578fa2ea3")},  // gallon UK squared per ounce squared
         {UnitChoicesEnum.GallonUSSquaredPerOunceSquared, new Guid("1ddf2dc3-a5cd-457d-904d-cfead242bb05")},  // gallon US squared per ounce squared
         {UnitChoicesEnum.GallonUKSquaredPerPoundSquared, new Guid("b689bb7e-7334-41c6-b8de-afe74cec4dd0")},  // gallon UK squared per pound squared
         {UnitChoicesEnum.GallonUSSquaredPerPoundSquared, new Guid("109d07d6-b035-420a-9cee-fb44524ad0fb")} // gallon US squared per pound squared
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
