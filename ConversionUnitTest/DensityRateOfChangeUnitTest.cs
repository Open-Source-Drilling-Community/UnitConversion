using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class DensityRateOfChangeUnitTest
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
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.GramPerCubicCentimetrePerHour).ID);
            Assert.AreEqual(3.6, unitVal);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.GramPerCubicCentimetrePerMinute).ID);
            Assert.AreEqual(0.06, unitVal);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.GramPerCubicCentimetrePerSecond).ID);
            Assert.AreEqual(0.001, unitVal);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.KilogramPerCubicMetrePerSecond).ID);
            Assert.AreEqual(1.0, unitVal);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUKPerHour).ID);
            Assert.AreEqual(36.1, unitVal, 1e-1);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUKPerMinute).ID);
            Assert.AreEqual(0.60, unitVal, 1e-2);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUKPerSecond).ID);
            Assert.AreEqual(0.01, unitVal, 1e-3);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUSPerHour).ID);
            Assert.AreEqual(30.0, unitVal, 1e-1);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUSPerMinute).ID);
            Assert.AreEqual(0.50, unitVal, 1e-2);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUSPerSecond).ID);
            Assert.AreEqual(0.008344, unitVal, 1e-3);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.SpecificGravityPerHour).ID);
            Assert.AreEqual(3.6, unitVal, 1e-1);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.SpecificGravityPerMinute).ID);
            Assert.AreEqual(0.06, unitVal, 1e-3);
            unitVal = DensityRateOfChangeQuantity.Instance.FromSI(val, DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.SpecificGravityPerSecond).ID);
            Assert.AreEqual(0.001, unitVal, 1e-4);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, DensityRateOfChangeQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-1, DensityRateOfChangeQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, DensityRateOfChangeQuantity.Instance.MassDimension);
            Assert.AreEqual(-3, DensityRateOfChangeQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, DensityRateOfChangeQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, DensityRateOfChangeQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, DensityRateOfChangeQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, DensityRateOfChangeQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, DensityRateOfChangeQuantity.Instance.SolidAngleDimension);
        }
    }
}