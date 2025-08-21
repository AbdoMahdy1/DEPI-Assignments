using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Child : Parent
    {
        private int z;
        public int Z { get { return z; } set { z = value; } }

        public Child(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public new int Product()
        {  
            return base.Product() * z;
        }

        public override int Prod()
        {
            return base.Prod() * z;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Z: {z}";
        }
    }
}
