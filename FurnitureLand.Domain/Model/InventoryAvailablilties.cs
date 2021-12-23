using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    /// <summary>
    /// For keeping information regarding the available inventories
    /// </summary>
    public class InventoryAvailablilties : BaseModel
    {
        //public Guid CustomerId { get; set; }

        [ForeignKey("Inventories")]
        public Guid InventoryId { get; set; }

        [ForeignKey("Materials")]
        public Guid? MaterialId { get; set; }

        [ForeignKey("Colors")]
        public Guid? ColorId { get; set; }

        public bool IsAvailable { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public virtual Inventories Inventories { get; set; }
        public virtual Materials Materials { get; set; }
        public virtual Colors Colors { get; set; }
    }
}
