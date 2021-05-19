using DAL.Abstractions.Repositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Impl.Adonet.Repositories
{
    public class DescriptionInArticleRepository : IDescriptionInArticleRepository
    {
        public Task<DescriptionInArticle> CreateAsync(DescriptionInArticle entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DescriptionInArticle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DescriptionInArticle> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DescriptionInArticle entity, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
