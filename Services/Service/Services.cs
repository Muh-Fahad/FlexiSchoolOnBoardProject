using DataAccessLayer.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public sealed class Services : IService
    {
        private readonly Lazy<IStudentService> _lazyStudentService;
        private readonly Lazy<ISubjectService> _lazySubjectService;
        private readonly Lazy<ILectureService> _lazyLectureService;
        private readonly Lazy<ILectureTheatreService> _lazyLectureTheatreService;

        public Services(IRepository repositoryManager)
        {
            _lazyStudentService = new Lazy<IStudentService>(() => new StudentService(repositoryManager));
            _lazySubjectService = new Lazy<ISubjectService>(() => new SubjectService(repositoryManager));
            _lazyLectureService = new Lazy<ILectureService>(() => new LectureService(repositoryManager));
            _lazyLectureTheatreService = new Lazy<ILectureTheatreService>(() => new LectureTheatreService(repositoryManager));
        }

        public IStudentService StudentService => _lazyStudentService.Value;
        public ISubjectService SubjectService => _lazySubjectService.Value;
        public ILectureService LectureService => _lazyLectureService.Value;
        public ILectureTheatreService LectureTheatreService => _lazyLectureTheatreService.Value;
    }
}

