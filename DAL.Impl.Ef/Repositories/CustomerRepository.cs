using DAL.Abstractions.Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DAL.Impl.Ef.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ShopContext _ctx;

        public CustomerRepository(ShopContext ctx)
        {
            _ctx = ctx;
        }

        public Task<Customer> Create(Customer entity)
        {
            var result = _ctx.Add(entity);
            return Task.FromResult(result.Entity);
        }

        public async Task Delete(Guid id)
        {
            var res = await _ctx.Customer.FirstOrDefaultAsync(x => x.Id == id);
            _ctx.Remove(res);
        }

        public async Task<Customer> GetById(Guid id)
        {
            return await _ctx.Customer.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Customer entity, Guid id)
        {
            var dbEntity = await _ctx.Customer.FirstOrDefaultAsync(x => x.Id == id);
            dbEntity.Name = entity.Name;
            dbEntity.PhoneNumber = entity.PhoneNumber;
            dbEntity.DefaultAddress = entity.DefaultAddress;
        }
    }
}
