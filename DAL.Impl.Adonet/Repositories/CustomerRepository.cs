using DAL.Abstractions.Repositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Impl.Adonet.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<Customer> CreateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Customer entity, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
