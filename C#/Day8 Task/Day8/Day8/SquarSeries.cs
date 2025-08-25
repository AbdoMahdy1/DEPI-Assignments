using Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class SquarSeries : IShapeSeries
    {
        public double Length {  get; set; }
        public double CurrentArea { get; set; }

        //public SquarSeries(double length)
        //{
        //    Length = length;
        //}
        public void GetNextArea()
        {
            Length++;
            CurrentArea = Length * Length;
        }

        public void ResetSeries()
        {
            Length = 0;
            CurrentArea = 0;
        }
    }
}
