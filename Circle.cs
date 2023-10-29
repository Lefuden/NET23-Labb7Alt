using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Variation
{
    internal class Circle : Geometry
    {
        internal Circle()
        {
            A = 4;
        }

        //various calculations that don't save any data by themselves, will be used further down
        protected override double Area() => A * A * Math.PI;
        protected double Circumference() => Math.PI * A * 2;
        protected double Diameter() => A * 2;

        //method to call methods and print data
        internal override void PrintData()
        {
            Console.WriteLine($"Circle\nRadius: {A}");
            Console.WriteLine($"Area: {Math.Round(Area(), 2)}");
            Console.WriteLine($"Circumference: {Math.Round(Circumference(), 2)}");
            Console.WriteLine($"Diameter: {Math.Round(Diameter(), 2)}\n");
        }
    }
}