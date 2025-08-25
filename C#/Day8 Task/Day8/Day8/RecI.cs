using Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class RecI : IShape
    {
        public double Width {  get; set; }
        public double Height { get; set; }
        public RecI(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double CalcArea()
        {
            Console.Write("Rectangle area: ");
            return Width * Height;
        }
    }
}
