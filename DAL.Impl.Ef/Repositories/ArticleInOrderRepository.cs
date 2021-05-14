using DAL.Abstractions.Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Impl.Ef.Repositories
{
    public class ArticleInOrderRepository : IArticleInOrderRepository
    {
        private readonly ShopContext _ctx;

        public ArticleInOrderRepository(ShopContext ctx)
        {
            _ctx = ctx;
        }

        public Task<ArticleInOrder> CreateAsync(ArticleInOrder entity)
        {
            var result = _ctx.Add(entity);
            return Task.FromResult(result.Entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var res = await _ctx.ArticleInOrder.FirstOrDefaultAsync(x => x.Id == id);
            _ctx.Remove(res);
        }

        public async Task<List<ArticleInOrder>> GetAllAsync()
        {
            return await _ctx.ArticleInOrder.ToListAsync();
        }

        public async Task<ArticleInOrder> GetByIdAsync(Guid id)
        {
            return await _ctx.ArticleInOrder.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(ArticleInOrder entity, Guid id)
        {
            var dbEntity = await _ctx.ArticleInOrder.FirstOrDefaultAsync(x => x.Id == id);
            dbEntity.ArticleId = entity.ArticleId;
            dbEntity.OrderId = entity.OrderId;
        }
    }
}
