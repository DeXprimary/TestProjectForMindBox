using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectForMindBox.Core.Test
{    
    [TestClass]
    public class CircleTest
    {
        [TestMethod] // Площадь круга
        public void GetArea_WithRadius_5_Return78_54() 
        {
            ICommonShape circle = new Circle(5);

            double TriangleArea = Math.Round(circle.GetArea(), 3, MidpointRounding.ToEven);

            Assert.AreEqual<double>(TriangleArea, 78.54);
        }                
    }
}