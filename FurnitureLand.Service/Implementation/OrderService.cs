using AutoMapper;
using FurnitureLand.Core;
using FurnitureLand.Domain.DTO;
using FurnitureLand.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureLand.Service
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool>  CreateOrderAsync(OrderDTO order)
        {
            IGenericRepository<Orders> repository = _unitOfWork.GetRepository<Orders>();
            IGenericRepository<OrderItems> repositoryOrderItems = _unitOfWork.GetRepository<OrderItems>();
            IGenericRepository<Payments> repositoryPayments = _unitOfWork.GetRepository<Payments>();

            Orders dbOrder = _mapper.Map<OrderDTO, Orders>(order);
            dbOrder.Id = Guid.NewGuid();

            //insert into orderitems
            repository.Add(dbOrder);
            float total = 0;
            order.OrderItems.ForEach(orderItem =>
            {
                OrderItems dbOrderItem = _mapper.Map<OrderItemDTO, OrderItems>(orderItem);
                dbOrderItem.OrderId = dbOrder.Id;
                dbOrderItem.Id = Guid.NewGuid();
                dbOrderItem.CustomerId = (Guid)order.CustomerId;
                dbOrderItem.CustomerInventoryId = (Guid)order.CustomerInventoryId;
                
                total += dbOrderItem.Price * dbOrderItem.Quantity;
                repositoryOrderItems.Add(dbOrderItem);
            });

            // insert into payments
            Payments payment = new Payments
            {
                Id = Guid.NewGuid(),
                Discount = 0,
                OrderId = dbOrder.Id,
                PaymentMethod = "OnDelivery",
                PaymentStatus = "Pending",
                Tax = order.Tax,
                Total = total,
                GrandTotal = total + (order.Tax * total)
            };

            repositoryPayments.Add(payment);

            bool status = await Task.FromResult(_unitOfWork.SaveInTransaction());

            // other tasks 
            // The data should also be subtracted from the inventory after successful payment
            // this will be th future work due to time constraint.
            return status;
        }
    }
}
