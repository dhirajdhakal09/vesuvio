using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class CustomerFeedbacks : BaseModel
    {
        [ForeignKey("Customers")]
        public Guid CustomerId { get; set; }
        public virtual Customers Customers { get; set; }

        public string Feedback { get; set; }
    }
}
