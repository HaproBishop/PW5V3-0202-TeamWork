using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestAlternationV3
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestLibrary()
        {
            double[] mas = { 3.4, -2.3, 2.4 };
            Assert.IsTrue(AlternationV3_Array.AlternationV3.ElementAlternationCheck(mas));
        }
    }
}
