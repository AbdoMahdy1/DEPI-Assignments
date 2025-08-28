using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Manager : Employee, IComparable<Manager>
    {
        public Manager(int id, decimal salary, string name) : base(id, salary, name)
        {

        }

        public int CompareTo(Manager? other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
