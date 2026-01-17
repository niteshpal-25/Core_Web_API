using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = new List<Student>
            {
                new Student
                {
                    StudentID = 1,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@email.com",
                    Phone = "1234567890",
                    DateOfBirth = new DateTime(2001, 5, 12),
                    CreatedAt = DateTime.UtcNow,
                    Enrollments = new List<Enrollment>
                    {
                        new Enrollment
                        {
                            EnrollmentId = 1,
                            CourseId = 1,
                            StudentId = 1,
                            EnrollmentDate = DateTime.UtcNow
                        }
                    }
                },
                new Student
                {
                    StudentID = 2,
                    FirstName = "Bob",
                    LastName = "Smith",
                    Email = "bob.smith@email.com",
                    Phone = "9876543210",
                    DateOfBirth = new DateTime(2000, 10, 20),
                    CreatedAt = DateTime.UtcNow,
                    Enrollments = new List<Enrollment>
                    {
                        new Enrollment
                        {
                            EnrollmentId = 2,
                            CourseId = 2,
                            StudentId = 2,
                            EnrollmentDate = DateTime.UtcNow
                        }
                    }
                }
            };

            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = new Student
            {
                StudentID = id,
                FirstName = "Charlie",
                LastName = "Brown",
                Email = "charlie.brown@email.com",
                Phone = "5551234567",
                DateOfBirth = new DateTime(2002, 3, 8),
                CreatedAt = DateTime.UtcNow,
                Enrollments = new List<Enrollment>
                {
                    new Enrollment
                    {
                        EnrollmentId = 3,
                        CourseId = 3,
                        StudentId = id,
                        EnrollmentDate = DateTime.UtcNow
                    }
                }
            };

            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            student.StudentID = 100;
            student.CreatedAt = DateTime.UtcNow;

            return CreatedAtAction(
                nameof(GetStudentById),
                new { id = student.StudentID },
                student
            );
        }
    }
}
