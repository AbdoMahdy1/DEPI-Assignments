using Day02.Models;
using Day02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Day02.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentBL DepartmentBL = new DepartmentBL();
        public IActionResult ShowAll()
        {
            List<Department> departments = DepartmentBL.ShowAll();
            return View("ShowAll", departments);
        }

        public IActionResult ShowDetails(int id)
        {
            Department department = DepartmentBL.ShowDetails(id);
            return View("ShowDetails", department);
        }

        public IActionResult Add(Department department)
        {
            return View("Add");
        }

        public IActionResult SaveAdd(Department DeptSent)
        {
            if (DeptSent.Name != null)
            {
                DepartmentBL.AddDept(DeptSent);
                return RedirectToAction(nameof(Index));
            }

            return View("Add", DeptSent);
        }

        public IActionResult ShowDetailsVM(int id)
        {
            Department departmentmodel = DepartmentBL.ShowDetails(id);
            string State;
            if (departmentmodel.Students.Count > 50)
                State = "Main";
            else
                State = "Branch";
            List<Student> Students = departmentmodel.Students.Where(S => S.Age > 25).ToList();

            DeptInfoViewModel Department = new DeptInfoViewModel()
            {
                DeptName = departmentmodel.Name,
                State = State,
                Students = Students
            };

            return View("ShowDetailsVM", Department);
        }
    }
}
