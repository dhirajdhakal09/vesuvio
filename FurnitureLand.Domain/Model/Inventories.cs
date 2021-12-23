using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class Inventories : BaseModel
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public string FinishedProductSize { get; set; }
        public string FinishedProductWeight { get; set; }
        public string Price { get; set; }

        [ForeignKey("Catalogs")]
        public Guid CatalogId { get; set; }

        public virtual Catalogs Catalogs { get; set; }

        [ForeignKey("CustomerTypes")]
        public Guid CustomerTypeId { get; set; }

        public virtual CustomerTypes CustomerTypes { get; set; }
        //public DateTime? LeadTime { get; set; }
    }
}

