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
    public class DescriptionInArticleService : IDescriptionInArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DescriptionInArticleService(
            IUnitOfWork unitOfWork, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DescriptionInArticleDto> CreateAsync(DescriptionInArticleDto entityDto)
        {
            var entity = _mapper.Map<DescriptionInArticle>(entityDto);
            var created = await _unitOfWork.DescriptionInArticleRepository.CreateAsync(entity);
            return _mapper.Map<DescriptionInArticleDto>(created);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            await _unitOfWork.ArticleRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<DescriptionInArticleDto>> GetAllAsync()
        {
            var list= await _unitOfWork.DescriptionInArticleRepository.GetAllAsync();
            var result = _mapper.Map<List<DescriptionInArticleDto>>(list);
            return result;
        }

        public async Task<DescriptionInArticleDto> GetByIdAsync(Guid id)
        {
            var entity = await _unitOfWork.DescriptionInArticleRepository.GetByIdAsync(id);
            var result = _mapper.Map<DescriptionInArticleDto>(entity);
            return result;
        }

        public async Task<DescriptionInArticleDto> UpdateAsync(DescriptionInArticleDto entityDto, Guid id)
        {
            var entityToUpdate = _mapper.Map<DescriptionInArticle>(entityDto);
            await _unitOfWork.DescriptionInArticleRepository.UpdateAsync(entityToUpdate, id);
            return entityDto;
        }
    }
}
