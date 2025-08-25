﻿using Day8.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Rectangle : Shape
    {
        public double Width {  get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width; Height = height;
        }

        public override double CalcArea()
        {
            return (Width * Height);
        }
    }
}
