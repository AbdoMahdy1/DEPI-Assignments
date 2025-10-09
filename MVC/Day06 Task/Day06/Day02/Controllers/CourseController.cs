using Day02.Models;
using Day02.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Day02.Controllers
{
    public class CourseController : Controller
    {
        CourseBL courseBL = new CourseBL();
        DepartmentBL departmentBL = new DepartmentBL();

        public IActionResult ShowAll()
        {
            List<Course> courses = courseBL.GetAll();
            return View("ShowAll", courses);
        }

        public IActionResult ShowDetails(int id)
        {
            Course course = courseBL.GetById(id);
            if (course == null)
            {
                return NotFound();
            }
            return View("ShowDetails", course);
        }

        public IActionResult Add()
        {
            List<Department> deptList = departmentBL.GetAll();

            CourseDeptViewModel vm = new CourseDeptViewModel
            {
                Departments = deptList
            };

            return View("Add", vm);
        }

        [HttpPost]
        public IActionResult AddSave(CourseDeptViewModel vm)
        {
            // Server-side validation
            if (string.IsNullOrWhiteSpace(vm.Name))
            {
                ModelState.AddModelError("Name", "Course name is required.");
            }
            else if (vm.Name.Length > 50)
            {
                ModelState.AddModelError("Name", "Course name cannot exceed 50 characters.");
            }

            if (vm.Degree <= 0)
            {
                ModelState.AddModelError("Degree", "Course degree must be greater than 0.");
            }

            if (vm.MinDegree <= 0)
            {
                ModelState.AddModelError("MinDegree", "Minimum degree must be greater than 0.");
            }

            if (vm.MinDegree > vm.Degree)
            {
                ModelState.AddModelError("MinDegree", "Minimum degree cannot be greater than course degree.");
            }

            if (vm.DepartmentId <= 0)
            {
                ModelState.AddModelError("DepartmentId", "Please select a department.");
            }

            if (ModelState.IsValid)
            {
                Course course = new Course
                {
                    Name = vm.Name,
                    Degree = vm.Degree,
                    MinDegree = vm.MinDegree,
                    DepartmentId = vm.DepartmentId
                };

                courseBL.Add(course);
                return RedirectToAction(nameof(ShowAll));
            }

            vm.Departments = departmentBL.GetAll();
            return View("Add", vm);
        }

        public IActionResult Edit(int id)
        {
            Course course = courseBL.GetById(id);
            if (course == null)
            {
                return NotFound();
            }

            List<Department> departments = departmentBL.GetAll();

            CourseDeptViewModel CDVM = new CourseDeptViewModel
            {
                Id = course.Id,
                Name = course.Name,
                Degree = course.Degree,
                MinDegree = course.MinDegree,
                DepartmentId = course.DepartmentId,
                Departments = departments
            };

            return View("Edit", CDVM);
        }

        [HttpPost]
        public IActionResult SaveEdit(int id, CourseDeptViewModel vm)
        {
            Course course = courseBL.GetById(id);
            if (course == null)
            {
                return NotFound();
            }

            // Server-side validation
            if (string.IsNullOrWhiteSpace(vm.Name))
            {
                ModelState.AddModelError("Name", "Course name is required.");
            }
            else if (vm.Name.Length > 50)
            {
                ModelState.AddModelError("Name", "Course name cannot exceed 50 characters.");
            }

            if (vm.Degree <= 0)
            {
                ModelState.AddModelError("Degree", "Course degree must be greater than 0.");
            }

            if (vm.MinDegree <= 0)
            {
                ModelState.AddModelError("MinDegree", "Minimum degree must be greater than 0.");
            }

            if (vm.MinDegree > vm.Degree)
            {
                ModelState.AddModelError("MinDegree", "Minimum degree cannot be greater than course degree.");
            }

            if (vm.DepartmentId <= 0)
            {
                ModelState.AddModelError("DepartmentId", "Please select a department.");
            }

            if (ModelState.IsValid)
            {
                course.Name = vm.Name;
                course.Degree = vm.Degree;
                course.MinDegree = vm.MinDegree;
                course.DepartmentId = vm.DepartmentId;

                courseBL.SaveInDB();
                return RedirectToAction(nameof(ShowAll));
            }

            vm.Departments = departmentBL.GetAll();
            return View("Edit", vm);
        }

        public IActionResult Delete(int id)
        {
            Course course = courseBL.GetById(id);
            if (course == null)
            {
                return NotFound();
            }
            return View("Delete", course);
        }

        [HttpPost]
        public IActionResult ConfirmDeletion(int id)
        {
            Course course = courseBL.GetById(id);
            if (course != null)
            {
                courseBL.Delete(course);
                return RedirectToAction(nameof(ShowAll));
            }
            return NotFound();
        }

        public IActionResult StudentCourseResults(int studentId, int courseId)
        {
            StudentBL studentBL = new StudentBL();
            Student student = studentBL.GetById(studentId);
            Course course = courseBL.GetById(courseId);

            if (student == null || course == null)
            {
                return NotFound();
            }

            // Get the result for this student and course
            StuCrsResult result = courseBL.GetStudentCourseResult(studentId, courseId);

            StudentCourseResultViewModel vm = new StudentCourseResultViewModel
            {
                StudentName = student.Name,
                CourseName = course.Name,
                Grade = result?.Grade ?? 0,
                MinDegree = course.MinDegree,
                IsPassed = result != null && result.Grade >= course.MinDegree
            };

            return View("StudentCourseResults", vm);
        }
    }
}
