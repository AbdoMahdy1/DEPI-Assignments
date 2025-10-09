using Day02.Models;
using System.ComponentModel.DataAnnotations;

namespace Day02.ViewModels
{
    public class CourseDeptViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(50, ErrorMessage = "Course name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Course degree is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Course degree must be greater than 0")]
        public int Degree { get; set; }

        [Required(ErrorMessage = "Minimum degree is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Minimum degree must be greater than 0")]
        public int MinDegree { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public int DepartmentId { get; set; }

        public List<Department> Departments { get; set; }
    }

    public class StudentCourseResultViewModel
    {
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public int Grade { get; set; }
        public int MinDegree { get; set; }
        public bool IsPassed { get; set; }
    }
}
