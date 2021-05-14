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
    public class ArticleInOrderService : IArticleInOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleInOrderService(
            IUnitOfWork unitOfWork, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ArticleInOrderDto> CreateAsync(ArticleInOrderDto entityDto)
        {
            var entity = _mapper.Map<ArticleInOrder>(entityDto);
            var created = await _unitOfWork.ArticleInOrderRepository.CreateAsync(entity);
            return _mapper.Map<ArticleInOrderDto>(created);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            await _unitOfWork.ArticleInOrderRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<ArticleInOrderDto>> GetAllAsync()
        {
            var list= await _unitOfWork.ArticleInOrderRepository.GetAllAsync();
            var result = _mapper.Map<List<ArticleInOrderDto>>(list);
            return result;
        }

        public async Task<ArticleInOrderDto> GetByIdAsync(Guid id)
        {
            var entity = await _unitOfWork.ArticleInOrderRepository.GetByIdAsync(id);
            var result = _mapper.Map<ArticleInOrderDto>(entity);
            return result;
        }

        public async Task<ArticleInOrderDto> UpdateAsync(ArticleInOrderDto entityDto, Guid id)
        {
            var entityToUpdate = _mapper.Map<ArticleInOrder>(entityDto);
            await _unitOfWork.ArticleInOrderRepository.UpdateAsync(entityToUpdate, id);
            return entityDto;
        }
    }
}
