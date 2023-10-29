using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Variation
{
    internal class Ellipse : Geometry
    {
        internal Ellipse(double a)
        {
            A = a;
            B = 4.1;
        }
        protected override double Area() => A * B * Math.PI;

        internal override void PrintData()
        {
            Console.WriteLine($"Ellipse\nMajor axis: {A}\nMinor axis: {B}");
            Console.WriteLine($"Area: {Math.Round(Area(), 2)}\n");
        }
        //yeahh, I'm not going to attempt any other calculations of ellipses. It gets complicated.
    }
}
