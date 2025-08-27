using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Rectangle
    {
        public int Length {  get; set; }
        public int Width {  get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public void Swap()
        {
            int temp = Length;
            Length = Width;
            Width = temp;
        }

        public override string ToString()
        {
            return $"Length = {Length}, Width = {Width}";
        }
    }
}
