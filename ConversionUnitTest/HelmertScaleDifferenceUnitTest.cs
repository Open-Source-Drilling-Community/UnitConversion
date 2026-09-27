using System.Globalization;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest;

public class HelmertScaleDifferenceUnitTest
{
    [TestCase(0.000002123456, "0.000002123456")]
    [TestCase(-0.000002123456, "-0.000002123456")]
    public void SmallSignedScaleDifferencesKeepTwelveDecimalPlaces(double value, string expected)
    {
        var quantity = HelmertScaleDifferenceQuantity.Instance;
        Assert.That(quantity.FromSIString(value, "dimensionless"), Is.EqualTo(expected));
        Assert.That(double.Parse(quantity.FromSIString(value, "dimensionless"), CultureInfo.InvariantCulture), Is.EqualTo(value));
    }

    [Test]
    public void NumericConversionRetainsExtraDigitsAndZeroMeansNoScaleChange()
    {
        var quantity = HelmertScaleDifferenceQuantity.Instance;
        foreach (double value in new[] { 0.0, 2.123456789123456e-6, -2.123456789123456e-6 })
        {
            Assert.That(quantity.FromSI(value, "dimensionless"), Is.EqualTo(value));
            Assert.That(quantity.ToSI(value, "dimensionless"), Is.EqualTo(value));
        }
        Assert.That(quantity.MeaningfulPrecisionInSI, Is.EqualTo(1e-12));
        Assert.That(quantity.DescriptionMD, Does.Contain("(1 + s)"));
        Assert.That(quantity.DescriptionMD, Does.Contain("Zero means no scale change"));
        Assert.That(quantity.DescriptionMD, Does.Contain("2 ppm"));
        Assert.That(quantity.UnitChoices.Single().ConversionFactorFromSIFormula, Is.EqualTo("1.0/Factors.Unit"));
    }

    [Test]
    public void CatalogueHasSeparateQuantityIdentityWithTheSharedDimensionlessUnit()
    {
        var quantity = HelmertScaleDifferenceQuantity.Instance;
        Assert.That(BasePhysicalQuantity.GetQuantity("HelmertScaleDifference")!.ID, Is.EqualTo(quantity.ID));
        Assert.That(quantity.ID, Is.Not.EqualTo(InverseFlatteningQuantity.Instance.ID));
        Assert.That(quantity.ID, Is.Not.EqualTo(DimensionlessQuantity.Instance.ID));
        Assert.That(quantity.GetUnitChoice(HelmertScaleDifferenceQuantity.UnitChoicesEnum.Dimensionless).ID,
            Is.EqualTo(DimensionlessQuantity.Instance.UnitChoices.Single().ID));
    }
}
