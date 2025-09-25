using Day02.Models;

namespace Day02.ViewModels
{
    public class DeptInfoViewModel
    {
        public string DeptName { get; set; }
        public string State { get; set; }
        public List<Student> Students { get; set; }
    }
}
