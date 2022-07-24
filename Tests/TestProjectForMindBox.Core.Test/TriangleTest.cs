using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectForMindBox.Core.Test
{    
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetArea_WithSides_7_5_6_Return14_696()
        {
            ICommonShape triangle = new Triangle(7, 5, 6);

            double TriangleArea = Math.Round(triangle.GetArea(), 3, MidpointRounding.ToEven);

            Assert.AreEqual<double>(TriangleArea, 14.697d);
        }

        [TestMethod]
        public void IsRightTriangle_ReturnTrue()
        {
            ICommonShape triangle = new Triangle(3, 4, 5);

            bool isRight = ((Triangle)triangle).IsRightTriangle();

            Assert.IsTrue(isRight);
        }

        [TestMethod]
        public void IsRightTriangle_ReturnFalse()
        {
            ICommonShape triangle = new Triangle(7, 5, 6);

            bool isRight = ((Triangle)triangle).IsRightTriangle();

            Assert.IsFalse(isRight);
        }
    }
}