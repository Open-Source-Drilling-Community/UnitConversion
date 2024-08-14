using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class PressureGradientUnitTest
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
            unitVal = PressureGradientQuantity.Instance.FromSI(val, PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.BarPerMetre).ID);
            Assert.AreEqual(1E-05, unitVal);
            unitVal = PressureGradientQuantity.Instance.FromSI(val, PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PascalPerMetre).ID);
            Assert.AreEqual(1, unitVal);
            unitVal = PressureGradientQuantity.Instance.FromSI(val, PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PsiPerFoot).ID);
            Assert.AreEqual(4.4207468542442094E-05, unitVal, 1e-8);
            unitVal = PressureGradientQuantity.Instance.FromSI(val, PressureGradientQuantity.Instance.GetUnitChoice(PressureGradientQuantity.UnitChoicesEnum.PsiPerMetre).ID);
            Assert.AreEqual(0.00014503762645158165, unitVal, 1e-8);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, PressureGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-2, PressureGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, PressureGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(-2, PressureGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, PressureGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, PressureGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, PressureGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, PressureGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, PressureGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}