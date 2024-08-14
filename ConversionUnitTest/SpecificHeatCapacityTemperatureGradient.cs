using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class SpecificHeatCapacityTemperatureGradientUnitTest
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
            unitVal = SpecificHeatCapacityTemperatureGradientQuantity.Instance.FromSI(val, SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundSquaredDegreeFahrenheit).ID);
            Assert.AreEqual(0.00013269216666666667, unitVal,1e-6);
            unitVal = SpecificHeatCapacityTemperatureGradientQuantity.Instance.FromSI(val, SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerGramDegreeSquaredCelsius).ID);
            Assert.AreEqual(0.0002388459, unitVal, 1e-6);
            unitVal = SpecificHeatCapacityTemperatureGradientQuantity.Instance.FromSI(val, SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerGramDegreeSquaredCelsius).ID);
            Assert.AreEqual(0.001, unitVal, 1e-6);
            unitVal = SpecificHeatCapacityTemperatureGradientQuantity.Instance.FromSI(val, SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerGramSquaredKelvin).ID);
            Assert.AreEqual(0.001, unitVal, 1e-6);
            unitVal = SpecificHeatCapacityTemperatureGradientQuantity.Instance.FromSI(val, SpecificHeatCapacityTemperatureGradientQuantity.Instance.GetUnitChoice(SpecificHeatCapacityTemperatureGradientQuantity.UnitChoicesEnum.JoulePerKilogramSquaredKelvin).ID);
            Assert.AreEqual(1, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, SpecificHeatCapacityTemperatureGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-2, SpecificHeatCapacityTemperatureGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, SpecificHeatCapacityTemperatureGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(2, SpecificHeatCapacityTemperatureGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(-2, SpecificHeatCapacityTemperatureGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, SpecificHeatCapacityTemperatureGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, SpecificHeatCapacityTemperatureGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, SpecificHeatCapacityTemperatureGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, SpecificHeatCapacityTemperatureGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}