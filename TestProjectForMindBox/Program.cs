// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using System;
using TestProjectForMindBox.Core;

namespace TestProjectForMindBox
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "<Ожидание>")]
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Выбери фигуру: {0}[1] Круг.{0}[2] Треугольник.", Environment.NewLine);

            string? read = Console.ReadLine();

            ICommonShape shape;

            if (read == "1") shape = new Circle(4);

            else shape = new Triangle(4,5,6);
                                   
            Console.WriteLine("Площадь фигуры: " + shape.GetArea());

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}