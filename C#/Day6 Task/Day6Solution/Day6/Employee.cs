using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal struct Employee
    {
        private int ID;
        private string Name;
        private decimal Salary;


        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string name
        {
            get { return Name; }
            set {  Name = value; }
        }

        public decimal salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        //public void SetId(int Id)
        //{
        //    ID = Id;
        //}
        //public int GetId()
        //{
        //    return ID;
        //}

        //public void SetName(string name)
        //{
        //    Name = name;
        //}
        //public string GetName()
        //{
        //    return Name;
        //}

        //public void SetSalary(decimal salary)
        //{
        //    Salary = salary;
        //}
        //public decimal GetSalary()
        //{
        //    return Salary;
        //}
    }
}
