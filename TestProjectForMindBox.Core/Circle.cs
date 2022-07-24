using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForMindBox.Core
{
    public class Circle : ICommonShape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            // Возвращаем площадь круга
            return Math.PI * Radius * Radius;
        }
    }
}
