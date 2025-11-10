using Core.Entities;
using Core.RepositoryInterfaces;
using Infrastructure.Data.DbContent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CoursesDbContext _context;

        public CourseRepository(CoursesDbContext context)
        {
            _context = context;
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course GetById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.Id == id);
        }

        public Course GetByName(string name)
        {
            return _context.Courses.FirstOrDefault(c => c.Name == name);
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Course course)
        {
            _context.Remove(course);
            _context.SaveChanges();
        }
    }
}
