

namespace DataAccessLayer.Exceptions
{
    public class EnrollmentException : Exception
    {
        public EnrollmentException() : base("Enrollment exceed capacity or student weekly schedule.")
        {
        }
    }
}
