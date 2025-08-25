using Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot is Walkin");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is wlking in default mode");
        }
    }
}
