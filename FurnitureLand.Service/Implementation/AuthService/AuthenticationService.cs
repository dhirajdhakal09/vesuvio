using FurnitureLand.Domain.DTO;
using FurnitureLand.Domain.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureLand.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<Customers> _userManager;
        private readonly IJwtService _jwtService;

        public AuthenticationService(UserManager<Customers> userManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _jwtService = jwtService;
        }

        public async Task<AuthenticationResponse> Authenticate(string username, string password)
        {
            var dbUser = username.Contains("@") ? await _userManager.FindByEmailAsync(username) : await _userManager.FindByNameAsync(username);

            if (dbUser != null)
            {
                var result = await _userManager.CheckPasswordAsync(dbUser, password);

                if (result)
                {
                    var authenticationResult = new AuthenticationResponse
                    {
                        Token = _jwtService.GenerateJWT(dbUser),
                        //TokenExpirationUTC = DateTime.UtcNow.AddMinutes(5),
                        FirstName = dbUser.Name,
                    };
                    return authenticationResult;
                }
            }

            throw new Exception("Invalid username or password.");
        }
    }
}
