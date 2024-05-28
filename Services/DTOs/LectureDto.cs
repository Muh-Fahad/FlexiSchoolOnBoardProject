using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class LectureDto
    {
        public int Id { get; set; }
        [Required]
        public  WeeklyScheduleDto WeeklySchedule { get; set; }
        public int SubjectId { get; set; }
        [Required]
        public  SubjectDto Subject { get; set; }
        public int LectureTheatreId { get; set; }
     [Required]
    public  LectureTheatreDto LectureTheatre{ get; set; }
}

 

}
