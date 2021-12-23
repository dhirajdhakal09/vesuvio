using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class Orders : BaseModel
    {
        public DateTime OrderDate { get; set; }

        [ForeignKey("Customers")]
        public Guid CustomerId { get; set; }

        [ForeignKey("CustomerInventories")]
        public Guid CustomerInventoryId { get; set; }

        public DateTime? DateOfDelivery { get; set; }

        /// <summary>
        /// Can be complete/cancelled/whole order can be lost in shippment
        /// </summary>
        public string OrderStatus { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual CustomerInventories CustomerInventories { get; set; }
    }
}
