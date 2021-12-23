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
    [Route("api/inventory")]
    public class InventoryController : BaseController
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }


        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<InventoryDTO> inventories = await _inventoryService.GetAvailableInventoriesAsync();

                if (inventories.Count() > 0) return Ok(inventories);

                return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> GetAll([FromQuery] InventorySearchRequest param)
        {
            try
            {
                List<InventoryDTO> inventories = await _inventoryService.SearchInventoryAsync(param);

                if (inventories.Count() > 0) return Ok(inventories);

                return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*[HttpPost]
        [Route("create")]
        public async Task<IActionResult> Post([FromBody] InventoryDTO inventoryDTO)
        {
            try
            {
                if (await _inventoryService.CreateAsync(inventoryDTO)) return Ok();
                else return BadRequest("Internal Server Error. Contact Administrator");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Put([FromBody] InventoryDTO inventoryDTO)
        {
            try
            {
                var Inventory = await _inventoryService.GetInventoryByIdAsync((Guid)inventoryDTO.Id);
                if (Inventory == null) return BadRequest();

                if (await _inventoryService.UpdateAsync(inventoryDTO)) return Ok();
                else return BadRequest("Internal Server Error. Contact Administrator");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
