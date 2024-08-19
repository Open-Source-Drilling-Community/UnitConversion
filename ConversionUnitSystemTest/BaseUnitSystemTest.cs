using OSDC.UnitConversion.Conversion.UnitSystem;

namespace ConversionUnitSystemTest
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
            
            BaseUnitSystem unitSystem = BaseUnitSystem.SIBaseUnitSystem;
            Assert.Pass();    
        }

        [Test]
        public void Test2()
        {

            BaseUnitSystem unitSystem = BaseUnitSystem.MetricBaseUnitSystem;
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {

            BaseUnitSystem unitSystem = BaseUnitSystem.USBaseUnitSystem;
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {

            BaseUnitSystem unitSystem = BaseUnitSystem.ImperialBaseUnitSystem;
            Assert.Pass();
        }
    }
}