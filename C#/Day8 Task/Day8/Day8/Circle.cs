using Day8.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Circle : Shape
    {
        public double Raduis {  get; set; }

        public Circle(double radius)
        {
            Raduis = radius;
        }
        public override double CalcArea()
        {
            return (Math.PI * Raduis * Raduis);
        }
    }
}
