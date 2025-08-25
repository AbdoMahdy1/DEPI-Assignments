using Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Car : IVehicle
    {
        public Car()
        {

        }

        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}
