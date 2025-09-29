namespace Day02.Models
{
    public class StuCrsResult
    {
        public int CourseId { get; set; }
        public int StuId { get; set; }
        public int Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
