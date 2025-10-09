using Day02.Models;
using Day02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Day02.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
        DepartmentBL departmentBL = new DepartmentBL();
        public IActionResult ShowAll()
        {
            List<Student> students = studentBL.GetAll();
            return View("ShowAll", students);
        }

        public IActionResult ShowDetails(int id)
        {
            Student student = studentBL.GetById(id);
            return View("ShowDetails", student);
        }

        public IActionResult Add()
        {
            List<Department> deptList = departmentBL.GetAll();

            StudentDeptViewModel vm = new StudentDeptViewModel
            {
                Departments = deptList
            };

            return View("Add", vm);
        }

        [HttpPost]
        public IActionResult AddSave(StudentDeptViewModel vm)
        {
            if (vm.Name != null)
            {
                Student student = new Student
                {
                    Name = vm.Name,
                    Age = vm.Age,
                    DepartmentId = vm.DepartmentId
                };

                studentBL.Add(student);
                return RedirectToAction(nameof(ShowAll));
            }

            vm.Departments = departmentBL.GetAll();
            return View("Add", vm);
        }

        public IActionResult Edit(int id)
        {
            Student student = studentBL.GetById(id);
            List<Department> departments = departmentBL.GetAll();

            StudentDeptViewModel SDVM = new StudentDeptViewModel
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,
                Departments = departments
            };

            return View("Edit", SDVM);
        }

        public IActionResult SaveEdit(int id, Student NewStudent)
        {
            if (NewStudent.Name != null)
            {
                Student OldStudent = studentBL.GetById(id);
                
                OldStudent.Name = NewStudent.Name;
                OldStudent.Age = NewStudent.Age;
                OldStudent.DepartmentId = NewStudent.DepartmentId;

                studentBL.SaveInDB();

                return RedirectToAction(nameof(ShowAll));
            }

            return View("Edit", NewStudent);
        }

        public IActionResult Delete(int id)
        {
            return View("Delete", studentBL.GetById(id));
        }

        public IActionResult ConfirmDeletion(int id)
        {
            Student student = studentBL.GetById(id);
            if(student != null)
            {
                studentBL.Delete(student);
                return RedirectToAction(nameof(ShowAll));
            }
            return NotFound();
        }

        public IActionResult Warning(int id)
        {
            return View("Warning", studentBL.GetById(id));
        }

    }
}
