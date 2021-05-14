using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Abstractions
{
    public interface IRepository<TEntity> where TEntity: IBaseEntity
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity, Guid id);
        Task DeleteAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
    }
}
