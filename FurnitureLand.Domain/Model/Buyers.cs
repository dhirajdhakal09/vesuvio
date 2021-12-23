using System;
using System.ComponentModel.DataAnnotations;

namespace FurnitureLand.Domain.Model
{
    public class Buyers : BaseModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
