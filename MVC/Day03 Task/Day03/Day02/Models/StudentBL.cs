using Microsoft.EntityFrameworkCore;
using Day02.Data.DbContent;

namespace Day02.Models
{
    public class StudentBL
    {
        SchoolDbContext Context = new SchoolDbContext();

        public List<Student> ShowAll()
        {
            return Context.Students.ToList();
        }

        public Student ShowDetails(int id)
        {
            return Context.Students.FirstOrDefault(s => s.Id == id);
        }
    }

}
