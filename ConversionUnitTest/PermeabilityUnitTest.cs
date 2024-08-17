using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class PermeabilityUnitTest
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
            unitVal = PermeabilityQuantity.Instance.FromSI(val, PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.Darcy).ID);
            Assert.AreEqual(1013249965828.14, unitVal, 1e5);
            unitVal = PermeabilityQuantity.Instance.FromSI(val, PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.Microdarcy).ID);
            Assert.AreEqual(1013249965828140000.0, unitVal, 1e11);
            unitVal = PermeabilityQuantity.Instance.FromSI(val, PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.Millidarcy).ID);
            Assert.AreEqual(1013249965828140.0, unitVal, 1e8);
            unitVal = PermeabilityQuantity.Instance.FromSI(val, PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.Nanodarcy).ID);
            Assert.AreEqual(1013249965828140000000.0, unitVal, 1e14);
            unitVal = PermeabilityQuantity.Instance.FromSI(val, PermeabilityQuantity.Instance.GetUnitChoice(PermeabilityQuantity.UnitChoicesEnum.SquareMetre).ID);
            Assert.AreEqual(1, unitVal);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, PermeabilityQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(0, PermeabilityQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, PermeabilityQuantity.Instance.MassDimension);
            Assert.AreEqual(2, PermeabilityQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, PermeabilityQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, PermeabilityQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, PermeabilityQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, PermeabilityQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, PermeabilityQuantity.Instance.SolidAngleDimension);
        }
    }
}