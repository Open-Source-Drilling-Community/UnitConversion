using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class AngularVelocityUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double val = 1.0;
            double unitVal = AngularVelocityQuantity.Instance.FromSI(val, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.RadianPerSecond).ID);
            Assert.AreEqual(1.0, unitVal, 1e-6);
            unitVal = AngularVelocityQuantity.Instance.FromSI(val, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.RadianPerMinute).ID);
            Assert.AreEqual(60.0, unitVal, 1e-6);
            unitVal = AngularVelocityQuantity.Instance.FromSI(val, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.RadianPerHour).ID);
            Assert.AreEqual(60.0 * 60.0, unitVal, 1e-6);
            unitVal = AngularVelocityQuantity.Instance.FromSI(val, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.RadianPerDay).ID);
            Assert.AreEqual(60.0 * 60.0 * 24.0, unitVal, 1e-6);
            unitVal = AngularVelocityQuantity.Instance.FromSI(val, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond).ID);
            Assert.AreEqual(180.0 / Math.PI, unitVal, 1e-6);
            unitVal = AngularVelocityQuantity.Instance.FromSI(val, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerMinute).ID);
            Assert.AreEqual(180.0 * 60.0 / Math.PI, unitVal, 1e-6);
            unitVal = AngularVelocityQuantity.Instance.FromSI(val, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerHour).ID);
            Assert.AreEqual(180.0 * 60.0 * 60.0 / Math.PI, unitVal, 1e-6);
            unitVal = AngularVelocityQuantity.Instance.FromSI(val, AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerDay).ID);
            Assert.AreEqual(180.0 * 60.0 * 60.0 * 24.0 / Math.PI, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, AngularVelocityQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-1, AngularVelocityQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, AngularVelocityQuantity.Instance.MassDimension);
            Assert.AreEqual(0, AngularVelocityQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, AngularVelocityQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, AngularVelocityQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, AngularVelocityQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, AngularVelocityQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, AngularVelocityQuantity.Instance.SolidAngleDimension);
        }
    }
}