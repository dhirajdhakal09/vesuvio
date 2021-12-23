using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using FurnitureLand.Domain.DTO;
using FurnitureLand.Domain.Model;

namespace FurnitureLand.Service.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Customer
            CreateMap<UserDTO, Customers>().ReverseMap();
            CreateMap<Inventories, InventoryDTO>().ReverseMap();
            CreateMap<OrderDTO, Orders>().ReverseMap();
            CreateMap<OrderItemDTO, OrderItems>().ReverseMap();
            CreateMap<PaymentDTO, Payments>().ReverseMap();
        }
    }
}
