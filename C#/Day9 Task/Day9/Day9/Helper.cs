using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Helper<T>
    {
        public static int SearchArr(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Value.Equals((Arr[i])))
                    return i;
            }
            return -1;
        }

        public static T Max<T>(T value1,  T value2) where T : IComparable
        {
            int com = value1.CompareTo(value2);
            if(com == 1)
                return value1;
            else if(com == -1)
                return value2;
            else
            {
                Console.WriteLine("both equals");
                return value1;
            }

        }

        public static void ReplaceArr(T[] Arr, T Old, T New)
        {
            Arr[SearchArr(Arr, Old)] = New;
        }
    }
}
