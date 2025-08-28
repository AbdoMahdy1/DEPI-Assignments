using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class SortingAlgorithm<T> where T : IComparable<T>
    {
        public static void Sort(T[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = 0; j < items.Length - 1 - i; j++)
                {
                    if (items[j].CompareTo((items[j + 1])) == 1)
                    {
                        Swap(ref items[j], ref items[j + 1]);
                    }
                }
            }
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
