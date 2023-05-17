namespace SchoolManagementSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public int CourseYear { get; set; }


        public Teacher Teacher { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
