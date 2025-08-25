using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade {  get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public Student(Student obj)
        {
            this.Id = obj.Id;
            this.Name = obj.Name;
            this.Grade = obj.Grade;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Grade: {Grade}";
        }
    }
}
