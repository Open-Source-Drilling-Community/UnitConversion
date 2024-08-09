using Conversion;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class AngleVariationGradientUnitTest
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
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerCentimetre).ID);
            Assert.AreEqual(Factors.Degree * Factors.Centi, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerDecimetre).ID);
            Assert.AreEqual(Factors.Degree * Factors.Deci, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot).ID);
            Assert.AreEqual(Factors.Degree * Factors.Foot, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerInch).ID);
            Assert.AreEqual(Factors.Degree * Factors.Inch, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerMetre).ID);
            Assert.AreEqual(Factors.Degree * Factors.Unit, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerMillimetre).ID);
            Assert.AreEqual(Factors.Degree * Factors.Milli, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.RadianPerCentimetre).ID);
            Assert.AreEqual(Factors.Unit * Factors.Centi, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.RadianPerDecimetre).ID);
            Assert.AreEqual(Factors.Unit * Factors.Deci, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.RadianPerMetre).ID);
            Assert.AreEqual(Factors.Unit * Factors.Unit, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.RadianPerMillimetre).ID);
            Assert.AreEqual(Factors.Unit * Factors.Milli, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.RadianPerFoot).ID);
            Assert.AreEqual(Factors.Unit * Factors.Foot, unitVal);
            unitVal = AngleVariationGradientQuantity.Instance.FromSI(val, AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.RadianPerInch).ID);
            Assert.AreEqual(Factors.Unit * Factors.Inch, unitVal);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, AngleVariationGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(0, AngleVariationGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(0, AngleVariationGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(-1, AngleVariationGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, AngleVariationGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, AngleVariationGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, AngleVariationGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, AngleVariationGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, AngleVariationGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}