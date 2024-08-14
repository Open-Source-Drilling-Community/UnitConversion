using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class ThermalConductivityTemperatureGradientUnitTest
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
            unitVal = ThermalConductivityTemperatureGradientQuantity.Instance.FromSI(val, ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared).ID);
            Assert.AreEqual(3.8519288888888887, unitVal, 1e-2);
            unitVal = ThermalConductivityTemperatureGradientQuantity.Instance.FromSI(val, ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourFootDegreeFahrenheitSquared).ID);
            Assert.AreEqual(0.32099405555555555, unitVal, 1e-3);
            unitVal = ThermalConductivityTemperatureGradientQuantity.Instance.FromSI(val, ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerCentimetreSecondDegreeCelsiusSquared).ID);
            Assert.AreEqual(0.00238846, unitVal, 1e-5);
            unitVal = ThermalConductivityTemperatureGradientQuantity.Instance.FromSI(val, ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.CaloriePerMetreSecondDegreeCelsiusSquared).ID);
            Assert.AreEqual(0.238846, unitVal, 1e-3);
            unitVal = ThermalConductivityTemperatureGradientQuantity.Instance.FromSI(val, ThermalConductivityTemperatureGradientQuantity.Instance.GetUnitChoice(ThermalConductivityTemperatureGradientQuantity.UnitChoicesEnum.WattPerMetreKelvinPerKelvin).ID);
            Assert.AreEqual(1, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, ThermalConductivityTemperatureGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-3, ThermalConductivityTemperatureGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, ThermalConductivityTemperatureGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(1, ThermalConductivityTemperatureGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(-2, ThermalConductivityTemperatureGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, ThermalConductivityTemperatureGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, ThermalConductivityTemperatureGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, ThermalConductivityTemperatureGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, ThermalConductivityTemperatureGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}