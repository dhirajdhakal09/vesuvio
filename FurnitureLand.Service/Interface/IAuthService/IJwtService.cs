using FurnitureLand.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureLand.Service
{
    public interface IJwtService
    {
        string GenerateJWT(Customers user);
    }
}
