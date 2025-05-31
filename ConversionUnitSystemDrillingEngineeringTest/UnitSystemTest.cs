using OSDC.UnitConversion.Conversion.UnitSystem.DrillingEngineering;

namespace ConversionUnitSystemDrillingEngineeringTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            DrillingUnitSystem unitSystem = DrillingUnitSystem.SIUnitSystem;
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {

            DrillingUnitSystem unitSystem = DrillingUnitSystem.MetricUnitSystem;
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {

            DrillingUnitSystem unitSystem = DrillingUnitSystem.USUnitSystem;
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {

            DrillingUnitSystem unitSystem = DrillingUnitSystem.ImperialUnitSystem;
            Assert.Pass();
        }
    }
}