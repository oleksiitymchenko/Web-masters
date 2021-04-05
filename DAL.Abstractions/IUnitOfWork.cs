using DAL.Abstractions.Repositories;

namespace DAL.Abstractions
{
    public interface IUnitOfWork
    {
        public IArticleInOrderRepository ArticleInOrderRepository { get; set; }
        public IArticleRepository ArticleRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        public IDescriptionRepository DescriptionRepository { get; set; }
        public IDescriptionInArticleRepository DescriptionInArticleRepository { get; set; }
    }
}
