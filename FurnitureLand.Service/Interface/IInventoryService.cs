using FurnitureLand.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureLand.Service
{
    public interface IInventoryService
    {
        Task<List<InventoryDTO>> SearchInventoryAsync(InventorySearchRequest request);
        Task<List<InventoryDTO>> GetAvailableInventoriesAsync();

    }
}
