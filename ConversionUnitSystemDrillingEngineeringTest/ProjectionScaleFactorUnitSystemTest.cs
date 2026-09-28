using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.Conversion.UnitSystem;
using OSDC.UnitConversion.Conversion.UnitSystem.DrillingEngineering;

namespace ConversionUnitSystemDrillingEngineeringTest;

public class ProjectionScaleFactorUnitSystemTest
{
    [Test]
    public void DrillingCatalogueAndSystemsInheritTheGeneralQuantity()
    {
        var quantity = ProjectionScaleFactorQuantity.Instance;
        Assert.That(DrillingPhysicalQuantity.GetQuantity("ProjectionScaleFactor")!.ID, Is.EqualTo(quantity.ID));
        foreach (var system in Enum.GetValues<BaseUnitSystem.DefaultUnitSystemEnum>())
            Assert.That(new DrillingUnitSystem(system).Choices[quantity.ID.ToString()], Is.EqualTo(quantity.UnitChoices.Single().ID.ToString()));
    }
}
