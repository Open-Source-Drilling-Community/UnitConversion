using Conversion;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class MassGradientUnitTest
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
            unitVal = MassGradientQuantity.Instance.FromSI(val, MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.GramPerMetre).ID);
            Assert.AreEqual(1000, unitVal);
            unitVal = MassGradientQuantity.Instance.FromSI(val, MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.KilogramPerMetre).ID);
            Assert.AreEqual(1, unitVal);
            unitVal = MassGradientQuantity.Instance.FromSI(val, MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID);
            Assert.AreEqual(0.6719689753966845, unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, MassGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(0, MassGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, MassGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(-1, MassGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, MassGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, MassGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, MassGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, MassGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, MassGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}