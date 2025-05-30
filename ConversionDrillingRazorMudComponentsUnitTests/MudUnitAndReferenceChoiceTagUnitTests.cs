using Bunit;
using Xunit;
using OSDC.UnitConversion.DrillingRazorMudComponents;
using MudBlazor;
using MudBlazor.Services;

namespace ConversionDrillingRazorMudComponentsUnitTests
{
    public class MudUnitAndReferenceChoiceTagUnitTests : TestContext
    {
        public MudUnitAndReferenceChoiceTagUnitTests() : base()
        {
            Services.AddMudServices();
        }

        [Fact]
        public void Test1()
        {
            var obj = RenderComponent<MudUnitAndReferenceChoiceTag>(parameters => parameters
            .Add(p => p.HttpHost, "https://app.digiwells.no/")
            .Add(p => p.HttpBasePath, "UnitConversion/api/")
            .Add(p => p.HttpController, "UnitSystem/")
            .Add(p => p.UnitSystemName, "SI"));

            obj.WaitForState(() => obj.Instance.InitializedOnce, timeout: TimeSpan.FromSeconds(5));
            var instance = obj.Instance;
            Assert.NotNull(instance);
            double val = instance.FromSI(0, OSDC.UnitConversion.Conversion.BasePhysicalQuantity.QuantityEnum.RotationalFrequency);
            Assert.Equal(0, val);
        }
    }
}