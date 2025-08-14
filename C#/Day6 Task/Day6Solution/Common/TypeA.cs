using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeA
    {
        private int F;
        internal int G;
        public int H;

        public TypeA(int _F, int _G, int _H)
        {
            F = _F;
            G = _G;
            H = _H;
        }



        public void Print()
        {
            Console.WriteLine($"F = {F}");
            Console.WriteLine($"G = {G}");
            Console.WriteLine($"H = {H}");
        }
    }
}
