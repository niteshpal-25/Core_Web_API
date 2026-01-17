using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Enrollment> Enrollments { get; set; }
    }

}
