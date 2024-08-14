using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class FrequencyUnitTest
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
            unitVal = FrequencyQuantity.Instance.FromSI(val, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Gigahertz).ID);
            Assert.AreEqual(1.0 / Factors.Giga, unitVal);
            unitVal = FrequencyQuantity.Instance.FromSI(val, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Hertz).ID);
            Assert.AreEqual(1.0 / Factors.Unit, unitVal);
            unitVal = FrequencyQuantity.Instance.FromSI(val, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Kilohertz).ID);
            Assert.AreEqual(1.0 / Factors.Kilo, unitVal);
            unitVal = FrequencyQuantity.Instance.FromSI(val, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Megahertz).ID);
            Assert.AreEqual(1.0 / Factors.Mega, unitVal);
            unitVal = FrequencyQuantity.Instance.FromSI(val, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.ReciprocalSecond).ID);
            Assert.AreEqual(1.0 / Factors.Unit, unitVal);
            unitVal = FrequencyQuantity.Instance.FromSI(val, FrequencyQuantity.Instance.GetUnitChoice(FrequencyQuantity.UnitChoicesEnum.Terahertz).ID);
            Assert.AreEqual(1.0 / Factors.Tera, unitVal);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, FrequencyQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-1, FrequencyQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, FrequencyQuantity.Instance.MassDimension);
            Assert.AreEqual(0, FrequencyQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, FrequencyQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, FrequencyQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, FrequencyQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, FrequencyQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, FrequencyQuantity.Instance.SolidAngleDimension);
        }
    }
}