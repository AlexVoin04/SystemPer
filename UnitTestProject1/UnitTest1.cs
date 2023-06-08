using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SystemPer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1();

            Assert.AreEqual("7E7", c.Calc(16,"2023"));
            Assert.AreEqual("3747", c.Calc(8, "2023"));
            Assert.AreEqual("11111100111", c.Calc(2, "2023"));
        }
    }
}
