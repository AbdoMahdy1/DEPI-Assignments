using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Interface
{
    internal interface IShapeSeries
    {
        double CurrentArea { get; set; }

        void GetNextArea();
        void ResetSeries();
    }
}
