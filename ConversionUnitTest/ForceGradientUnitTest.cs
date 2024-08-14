using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class ForceGradientUnitTest
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
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecanewtonPer10Metre).ID);
            Assert.AreEqual(10.0 / Factors.Deca, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecanewtonPer30Metre).ID);
            Assert.AreEqual(30.0 / Factors.Deca, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecanewtonPerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / Factors.Deca, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecanewtonPerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / Factors.Deca, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecanewtonPerMetre).ID);
            Assert.AreEqual(Factors.Unit / Factors.Deca, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecanewtonPerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / Factors.Deca, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.KilonewtonPer10Metre).ID);
            Assert.AreEqual(Factors.Deca / Factors.Kilo, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.KilonewtonPer30Metre).ID);
            Assert.AreEqual(3 * Factors.Deca / Factors.Kilo, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.KilonewtonPerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / Factors.Kilo, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.KilonewtonPerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / Factors.Kilo, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.KilonewtonPerMetre).ID);
            Assert.AreEqual(Factors.Unit / Factors.Kilo, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.KilonewtonPerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / Factors.Kilo, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.KilopoundPerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Kilo * Factors.PoundForce), unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.KilopoundPerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Kilo * Factors.PoundForce), unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPer10Metre).ID);
            Assert.AreEqual(Factors.Deca / Factors.Unit, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPer30Metre).ID);
            Assert.AreEqual(3*Factors.Deca / Factors.Unit, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / Factors.Unit, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / Factors.Unit, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPerMetre).ID);
            Assert.AreEqual(1, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / Factors.Unit, unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.PoundPerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.PoundForce), unitVal);
            unitVal = ForceGradientQuantity.Instance.FromSI(val, ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.PoundPerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.PoundForce), unitVal);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, ForceGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-2, ForceGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, ForceGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(0, ForceGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, ForceGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, ForceGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, ForceGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, ForceGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, ForceGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}