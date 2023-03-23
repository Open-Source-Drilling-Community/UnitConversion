using System;
using System.Collections.Generic;
using System.Reflection;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public class DrillingUnitChoiceSet : UnitChoiceSet
    {
        private static Dictionary<Guid, DrillingUnitChoiceSet> unitChoiceSets_ = null;

        private static List<PhysicalQuantity> availableQuantities_ = null;

        private static DrillingUnitChoiceSet SIUnitChoiceSet_ = null;
        private static DrillingUnitChoiceSet MetricUnitChoiceSet_ = null;
        private static DrillingUnitChoiceSet ImperialUnitChoiceSet_ = null;
        private static DrillingUnitChoiceSet USUnitChoiceSet_ = null;

        /// <summary>
        /// default constructor
        /// </summary>
        public DrillingUnitChoiceSet() : base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultUnitChoice"></param>
        public DrillingUnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum defaultUnitChoice) : base(defaultUnitChoice)
        {
            List<PhysicalQuantity> quantities = DrillingUnitChoiceSet.AvailableQuantities;
            if (quantities != null)
            {
                /*
                // generate
                foreach(PhysicalQuantity quantity in quantities)
                {
                    Console.WriteLine("Choices.Add(" + quantity.GetType().Name + ".Instance.ID, " + quantity.GetType().Name + ".Instance.GetUnitChoice(" + quantity.GetType().Name + ".UnitChoicesEnum.).ID);");
                }
                */

                if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.SI)
                {
                    IsSI = true;
                    IsDefault = true;
                    ID = new Guid("f8338e35-c548-4284-a2e7-61b94a7b4769");
                    Name = "SI";
                    Description = "International System of Units";

                    foreach (PhysicalQuantity quantity in quantities)
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
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.Metric)
                {
                    IsDefault = true;
                    ID = new Guid("0e595036-8f8b-4b70-9d81-3b45f351f55c");
                    Name = "Metric";
                    Description = "Metric System of Units";

                    Choices.Add(BlockVelocityQuantity.Instance.ID.ToString(), BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.MeterPerSecond).ID.ToString());
                    Choices.Add(CableDiameterQuantity.Instance.ID.ToString(), CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(CapillaryPressureQuantity.Instance.ID.ToString(), CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.Bar).ID.ToString());
                    Choices.Add(DepthQuantity.Instance.ID.ToString(), DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Metre).ID.ToString());
                    Choices.Add(DrillingAccelerationQuantity.Instance.ID.ToString(), DrillingAccelerationQuantity.Instance.GetUnitChoice(DrillingAccelerationQuantity.UnitChoicesEnum.MeterPerSecondSquare).ID.ToString());
                    Choices.Add(DrillingAngleVariationGradientQuantity.Instance.ID.ToString(), DrillingAngleVariationGradientQuantity.Instance.GetUnitChoice(DrillingAngleVariationGradientQuantity.UnitChoicesEnum.DegreePerMeter).ID.ToString());
                    Choices.Add(DrillingAngularVelocityQuantity.Instance.ID.ToString(), DrillingAngularVelocityQuantity.Instance.GetUnitChoice(DrillingAngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(DrillingAreaQuantity.Instance.ID.ToString(), DrillingAreaQuantity.Instance.GetUnitChoice(DrillingAreaQuantity.UnitChoicesEnum.SquareMeter).ID.ToString());
                    Choices.Add(DrillingCompressibilityQuantity.Instance.ID.ToString(), DrillingCompressibilityQuantity.Instance.GetUnitChoice(DrillingCompressibilityQuantity.UnitChoicesEnum.InverseBar).ID.ToString());
                    Choices.Add(DrillingCurvatureQuantity.Instance.ID.ToString(), DrillingCurvatureQuantity.Instance.GetUnitChoice(DrillingCurvatureQuantity.UnitChoicesEnum.DegreePer30m).ID.ToString());
                    Choices.Add(DrillingDensityGradientDepthQuantity.Instance.ID.ToString(), DrillingDensityGradientDepthQuantity.Instance.GetUnitChoice(DrillingDensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPerMeter).ID.ToString());
                    Choices.Add(DrillingDensityGradientTemperatureQuantity.Instance.ID.ToString(), DrillingDensityGradientTemperatureQuantity.Instance.GetUnitChoice(DrillingDensityGradientTemperatureQuantity.UnitChoicesEnum.SpecificGravityPerCelsius).ID.ToString());
                    Choices.Add(DrillingDensityQuantity.Instance.ID.ToString(), DrillingDensityQuantity.Instance.GetUnitChoice(DrillingDensityQuantity.UnitChoicesEnum.SpecificGravity).ID.ToString());
                    Choices.Add(DrillingDensityRateOfChangeQuantity.Instance.ID.ToString(), DrillingDensityRateOfChangeQuantity.Instance.GetUnitChoice(DrillingDensityRateOfChangeQuantity.UnitChoicesEnum.SpecificGravityPerSecond).ID.ToString());
                    Choices.Add(DrillingDurationQuantity.Instance.ID.ToString(), DrillingDurationQuantity.Instance.GetUnitChoice(DrillingDurationQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(DrillingDynamicViscosityQuantity.Instance.ID.ToString(), DrillingDynamicViscosityQuantity.Instance.GetUnitChoice(DrillingDynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(DrillingElongationGradientQuantity.Instance.ID.ToString(), DrillingElongationGradientQuantity.Instance.GetUnitChoice(DrillingElongationGradientQuantity.UnitChoicesEnum.MillimeterPerMeter).ID.ToString()); ;
                    Choices.Add(DrillingFluidVelocityQuantity.Instance.ID.ToString(), DrillingFluidVelocityQuantity.Instance.GetUnitChoice(DrillingFluidVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(DrillingForceGradientQuantity.Instance.ID.ToString(), DrillingForceGradientQuantity.Instance.GetUnitChoice(DrillingForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID.ToString());
                    Choices.Add(DrillingForceQuantity.Instance.ID.ToString(), DrillingForceQuantity.Instance.GetUnitChoice(DrillingForceQuantity.UnitChoicesEnum.DecaNewton).ID.ToString());
                    Choices.Add(DrillingHeatTransferCoefficientQuantity.Instance.ID.ToString(), DrillingHeatTransferCoefficientQuantity.Instance.GetUnitChoice(DrillingHeatTransferCoefficientQuantity.UnitChoicesEnum.WattPerMeterSquaredPerKelvin).ID.ToString());
                    Choices.Add(DrillingHydraulicConductivityQuantity.Instance.ID.ToString(), DrillingHydraulicConductivityQuantity.Instance.GetUnitChoice(DrillingHydraulicConductivityQuantity.UnitChoicesEnum.CentimeterPerSecond).ID.ToString());
                    Choices.Add(DrillingInterfacialTensionQuantity.Instance.ID.ToString(), DrillingInterfacialTensionQuantity.Instance.GetUnitChoice(DrillingInterfacialTensionQuantity.UnitChoicesEnum.NewtonPerMeter).ID.ToString());
                    Choices.Add(DrillingMassQuantity.Instance.ID.ToString(), DrillingMassQuantity.Instance.GetUnitChoice(DrillingMassQuantity.UnitChoicesEnum.Kilogram).ID.ToString());
                    Choices.Add(DrillingMassGradientQuantity.Instance.ID.ToString(), DrillingMassGradientQuantity.Instance.GetUnitChoice(DrillingMassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID.ToString());
                    Choices.Add(DrillingMassRateQuantity.Instance.ID.ToString(), DrillingMassRateQuantity.Instance.GetUnitChoice(DrillingMassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(DrillingPlaneAngleQuantity.Instance.ID.ToString(), DrillingPlaneAngleQuantity.Instance.GetUnitChoice(DrillingPlaneAngleQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(DrillingPressureGradientQuantity.Instance.ID.ToString(), DrillingPressureGradientQuantity.Instance.GetUnitChoice(DrillingPressureGradientQuantity.UnitChoicesEnum.BarPerMeter).ID.ToString());
                    Choices.Add(DrillingPressureQuantity.Instance.ID.ToString(), DrillingPressureQuantity.Instance.GetUnitChoice(DrillingPressureQuantity.UnitChoicesEnum.Bar).ID.ToString());
                    Choices.Add(DrillingPressureLossConstantQuantity.Instance.ID.ToString(), DrillingPressureLossConstantQuantity.Instance.GetUnitChoice(DrillingPressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantMetric).ID.ToString());
                    Choices.Add(DrillingRotationFrequencyRateOfChangeQuantity.Instance.ID.ToString(), DrillingRotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(DrillingRotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(DrillingSpecificHeatCapacityQuantity.Instance.ID.ToString(), DrillingSpecificHeatCapacityQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerKilogramKelvin).ID.ToString());
                    Choices.Add(DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.ID.ToString(), DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerKilogramKelvinPerKelvin).ID.ToString());
                    Choices.Add(DrillingTemperatureQuantity.Instance.ID.ToString(), DrillingTemperatureQuantity.Instance.GetUnitChoice(DrillingTemperatureQuantity.UnitChoicesEnum.Celsius).ID.ToString());
                    Choices.Add(DrillingTemperatureGradientQuantity.Instance.ID.ToString(), DrillingTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingTemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Meter).ID.ToString());
                    Choices.Add(DrillingTensionQuantity.Instance.ID.ToString(), DrillingTensionQuantity.Instance.GetUnitChoice(DrillingTensionQuantity.UnitChoicesEnum.KiloDecaNewton).ID.ToString());
                    Choices.Add(DrillingThermalConductivityQuantity.Instance.ID.ToString(), DrillingThermalConductivityQuantity.Instance.GetUnitChoice(DrillingThermalConductivityQuantity.UnitChoicesEnum.WattPerMetreKelvin).ID.ToString());
                    Choices.Add(DrillingThermalConductivityTemperatureGradientQuantity.Instance.ID.ToString(), DrillingThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.WattPerMetreKelvinPerKelvin).ID.ToString());
                    Choices.Add(DrillingTorqueQuantity.Instance.ID.ToString(), DrillingTorqueQuantity.Instance.GetUnitChoice(DrillingTorqueQuantity.UnitChoicesEnum.MeterKiloNewton).ID.ToString());
                    Choices.Add(DrillingVolumeQuantity.Instance.ID.ToString(), DrillingVolumeQuantity.Instance.GetUnitChoice(DrillingVolumeQuantity.UnitChoicesEnum.Liter).ID.ToString());
                    Choices.Add(DrillingVolumetricFlowRateOfChangeQuantity.Instance.ID.ToString(), DrillingVolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.LiterPerMinutePerSecond).ID.ToString());
                    Choices.Add(DrillingVolumetricFlowrateQuantity.Instance.ID.ToString(), DrillingVolumetricFlowrateQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowrateQuantity.UnitChoicesEnum.LiterPerMinute).ID.ToString());
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID.ToString(), DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.MegaPascal).ID.ToString());
                    Choices.Add(HeightQuantity.Instance.ID.ToString(), HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Metre).ID.ToString());
                    Choices.Add(NozzleDiameterQuantity.Instance.ID.ToString(), NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(PipeDiameterQuantity.Instance.ID.ToString(), PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(PoreDiameterQuantity.Instance.ID.ToString(), PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Micrometer).ID.ToString());
                    Choices.Add(PositionQuantity.Instance.ID.ToString(), PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Metre).ID.ToString());
                    Choices.Add(FormationStrengthQuantity.Instance.ID.ToString(), FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.MegaPascal).ID.ToString());
                    Choices.Add(FormationResistivityQuantity.Instance.ID.ToString(), FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMeter).ID.ToString());
                    Choices.Add(GammaRayQuantity.Instance.ID.ToString(), GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID.ToString());
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID.ToString(), GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerMinute).ID.ToString());
                    Choices.Add(GasShowQuantity.Instance.ID.ToString(), GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(HookLoadQuantity.Instance.ID.ToString(), HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.TonneMetric).ID.ToString());
                    Choices.Add(PoreSurfaceQuantity.Instance.ID.ToString(), PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometer).ID.ToString());
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID.ToString(), RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.MeterPerHour).ID.ToString());
                    Choices.Add(WeightOnBitQuantity.Instance.ID.ToString(), WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.TonneMetric).ID.ToString());
                }
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.US)
                {
                    IsDefault = true;
                    ID = new Guid("3693c680-8c7e-4977-874e-109be3600c64");
                    Name = "US";
                    Description = "United States of America System of Units";

                    Choices.Add(BlockVelocityQuantity.Instance.ID.ToString(), BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(CableDiameterQuantity.Instance.ID.ToString(), CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(CapillaryPressureQuantity.Instance.ID.ToString(), CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(DepthQuantity.Instance.ID.ToString(), DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(DrillingAccelerationQuantity.Instance.ID.ToString(), DrillingAccelerationQuantity.Instance.GetUnitChoice(DrillingAccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare).ID.ToString());
                    Choices.Add(DrillingAngleVariationGradientQuantity.Instance.ID.ToString(), DrillingAngleVariationGradientQuantity.Instance.GetUnitChoice(DrillingAngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID.ToString());
                    Choices.Add(DrillingAngularVelocityQuantity.Instance.ID.ToString(), DrillingAngularVelocityQuantity.Instance.GetUnitChoice(DrillingAngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(DrillingAreaQuantity.Instance.ID.ToString(), DrillingAreaQuantity.Instance.GetUnitChoice(DrillingAreaQuantity.UnitChoicesEnum.SquareFoot).ID.ToString());
                    Choices.Add(DrillingCompressibilityQuantity.Instance.ID.ToString(), DrillingCompressibilityQuantity.Instance.GetUnitChoice(DrillingCompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID.ToString());
                    Choices.Add(DrillingCurvatureQuantity.Instance.ID.ToString(), DrillingCurvatureQuantity.Instance.GetUnitChoice(DrillingCurvatureQuantity.UnitChoicesEnum.DegreePer100ft).ID.ToString());
                    Choices.Add(DrillingDensityGradientDepthQuantity.Instance.ID.ToString(), DrillingDensityGradientDepthQuantity.Instance.GetUnitChoice(DrillingDensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer100Foot).ID.ToString());
                    Choices.Add(DrillingDensityGradientTemperatureQuantity.Instance.ID.ToString(), DrillingDensityGradientTemperatureQuantity.Instance.GetUnitChoice(DrillingDensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit).ID.ToString());
                    Choices.Add(DrillingDensityQuantity.Instance.ID.ToString(), DrillingDensityQuantity.Instance.GetUnitChoice(DrillingDensityQuantity.UnitChoicesEnum.PoundPerGallonUS).ID.ToString());
                    Choices.Add(DrillingDensityRateOfChangeQuantity.Instance.ID.ToString(), DrillingDensityRateOfChangeQuantity.Instance.GetUnitChoice(DrillingDensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUSPerHour).ID.ToString());
                    Choices.Add(DrillingDurationQuantity.Instance.ID.ToString(), DrillingDurationQuantity.Instance.GetUnitChoice(DrillingDurationQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(DrillingDynamicViscosityQuantity.Instance.ID.ToString(), DrillingDynamicViscosityQuantity.Instance.GetUnitChoice(DrillingDynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(DrillingElongationGradientQuantity.Instance.ID.ToString(), DrillingElongationGradientQuantity.Instance.GetUnitChoice(DrillingElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID.ToString()); ;
                    Choices.Add(DrillingFluidVelocityQuantity.Instance.ID.ToString(), DrillingFluidVelocityQuantity.Instance.GetUnitChoice(DrillingFluidVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(DrillingForceGradientQuantity.Instance.ID.ToString(), DrillingForceGradientQuantity.Instance.GetUnitChoice(DrillingForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID.ToString());
                    Choices.Add(DrillingForceQuantity.Instance.ID.ToString(), DrillingForceQuantity.Instance.GetUnitChoice(DrillingForceQuantity.UnitChoicesEnum.PoundForce).ID.ToString());
                    Choices.Add(DrillingHeatTransferCoefficientQuantity.Instance.ID.ToString(), DrillingHeatTransferCoefficientQuantity.Instance.GetUnitChoice(DrillingHeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID.ToString());
                    Choices.Add(DrillingHydraulicConductivityQuantity.Instance.ID.ToString(), DrillingHydraulicConductivityQuantity.Instance.GetUnitChoice(DrillingHydraulicConductivityQuantity.UnitChoicesEnum.InchPerSecond).ID.ToString());
                    Choices.Add(DrillingInterfacialTensionQuantity.Instance.ID.ToString(), DrillingInterfacialTensionQuantity.Instance.GetUnitChoice(DrillingInterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID.ToString());
                    Choices.Add(DrillingMassQuantity.Instance.ID.ToString(), DrillingMassQuantity.Instance.GetUnitChoice(DrillingMassQuantity.UnitChoicesEnum.Pound).ID.ToString());
                    Choices.Add(DrillingMassGradientQuantity.Instance.ID.ToString(), DrillingMassGradientQuantity.Instance.GetUnitChoice(DrillingMassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID.ToString());
                    Choices.Add(DrillingMassRateQuantity.Instance.ID.ToString(), DrillingMassRateQuantity.Instance.GetUnitChoice(DrillingMassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(DrillingPlaneAngleQuantity.Instance.ID.ToString(), DrillingPlaneAngleQuantity.Instance.GetUnitChoice(DrillingPlaneAngleQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(DrillingPressureGradientQuantity.Instance.ID.ToString(), DrillingPressureGradientQuantity.Instance.GetUnitChoice(DrillingPressureGradientQuantity.UnitChoicesEnum.PSIPerFoot).ID.ToString());
                    Choices.Add(DrillingPressureQuantity.Instance.ID.ToString(), DrillingPressureQuantity.Instance.GetUnitChoice(DrillingPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(DrillingPressureLossConstantQuantity.Instance.ID.ToString(), DrillingPressureLossConstantQuantity.Instance.GetUnitChoice(DrillingPressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUS).ID.ToString());
                    Choices.Add(DrillingRotationFrequencyRateOfChangeQuantity.Instance.ID.ToString(), DrillingRotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(DrillingRotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(DrillingSpecificHeatCapacityQuantity.Instance.ID.ToString(), DrillingSpecificHeatCapacityQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit).ID.ToString());
                    Choices.Add(DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.ID.ToString(), DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit).ID.ToString());
                    Choices.Add(DrillingTemperatureQuantity.Instance.ID.ToString(), DrillingTemperatureQuantity.Instance.GetUnitChoice(DrillingTemperatureQuantity.UnitChoicesEnum.Fahrenheit).ID.ToString());
                    Choices.Add(DrillingTemperatureGradientQuantity.Instance.ID.ToString(), DrillingTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingTemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot).ID.ToString());
                    Choices.Add(DrillingTensionQuantity.Instance.ID.ToString(), DrillingTensionQuantity.Instance.GetUnitChoice(DrillingTensionQuantity.UnitChoicesEnum.KiloPoundForce).ID.ToString());
                    Choices.Add(DrillingThermalConductivityQuantity.Instance.ID.ToString(), DrillingThermalConductivityQuantity.Instance.GetUnitChoice(DrillingThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit).ID.ToString());
                    Choices.Add(DrillingThermalConductivityTemperatureGradientQuantity.Instance.ID.ToString(), DrillingThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit).ID.ToString());
                    Choices.Add(DrillingTorqueQuantity.Instance.ID.ToString(), DrillingTorqueQuantity.Instance.GetUnitChoice(DrillingTorqueQuantity.UnitChoicesEnum.FootPound).ID.ToString());
                    Choices.Add(DrillingVolumeQuantity.Instance.ID.ToString(), DrillingVolumeQuantity.Instance.GetUnitChoice(DrillingVolumeQuantity.UnitChoicesEnum.USGallon).ID.ToString());
                    Choices.Add(DrillingVolumetricFlowRateOfChangeQuantity.Instance.ID.ToString(), DrillingVolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.USGallonPerMinutePerSecond).ID.ToString());
                    Choices.Add(DrillingVolumetricFlowrateQuantity.Instance.ID.ToString(), DrillingVolumetricFlowrateQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowrateQuantity.UnitChoicesEnum.USGallonPerMinute).ID.ToString());
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID.ToString(), DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(NozzleDiameterQuantity.Instance.ID.ToString(), NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(PipeDiameterQuantity.Instance.ID.ToString(), PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(PositionQuantity.Instance.ID.ToString(), PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(PoreDiameterQuantity.Instance.ID.ToString(), PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(FormationStrengthQuantity.Instance.ID.ToString(), FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(FormationResistivityQuantity.Instance.ID.ToString(), FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMeter).ID.ToString());
                    Choices.Add(GammaRayQuantity.Instance.ID.ToString(), GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID.ToString());
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID.ToString(), GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerMinute).ID.ToString());
                    Choices.Add(GasShowQuantity.Instance.ID.ToString(), GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(HeightQuantity.Instance.ID.ToString(), HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(HookLoadQuantity.Instance.ID.ToString(), HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.KiloPound).ID.ToString());
                    Choices.Add(PoreSurfaceQuantity.Instance.ID.ToString(), PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometer).ID.ToString());
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID.ToString(), RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.FootPerHour).ID.ToString());
                    Choices.Add(WeightOnBitQuantity.Instance.ID.ToString(), WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.KiloPound).ID.ToString());
                }
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.Imperial)
                {
                    IsDefault = true;
                    ID = new Guid("67e6faf9-8d2f-4071-badb-f8d1355017a4");
                    Name = "Imperial";
                    Description = "United Kingdom System of Units";

                    Choices.Add(BlockVelocityQuantity.Instance.ID.ToString(), BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(CableDiameterQuantity.Instance.ID.ToString(), CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(CapillaryPressureQuantity.Instance.ID.ToString(), CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(DepthQuantity.Instance.ID.ToString(), DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(DrillingAccelerationQuantity.Instance.ID.ToString(), DrillingAccelerationQuantity.Instance.GetUnitChoice(DrillingAccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare).ID.ToString());
                    Choices.Add(DrillingAngleVariationGradientQuantity.Instance.ID.ToString(), DrillingAngleVariationGradientQuantity.Instance.GetUnitChoice(DrillingAngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID.ToString());
                    Choices.Add(DrillingAngularVelocityQuantity.Instance.ID.ToString(), DrillingAngularVelocityQuantity.Instance.GetUnitChoice(DrillingAngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(DrillingAreaQuantity.Instance.ID.ToString(), DrillingAreaQuantity.Instance.GetUnitChoice(DrillingAreaQuantity.UnitChoicesEnum.SquareFoot).ID.ToString());
                    Choices.Add(DrillingCompressibilityQuantity.Instance.ID.ToString(), DrillingCompressibilityQuantity.Instance.GetUnitChoice(DrillingCompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID.ToString());
                    Choices.Add(DrillingCurvatureQuantity.Instance.ID.ToString(), DrillingCurvatureQuantity.Instance.GetUnitChoice(DrillingCurvatureQuantity.UnitChoicesEnum.DegreePer100ft).ID.ToString());
                    Choices.Add(DrillingDensityGradientDepthQuantity.Instance.ID.ToString(), DrillingDensityGradientDepthQuantity.Instance.GetUnitChoice(DrillingDensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer100Foot).ID.ToString());
                    Choices.Add(DrillingDensityGradientTemperatureQuantity.Instance.ID.ToString(), DrillingDensityGradientTemperatureQuantity.Instance.GetUnitChoice(DrillingDensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit).ID.ToString());
                    Choices.Add(DrillingDensityQuantity.Instance.ID.ToString(), DrillingDensityQuantity.Instance.GetUnitChoice(DrillingDensityQuantity.UnitChoicesEnum.PoundPerGallonUK).ID.ToString());
                    Choices.Add(DrillingDensityRateOfChangeQuantity.Instance.ID.ToString(), DrillingDensityRateOfChangeQuantity.Instance.GetUnitChoice(DrillingDensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUKPerHour).ID.ToString());
                    Choices.Add(DrillingDurationQuantity.Instance.ID.ToString(), DrillingDurationQuantity.Instance.GetUnitChoice(DrillingDurationQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(DrillingDynamicViscosityQuantity.Instance.ID.ToString(), DrillingDynamicViscosityQuantity.Instance.GetUnitChoice(DrillingDynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(DrillingElongationGradientQuantity.Instance.ID.ToString(), DrillingElongationGradientQuantity.Instance.GetUnitChoice(DrillingElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID.ToString()); ;
                    Choices.Add(DrillingFluidVelocityQuantity.Instance.ID.ToString(), DrillingFluidVelocityQuantity.Instance.GetUnitChoice(DrillingFluidVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(DrillingForceGradientQuantity.Instance.ID.ToString(), DrillingForceGradientQuantity.Instance.GetUnitChoice(DrillingForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID.ToString());
                    Choices.Add(DrillingForceQuantity.Instance.ID.ToString(), DrillingForceQuantity.Instance.GetUnitChoice(DrillingForceQuantity.UnitChoicesEnum.PoundForce).ID.ToString());
                    Choices.Add(DrillingHeatTransferCoefficientQuantity.Instance.ID.ToString(), DrillingHeatTransferCoefficientQuantity.Instance.GetUnitChoice(DrillingHeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID.ToString());
                    Choices.Add(DrillingHydraulicConductivityQuantity.Instance.ID.ToString(), DrillingHydraulicConductivityQuantity.Instance.GetUnitChoice(DrillingHydraulicConductivityQuantity.UnitChoicesEnum.InchPerSecond).ID.ToString());
                    Choices.Add(DrillingInterfacialTensionQuantity.Instance.ID.ToString(), DrillingInterfacialTensionQuantity.Instance.GetUnitChoice(DrillingInterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID.ToString());
                    Choices.Add(DrillingMassQuantity.Instance.ID.ToString(), DrillingMassQuantity.Instance.GetUnitChoice(DrillingMassQuantity.UnitChoicesEnum.Pound).ID.ToString());
                    Choices.Add(DrillingMassGradientQuantity.Instance.ID.ToString(), DrillingMassGradientQuantity.Instance.GetUnitChoice(DrillingMassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID.ToString());
                    Choices.Add(DrillingMassRateQuantity.Instance.ID.ToString(), DrillingMassRateQuantity.Instance.GetUnitChoice(DrillingMassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(DrillingPlaneAngleQuantity.Instance.ID.ToString(), DrillingPlaneAngleQuantity.Instance.GetUnitChoice(DrillingPlaneAngleQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(DrillingPressureGradientQuantity.Instance.ID.ToString(), DrillingPressureGradientQuantity.Instance.GetUnitChoice(DrillingPressureGradientQuantity.UnitChoicesEnum.PSIPerFoot).ID.ToString());
                    Choices.Add(DrillingPressureQuantity.Instance.ID.ToString(), DrillingPressureQuantity.Instance.GetUnitChoice(DrillingPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(DrillingPressureLossConstantQuantity.Instance.ID.ToString(), DrillingPressureLossConstantQuantity.Instance.GetUnitChoice(DrillingPressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUK).ID.ToString());
                    Choices.Add(DrillingRotationFrequencyRateOfChangeQuantity.Instance.ID.ToString(), DrillingRotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(DrillingRotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(DrillingSpecificHeatCapacityQuantity.Instance.ID.ToString(), DrillingSpecificHeatCapacityQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit).ID.ToString());
                    Choices.Add(DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.ID.ToString(), DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit).ID.ToString());
                    Choices.Add(DrillingTemperatureQuantity.Instance.ID.ToString(), DrillingTemperatureQuantity.Instance.GetUnitChoice(DrillingTemperatureQuantity.UnitChoicesEnum.Fahrenheit).ID.ToString());
                    Choices.Add(DrillingTemperatureGradientQuantity.Instance.ID.ToString(), DrillingTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingTemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Foot).ID.ToString());
                    Choices.Add(DrillingTensionQuantity.Instance.ID.ToString(), DrillingTensionQuantity.Instance.GetUnitChoice(DrillingTensionQuantity.UnitChoicesEnum.KiloPoundForce).ID.ToString());
                    Choices.Add(DrillingThermalConductivityQuantity.Instance.ID.ToString(), DrillingThermalConductivityQuantity.Instance.GetUnitChoice(DrillingThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit).ID.ToString());
                    Choices.Add(DrillingThermalConductivityTemperatureGradientQuantity.Instance.ID.ToString(), DrillingThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit).ID.ToString());
                    Choices.Add(DrillingTorqueQuantity.Instance.ID.ToString(), DrillingTorqueQuantity.Instance.GetUnitChoice(DrillingTorqueQuantity.UnitChoicesEnum.FootPound).ID.ToString());
                    Choices.Add(DrillingVolumeQuantity.Instance.ID.ToString(), DrillingVolumeQuantity.Instance.GetUnitChoice(DrillingVolumeQuantity.UnitChoicesEnum.UKGallon).ID.ToString());
                    Choices.Add(DrillingVolumetricFlowRateOfChangeQuantity.Instance.ID.ToString(), DrillingVolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.UKGallonPerMinutePerSecond).ID.ToString());
                    Choices.Add(DrillingVolumetricFlowrateQuantity.Instance.ID.ToString(), DrillingVolumetricFlowrateQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowrateQuantity.UnitChoicesEnum.UKGallonPerMinute).ID.ToString());
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID.ToString(), DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(HeightQuantity.Instance.ID.ToString(), HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(NozzleDiameterQuantity.Instance.ID.ToString(), NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(PipeDiameterQuantity.Instance.ID.ToString(), PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID.ToString());
                    Choices.Add(PositionQuantity.Instance.ID.ToString(), PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(PoreDiameterQuantity.Instance.ID.ToString(), PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(FormationStrengthQuantity.Instance.ID.ToString(), FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(FormationResistivityQuantity.Instance.ID.ToString(), FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMeter).ID.ToString());
                    Choices.Add(GammaRayQuantity.Instance.ID.ToString(), GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID.ToString());
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID.ToString(), GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerMinute).ID.ToString());
                    Choices.Add(GasShowQuantity.Instance.ID.ToString(), GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(HookLoadQuantity.Instance.ID.ToString(), HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.KiloPound).ID.ToString());
                    Choices.Add(PoreSurfaceQuantity.Instance.ID.ToString(), PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometer).ID.ToString());
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID.ToString(), RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.FootPerHour).ID.ToString());
                    Choices.Add(WeightOnBitQuantity.Instance.ID.ToString(), WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.KiloPound).ID.ToString());
                }
                CheckMissing(quantities);
            }
        }


        public static new UnitChoiceSet Get(Guid ID)
        {
            if (unitChoiceSets_ == null)
            {
                Initialize();
            }
            DrillingUnitChoiceSet result;
            unitChoiceSets_.TryGetValue(ID, out result);
            if (result == null)
            {
                return UnitChoiceSet.Get(ID);
            }
            else
            {
                return result;
            }
        }

        public static new DrillingUnitChoiceSet CreateNew()
        {
            if (unitChoiceSets_ == null)
            {
                Initialize();
            }
            DrillingUnitChoiceSet unitChoiceSet = new DrillingUnitChoiceSet();
            unitChoiceSet.ID = Guid.NewGuid();
            unitChoiceSets_.Add(unitChoiceSet.ID, unitChoiceSet);
            return unitChoiceSet;
        }

        public static new DrillingUnitChoiceSet CreateNew(Guid guid)
        {
            if (unitChoiceSets_ == null)
            {
                Initialize();
            }
            if (unitChoiceSets_.ContainsKey(guid))
            {
                DrillingUnitChoiceSet result;
                unitChoiceSets_.TryGetValue(guid, out result);
                return result;
            }
            else
            {
                DrillingUnitChoiceSet unitChoiceSet = new DrillingUnitChoiceSet();
                unitChoiceSet.ID = guid;
                unitChoiceSets_.Add(unitChoiceSet.ID, unitChoiceSet);
                return unitChoiceSet;
            }
        }

        /// <summary>
        /// Adds the given DrillingUnitChoiceSet to the static Dictionary of available DrillingUnitChoiceSet
        /// </summary>
        /// <param name="drillingUnitChoiceSet"></param>
        /// <returns>Returns true is effectively added to the static Dictionary, false otherwise</returns>
        public static bool Add(DrillingUnitChoiceSet drillingUnitChoiceSet)
        {
            if (unitChoiceSets_ == null)
            {
                Initialize();
            }
            if (!unitChoiceSets_.ContainsKey(drillingUnitChoiceSet.ID))
            {
                unitChoiceSets_.Add(drillingUnitChoiceSet.ID, drillingUnitChoiceSet);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Updates the given DrillingUnitChoiceSet in the static Dictionary of available DrillingUnitChoiceSet
        /// </summary>
        /// <param name="drillingUnitChoiceSet"></param>
        /// <returns>Returns true is effectively updated in the static Dictionary, false otherwise</returns>
        public static bool Update(DrillingUnitChoiceSet drillingUnitChoiceSet)
        {
            if (unitChoiceSets_ == null)
            {
                Initialize();
            }
            if (unitChoiceSets_.ContainsKey(drillingUnitChoiceSet.ID))
            {
                unitChoiceSets_[drillingUnitChoiceSet.ID] = drillingUnitChoiceSet;
                return true;
            }
            return false;
        }

        private static void Initialize()
        {
            if (unitChoiceSets_ == null)
            {
                unitChoiceSets_ = new Dictionary<Guid, DrillingUnitChoiceSet>();
                DrillingUnitChoiceSet SI = DrillingSIUnitChoiceSet;
                unitChoiceSets_.Add(SI.ID, SI);
                DrillingUnitChoiceSet metric = DrillingMetricUnitChoiceSet;
                unitChoiceSets_.Add(metric.ID, metric);
                DrillingUnitChoiceSet US = DrillingUSUnitChoiceSet;
                unitChoiceSets_.Add(US.ID, US);
                DrillingUnitChoiceSet imperial = DrillingImperialUnitChoiceSet;
                unitChoiceSets_.Add(imperial.ID, imperial);
            }
        }

        public static DrillingUnitChoiceSet DrillingSIUnitChoiceSet
        {
            get
            {
                if (SIUnitChoiceSet_ == null)
                {
                    SIUnitChoiceSet_ = new DrillingUnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.SI);
                }
                return SIUnitChoiceSet_;
            }
        }

        public static DrillingUnitChoiceSet DrillingMetricUnitChoiceSet
        {
            get
            {
                if (MetricUnitChoiceSet_ == null)
                {
                    MetricUnitChoiceSet_ = new DrillingUnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.Metric);
                }
                return MetricUnitChoiceSet_;
            }
        }

        public static DrillingUnitChoiceSet DrillingImperialUnitChoiceSet
        {
            get
            {
                if (ImperialUnitChoiceSet_ == null)
                {
                    ImperialUnitChoiceSet_ = new DrillingUnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.Imperial);
                }
                return ImperialUnitChoiceSet_;
            }
        }
        public static DrillingUnitChoiceSet DrillingUSUnitChoiceSet
        {
            get
            {
                if (USUnitChoiceSet_ == null)
                {
                    USUnitChoiceSet_ = new DrillingUnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.US);
                }
                return USUnitChoiceSet_;
            }
        }

        protected PhysicalQuantity GetQuantity(DrillingPhysicalQuantity.QuantityEnum quantityChoice)
        {
            return DrillingPhysicalQuantity.GetQuantity(quantityChoice);
        }

        protected override PhysicalQuantity GetQuantity(Guid quantityID)
        {
            PhysicalQuantity quantity = DrillingPhysicalQuantity.GetQuantity(quantityID);
            if (quantity == null)
            {
                quantity = base.GetQuantity(quantityID);
            }
            return quantity;
        }

        protected override PhysicalQuantity GetQuantity(string quantityName)
        {
            PhysicalQuantity quantity = DrillingPhysicalQuantity.GetQuantity(quantityName);
            if (quantity == null)
            {
                quantity = base.GetQuantity(quantityName);
            }
            return quantity;
        }


        public static new List<PhysicalQuantity> AvailableQuantities
        {
            get
            {
                if (availableQuantities_ == null)
                {
                    Assembly assembly = Assembly.GetAssembly(typeof(DrillingUnitChoiceSet));
                    if (assembly != null)
                    {
                        foreach (Type typ in assembly.GetTypes())
                        {
                            if (typ.IsSubclassOf(typeof(PhysicalQuantity)))
                            {
                                MethodInfo method = null;
                                foreach (MethodInfo meth in typ.GetMethods())
                                {
                                    if (meth.IsStatic &&
                                        meth.Name.EndsWith("Instance") &&
                                        meth.ReturnType.IsSubclassOf(typeof(PhysicalQuantity)))
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
                                        var res = (PhysicalQuantity)obj;
                                        if (availableQuantities_ == null)
                                        {
                                            availableQuantities_ = new List<PhysicalQuantity>();
                                        }
                                        availableQuantities_.Add(res);
                                    }
                                }
                            }
                        }
                    }
                }
                return availableQuantities_;
            }
        }

        public UnitChoice GetChoice(DrillingPhysicalQuantity.QuantityEnum physicalQuantityID)
        {
            UnitChoice choice = null;
            string unitChoiceID;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityID);
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

        public double? FromSI(DrillingPhysicalQuantity.QuantityEnum physicalQuantityID, double val)
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
        public string FromSIString(DrillingPhysicalQuantity.QuantityEnum physicalQuantityID, double val)
        {
            double? meaningfulPrecision = null;
            PhysicalQuantity quantity = DrillingPhysicalQuantity.GetQuantity(physicalQuantityID);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="physicalQuantityID"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public double? ToSI(DrillingPhysicalQuantity.QuantityEnum physicalQuantityID, double val)
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

        public string GetUnitLabel(DrillingPhysicalQuantity.QuantityEnum physicalQuantityID)
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
    }
}
