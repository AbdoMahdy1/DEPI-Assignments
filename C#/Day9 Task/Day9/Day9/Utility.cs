using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal static class Utility
    {
        public static double CalcRecPer(double x, double y)
        {
            return 2 * (x + y);
        }

        public static string ConvertCelsToFahren(double temp)
        {
            return $"Celsus = {temp}, Fahrenheit = {temp * 1.8 + 32}";
        }
    }
}
