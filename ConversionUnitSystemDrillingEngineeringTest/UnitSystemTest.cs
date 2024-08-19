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

            UnitSystem unitSystem = UnitSystem.SIUnitSystem;
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {

            UnitSystem unitSystem = UnitSystem.MetricUnitSystem;
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {

            UnitSystem unitSystem = UnitSystem.USUnitSystem;
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {

            UnitSystem unitSystem = UnitSystem.ImperialUnitSystem;
            Assert.Pass();
        }
    }
}