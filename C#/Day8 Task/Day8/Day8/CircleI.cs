using Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class CircleI : IShape
    {
        public double Radius {  get; set; }
        public CircleI(double radius)
        {
            Radius = radius;
        }
        public double CalcArea()
        {
            Console.Write("Circle area: ");
            return Math.PI * Radius * Radius;
        }
    }
}
