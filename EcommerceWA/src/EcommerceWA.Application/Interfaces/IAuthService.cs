using EcommerceWA.Application.DTO;

namespace EcommerceWA.Application.Interfaces
{
    public interface IAuthService
    {
        string GenerateToken(UserDto user);
    }
}
