using Conversion;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class ElongationGradientUnitTest
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
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.CentimetrePerKilometre).ID);
            Assert.AreEqual(100000.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.CentimetrePerMetre).ID);
            Assert.AreEqual(100.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.DecimetrePerKilometre).ID);
            Assert.AreEqual(10000.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.DecimetrePerMetre).ID);
            Assert.AreEqual(10.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.FootPerFoot).ID);
            Assert.AreEqual(1.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.FootPerMile).ID);
            Assert.AreEqual(5280, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.FootPerYard).ID);
            Assert.AreEqual(3, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerFoot).ID);
            Assert.AreEqual(12, unitVal, 1e-6);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerMile).ID);
            Assert.AreEqual(63360, unitVal, 1e-6);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerYard).ID);
            Assert.AreEqual(36.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MetrePerKilometre).ID);
            Assert.AreEqual(1000.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MetrePerMetre).ID);
            Assert.AreEqual(1.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MicrometrePerKilometre).ID);
            Assert.AreEqual(1e9, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MicrometrePerMetre).ID);
            Assert.AreEqual(1e6, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MillimetrePerKilometre).ID);
            Assert.AreEqual(1e6, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MillimetrePerMetre).ID);
            Assert.AreEqual(1000.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.YardPerFoot).ID);
            Assert.AreEqual(1.0/3.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.YardPerMile).ID);
            Assert.AreEqual(1760.0, unitVal);
            unitVal = ElongationGradientQuantity.Instance.FromSI(val, ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.YardPerYard).ID);
            Assert.AreEqual(1.0, unitVal);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, ElongationGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}