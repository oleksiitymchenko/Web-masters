using DAL.Abstractions.Repositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Impl.Adonet.Repositories
{
    public class ArticleInOrderRepository : IArticleInOrderRepository
    {
        public Task<ArticleInOrder> CreateAsync(ArticleInOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticleInOrder>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ArticleInOrder> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ArticleInOrder entity, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
