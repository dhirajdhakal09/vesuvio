using System;
using System.ComponentModel.DataAnnotations;

namespace FurnitureLand.Domain.Model
{
    public class Catalogs 
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
