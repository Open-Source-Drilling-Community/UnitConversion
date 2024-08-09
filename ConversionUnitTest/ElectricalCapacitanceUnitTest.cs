using Conversion;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class ElectricalCapacitanceUnitTest
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
            unitVal = ElectricalCapacitanceQuantity.Instance.FromSI(val, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.CoulombPerVolt).ID);
            Assert.AreEqual(1.0 / Factors.Unit, unitVal, 1e-6);
            unitVal = ElectricalCapacitanceQuantity.Instance.FromSI(val, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.Farad).ID);
            Assert.AreEqual(1.0 / Factors.Unit, unitVal, 1e-6);
            unitVal = ElectricalCapacitanceQuantity.Instance.FromSI(val, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.Microfarad).ID);
            Assert.AreEqual(1.0 / Factors.Micro, unitVal, 1e-6);
            unitVal = ElectricalCapacitanceQuantity.Instance.FromSI(val, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.Millifarad).ID);
            Assert.AreEqual(1.0 / Factors.Milli, unitVal, 1e-6);
            unitVal = ElectricalCapacitanceQuantity.Instance.FromSI(val, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.Nanofarad).ID);
            Assert.AreEqual(1.0 / Factors.Nano, unitVal, 1e-6);
            unitVal = ElectricalCapacitanceQuantity.Instance.FromSI(val, ElectricalCapacitanceQuantity.Instance.GetUnitChoice(ElectricalCapacitanceQuantity.UnitChoicesEnum.Picofarad).ID);
            Assert.AreEqual(1.0 / Factors.Pico, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, ElectricalCapacitanceQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(4, ElectricalCapacitanceQuantity.Instance.TimeDimension);
            Assert.AreEqual(-1, ElectricalCapacitanceQuantity.Instance.MassDimension);
            Assert.AreEqual(-2, ElectricalCapacitanceQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, ElectricalCapacitanceQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(2, ElectricalCapacitanceQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, ElectricalCapacitanceQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, ElectricalCapacitanceQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, ElectricalCapacitanceQuantity.Instance.SolidAngleDimension);
        }
    }
}