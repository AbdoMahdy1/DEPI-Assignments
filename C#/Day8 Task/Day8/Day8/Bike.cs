using Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike engine stopped");
        }
    }
}
