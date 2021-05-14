using AutoMapper;
using BLL.Interfaces;
using Common;
using DAL.Abstractions;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class DescriptionService : IDescriptionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DescriptionService(
            IUnitOfWork unitOfWork, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DescriptionDto> CreateAsync(DescriptionDto entityDto)
        {
            var entity = _mapper.Map<Description>(entityDto);
            var created = await _unitOfWork.DescriptionRepository.CreateAsync(entity);
            return _mapper.Map<DescriptionDto>(created);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            await _unitOfWork.DescriptionRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<DescriptionDto>> GetAllAsync()
        {
            var list= await _unitOfWork.DescriptionRepository.GetAllAsync();
            var result = _mapper.Map<List<DescriptionDto>>(list);
            return result;
        }

        public async Task<DescriptionDto> GetByIdAsync(Guid id)
        {
            var entity = await _unitOfWork.DescriptionRepository.GetByIdAsync(id);
            var result = _mapper.Map<DescriptionDto>(entity);
            return result;
        }

        public async Task<DescriptionDto> UpdateAsync(DescriptionDto entityDto, Guid id)
        {
            var entityToUpdate = _mapper.Map<Description>(entityDto);
            await _unitOfWork.DescriptionRepository.UpdateAsync(entityToUpdate, id);
            return entityDto;
        }
    }
}
