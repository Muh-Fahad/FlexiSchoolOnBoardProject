using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class LectureForCreationDto
    {
        public int Id { get; set; }
        [Required]
        public  WeeklyScheduleDto WeeklySchedule { get; set; }
        public int SubjectId { get; set; }
        public int LectureTheatreId { get; set; }
    }
}
