using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface ILectureTheatreRepository
    {
        Task<IEnumerable<LectureTheatre>> ListAsync(CancellationToken cancellationToken = default);

        Task<LectureTheatre> GetByIdAsync(int Id, CancellationToken cancellationToken = default);

        void Add(LectureTheatre LectureTheatre);

        void Delete(LectureTheatre LectureTheatre);
    }
}
