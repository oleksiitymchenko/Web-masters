using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBaseService<TEntityDto>
    {
        Task<TEntityDto> CreateAsync(TEntityDto entityDto);
        Task<TEntityDto> UpdateAsync(TEntityDto entityDto, Guid id);
        Task<bool> DeleteAsync(Guid id);
        Task<TEntityDto> GetByIdAsync(Guid id);
        Task<List<TEntityDto>> GetAllAsync();
    }
}
