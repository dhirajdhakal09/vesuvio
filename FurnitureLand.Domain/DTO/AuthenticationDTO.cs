using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureLand.Domain.DTO
{
    public class AuthenticationRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class AuthenticationResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }
        public DateTime TokenExpiration { get; set; }
    }

    public class JwtConfiguration
    {
        public const string SECTION_NAME = "JWT";
        public string Key { get; set; }
        public int ExpireTimeInMinutes { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    }
}
