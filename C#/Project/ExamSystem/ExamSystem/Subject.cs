using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Subject : ICloneable, IComparable<Subject>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public string Department { get; set; }

        public Subject(int id, string name, string code, string description, int credits, string department)
        {
            Id = id;
            Name = name;
            Code = code;
            Description = description;
            Credits = credits;
            Department = department;
        }

        // Constructor chaining
        public Subject() : this(0, "", "", "", 0, "") { }

        public Subject(int id, string name, string code) : this(id, name, code, "", 0, "") { }

        public override string ToString()
        {
            return $"{Code} - {Name} ({Credits} credits)";
        }

        public override bool Equals(object obj)
        {
            if (obj is Subject other)
            {
                return Id == other.Id && Name == other.Name && Code == other.Code;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Code);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Subject other)
        {
            if (other == null) return 1;
            return Code.CompareTo(other.Code);
        }
    }
}
