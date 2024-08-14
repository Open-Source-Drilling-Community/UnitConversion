using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class TemperatureGradientUnitTest
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
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Foot).ID);
            Assert.AreEqual(100.0*Factors.Foot / Factors.Unit, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer100Metre).ID);
            Assert.AreEqual(100.0 / Factors.Unit, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer10Metre).ID);
            Assert.AreEqual(10.0 / Factors.Unit, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPer30Foot).ID);
            Assert.AreEqual(30.0 * Factors.Foot / Factors.Unit, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPerFoot).ID);
            Assert.AreEqual(Factors.Foot / Factors.Unit, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.CelsiusPerMetre).ID);
            Assert.AreEqual(1 / Factors.Unit, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer100Foot).ID);
            Assert.AreEqual(100.0 * Factors.Foot / Factors.FahrenheitSlope, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPer30Foot).ID);
            Assert.AreEqual(30.0 * Factors.Foot / Factors.FahrenheitSlope, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.FahrenheitPerFoot).ID);
            Assert.AreEqual(Factors.Foot / Factors.FahrenheitSlope, unitVal);
            unitVal = TemperatureGradientQuantity.Instance.FromSI(val, TemperatureGradientQuantity.Instance.GetUnitChoice(TemperatureGradientQuantity.UnitChoicesEnum.KelvinPerMetre).ID);
            Assert.AreEqual(1 / Factors.Unit, unitVal);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, TemperatureGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(0, TemperatureGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, TemperatureGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(-1, TemperatureGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(1, TemperatureGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, TemperatureGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, TemperatureGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, TemperatureGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, TemperatureGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}