using DAL.Abstractions.Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DAL.Impl.Ef.Repositories
{
    public class DescriptionInArticleRepository : IDescriptionInArticleRepository
    {
        private readonly ShopContext _ctx;

        public DescriptionInArticleRepository(ShopContext ctx)
        {
            _ctx = ctx;
        }

        public Task<DescriptionInArticle> Create(DescriptionInArticle entity)
        {
            var result = _ctx.Add(entity);
            return Task.FromResult(result.Entity);
        }

        public async Task Delete(Guid id)
        {
            var res = await _ctx.DescriptionInArticle.FirstOrDefaultAsync(x => x.Id == id);
            _ctx.Remove(res);
        }

        public async Task<DescriptionInArticle> GetById(Guid id)
        {
            return await _ctx.DescriptionInArticle.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(DescriptionInArticle entity, Guid id)
        {
            var dbEntity = await _ctx.DescriptionInArticle.FirstOrDefaultAsync(x => x.Id == id);
            dbEntity.ArticleId = entity.ArticleId;
            dbEntity.DescriptionId = entity.DescriptionId;
        }
    }
}
