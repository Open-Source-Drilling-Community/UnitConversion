using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.Conversion.UnitSystem;
using OSDC.UnitConversion.Conversion.UnitSystem.DrillingEngineering;

namespace ConversionUnitSystemDrillingEngineeringTest;

public class GravityPotentialUnitSystemTest
{
    [Test]
    public void DrillingSystemsInheritTheGeneralEarthGravityQuantities()
    {
        foreach (var system in Enum.GetValues<BaseUnitSystem.DefaultUnitSystemEnum>())
        {
            var choices = new DrillingUnitSystem(system).Choices;
            string unit = system is BaseUnitSystem.DefaultUnitSystemEnum.SI or BaseUnitSystem.DefaultUnitSystemEnum.Metric
                ? "square metre per square second" : "square foot per square second";
            foreach (var quantity in new GravityPotentialQuantity[] { GravityPotentialQuantity.Instance, EarthGravityPotentialQuantity.Instance })
            {
                Assert.That(choices[quantity.ID.ToString()], Is.EqualTo(quantity.GetUnitChoice(unit).ID.ToString()));
                Assert.That(DrillingPhysicalQuantity.GetQuantity(quantity.ID)!.Name, Is.EqualTo(quantity.Name));
            }
        }
    }
}
