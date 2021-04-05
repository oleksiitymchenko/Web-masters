using DAL.Models;
using System;
using System.Threading.Tasks;

namespace DAL.Abstractions
{
    interface IRepository<TEntity> where TEntity: IBaseEntity
    {
        Task<TEntity> GetById(Guid id);
        Task<TEntity> Create(TEntity entity);
        Task Update(TEntity entity, Guid id);
        Task Delete(Guid id);
    }
}
