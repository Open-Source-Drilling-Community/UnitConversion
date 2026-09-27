using System.Globalization;
using OSDC.UnitConversion.Conversion;

namespace ConversionUnitTest;

public class InverseFlatteningUnitTest
{
    [TestCase(298.257223563, "298.257223563")]
    [TestCase(298.257222101, "298.257222101")]
    public void PresentationPreservesAuthoritativeEllipsoidDigits(double value, string expected)
    {
        var quantity = InverseFlatteningQuantity.Instance;
        Assert.That(quantity.FromSIString(value, "dimensionless"), Is.EqualTo(expected));
        Assert.That(double.Parse(quantity.FromSIString(value, "dimensionless"), CultureInfo.InvariantCulture), Is.EqualTo(value));
    }

    [Test]
    public void NumericConversionsDoNotRoundOrInterpretSphereSentinels()
    {
        var quantity = InverseFlatteningQuantity.Instance;
        foreach (double value in new[] { 0.0, 298.257223563123, 300.123456789456 })
        {
            Assert.That(quantity.ToSI(value, "dimensionless"), Is.EqualTo(value));
            Assert.That(quantity.FromSI(value, "dimensionless"), Is.EqualTo(value));
        }
        Assert.That(quantity.MeaningfulPrecisionInSI, Is.EqualTo(1e-9));
        Assert.That(quantity.UnitChoices.Single().ID, Is.EqualTo(DimensionlessQuantity.Instance.UnitChoices.Single().ID));
        Assert.That(quantity.UnitChoices.Single().ConversionFactorFromSIFormula, Is.EqualTo("1.0/Factors.Unit"));
        Assert.That(quantity.DescriptionMD, Does.Contain("not a unit conversion"));
        Assert.That(quantity.DescriptionMD, Does.Contain("sphere sentinel"));
    }

    [Test]
    public void GeneratedCatalogueResolvesTheSpecializedIdentity()
    {
        var quantity = InverseFlatteningQuantity.Instance;
        Assert.That(BasePhysicalQuantity.GetQuantity("InverseFlattening")!.ID, Is.EqualTo(quantity.ID));
        Assert.That(quantity.ID, Is.Not.EqualTo(DimensionlessQuantity.Instance.ID));
        Assert.That(quantity.GetUnitChoice(InverseFlatteningQuantity.UnitChoicesEnum.Dimensionless).IsSI, Is.True);
    }
}
