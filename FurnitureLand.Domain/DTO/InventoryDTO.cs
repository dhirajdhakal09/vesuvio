using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FurnitureLand.Domain.DTO
{
    public class InventoryDTO
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public string FinishedProductSize { get; set; }
        public string FinishedProductWeight { get; set; }
        public float Price { get; set; }

        [NotMapped]
        public CustomerTypeDTO CustomerType { get; set; }
        [NotMapped]
        public bool IsAvailable { get; set; }
        [NotMapped]
        public string Color { get; set; }
        [NotMapped]
        public string Material { get; set; }
    }

    public class InventorySearchRequest
    {
        public string Name { get; set; }

        public string CatalogName { get; set; }

        public float Price { get; set; }
    }

    public class ColorMaterials
    {
        public string Color { get; set; }
        public string Material { get; set; }
    }

}
