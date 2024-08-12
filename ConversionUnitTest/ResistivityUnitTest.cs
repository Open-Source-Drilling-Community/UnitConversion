using Conversion;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class ResistivityUnitTest
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
            unitVal = ResistivityQuantity.Instance.FromSI(val, ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.OhmMetre).ID);
            Assert.AreEqual(1.0 / Factors.Unit, unitVal);
            unitVal = ResistivityQuantity.Instance.FromSI(val, ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.GigaOhmMetre).ID);
            Assert.AreEqual(1.0 / Factors.Giga, unitVal);
            unitVal = ResistivityQuantity.Instance.FromSI(val, ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.KiloOhmMetre).ID);
            Assert.AreEqual(1.0 / Factors.Kilo, unitVal);
            unitVal = ResistivityQuantity.Instance.FromSI(val, ResistivityQuantity.Instance.GetUnitChoice(ResistivityQuantity.UnitChoicesEnum.MegaOhmMetre).ID);
            Assert.AreEqual(1.0 / Factors.Mega, unitVal);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, ResistivityQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-3, ResistivityQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, ResistivityQuantity.Instance.MassDimension);
            Assert.AreEqual(3, ResistivityQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, ResistivityQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(-2, ResistivityQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, ResistivityQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, ResistivityQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, ResistivityQuantity.Instance.SolidAngleDimension);
        }
    }
}