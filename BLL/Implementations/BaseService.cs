using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class BaseService<TEntityDto> : IBaseService<TEntityDto>
    {
        public BaseService()
        {

        }
        public Task<TEntityDto> CreateAsync(TEntityDto entityDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntityDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDto> UpdateAsync(TEntityDto entityDto, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
