using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInstructors()
        {
            var instructors = new List<Instructor>
            {
                new Instructor
                {
                    InstructorId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@email.com",
                    Phone = "1234567890",
                    HireDate = new DateTime(2020, 1, 15),
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            CourseId = 1,
                            CourseCode = "CS101",
                            CourseName = "Introduction to Computer Science",
                            Credits = 3,
                            InstructorId = 1
                        },
                        new Course
                        {
                            CourseId = 2,
                            CourseCode = "CS102",
                            CourseName = "Programming Basics",
                            Credits = 4,
                            InstructorId = 1
                        }
                    }
                },
                new Instructor
                {
                    InstructorId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@email.com",
                    Phone = "9876543210",
                    HireDate = new DateTime(2019, 6, 10),
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            CourseId = 3,
                            CourseCode = "CS201",
                            CourseName = "Data Structures",
                            Credits = 4,
                            InstructorId = 2
                        }
                    }
                }
            };

            return Ok(instructors);
        }

        // GET: api/instructors/1
        [HttpGet("{id}")]
        public IActionResult GetInstructorById(int id)
        {
            var instructor = new Instructor
            {
                InstructorId = id,
                FirstName = "Michael",
                LastName = "Brown",
                Email = "michael.brown@email.com",
                Phone = "5551234567",
                HireDate = new DateTime(2018, 3, 20),
                Courses = new List<Course>
                {
                    new Course
                    {
                        CourseId = 4,
                        CourseCode = "CS301",
                        CourseName = "Algorithms",
                        Credits = 4,
                        InstructorId = id
                    },
                    new Course
                    {
                        CourseId = 5,
                        CourseCode = "CS302",
                        CourseName = "Operating Systems",
                        Credits = 4,
                        InstructorId = id
                    }
                }
            };

            return Ok(instructor);
        }

        // POST: api/instructors
        [HttpPost]
        public IActionResult CreateInstructor([FromBody] Instructor instructor)
        {
            instructor.InstructorId = 100;
            instructor.HireDate = DateTime.UtcNow;

            return CreatedAtAction(
                nameof(GetInstructorById),
                new { id = instructor.InstructorId },
                instructor
            );
        }
    }
}
