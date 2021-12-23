using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class OrderItems : BaseModel
    {
        [ForeignKey("Orders")]
        public Guid OrderId { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("Customers")]
        public Guid CustomerId { get; set; }

        [ForeignKey("CustomerInventories")]
        public Guid CustomerInventoryId { get; set; }

        [ForeignKey("Materials")]
        public Guid? MaterialId { get; set; }

        [ForeignKey("Colors")]
        public Guid? ColorId { get; set; }

        public float Price { get; set; }

        /// <summary>
        /// Status for individual item
        /// Can be complete or cancelled
        /// </summary>
        public string OrderStatus { get; set; }

        public bool AnyLostDuringShipment { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual CustomerInventories CustomerInventories { get; set; }
        public virtual Materials Materials { get; set; }
        public virtual Colors Colors { get; set; }
    }
}
