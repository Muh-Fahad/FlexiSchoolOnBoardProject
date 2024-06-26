﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services.DTOs;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ILectureService
    {
        Task<LectureDto> AddAsync(LectureForCreationDto LectureForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<LectureDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<LectureDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
