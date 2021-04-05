using System;

namespace DAL.Models
{
    public class Order : IBaseEntity
    {
        public Guid Id { get; set; }
        
        public double TotalAmount { get; set; }
        public double TaxAmount { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerId{ get; set; }

        public string DeliveryAddress { get; set; }
        public string BillingAddress { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
