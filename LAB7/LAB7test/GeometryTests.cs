using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB7;
namespace LAB7test
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            
          
           int a = -4;
           int b = 10;
           Geometry g = new Geometry();
            Assert.ThrowsException<ArgumentException>(() => g.CalculateArea(a, b),
                "не обработаны отрицательные длины сторон прямоугольника");

        }
    }
}
