using System;
using System.ComponentModel.DataAnnotations;

namespace FurnitureLand.Domain.Model
{
    public class CustomerTypes
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
