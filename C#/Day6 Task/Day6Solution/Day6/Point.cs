using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal struct Point
    {
        int x, y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }


        public override string ToString()
        {
            return $"Value X: {x}, Value Y: {y})";
        }
    }
}
