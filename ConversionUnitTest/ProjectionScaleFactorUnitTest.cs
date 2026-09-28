using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest;

public class ProjectionScaleFactorUnitTest
{
    [TestCase(0.9996, "0.999600000")]
    [TestCase(1.000002123, "1.000002123")]
    [TestCase(1.0, "1.000000000")]
    public void FullFactorsRetainNineDecimalPlaces(double value, string expected)
    {
        Assert.That(ProjectionScaleFactorQuantity.Instance.FromSIString(value, "dimensionless"), Is.EqualTo(expected));
    }

    [Test]
    public void ConversionPreservesFullFactorAndExtraDigits()
    {
        var quantity = ProjectionScaleFactorQuantity.Instance;
        foreach (double value in new[] { 0.9996, 1.0, 1.000002123456789 })
        {
            Assert.That(quantity.FromSI(value, "dimensionless"), Is.EqualTo(value));
            Assert.That(quantity.ToSI(value, "dimensionless"), Is.EqualTo(value));
        }
        Assert.That(quantity.MeaningfulPrecisionInSI, Is.EqualTo(1e-9));
        Assert.That(quantity.UnitChoices.Single().ConversionFactorFromSIFormula, Is.EqualTo("1.0/Factors.Unit"));
        Assert.That(quantity.DescriptionMD, Does.Contain("Unity means no local scale change"));
    }

    [Test]
    public void GeneratedCatalogueKeepsScaleFactorDistinctFromScaleDifference()
    {
        var quantity = ProjectionScaleFactorQuantity.Instance;
        Assert.That(BasePhysicalQuantity.GetQuantity("ProjectionScaleFactor")!.ID, Is.EqualTo(quantity.ID));
        Assert.That(quantity.ID, Is.Not.EqualTo(HelmertScaleDifferenceQuantity.Instance.ID));
        Assert.That(quantity.ID, Is.Not.EqualTo(DimensionlessQuantity.Instance.ID));
        Assert.That(quantity.GetUnitChoice(ProjectionScaleFactorQuantity.UnitChoicesEnum.Dimensionless).ID,
            Is.EqualTo(DimensionlessQuantity.Instance.UnitChoices.Single().ID));
    }
}
