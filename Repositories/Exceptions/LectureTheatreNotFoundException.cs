using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Exceptions
{
    public sealed class LectureTheatreNotFoundException : NotFoundException
    {
        public LectureTheatreNotFoundException(int id)
            : base($"The Lecture Theater with the id {id} was not found.")
        {
        }
    }
}
