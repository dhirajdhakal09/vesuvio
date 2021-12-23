using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class CompanyCustomerBuyers : BaseModel
    {
        [ForeignKey("Customers")]
        public Guid CustomerId { get; set; }
        [ForeignKey("Buyers")]
        public Guid BuyerId { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual Buyers Buyers { get; set; }
    }
}
