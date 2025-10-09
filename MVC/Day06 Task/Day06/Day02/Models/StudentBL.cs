using Microsoft.EntityFrameworkCore;
using Day02.Data.DbContent;

namespace Day02.Models
{
    public class StudentBL
    {
        SchoolDbContext Context = new SchoolDbContext();

        public List<Student> GetAll()
        {
            return Context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return Context.Students.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Student student)
        {
            Context.Students.Add(student);
            Context.SaveChanges();
        }

        public void SaveInDB()
        {
            Context.SaveChanges();
        }

        public void Delete(Student student)
        {
            Context.Students.Remove(student);
            Context.SaveChanges();
        }
    }

}
