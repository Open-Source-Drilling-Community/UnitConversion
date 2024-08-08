using Conversion;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class DensityUnitTest
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
            unitVal = DensityQuantity.Instance.FromSI(val, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.GramPerCubicCentimetre).ID);
            Assert.AreEqual(0.001, unitVal, 1e-6);
            unitVal = DensityQuantity.Instance.FromSI(val, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.GramPerCubicMetre).ID);
            Assert.AreEqual(1000, unitVal, 1e-6);
            unitVal = DensityQuantity.Instance.FromSI(val, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.KilogramPerCubicMetre).ID);
            Assert.AreEqual(1.0, unitVal, 1e-6);
            unitVal = DensityQuantity.Instance.FromSI(val, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerCubicFoot).ID);
            Assert.AreEqual(0.062427962, unitVal, 1e-6);
            unitVal = DensityQuantity.Instance.FromSI(val, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerCubicInch).ID);
            Assert.AreEqual(3.6127292e-5, unitVal, 1e-8);
            unitVal = DensityQuantity.Instance.FromSI(val, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerCubicYard).ID);
            Assert.AreEqual(1.685555, unitVal, 1e-6);
            unitVal = DensityQuantity.Instance.FromSI(val, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUK).ID);
            Assert.AreEqual(0.0100224129, unitVal, 1e-6);
            unitVal = DensityQuantity.Instance.FromSI(val, DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUS).ID);
            Assert.AreEqual(0.00834543421, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, DensityQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(0, DensityQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, DensityQuantity.Instance.MassDimension);
            Assert.AreEqual(-3, DensityQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, DensityQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, DensityQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, DensityQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, DensityQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, DensityQuantity.Instance.SolidAngleDimension);
        }
    }
}