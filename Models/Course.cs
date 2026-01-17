using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required, MaxLength(20)]
        public string CourseCode { get;set; }
        [Required, MaxLength(200)]
        public string CourseName { get;set;}
        public string Description { get; set; }
        public int Credits { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Instructor Instructor { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
