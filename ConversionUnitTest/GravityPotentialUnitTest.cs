using System.Globalization;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest;

public class GravityPotentialUnitTest
{
    [TestCase(false)]
    [TestCase(true)]
    public void IndependentUnitValuesAndRoundTrips(bool earth)
    {
        GravityPotentialQuantity quantity = earth ? EarthGravityPotentialQuantity.Instance : GravityPotentialQuantity.Instance;
        var cases = new[]
        {
            ("square metre per square second", 1.0), ("joule per kilogram", 1.0),
            ("square foot per square second", 0.09290304),
            ("foot pound-force per pound-mass", 2.98906692)
        };
        foreach (var (name, siValue) in cases)
        {
            Assert.That(quantity.ToSI(1.0, name), Is.EqualTo(siValue).Within(1e-12));
            Assert.That(quantity.FromSI(siValue, name), Is.EqualTo(1.0).Within(1e-12));
            foreach (double value in new[] { -12345.6789, 0, 0.012345, 62636853.12345 })
                Assert.That(quantity.ToSI(quantity.FromSI(value, name), name), Is.EqualTo(value).Within(Math.Max(1e-12, Math.Abs(value) * 1e-14)));
        }
        Assert.That(quantity.UnitChoices.Count(u => u.IsSI), Is.EqualTo(1));
    }

    [Test]
    public void GeneratedFactorsKeepTheirSymbolicOrigins()
    {
        var foot = GravityPotentialQuantity.Instance.GetUnitChoice("square foot per square second");
        var energy = GravityPotentialQuantity.Instance.GetUnitChoice("foot pound-force per pound-mass");
        Assert.That(foot.ConversionFactorFromSIFormula, Is.EqualTo("1.0/(Factors.Foot*Factors.Foot)"));
        Assert.That(energy.ConversionFactorFromSIFormula, Is.EqualTo("Factors.Pound/(Factors.Foot*Factors.PoundForce)"));
        Assert.That(energy.ConversionDescription, Does.Contain("PoundForce"));
        Assert.That(energy.ConversionDescription, Does.Contain("Foot"));
    }

    [Test]
    public void PrecisionOnlyAffectsPresentationAndDimensionsRemainSpecificEnergy()
    {
        var quantity = EarthGravityPotentialQuantity.Instance;
        Assert.That(GravityPotentialQuantity.Instance.MeaningfulPrecisionInSI, Is.Null);
        Assert.That(quantity.MeaningfulPrecisionInSI, Is.EqualTo(0.01));
        Assert.That(quantity.LengthDimension, Is.EqualTo(2));
        Assert.That(quantity.TimeDimension, Is.EqualTo(-2));
        Assert.That(quantity.MassDimension, Is.Zero);
        foreach (var unit in quantity.UnitChoices)
        {
            const double input = 62636853.123456;
            double displayed = double.Parse(quantity.FromSIString(input, unit.ID), CultureInfo.InvariantCulture);
            Assert.That(Math.Abs(quantity.ToSI(displayed, unit.ID) - input), Is.LessThanOrEqualTo(0.01));
            Assert.That(quantity.FromSI(input, unit.ID), Is.EqualTo(input * unit.ConversionFactorFromSI).Within(1e-8));
        }
        Assert.That(quantity.DescriptionMD, Does.Contain("not a statement of EGM96 accuracy"));
    }

    [Test]
    public void BothQuantitiesHaveIndependentIdentitiesAndSharedUnitIdentities()
    {
        var general = GravityPotentialQuantity.Instance;
        var earth = EarthGravityPotentialQuantity.Instance;
        Assert.That(general.ID, Is.Not.EqualTo(earth.ID));
        Assert.That(BasePhysicalQuantity.GetQuantity("GravityPotential")!.ID, Is.EqualTo(general.ID));
        Assert.That(BasePhysicalQuantity.GetQuantity("EarthGravityPotential")!.ID, Is.EqualTo(earth.ID));
        Assert.That(earth.UnitChoices.Select(u => u.ID), Is.EqualTo(general.UnitChoices.Select(u => u.ID)));
    }
}
