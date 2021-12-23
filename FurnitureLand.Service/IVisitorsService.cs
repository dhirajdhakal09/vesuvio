using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureLand.Domain.Model;

namespace FurnitureLand.Service
{
    public interface IFurnitureLandsService
    {
        IEnumerable<FurnitureLand.Domain.DTO.FurnitureLandDTO> GetFurnitureLands();
        FurnitureLand.Domain.DTO.FurnitureLandDTO GetCheckedInFurnitureLand();
        bool UpdateFurnitureLand(Domain.DTO.FurnitureLandDTO dto);
        bool CreateFurnitureLand(Domain.DTO.FurnitureLandDTO dto);
    }
}
