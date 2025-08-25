using Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class ConsoleLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("overrided log");
        }
    }
}
