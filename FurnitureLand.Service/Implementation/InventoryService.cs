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
using LinqKit;
using System.Collections.Specialized;

namespace FurnitureLand.Service
{
    public class InventoryService : IInventoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InventoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<InventoryDTO>> GetAvailableInventoriesAsync()
        {
            IGenericRepository<InventoryAvailablilties> repository = _unitOfWork.GetRepository<InventoryAvailablilties>();
            
            var inventories = repository.GetQuerable().Where(q => q.DeletedDate == null && q.IsAvailable == true)
                .Include(q => q.Inventories).ThenInclude(q=>q.CustomerTypes)
                .Include(q => q.Inventories).ThenInclude(q=>q.Catalogs)
                .Include(q=> q.Colors)
                .Include(q=> q.Materials).ToList();

            //List<InventoryDTO> inventoryDTOs = inventories.Select(q => _mapper.Map<Inventories, InventoryDTO>(q.Inventories)).ToList();
            List<InventoryDTO> inventoryDTOs = new List<InventoryDTO>();
            foreach (var inventory in inventories)
            {
                InventoryDTO dto = _mapper.Map<Inventories, InventoryDTO>(inventory.Inventories);
                dto.CustomerType = new CustomerTypeDTO { Id = inventory.Inventories.CustomerTypes.Id, Name = inventory.Inventories.CustomerTypes.Name };
                dto.Color = inventory.Colors.Name;
                dto.Material = inventory.Materials.Name;
                dto.IsAvailable = inventory.IsAvailable;
                dto.Price = inventory.Price;
                inventoryDTOs.Add(dto);
            }

            return await Task.FromResult(inventoryDTOs);
        }

        /// <summary>
        /// Search inventory based on Name, catalog name and price
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<List<InventoryDTO>> SearchInventoryAsync(InventorySearchRequest request)
        {
            //var searchParam = { "Price", "Category", "Name" };
            IGenericRepository<InventoryAvailablilties> repository = _unitOfWork.GetRepository<InventoryAvailablilties>();

            var predicate = PredicateBuilder.New<InventoryAvailablilties>();

            predicate = predicate.And(i => i.DeletedDate == null && i.IsAvailable == true);

            if (!string.IsNullOrEmpty(request.Name))
            {
                predicate = predicate.And(i => i.Inventories.Name.Contains(request.Name));
            }

            if (!string.IsNullOrEmpty(request.CatalogName))
            {
                predicate = predicate.And(i => i.Inventories.Catalogs.Name == request.CatalogName);
            }
            if (!string.IsNullOrEmpty(request.Price.ToString()))
            {
                predicate = predicate.And(i => i.Price == request.Price);
            }

            var inventories = repository.GetQuerable().Where(predicate)
                .Include(q => q.Inventories).ThenInclude(q => q.CustomerTypes)
                .Include(q => q.Inventories).ThenInclude(q => q.Catalogs)
                .Include(q => q.Colors)
                .Include(q => q.Materials).ToList();

            List<InventoryDTO> inventoryDTOs = new List<InventoryDTO>();
            foreach (var inventory in inventories)
            {
                InventoryDTO dto = _mapper.Map<Inventories, InventoryDTO>(inventory.Inventories);
                
                dto.CustomerType = new CustomerTypeDTO { Id = inventory.Inventories.CustomerTypes.Id, Name = inventory.Inventories.CustomerTypes.Name };
                dto.Color = inventory.Colors.Name;
                dto.Material = inventory.Materials.Name;
                dto.IsAvailable = inventory.IsAvailable;
                dto.Price = inventory.Price;
                
                inventoryDTOs.Add(dto);
            }

            return await Task.FromResult(inventoryDTOs);
        }
    }
}
