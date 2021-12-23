using AutoMapper;
using FurnitureLand.Core;
using FurnitureLand.Domain.DTO;
using FurnitureLand.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FurnitureLand.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<Customers> _userManager;
        private readonly JwtConfiguration _jwtConfiguration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(UserManager<Customers> userManager,
                               IOptions<JwtConfiguration> jwtOptions,
                               IHttpContextAccessor httpContextAccessor,
                               IUnitOfWork unitOfWork,
                               IMapper mapper)
        {
            _userManager = userManager;
            _jwtConfiguration = jwtOptions.Value;
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            IGenericRepository<Customers> repository = _unitOfWork.GetRepository<Customers>();
            var users = repository.Get(q => q.DeletedDate == null).ToList();

            var userDTO = users.Select(q=>_mapper.Map<Customers, UserDTO>(q)).ToList();

            return await Task.FromResult(userDTO);
            
        }

        public async Task<UserDTO> GetUserByIdAsync(Guid Id)
        {
            IGenericRepository<Customers> repository = _unitOfWork.GetRepository<Customers>();
            Customers user =  await repository.GetByIdAsync(Id);

            UserDTO userDTO = _mapper.Map<Customers, UserDTO>(user);

            return userDTO;
        }

        public async Task<bool> CreateAsync(UserDTO userRequest)//, string password)
        {
            Customers dbUser = _mapper.Map<UserDTO, Customers>(userRequest);

            var result = await _userManager.CreateAsync(dbUser, userRequest.Password);
            return (result.Succeeded) ? true : false;
        }

        public async Task<bool> UpdateAsync(UserDTO userRequest)
        {
            Customers dbUser = _mapper.Map<UserDTO, Customers>(userRequest);
            var result = await _userManager.UpdateAsync(dbUser);

            return (result.Succeeded) ? true : false;
        }

        /*public async Task<bool> DeleteAsync(Guid[] userId)
        {

        }*/

    }
}
