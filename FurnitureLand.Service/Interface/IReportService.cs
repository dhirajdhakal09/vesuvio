using FurnitureLand.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureLand.Service
{
    public interface IReportService
    {
        Task<CustomerPaymentReportDTO> GenerateReportAsync(Guid customerId);
    }
}
