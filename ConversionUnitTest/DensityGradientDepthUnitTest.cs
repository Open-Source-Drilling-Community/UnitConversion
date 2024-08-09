using Conversion;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class DensityGradientDepthUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double val = 1.0;
            double unitVal;
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.GramPerCubicCentimetrePer100Metre).ID);
            Assert.AreEqual(0.1, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.GramPerCubicCentimetrePer10Metre).ID);
            Assert.AreEqual(0.01, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.GramPerCubicCentimetrePer30Metre).ID);
            Assert.AreEqual(30.0/1000.0, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.GramPerCubicCentimetrePerMetre).ID);
            Assert.AreEqual(0.001, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.KilogramPerCubicMetrePer100Metre).ID);
            Assert.AreEqual(100.0, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.KilogramPerCubicMetrePer10Metre).ID);
            Assert.AreEqual(10.0, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.KilogramPerCubicMetrePer30Metre).ID);
            Assert.AreEqual(30.0, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.KilogramPerCubicMetrePerMetre).ID);
            Assert.AreEqual(1.0, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicFootPer100Foot).ID);
            Assert.AreEqual(1.899, unitVal, 1e-2);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicFootPer30Foot).ID);
            Assert.AreEqual(0.57, unitVal, 1e-2);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicFootPerFoot).ID);
            Assert.AreEqual(0.019, unitVal, 1e-3);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicInchPer100Foot).ID);
            Assert.AreEqual(0.0011011, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicInchPer30Foot).ID);
            Assert.AreEqual(0.00033035, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicInchPerFoot).ID);
            Assert.AreEqual(0.000011011, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicYardPer100Foot).ID);
            Assert.AreEqual(51.37598, unitVal, 1e-3);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicYardPer30Foot).ID);
            Assert.AreEqual(15.41279, unitVal, 1e-3);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerCubicYardPerFoot).ID);
            Assert.AreEqual(0.51375, unitVal, 1e-3);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer100Foot).ID);
            Assert.AreEqual(0.305484, unitVal, 1e-4);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer30Foot).ID);
            Assert.AreEqual(0.091645, unitVal, 1e-4);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPerFoot).ID);
            Assert.AreEqual(0.003054, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer100Foot).ID);
            Assert.AreEqual(0.25437, unitVal, 1e-4);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer30Foot).ID);
            Assert.AreEqual(0.07631, unitVal, 1e-5);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPerFoot).ID);
            Assert.AreEqual(0.0025436, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer100Metre).ID);
            Assert.AreEqual(0.1, unitVal, 1e-4);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer10Metre).ID);
            Assert.AreEqual(0.01, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer30Metre).ID);
            Assert.AreEqual(0.03, unitVal, 1e-6);
            unitVal = DensityGradientDepthQuantity.Instance.FromSI(val, DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPerMetre).ID);
            Assert.AreEqual(0.001, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, DensityGradientDepthQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(0, DensityGradientDepthQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, DensityGradientDepthQuantity.Instance.MassDimension);
            Assert.AreEqual(-4, DensityGradientDepthQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, DensityGradientDepthQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, DensityGradientDepthQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, DensityGradientDepthQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, DensityGradientDepthQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, DensityGradientDepthQuantity.Instance.SolidAngleDimension);
        }
    }
}