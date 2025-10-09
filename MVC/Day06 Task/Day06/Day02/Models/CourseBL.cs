using Day02.Models;
using Day02.Data.DbContent;
using Microsoft.EntityFrameworkCore;

namespace Day02.Models
{
    public class CourseBL
    {
        SchoolDbContext context = new SchoolDbContext();

        public List<Course> GetAll()
        {
            return context.Courses.Include(c => c.Department).ToList();
        }

        public Course GetById(int id)
        {
            return context.Courses.Include(c => c.Department).FirstOrDefault(c => c.Id == id);
        }

        public void Add(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public void Update(Course course)
        {
            context.Courses.Update(course);
            context.SaveChanges();
        }

        public void Delete(Course course)
        {
            context.Courses.Remove(course);
            context.SaveChanges();
        }

        public void SaveInDB()
        {
            context.SaveChanges();
        }

        public StuCrsResult GetStudentCourseResult(int studentId, int courseId)
        {
            return context.StuCrsResults
                .Include(r => r.Student)
                .Include(r => r.Course)
                .FirstOrDefault(r => r.StuId == studentId && r.CourseId == courseId);
        }
    }
}
