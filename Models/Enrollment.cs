using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
        public EnrollmentStatus Status { get; set; }
        public decimal? Grade { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }

    public enum EnrollmentStatus
    {
        Enrolled = 1,
        Completed = 2,
        Dropped = 3
    }

}
