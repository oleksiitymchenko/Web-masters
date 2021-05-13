using System;

namespace Common
{
    public class ArticleDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public double SKU { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
