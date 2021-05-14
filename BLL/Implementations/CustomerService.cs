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
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerService(
            IUnitOfWork unitOfWork, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CustomerDto> CreateAsync(CustomerDto entityDto)
        {
            var entity = _mapper.Map<Customer>(entityDto);
            var created = await _unitOfWork.CustomerRepository.CreateAsync(entity);
            return _mapper.Map<CustomerDto>(created);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            await _unitOfWork.CustomerRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<CustomerDto>> GetAllAsync()
        {
            var list= await _unitOfWork.CustomerRepository.GetAllAsync();
            var result = _mapper.Map<List<CustomerDto>>(list);
            return result;
        }

        public async Task<CustomerDto> GetByIdAsync(Guid id)
        {
            var entity = await _unitOfWork.CustomerRepository.GetByIdAsync(id);
            var result = _mapper.Map<CustomerDto>(entity);
            return result;
        }

        public async Task<CustomerDto> UpdateAsync(CustomerDto entityDto, Guid id)
        {
            var entityToUpdate = _mapper.Map<Customer>(entityDto);
            await _unitOfWork.CustomerRepository.UpdateAsync(entityToUpdate, id);
            return entityDto;
        }
    }
}
