using System;

namespace DAL.Models
{
    public class Customer : IBaseEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string DefaultAddress { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
