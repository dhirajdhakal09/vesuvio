using AutoMapper;
using FurnitureLand.Core;
using FurnitureLand.Domain.DTO;
using FurnitureLand.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FurnitureLand.Service
{
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReportService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CustomerPaymentReportDTO> GenerateReportAsync(Guid customerId)
        {
            IGenericRepository<Orders> repository = _unitOfWork.GetRepository<Orders>();
            IGenericRepository<OrderItems> repositoryOrderItems = _unitOfWork.GetRepository<OrderItems>();
            IGenericRepository<Payments> repositoryPayments = _unitOfWork.GetRepository<Payments>();

            //as of now it is assumed one order per customer
            var customerOrder = repository.GetQuerable().Where(q => q.CustomerId == customerId && q.OrderStatus != "Paid").
                Include(q => q.Customers).ThenInclude(q => q.CustomerTypes).FirstOrDefault();

            if (customerOrder == null) throw new Exception("No customer to generate report");
            var orderItems = new List<OrderItems>();

            CustomerPaymentReportDTO report = new CustomerPaymentReportDTO();

            report.CustomerName = customerOrder.Customers.Name;//.Select(q => q.Customers.Name).FirstOrDefault();
            report.CustomerType = customerOrder.Customers.CustomerTypes.Name;//.Select(q => q.Customers.CustomerTypes.Name).FirstOrDefault();
            report.Email = customerOrder.Customers.Email;//  Select(q => q.Customers.Email).FirstOrDefault();

            OrderDTO dto = new OrderDTO();
            dto = _mapper.Map<Orders, OrderDTO>(customerOrder);
            var customerOrderItems = repositoryOrderItems.GetQuerable().Where(q => q.OrderId == customerOrder.Id).ToList();
            List<OrderItemDTO> orderItemsDTOs = customerOrderItems.Select(q => _mapper.Map<OrderItems, OrderItemDTO>(q)).ToList();
            dto.OrderItems = orderItemsDTOs;

            report.Order = dto;

            var payments = repositoryPayments.GetQuerable().Where(q => q.OrderId == customerOrder.Id).FirstOrDefault();

            var paymentDTO = _mapper.Map<Payments, PaymentDTO>(payments);

            report.Payment = paymentDTO;

            return await Task.FromResult(report);
        }
    }
}
