using System;

namespace DAL.Models
{
    public class Article : IBaseEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public double SKU { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
