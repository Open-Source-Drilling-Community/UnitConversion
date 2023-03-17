using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public class UnitChoiceSet
    {
        private static Dictionary<Guid, UnitChoiceSet> unitChoiceSets_ = null;

        private static List<PhysicalQuantity> availableQuantities_ = null;

        private static UnitChoiceSet SIUnitChoiceSet_ = null;
        private static UnitChoiceSet MetricUnitChoiceSet_ = null;
        private static UnitChoiceSet ImperialUnitChoiceSet_ = null;
        private static UnitChoiceSet USUnitChoiceSet_ = null;

        public static UnitChoiceSet Get(Guid ID)
        {
            if (unitChoiceSets_ == null)
            {
                Initialize();
            }
            UnitChoiceSet result;
            unitChoiceSets_.TryGetValue(ID, out result);
            return result;
        }

        public static UnitChoiceSet CreateNew()
        {
            if (unitChoiceSets_ == null)
            {
                Initialize();
            }
            UnitChoiceSet unitChoiceSet = new UnitChoiceSet();
            unitChoiceSet.ID = Guid.NewGuid();
            unitChoiceSets_.Add(unitChoiceSet.ID, unitChoiceSet);
            return unitChoiceSet;
        }

        public static UnitChoiceSet CreateNew(Guid guid)
        {
            if (unitChoiceSets_ == null)
            {
                Initialize();
            }
            if (unitChoiceSets_.ContainsKey(guid))
            {
                UnitChoiceSet result;
                unitChoiceSets_.TryGetValue(guid, out result);
                return result;
            }
            else
            {
                UnitChoiceSet unitChoiceSet = new UnitChoiceSet();
                unitChoiceSet.ID = guid;
                unitChoiceSets_.Add(unitChoiceSet.ID, unitChoiceSet);
                return unitChoiceSet;
            }
        }

        private static void Initialize()
        {
            if (unitChoiceSets_ == null)
            {
                unitChoiceSets_ = new Dictionary<Guid, UnitChoiceSet>();
                UnitChoiceSet SI = SIUnitChoiceSet;
                unitChoiceSets_.Add(SI.ID, SI);
                UnitChoiceSet metric = MetricUnitChoiceSet;
                unitChoiceSets_.Add(metric.ID, metric);
                UnitChoiceSet US = USUnitChoiceSet;
                unitChoiceSets_.Add(US.ID, US);
                UnitChoiceSet imperial = ImperialUnitChoiceSet;
                unitChoiceSets_.Add(imperial.ID, imperial);
            }
        }

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

        public Dictionary<string, string> Choices { get; set; } = new Dictionary<string, string>();

        protected Guid StringToGUID(string val)
        {
            Guid result = Guid.Empty;
            if (!string.IsNullOrEmpty(val))
            {
                try
                {
                    result = new Guid(val);
                }
                catch(Exception)
                {

                }
            }
            return result;
        }
        /// <summary>
        /// a unique ID for the unit choice set
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// a name for the unit choice set
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// a description of the unit choice set
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// true if it is one the default unit choice set
        /// </summary>
        public bool IsDefault { get; set; }
        /// <summary>
        /// true if it is the SI unit choice set
        /// </summary>
        public bool IsSI { get; set; }

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

        protected virtual PhysicalQuantity GetQuantity(Guid quantityID)
        {
            return PhysicalQuantity.GetQuantity(quantityID);
        }

        protected virtual PhysicalQuantity GetQuantity(string quantityName)
        {
            return PhysicalQuantity.GetQuantity(quantityName);
        }

        protected virtual PhysicalQuantity GetQuantity(PhysicalQuantity.QuantityEnum quantityChoice)
        {
            return PhysicalQuantity.GetQuantity(quantityChoice);
        }

        public UnitChoice GetChoice(Guid physicalQuantityID)
        {
            UnitChoice choice = null;
            string unitChoiceID;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityID);
            if (quantity != null && Choices.TryGetValue(physicalQuantityID.ToString(), out unitChoiceID))
            {
                Guid ID = StringToGUID(unitChoiceID);
                if (ID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(ID);
                }
            }
            return choice;
        }
        public UnitChoice GetChoice(string physicalQuantityName)
        {
            UnitChoice choice = null;
            string unitChoiceID;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityName);
            if (quantity != null &&  Choices.TryGetValue(quantity.ID.ToString(), out unitChoiceID))
            {
                Guid ID = StringToGUID(unitChoiceID);
                if (ID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(ID);
                }
            }
            return choice;
        }
        public UnitChoice GetChoice(PhysicalQuantity.QuantityEnum physicalQuantityID)
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

        public double? FromSI(Guid physicalQuantityID, double val)
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

        public string FromSIString(string physicalQuantityName, double val)
        {
            double? meaningfulPrecision = null;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityName);
            if (quantity != null)
            {
                meaningfulPrecision = quantity.MeaningfulPrecisionInSI;
            }
            UnitChoice choice = GetChoice(physicalQuantityName);
            if (choice != null)
            {
                return choice.FromSI(val, meaningfulPrecision);
            }
            else
            {
                return null;
            }
        }

        public string FromSIString(Guid physicalQuantityID, double val)
        {
            double? meaningfulPrecision = null;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityID);
            if (quantity != null)
            {
                meaningfulPrecision = quantity.MeaningfulPrecisionInSI;
            }
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

        public string FromSIString(PhysicalQuantity.QuantityEnum physicalQuantityID, double val)
        {
            double? meaningfulPrecision = null;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityID);
            if (quantity != null)
            {
                meaningfulPrecision = quantity.MeaningfulPrecisionInSI;
            }
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
        public double? ToSI(Guid physicalQuantityID, double val)
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
        public string ToSIString(string physicalQuantityName, double val)
        {
            double? meaningfulPrecision = null;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityName);
            if (quantity != null)
            {
                meaningfulPrecision = quantity.MeaningfulPrecisionInSI;
            }
            UnitChoice choice = GetChoice(physicalQuantityName);
            if (choice != null)
            {
                return choice.ToSI(val, meaningfulPrecision);
            }
            else
            {
                return null;
            }
        }

        public string ToSIString(Guid physicalQuantityID, double val)
        {
            double? meaningfulPrecision = null;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityID);
            if (quantity != null)
            {
                meaningfulPrecision = quantity.MeaningfulPrecisionInSI;
            }
            UnitChoice choice = GetChoice(physicalQuantityID);
            if (choice != null)
            {
                return choice.ToSI(val, meaningfulPrecision);
            }
            else
            {
                return null;
            }
        }

        public string ToSIString(PhysicalQuantity.QuantityEnum physicalQuantityID, double val)
        {
            double? meaningfulPrecision = null;
            PhysicalQuantity quantity = GetQuantity(physicalQuantityID);
            if (quantity != null)
            {
                meaningfulPrecision = quantity.MeaningfulPrecisionInSI;
            }
            UnitChoice choice = GetChoice(physicalQuantityID);
            if (choice != null)
            {
                return choice.ToSI(val, meaningfulPrecision);
            }
            else
            {
                return null;
            }
        }

        public string GetUnitLabel(string physicalQuantityName)
        {
            UnitChoice choice = GetChoice(physicalQuantityName);
            if (choice != null)
            {
                return choice.UnitLabel;
            }
            else
            {
                return null;
            }
        }
        public string GetUnitLabel(Guid physicalQuantityID)
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
                    IsSI = true;
                    IsDefault = true;
                    ID = new Guid("a02672dc-17fc-474d-a4de-397e0d39325a");
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
                    ID = new Guid("54191fdc-e88e-46db-ba05-9efce3d4fc0b");
                    Name = "Metric";
                    Description = "Metric System of Units";

                    Choices.Add(AccelerationQuantity.Instance.ID.ToString(), AccelerationQuantity.Instance.GetUnitChoice(AccelerationQuantity.UnitChoicesEnum.MeterPerSecondSquare).ID.ToString());
                    Choices.Add(AmountSubstanceQuantity.Instance.ID.ToString(), AmountSubstanceQuantity.Instance.GetUnitChoice(AmountSubstanceQuantity.UnitChoicesEnum.Mole).ID.ToString());
                    Choices.Add(AngleVariationGradientQuantity.Instance.ID.ToString(), AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerMeter).ID.ToString());
                    Choices.Add(AngularVelocityQuantity.Instance.ID.ToString(), AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(AreaQuantity.Instance.ID.ToString(), AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMeter).ID.ToString());
                    Choices.Add(CompressibilityQuantity.Instance.ID.ToString(), CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InverseBar).ID.ToString());
                    Choices.Add(CurvatureQuantity.Instance.ID.ToString(), CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer30m).ID.ToString());
                    Choices.Add(DensityGradientDepthQuantity.Instance.ID.ToString(), DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.GramPerCubicCentimeterPer100Meter).ID.ToString());
                    Choices.Add(DensityGradientTemperatureQuantity.Instance.ID.ToString(), DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.GramPerCubicCentimeterPerCelsius).ID.ToString());
                    Choices.Add(DensityQuantity.Instance.ID.ToString(), DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.GramPerCubicCentimeter).ID.ToString());
                    Choices.Add(DensityRateOfChangeQuantity.Instance.ID.ToString(), DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.GramPerCubicCentimeterPerHour).ID.ToString());
                    Choices.Add(DimensionlessQuantity.Instance.ID.ToString(), DimensionlessQuantity.Instance.GetUnitChoice(DimensionlessQuantity.UnitChoicesEnum.Dimensionless).ID.ToString());
                    Choices.Add(DynamicViscosityQuantity.Instance.ID.ToString(), DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(EarthMagneticFluxDensityQuantity.Instance.ID.ToString(), EarthMagneticFluxDensityQuantity.Instance.GetUnitChoice(EarthMagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID.ToString());
                    Choices.Add(ElectricalCapacitanceQuantity.Instance.ID.ToString(), ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.MicroFarad).ID.ToString());
                    Choices.Add(ElectricCurrentQuantity.Instance.ID.ToString(), ElectricCurrentQuantity.Instance.GetUnitChoice(ElectricCurrentQuantity.UnitChoicesEnum.Ampere).ID.ToString());
                    Choices.Add(ElectricTensionQuantity.Instance.ID.ToString(), ElectricTensionQuantity.Instance.GetUnitChoice(ElectricTensionQuantity.UnitChoicesEnum.Volt).ID.ToString());
                    Choices.Add(ElongationGradientQuantity.Instance.ID.ToString(), ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MeterPerMeter).ID.ToString());
                    Choices.Add(EnergyQuantity.Instance.ID.ToString(), EnergyQuantity.Instance.GetUnitChoice(EnergyQuantity.UnitChoicesEnum.Joule).ID.ToString());
                    Choices.Add(ImageScaleQuantity.Instance.ID.ToString(), ImageScaleQuantity.Instance.GetUnitChoice(ImageScaleQuantity.UnitChoicesEnum.DotPerInch).ID.ToString());
                    Choices.Add(LengthQuantity.Instance.ID.ToString(), LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Metre).ID.ToString());
                    Choices.Add(LuminousIntensityQuantity.Instance.ID.ToString(), LuminousIntensityQuantity.Instance.GetUnitChoice(LuminousIntensityQuantity.UnitChoicesEnum.Candela).ID.ToString());
                    Choices.Add(MassQuantity.Instance.ID.ToString(), MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Kilogram).ID.ToString());
                    Choices.Add(PlaneAngleQuantity.Instance.ID.ToString(), PlaneAngleQuantity.Instance.GetUnitChoice(PlaneAngleQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(RelativeTemperatureQuantity.Instance.ID.ToString(), RelativeTemperatureQuantity.Instance.GetUnitChoice(RelativeTemperatureQuantity.UnitChoicesEnum.RelativeCelcius).ID.ToString());
                    Choices.Add(SmallLengthQuantity.Instance.ID.ToString(), SmallLengthQuantity.Instance.GetUnitChoice(SmallLengthQuantity.UnitChoicesEnum.Millimeter).ID.ToString());
                    Choices.Add(StandardLengthQuantity.Instance.ID.ToString(), StandardLengthQuantity.Instance.GetUnitChoice(StandardLengthQuantity.UnitChoicesEnum.Metre).ID.ToString());
                    Choices.Add(SolidAngleQuantity.Instance.ID.ToString(), SolidAngleQuantity.Instance.GetUnitChoice(SolidAngleQuantity.UnitChoicesEnum.SquareDegree).ID.ToString());
                    Choices.Add(TemperatureQuantity.Instance.ID.ToString(), TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Celsius).ID.ToString());
                    Choices.Add(TimeQuantity.Instance.ID.ToString(), TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(PressureQuantity.Instance.ID.ToString(), PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Bar).ID.ToString());
                    Choices.Add(VolumetricFlowRateQuantity.Instance.ID.ToString(), VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerMinute).ID.ToString());
                    Choices.Add(VolumetricFlowRateOfChangeQuantity.Instance.ID.ToString(), VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.LiterPerMinutePerSecond).ID.ToString());
                    Choices.Add(VelocityQuantity.Instance.ID.ToString(), VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MeterPerSecond).ID.ToString());
                    Choices.Add(ForceGradientQuantity.Instance.ID.ToString(), ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID.ToString());
                    Choices.Add(ForceQuantity.Instance.ID.ToString(), ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.DecaNewton).ID.ToString());
                    Choices.Add(MaterialStrengthQuantity.Instance.ID.ToString(), MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.MegaPascal).ID.ToString());
                    Choices.Add(FrequencyQuantity.Instance.ID.ToString(), FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz).ID.ToString());
                    Choices.Add(RotationFrequencyQuantity.Instance.ID.ToString(), RotationFrequencyQuantity.Instance.GetUnitChoice(RotationFrequencyQuantity.UnitChoicesEnum.RPM).ID.ToString());
                    Choices.Add(ProportionQuantity.Instance.ID.ToString(), ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(HeatTransferCoefficientQuantity.Instance.ID.ToString(), HeatTransferCoefficientQuantity.Instance.GetUnitChoice(HeatTransferCoefficientQuantity.UnitChoicesEnum.WattPerMeterSquaredPerKelvin).ID.ToString());
                    Choices.Add(GravitationalLoadQuantity.Instance.ID.ToString(), GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Kilogram).ID.ToString());
                    Choices.Add(HydraulicConductivityQuantity.Instance.ID.ToString(), HydraulicConductivityQuantity.Instance.GetUnitChoice(HydraulicConductivityQuantity.UnitChoicesEnum.MeterPerSecond).ID.ToString());
                    Choices.Add(InterfacialTensionQuantity.Instance.ID.ToString(), InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.NewtonPerMeter).ID.ToString());
                    Choices.Add(VolumeQuantity.Instance.ID.ToString(), VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.Liter).ID.ToString());
                    Choices.Add(LargeVolumeQuantity.Instance.ID.ToString(), LargeVolumeQuantity.Instance.GetUnitChoice(LargeVolumeQuantity.UnitChoicesEnum.CubicMeter).ID.ToString());
                    Choices.Add(MagneticFluxDensityQuantity.Instance.ID.ToString(), MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID.ToString());
                    Choices.Add(MassRateQuantity.Instance.ID.ToString(), MassRateQuantity.Instance.GetUnitChoice(MassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(PermeabilityQuantity.Instance.ID.ToString(), PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.MilliDarcy).ID.ToString());
                    Choices.Add(PressureGradientQuantity.Instance.ID.ToString(), PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.BarPerMeter).ID.ToString());
                    Choices.Add(PressureLossConstantQuantity.Instance.ID.ToString(), PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantMetric).ID.ToString());
                    Choices.Add(ResistivityQuantity.Instance.ID.ToString(), ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMeter).ID.ToString());
                    Choices.Add(FrequencyRateOfChangeQuantity.Instance.ID.ToString(), FrequencyRateOfChangeQuantity.Instance.GetUnitChoice(FrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond).ID.ToString());
                    Choices.Add(RotationFrequencyRateOfChangeQuantity.Instance.ID.ToString(), RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(FluidShearStressQuantity.Instance.ID.ToString(), FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.Pascal).ID.ToString());
                    Choices.Add(FluidShearRateQuantity.Instance.ID.ToString(), FluidShearRateQuantity.Instance.GetUnitChoice(FluidShearRateQuantity.UnitChoicesEnum.ReciprocalSecond).ID.ToString());
                    Choices.Add(SpecificHeatCapacityQuantity.Instance.ID.ToString(), SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerKilogramKelvin).ID.ToString());
                    Choices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.ID.ToString(), SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerKilogramKelvinPerKelvin).ID.ToString());
                    Choices.Add(TemperatureGradientQuantity.Instance.ID.ToString(), TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPerMeter).ID.ToString());
                    Choices.Add(TensionQuantity.Instance.ID.ToString(), TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.DecaNewton).ID.ToString());
                    Choices.Add(ThermalConductivityQuantity.Instance.ID.ToString(), ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.WattPerMetreKelvin).ID.ToString());
                    Choices.Add(MassGradientQuantity.Instance.ID.ToString(), MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.KilogramPerMeter).ID.ToString());
                    Choices.Add(StandardProportionQuantity.Instance.ID.ToString(), StandardProportionQuantity.Instance.GetUnitChoice(StandardProportionQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(StandardDimensionlessQuantity.Instance.ID.ToString(), StandardDimensionlessQuantity.Instance.GetUnitChoice(StandardDimensionlessQuantity.UnitChoicesEnum.Dimensionless).ID.ToString());
                    Choices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.ID.ToString(), ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.WattPerMetreKelvinPerKelvin).ID.ToString());
                    Choices.Add(TorqueQuantity.Instance.ID.ToString(), TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.MeterNewton).ID.ToString());
                    Choices.Add(YoungModulusQuantity.Instance.ID.ToString(), YoungModulusQuantity.Instance.GetUnitChoice(YoungModulusQuantity.UnitChoicesEnum.MegaPascal).ID.ToString());
                }
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.US)
                {
                    IsDefault = true;
                    ID = new Guid("59043df0-ff9d-42ad-bd40-d81625fe99b4");
                    Name = "US";
                    Description = "United States of America System of Units";

                    Choices.Add(AccelerationQuantity.Instance.ID.ToString(), AccelerationQuantity.Instance.GetUnitChoice(AccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare).ID.ToString());
                    Choices.Add(AmountSubstanceQuantity.Instance.ID.ToString(), AmountSubstanceQuantity.Instance.GetUnitChoice(AmountSubstanceQuantity.UnitChoicesEnum.Mole).ID.ToString());
                    Choices.Add(AngleVariationGradientQuantity.Instance.ID.ToString(), AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID.ToString());
                    Choices.Add(AngularVelocityQuantity.Instance.ID.ToString(), AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(AreaQuantity.Instance.ID.ToString(), AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareFoot).ID.ToString());
                    Choices.Add(CompressibilityQuantity.Instance.ID.ToString(), CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID.ToString());
                    Choices.Add(CurvatureQuantity.Instance.ID.ToString(), CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer100ft).ID.ToString());
                    Choices.Add(DensityGradientDepthQuantity.Instance.ID.ToString(), DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer100Foot).ID.ToString());
                    Choices.Add(DensityGradientTemperatureQuantity.Instance.ID.ToString(), DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit).ID.ToString());
                    Choices.Add(DensityQuantity.Instance.ID.ToString(), DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUS).ID.ToString());
                    Choices.Add(DensityRateOfChangeQuantity.Instance.ID.ToString(), DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUSPerHour).ID.ToString());
                    Choices.Add(DimensionlessQuantity.Instance.ID.ToString(), DimensionlessQuantity.Instance.GetUnitChoice(DimensionlessQuantity.UnitChoicesEnum.Dimensionless).ID.ToString());
                    Choices.Add(DynamicViscosityQuantity.Instance.ID.ToString(), DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(EarthMagneticFluxDensityQuantity.Instance.ID.ToString(), EarthMagneticFluxDensityQuantity.Instance.GetUnitChoice(EarthMagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID.ToString());
                    Choices.Add(ElectricalCapacitanceQuantity.Instance.ID.ToString(), ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.MicroFarad).ID.ToString());
                    Choices.Add(ElectricCurrentQuantity.Instance.ID.ToString(), ElectricCurrentQuantity.Instance.GetUnitChoice(ElectricCurrentQuantity.UnitChoicesEnum.Ampere).ID.ToString());
                    Choices.Add(ElectricTensionQuantity.Instance.ID.ToString(), ElectricTensionQuantity.Instance.GetUnitChoice(ElectricTensionQuantity.UnitChoicesEnum.Volt).ID.ToString());
                    Choices.Add(ElongationGradientQuantity.Instance.ID.ToString(), ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID.ToString());
                    Choices.Add(EnergyQuantity.Instance.ID.ToString(), EnergyQuantity.Instance.GetUnitChoice(EnergyQuantity.UnitChoicesEnum.Joule).ID.ToString());
                    Choices.Add(ImageScaleQuantity.Instance.ID.ToString(), ImageScaleQuantity.Instance.GetUnitChoice(ImageScaleQuantity.UnitChoicesEnum.DotPerInch).ID.ToString());
                    Choices.Add(LengthQuantity.Instance.ID.ToString(), LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(LuminousIntensityQuantity.Instance.ID.ToString(), LuminousIntensityQuantity.Instance.GetUnitChoice(LuminousIntensityQuantity.UnitChoicesEnum.Candela).ID.ToString());
                    Choices.Add(MassQuantity.Instance.ID.ToString(), MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Pound).ID.ToString());
                    Choices.Add(PlaneAngleQuantity.Instance.ID.ToString(), PlaneAngleQuantity.Instance.GetUnitChoice(PlaneAngleQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(RelativeTemperatureQuantity.Instance.ID.ToString(), RelativeTemperatureQuantity.Instance.GetUnitChoice(RelativeTemperatureQuantity.UnitChoicesEnum.Rankine).ID.ToString());
                    Choices.Add(SmallLengthQuantity.Instance.ID.ToString(), SmallLengthQuantity.Instance.GetUnitChoice(SmallLengthQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(StandardLengthQuantity.Instance.ID.ToString(), StandardLengthQuantity.Instance.GetUnitChoice(StandardLengthQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(SolidAngleQuantity.Instance.ID.ToString(), SolidAngleQuantity.Instance.GetUnitChoice(SolidAngleQuantity.UnitChoicesEnum.SquareDegree).ID.ToString());
                    Choices.Add(TemperatureQuantity.Instance.ID.ToString(), TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Fahrenheit).ID.ToString());
                    Choices.Add(TimeQuantity.Instance.ID.ToString(), TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(PressureQuantity.Instance.ID.ToString(), PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(VolumetricFlowRateQuantity.Instance.ID.ToString(), VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerMinute).ID.ToString());
                    Choices.Add(VolumetricFlowRateOfChangeQuantity.Instance.ID.ToString(), VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.USGallonPerMinutePerSecond).ID.ToString());
                    Choices.Add(VelocityQuantity.Instance.ID.ToString(), VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(ForceGradientQuantity.Instance.ID.ToString(), ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID.ToString());
                    Choices.Add(ForceQuantity.Instance.ID.ToString(), ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.PoundForce).ID.ToString());
                    Choices.Add(MaterialStrengthQuantity.Instance.ID.ToString(), MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(FrequencyQuantity.Instance.ID.ToString(), FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz).ID.ToString());
                    Choices.Add(RotationFrequencyQuantity.Instance.ID.ToString(), RotationFrequencyQuantity.Instance.GetUnitChoice(RotationFrequencyQuantity.UnitChoicesEnum.RPM).ID.ToString());
                    Choices.Add(ProportionQuantity.Instance.ID.ToString(), ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(HeatTransferCoefficientQuantity.Instance.ID.ToString(), HeatTransferCoefficientQuantity.Instance.GetUnitChoice(HeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID.ToString());
                    Choices.Add(GravitationalLoadQuantity.Instance.ID.ToString(), GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Pound).ID.ToString());
                    Choices.Add(HydraulicConductivityQuantity.Instance.ID.ToString(), HydraulicConductivityQuantity.Instance.GetUnitChoice(HydraulicConductivityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(InterfacialTensionQuantity.Instance.ID.ToString(), InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID.ToString());
                    Choices.Add(VolumeQuantity.Instance.ID.ToString(), VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.USGallon).ID.ToString());
                    Choices.Add(LargeVolumeQuantity.Instance.ID.ToString(), LargeVolumeQuantity.Instance.GetUnitChoice(LargeVolumeQuantity.UnitChoicesEnum.USGallon).ID.ToString());
                    Choices.Add(MagneticFluxDensityQuantity.Instance.ID.ToString(), MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID.ToString());
                    Choices.Add(MassRateQuantity.Instance.ID.ToString(), MassRateQuantity.Instance.GetUnitChoice(MassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(PermeabilityQuantity.Instance.ID.ToString(), PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.MilliDarcy).ID.ToString());
                    Choices.Add(PressureGradientQuantity.Instance.ID.ToString(), PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PSIPerFoot).ID.ToString());
                    Choices.Add(PressureLossConstantQuantity.Instance.ID.ToString(), PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUS).ID.ToString());
                    Choices.Add(ResistivityQuantity.Instance.ID.ToString(), ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMeter).ID.ToString());
                    Choices.Add(FrequencyRateOfChangeQuantity.Instance.ID.ToString(), FrequencyRateOfChangeQuantity.Instance.GetUnitChoice(FrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond).ID.ToString());
                    Choices.Add(RotationFrequencyRateOfChangeQuantity.Instance.ID.ToString(), RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(FluidShearStressQuantity.Instance.ID.ToString(), FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.PoundPer100SquareFoot).ID.ToString());
                    Choices.Add(FluidShearRateQuantity.Instance.ID.ToString(), FluidShearRateQuantity.Instance.GetUnitChoice(FluidShearRateQuantity.UnitChoicesEnum.ReciprocalSecond).ID.ToString());
                    Choices.Add(SpecificHeatCapacityQuantity.Instance.ID.ToString(), SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit).ID.ToString());
                    Choices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.ID.ToString(), SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit).ID.ToString());
                    Choices.Add(TemperatureGradientQuantity.Instance.ID.ToString(), TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot).ID.ToString());
                    Choices.Add(TensionQuantity.Instance.ID.ToString(), TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.PoundForce).ID.ToString());
                    Choices.Add(ThermalConductivityQuantity.Instance.ID.ToString(), ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit).ID.ToString());
                    Choices.Add(MassGradientQuantity.Instance.ID.ToString(), MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID.ToString());
                    Choices.Add(StandardProportionQuantity.Instance.ID.ToString(), StandardProportionQuantity.Instance.GetUnitChoice(StandardProportionQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(StandardDimensionlessQuantity.Instance.ID.ToString(), StandardDimensionlessQuantity.Instance.GetUnitChoice(StandardDimensionlessQuantity.UnitChoicesEnum.Dimensionless).ID.ToString());
                    Choices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.ID.ToString(), ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit).ID.ToString());
                    Choices.Add(TorqueQuantity.Instance.ID.ToString(), TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.FootPound).ID.ToString());
                    Choices.Add(YoungModulusQuantity.Instance.ID.ToString(), YoungModulusQuantity.Instance.GetUnitChoice(YoungModulusQuantity.UnitChoicesEnum.PSI).ID.ToString());
                }
                else if (defaultUnitChoice == UnitChoice.DefaultUnitSetChoiceEnum.Imperial)
                {
                    IsDefault = true;
                    ID = new Guid("0f3f96ae-9b00-42f3-be3a-e0e9f329cb62");
                    Name = "Imperial";
                    Description = "United Kingdom System of Units";

                    Choices.Add(AccelerationQuantity.Instance.ID.ToString(), AccelerationQuantity.Instance.GetUnitChoice(AccelerationQuantity.UnitChoicesEnum.FootPerSecondSquare).ID.ToString());
                    Choices.Add(AmountSubstanceQuantity.Instance.ID.ToString(), AmountSubstanceQuantity.Instance.GetUnitChoice(AmountSubstanceQuantity.UnitChoicesEnum.Mole).ID.ToString());
                    Choices.Add(AngleVariationGradientQuantity.Instance.ID.ToString(), AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID.ToString());
                    Choices.Add(AngularVelocityQuantity.Instance.ID.ToString(), AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID.ToString());
                    Choices.Add(AreaQuantity.Instance.ID.ToString(), AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareFoot).ID.ToString());
                    Choices.Add(CompressibilityQuantity.Instance.ID.ToString(), CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch).ID.ToString());
                    Choices.Add(CurvatureQuantity.Instance.ID.ToString(), CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer100ft).ID.ToString());
                    Choices.Add(DensityGradientDepthQuantity.Instance.ID.ToString(), DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer100Foot).ID.ToString());
                    Choices.Add(DensityGradientTemperatureQuantity.Instance.ID.ToString(), DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFarenheit).ID.ToString());
                    Choices.Add(DensityQuantity.Instance.ID.ToString(), DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUK).ID.ToString());
                    Choices.Add(DensityRateOfChangeQuantity.Instance.ID.ToString(), DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUKPerHour).ID.ToString());
                    Choices.Add(DimensionlessQuantity.Instance.ID.ToString(), DimensionlessQuantity.Instance.GetUnitChoice(DimensionlessQuantity.UnitChoicesEnum.Dimensionless).ID.ToString());
                    Choices.Add(DynamicViscosityQuantity.Instance.ID.ToString(), DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond).ID.ToString());
                    Choices.Add(EarthMagneticFluxDensityQuantity.Instance.ID.ToString(), EarthMagneticFluxDensityQuantity.Instance.GetUnitChoice(EarthMagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID.ToString());
                    Choices.Add(ElectricalCapacitanceQuantity.Instance.ID.ToString(), ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.MicroFarad).ID.ToString());
                    Choices.Add(ElectricCurrentQuantity.Instance.ID.ToString(), ElectricCurrentQuantity.Instance.GetUnitChoice(ElectricCurrentQuantity.UnitChoicesEnum.Ampere).ID.ToString());
                    Choices.Add(ElectricTensionQuantity.Instance.ID.ToString(), ElectricTensionQuantity.Instance.GetUnitChoice(ElectricTensionQuantity.UnitChoicesEnum.Volt).ID.ToString());
                    Choices.Add(ElongationGradientQuantity.Instance.ID.ToString(), ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID.ToString());
                    Choices.Add(EnergyQuantity.Instance.ID.ToString(), EnergyQuantity.Instance.GetUnitChoice(EnergyQuantity.UnitChoicesEnum.Joule).ID.ToString());
                    Choices.Add(ImageScaleQuantity.Instance.ID.ToString(), ImageScaleQuantity.Instance.GetUnitChoice(ImageScaleQuantity.UnitChoicesEnum.DotPerInch).ID.ToString());
                    Choices.Add(LengthQuantity.Instance.ID.ToString(), LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(LuminousIntensityQuantity.Instance.ID.ToString(), LuminousIntensityQuantity.Instance.GetUnitChoice(LuminousIntensityQuantity.UnitChoicesEnum.Candela).ID.ToString());
                    Choices.Add(MassQuantity.Instance.ID.ToString(), MassQuantity.Instance.GetUnitChoice(MassQuantity.UnitChoicesEnum.Pound).ID.ToString());
                    Choices.Add(PlaneAngleQuantity.Instance.ID.ToString(), PlaneAngleQuantity.Instance.GetUnitChoice(PlaneAngleQuantity.UnitChoicesEnum.Degree).ID.ToString());
                    Choices.Add(RelativeTemperatureQuantity.Instance.ID.ToString(), RelativeTemperatureQuantity.Instance.GetUnitChoice(RelativeTemperatureQuantity.UnitChoicesEnum.Rankine).ID.ToString());
                    Choices.Add(SmallLengthQuantity.Instance.ID.ToString(), SmallLengthQuantity.Instance.GetUnitChoice(SmallLengthQuantity.UnitChoicesEnum.Inch_32).ID.ToString());
                    Choices.Add(StandardLengthQuantity.Instance.ID.ToString(), StandardLengthQuantity.Instance.GetUnitChoice(StandardLengthQuantity.UnitChoicesEnum.Feet).ID.ToString());
                    Choices.Add(SolidAngleQuantity.Instance.ID.ToString(), SolidAngleQuantity.Instance.GetUnitChoice(SolidAngleQuantity.UnitChoicesEnum.SquareDegree).ID.ToString());
                    Choices.Add(TemperatureQuantity.Instance.ID.ToString(), TemperatureQuantity.Instance.GetUnitChoice(TemperatureQuantity.UnitChoicesEnum.Fahrenheit).ID.ToString());
                    Choices.Add(TimeQuantity.Instance.ID.ToString(), TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Second).ID.ToString());
                    Choices.Add(PressureQuantity.Instance.ID.ToString(), PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch).ID.ToString());
                    Choices.Add(VolumetricFlowRateQuantity.Instance.ID.ToString(), VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerMinute).ID.ToString());
                    Choices.Add(VolumetricFlowRateOfChangeQuantity.Instance.ID.ToString(), VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.UKGallonPerMinutePerSecond).ID.ToString());
                    Choices.Add(VelocityQuantity.Instance.ID.ToString(), VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(ForceGradientQuantity.Instance.ID.ToString(), ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecaNewtonPerMeter).ID.ToString());
                    Choices.Add(ForceQuantity.Instance.ID.ToString(), ForceQuantity.Instance.GetUnitChoice(ForceQuantity.UnitChoicesEnum.PoundForce).ID.ToString());
                    Choices.Add(MaterialStrengthQuantity.Instance.ID.ToString(), MaterialStrengthQuantity.Instance.GetUnitChoice(MaterialStrengthQuantity.UnitChoicesEnum.PSI).ID.ToString());
                    Choices.Add(FrequencyQuantity.Instance.ID.ToString(), FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz).ID.ToString());
                    Choices.Add(RotationFrequencyQuantity.Instance.ID.ToString(), RotationFrequencyQuantity.Instance.GetUnitChoice(RotationFrequencyQuantity.UnitChoicesEnum.RPM).ID.ToString());
                    Choices.Add(ProportionQuantity.Instance.ID.ToString(), ProportionQuantity.Instance.GetUnitChoice(ProportionQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(HeatTransferCoefficientQuantity.Instance.ID.ToString(), HeatTransferCoefficientQuantity.Instance.GetUnitChoice(HeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit).ID.ToString());
                    Choices.Add(GravitationalLoadQuantity.Instance.ID.ToString(), GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Pound).ID.ToString());
                    Choices.Add(HydraulicConductivityQuantity.Instance.ID.ToString(), HydraulicConductivityQuantity.Instance.GetUnitChoice(HydraulicConductivityQuantity.UnitChoicesEnum.FootPerSecond).ID.ToString());
                    Choices.Add(InterfacialTensionQuantity.Instance.ID.ToString(), InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared).ID.ToString());
                    Choices.Add(VolumeQuantity.Instance.ID.ToString(), VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.UKGallon).ID.ToString());
                    Choices.Add(LargeVolumeQuantity.Instance.ID.ToString(), LargeVolumeQuantity.Instance.GetUnitChoice(LargeVolumeQuantity.UnitChoicesEnum.UKGallon).ID.ToString());
                    Choices.Add(MagneticFluxDensityQuantity.Instance.ID.ToString(), MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Gauss).ID.ToString());
                    Choices.Add(MassRateQuantity.Instance.ID.ToString(), MassRateQuantity.Instance.GetUnitChoice(MassRateQuantity.UnitChoicesEnum.KilogramPerSecond).ID.ToString());
                    Choices.Add(PermeabilityQuantity.Instance.ID.ToString(), PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.MilliDarcy).ID.ToString());
                    Choices.Add(PressureGradientQuantity.Instance.ID.ToString(), PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PSIPerFoot).ID.ToString());
                    Choices.Add(PressureLossConstantQuantity.Instance.ID.ToString(), PressureLossConstantQuantity.Instance.GetUnitChoice(PressureLossConstantQuantity.UnitChoicesEnum.PressureLossConstantUK).ID.ToString());
                    Choices.Add(ResistivityQuantity.Instance.ID.ToString(), ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMeter).ID.ToString());
                    Choices.Add(FrequencyRateOfChangeQuantity.Instance.ID.ToString(), FrequencyRateOfChangeQuantity.Instance.GetUnitChoice(FrequencyRateOfChangeQuantity.UnitChoicesEnum.HertzPerSecond).ID.ToString());
                    Choices.Add(RotationFrequencyRateOfChangeQuantity.Instance.ID.ToString(), RotationFrequencyRateOfChangeQuantity.Instance.GetUnitChoice(RotationFrequencyRateOfChangeQuantity.UnitChoicesEnum.RPMPerSecond).ID.ToString());
                    Choices.Add(FluidShearStressQuantity.Instance.ID.ToString(), FluidShearStressQuantity.Instance.GetUnitChoice(FluidShearStressQuantity.UnitChoicesEnum.PoundPer100SquareFoot).ID.ToString());
                    Choices.Add(FluidShearRateQuantity.Instance.ID.ToString(), FluidShearRateQuantity.Instance.GetUnitChoice(FluidShearRateQuantity.UnitChoicesEnum.ReciprocalSecond).ID.ToString());
                    Choices.Add(SpecificHeatCapacityQuantity.Instance.ID.ToString(), SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheit).ID.ToString());
                    Choices.Add(SpecificHeatCapacityTemperatureGradientQuantity.Instance.ID.ToString(), SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFarenheitPerFarenheit).ID.ToString());
                    Choices.Add(TemperatureGradientQuantity.Instance.ID.ToString(), TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot).ID.ToString());
                    Choices.Add(TensionQuantity.Instance.ID.ToString(), TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.PoundForce).ID.ToString());
                    Choices.Add(ThermalConductivityQuantity.Instance.ID.ToString(), ThermalConductivityQuantity.Instance.GetUnitChoice(ThermalConductivityQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheit).ID.ToString());
                    Choices.Add(MassGradientQuantity.Instance.ID.ToString(), MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID.ToString());
                    Choices.Add(StandardProportionQuantity.Instance.ID.ToString(), StandardProportionQuantity.Instance.GetUnitChoice(StandardProportionQuantity.UnitChoicesEnum.Percent).ID.ToString());
                    Choices.Add(StandardDimensionlessQuantity.Instance.ID.ToString(), StandardDimensionlessQuantity.Instance.GetUnitChoice(StandardDimensionlessQuantity.UnitChoicesEnum.Dimensionless).ID.ToString());
                    Choices.Add(ThermalConductivityTemperatureGradientQuantity.Instance.ID.ToString(), ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFarenheitPerFarenheit).ID.ToString());
                    Choices.Add(TorqueQuantity.Instance.ID.ToString(), TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.FootPound).ID.ToString());
                    Choices.Add(YoungModulusQuantity.Instance.ID.ToString(), YoungModulusQuantity.Instance.GetUnitChoice(YoungModulusQuantity.UnitChoicesEnum.PSI).ID.ToString());
                }
                CheckMissing(quantities);
            }
        }
        protected void CheckMissing(List<PhysicalQuantity> quantities)
        {
            foreach (PhysicalQuantity quantity in quantities)
            {
                if (!Choices.ContainsKey(quantity.ID.ToString()))
                {
                    throw new Exception("missing default unit choice for this physical quantity");
                }
            }
        }
    }
}
