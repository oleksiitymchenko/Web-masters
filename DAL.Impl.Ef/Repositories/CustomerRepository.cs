using DAL.Abstractions.Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public Task<Customer> CreateAsync(Customer entity)
        {
            var result = _ctx.Add(entity);
            return Task.FromResult(result.Entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var res = await _ctx.Customer.FirstOrDefaultAsync(x => x.Id == id);
            _ctx.Remove(res);
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _ctx.Customer.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            return await _ctx.Customer.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Customer entity, Guid id)
        {
            var dbEntity = await _ctx.Customer.FirstOrDefaultAsync(x => x.Id == id);
            dbEntity.Name = entity.Name;
            dbEntity.PhoneNumber = entity.PhoneNumber;
            dbEntity.DefaultAddress = entity.DefaultAddress;
        }
    }
}
