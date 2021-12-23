using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class CustomerInventories : BaseModel
    {
        [ForeignKey("Customers")]
        public Guid CustomerId { get; set; }

        public virtual Customers Customers { get; set; }

        [ForeignKey("Inventories")]
        public Guid InventoryId { get; set; }

        public virtual Inventories Inventories { get; set; }
    }
}
