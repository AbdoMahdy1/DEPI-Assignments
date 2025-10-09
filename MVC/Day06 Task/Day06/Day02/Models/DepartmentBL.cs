using Day02.Data.DbContent;
using Microsoft.EntityFrameworkCore;

namespace Day02.Models
{
    public class DepartmentBL
    {
        SchoolDbContext Context = new SchoolDbContext();

        public List<Department> GetAll()
        {
            return Context.Departments.Include(d => d.Students).ToList();
        }

        public Department GetById(int id)
        {
            return Context.Departments.Include(D => D.Students).FirstOrDefault(D => D.Id == id);
        }

        public void AddDept(Department Dept)
        {
            Context.Add(Dept);
            Context.SaveChanges();
        }
    }
}
