using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseSchedulesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCourseSchedules()
        {
            var schedules = new List<CourseSchedule>()
            {
                new CourseSchedule
                {
                    ScheduleId = 1,
                    CourseId = 101,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(10, 30, 0),
                    Room = "Room A"
                },
                new CourseSchedule
                {
                    ScheduleId = 2,
                    CourseId = 102,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(11, 0, 0),
                    EndTime = new TimeSpan(12, 30, 0),
                    Room = "Room B"
                }
            };
            return Ok(schedules);
        }
        
        [HttpGet("{courseId}")]
        public IActionResult getCourceSchedulesByID(int courseId)
        {
            var schedule = new CourseSchedule
            {
                ScheduleId = 3,
                CourseId = courseId,
                DayOfWeek = DayOfWeek.Friday,
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(15, 30, 0),
                Room = "Room C"
            };
            return Ok(schedule);
        }        
    }
}
