using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureLand.Domain.Model
{
    public class Customers : IdentityUser<Guid>
    {
        [StringLength(100)]
        public string Name { get; set; }

        //for students
        [StringLength(100)]
        public string School { get; set; }

        //for home/office
        [StringLength(100)]
        public string BusinessInfo { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(15)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string ShippingMethod { get; set; }

        [ForeignKey("CustomerTypes")]
        public Guid? CustomerTypeId { get; set; }

        public virtual CustomerTypes CustomerTypes { get; set; }

        /*[ForeignKey("CompanyCustomerBuyers")]
        public Guid? CustomerBuyerId { get; set; }

        public virtual CompanyCustomerBuyers CompanyCustomerBuyers { get; set; }*/

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}

