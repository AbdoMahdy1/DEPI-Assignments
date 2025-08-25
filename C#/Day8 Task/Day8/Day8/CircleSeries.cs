using Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class CircleSeries : IShapeSeries
    {
        public double Radius {  get; set; }
        public double CurrentArea { get; set; }

        //public CircleSeries(double radius)
        //{
        //    Radius = radius;
        //}
        public void GetNextArea()
        {
            Radius++;
            CurrentArea = Math.PI * Radius * Radius;
        }

        public void ResetSeries()
        {
            Radius = 0;
            CurrentArea = 0;
        }
    }
}
