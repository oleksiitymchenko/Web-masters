using System;

namespace Common
{
    public class DescriptionInArticleDto
    {
        public Guid Id { get; set; }

        public Guid DescriptionId { get; set; }
        public Guid ArticleId { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
