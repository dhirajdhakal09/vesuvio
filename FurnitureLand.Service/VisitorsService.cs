using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using FurnitureLand.Core;
using FurnitureLand.Domain.Model;
using FurnitureLand.Domain.DTO;

namespace FurnitureLand.Service
{
    public class FurnitureLandsService// : IFurnitureLandsService
    {
        /*private IUnitOfWork _uow;
        public FurnitureLandsService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IEnumerable<FurnitureLand.Domain.DTO.FurnitureLandDTO> GetFurnitureLands()
        {
            try
            {
                IEnumerable<FurnitureLand.Domain.DTO.FurnitureLandDTO> FurnitureLands = _uow.GetRepository<FurnitureLand.Domain.Model.FurnitureLand>().GetAll()
                    .OrderBy(p => p.Name).Select(dto=>new Domain.DTO.FurnitureLandDTO 
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Address = dto.Address,
                    Phone = dto.Phone,
                    CheckInTime = dto.CheckInTime,
                    CheckOutTime = dto.CheckOutTime,
                    CheckInStatus = dto.CheckInStatus
                });

                return FurnitureLands;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public FurnitureLand.Domain.DTO.FurnitureLandDTO GetCheckedInFurnitureLand()
        {
            try
            {
                FurnitureLandDTO FurnitureLand = _uow.GetRepository<FurnitureLand.Domain.Model.FurnitureLand>().Get(q => q.CheckInStatus == false, q=>q.CheckInTime, SortOrder.Ascending).Select(dto => new Domain.DTO.FurnitureLandDTO
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Address = dto.Address,
                    Phone = dto.Phone,
                    CheckInTime = dto.CheckInTime,
                    CheckOutTime = dto.CheckOutTime,
                    CheckInStatus = dto.CheckInStatus
                }).FirstOrDefault();

                return FurnitureLand;
                    
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public bool CreateFurnitureLand(FurnitureLandDTO dto)
        {
            IGenericRepository<FurnitureLand.Domain.Model.FurnitureLand> repository = this._uow.GetRepository<FurnitureLand.Domain.Model.FurnitureLand>();

            FurnitureLand.Domain.Model.FurnitureLand FurnitureLand = new FurnitureLand.Domain.Model.FurnitureLand
            {
                Name = dto.Name,
                Address = dto.Address,
                Phone = dto.Phone,
                CheckInTime = dto.CheckInTime.ToLocalTime(),
                CheckOutTime = dto.CheckOutTime.ToLocalTime(),
                CheckInStatus = false
            };
            repository.Add(FurnitureLand);

            if (_uow.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateFurnitureLand(FurnitureLandDTO dto)
        {
            IGenericRepository<FurnitureLand.Domain.Model.FurnitureLand> repository = this._uow.GetRepository<FurnitureLand.Domain.Model.FurnitureLand>();
            FurnitureLand.Domain.Model.FurnitureLand FurnitureLand = repository.GetById(dto.Id);
            FurnitureLand.CheckInStatus = true;
            //FurnitureLand = new FurnitureLand.Domain.Model.FurnitureLand
            //{
            //    Id = dto.Id,
            //    Name = dto.Name,
            //    Address = dto.Address,
            //    Phone = dto.Phone,
            //    CheckInTime = dto.CheckInTime,
            //    CheckOutTime = dto.CheckOutTime,
            //    CheckInStatus = dto.CheckInStatus
            //};

            repository.Update(FurnitureLand);

            if (_uow.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
