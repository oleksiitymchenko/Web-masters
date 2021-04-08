using DAL.Abstractions.Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DAL.Impl.Ef.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ShopContext _ctx;

        public ArticleRepository(ShopContext ctx)
        {
            _ctx = ctx;
        }

        public Task<Article> Create(Article entity)
        {
            var result = _ctx.Add(entity);
            return Task.FromResult(result.Entity);
        }

        public async Task Delete(Guid id)
        {
            var res = await _ctx.Article.FirstOrDefaultAsync(x => x.Id == id);
            _ctx.Remove(res);
        }

        public async Task<Article> GetById(Guid id)
        {
            return await _ctx.Article.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Article entity, Guid id)
        {
            var dbEntity = await _ctx.Article.FirstOrDefaultAsync(x => x.Id == id);
            dbEntity.Name = entity.Name;
            dbEntity.Price = entity.Price;
            dbEntity.SKU = entity.SKU;
        }
    }
}
