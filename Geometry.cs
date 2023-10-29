using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Variation
{
    internal abstract class Geometry
    {
        //This will be filled with ideas I had while following the original instructions

        //I've added two properties that will be used in all calculations
        protected double A { get; set; }
        protected double B { get; set; }
        protected abstract double Area();
        internal abstract void PrintData();
    }
}
