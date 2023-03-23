using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace OSDC.UnitConversion.Conversion.UnitTest
{
    [TestClass]
    public class UnitTestPhysicalQuantity
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<PhysicalQuantity> quantities = PhysicalQuantity.AvailableQuantities;
            if (quantities != null)
            {
                // check that all guids are unique
                bool unique = true;
                foreach (PhysicalQuantity quantity in quantities)
                {
                    Dictionary<Guid, UnitChoice> dict = new Dictionary<Guid, UnitChoice>();
                    foreach (UnitChoice choice in quantity.UnitChoices)
                    {
                        if (dict.ContainsKey(choice.ID))
                        {
                            unique = false;
                            break;
                        }
                        dict.Add(choice.ID, choice);
                    }
                }
                Assert.IsTrue(unique);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<string> choices = LengthQuantity.Instance.GetUnitChoiceNames();
            double oneFoot = LengthQuantity.Instance.ToSI(1.0, "feet");
            Assert.AreEqual(0.3048, oneFoot, 0.0001);
        }
        [TestMethod]
        public void TestMethod3()
        {
            List<string> choices = LengthQuantity.Instance.GetUnitChoiceNames();
            string oneFoot = LengthQuantity.Instance.ToSIString(1.0, "feet");
            string expected = 0.3048.ToString(CultureInfo.InvariantCulture.NumberFormat);
            Assert.AreEqual(expected, oneFoot);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<string> choices = DepthQuantity.Instance.GetUnitChoiceNames();
            string oneFoot = DepthQuantity.Instance.ToSIString(1.0, "feet");
            string expected = 0.305.ToString(CultureInfo.InvariantCulture.NumberFormat);
            Assert.AreEqual(expected, oneFoot);
        }
        [TestMethod]
        public void TestMethod5()
        {
            List<string> choices = PipeDiameterQuantity.Instance.GetUnitChoiceNames();
            string oneInch = PipeDiameterQuantity.Instance.ToSIString(1.0, "inch");
            string expected = 0.0254.ToString(CultureInfo.InvariantCulture.NumberFormat);
            Assert.AreEqual(expected, oneInch);
        }

    }
}
