using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB7;

namespace LAB7test
{
    [TestClass]
    public class Zadanie3Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Zadanie3 t = new Zadanie3();
            bool actual = t.z3(1200);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMothod2()
        {
            Zadanie3 t = new Zadanie3();
            Assert.ThrowsException<ArgumentException>(() => t.z3(0));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Zadanie3 t = new Zadanie3();
            bool actual = t.z3(300);
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Zadanie3 t = new Zadanie3();
            bool actual = t.z3(1300);
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }
    }
}
