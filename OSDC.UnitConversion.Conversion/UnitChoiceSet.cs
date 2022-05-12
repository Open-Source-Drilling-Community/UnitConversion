using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public class UnitChoiceSet
    {
        private static List<PhysicalQuantity> availableQuantities_ = null;

        private static UnitChoiceSet SIUnitChoiceSet_ = null;
        private static UnitChoiceSet MetricUnitChoiceSet_ = null;
        private static UnitChoiceSet ImperialUnitChoiceSet_ = null;
        private static UnitChoiceSet USUnitChoiceSet_ = null;

        public static UnitChoiceSet SIUnitChoiceSet
        {
            get
            {
                if (SIUnitChoiceSet_ == null)
                {
                    SIUnitChoiceSet_ = new UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.SI);
                }
                return SIUnitChoiceSet_;
            }
        }

        public static UnitChoiceSet MetricUnitChoiceSet
        {
            get
            {
                if (MetricUnitChoiceSet_ == null)
                {
                    MetricUnitChoiceSet_ = new UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.Metric);
                }
                return MetricUnitChoiceSet_;
            }
        }

        public static UnitChoiceSet ImperialUnitChoiceSet
        {
            get
            {
                if (ImperialUnitChoiceSet_ == null)
                {
                    ImperialUnitChoiceSet_ = new UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.Imperial);
                }
                return ImperialUnitChoiceSet_;
            }
        }
        public static UnitChoiceSet USUnitChoiceSet
        {
            get
            {
                if (USUnitChoiceSet_ == null)
                {
                    USUnitChoiceSet_ = new UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.US);
                }
                return USUnitChoiceSet_;
            }
        }

        protected Dictionary<Guid, Guid> Choices { get; } = new Dictionary<Guid, Guid>();

        /// <summary>
        /// default constructor
        /// </summary>
        public UnitChoiceSet() : base()
        {

        }

        public static List<PhysicalQuantity> AvailableQuantities
        {
            get
            {
                if (availableQuantities_ == null)
                {
                    Assembly assembly = Assembly.GetAssembly(typeof(UnitChoiceSet));
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

        public UnitChoice GetChoice(Guid physicalQuantityID)
        {
            UnitChoice choice = null;
            Guid unitChoiceID;
            PhysicalQuantity quantity = PhysicalQuantity.GetQuantity(physicalQuantityID);
            if (quantity != null && Choices.TryGetValue(physicalQuantityID, out unitChoiceID))
            {
                if (unitChoiceID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(unitChoiceID);
                }
            }
            return choice;
        }
        public UnitChoice GetChoice(string physicalQuantityName)
        {
            UnitChoice choice = null;
            Guid unitChoiceID;
            PhysicalQuantity quantity = PhysicalQuantity.GetQuantity(physicalQuantityName);
            if (quantity != null &&  Choices.TryGetValue(quantity.ID, out unitChoiceID))
            {
                if (unitChoiceID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(unitChoiceID);
                }
            }
            return choice;
        }
        public UnitChoice GetChoice(PhysicalQuantity.QuantityEnum physicalQuantityID)
        {
            UnitChoice choice = null;
            Guid unitChoiceID;
            PhysicalQuantity quantity = PhysicalQuantity.GetQuantity(physicalQuantityID);
            if (quantity != null && Choices.TryGetValue(quantity.ID, out unitChoiceID))
            {
                if (unitChoiceID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(unitChoiceID);
                }
            }
            return choice;
        }

        public double? FromSI(string physicalQuantityName, double val)
        {
            UnitChoice choice = GetChoice(physicalQuantityName);
            if (choice != null)
            {
                return choice.FromSI(val);
            }
            else
            {
                return null;
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

        public double? ToSI(string physicalQuantityName, double val)
        {
            UnitChoice choice = GetChoice(physicalQuantityName);
            if (choice != null)
            {
                return choice.ToSI(val);
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

        public string GetUnitSymbol(string physicalQuantityName)
        {
            UnitChoice choice = GetChoice(physicalQuantityName);
            if (choice != null)
            {
                return choice.UnitSymbol;
            }
            else
            {
                return null;
            }
        }

        public string GetUnitSymbol(PhysicalQuantity.QuantityEnum physicalQuantityID)
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
        protected UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum defaultUnitChoice)
        {
            List<PhysicalQuantity> quantities = UnitChoiceSet.AvailableQuantities;
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
                    Choices.Add(AccelerationQuantity.Instance.ID, AccelerationQuantity.Instance.GetUnitChoice(AccelerationQuantity.UnitChoicesEnum.MeterPerSecondSquare).ID);
                    Choices.Add(AmountSubstanceQuantity.Instance.ID, AmountSubstanceQuantity.Instance.GetUnitChoice(AmountSubstanceQuantity.UnitChoicesEnum.Mole).ID);
                    Choices.Add(AngleVariationGradientQuantity.Instance.ID, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerMeter).ID);
                    Choices.Add(AngularVelocityQuantity.Instance.ID, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID);
                    Choices.Add(AreaQuantity.Instance.ID, AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMeter).ID);
                    Choices.Add(CompressibilityQuantity.Instance.ID, CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InverseBar).ID);
                    Choices.Add(CurvatureQuantity.Instance.ID, CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer30m).ID);
                    Choices.Add(DensityGradientDepthQuantity.Instance.ID, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.GramPerCubicCentimeterPer100Meter).ID);
                    Choices.Add(DensityGradientTemperatureQuantity.Instance.ID, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.GramPerCubicCentimeterPerCelsius).ID);
                    Choices.Add(DensityQuantity.Instance.ID, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.GramPerCubicCentimeter).ID);
                    Choices.Add(DensitySpeedQuantity.Instance.ID, DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.GramPerCubicCentimeterPerHour).ID);
                    Choices.Add(DimensionLessQuantity.Instance.ID, DimensionLessQuantity.Instance.GetUnitChoice(DimensionLessQuantity.UnitChoicesEnum.DimensionLess).ID);
                    Choices.Add(DynamicViscosityQuantity.Instance.ID, DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID);
                    Choices.Add(EarthMagneticFluxDencityQuantity.Instance.ID, EarthMagneticFluxDencityQuantity.Instance.GetUnitChoice(EarthMagneticFluxDencityQuantity.UnitChoicesEnum.Gauss).ID);
                    Choices.Add(ElectricalCapacitanceQuantity.Instance.ID, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.MicroFarad).ID);
                    Choices.Add(ElectricCurrentQuantity.Instance.ID, ElectricCurrentQuantity.Instance.GetUnitChoice(ElectricCurrentQuantity.UnitChoicesEnum.Ampere).ID);
                    Choices.Add(ElectricTensionQuantity.Instance.ID, ElectricTensionQuantity.Instance.GetUnitChoice(ElectricTensionQuantity.UnitChoicesEnum.Volt).ID);
                    Choices.Add(ElongationGradientQuantity.Instance.ID, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MeterPerMeter).ID);
                    Choices.Add(EnergyQuantity.Instance.ID, EnergyQuantity.Instance.GetUnitChoice(EnergyQuantity.UnitChoicesEnum.Joule).ID);
                    Choices.Add(ImageScaleQuantity.Instance.ID, ImageScaleQuantity.Instance.GetUnitChoice(ImageScaleQuantity.UnitChoicesEnum.DotPerInch).ID);
                    Choices.Add(LengthQuantity.Instance.ID, LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Metre).ID);
                    Choices.Add(LuminousIntensityQuantity.Instance.ID, LuminousIntensityQuantity.Instance.GetUnitChoice(LuminousIntensityQuantity.UnitChoicesEnum.Candela).ID);
                    Choices.Add(MassQuantity.Instance.ID, MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Kilogram).ID);
                    Choices.Add(PlaneAngleQuantity.Instance.ID, PlaneAngleQuantity.Instance.GetUnitChoice(PlaneAngleQuantity.UnitChoicesEnum.Degree).ID);
                    Choices.Add(RelativeTemperatureQuantity.Instance.ID, RelativeTemperatureQuantity.Instance.GetUnitChoice(RelativeTemperatureQuantity.UnitChoicesEnum.RelativeCelcius).ID);
                    Choices.Add(SmallLengthQuantity.Instance.ID, SmallLengthQuantity.Instance.GetUnitChoice(SmallLengthQuantity.UnitChoicesEnum.Millimeter).ID);
                    Choices.Add(SolidAngleQuantity.Instance.ID, SolidAngleQuantity.Instance.GetUnitChoice(SolidAngleQuantity.UnitChoicesEnum.SquareDegree).ID);
                    Choices.Add(TemperatureQuantity.Instance.ID, TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Celsius).ID);
                    Choices.Add(TimeQuantity.Instance.ID, TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Second).ID);
                    Choices.Add(PressureQuantity.Instance.ID, PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Bar).ID);
                    Choices.Add(VolumetricFlowRateQuantity.Instance.ID, VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerMinute).ID);
                    Choices.Add(VolumetricFlowRateOfChangeQuantity.Instance.ID, VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.LiterPerMinutePerSecond).ID);
                    Choices.Add(VelocityQuantity.Instance.ID, VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerSecond).ID);
                    Choices.Add(ForceGradientQuantity.Instance.ID, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID);
                    Choices.Add(ForceQuantity.Instance.ID, ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.DecaNewton).ID);
                    Choices.Add(MaterialStrengthQuantity.Instance.ID, MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.MegaPascal).ID);
                    Choices.Add(FrequencyQuantity.Instance.ID, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz).ID);
                    Choices.Add(RotationFrequencyQuantity.Instance.ID, RotationFrequencyQuantity.Instance.GetUnitChoice(RotationFrequencyQuantity.UnitChoicesEnum.RPM).ID);
                    Choices.Add(ProportionQuantity.Instance.ID, ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(HeatTransferCoefficientQuantity.Instance.ID, HeatTransferCoefficientQuantity.Instance.GetUnitChoice(HeatTransferCoefficientQuantity.UnitChoicesEnum.WattPerMeterSquaredPerKelvin).ID);
                    Choices.Add(GravitationalLoadQuantity.Instance.ID, GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Kilogram).ID);
                    Choices.Add(HydraulicConductivityQuantity.Instance.ID, HydraulicConductivityQuantity.Instance.GetUnitChoice(HydraulicConductivityQuantity.UnitChoicesEnum.MeterPerSecond).ID);
                    Choices.Add(InterfacialTensionQuantity.Instance.ID, InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.NewtonPerMeter).ID);
                    Choices.Add(VolumeQuantity.Instance.ID, VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.Liter).ID);
                    Choices.Add(LargeVolumeQuantity.Instance.ID, LargeVolumeQuantity.Instance.GetUnitChoice(LargeVolumeQuantity.UnitChoicesEnum.CubicMeter).ID);
                    Choices.Add(MagneticFluxDensityQuantity.Instance.ID, MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID);
                    Choices.Add(MassRateQuantity.Instance.ID, MassRateQuantity.Instance.GetUnitChoice(MassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID);
                    Choices.Add(PermeabilityQuantity.Instance.ID, PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.MilliDarcy).ID);
                    Choices.Add(PressureGradientQuantity.Instance.ID, PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.BarPerMeter).ID);
                    Choices.Add(PressureLossConstantQuantity.Instance.ID, PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantMetric).ID);
                    Choices.Add(ResistivityQuantity.Instance.ID, ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMeter).ID);
                    Choices.Add(FrequencyRateOfChangeQuantity.Instance.ID, FrequencyRateOfChangeQuantity.Instance.GetUnitChoice(FrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond).ID);
                    Choices.Add(RotationFrequencyRateOfChangeQuantity.Instance.ID, RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID);
                    Choices.Add(FluidShearStressQuantity.Instance.ID, FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.Pascal).ID);
                    Choices.Add(SpecificHeatCapacityQuantity.Instance.ID, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerKilogramKelvin).ID);
                    Choices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.ID, SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerKilogramKelvinPerKelvin).ID);
                    Choices.Add(TemperatureGradientQuantity.Instance.ID, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPerMeter).ID);
                    Choices.Add(TensionQuantity.Instance.ID, TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.DecaNewton).ID);
                    Choices.Add(ThermalConductivityQuantity.Instance.ID, ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.WattPerMetreKelvin).ID);
                    Choices.Add(MassGradientQuantity.Instance.ID, MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.KilogramPerMeter).ID);
                    Choices.Add(StandardProportionQuantity.Instance.ID, StandardProportionQuantity.Instance.GetUnitChoice(StandardProportionQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(StandardDimensionLessQuantity.Instance.ID, StandardDimensionLessQuantity.Instance.GetUnitChoice(StandardDimensionLessQuantity.UnitChoicesEnum.DimensionLess).ID);
                    Choices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.ID, ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.WattPerMetreKelvinPerKelvin).ID);
                    Choices.Add(TorqueQuantity.Instance.ID, TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.MeterNewton).ID);
                    Choices.Add(YoungModulusQuantity.Instance.ID, YoungModulusQuantity.Instance.GetUnitChoice(YoungModulusQuantity.UnitChoicesEnum.MegaPascal).ID);
                }
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.US)
                {
                    Choices.Add(AccelerationQuantity.Instance.ID, AccelerationQuantity.Instance.GetUnitChoice(AccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare).ID);
                    Choices.Add(AmountSubstanceQuantity.Instance.ID, AmountSubstanceQuantity.Instance.GetUnitChoice(AmountSubstanceQuantity.UnitChoicesEnum.Mole).ID);
                    Choices.Add(AngleVariationGradientQuantity.Instance.ID, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID);
                    Choices.Add(AngularVelocityQuantity.Instance.ID, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID);
                    Choices.Add(AreaQuantity.Instance.ID, AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareFoot).ID);
                    Choices.Add(CompressibilityQuantity.Instance.ID, CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID);
                    Choices.Add(CurvatureQuantity.Instance.ID, CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer100ft).ID);
                    Choices.Add(DensityGradientDepthQuantity.Instance.ID, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer100Foot).ID);
                    Choices.Add(DensityGradientTemperatureQuantity.Instance.ID, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit).ID);
                    Choices.Add(DensityQuantity.Instance.ID, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUS).ID);
                    Choices.Add(DensitySpeedQuantity.Instance.ID, DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUSPerHour).ID);
                    Choices.Add(DimensionLessQuantity.Instance.ID, DimensionLessQuantity.Instance.GetUnitChoice(DimensionLessQuantity.UnitChoicesEnum.DimensionLess).ID);
                    Choices.Add(DynamicViscosityQuantity.Instance.ID, DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID);
                    Choices.Add(EarthMagneticFluxDencityQuantity.Instance.ID, EarthMagneticFluxDencityQuantity.Instance.GetUnitChoice(EarthMagneticFluxDencityQuantity.UnitChoicesEnum.Gauss).ID);
                    Choices.Add(ElectricalCapacitanceQuantity.Instance.ID, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.MicroFarad).ID);
                    Choices.Add(ElectricCurrentQuantity.Instance.ID, ElectricCurrentQuantity.Instance.GetUnitChoice(ElectricCurrentQuantity.UnitChoicesEnum.Ampere).ID);
                    Choices.Add(ElectricTensionQuantity.Instance.ID, ElectricTensionQuantity.Instance.GetUnitChoice(ElectricTensionQuantity.UnitChoicesEnum.Volt).ID);
                    Choices.Add(ElongationGradientQuantity.Instance.ID, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID);
                    Choices.Add(EnergyQuantity.Instance.ID, EnergyQuantity.Instance.GetUnitChoice(EnergyQuantity.UnitChoicesEnum.Joule).ID);
                    Choices.Add(ImageScaleQuantity.Instance.ID, ImageScaleQuantity.Instance.GetUnitChoice(ImageScaleQuantity.UnitChoicesEnum.DotPerInch).ID);
                    Choices.Add(LengthQuantity.Instance.ID, LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Feet).ID);
                    Choices.Add(LuminousIntensityQuantity.Instance.ID, LuminousIntensityQuantity.Instance.GetUnitChoice(LuminousIntensityQuantity.UnitChoicesEnum.Candela).ID);
                    Choices.Add(MassQuantity.Instance.ID, MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Pound).ID);
                    Choices.Add(PlaneAngleQuantity.Instance.ID, PlaneAngleQuantity.Instance.GetUnitChoice(PlaneAngleQuantity.UnitChoicesEnum.Degree).ID);
                    Choices.Add(RelativeTemperatureQuantity.Instance.ID, RelativeTemperatureQuantity.Instance.GetUnitChoice(RelativeTemperatureQuantity.UnitChoicesEnum.Rankine).ID);
                    Choices.Add(SmallLengthQuantity.Instance.ID, SmallLengthQuantity.Instance.GetUnitChoice(SmallLengthQuantity.UnitChoicesEnum.Inch_32).ID);
                    Choices.Add(SolidAngleQuantity.Instance.ID, SolidAngleQuantity.Instance.GetUnitChoice(SolidAngleQuantity.UnitChoicesEnum.SquareDegree).ID);
                    Choices.Add(TemperatureQuantity.Instance.ID, TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Fahrenheit).ID);
                    Choices.Add(TimeQuantity.Instance.ID, TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Second).ID);
                    Choices.Add(PressureQuantity.Instance.ID, PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID);
                    Choices.Add(VolumetricFlowRateQuantity.Instance.ID, VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerMinute).ID);
                    Choices.Add(VolumetricFlowRateOfChangeQuantity.Instance.ID, VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.USGallonPerMinutePerSecond).ID);
                    Choices.Add(VelocityQuantity.Instance.ID, VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(ForceGradientQuantity.Instance.ID, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID);
                    Choices.Add(ForceQuantity.Instance.ID, ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.PoundForce).ID);
                    Choices.Add(MaterialStrengthQuantity.Instance.ID, MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.PSI).ID);
                    Choices.Add(FrequencyQuantity.Instance.ID, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz).ID);
                    Choices.Add(RotationFrequencyQuantity.Instance.ID, RotationFrequencyQuantity.Instance.GetUnitChoice(RotationFrequencyQuantity.UnitChoicesEnum.RPM).ID);
                    Choices.Add(ProportionQuantity.Instance.ID, ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(HeatTransferCoefficientQuantity.Instance.ID, HeatTransferCoefficientQuantity.Instance.GetUnitChoice(HeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID);
                    Choices.Add(GravitationalLoadQuantity.Instance.ID, GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Pound).ID);
                    Choices.Add(HydraulicConductivityQuantity.Instance.ID, HydraulicConductivityQuantity.Instance.GetUnitChoice(HydraulicConductivityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(InterfacialTensionQuantity.Instance.ID, InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID);
                    Choices.Add(VolumeQuantity.Instance.ID, VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.USGallon).ID);
                    Choices.Add(LargeVolumeQuantity.Instance.ID, LargeVolumeQuantity.Instance.GetUnitChoice(LargeVolumeQuantity.UnitChoicesEnum.USGallon).ID);
                    Choices.Add(MagneticFluxDensityQuantity.Instance.ID, MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID);
                    Choices.Add(MassRateQuantity.Instance.ID, MassRateQuantity.Instance.GetUnitChoice(MassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID);
                    Choices.Add(PermeabilityQuantity.Instance.ID, PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.MilliDarcy).ID);
                    Choices.Add(PressureGradientQuantity.Instance.ID, PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PSIPerFoot).ID);
                    Choices.Add(PressureLossConstantQuantity.Instance.ID, PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUS).ID);
                    Choices.Add(ResistivityQuantity.Instance.ID, ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMeter).ID);
                    Choices.Add(FrequencyRateOfChangeQuantity.Instance.ID, FrequencyRateOfChangeQuantity.Instance.GetUnitChoice(FrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond).ID);
                    Choices.Add(RotationFrequencyRateOfChangeQuantity.Instance.ID, RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID);
                    Choices.Add(FluidShearStressQuantity.Instance.ID, FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.PoundPer100SquareFoot).ID);
                    Choices.Add(SpecificHeatCapacityQuantity.Instance.ID, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit).ID);
                    Choices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.ID, SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit).ID);
                    Choices.Add(TemperatureGradientQuantity.Instance.ID, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot).ID);
                    Choices.Add(TensionQuantity.Instance.ID, TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.PoundForce).ID);
                    Choices.Add(ThermalConductivityQuantity.Instance.ID, ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit).ID);
                    Choices.Add(MassGradientQuantity.Instance.ID, MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID);
                    Choices.Add(StandardProportionQuantity.Instance.ID, StandardProportionQuantity.Instance.GetUnitChoice(StandardProportionQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(StandardDimensionLessQuantity.Instance.ID, StandardDimensionLessQuantity.Instance.GetUnitChoice(StandardDimensionLessQuantity.UnitChoicesEnum.DimensionLess).ID);
                    Choices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.ID, ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit).ID);
                    Choices.Add(TorqueQuantity.Instance.ID, TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.FootPound).ID);
                    Choices.Add(YoungModulusQuantity.Instance.ID, YoungModulusQuantity.Instance.GetUnitChoice(YoungModulusQuantity.UnitChoicesEnum.PSI).ID);
                }
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.Imperial)
                {
                    Choices.Add(AccelerationQuantity.Instance.ID, AccelerationQuantity.Instance.GetUnitChoice(AccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare).ID);
                    Choices.Add(AmountSubstanceQuantity.Instance.ID, AmountSubstanceQuantity.Instance.GetUnitChoice(AmountSubstanceQuantity.UnitChoicesEnum.Mole).ID);
                    Choices.Add(AngleVariationGradientQuantity.Instance.ID, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID);
                    Choices.Add(AngularVelocityQuantity.Instance.ID, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID);
                    Choices.Add(AreaQuantity.Instance.ID, AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareFoot).ID);
                    Choices.Add(CompressibilityQuantity.Instance.ID, CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID);
                    Choices.Add(CurvatureQuantity.Instance.ID, CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer100ft).ID);
                    Choices.Add(DensityGradientDepthQuantity.Instance.ID, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer100Foot).ID);
                    Choices.Add(DensityGradientTemperatureQuantity.Instance.ID, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit).ID);
                    Choices.Add(DensityQuantity.Instance.ID, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUK).ID);
                    Choices.Add(DensitySpeedQuantity.Instance.ID, DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUKPerHour).ID);
                    Choices.Add(DimensionLessQuantity.Instance.ID, DimensionLessQuantity.Instance.GetUnitChoice(DimensionLessQuantity.UnitChoicesEnum.DimensionLess).ID);
                    Choices.Add(DynamicViscosityQuantity.Instance.ID, DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID);
                    Choices.Add(EarthMagneticFluxDencityQuantity.Instance.ID, EarthMagneticFluxDencityQuantity.Instance.GetUnitChoice(EarthMagneticFluxDencityQuantity.UnitChoicesEnum.Gauss).ID);
                    Choices.Add(ElectricalCapacitanceQuantity.Instance.ID, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.MicroFarad).ID);
                    Choices.Add(ElectricCurrentQuantity.Instance.ID, ElectricCurrentQuantity.Instance.GetUnitChoice(ElectricCurrentQuantity.UnitChoicesEnum.Ampere).ID);
                    Choices.Add(ElectricTensionQuantity.Instance.ID, ElectricTensionQuantity.Instance.GetUnitChoice(ElectricTensionQuantity.UnitChoicesEnum.Volt).ID);
                    Choices.Add(ElongationGradientQuantity.Instance.ID, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID);
                    Choices.Add(EnergyQuantity.Instance.ID, EnergyQuantity.Instance.GetUnitChoice(EnergyQuantity.UnitChoicesEnum.Joule).ID);
                    Choices.Add(ImageScaleQuantity.Instance.ID, ImageScaleQuantity.Instance.GetUnitChoice(ImageScaleQuantity.UnitChoicesEnum.DotPerInch).ID);
                    Choices.Add(LengthQuantity.Instance.ID, LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Feet).ID);
                    Choices.Add(LuminousIntensityQuantity.Instance.ID, LuminousIntensityQuantity.Instance.GetUnitChoice(LuminousIntensityQuantity.UnitChoicesEnum.Candela).ID);
                    Choices.Add(MassQuantity.Instance.ID, MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Pound).ID);
                    Choices.Add(PlaneAngleQuantity.Instance.ID, PlaneAngleQuantity.Instance.GetUnitChoice(PlaneAngleQuantity.UnitChoicesEnum.Degree).ID);
                    Choices.Add(RelativeTemperatureQuantity.Instance.ID, RelativeTemperatureQuantity.Instance.GetUnitChoice(RelativeTemperatureQuantity.UnitChoicesEnum.Rankine).ID);
                    Choices.Add(SmallLengthQuantity.Instance.ID, SmallLengthQuantity.Instance.GetUnitChoice(SmallLengthQuantity.UnitChoicesEnum.Inch_32).ID);
                    Choices.Add(SolidAngleQuantity.Instance.ID, SolidAngleQuantity.Instance.GetUnitChoice(SolidAngleQuantity.UnitChoicesEnum.SquareDegree).ID);
                    Choices.Add(TemperatureQuantity.Instance.ID, TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Fahrenheit).ID);
                    Choices.Add(TimeQuantity.Instance.ID, TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Second).ID);
                    Choices.Add(PressureQuantity.Instance.ID, PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID);
                    Choices.Add(VolumetricFlowRateQuantity.Instance.ID, VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerMinute).ID);
                    Choices.Add(VolumetricFlowRateOfChangeQuantity.Instance.ID, VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.UKGallonPerMinutePerSecond).ID);
                    Choices.Add(VelocityQuantity.Instance.ID, VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(ForceGradientQuantity.Instance.ID, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID);
                    Choices.Add(ForceQuantity.Instance.ID, ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.PoundForce).ID);
                    Choices.Add(MaterialStrengthQuantity.Instance.ID, MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.PSI).ID);
                    Choices.Add(FrequencyQuantity.Instance.ID, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz).ID);
                    Choices.Add(RotationFrequencyQuantity.Instance.ID, RotationFrequencyQuantity.Instance.GetUnitChoice(RotationFrequencyQuantity.UnitChoicesEnum.RPM).ID);
                    Choices.Add(ProportionQuantity.Instance.ID, ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(HeatTransferCoefficientQuantity.Instance.ID, HeatTransferCoefficientQuantity.Instance.GetUnitChoice(HeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID);
                    Choices.Add(GravitationalLoadQuantity.Instance.ID, GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Pound).ID);
                    Choices.Add(HydraulicConductivityQuantity.Instance.ID, HydraulicConductivityQuantity.Instance.GetUnitChoice(HydraulicConductivityQuantity.UnitChoicesEnum.FootPerSecond).ID);
                    Choices.Add(InterfacialTensionQuantity.Instance.ID, InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID);
                    Choices.Add(VolumeQuantity.Instance.ID, VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.UKGallon).ID);
                    Choices.Add(LargeVolumeQuantity.Instance.ID, LargeVolumeQuantity.Instance.GetUnitChoice(LargeVolumeQuantity.UnitChoicesEnum.UKGallon).ID);
                    Choices.Add(MagneticFluxDensityQuantity.Instance.ID, MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID);
                    Choices.Add(MassRateQuantity.Instance.ID, MassRateQuantity.Instance.GetUnitChoice(MassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID);
                    Choices.Add(PermeabilityQuantity.Instance.ID, PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.MilliDarcy).ID);
                    Choices.Add(PressureGradientQuantity.Instance.ID, PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PSIPerFoot).ID);
                    Choices.Add(PressureLossConstantQuantity.Instance.ID, PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUK).ID);
                    Choices.Add(ResistivityQuantity.Instance.ID, ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMeter).ID);
                    Choices.Add(FrequencyRateOfChangeQuantity.Instance.ID, FrequencyRateOfChangeQuantity.Instance.GetUnitChoice(FrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond).ID);
                    Choices.Add(RotationFrequencyRateOfChangeQuantity.Instance.ID, RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID);
                    Choices.Add(FluidShearStressQuantity.Instance.ID, FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.PoundPer100SquareFoot).ID);
                    Choices.Add(SpecificHeatCapacityQuantity.Instance.ID, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit).ID);
                    Choices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.ID, SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit).ID);
                    Choices.Add(TemperatureGradientQuantity.Instance.ID, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot).ID);
                    Choices.Add(TensionQuantity.Instance.ID, TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.PoundForce).ID);
                    Choices.Add(ThermalConductivityQuantity.Instance.ID, ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit).ID);
                    Choices.Add(MassGradientQuantity.Instance.ID, MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID);
                    Choices.Add(StandardProportionQuantity.Instance.ID, StandardProportionQuantity.Instance.GetUnitChoice(StandardProportionQuantity.UnitChoicesEnum.Percent).ID);
                    Choices.Add(StandardDimensionLessQuantity.Instance.ID, StandardDimensionLessQuantity.Instance.GetUnitChoice(StandardDimensionLessQuantity.UnitChoicesEnum.DimensionLess).ID);
                    Choices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.ID, ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit).ID);
                    Choices.Add(TorqueQuantity.Instance.ID, TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.FootPound).ID);
                    Choices.Add(YoungModulusQuantity.Instance.ID, YoungModulusQuantity.Instance.GetUnitChoice(YoungModulusQuantity.UnitChoicesEnum.PSI).ID);
                }
                CheckMissing(quantities);
            }
        }
        protected void CheckMissing(List<PhysicalQuantity> quantities)
        {
            foreach (PhysicalQuantity quantity in quantities)
            {
                if (!Choices.ContainsKey(quantity.ID))
                {
                    throw new Exception("missing default unit choice for this physical quantity");
                }
            }
        }
    }
}
