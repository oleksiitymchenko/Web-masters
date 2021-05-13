using System;

namespace Common
{
    public class ArticleInOrderDto
    {
        public Guid Id { get; set; }

        public Guid ArticleId { get; set; }
        public Guid OrderId { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
