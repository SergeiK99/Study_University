using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB7;

namespace LAB7test
{
    [TestClass]
    public class Zadanie1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Zadanie1 t = new Zadanie1();
            string expected = "ABC";
            string actual = t.z1(3);
            Assert.AreEqual(expected, actual);
        }
    }
}
