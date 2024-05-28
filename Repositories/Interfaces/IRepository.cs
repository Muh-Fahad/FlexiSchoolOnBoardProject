
namespace Repositories.Interfaces
{
    public interface IRepository
    {
        IStudentRepository StudentRepository { get; }
        ISubjectRepository SubjectRepository { get; }
        ILectureRepository LectureRepository { get; }
        ILectureTheatreRepository LectureTheatreRepository { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
