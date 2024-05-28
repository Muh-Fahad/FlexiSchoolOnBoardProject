using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class LectureTheatreForCreationDto
    {
        public int Id { get; set; }
        [Required]
        public  string Name { get; set; }
        public int Capacity { get; set; }
    }
}
