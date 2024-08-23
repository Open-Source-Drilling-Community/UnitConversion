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
            unitVal = SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.FromSI(val, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.BritishThermalUnitPerPoundSquaredDegreeFahrenheit).ID);
            Assert.AreEqual(0.00013269216666666667, unitVal,1e-6);
            unitVal = SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.FromSI(val, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.CaloriePerGramDegreeSquaredCelsius).ID);
            Assert.AreEqual(0.0002388459, unitVal, 1e-6);
            unitVal = SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.FromSI(val, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.JoulePerGramDegreeSquaredCelsius).ID);
            Assert.AreEqual(0.001, unitVal, 1e-6);
            unitVal = SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.FromSI(val, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.JoulePerGramSquaredKelvin).ID);
            Assert.AreEqual(0.001, unitVal, 1e-6);
            unitVal = SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.FromSI(val, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.GetUnitChoice(SpecificHeatCapacityGradientPerTemperatureQuantity.UnitChoicesEnum.JoulePerKilogramSquaredKelvin).ID);
            Assert.AreEqual(1, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-2, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.MassDimension);
            Assert.AreEqual(2, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.LengthDimension);
            Assert.AreEqual(-2, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, SpecificHeatCapacityGradientPerTemperatureQuantity.Instance.SolidAngleDimension);
        }
    }
}