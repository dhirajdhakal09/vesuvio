using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class Payments
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Orders")]
        public Guid OrderId { get; set; }

        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public double Total { get; set; }
        public double Tax { get; set; }
        public double Discount { get; set; }
        public double GrandTotal { get; set; }
    }
}
