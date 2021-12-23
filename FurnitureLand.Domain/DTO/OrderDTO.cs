using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FurnitureLand.Domain.DTO
{
    public class OrderDTO
    {
        public Guid? Id { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderStatus { get; set; }

        public DateTime DateOfDelivery { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid? CustomerInventoryId { get; set; }

        [NotMapped]
        //tax 10%
        public float Tax => 10;

        [NotMapped]
        public List<OrderItemDTO> OrderItems { get; set; }
    }

    public class OrderItemDTO
    {
        public Guid? Id { get; set; }

        public Guid OrderId { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public ColorDTO Color { get; set; }

        public ColorDTO Material { get; set; }


        /// <summary>
        /// this is for orderitem
        /// </summary>
        public string OrderStatus { get; set; }

        public bool AnyLostDuringShipment { get; set; }
    }

    public class PaymentDTO
    {
        public string OrderId { get; set; }
        public float Total { get; set; }
        public float Tax { get; set; }
        public float Discount { get; set; }
        public float GrandTotal { get; set; }
    }

    public class ColorDTO
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }

    public class MaterialDTO
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}
