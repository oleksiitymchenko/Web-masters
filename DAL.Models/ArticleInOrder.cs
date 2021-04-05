using System;

namespace DAL.Models
{
    public class ArticleInOrder : IBaseEntity
    {
        public Guid Id { get; set; }

        public Article Article { get; set; }
        public Guid ArticleId { get; set; }

        public Order Order { get; set; }
        public Guid OrderId { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
