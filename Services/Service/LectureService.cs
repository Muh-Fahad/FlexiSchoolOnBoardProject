using Mapster;
using Repositories.Entities;
using Repositories.Interfaces;
using Services.DTOs;
using Services.Interfaces;

namespace Services.Service
{
    public class LectureService : ILectureService
    {
        private readonly IRepository _repositoryManager;

        public LectureService(IRepository repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<LectureDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var Lectures = await _repositoryManager.LectureRepository.ListAsync(cancellationToken);

            return Lectures.Adapt<IEnumerable<LectureDto>>();
        }

        public async Task<LectureDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var Lectures = await _repositoryManager.LectureRepository.GetByIdAsync(id, cancellationToken);
           
            return Lectures.Adapt<LectureDto>();
        }

        public async Task<LectureDto> AddAsync(LectureForCreationDto LectureForCreationDto, CancellationToken cancellationToken = default)
        {
            var Lectures = LectureForCreationDto.Adapt<Lecture>();

            _repositoryManager.LectureRepository.Add(Lectures);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Lectures.Adapt<LectureDto>();
        }
    }
}
