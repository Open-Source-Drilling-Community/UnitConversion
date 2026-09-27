using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.UnitSystem;

namespace ConversionUnitSystemTest;

public class HelmertScaleDifferenceUnitSystemTest
{
    [Test]
    public void EveryDefaultSystemUsesTheSameDimensionlessUnit()
    {
        var quantity = HelmertScaleDifferenceQuantity.Instance;
        foreach (var system in new[] { BaseUnitSystem.SIBaseUnitSystem, BaseUnitSystem.MetricBaseUnitSystem,
            BaseUnitSystem.USBaseUnitSystem, BaseUnitSystem.ImperialBaseUnitSystem })
            Assert.That(system.Choices[quantity.ID.ToString()], Is.EqualTo(quantity.UnitChoices.Single().ID.ToString()));
    }
}
