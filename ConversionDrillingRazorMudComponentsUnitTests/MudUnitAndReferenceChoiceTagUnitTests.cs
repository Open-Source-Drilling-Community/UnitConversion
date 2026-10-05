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
            .Add(p => p.HttpHost, "https://dev.digiwells.no/")
            .Add(p => p.HttpBasePath, "UnitConversion/api/")
            .Add(p => p.HttpController, "UnitSystem/")
            .Add(p => p.UnitSystemName, "SI"));

            obj.WaitForState(() => obj.Instance.InitializedOnce, timeout: TimeSpan.FromSeconds(5));
            Assert.NotNull(obj.Instance);
            double val = obj.Instance.FromSI(2.0*Math.PI, OSDC.UnitConversion.Conversion.DrillingEngineering.DrillingPhysicalQuantity.QuantityEnum.AngularVelocityDrilling);
            //Assert.Equal(2.0*Math.PI, val);
            obj.Instance.UnitSystemName = "Metric";
            var label = obj.Instance.GetUnitLabel(OSDC.UnitConversion.Conversion.DrillingEngineering.DrillingPhysicalQuantity.QuantityEnum.AngularVelocityDrilling);
            val = obj.Instance.FromSI(2.0 * Math.PI, OSDC.UnitConversion.Conversion.DrillingEngineering.DrillingPhysicalQuantity.QuantityEnum.AngularVelocityDrilling);
            //Assert.Equal(60.0, val);
        }

        [Fact]
        public void DateTimeReferenceConvertsDisplayInputBackToCanonicalUtc()
        {
            MudUnitAndReferenceChoiceTag component = new();
            DateTime wallClock = new(2026, 10, 5, 12, 30, 0, DateTimeKind.Unspecified);

            component.DateReferenceName = "UTC";
            Assert.Equal(TimeSpan.Zero, component.ToUtcDateTimeOffset(wallClock).Offset);
            Assert.Equal(wallClock, component.ToDisplayDateTime(component.ToUtcDateTimeOffset(wallClock)));

            component.DateReferenceName = "Local Time";
            DateTimeOffset canonical = component.ToUtcDateTimeOffset(wallClock);
            Assert.Equal(TimeSpan.Zero, canonical.Offset);
            Assert.Equal(wallClock, component.ToDisplayDateTime(canonical));
        }
    }
}
