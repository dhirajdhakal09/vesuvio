using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class LostShipments
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Orders")]
        public Guid? OrderId { get; set; }

        [ForeignKey("OrderItems")]
        public Guid? OrderItemId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double Total { get; set; }
    }
}
