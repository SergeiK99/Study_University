using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB7;

namespace LAB7test
{
    [TestClass]
    public class Zadanie5Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Zadanie5 t = new Zadanie5();
            int actual = t.z5("12345340943287432");
            int expected = 64;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Zadanie5 t = new Zadanie5();
            int actual = t.z5("922337203685477580811");
            int expected = 91;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool catched = false;
            Zadanie5 t = new Zadanie5();
            try
            {
                int value = Convert.ToInt32(t.z5("Hello"));

            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработаны недопустимые данные");
        }
    }
}
