using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEnrollments()
        {
            var enrollments = new List<Enrollment>
            {
                new Enrollment
                {
                    EnrollmentId = 1,
                    StudentId = 1,
                    CourseId = 1,
                    EnrollmentDate = DateTime.UtcNow,
                    Status = EnrollmentStatus.Enrolled,
                    Grade = null,
                    student = new Student
                    {
                        StudentID = 1,
                        FirstName = "Alice",
                        LastName = "Johnson",
                        Email = "alice@email.com"
                    },
                    course = new Course
                    {
                        CourseId = 1,
                        CourseCode = "CS101",
                        CourseName = "Intro to CS",
                        Credits = 3,
                        InstructorId = 1
                    }
                },
                new Enrollment
                {
                    EnrollmentId = 2,
                    StudentId = 2,
                    CourseId = 2,
                    EnrollmentDate = DateTime.UtcNow,
                    Status = EnrollmentStatus.Completed,
                    Grade = 3.8m,
                    student = new Student
                    {
                        StudentID = 2,
                        FirstName = "Bob",
                        LastName = "Smith",
                        Email = "bob@email.com"
                    },
                    course = new Course
                    {
                        CourseId = 2,
                        CourseCode = "CS201",
                        CourseName = "Data Structures",
                        Credits = 4,
                        InstructorId = 2
                    }
                }
            };

            return Ok(enrollments);
        }

        // GET: api/enrollments/1
        [HttpGet("{id}")]
        public IActionResult GetEnrollmentById(int id)
        {
            var enrollment = new Enrollment
            {
                EnrollmentId = id,
                StudentId = 3,
                CourseId = 3,
                EnrollmentDate = DateTime.UtcNow,
                Status = EnrollmentStatus.Enrolled,
                Grade = null,
                student = new Student
                {
                    StudentID = 3,
                    FirstName = "Charlie",
                    LastName = "Brown",
                    Email = "charlie@email.com"
                },
                course = new Course
                {
                    CourseId = 3,
                    CourseCode = "CS301",
                    CourseName = "Algorithms",
                    Credits = 4,
                    InstructorId = 3
                }
            };

            return Ok(enrollment);
        }

        // POST: api/enrollments
        [HttpPost]
        public IActionResult CreateEnrollment([FromBody] Enrollment enrollment)
        {
            enrollment.EnrollmentId = 100;
            enrollment.EnrollmentDate = DateTime.UtcNow;

            return CreatedAtAction(
                nameof(GetEnrollmentById),
                new { id = enrollment.EnrollmentId },
                enrollment
            );
        }
    }
}
