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
        public Task<TEntityDto> Create(TEntityDto entityDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntityDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDto> Update(TEntityDto entityDto, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
