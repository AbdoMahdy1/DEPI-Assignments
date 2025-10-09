using Day02.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Day02.ViewModels
{
    public class StudentDeptViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
    }
}
