using System;
using System.Collections.Generic;
using System.Reflection;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public class UnitSystem : BaseUnitSystem
    {
        private static Dictionary<Guid, UnitSystem> unitSystemDict_ = null;

        private static List<BasePhysicalQuantity> availablePhysicalQuantities_ = null;

        private static UnitSystem SIUnitSystem_ = null;
        private static UnitSystem MetricUnitSystem_ = null;
        private static UnitSystem ImperialUnitSystem_ = null;
        private static UnitSystem USUnitSystem_ = null;

        /// <summary>
        /// default constructor
        /// </summary>
        public UnitSystem() : base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultUnitChoice"></param>
        public UnitSystem(BaseUnitSystem.DefaultUnitSystemEnum defaultUnitChoice) : base(defaultUnitChoice)
        {
            List<BasePhysicalQuantity> quantities = UnitSystem.AvailableQuantities;
            if (quantities != null)
            {
                /*
                // generate
                foreach(PhysicalQuantity quantity in quantities)
                {
                    Console.WriteLine("Choices.Add(" + quantity.GetType().Name + ".Instance.ID, " + quantity.GetType().Name + ".Instance.GetUnitChoice(" + quantity.GetType().Name + ".UnitChoicesEnum.).ID);");
                }
                */

                if (defaultUnitChoice == BaseUnitSystem.DefaultUnitSystemEnum.SI)
                {
                    IsSI = true;
                    IsDefault = true;
                    ID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769");
                    Name = "SI";
                    Description = "International System of Units";

                    foreach (BasePhysicalQuantity quantity in quantities)
                    {
                        if (quantity.ID != Guid.Empty)
                        {
                            Guid unitChoiceID = Guid.Empty;
                            foreach (UnitChoice unitChoice in quantity.UnitChoices)
                            {
                                if (unitChoice.IsSI)
                                {
                                    unitChoiceID = unitChoice.ID;
                                    break;
                                }
                            }
                            if (unitChoiceID != Guid.Empty)
                            {
                                if (!Choices.ContainsKey(quantity.ID.ToString()))
                                {
                                    Choices.Add(quantity.ID.ToString(), unitChoiceID.ToString());
                                }
                                else
                                {
                                    throw new Exception("duplicate guid for physical quantity");
                                }
                            }
                            else
                            {
                                throw new Exception("missing default unit choice for this physical quantity");
                            }
                        }
                    }
                }
                else if (defaultUnitChoice == BaseUnitSystem.DefaultUnitSystemEnum.Metric)
                {
                    IsDefault = true;
                    ID = new Guid("0e595036-8f8b-4b70-9d81-3b45f351f55c");
                    Name = "Metric";
                    Description = "Metric System of Units";

                    Choices.Add(AccelerationDrillingQuantity.Instance.ID.ToString(), AccelerationDrillingQuantity.Instance.GetUnitChoice(AccelerationDrillingQuantity.UnitChoicesEnum.MetrePerSecondSquare).ID.ToString());
                    Choices.Add(AngleVariationGradientDrillingQuantity.Instance.ID.ToString(), AngleVariationGradientDrillingQuantity.Instance.GetUnitChoice(AngleVariationGradientDrillingQuantity.UnitChoicesEnum.DegreePerMetre).ID.ToString());
                    Choices.Add(AngularVelocityDrillingQuantity.Instance.ID.ToString(), AngularVelocityDrillingQuantity.Instance.GetUnitChoice(AngularVelocityDrillingQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(AreaDrillingQuantity.Instance.ID.ToString(), AreaDrillingQuantity.Instance.GetUnitChoice(AreaDrillingQuantity.UnitChoicesEnum.SquareMetre).ID.ToString());
                    Choices.Add(AxialVelocityDrillingQuantity.Instance.ID.ToString(), AxialVelocityDrillingQuantity.Instance.GetUnitChoice(AxialVelocityDrillingQuantity.UnitChoicesEnum.MetrePerSecond).ID.ToString());
                    Choices.Add(BlockVelocityQuantity.Instance.ID.ToString(), BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.MetrePerSecond).ID.ToString());
                    Choices.Add(CableDiameterQuantity.Instance.ID.ToString(), CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(CapillaryPressureQuantity.Instance.ID.ToString(), CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.Bar).ID.ToString());
                    Choices.Add(CompressibilityDrillingQuantity.Instance.ID.ToString(), CompressibilityDrillingQuantity.Instance.GetUnitChoice(CompressibilityDrillingQuantity.UnitChoicesEnum.InverseBar).ID.ToString());
                    Choices.Add(CurvatureDrillingQuantity.Instance.ID.ToString(), CurvatureDrillingQuantity.Instance.GetUnitChoice(CurvatureDrillingQuantity.UnitChoicesEnum.DegreePer30m).ID.ToString());
                    Choices.Add(DensityDrillingQuantity.Instance.ID.ToString(), DensityDrillingQuantity.Instance.GetUnitChoice(DensityDrillingQuantity.UnitChoicesEnum.SpecificGravity).ID.ToString());
                    Choices.Add(DensityGradientDepthDrillingQuantity.Instance.ID.ToString(), DensityGradientDepthDrillingQuantity.Instance.GetUnitChoice(DensityGradientDepthDrillingQuantity.UnitChoicesEnum.SpecificGravityPerMetre).ID.ToString());
                    Choices.Add(DensityGradientTemperatureDrillingQuantity.Instance.ID.ToString(), DensityGradientTemperatureDrillingQuantity.Instance.GetUnitChoice(DensityGradientTemperatureDrillingQuantity.UnitChoicesEnum.SpecificGravityPerCelsius).ID.ToString());
                    Choices.Add(DensityRateOfChangeDrillingQuantity.Instance.ID.ToString(), DensityRateOfChangeDrillingQuantity.Instance.GetUnitChoice(DensityRateOfChangeDrillingQuantity.UnitChoicesEnum.SpecificGravityPerSecond).ID.ToString());
                    Choices.Add(DepthQuantity.Instance.ID.ToString(), DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Metre).ID.ToString());
                    Choices.Add(DrillStringMagneticFluxDrillingQuantity.Instance.ID.ToString(), DrillStringMagneticFluxDrillingQuantity.Instance.GetUnitChoice(DrillStringMagneticFluxDrillingQuantity.UnitChoicesEnum.MicroWeber).ID.ToString());
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID.ToString(), DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.MegaPascal).ID.ToString());
                    Choices.Add(DurationDrillingQuantity.Instance.ID.ToString(), DurationDrillingQuantity.Instance.GetUnitChoice(DurationDrillingQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(DynamicViscosityDrillingQuantity.Instance.ID.ToString(), DynamicViscosityDrillingQuantity.Instance.GetUnitChoice(DynamicViscosityDrillingQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(ElongationGradientDrillingQuantity.Instance.ID.ToString(), ElongationGradientDrillingQuantity.Instance.GetUnitChoice(ElongationGradientDrillingQuantity.UnitChoicesEnum.MillimetrePerMetre).ID.ToString()); ;
                    Choices.Add(FluidVelocityDrillingQuantity.Instance.ID.ToString(), FluidVelocityDrillingQuantity.Instance.GetUnitChoice(FluidVelocityDrillingQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(ForceDrillingQuantity.Instance.ID.ToString(), ForceDrillingQuantity.Instance.GetUnitChoice(ForceDrillingQuantity.UnitChoicesEnum.DecaNewton).ID.ToString());
                    Choices.Add(ForceGradientDrillingQuantity.Instance.ID.ToString(), ForceGradientDrillingQuantity.Instance.GetUnitChoice(ForceGradientDrillingQuantity.UnitChoicesEnum.DecaNewtonPerMetre).ID.ToString());
                    Choices.Add(FormationResistivityQuantity.Instance.ID.ToString(), FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMetre).ID.ToString());
                    Choices.Add(FormationStrengthQuantity.Instance.ID.ToString(), FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.MegaPascal).ID.ToString());
                    Choices.Add(GammaRayQuantity.Instance.ID.ToString(), GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID.ToString());
                    Choices.Add(GasShowQuantity.Instance.ID.ToString(), GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID.ToString(), GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerMinute).ID.ToString());
                    Choices.Add(HeatTransferCoefficientDrillingQuantity.Instance.ID.ToString(), HeatTransferCoefficientDrillingQuantity.Instance.GetUnitChoice(HeatTransferCoefficientDrillingQuantity.UnitChoicesEnum.WattPerMetreSquaredPerKelvin).ID.ToString());
                    Choices.Add(HeightQuantity.Instance.ID.ToString(), HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Metre).ID.ToString());
                    Choices.Add(HookLoadQuantity.Instance.ID.ToString(), HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.TonneMetric).ID.ToString());
                    Choices.Add(HydraulicConductivityDrillingQuantity.Instance.ID.ToString(), HydraulicConductivityDrillingQuantity.Instance.GetUnitChoice(HydraulicConductivityDrillingQuantity.UnitChoicesEnum.CentimetrePerSecond).ID.ToString());
                    Choices.Add(InterfacialTensionDrillingQuantity.Instance.ID.ToString(), InterfacialTensionDrillingQuantity.Instance.GetUnitChoice(InterfacialTensionDrillingQuantity.UnitChoicesEnum.NewtonPerMetre).ID.ToString());
                    Choices.Add(MassDrillingQuantity.Instance.ID.ToString(), MassDrillingQuantity.Instance.GetUnitChoice(MassDrillingQuantity.UnitChoicesEnum.Kilogram).ID.ToString());
                    Choices.Add(MassGradientDrillingQuantity.Instance.ID.ToString(), MassGradientDrillingQuantity.Instance.GetUnitChoice(MassGradientDrillingQuantity.UnitChoicesEnum.KilogramPerMetre).ID.ToString());
                    Choices.Add(MassRateDrillingQuantity.Instance.ID.ToString(), MassRateDrillingQuantity.Instance.GetUnitChoice(MassRateDrillingQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(NozzleDiameterQuantity.Instance.ID.ToString(), NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(PipeDiameterQuantity.Instance.ID.ToString(), PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(PlaneAngleDrillingQuantity.Instance.ID.ToString(), PlaneAngleDrillingQuantity.Instance.GetUnitChoice(PlaneAngleDrillingQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(PoreDiameterQuantity.Instance.ID.ToString(), PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Micrometre).ID.ToString());
                    Choices.Add(PoreSurfaceQuantity.Instance.ID.ToString(), PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometre).ID.ToString());
                    Choices.Add(PositionQuantity.Instance.ID.ToString(), PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Metre).ID.ToString());
                    Choices.Add(PowerDrillingQuantity.Instance.ID.ToString(), PowerDrillingQuantity.Instance.GetUnitChoice(PowerDrillingQuantity.UnitChoicesEnum.Watt).ID.ToString());
                    Choices.Add(PressureDrillingQuantity.Instance.ID.ToString(), PressureDrillingQuantity.Instance.GetUnitChoice(PressureDrillingQuantity.UnitChoicesEnum.Bar).ID.ToString());
                    Choices.Add(PressureGradientDrillingQuantity.Instance.ID.ToString(), PressureGradientDrillingQuantity.Instance.GetUnitChoice(PressureGradientDrillingQuantity.UnitChoicesEnum.BarPerMetre).ID.ToString());
                    Choices.Add(PressureLossConstantDrillingQuantity.Instance.ID.ToString(), PressureLossConstantDrillingQuantity.Instance.GetUnitChoice(PressureLossConstantDrillingQuantity.UnitChoicesEnum.PressureLossConstantMetric).ID.ToString());
                    Choices.Add(RandomWalkDrillingQuantity.Instance.ID.ToString(), RandomWalkDrillingQuantity.Instance.GetUnitChoice(RandomWalkDrillingQuantity.UnitChoicesEnum.DegreePerSqrtHour).ID.ToString());
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID.ToString(), RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.MetrePerHour).ID.ToString());
                    Choices.Add(RotationFrequencyRateOfChangeDrillingQuantity.Instance.ID.ToString(), RotationFrequencyRateOfChangeDrillingQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeDrillingQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(ShockRateQuantity.Instance.ID.ToString(), ShockRateQuantity.Instance.GetUnitChoice(ShockRateQuantity.UnitChoicesEnum.ShockPerMinute).ID.ToString());
                    Choices.Add(SpecificHeatCapacityDrillingQuantity.Instance.ID.ToString(), SpecificHeatCapacityDrillingQuantity.Instance.GetUnitChoice(SpecificHeatCapacityDrillingQuantity.UnitChoicesEnum.JoulePerKilogramKelvin).ID.ToString());
                    Choices.Add(SpecificHeatCapacityTemperatureGradientDrillingQuantity.Instance.ID.ToString(), SpecificHeatCapacityTemperatureGradientDrillingQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientDrillingQuantity.UnitChoicesEnum.JoulePerKilogramKelvinPerKelvin).ID.ToString());
                    Choices.Add(StickDurationDrillingQuantity.Instance.ID.ToString(), StickDurationDrillingQuantity.Instance.GetUnitChoice(StickDurationDrillingQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.UnitChoicesEnum.DegreeNanoTesla).ID.ToString());
                    Choices.Add(SurveyInstrumentAngularVelocityDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentAngularVelocityDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentAngularVelocityDrillingQuantity.UnitChoicesEnum.DegreePerHour).ID.ToString());
                    Choices.Add(SurveyInstrumentReciprocalLengthDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentReciprocalLengthDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentReciprocalLengthDrillingQuantity.UnitChoicesEnum.ReciprocalKilometre).ID.ToString());
                    Choices.Add(TemperatureDrillingQuantity.Instance.ID.ToString(), TemperatureDrillingQuantity.Instance.GetUnitChoice(TemperatureDrillingQuantity.UnitChoicesEnum.Celsius).ID.ToString());
                    Choices.Add(TemperatureGradientDrillingQuantity.Instance.ID.ToString(), TemperatureGradientDrillingQuantity.Instance.GetUnitChoice(TemperatureGradientDrillingQuantity.UnitChoicesEnum.CelsiusPer100Metre).ID.ToString());
                    Choices.Add(TensionDrillingQuantity.Instance.ID.ToString(), TensionDrillingQuantity.Instance.GetUnitChoice(TensionDrillingQuantity.UnitChoicesEnum.KiloDecaNewton).ID.ToString());
                    Choices.Add(ThermalConductivityDrillingQuantity.Instance.ID.ToString(), ThermalConductivityDrillingQuantity.Instance.GetUnitChoice(ThermalConductivityDrillingQuantity.UnitChoicesEnum.WattPerMetreKelvin).ID.ToString());
                    Choices.Add(ThermalConductivityTemperatureGradientDrillingQuantity.Instance.ID.ToString(), ThermalConductivityTemperatureGradientDrillingQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientDrillingQuantity.UnitChoicesEnum.WattPerMetreKelvinPerKelvin).ID.ToString());
                    Choices.Add(TorqueDrillingQuantity.Instance.ID.ToString(), TorqueDrillingQuantity.Instance.GetUnitChoice(TorqueDrillingQuantity.UnitChoicesEnum.MetreKiloNewton).ID.ToString());
                    Choices.Add(VolumeDrillingQuantity.Instance.ID.ToString(), VolumeDrillingQuantity.Instance.GetUnitChoice(VolumeDrillingQuantity.UnitChoicesEnum.Liter).ID.ToString());
                    Choices.Add(VolumetricFlowrateDrillingQuantity.Instance.ID.ToString(), VolumetricFlowrateDrillingQuantity.Instance.GetUnitChoice(VolumetricFlowrateDrillingQuantity.UnitChoicesEnum.LiterPerMinute).ID.ToString());
                    Choices.Add(VolumetricFlowRateOfChangeDrillingQuantity.Instance.ID.ToString(), VolumetricFlowRateOfChangeDrillingQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeDrillingQuantity.UnitChoicesEnum.LiterPerMinutePerSecond).ID.ToString());
                    Choices.Add(WeightOnBitQuantity.Instance.ID.ToString(), WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.TonneMetric).ID.ToString());
                }
                else if (defaultUnitChoice == BaseUnitSystem.DefaultUnitSystemEnum.US)
                {
                    IsDefault = true;
                    ID = new Guid("3693c680-8c7e-4977-874e-109be3600c64");
                    Name = "US";
                    Description = "United States of America System of Units";

                    Choices.Add(AccelerationDrillingQuantity.Instance.ID.ToString(), AccelerationDrillingQuantity.Instance.GetUnitChoice(AccelerationDrillingQuantity.UnitChoicesEnum.FootPerSecondSquare).ID.ToString());
                    Choices.Add(AngleVariationGradientDrillingQuantity.Instance.ID.ToString(), AngleVariationGradientDrillingQuantity.Instance.GetUnitChoice(AngleVariationGradientDrillingQuantity.UnitChoicesEnum.DegreePerFoot).ID.ToString());
                    Choices.Add(AngularVelocityDrillingQuantity.Instance.ID.ToString(), AngularVelocityDrillingQuantity.Instance.GetUnitChoice(AngularVelocityDrillingQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(AreaDrillingQuantity.Instance.ID.ToString(), AreaDrillingQuantity.Instance.GetUnitChoice(AreaDrillingQuantity.UnitChoicesEnum.SquareFoot).ID.ToString());
                    Choices.Add(AxialVelocityDrillingQuantity.Instance.ID.ToString(), AxialVelocityDrillingQuantity.Instance.GetUnitChoice(AxialVelocityDrillingQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(BlockVelocityQuantity.Instance.ID.ToString(), BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(CableDiameterQuantity.Instance.ID.ToString(), CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(CapillaryPressureQuantity.Instance.ID.ToString(), CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(CompressibilityDrillingQuantity.Instance.ID.ToString(), CompressibilityDrillingQuantity.Instance.GetUnitChoice(CompressibilityDrillingQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID.ToString());
                    Choices.Add(CurvatureDrillingQuantity.Instance.ID.ToString(), CurvatureDrillingQuantity.Instance.GetUnitChoice(CurvatureDrillingQuantity.UnitChoicesEnum.DegreePer100ft).ID.ToString());
                    Choices.Add(DensityDrillingQuantity.Instance.ID.ToString(), DensityDrillingQuantity.Instance.GetUnitChoice(DensityDrillingQuantity.UnitChoicesEnum.PoundPerGallonUS).ID.ToString());
                    Choices.Add(DensityGradientDepthDrillingQuantity.Instance.ID.ToString(), DensityGradientDepthDrillingQuantity.Instance.GetUnitChoice(DensityGradientDepthDrillingQuantity.UnitChoicesEnum.PoundPerGallonUSPer100Foot).ID.ToString());
                    Choices.Add(DensityGradientTemperatureDrillingQuantity.Instance.ID.ToString(), DensityGradientTemperatureDrillingQuantity.Instance.GetUnitChoice(DensityGradientTemperatureDrillingQuantity.UnitChoicesEnum.PoundPerGallonUSPerFahrenheit).ID.ToString());
                    Choices.Add(DensityRateOfChangeDrillingQuantity.Instance.ID.ToString(), DensityRateOfChangeDrillingQuantity.Instance.GetUnitChoice(DensityRateOfChangeDrillingQuantity.UnitChoicesEnum.PoundPerGallonUSPerHour).ID.ToString());
                    Choices.Add(DepthQuantity.Instance.ID.ToString(), DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Foot).ID.ToString());
                    Choices.Add(DrillStringMagneticFluxDrillingQuantity.Instance.ID.ToString(), DrillStringMagneticFluxDrillingQuantity.Instance.GetUnitChoice(DrillStringMagneticFluxDrillingQuantity.UnitChoicesEnum.MicroWeber).ID.ToString());
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID.ToString(), DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(DurationDrillingQuantity.Instance.ID.ToString(), DurationDrillingQuantity.Instance.GetUnitChoice(DurationDrillingQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(DynamicViscosityDrillingQuantity.Instance.ID.ToString(), DynamicViscosityDrillingQuantity.Instance.GetUnitChoice(DynamicViscosityDrillingQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(ElongationGradientDrillingQuantity.Instance.ID.ToString(), ElongationGradientDrillingQuantity.Instance.GetUnitChoice(ElongationGradientDrillingQuantity.UnitChoicesEnum.InchPerFoot).ID.ToString()); ;
                    Choices.Add(FluidVelocityDrillingQuantity.Instance.ID.ToString(), FluidVelocityDrillingQuantity.Instance.GetUnitChoice(FluidVelocityDrillingQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(ForceDrillingQuantity.Instance.ID.ToString(), ForceDrillingQuantity.Instance.GetUnitChoice(ForceDrillingQuantity.UnitChoicesEnum.PoundForce).ID.ToString());
                    Choices.Add(ForceGradientDrillingQuantity.Instance.ID.ToString(), ForceGradientDrillingQuantity.Instance.GetUnitChoice(ForceGradientDrillingQuantity.UnitChoicesEnum.DecaNewtonPerMetre).ID.ToString());
                    Choices.Add(FormationResistivityQuantity.Instance.ID.ToString(), FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMetre).ID.ToString());
                    Choices.Add(FormationStrengthQuantity.Instance.ID.ToString(), FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(GammaRayQuantity.Instance.ID.ToString(), GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID.ToString());
                    Choices.Add(GasShowQuantity.Instance.ID.ToString(), GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID.ToString(), GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerMinute).ID.ToString());
                    Choices.Add(HeatTransferCoefficientDrillingQuantity.Instance.ID.ToString(), HeatTransferCoefficientDrillingQuantity.Instance.GetUnitChoice(HeatTransferCoefficientDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID.ToString());
                    Choices.Add(HeightQuantity.Instance.ID.ToString(), HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Foot).ID.ToString());
                    Choices.Add(HookLoadQuantity.Instance.ID.ToString(), HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.KiloPound).ID.ToString());
                    Choices.Add(HydraulicConductivityDrillingQuantity.Instance.ID.ToString(), HydraulicConductivityDrillingQuantity.Instance.GetUnitChoice(HydraulicConductivityDrillingQuantity.UnitChoicesEnum.InchPerSecond).ID.ToString());
                    Choices.Add(InterfacialTensionDrillingQuantity.Instance.ID.ToString(), InterfacialTensionDrillingQuantity.Instance.GetUnitChoice(InterfacialTensionDrillingQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID.ToString());
                    Choices.Add(MassDrillingQuantity.Instance.ID.ToString(), MassDrillingQuantity.Instance.GetUnitChoice(MassDrillingQuantity.UnitChoicesEnum.Pound).ID.ToString());
                    Choices.Add(MassGradientDrillingQuantity.Instance.ID.ToString(), MassGradientDrillingQuantity.Instance.GetUnitChoice(MassGradientDrillingQuantity.UnitChoicesEnum.PoundPerFoot).ID.ToString());
                    Choices.Add(MassRateDrillingQuantity.Instance.ID.ToString(), MassRateDrillingQuantity.Instance.GetUnitChoice(MassRateDrillingQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(NozzleDiameterQuantity.Instance.ID.ToString(), NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(PipeDiameterQuantity.Instance.ID.ToString(), PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(PlaneAngleDrillingQuantity.Instance.ID.ToString(), PlaneAngleDrillingQuantity.Instance.GetUnitChoice(PlaneAngleDrillingQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(PoreDiameterQuantity.Instance.ID.ToString(), PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(PoreSurfaceQuantity.Instance.ID.ToString(), PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometre).ID.ToString());
                    Choices.Add(PositionQuantity.Instance.ID.ToString(), PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Foot).ID.ToString());
                    Choices.Add(PowerDrillingQuantity.Instance.ID.ToString(), PowerDrillingQuantity.Instance.GetUnitChoice(PowerDrillingQuantity.UnitChoicesEnum.Watt).ID.ToString());
                    Choices.Add(PressureDrillingQuantity.Instance.ID.ToString(), PressureDrillingQuantity.Instance.GetUnitChoice(PressureDrillingQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(PressureGradientDrillingQuantity.Instance.ID.ToString(), PressureGradientDrillingQuantity.Instance.GetUnitChoice(PressureGradientDrillingQuantity.UnitChoicesEnum.PSIPerFoot).ID.ToString());
                    Choices.Add(PressureLossConstantDrillingQuantity.Instance.ID.ToString(), PressureLossConstantDrillingQuantity.Instance.GetUnitChoice(PressureLossConstantDrillingQuantity.UnitChoicesEnum.PressureLossConstantUS).ID.ToString());
                    Choices.Add(RandomWalkDrillingQuantity.Instance.ID.ToString(), RandomWalkDrillingQuantity.Instance.GetUnitChoice(RandomWalkDrillingQuantity.UnitChoicesEnum.DegreePerSqrtHour).ID.ToString());
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID.ToString(), RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.FootPerHour).ID.ToString());
                    Choices.Add(RotationFrequencyRateOfChangeDrillingQuantity.Instance.ID.ToString(), RotationFrequencyRateOfChangeDrillingQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeDrillingQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(ShockRateQuantity.Instance.ID.ToString(), ShockRateQuantity.Instance.GetUnitChoice(ShockRateQuantity.UnitChoicesEnum.ShockPerMinute).ID.ToString());
                    Choices.Add(SpecificHeatCapacityDrillingQuantity.Instance.ID.ToString(), SpecificHeatCapacityDrillingQuantity.Instance.GetUnitChoice(SpecificHeatCapacityDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFahrenheit).ID.ToString());
                    Choices.Add(SpecificHeatCapacityTemperatureGradientDrillingQuantity.Instance.ID.ToString(), SpecificHeatCapacityTemperatureGradientDrillingQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFahrenheitPerFahrenheit).ID.ToString());
                    Choices.Add(StickDurationDrillingQuantity.Instance.ID.ToString(), StickDurationDrillingQuantity.Instance.GetUnitChoice(StickDurationDrillingQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(SurveyInstrumentAngularVelocityDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentAngularVelocityDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentAngularVelocityDrillingQuantity.UnitChoicesEnum.DegreePerHour).ID.ToString());
                    Choices.Add(SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.UnitChoicesEnum.DegreeNanoTesla).ID.ToString());
                    Choices.Add(SurveyInstrumentReciprocalLengthDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentReciprocalLengthDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentReciprocalLengthDrillingQuantity.UnitChoicesEnum.ReciprocalKilometre).ID.ToString());
                    Choices.Add(TemperatureDrillingQuantity.Instance.ID.ToString(), TemperatureDrillingQuantity.Instance.GetUnitChoice(TemperatureDrillingQuantity.UnitChoicesEnum.Fahrenheit).ID.ToString());
                    Choices.Add(TemperatureGradientDrillingQuantity.Instance.ID.ToString(), TemperatureGradientDrillingQuantity.Instance.GetUnitChoice(TemperatureGradientDrillingQuantity.UnitChoicesEnum.FahrenheitPer100Foot).ID.ToString());
                    Choices.Add(TensionDrillingQuantity.Instance.ID.ToString(), TensionDrillingQuantity.Instance.GetUnitChoice(TensionDrillingQuantity.UnitChoicesEnum.KiloPoundForce).ID.ToString());
                    Choices.Add(ThermalConductivityDrillingQuantity.Instance.ID.ToString(), ThermalConductivityDrillingQuantity.Instance.GetUnitChoice(ThermalConductivityDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheit).ID.ToString());
                    Choices.Add(ThermalConductivityTemperatureGradientDrillingQuantity.Instance.ID.ToString(), ThermalConductivityTemperatureGradientDrillingQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheitPerFahrenheit).ID.ToString());
                    Choices.Add(TorqueDrillingQuantity.Instance.ID.ToString(), TorqueDrillingQuantity.Instance.GetUnitChoice(TorqueDrillingQuantity.UnitChoicesEnum.FootPound).ID.ToString());
                    Choices.Add(VolumeDrillingQuantity.Instance.ID.ToString(), VolumeDrillingQuantity.Instance.GetUnitChoice(VolumeDrillingQuantity.UnitChoicesEnum.USGallon).ID.ToString());
                    Choices.Add(VolumetricFlowrateDrillingQuantity.Instance.ID.ToString(), VolumetricFlowrateDrillingQuantity.Instance.GetUnitChoice(VolumetricFlowrateDrillingQuantity.UnitChoicesEnum.USGallonPerMinute).ID.ToString());
                    Choices.Add(VolumetricFlowRateOfChangeDrillingQuantity.Instance.ID.ToString(), VolumetricFlowRateOfChangeDrillingQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeDrillingQuantity.UnitChoicesEnum.USGallonPerMinutePerSecond).ID.ToString());
                    Choices.Add(WeightOnBitQuantity.Instance.ID.ToString(), WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.KiloPound).ID.ToString());
                }
                else if (defaultUnitChoice == BaseUnitSystem.DefaultUnitSystemEnum.Imperial)
                {
                    IsDefault = true;
                    ID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4");
                    Name = "Imperial";
                    Description = "United Kingdom System of Units";

                    Choices.Add(AccelerationDrillingQuantity.Instance.ID.ToString(), AccelerationDrillingQuantity.Instance.GetUnitChoice(AccelerationDrillingQuantity.UnitChoicesEnum.FootPerSecondSquare).ID.ToString());
                    Choices.Add(AngleVariationGradientDrillingQuantity.Instance.ID.ToString(), AngleVariationGradientDrillingQuantity.Instance.GetUnitChoice(AngleVariationGradientDrillingQuantity.UnitChoicesEnum.DegreePerFoot).ID.ToString());
                    Choices.Add(AngularVelocityDrillingQuantity.Instance.ID.ToString(), AngularVelocityDrillingQuantity.Instance.GetUnitChoice(AngularVelocityDrillingQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(AreaDrillingQuantity.Instance.ID.ToString(), AreaDrillingQuantity.Instance.GetUnitChoice(AreaDrillingQuantity.UnitChoicesEnum.SquareFoot).ID.ToString());
                    Choices.Add(AxialVelocityDrillingQuantity.Instance.ID.ToString(), AxialVelocityDrillingQuantity.Instance.GetUnitChoice(AxialVelocityDrillingQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(BlockVelocityQuantity.Instance.ID.ToString(), BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(CableDiameterQuantity.Instance.ID.ToString(), CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(CapillaryPressureQuantity.Instance.ID.ToString(), CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(CompressibilityDrillingQuantity.Instance.ID.ToString(), CompressibilityDrillingQuantity.Instance.GetUnitChoice(CompressibilityDrillingQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID.ToString());
                    Choices.Add(CurvatureDrillingQuantity.Instance.ID.ToString(), CurvatureDrillingQuantity.Instance.GetUnitChoice(CurvatureDrillingQuantity.UnitChoicesEnum.DegreePer100ft).ID.ToString());
                    Choices.Add(DensityDrillingQuantity.Instance.ID.ToString(), DensityDrillingQuantity.Instance.GetUnitChoice(DensityDrillingQuantity.UnitChoicesEnum.PoundPerGallonUK).ID.ToString());
                    Choices.Add(DensityGradientDepthDrillingQuantity.Instance.ID.ToString(), DensityGradientDepthDrillingQuantity.Instance.GetUnitChoice(DensityGradientDepthDrillingQuantity.UnitChoicesEnum.PoundPerGallonUKPer100Foot).ID.ToString());
                    Choices.Add(DensityGradientTemperatureDrillingQuantity.Instance.ID.ToString(), DensityGradientTemperatureDrillingQuantity.Instance.GetUnitChoice(DensityGradientTemperatureDrillingQuantity.UnitChoicesEnum.PoundPerGallonUSPerFahrenheit).ID.ToString());
                    Choices.Add(DensityRateOfChangeDrillingQuantity.Instance.ID.ToString(), DensityRateOfChangeDrillingQuantity.Instance.GetUnitChoice(DensityRateOfChangeDrillingQuantity.UnitChoicesEnum.PoundPerGallonUKPerHour).ID.ToString());
                    Choices.Add(DepthQuantity.Instance.ID.ToString(), DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Foot).ID.ToString());
                    Choices.Add(DrillStringMagneticFluxDrillingQuantity.Instance.ID.ToString(), DrillStringMagneticFluxDrillingQuantity.Instance.GetUnitChoice(DrillStringMagneticFluxDrillingQuantity.UnitChoicesEnum.MicroWeber).ID.ToString());
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID.ToString(), DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(DurationDrillingQuantity.Instance.ID.ToString(), DurationDrillingQuantity.Instance.GetUnitChoice(DurationDrillingQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(DynamicViscosityDrillingQuantity.Instance.ID.ToString(), DynamicViscosityDrillingQuantity.Instance.GetUnitChoice(DynamicViscosityDrillingQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(ElongationGradientDrillingQuantity.Instance.ID.ToString(), ElongationGradientDrillingQuantity.Instance.GetUnitChoice(ElongationGradientDrillingQuantity.UnitChoicesEnum.InchPerFoot).ID.ToString()); ;
                    Choices.Add(FluidVelocityDrillingQuantity.Instance.ID.ToString(), FluidVelocityDrillingQuantity.Instance.GetUnitChoice(FluidVelocityDrillingQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(ForceDrillingQuantity.Instance.ID.ToString(), ForceDrillingQuantity.Instance.GetUnitChoice(ForceDrillingQuantity.UnitChoicesEnum.PoundForce).ID.ToString());
                    Choices.Add(ForceGradientDrillingQuantity.Instance.ID.ToString(), ForceGradientDrillingQuantity.Instance.GetUnitChoice(ForceGradientDrillingQuantity.UnitChoicesEnum.DecaNewtonPerMetre).ID.ToString());
                    Choices.Add(FormationResistivityQuantity.Instance.ID.ToString(), FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMetre).ID.ToString());
                    Choices.Add(FormationStrengthQuantity.Instance.ID.ToString(), FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(GammaRayQuantity.Instance.ID.ToString(), GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID.ToString());
                    Choices.Add(GasShowQuantity.Instance.ID.ToString(), GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID.ToString(), GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerMinute).ID.ToString());
                    Choices.Add(HeatTransferCoefficientDrillingQuantity.Instance.ID.ToString(), HeatTransferCoefficientDrillingQuantity.Instance.GetUnitChoice(HeatTransferCoefficientDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID.ToString());
                    Choices.Add(HeightQuantity.Instance.ID.ToString(), HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Foot).ID.ToString());
                    Choices.Add(HookLoadQuantity.Instance.ID.ToString(), HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.KiloPound).ID.ToString());
                    Choices.Add(HydraulicConductivityDrillingQuantity.Instance.ID.ToString(), HydraulicConductivityDrillingQuantity.Instance.GetUnitChoice(HydraulicConductivityDrillingQuantity.UnitChoicesEnum.InchPerSecond).ID.ToString());
                    Choices.Add(InterfacialTensionDrillingQuantity.Instance.ID.ToString(), InterfacialTensionDrillingQuantity.Instance.GetUnitChoice(InterfacialTensionDrillingQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID.ToString());
                    Choices.Add(MassDrillingQuantity.Instance.ID.ToString(), MassDrillingQuantity.Instance.GetUnitChoice(MassDrillingQuantity.UnitChoicesEnum.Pound).ID.ToString());
                    Choices.Add(MassGradientDrillingQuantity.Instance.ID.ToString(), MassGradientDrillingQuantity.Instance.GetUnitChoice(MassGradientDrillingQuantity.UnitChoicesEnum.PoundPerFoot).ID.ToString());
                    Choices.Add(MassRateDrillingQuantity.Instance.ID.ToString(), MassRateDrillingQuantity.Instance.GetUnitChoice(MassRateDrillingQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(NozzleDiameterQuantity.Instance.ID.ToString(), NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(PipeDiameterQuantity.Instance.ID.ToString(), PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(PlaneAngleDrillingQuantity.Instance.ID.ToString(), PlaneAngleDrillingQuantity.Instance.GetUnitChoice(PlaneAngleDrillingQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(PoreDiameterQuantity.Instance.ID.ToString(), PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(PoreSurfaceQuantity.Instance.ID.ToString(), PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometre).ID.ToString());
                    Choices.Add(PositionQuantity.Instance.ID.ToString(), PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Foot).ID.ToString());
                    Choices.Add(PowerDrillingQuantity.Instance.ID.ToString(), PowerDrillingQuantity.Instance.GetUnitChoice(PowerDrillingQuantity.UnitChoicesEnum.Watt).ID.ToString());
                    Choices.Add(PressureDrillingQuantity.Instance.ID.ToString(), PressureDrillingQuantity.Instance.GetUnitChoice(PressureDrillingQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(PressureGradientDrillingQuantity.Instance.ID.ToString(), PressureGradientDrillingQuantity.Instance.GetUnitChoice(PressureGradientDrillingQuantity.UnitChoicesEnum.PSIPerFoot).ID.ToString());
                    Choices.Add(PressureLossConstantDrillingQuantity.Instance.ID.ToString(), PressureLossConstantDrillingQuantity.Instance.GetUnitChoice(PressureLossConstantDrillingQuantity.UnitChoicesEnum.PressureLossConstantUK).ID.ToString());
                    Choices.Add(RandomWalkDrillingQuantity.Instance.ID.ToString(), RandomWalkDrillingQuantity.Instance.GetUnitChoice(RandomWalkDrillingQuantity.UnitChoicesEnum.DegreePerSqrtHour).ID.ToString());
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID.ToString(), RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.FootPerHour).ID.ToString());
                    Choices.Add(RotationFrequencyRateOfChangeDrillingQuantity.Instance.ID.ToString(), RotationFrequencyRateOfChangeDrillingQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeDrillingQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(ShockRateQuantity.Instance.ID.ToString(), ShockRateQuantity.Instance.GetUnitChoice(ShockRateQuantity.UnitChoicesEnum.ShockPerMinute).ID.ToString());
                    Choices.Add(SpecificHeatCapacityDrillingQuantity.Instance.ID.ToString(), SpecificHeatCapacityDrillingQuantity.Instance.GetUnitChoice(SpecificHeatCapacityDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFahrenheit).ID.ToString());
                    Choices.Add(SpecificHeatCapacityTemperatureGradientDrillingQuantity.Instance.ID.ToString(), SpecificHeatCapacityTemperatureGradientDrillingQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFahrenheitPerFahrenheit).ID.ToString());
                    Choices.Add(StickDurationDrillingQuantity.Instance.ID.ToString(), StickDurationDrillingQuantity.Instance.GetUnitChoice(StickDurationDrillingQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(SurveyInstrumentAngularVelocityDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentAngularVelocityDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentAngularVelocityDrillingQuantity.UnitChoicesEnum.DegreePerHour).ID.ToString());
                    Choices.Add(SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.UnitChoicesEnum.DegreeNanoTesla).ID.ToString());
                    Choices.Add(SurveyInstrumentReciprocalLengthDrillingQuantity.Instance.ID.ToString(), SurveyInstrumentReciprocalLengthDrillingQuantity.Instance.GetUnitChoice(SurveyInstrumentReciprocalLengthDrillingQuantity.UnitChoicesEnum.ReciprocalKilometre).ID.ToString());
                    Choices.Add(TemperatureDrillingQuantity.Instance.ID.ToString(), TemperatureDrillingQuantity.Instance.GetUnitChoice(TemperatureDrillingQuantity.UnitChoicesEnum.Fahrenheit).ID.ToString());
                    Choices.Add(TemperatureGradientDrillingQuantity.Instance.ID.ToString(), TemperatureGradientDrillingQuantity.Instance.GetUnitChoice(TemperatureGradientDrillingQuantity.UnitChoicesEnum.CelsiusPer100Foot).ID.ToString());
                    Choices.Add(TensionDrillingQuantity.Instance.ID.ToString(), TensionDrillingQuantity.Instance.GetUnitChoice(TensionDrillingQuantity.UnitChoicesEnum.KiloPoundForce).ID.ToString());
                    Choices.Add(ThermalConductivityDrillingQuantity.Instance.ID.ToString(), ThermalConductivityDrillingQuantity.Instance.GetUnitChoice(ThermalConductivityDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheit).ID.ToString());
                    Choices.Add(ThermalConductivityTemperatureGradientDrillingQuantity.Instance.ID.ToString(), ThermalConductivityTemperatureGradientDrillingQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientDrillingQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheitPerFahrenheit).ID.ToString());
                    Choices.Add(TorqueDrillingQuantity.Instance.ID.ToString(), TorqueDrillingQuantity.Instance.GetUnitChoice(TorqueDrillingQuantity.UnitChoicesEnum.FootPound).ID.ToString());
                    Choices.Add(VolumeDrillingQuantity.Instance.ID.ToString(), VolumeDrillingQuantity.Instance.GetUnitChoice(VolumeDrillingQuantity.UnitChoicesEnum.UKGallon).ID.ToString());
                    Choices.Add(VolumetricFlowrateDrillingQuantity.Instance.ID.ToString(), VolumetricFlowrateDrillingQuantity.Instance.GetUnitChoice(VolumetricFlowrateDrillingQuantity.UnitChoicesEnum.UKGallonPerMinute).ID.ToString());
                    Choices.Add(VolumetricFlowRateOfChangeDrillingQuantity.Instance.ID.ToString(), VolumetricFlowRateOfChangeDrillingQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeDrillingQuantity.UnitChoicesEnum.UKGallonPerMinutePerSecond).ID.ToString());
                    Choices.Add(WeightOnBitQuantity.Instance.ID.ToString(), WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.KiloPound).ID.ToString());
                }
                CheckMissing(quantities);
            }
        }


        public static new BaseUnitSystem Get(Guid ID)
        {
            if (unitSystemDict_ == null)
            {
                Initialize();
            }
            UnitSystem result;
            unitSystemDict_.TryGetValue(ID, out result);
            if (result == null)
            {
                return BaseUnitSystem.Get(ID);
            }
            else
            {
                return result;
            }
        }

        public static new UnitSystem CreateNew()
        {
            if (unitSystemDict_ == null)
            {
                Initialize();
            }
            UnitSystem unitSystem = new UnitSystem();
            unitSystem.ID = Guid.NewGuid();
            unitSystemDict_.Add(unitSystem.ID, unitSystem);
            return unitSystem;
        }

        public static new UnitSystem CreateNew(Guid guid)
        {
            if (unitSystemDict_ == null)
            {
                Initialize();
            }
            if (unitSystemDict_.ContainsKey(guid))
            {
                UnitSystem result;
                unitSystemDict_.TryGetValue(guid, out result);
                return result;
            }
            else
            {
                UnitSystem unitSystem = new UnitSystem();
                unitSystem.ID = guid;
                unitSystemDict_.Add(unitSystem.ID, unitSystem);
                return unitSystem;
            }
        }

        /// <summary>
        /// Adds the given UnitSystem to the static Dictionary of available UnitSystems
        /// </summary>
        /// <param name="unitSystem"></param>
        /// <returns>Returns true is effectively added to the static Dictionary, false otherwise</returns>
        public static bool Add(UnitSystem unitSystem)
        {
            if (unitSystemDict_ == null)
            {
                Initialize();
            }
            if (!unitSystemDict_.ContainsKey(unitSystem.ID))
            {
                unitSystemDict_.Add(unitSystem.ID, unitSystem);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Updates the given UnitSystem in the static Dictionary of available UnitSystems
        /// </summary>
        /// <param name="unitSystem"></param>
        /// <returns>Returns true is effectively updated in the static Dictionary, false otherwise</returns>
        public static bool Update(UnitSystem unitSystem)
        {
            if (unitSystemDict_ == null)
            {
                Initialize();
            }
            if (unitSystemDict_.ContainsKey(unitSystem.ID))
            {
                unitSystemDict_[unitSystem.ID] = unitSystem;
                return true;
            }
            return false;
        }

        private static void Initialize()
        {
            if (unitSystemDict_ == null)
            {
                unitSystemDict_ = new Dictionary<Guid, UnitSystem>();
                UnitSystem SI = SIUnitSystem;
                unitSystemDict_.Add(SI.ID, SI);
                UnitSystem metric = MetricUnitSystem;
                unitSystemDict_.Add(metric.ID, metric);
                UnitSystem US = USUnitSystem;
                unitSystemDict_.Add(US.ID, US);
                UnitSystem imperial = ImperialUnitSystem;
                unitSystemDict_.Add(imperial.ID, imperial);
            }
        }

        public static UnitSystem SIUnitSystem
        {
            get
            {
                if (SIUnitSystem_ == null)
                {
                    SIUnitSystem_ = new UnitSystem(BaseUnitSystem.DefaultUnitSystemEnum.SI);
                }
                return SIUnitSystem_;
            }
        }
        public static UnitSystem MetricUnitSystem
        {
            get
            {
                if (MetricUnitSystem_ == null)
                {
                    MetricUnitSystem_ = new UnitSystem(BaseUnitSystem.DefaultUnitSystemEnum.Metric);
                }
                return MetricUnitSystem_;
            }
        }
        public static UnitSystem ImperialUnitSystem
        {
            get
            {
                if (ImperialUnitSystem_ == null)
                {
                    ImperialUnitSystem_ = new UnitSystem(BaseUnitSystem.DefaultUnitSystemEnum.Imperial);
                }
                return ImperialUnitSystem_;
            }
        }
        public static UnitSystem USUnitSystem
        {
            get
            {
                if (USUnitSystem_ == null)
                {
                    USUnitSystem_ = new UnitSystem(BaseUnitSystem.DefaultUnitSystemEnum.US);
                }
                return USUnitSystem_;
            }
        }

        public static List<BasePhysicalQuantity> AvailableQuantities
        {
            get
            {
                if (availablePhysicalQuantities_ == null)
                {
                    Assembly assembly = Assembly.GetAssembly(typeof(UnitSystem));
                    if (assembly != null)
                    {
                        foreach (Type typ in assembly.GetTypes())
                        {
                            if (typ.IsSubclassOf(typeof(BasePhysicalQuantity)))
                            {
                                MethodInfo method = null;
                                foreach (MethodInfo meth in typ.GetMethods())
                                {
                                    if (meth.IsStatic &&
                                        meth.Name.EndsWith("Instance") &&
                                        meth.ReturnType.IsSubclassOf(typeof(BasePhysicalQuantity)))
                                    {
                                        method = meth;
                                        break;
                                    }
                                }
                                // call the method
                                if (method != null)
                                {
                                    object obj = method.Invoke(null, null);
                                    if (obj != null)
                                    {
                                        var res = (BasePhysicalQuantity)obj;
                                        if (availablePhysicalQuantities_ == null)
                                        {
                                            availablePhysicalQuantities_ = new List<BasePhysicalQuantity>();
                                        }
                                        availablePhysicalQuantities_.Add(res);
                                    }
                                }
                            }
                        }
                    }
                }
                return availablePhysicalQuantities_;
            }
        }

        public double? FromSI(PhysicalQuantity.QuantityEnum physicalQuantityID, double val)
        {
            UnitChoice choice = GetChoice(physicalQuantityID);
            if (choice != null)
            {
                return choice.FromSI(val);
            }
            else
            {
                return null;
            }
        }
        public string FromSIString(PhysicalQuantity.QuantityEnum physicalQuantityID, double val)
        {
            double? meaningfulPrecision = null;
            BasePhysicalQuantity quantity = PhysicalQuantity.GetQuantity(physicalQuantityID);
            meaningfulPrecision = quantity.MeaningfulPrecisionInSI;
            UnitChoice choice = GetChoice(physicalQuantityID);
            if (choice != null)
            {
                return choice.FromSI(val, meaningfulPrecision);
            }
            else
            {
                return null;
            }
        }
        public double? ToSI(PhysicalQuantity.QuantityEnum physicalQuantityID, double val)
        {
            UnitChoice choice = GetChoice(physicalQuantityID);
            if (choice != null)
            {
                return choice.ToSI(val);
            }
            else
            {
                return null;
            }
        }

        public UnitChoice GetChoice(PhysicalQuantity.QuantityEnum physicalQuantityID)
        {
            UnitChoice choice = null;
            string unitChoiceID;
            BasePhysicalQuantity quantity = GetQuantity(physicalQuantityID);
            if (quantity != null && Choices.TryGetValue(quantity.ID.ToString(), out unitChoiceID))
            {
                Guid ID = StringToGUID(unitChoiceID);
                if (ID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(ID);
                }
            }
            return choice;
        }
        public string GetUnitLabel(PhysicalQuantity.QuantityEnum physicalQuantityID)
        {
            UnitChoice choice = GetChoice(physicalQuantityID);
            if (choice != null)
            {
                return choice.UnitLabel;
            }
            else
            {
                return null;
            }
        }

        protected BasePhysicalQuantity GetQuantity(PhysicalQuantity.QuantityEnum quantityChoice)
        {
            return PhysicalQuantity.GetQuantity(quantityChoice);
        }
        protected override BasePhysicalQuantity GetQuantity(Guid quantityID)
        {
            BasePhysicalQuantity quantity = PhysicalQuantity.GetQuantity(quantityID);
            if (quantity == null)
            {
                quantity = base.GetQuantity(quantityID);
            }
            return quantity;
        }
        protected override BasePhysicalQuantity GetQuantity(string quantityName)
        {
            BasePhysicalQuantity quantity = PhysicalQuantity.GetQuantity(quantityName);
            if (quantity == null)
            {
                quantity = base.GetQuantity(quantityName);
            }
            return quantity;
        }

    }
}
