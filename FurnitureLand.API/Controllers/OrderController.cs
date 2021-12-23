using FurnitureLand.Domain.DTO;
using FurnitureLand.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureLand.API.Controllers
{
    [Route("api/order")]
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Post(OrderDTO orderDTO)
        {
            bool orderCreate = await _orderService.CreateOrderAsync(orderDTO);
            if (orderCreate) return Ok();
            else return BadRequest();
        }
    }
}
