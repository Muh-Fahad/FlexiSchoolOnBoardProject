using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class SubjectForCreationDto
    {
        public int Id { get; set; }
        [Required]
        public  string Name { get; set; }
    }
}
