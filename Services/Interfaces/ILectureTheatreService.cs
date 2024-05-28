using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services.Interfaces
{
    public interface ILectureTheatreService
    {
        Task<LectureTheatreDto> AddAsync(LectureTheatreForCreationDto LectureTheatreForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<LectureTheatreDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<LectureTheatreDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
