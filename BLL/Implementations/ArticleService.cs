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
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleService(
            IUnitOfWork unitOfWork, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ArticleDto> CreateAsync(ArticleDto entityDto)
        {
            var entity = _mapper.Map<Article>(entityDto);
            var created = await _unitOfWork.ArticleRepository.CreateAsync(entity);
            return _mapper.Map<ArticleDto>(created);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            await _unitOfWork.ArticleRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<ArticleDto>> GetAllAsync()
        {
            var list= await _unitOfWork.ArticleRepository.GetAllAsync();
            var result = _mapper.Map<List<ArticleDto>>(list);
            return result;
        }

        public async Task<ArticleDto> GetByIdAsync(Guid id)
        {
            var entity = await _unitOfWork.ArticleRepository.GetByIdAsync(id);
            var result = _mapper.Map<ArticleDto>(entity);
            return result;
        }

        public async Task<ArticleDto> UpdateAsync(ArticleDto entityDto, Guid id)
        {
            var entityToUpdate = _mapper.Map<Article>(entityDto);
            await _unitOfWork.ArticleRepository.UpdateAsync(entityToUpdate, id);
            return entityDto;
        }
    }
}
