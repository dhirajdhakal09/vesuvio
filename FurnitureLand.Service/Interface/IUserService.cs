using FurnitureLand.Domain.DTO;
using FurnitureLand.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureLand.Service
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(Guid Id);
        Task<bool> CreateAsync(UserDTO userRequest);
        Task<bool> UpdateAsync(UserDTO userRequest);
    }
}
