using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class DensityGradientTemperatureUnitTest
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
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.GramPerCubicCentimetrePerCelsius).ID);
            Assert.AreEqual(0.001, unitVal,1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.KilogramPerCubicMetrePerKelvin).ID);
            Assert.AreEqual(1.0, unitVal, 1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerCubicFootPerCelsius).ID);
            Assert.AreEqual(0.062427962, unitVal, 1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerCubicFootPerFahrenheit).ID);
            Assert.AreEqual(0.034685, unitVal, 1e-5);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerCubicInchPerCelsius).ID);
            Assert.AreEqual(3.6127292e-5, unitVal, 1e-8);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerCubicInchPerFahrenheit).ID);
            Assert.AreEqual(2.007e-5, unitVal, 1e-8);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerCubicYardPerCelsius).ID);
            Assert.AreEqual(1.685555, unitVal, 1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerCubicYeardPerFahrenheit).ID);
            Assert.AreEqual(0.936419, unitVal, 1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUKPerCelsius).ID);
            Assert.AreEqual(0.0100224129, unitVal, 1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUKPerFahrenheit).ID);
            Assert.AreEqual(0.005568, unitVal, 1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerCelsius).ID);
            Assert.AreEqual(0.00834543421, unitVal, 1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.PoundPerGallonUSPerFahrenheit).ID);
            Assert.AreEqual(0.00463635, unitVal, 1e-6);
            unitVal = DensityGradientTemperatureQuantity.Instance.FromSI(val, DensityGradientTemperatureQuantity.Instance.GetUnitChoice(DensityGradientTemperatureQuantity.UnitChoicesEnum.SpecificGravityPerCelsius).ID);
            Assert.AreEqual(0.001, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, DensityGradientTemperatureQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(0, DensityGradientTemperatureQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, DensityGradientTemperatureQuantity.Instance.MassDimension);
            Assert.AreEqual(-3, DensityGradientTemperatureQuantity.Instance.LengthDimension);
            Assert.AreEqual(-1, DensityGradientTemperatureQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, DensityGradientTemperatureQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, DensityGradientTemperatureQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, DensityGradientTemperatureQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, DensityGradientTemperatureQuantity.Instance.SolidAngleDimension);
        }
    }
}