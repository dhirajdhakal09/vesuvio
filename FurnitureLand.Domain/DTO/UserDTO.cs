using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FurnitureLand.Domain.DTO
{
    public class UserDTO : AuthenticationRequest
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        //for students
        public string School { get; set; }

        //for home/office
        public string BusinessInfo { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string ShippingMethod { get; set; }

        public Guid CustomerTypeId { get; set; }

        [NotMapped]
        public List<CompanyBuyers> CompanyBuyers  { get; set; }
    }

    public class CompanyBuyers
    {
        public Guid? Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
