using Core.Entities;
using Core.RepositoryInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository CourseRepo;

        public CourseController(ICourseRepository courseRepo)
        {
            this.CourseRepo = courseRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Course> courses = CourseRepo.GetAll();
            return Ok(courses);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            Course course = CourseRepo.GetById(id);
            if (course != null)
            {
                return Ok(course);
            }
            return NotFound();
        }

        [HttpGet("{Name:alpha}")]
        public IActionResult GetByName(string name)
        {
            Course course = CourseRepo.GetByName(name);
            if (course != null)
            {
                return Ok(course);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (course != null)
            {
                CourseRepo.Add(course);
                return CreatedAtAction(nameof(GetById), new {id = course.Id}, course);
            }
            return BadRequest();
        }

        [HttpPut("{id:int}")]
        public IActionResult Edit(int id, Course NewCourse)
        {
            var course = CourseRepo.GetById(id);
            if (course == null)
                return NotFound();

            course.Name = NewCourse.Name;
            course.Description = NewCourse.Description;
            course.Duration = NewCourse.Duration;

            CourseRepo.Update(course);

            return NoContent();
        }


        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id, Course Course)
        {
            Course = CourseRepo.GetById(id);
            if (Course != null)
            {
                CourseRepo.Delete(Course);
                return NoContent();
            }
            return BadRequest();
        }
    }
}
