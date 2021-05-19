using DAL.Abstractions.Repositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Impl.Adonet.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        public Task<Article> CreateAsync(Article entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Article>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Article> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Article entity, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
