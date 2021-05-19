using DAL.Abstractions.Repositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Impl.Adonet.Repositories
{
    public class DescriptionRepository : IDescriptionRepository
    {
        public Task<Description> CreateAsync(Description entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Description>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Description> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Description entity, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
