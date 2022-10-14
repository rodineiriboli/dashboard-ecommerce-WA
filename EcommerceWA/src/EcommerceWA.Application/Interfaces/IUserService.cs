using EcommerceWA.Application.DTO;

namespace EcommerceWA.Application.Interfaces
{
    public interface IUserService
    {
        UserDto Get(string userName, string password);
    }
}
