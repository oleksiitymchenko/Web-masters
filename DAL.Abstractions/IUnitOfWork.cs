using DAL.Abstractions.Repositories;
using System.Threading.Tasks;

namespace DAL.Abstractions
{
    public interface IUnitOfWork
    {
        public IArticleInOrderRepository ArticleInOrderRepository { get; }
        public IArticleRepository ArticleRepository { get; }
        public ICustomerRepository CustomerRepository { get; }
        public IDescriptionRepository DescriptionRepository { get; }
        public IDescriptionInArticleRepository DescriptionInArticleRepository { get; }

        public Task<int> SaveChangesAsync();
    }
}
