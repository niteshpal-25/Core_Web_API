using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime HireDate { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
