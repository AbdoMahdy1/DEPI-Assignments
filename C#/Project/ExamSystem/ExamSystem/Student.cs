using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Student : ICloneable, IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Subject> EnrolledSubjects { get; set; }
        public List<Exam> RegisteredExams { get; set; }

        public Student(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            EnrolledSubjects = new List<Subject>();
            RegisteredExams = new List<Exam>();
        }

        public Student() : this(0, "", "") { }

        public void EnrollInSubject(Subject subject)
        {
            if (!EnrolledSubjects.Contains(subject))
            {
                EnrolledSubjects.Add(subject);
            }
        }

        public void RegisterForExam(Exam exam)
        {
            if (!RegisteredExams.Contains(exam))
            {
                RegisteredExams.Add(exam);
                // Subscribe to exam events
                exam.ExamStarted += OnExamStarted;
                exam.ExamQueued += OnExamQueued;
                exam.ExamFinished += OnExamFinished;
            }
        }

        public void UnregisterFromExam(Exam exam)
        {
            if (RegisteredExams.Contains(exam))
            {
                RegisteredExams.Remove(exam);
                // Unsubscribe from exam events
                exam.ExamStarted -= OnExamStarted;
                exam.ExamQueued -= OnExamQueued;
                exam.ExamFinished -= OnExamFinished;
            }
        }

        private void OnExamStarted(object sender, ExamEventArgs e)
        {
            Console.WriteLine($" NOTIFICATION for {Name}:");
            Console.WriteLine($" Exam '{e.Exam.Type}' for subject '{e.Exam.Subject?.Name}' has STARTED!");
            Console.WriteLine($" Time: {e.Exam.Time:yyyy-MM-dd HH:mm}");
            Console.WriteLine();
        }

        private void OnExamQueued(object sender, ExamEventArgs e)
        {
            Console.WriteLine($" NOTIFICATION for {Name}:");
            Console.WriteLine($" Exam '{e.Exam.Type}' for subject '{e.Exam.Subject?.Name}' is now QUEUED.");
            Console.WriteLine($" Time: {e.Exam.Time:yyyy-MM-dd HH:mm}");
            Console.WriteLine();
        }

        private void OnExamFinished(object sender, ExamEventArgs e)
        {
            Console.WriteLine($" NOTIFICATION for {Name}:");
            Console.WriteLine($" Exam '{e.Exam.Type}' for subject '{e.Exam.Subject?.Name}' has FINISHED!");
            Console.WriteLine($" Time: {e.Exam.Time:yyyy-MM-dd HH:mm}");
            Console.WriteLine();
        }

        public bool IsEnrolledInSubject(Subject subject)
        {
            return EnrolledSubjects.Contains(subject);
        }

        public bool IsRegisteredForExam(Exam exam)
        {
            return RegisteredExams.Contains(exam);
        }

        public override string ToString()
        {
            return $"{Name} (ID: {Id}, Email: {Email})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                return Id == other.Id && Name == other.Name && Email == other.Email;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Email);
        }

        public object Clone()
        {
            var clonedStudent = (Student)MemberwiseClone();
            clonedStudent.EnrolledSubjects = new List<Subject>(EnrolledSubjects);
            clonedStudent.RegisteredExams = new List<Exam>();
            
            // Re-register for cloned exams
            foreach (var exam in RegisteredExams)
            {
                clonedStudent.RegisterForExam(exam);
            }
            
            return clonedStudent;
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
    }
}
