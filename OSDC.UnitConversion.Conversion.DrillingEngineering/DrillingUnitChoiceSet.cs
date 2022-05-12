using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using OSDC.UnitConversion.Conversion;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public class DrillingUnitChoiceSet : UnitChoiceSet
    {
        private static List<PhysicalQuantity> availableQuantities_ = null;

        private static DrillingUnitChoiceSet SIUnitChoiceSet_ = null;
        private static DrillingUnitChoiceSet MetricUnitChoiceSet_ = null;
        private static DrillingUnitChoiceSet ImperialUnitChoiceSet_ = null;
        private static DrillingUnitChoiceSet USUnitChoiceSet_ = null;

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

        /// <summary>
        /// default constructor
        /// </summary>
        public DrillingUnitChoiceSet() : base()
        {

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
            Guid unitChoiceID;
            PhysicalQuantity quantity = DrillingPhysicalQuantity.GetQuantity(physicalQuantityID);
            if (quantity != null && Choices.TryGetValue(quantity.ID, out unitChoiceID))
            {
                if (unitChoiceID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(unitChoiceID);
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

        public string GetUnitSymbol(DrillingPhysicalQuantity.QuantityEnum physicalQuantityID)
        {
            UnitChoice choice = GetChoice(physicalQuantityID);
            if (choice != null)
            {
                return choice.UnitSymbol;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultUnitChoice"></param>
        protected DrillingUnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum defaultUnitChoice) : base(defaultUnitChoice)
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
                                if (!Choices.ContainsKey(quantity.ID))
                                {
                                    Choices.Add(quantity.ID, unitChoiceID);
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
                    Choices.Add(BlockVelocityQuantity.Instance.ID, BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.MeterPerSecond).ID);
                    Choices.Add(CableDiameterQuantity.Instance.ID, CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID);
                    Choices.Add(CapillaryPressureQuantity.Instance.ID, CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.Bar).ID);
                    Choices.Add(DepthQuantity.Instance.ID, DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Metre).ID);
                    Choices.Add(DrillingAccelerationQuantity.Instance.ID, DrillingAccelerationQuantity.Instance.GetUnitChoice(DrillingAccelerationQuantity.UnitChoicesEnum.MeterPerSecondSquare).ID);
                    Choices.Add(DrillingAngleVariationGradientQuantity.Instance.ID, DrillingAngleVariationGradientQuantity.Instance.GetUnitChoice(DrillingAngleVariationGradientQuantity.UnitChoicesEnum.DegreePerMeter).ID);
                    Choices.Add(DrillingAngularVelocityQuantity.Instance.ID, DrillingAngularVelocityQuantity.Instance.GetUnitChoice(DrillingAngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID);
                    Choices.Add(DrillingAreaQuantity.Instance.ID, DrillingAreaQuantity.Instance.GetUnitChoice(DrillingAreaQuantity.UnitChoicesEnum.SquareMeter).ID);
                    Choices.Add(DrillingCompressibilityQuantity.Instance.ID, DrillingCompressibilityQuantity.Instance.GetUnitChoice(DrillingCompressibilityQuantity.UnitChoicesEnum.InverseBar).ID);
                    Choices.Add(DrillingCurvatureQuantity.Instance.ID, DrillingCurvatureQuantity.Instance.GetUnitChoice(DrillingCurvatureQuantity.UnitChoicesEnum.DegreePer30m).ID);
                    Choices.Add(DrillingDensityGradientDepthQuantity.Instance.ID, DrillingDensityGradientDepthQuantity.Instance.GetUnitChoice(DrillingDensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPerMeter).ID);
                    Choices.Add(DrillingDensityGradientTemperatureQuantity.Instance.ID, DrillingDensityGradientTemperatureQuantity.Instance.GetUnitChoice(DrillingDensityGradientTemperatureQuantity.UnitChoicesEnum.SpecificGravityPerCelsius).ID);
                    Choices.Add(DrillingDensityQuantity.Instance.ID, DrillingDensityQuantity.Instance.GetUnitChoice(DrillingDensityQuantity.UnitChoicesEnum.SpecificGravity).ID);
                    Choices.Add(DrillingDensitySpeedQuantity.Instance.ID, DrillingDensitySpeedQuantity.Instance.GetUnitChoice(DrillingDensitySpeedQuantity.UnitChoicesEnum.SpecificGravityPerSecond).ID);
                    Choices.Add(DrillingDurationQuantity.Instance.ID, DrillingDurationQuantity.Instance.GetUnitChoice(DrillingDurationQuantity.UnitChoicesEnum.Second).ID);
                    Choices.Add(DrillingDynamicViscosityQuantity.Instance.ID, DrillingDynamicViscosityQuantity.Instance.GetUnitChoice(DrillingDynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID);
                    Choices.Add(DrillingElongationGradientQuantity.Instance.ID, DrillingElongationGradientQuantity.Instance.GetUnitChoice(DrillingElongationGradientQuantity.UnitChoicesEnum.MillimeterPerMeter).ID); ;
                    Choices.Add(DrillingFluidVelocityQuantity.Instance.ID, DrillingFluidVelocityQuantity.Instance.GetUnitChoice(DrillingFluidVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(DrillingForceGradientQuantity.Instance.ID, DrillingForceGradientQuantity.Instance.GetUnitChoice(DrillingForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID);
                    Choices.Add(DrillingForceQuantity.Instance.ID, DrillingForceQuantity.Instance.GetUnitChoice(DrillingForceQuantity.UnitChoicesEnum.DecaNewton).ID);
                    Choices.Add(DrillingHeatTransferCoefficientQuantity.Instance.ID, DrillingHeatTransferCoefficientQuantity.Instance.GetUnitChoice(DrillingHeatTransferCoefficientQuantity.UnitChoicesEnum.WattPerMeterSquaredPerKelvin).ID);
                    Choices.Add(DrillingHydraulicConductivityQuantity.Instance.ID, DrillingHydraulicConductivityQuantity.Instance.GetUnitChoice(DrillingHydraulicConductivityQuantity.UnitChoicesEnum.CentimeterPerSecond).ID);
                    Choices.Add(DrillingInterfacialTensionQuantity.Instance.ID, DrillingInterfacialTensionQuantity.Instance.GetUnitChoice(DrillingInterfacialTensionQuantity.UnitChoicesEnum.NewtonPerMeter).ID);
                    Choices.Add(DrillingMassQuantity.Instance.ID, DrillingMassQuantity.Instance.GetUnitChoice(DrillingMassQuantity.UnitChoicesEnum.Kilogram).ID);
                    Choices.Add(DrillingMassGradientQuantity.Instance.ID, DrillingMassGradientQuantity.Instance.GetUnitChoice(DrillingMassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID);
                    Choices.Add(DrillingMassRateQuantity.Instance.ID, DrillingMassRateQuantity.Instance.GetUnitChoice(DrillingMassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID);
                    Choices.Add(DrillingPlaneAngleQuantity.Instance.ID, DrillingPlaneAngleQuantity.Instance.GetUnitChoice(DrillingPlaneAngleQuantity.UnitChoicesEnum.Degree).ID);
                    Choices.Add(DrillingPressureGradientQuantity.Instance.ID, DrillingPressureGradientQuantity.Instance.GetUnitChoice(DrillingPressureGradientQuantity.UnitChoicesEnum.BarPerMeter).ID);
                    Choices.Add(DrillingPressureQuantity.Instance.ID, DrillingPressureQuantity.Instance.GetUnitChoice(DrillingPressureQuantity.UnitChoicesEnum.Bar).ID);
                    Choices.Add(DrillingPressureLossConstantQuantity.Instance.ID, DrillingPressureLossConstantQuantity.Instance.GetUnitChoice(DrillingPressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantMetric).ID);
                    Choices.Add(DrillingRotationFrequencyRateOfChangeQuantity.Instance.ID, DrillingRotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(DrillingRotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID);
                    Choices.Add(DrillingSpecificHeatCapacityQuantity.Instance.ID, DrillingSpecificHeatCapacityQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerKilogramKelvin).ID);
                    Choices.Add(DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.ID, DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerKilogramKelvinPerKelvin).ID);
                    Choices.Add(DrillingTemperatureGradientQuantity.Instance.ID, DrillingTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingTemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Meter).ID);
                    Choices.Add(DrillingTensionQuantity.Instance.ID, DrillingTensionQuantity.Instance.GetUnitChoice(DrillingTensionQuantity.UnitChoicesEnum.KiloDecaNewton).ID);
                    Choices.Add(DrillingThermalConductivityQuantity.Instance.ID, DrillingThermalConductivityQuantity.Instance.GetUnitChoice(DrillingThermalConductivityQuantity.UnitChoicesEnum.WattPerMetreKelvin).ID);
                    Choices.Add(DrillingThermalConductivityTemperatureGradientQuantity.Instance.ID, DrillingThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.WattPerMetreKelvinPerKelvin).ID);
                    Choices.Add(DrillingTorqueQuantity.Instance.ID, DrillingTorqueQuantity.Instance.GetUnitChoice(DrillingTorqueQuantity.UnitChoicesEnum.MeterKiloNewton).ID);
                    Choices.Add(DrillingVolumeQuantity.Instance.ID, DrillingVolumeQuantity.Instance.GetUnitChoice(DrillingVolumeQuantity.UnitChoicesEnum.Liter).ID);
                    Choices.Add(DrillingVolumetricFlowRateOfChangeQuantity.Instance.ID, DrillingVolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.LiterPerMinutePerSecond).ID);
                    Choices.Add(DrillingVolumetricFlowrateQuantity.Instance.ID, DrillingVolumetricFlowrateQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowrateQuantity.UnitChoicesEnum.LiterPerMinute).ID);
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID, DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.MegaPascal).ID);
                    Choices.Add(HeightQuantity.Instance.ID, HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Metre).ID);
                    Choices.Add(NozzleDiameterQuantity.Instance.ID, NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID);
                    Choices.Add(PipeDiameterQuantity.Instance.ID, PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID);
                    Choices.Add(PoreDiameterQuantity.Instance.ID, PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Micrometer).ID);
                    Choices.Add(PositionQuantity.Instance.ID, PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Metre).ID);
                    Choices.Add(FormationStrengthQuantity.Instance.ID, FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.MegaPascal).ID);
                    Choices.Add(FormationResistivityQuantity.Instance.ID, FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMeter).ID);
                    Choices.Add(GammaRayQuantity.Instance.ID, GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID);
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID, GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerMinute).ID);
                    Choices.Add(GasShowQuantity.Instance.ID, GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(HookLoadQuantity.Instance.ID, HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.TonneMetric).ID);
                    Choices.Add(PoreSurfaceQuantity.Instance.ID, PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometer).ID);
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID, RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.MeterPerHour).ID);
                    Choices.Add(WeightOnBitQuantity.Instance.ID, WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.TonneMetric).ID);
                }
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.US)
                {
                    Choices.Add(BlockVelocityQuantity.Instance.ID, BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(CableDiameterQuantity.Instance.ID, CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID);
                    Choices.Add(CapillaryPressureQuantity.Instance.ID, CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID);
                    Choices.Add(DepthQuantity.Instance.ID, DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Feet).ID);
                    Choices.Add(DrillingAccelerationQuantity.Instance.ID, DrillingAccelerationQuantity.Instance.GetUnitChoice(DrillingAccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare).ID);
                    Choices.Add(DrillingAngleVariationGradientQuantity.Instance.ID, DrillingAngleVariationGradientQuantity.Instance.GetUnitChoice(DrillingAngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID);
                    Choices.Add(DrillingAngularVelocityQuantity.Instance.ID, DrillingAngularVelocityQuantity.Instance.GetUnitChoice(DrillingAngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID);
                    Choices.Add(DrillingAreaQuantity.Instance.ID, DrillingAreaQuantity.Instance.GetUnitChoice(DrillingAreaQuantity.UnitChoicesEnum.SquareFoot).ID);
                    Choices.Add(DrillingCompressibilityQuantity.Instance.ID, DrillingCompressibilityQuantity.Instance.GetUnitChoice(DrillingCompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID);
                    Choices.Add(DrillingCurvatureQuantity.Instance.ID, DrillingCurvatureQuantity.Instance.GetUnitChoice(DrillingCurvatureQuantity.UnitChoicesEnum.DegreePer100ft).ID);
                    Choices.Add(DrillingDensityGradientDepthQuantity.Instance.ID, DrillingDensityGradientDepthQuantity.Instance.GetUnitChoice(DrillingDensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer100Foot).ID);
                    Choices.Add(DrillingDensityGradientTemperatureQuantity.Instance.ID, DrillingDensityGradientTemperatureQuantity.Instance.GetUnitChoice(DrillingDensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit).ID);
                    Choices.Add(DrillingDensityQuantity.Instance.ID, DrillingDensityQuantity.Instance.GetUnitChoice(DrillingDensityQuantity.UnitChoicesEnum.PoundPerGallonUS).ID);
                    Choices.Add(DrillingDensitySpeedQuantity.Instance.ID, DrillingDensitySpeedQuantity.Instance.GetUnitChoice(DrillingDensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUSPerHour).ID);
                    Choices.Add(DrillingDurationQuantity.Instance.ID, DrillingDurationQuantity.Instance.GetUnitChoice(DrillingDurationQuantity.UnitChoicesEnum.Second).ID);
                    Choices.Add(DrillingDynamicViscosityQuantity.Instance.ID, DrillingDynamicViscosityQuantity.Instance.GetUnitChoice(DrillingDynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID);
                    Choices.Add(DrillingElongationGradientQuantity.Instance.ID, DrillingElongationGradientQuantity.Instance.GetUnitChoice(DrillingElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID); ;
                    Choices.Add(DrillingFluidVelocityQuantity.Instance.ID, DrillingFluidVelocityQuantity.Instance.GetUnitChoice(DrillingFluidVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(DrillingForceGradientQuantity.Instance.ID, DrillingForceGradientQuantity.Instance.GetUnitChoice(DrillingForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID);
                    Choices.Add(DrillingForceQuantity.Instance.ID, DrillingForceQuantity.Instance.GetUnitChoice(DrillingForceQuantity.UnitChoicesEnum.PoundForce).ID);
                    Choices.Add(DrillingHeatTransferCoefficientQuantity.Instance.ID, DrillingHeatTransferCoefficientQuantity.Instance.GetUnitChoice(DrillingHeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID);
                    Choices.Add(DrillingHydraulicConductivityQuantity.Instance.ID, DrillingHydraulicConductivityQuantity.Instance.GetUnitChoice(DrillingHydraulicConductivityQuantity.UnitChoicesEnum.InchPerSecond).ID);
                    Choices.Add(DrillingInterfacialTensionQuantity.Instance.ID, DrillingInterfacialTensionQuantity.Instance.GetUnitChoice(DrillingInterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID);
                    Choices.Add(DrillingMassQuantity.Instance.ID, DrillingMassQuantity.Instance.GetUnitChoice(DrillingMassQuantity.UnitChoicesEnum.Pound).ID);
                    Choices.Add(DrillingMassGradientQuantity.Instance.ID, DrillingMassGradientQuantity.Instance.GetUnitChoice(DrillingMassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID);
                    Choices.Add(DrillingMassRateQuantity.Instance.ID, DrillingMassRateQuantity.Instance.GetUnitChoice(DrillingMassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID);
                    Choices.Add(DrillingPlaneAngleQuantity.Instance.ID, DrillingPlaneAngleQuantity.Instance.GetUnitChoice(DrillingPlaneAngleQuantity.UnitChoicesEnum.Degree).ID);
                    Choices.Add(DrillingPressureGradientQuantity.Instance.ID, DrillingPressureGradientQuantity.Instance.GetUnitChoice(DrillingPressureGradientQuantity.UnitChoicesEnum.PSIPerFoot).ID);
                    Choices.Add(DrillingPressureQuantity.Instance.ID, DrillingPressureQuantity.Instance.GetUnitChoice(DrillingPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID);
                    Choices.Add(DrillingPressureLossConstantQuantity.Instance.ID, DrillingPressureLossConstantQuantity.Instance.GetUnitChoice(DrillingPressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUS).ID);
                    Choices.Add(DrillingRotationFrequencyRateOfChangeQuantity.Instance.ID, DrillingRotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(DrillingRotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID);
                    Choices.Add(DrillingSpecificHeatCapacityQuantity.Instance.ID, DrillingSpecificHeatCapacityQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit).ID);
                    Choices.Add(DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.ID, DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit).ID);
                    Choices.Add(DrillingTemperatureGradientQuantity.Instance.ID, DrillingTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingTemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot).ID);
                    Choices.Add(DrillingTensionQuantity.Instance.ID, DrillingTensionQuantity.Instance.GetUnitChoice(DrillingTensionQuantity.UnitChoicesEnum.KiloPoundForce).ID);
                    Choices.Add(DrillingThermalConductivityQuantity.Instance.ID, DrillingThermalConductivityQuantity.Instance.GetUnitChoice(DrillingThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit).ID);
                    Choices.Add(DrillingThermalConductivityTemperatureGradientQuantity.Instance.ID, DrillingThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit).ID);
                    Choices.Add(DrillingTorqueQuantity.Instance.ID, DrillingTorqueQuantity.Instance.GetUnitChoice(DrillingTorqueQuantity.UnitChoicesEnum.FootPound).ID);
                    Choices.Add(DrillingVolumeQuantity.Instance.ID, DrillingVolumeQuantity.Instance.GetUnitChoice(DrillingVolumeQuantity.UnitChoicesEnum.USGallon).ID);
                    Choices.Add(DrillingVolumetricFlowRateOfChangeQuantity.Instance.ID, DrillingVolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.USGallonPerMinutePerSecond).ID);
                    Choices.Add(DrillingVolumetricFlowrateQuantity.Instance.ID, DrillingVolumetricFlowrateQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowrateQuantity.UnitChoicesEnum.USGallonPerMinute).ID);
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID, DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.PSI).ID);
                    Choices.Add(NozzleDiameterQuantity.Instance.ID, NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID);
                    Choices.Add(PipeDiameterQuantity.Instance.ID, PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID);
                    Choices.Add(PositionQuantity.Instance.ID, PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Feet).ID);
                    Choices.Add(PoreDiameterQuantity.Instance.ID, PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Inch_32).ID);
                    Choices.Add(FormationStrengthQuantity.Instance.ID, FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.PSI).ID);
                    Choices.Add(FormationResistivityQuantity.Instance.ID, FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMeter).ID);
                    Choices.Add(GammaRayQuantity.Instance.ID, GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID);
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID, GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerMinute).ID);
                    Choices.Add(GasShowQuantity.Instance.ID, GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(HeightQuantity.Instance.ID, HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Feet).ID);
                    Choices.Add(HookLoadQuantity.Instance.ID, HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.KiloPound).ID);
                    Choices.Add(PoreSurfaceQuantity.Instance.ID, PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometer).ID);
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID, RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.FootPerHour).ID);
                    Choices.Add(WeightOnBitQuantity.Instance.ID, WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.KiloPound).ID);
                }
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.Imperial)
                {
                    Choices.Add(BlockVelocityQuantity.Instance.ID, BlockVelocityQuantity.Instance.GetUnitChoice(BlockVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(CableDiameterQuantity.Instance.ID, CableDiameterQuantity.Instance.GetUnitChoice(CableDiameterQuantity.UnitChoicesEnum.Inch).ID);
                    Choices.Add(CapillaryPressureQuantity.Instance.ID, CapillaryPressureQuantity.Instance.GetUnitChoice(CapillaryPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID);
                    Choices.Add(DepthQuantity.Instance.ID, DepthQuantity.Instance.GetUnitChoice(DepthQuantity.UnitChoicesEnum.Feet).ID);
                    Choices.Add(DrillingAccelerationQuantity.Instance.ID, DrillingAccelerationQuantity.Instance.GetUnitChoice(DrillingAccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare).ID);
                    Choices.Add(DrillingAngleVariationGradientQuantity.Instance.ID, DrillingAngleVariationGradientQuantity.Instance.GetUnitChoice(DrillingAngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID);
                    Choices.Add(DrillingAngularVelocityQuantity.Instance.ID, DrillingAngularVelocityQuantity.Instance.GetUnitChoice(DrillingAngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID);
                    Choices.Add(DrillingAreaQuantity.Instance.ID, DrillingAreaQuantity.Instance.GetUnitChoice(DrillingAreaQuantity.UnitChoicesEnum.SquareFoot).ID);
                    Choices.Add(DrillingCompressibilityQuantity.Instance.ID, DrillingCompressibilityQuantity.Instance.GetUnitChoice(DrillingCompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID);
                    Choices.Add(DrillingCurvatureQuantity.Instance.ID, DrillingCurvatureQuantity.Instance.GetUnitChoice(DrillingCurvatureQuantity.UnitChoicesEnum.DegreePer100ft).ID);
                    Choices.Add(DrillingDensityGradientDepthQuantity.Instance.ID, DrillingDensityGradientDepthQuantity.Instance.GetUnitChoice(DrillingDensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer100Foot).ID);
                    Choices.Add(DrillingDensityGradientTemperatureQuantity.Instance.ID, DrillingDensityGradientTemperatureQuantity.Instance.GetUnitChoice(DrillingDensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit).ID);
                    Choices.Add(DrillingDensityQuantity.Instance.ID, DrillingDensityQuantity.Instance.GetUnitChoice(DrillingDensityQuantity.UnitChoicesEnum.PoundPerGallonUK).ID);
                    Choices.Add(DrillingDensitySpeedQuantity.Instance.ID, DrillingDensitySpeedQuantity.Instance.GetUnitChoice(DrillingDensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUKPerHour).ID);
                    Choices.Add(DrillingDurationQuantity.Instance.ID, DrillingDurationQuantity.Instance.GetUnitChoice(DrillingDurationQuantity.UnitChoicesEnum.Second).ID);
                    Choices.Add(DrillingDynamicViscosityQuantity.Instance.ID, DrillingDynamicViscosityQuantity.Instance.GetUnitChoice(DrillingDynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID);
                    Choices.Add(DrillingElongationGradientQuantity.Instance.ID, DrillingElongationGradientQuantity.Instance.GetUnitChoice(DrillingElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID); ;
                    Choices.Add(DrillingFluidVelocityQuantity.Instance.ID, DrillingFluidVelocityQuantity.Instance.GetUnitChoice(DrillingFluidVelocityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(DrillingForceGradientQuantity.Instance.ID, DrillingForceGradientQuantity.Instance.GetUnitChoice(DrillingForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID);
                    Choices.Add(DrillingForceQuantity.Instance.ID, DrillingForceQuantity.Instance.GetUnitChoice(DrillingForceQuantity.UnitChoicesEnum.PoundForce).ID);
                    Choices.Add(DrillingHeatTransferCoefficientQuantity.Instance.ID, DrillingHeatTransferCoefficientQuantity.Instance.GetUnitChoice(DrillingHeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID);
                    Choices.Add(DrillingHydraulicConductivityQuantity.Instance.ID, DrillingHydraulicConductivityQuantity.Instance.GetUnitChoice(DrillingHydraulicConductivityQuantity.UnitChoicesEnum.InchPerSecond).ID);
                    Choices.Add(DrillingInterfacialTensionQuantity.Instance.ID, DrillingInterfacialTensionQuantity.Instance.GetUnitChoice(DrillingInterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID);
                    Choices.Add(DrillingMassQuantity.Instance.ID, DrillingMassQuantity.Instance.GetUnitChoice(DrillingMassQuantity.UnitChoicesEnum.Pound).ID);
                    Choices.Add(DrillingMassGradientQuantity.Instance.ID, DrillingMassGradientQuantity.Instance.GetUnitChoice(DrillingMassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID);
                    Choices.Add(DrillingMassRateQuantity.Instance.ID, DrillingMassRateQuantity.Instance.GetUnitChoice(DrillingMassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID);
                    Choices.Add(DrillingPlaneAngleQuantity.Instance.ID, DrillingPlaneAngleQuantity.Instance.GetUnitChoice(DrillingPlaneAngleQuantity.UnitChoicesEnum.Degree).ID);
                    Choices.Add(DrillingPressureGradientQuantity.Instance.ID, DrillingPressureGradientQuantity.Instance.GetUnitChoice(DrillingPressureGradientQuantity.UnitChoicesEnum.PSIPerFoot).ID);
                    Choices.Add(DrillingPressureQuantity.Instance.ID, DrillingPressureQuantity.Instance.GetUnitChoice(DrillingPressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID);
                    Choices.Add(DrillingPressureLossConstantQuantity.Instance.ID, DrillingPressureLossConstantQuantity.Instance.GetUnitChoice(DrillingPressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUK).ID);
                    Choices.Add(DrillingRotationFrequencyRateOfChangeQuantity.Instance.ID, DrillingRotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(DrillingRotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID);
                    Choices.Add(DrillingSpecificHeatCapacityQuantity.Instance.ID, DrillingSpecificHeatCapacityQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit).ID);
                    Choices.Add(DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.ID, DrillingSpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingSpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit).ID);
                    Choices.Add(DrillingTemperatureGradientQuantity.Instance.ID, DrillingTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingTemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Foot).ID);
                    Choices.Add(DrillingTensionQuantity.Instance.ID, DrillingTensionQuantity.Instance.GetUnitChoice(DrillingTensionQuantity.UnitChoicesEnum.KiloPoundForce).ID);
                    Choices.Add(DrillingThermalConductivityQuantity.Instance.ID, DrillingThermalConductivityQuantity.Instance.GetUnitChoice(DrillingThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit).ID);
                    Choices.Add(DrillingThermalConductivityTemperatureGradientQuantity.Instance.ID, DrillingThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(DrillingThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit).ID);
                    Choices.Add(DrillingTorqueQuantity.Instance.ID, DrillingTorqueQuantity.Instance.GetUnitChoice(DrillingTorqueQuantity.UnitChoicesEnum.FootPound).ID);
                    Choices.Add(DrillingVolumeQuantity.Instance.ID, DrillingVolumeQuantity.Instance.GetUnitChoice(DrillingVolumeQuantity.UnitChoicesEnum.UKGallon).ID);
                    Choices.Add(DrillingVolumetricFlowRateOfChangeQuantity.Instance.ID, DrillingVolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.UKGallonPerMinutePerSecond).ID);
                    Choices.Add(DrillingVolumetricFlowrateQuantity.Instance.ID, DrillingVolumetricFlowrateQuantity.Instance.GetUnitChoice(DrillingVolumetricFlowrateQuantity.UnitChoicesEnum.UKGallonPerMinute).ID);
                    Choices.Add(DrillStemMaterialStrengthQuantity.Instance.ID, DrillStemMaterialStrengthQuantity.Instance.GetUnitChoice(DrillStemMaterialStrengthQuantity.UnitChoicesEnum.PSI).ID);
                    Choices.Add(HeightQuantity.Instance.ID, HeightQuantity.Instance.GetUnitChoice(HeightQuantity.UnitChoicesEnum.Feet).ID);
                    Choices.Add(NozzleDiameterQuantity.Instance.ID, NozzleDiameterQuantity.Instance.GetUnitChoice(NozzleDiameterQuantity.UnitChoicesEnum.Inch_32).ID);
                    Choices.Add(PipeDiameterQuantity.Instance.ID, PipeDiameterQuantity.Instance.GetUnitChoice(PipeDiameterQuantity.UnitChoicesEnum.Inch).ID);
                    Choices.Add(PositionQuantity.Instance.ID, PositionQuantity.Instance.GetUnitChoice(PositionQuantity.UnitChoicesEnum.Feet).ID);
                    Choices.Add(PoreDiameterQuantity.Instance.ID, PoreDiameterQuantity.Instance.GetUnitChoice(PoreDiameterQuantity.UnitChoicesEnum.Inch_32).ID);
                    Choices.Add(FormationStrengthQuantity.Instance.ID, FormationStrengthQuantity.Instance.GetUnitChoice(FormationStrengthQuantity.UnitChoicesEnum.PSI).ID);
                    Choices.Add(FormationResistivityQuantity.Instance.ID, FormationResistivityQuantity.Instance.GetUnitChoice(FormationResistivityQuantity.UnitChoicesEnum.OhmMeter).ID);
                    Choices.Add(GammaRayQuantity.Instance.ID, GammaRayQuantity.Instance.GetUnitChoice(GammaRayQuantity.UnitChoicesEnum.GammaAPI).ID);
                    Choices.Add(GasVolumetricFlowRateQuantity.Instance.ID, GasVolumetricFlowRateQuantity.Instance.GetUnitChoice(GasVolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerMinute).ID);
                    Choices.Add(GasShowQuantity.Instance.ID, GasShowQuantity.Instance.GetUnitChoice(GasShowQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(HookLoadQuantity.Instance.ID, HookLoadQuantity.Instance.GetUnitChoice(HookLoadQuantity.UnitChoicesEnum.KiloPound).ID);
                    Choices.Add(PoreSurfaceQuantity.Instance.ID, PoreSurfaceQuantity.Instance.GetUnitChoice(PoreSurfaceQuantity.UnitChoicesEnum.SquareMicrometer).ID);
                    Choices.Add(RateOfPenetrationQuantity.Instance.ID, RateOfPenetrationQuantity.Instance.GetUnitChoice(RateOfPenetrationQuantity.UnitChoicesEnum.FootPerHour).ID);
                    Choices.Add(WeightOnBitQuantity.Instance.ID, WeightOnBitQuantity.Instance.GetUnitChoice(WeightOnBitQuantity.UnitChoicesEnum.KiloPound).ID);
                }   
                CheckMissing(quantities);
            }
        }

    }
}
