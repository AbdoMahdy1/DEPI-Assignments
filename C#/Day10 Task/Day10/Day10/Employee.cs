using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set;}
        public decimal Salary {  get; set;}

        public string Name { get; set;}
        public Employee(int id, decimal salary, string name)
        {
            Id = id;
            Salary = salary;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }

        public static int CompareNames ( Employee a,  Employee b)
        {
            if(a.Name.Length > b.Name.Length)
                return 1 ;
            if(a.Name.Length < b.Name.Length)
                return -1 ;
            else return 0 ;

        }
        public static int CompareSal ( Employee a,  Employee b)
        {
            //return a.Salary > b.Salary;
            if (a.Salary > b.Salary)
                return 1;
            else if (a.Salary < b.Salary)
                return -1;
            else return 0;
        }

        public static int Compare(Employee a, Employee b)
        {
            int salcomp = CompareSal (a, b);
            if (salcomp != 0)
                return salcomp;

            return CompareNames(a, b);
        }

        public int CompareTo(Employee emp)
        {
            if(this.Salary > emp.Salary)
                return 1;
            else if(this.Salary < emp.Salary)
                return -1;
            else return 0;
        }
    }
}
