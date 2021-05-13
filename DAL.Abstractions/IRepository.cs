using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Abstractions
{
    public interface IRepository<TEntity> where TEntity: IBaseEntity
    {
        Task<TEntity> GetById(Guid id);
        Task<TEntity> Create(TEntity entity);
        Task Update(TEntity entity, Guid id);
        Task Delete(Guid id);
        Task<List<TEntity>> GetAll();
    }
}
