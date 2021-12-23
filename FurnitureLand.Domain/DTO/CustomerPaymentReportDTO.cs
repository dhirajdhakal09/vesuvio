using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureLand.Domain.DTO
{
    public class CustomerPaymentReportDTO
    {
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public string Email { get; set; }
        public OrderDTO Order { get; set; }
        public PaymentDTO Payment { get; set; }
    } 
}
