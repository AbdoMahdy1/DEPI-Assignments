using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Interface
{
    internal interface ILogger
    {
        void Log()
        {
            Console.WriteLine("default log");
        }
    }

    class DefaultLogger: ILogger
    {

    }
}
