using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Variation
{
    internal class Rectangle : Geometry
    {
        internal Rectangle(double a)
        {
            A = a;
            B = 4;
        }
        protected override double Area() => A * B;
        protected double Diameter() => Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        protected double Perimeter() => (A + B) * 2;

        internal override void PrintData()
        {
            Console.WriteLine($"Rectangle\nWidth: {A}\nHeight: {B}");
            Console.WriteLine($"Area: {Math.Round(Area(), 2)}");
            Console.WriteLine($"Diameter: {Math.Round(Diameter(), 2)}");
            Console.WriteLine($"Perimeter: {Math.Round(Perimeter(), 2)}\n");
        }
    }
}
