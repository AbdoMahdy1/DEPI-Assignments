using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Shape2: IComparable
    {
        public String? Name {  get; set; }
        public double Area { get; set; }

        public Shape2(String name, double area)
        {
            Name = name;
            Area = area;
        }

        public override string ToString()
        {
            return $"Shape: {Name}, Area: {Area}";
        }

        public int CompareTo(Object? obj)
        {
            Shape2 Pshape =  (Shape2)obj;
            if(this.Area > Pshape?.Area)
                return 1;
            else if(this.Area < Pshape?.Area)
                return -1;
            else return 0;
        }
    }
}
