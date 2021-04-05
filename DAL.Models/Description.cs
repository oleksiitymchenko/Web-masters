using System;

namespace DAL.Models
{
    public class Description : IBaseEntity
    {
        public Guid Id { get; set; }
        
        public string DescriptionTextSmall { get; set; }
        public string DescriptionTextFull { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
