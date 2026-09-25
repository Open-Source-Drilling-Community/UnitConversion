using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.UnitSystem;

namespace ConversionUnitSystemTest;

public class GravityPotentialUnitSystemTest
{
    [Test]
    public void AllDefaultSystemsSelectTheExpectedUnitForBothQuantities()
    {
        foreach (var (system, unitName) in new[]
        {
            (BaseUnitSystem.SIBaseUnitSystem, "square metre per square second"),
            (BaseUnitSystem.MetricBaseUnitSystem, "square metre per square second"),
            (BaseUnitSystem.USBaseUnitSystem, "square foot per square second"),
            (BaseUnitSystem.ImperialBaseUnitSystem, "square foot per square second")
        })
        foreach (var quantity in new GravityPotentialQuantity[] { GravityPotentialQuantity.Instance, EarthGravityPotentialQuantity.Instance })
            Assert.That(system.Choices[quantity.ID.ToString()], Is.EqualTo(quantity.GetUnitChoice(unitName).ID.ToString()));
    }
}
