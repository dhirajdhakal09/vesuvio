using FurnitureLand.Domain.DTO;
using FurnitureLand.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureLand.Service
{
    public class JwtService : IJwtService
    {
        private readonly UserManager<Customers> _userManager;
        //private readonly RoleManager<Role> _roleManager;
        private readonly JwtConfiguration _jwtConfiguration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JwtService(UserManager<Customers> userManager,
                               //RoleManager<Role> roleManager,
                               IOptions<JwtConfiguration> jwtOptions,
                               IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            //_roleManager = roleManager;
            _jwtConfiguration = jwtOptions.Value;
            _httpContextAccessor = httpContextAccessor;
        }

        public string GenerateJWT(Customers user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var scKey = Encoding.UTF8.GetBytes(_jwtConfiguration.Key);
            var signingSymmetricSecurityKey = new SymmetricSecurityKey(scKey);
            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                //new Claim(ClaimTypes.Role, System.Text.Json.JsonSerializer.Serialize(await GetUserRolesIdAsync(user)))
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Audience = _jwtConfiguration.Issuer,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(_jwtConfiguration.ExpireTimeInMinutes),
                SigningCredentials = new SigningCredentials(signingSymmetricSecurityKey, SecurityAlgorithms.HmacSha512),
                Issuer = _jwtConfiguration.Issuer
            };

            var token =  tokenHandler.CreateJwtSecurityToken(tokenDescriptor);
            return (tokenHandler.WriteToken(token));
        }
    }
}
