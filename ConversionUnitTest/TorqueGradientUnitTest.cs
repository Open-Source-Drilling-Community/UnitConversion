using Conversion;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest
{
    public class TorqueGradientUnitTest
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
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.DecanewtonMetrePerCentimetre).ID);
            Assert.AreEqual(Factors.Centi/ (Factors.Deca), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.DecanewtonMetrePerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Deca), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.DecanewtonMetrePerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Deca), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.DecanewtonMetrePerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Deca), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.DecanewtonMetrePerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Deca), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.DecanewtonMetrePerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Deca), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.FootPoundPerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Foot*Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.FootPoundPerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Foot * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.FootPoundPerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Foot * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.FootPoundPerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Foot * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.FootPoundPerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Foot * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.FootPoundPerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Foot * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.InchPoundPerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Inch * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.InchPoundPerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Inch * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.InchPoundPerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Inch * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.InchPoundPerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Inch * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.InchPoundPerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Inch * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.InchPoundPerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Inch * Factors.PoundForce), unitVal);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilofootPoundPerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Kilo*Factors.Foot * Factors.PoundForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilofootPoundPerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Kilo * Factors.Foot * Factors.PoundForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilofootPoundPerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Kilo * Factors.Foot * Factors.PoundForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilofootPoundPerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Kilo * Factors.Foot * Factors.PoundForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilofootPoundPerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Kilo * Factors.Foot * Factors.PoundForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilofootPoundPerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Kilo * Factors.Foot * Factors.PoundForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilogramForceMetrePerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Unit * Factors.KilogramForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilogramForceMetrePerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Unit * Factors.KilogramForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilogramForceMetrePerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Unit * Factors.KilogramForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilogramForceMetrePerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Unit * Factors.KilogramForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilogramForceMetrePerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Unit * Factors.KilogramForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilogramForceMetrePerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Unit * Factors.KilogramForce), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilonewtonMetrePerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Kilo * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilonewtonMetrePerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Kilo * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilonewtonMetrePerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Kilo * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilonewtonMetrePerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Kilo * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilonewtonMetrePerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Kilo * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.KilonewtonMetrePerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Kilo * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonCentimetrePerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Unit * Factors.Centi), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonCentimetrePerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Unit * Factors.Centi), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonCentimetrePerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Unit * Factors.Centi), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonCentimetrePerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Unit * Factors.Centi), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonCentimetrePerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Unit * Factors.Centi), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonCentimetrePerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Unit * Factors.Centi), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonDecimetrePerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Unit * Factors.Deci), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonDecimetrePerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Unit * Factors.Deci), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonDecimetrePerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Unit * Factors.Deci), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonDecimetrePerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Unit * Factors.Deci), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonDecimetrePerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Unit * Factors.Deci), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonDecimetrePerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Unit * Factors.Deci), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMetrePerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Unit * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMetrePerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Unit * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMetrePerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Unit * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMetrePerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Unit * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMetrePerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Unit * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMetrePerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Unit * Factors.Unit), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMillimetrePerCentimetre).ID);
            Assert.AreEqual(Factors.Centi / (Factors.Unit * Factors.Milli), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMillimetrePerDecimetre).ID);
            Assert.AreEqual(Factors.Deci / (Factors.Unit * Factors.Milli), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMillimetrePerFoot).ID);
            Assert.AreEqual(Factors.Foot / (Factors.Unit * Factors.Milli), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMillimetrePerInch).ID);
            Assert.AreEqual(Factors.Inch / (Factors.Unit * Factors.Milli), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMillimetrePerMetre).ID);
            Assert.AreEqual(Factors.Unit / (Factors.Unit * Factors.Milli), unitVal, 1e-6);
            unitVal = TorqueGradientQuantity.Instance.FromSI(val, TorqueGradientQuantity.Instance.GetUnitChoice(TorqueGradientQuantity.UnitChoicesEnum.NewtonMillimetrePerMillimetre).ID);
            Assert.AreEqual(Factors.Milli / (Factors.Unit * Factors.Milli), unitVal, 1e-6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, TorqueGradientQuantity.Instance.PlaneAngleDimension);
            Assert.AreEqual(-2, TorqueGradientQuantity.Instance.TimeDimension);
            Assert.AreEqual(1, TorqueGradientQuantity.Instance.MassDimension);
            Assert.AreEqual(1, TorqueGradientQuantity.Instance.LengthDimension);
            Assert.AreEqual(0, TorqueGradientQuantity.Instance.TemperatureDimension);
            Assert.AreEqual(0, TorqueGradientQuantity.Instance.ElectricCurrentDimension);
            Assert.AreEqual(0, TorqueGradientQuantity.Instance.AmountSubstanceDimension);
            Assert.AreEqual(0, TorqueGradientQuantity.Instance.LuminousIntensityDimension);
            Assert.AreEqual(0, TorqueGradientQuantity.Instance.SolidAngleDimension);
        }
    }
}