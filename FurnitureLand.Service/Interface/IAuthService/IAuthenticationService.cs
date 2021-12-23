using FurnitureLand.Domain.DTO;
using System.Threading.Tasks;

namespace FurnitureLand.Service
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> Authenticate(string username, string password);
    }
}
