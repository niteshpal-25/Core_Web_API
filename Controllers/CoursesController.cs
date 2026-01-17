using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetCourses()
        {
            var courses = new List<Course>()
            {
                new Course
                {
                    CourseId = 1,
                    CourseCode = "CS101",
                    CourseName = "Introduction to Computer Science",
                    Description = "Basics of computer science",
                    Credits = 3,
                    InstructorId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Course
                {
                    CourseId = 2,
                    CourseCode = "CS201",
                    CourseName = "Data Structures",
                    Description = "Learn data structures",
                    Credits = 4,
                    InstructorId = 2,
                    CreatedAt = DateTime.UtcNow
                }
            };
            return Ok(courses);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetCourseById(int id)
        {
            var course = new Course
            {
                CourseId = id,
                CourseCode = "CS301",
                CourseName = "Algorithms",
                Description = "Algorithm design and analysis",
                Credits = 4,
                InstructorId = 3,
                CreatedAt = DateTime.UtcNow
            };

            return Ok(course);
        }

        [HttpPost]
        public IActionResult CreateCourse([FromBody] Course course)
        {
            course.CourseId = 100;
            course.CreatedAt = DateTime.UtcNow;

            return CreatedAtAction(nameof(GetCourseById), new { id = course.CourseId }, course);
        }
    }
}
