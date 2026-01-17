using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{    
    public class CourseSchedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public string Room { get; set; }

        // Navigation
        public Course Course { get; set; }
    }

}
