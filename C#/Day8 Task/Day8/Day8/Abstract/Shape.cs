using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Abstract
{
    internal abstract class Shape
    {
        public abstract double CalcArea();

        public void Display()
        {
            Console.WriteLine("This is shape");
        }
    }
}
