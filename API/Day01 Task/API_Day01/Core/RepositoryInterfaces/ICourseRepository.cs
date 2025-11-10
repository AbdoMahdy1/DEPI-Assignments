using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryInterfaces
{
    public interface ICourseRepository
    {
        public List<Course> GetAll();
        public Course GetById(int id);
        public Course GetByName(string name);
        public void Add(Course course);
        public void Update(Course course);
        public void Delete(Course course);
    }
}
