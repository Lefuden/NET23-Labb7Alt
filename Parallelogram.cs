using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Variation
{
    internal class Parallelogram : Geometry
    {
        internal Parallelogram(double a)
        {
            A = a;
            B = 7.4;
        }
        protected override double Area() => A * B;
        protected double Perimeter() => (A + B) * 2;

        internal override void PrintData()
        {
            Console.WriteLine($"Parallelogram\nWidth: {A}\nHeight: {B}");
            Console.WriteLine($"Area: {Math.Round(Area(), 2)}");
            Console.WriteLine($"Perimeter: {Math.Round(Perimeter(),2)}\n");
        }
    }
}
