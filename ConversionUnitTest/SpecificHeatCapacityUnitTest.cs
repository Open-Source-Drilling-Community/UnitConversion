using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class SpecificHeatCapacityUnitTest
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
            unitVal = SpecificHeatCapacityQuantity.Instance.FromSI(val, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundDegreeFahrenheit).ID);
            Assert.AreEqual(0.0002388459, unitVal, 1e-5);
            unitVal = SpecificHeatCapacityQuantity.Instance.FromSI(val, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.CaloriePerGramDegreeCelsius).ID);
            Assert.AreEqual(0.000239005736, unitVal, 1e-5);
            unitVal = SpecificHeatCapacityQuantity.Instance.FromSI(val, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerGramDegreeCelsius).ID);
            Assert.AreEqual(0.001, unitVal, 1e-5);
            unitVal = SpecificHeatCapacityQuantity.Instance.FromSI(val, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerGramKelvin).ID);
            Assert.AreEqual(0.001, unitVal, 1e-5);
            unitVal = SpecificHeatCapacityQuantity.Instance.FromSI(val, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.JoulePerKilogramKelvin).ID);
            Assert.AreEqual(1, unitVal, 1e-5);
            unitVal = SpecificHeatCapacityQuantity.Instance.FromSI(val, SpecificHeatCapacityQuantity.Instance.GetUnitChoice(SpecificHeatCapacityQuantity.UnitChoicesEnum.KilocaloriePerGramDegreeCelsius).ID);
            Assert.AreEqual(0.000000239005736, unitVal, 1e-10);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, SpecificHeatCapacityQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-2, SpecificHeatCapacityQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, SpecificHeatCapacityQuantity.Instance.MassDimension);
            Assert.AreEqual(2, SpecificHeatCapacityQuantity.Instance.LengthDimension);
            Assert.AreEqual(-1, SpecificHeatCapacityQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, SpecificHeatCapacityQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, SpecificHeatCapacityQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, SpecificHeatCapacityQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, SpecificHeatCapacityQuantity.Instance.SolidAngleDimension);
        }
    }
}