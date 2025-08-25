using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Abstract
{
    internal class Triangle : GeometricShape
    {
        public Triangle(double basee, double height) : base(basee, height) { }
        public override double Perimeter
        {
            get
            {
                double hypotenuse = Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
                return hypotenuse + Dimension1 + Dimension2;
            }
        }

        public override double CalcArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }
    }
}
