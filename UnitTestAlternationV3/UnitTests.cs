using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestAlternationV3
{
    [TestClass]
    public class UnitTests//Test our library
    {
        [TestMethod]
        public void TestLibrary()
        {
            double[] mas = { 3.4, -2.3, 2.4 };
            Assert.IsTrue(AlternationV3_Array.AlternationV3.ElementAlternationCheck(mas));//Must true
        }
        [TestMethod]
        public void TestLibrary2()
        {
            double[] mas2 = { -3.4, 2.3, -2.4 };
            Assert.IsTrue(AlternationV3_Array.AlternationV3.ElementAlternationCheck(mas2));//Must true
        }
        [TestMethod]
        public void TestLibrary3()
        {
            double[] mas3 = { 3.4, 2.3, -2.4 };
            Assert.IsTrue(AlternationV3_Array.AlternationV3.ElementAlternationCheck(mas3));//Must false
        }
        [TestMethod]
        public void TestLibrary4()
        {
            double[] mas4 = { -3.4, -2.3, 2.4 };
            Assert.IsTrue(AlternationV3_Array.AlternationV3.ElementAlternationCheck(mas4));//Must false
        }
    }
}
