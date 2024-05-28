using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Exceptions
{
    public class CapacityExceedingException : Exception
    {
        public CapacityExceedingException(int id)
           : base($"The capacity of lecture theater has exceed the limit. You cannot add students to the lecture with the id {id}.")
        {
        }
    }
}
