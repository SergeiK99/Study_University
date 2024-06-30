using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB7;

namespace LAB7test
{
    [TestClass]
    public class Zadanie2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Zadanie2 t = new Zadanie2();
            double[] actual = t.z2(1, 10, 9);
            double[] expect = {-1, -9 };
            CollectionAssert.AreEqual(actual,expect);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Zadanie2 t = new Zadanie2();
            Assert.ThrowsException<ArgumentException>(() => t.z2(0,1,1));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Zadanie2 t = new Zadanie2();
            double[] actual = t.z2(4, 4, 1);
            double[] expect = { -0.5 };
            CollectionAssert.AreEqual(actual, expect);
        }
    }
}
