using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using System.Globalization;

namespace OSDC.UnitConversion.ModelTest
{
    public class Tests
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [Test]
        public void Test_General_BasePhysicalQuantity()
        {
            #region availability of BasePhysicalQuantities
            List<BasePhysicalQuantity> quantityList = BasePhysicalQuantity.AvailableBasePhysicalQuantities;
            Assert.That(quantityList, Is.Not.Null);
            #endregion

            #region uniqueness of BasePhysicalQuantities
            Assert.That(quantityList.Count, Is.EqualTo(78));
            Assert.That(quantityList, Does.Contain(AccelerationQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AmountSubstanceQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AngleMagneticFluxDensityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AngleVariationGradientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AngularVelocityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AreaQuantity.Instance));
            Assert.That(quantityList, Does.Contain(CompressibilityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(CurvatureQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DensityGradientDepthQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DensityGradientTemperatureQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DensityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DensityRateOfChangeQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DimensionlessQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DynamicViscosityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(EarthMagneticFluxDensityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ElectricalCapacitanceQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ElectricCurrentQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ElectricTensionQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ElongationGradientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(EnergyQuantity.Instance));
            Assert.That(quantityList, Does.Contain(FluidShearRateQuantity.Instance));
            Assert.That(quantityList, Does.Contain(FluidShearStressQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ForceGradientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ForceQuantity.Instance));
            Assert.That(quantityList, Does.Contain(FrequencyQuantity.Instance));
            Assert.That(quantityList, Does.Contain(FrequencyRateOfChangeQuantity.Instance));
            Assert.That(quantityList, Does.Contain(GravitationalLoadQuantity.Instance));
            Assert.That(quantityList, Does.Contain(HeatTransferCoefficientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(HydraulicConductivityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ImageScaleQuantity.Instance));
            Assert.That(quantityList, Does.Contain(InterfacialTensionQuantity.Instance));
            Assert.That(quantityList, Does.Contain(LargeVolumeQuantity.Instance));
            Assert.That(quantityList, Does.Contain(LengthQuantity.Instance));
            Assert.That(quantityList, Does.Contain(LuminousIntensityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MagneticFluxDensityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MagneticFluxQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MassGradientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MassQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MassRateQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MaterialStrengthQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PermeabilityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PlaneAngleQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PorosityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PowerQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PressureGradientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PressureLossConstantQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PressureQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ProportionQuantity.Instance));
            Assert.That(quantityList, Does.Contain(RandomWalkQuantity.Instance));
            Assert.That(quantityList, Does.Contain(RelativeTemperatureQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ResistivityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(RheologyConsistencyIndexQuantity.Instance));
            Assert.That(quantityList, Does.Contain(RotationFrequencyQuantity.Instance));
            Assert.That(quantityList, Does.Contain(RotationFrequencyRateOfChangeQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SmallDiameterQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SmallLengthQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SmallProportionQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SmallRotationFrequencyQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SmallTorqueQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SolidAngleQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SpecificHeatCapacityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SpecificHeatCapacityTemperatureGradientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(StandardDimensionlessQuantity.Instance));
            Assert.That(quantityList, Does.Contain(StandardLengthQuantity.Instance));
            Assert.That(quantityList, Does.Contain(StandardProportionQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TemperatureGradientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TemperatureQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TensionQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ThermalConductivityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ThermalConductivityTemperatureGradientQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TimeQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TorqueQuantity.Instance));
            Assert.That(quantityList, Does.Contain(VelocityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(VolumeQuantity.Instance));
            Assert.That(quantityList, Does.Contain(VolumetricFlowRateOfChangeQuantity.Instance));
            Assert.That(quantityList, Does.Contain(VolumetricFlowRateQuantity.Instance));
            Assert.That(quantityList, Does.Contain(WaveNumberQuantity.Instance));
            Assert.That(quantityList, Does.Contain(YoungModulusQuantity.Instance));
            #endregion
        }

        [Test]
        public void Test_General_PhysicalQuantity()
        {
            #region availability of PhysicalQuantities
            List<BasePhysicalQuantity> quantityList = PhysicalQuantity.AvailablePhysicalQuantities;
            Assert.That(quantityList, Is.Not.Null);
            #endregion

            #region uniqueness of PhysicalQuantities
            Assert.That(quantityList.Count, Is.EqualTo(66));
            Assert.That(quantityList, Does.Contain(AccelerationDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AngleVariationGradientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AngularVelocityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AreaDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(AxialVelocityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(BlockVelocityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(CableDiameterQuantity.Instance));
            Assert.That(quantityList, Does.Contain(CapillaryPressureQuantity.Instance));
            Assert.That(quantityList, Does.Contain(CompressibilityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(CurvatureDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DensityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DensityGradientDepthDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DensityGradientTemperatureDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DensityRateOfChangeDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DepthQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DrillStemMaterialStrengthQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DrillStringMagneticFluxDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DurationDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(DynamicViscosityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ElongationGradientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(FluidVelocityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ForceDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ForceGradientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(FormationResistivityQuantity.Instance));
            Assert.That(quantityList, Does.Contain(FormationStrengthQuantity.Instance));
            Assert.That(quantityList, Does.Contain(GammaRayQuantity.Instance));
            Assert.That(quantityList, Does.Contain(GasShowQuantity.Instance));
            Assert.That(quantityList, Does.Contain(GasVolumetricFlowRateQuantity.Instance));
            Assert.That(quantityList, Does.Contain(HeatTransferCoefficientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(HeightQuantity.Instance));
            Assert.That(quantityList, Does.Contain(HookLoadQuantity.Instance));
            Assert.That(quantityList, Does.Contain(HydraulicConductivityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(InterfacialTensionDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MassDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MassGradientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(MassRateDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(NozzleDiameterQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PipeDiameterQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PlaneAngleDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PoreDiameterQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PoreSurfaceQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PositionQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PowerDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PressureDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PressureGradientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(PressureLossConstantDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(RandomWalkDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(RateOfPenetrationQuantity.Instance));
            Assert.That(quantityList, Does.Contain(RotationFrequencyRateOfChangeDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ShockRateQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SpecificHeatCapacityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SpecificHeatCapacityTemperatureGradientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(StickDurationDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SurveyInstrumentAngularVelocityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(SurveyInstrumentReciprocalLengthDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TemperatureDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TemperatureGradientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TensionDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ThermalConductivityDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(ThermalConductivityTemperatureGradientDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(TorqueDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(VolumeDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(VolumetricFlowrateDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(VolumetricFlowRateOfChangeDrillingQuantity.Instance));
            Assert.That(quantityList, Does.Contain(WeightOnBitQuantity.Instance));

            #endregion
        }

        [Test]
        public void Test_Calculus_LengthQuantity()
        {
            List<string> choices = LengthQuantity.Instance.GetUnitChoiceNames();
            double actual = LengthQuantity.Instance.ToSI(1.0, "feet");
            Assert.That(actual, Is.EqualTo(0.3048));

            string actualStr = LengthQuantity.Instance.ToSIString(1.0, "feet");
            string expected = 0.3048.ToString(CultureInfo.InvariantCulture.NumberFormat);
            Assert.That(actualStr, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Calculus_DepthQuantity()
        {
            List<string> choices = DepthQuantity.Instance.GetUnitChoiceNames();
            string actualStr = DepthQuantity.Instance.ToSIString(1.0, "feet");
            string expected = 0.305.ToString(CultureInfo.InvariantCulture.NumberFormat);
            Assert.That(actualStr, Is.EqualTo(expected));
        }
        [Test]
        public void Test_Calculus_PipeDiameterQuantity()
        {
            List<string> choices = PipeDiameterQuantity.Instance.GetUnitChoiceNames();
            string actualStr = PipeDiameterQuantity.Instance.ToSIString(1.0, "inch");
            string expected = 0.0254.ToString(CultureInfo.InvariantCulture.NumberFormat);
            Assert.That(actualStr, Is.EqualTo(expected));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }
    }
}