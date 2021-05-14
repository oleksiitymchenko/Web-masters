using DAL.Abstractions.Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Impl.Ef.Repositories
{
    public class DescriptionRepository : IDescriptionRepository
    {
        private readonly ShopContext _ctx;

        public DescriptionRepository(ShopContext ctx)
        {
            _ctx = ctx;
        }

        public Task<Description> CreateAsync(Description entity)
        {
            var result = _ctx.Add(entity);
            return Task.FromResult(result.Entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var res = await _ctx.Description.FirstOrDefaultAsync(x => x.Id == id);
            _ctx.Remove(res);
        }

        public async Task<List<Description>> GetAllAsync()
        {
            return await _ctx.Description.ToListAsync();
        }

        public async Task<Description> GetByIdAsync(Guid id)
        {
            return await _ctx.Description.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Description entity, Guid id)
        {
            var dbEntity = await _ctx.Description.FirstOrDefaultAsync(x => x.Id == id);
            dbEntity.DescriptionTextFull = entity.DescriptionTextFull;
            dbEntity.DescriptionTextSmall = entity.DescriptionTextSmall;
        }
    }
}
