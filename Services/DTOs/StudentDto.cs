using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }
        [Required]
        public  string FullName { get; set; }
        public List<SubjectDto> EnrolledSubjects { get; set; } = new List<SubjectDto>();
    }
}
