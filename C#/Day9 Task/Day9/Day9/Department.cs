using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Department
    {
        public int DeptID {  get; set; }
        public string DeptName { get; set; }

        public Department(int id,  string name)
        {
            DeptID = id;
            DeptName = name;
        }
    }
}
