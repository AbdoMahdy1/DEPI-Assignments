using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Abstract
{
    internal class GRectangle : GeometricShape
    {
        public GRectangle(double length, double width) : base(length, width) { }

        public override double Perimeter
        {
            get
            {
                return 2 * (Dimension1 + Dimension2);
            }
        }

        public override double CalcArea()
        {
            return Dimension1 * Dimension2;
        }
    }
}
