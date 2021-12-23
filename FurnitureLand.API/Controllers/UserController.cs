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
    [Route("api/user")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<UserDTO> usersData = await _userService.GetAllUsersAsync();

                if (usersData.Count() > 0) return Ok(usersData);

                return NotFound();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Post([FromBody] UserDTO userDTO)
        {
            try
            {
                if (await _userService.CreateAsync(userDTO)) return Ok();
                else return BadRequest("Internal Server Error. Contact Adminsitrator");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Put([FromBody] UserDTO userDTO)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync((Guid)userDTO.Id);
                if (user == null) return BadRequest();

                if (await _userService.UpdateAsync(userDTO)) return Ok();
                else return BadRequest("Internal Server Error. Contact Adminsitrator");
            }
            catch(Exception ex)
            {
                throw ex;
            }      
        }
    }
}
