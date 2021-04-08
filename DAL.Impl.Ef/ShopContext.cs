using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Impl.Ef
{
    public class ShopContext:DbContext
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArticleInOrder> ArticleInOrder { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Description> Description { get; set; }
        public virtual DbSet<DescriptionInArticle> DescriptionInArticle { get; set; }
    }
}
