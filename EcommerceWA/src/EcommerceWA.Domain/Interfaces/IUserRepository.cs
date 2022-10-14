using EcommerceWA.Domain.Entities;

namespace EcommerceWA.Domain.Interfaces
{
    public interface IUserRepository
    {
        User Get(string userName, string password);
    }
}
