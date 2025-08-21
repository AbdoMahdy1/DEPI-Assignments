using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Parent
    {
        private int x, y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Product()
        {
            return x * y;
        }

        public virtual int Prod()
        {
            return x * y;
        }

        public override string ToString()
        {
            return $"X = {x}, Y = {y}";
        }
    }
}
