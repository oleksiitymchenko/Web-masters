using System;

namespace DAL.Models
{
    public class DescriptionInArticle : IBaseEntity
    {
        public Guid Id { get; set; }

        public Description Description { get; set; }
        public Guid DescriptionId { get; set; }
        public Article Article { get; set; }
        public Guid ArticleId { get; set; }
        
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
