using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("TestProjectForMindBox.Core.Test")]

namespace TestProjectForMindBox.Core
{
    public class Triangle : ICommonShape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;

            SideB = sideB;

            SideC = sideC;
        }

        public double GetArea()
        {
            // Найдём полупериметр треугольника
            double p = (SideA + SideB + SideC) / 2;

            // Найдём площадь по формуле Герона
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightTriangle()
        {
            // Определим является ли треугольник прямоугольным с применением теоремы Пифагора
            return 
                (SideA * SideA + SideB * SideB == SideC * SideC) || 
                (SideA * SideA + SideC * SideC == SideB * SideB) || 
                (SideC * SideC + SideB * SideB == SideA * SideA) ? true : false;
        }
    }
}
