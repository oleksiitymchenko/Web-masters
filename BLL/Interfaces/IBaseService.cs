using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBaseService<TEntityDto>
    {
        Task<TEntityDto> Create(TEntityDto entityDto);
        Task<TEntityDto> Update(TEntityDto entityDto, Guid id);
        Task<bool> Delete(Guid id);
        Task<TEntityDto> GetById(Guid id);
        Task<List<TEntityDto>> GetAll();
    }
}
