﻿using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class SchoolService : ISchoolService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SchoolService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<SchoolDto> GetAllSchools(bool trackChanges)
        {
            try
            {
                var schools = _repository.School.GetAllSchools(trackChanges);
                var schoolsDto = _mapper.Map<IEnumerable<SchoolDto>>(schools);
                return schoolsDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllSchools)} service method {ex}");
                throw;
            }
        }
    }

    
}
