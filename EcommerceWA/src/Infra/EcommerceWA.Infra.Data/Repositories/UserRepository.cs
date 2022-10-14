using EcommerceWA.Domain.Entities;
using EcommerceWA.Domain.Interfaces;
using EcommerceWA.Infra.Data.Context;
using System.Linq;

namespace EcommerceWA.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EcommerceWADbContext context;
        public UserRepository(EcommerceWADbContext context)
        {
            this.context = context;
        }
        public User Get(string userName, string password)
        {
            return context.User.FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }
    }
}
