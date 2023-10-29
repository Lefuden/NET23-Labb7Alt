using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Variation
{
    internal class Square : Geometry
    {
        internal Square()
        {
            A = 10;
        }

        protected override double Area() => A * A;
        protected double Perimeter() => A * 4;
        protected double Diameter() => A * Math.Sqrt(2);

        internal override void PrintData()
        {
            Console.WriteLine($"Square\nWidth: {A}\nHeight: {A}");
            Console.WriteLine($"Area: {Math.Round(Area(), 2)}");
            Console.WriteLine($"Perimeter: {Math.Round(Perimeter(),2)}");
            Console.WriteLine($"Diameter: {Math.Round(Diameter(),2)}\n");
        }
    }
}
