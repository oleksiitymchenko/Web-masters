using DAL.Abstractions;
using DAL.Abstractions.Repositories;
using DAL.Impl.Ef.Repositories;
using System.Threading.Tasks;

namespace DAL.Impl.Ef
{
    public class UnitOfWork : IUnitOfWork
    {
        private IArticleInOrderRepository articleInOrderRepository;
        private IArticleRepository articleRepository;
        private ICustomerRepository customerRepository;
        private IDescriptionRepository descriptionRepository;
        private IDescriptionInArticleRepository descriptionInArticleRepository;
        private readonly ShopContext _ctx;

        public UnitOfWork(ShopContext ctx)
        {
            _ctx = ctx; 
        }

        public IArticleInOrderRepository ArticleInOrderRepository
        {
            get
            {
                if (articleInOrderRepository == null)
                {
                    articleInOrderRepository = new ArticleInOrderRepository(_ctx);
                }
                return articleInOrderRepository;
            }
        }
        public IArticleRepository ArticleRepository
        {
            get
            {
                if (articleRepository == null)
                {
                    articleRepository = new ArticleRepository(_ctx);
                }
                return articleRepository;
            }
        }
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(_ctx);
                }
                return customerRepository;
            }
        }
        public IDescriptionRepository DescriptionRepository
        {
            get
            {
                if (descriptionRepository == null)
                {
                    descriptionRepository = new DescriptionRepository(_ctx);
                }
                return descriptionRepository;
            }
        }
        public IDescriptionInArticleRepository DescriptionInArticleRepository
        {
            get
            {
                if (descriptionInArticleRepository == null)
                {
                    descriptionInArticleRepository = new DescriptionInArticleRepository(_ctx);
                }
                return descriptionInArticleRepository;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _ctx.SaveChangesAsync();
        }
    }
}
