using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class WeeklyScheduleDto
    {
        public DayOfWeek DayOfWeek { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}")]
        public string StartTime { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
