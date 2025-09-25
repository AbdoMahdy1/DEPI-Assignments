using Day02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day02.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> students = studentBL.ShowAll();
            return View("ShowAll", students);
        }

        public IActionResult ShowDetails(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student student = studentBL.ShowDetails(id);
            return View("ShowDetails", student);
        }
    }
}
