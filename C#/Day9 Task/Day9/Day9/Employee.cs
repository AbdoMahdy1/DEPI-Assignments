using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }

        private Department Department;

        private decimal EmpSalary;
        public decimal Salary
        {
            get { return EmpSalary; }
            set { EmpSalary = value < 4000 ? 4000 : value; }
        }


        public Employee(int _id, string _Name, decimal _salary, int _Age, Department dep)
        {
            EmpID = _id;
            EmpName = _Name;
            EmpSalary = _salary;
            Age = _Age;
            Department = dep;
        }

        public override string ToString()
        {
            return $"Emp Id is {EmpID}, Name is {EmpName}, Salary is {EmpSalary}, Age is {Age}";
        }


        public decimal Bonus
        {
            get { return EmpSalary * 0.1M; }
        }
    }
}
