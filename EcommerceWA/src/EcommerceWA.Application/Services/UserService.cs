using AutoMapper;
using EcommerceWA.Application.DTO;
using EcommerceWA.Application.Interfaces;
using EcommerceWA.Domain.Interfaces;

namespace EcommerceWA.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public UserDto Get(string userName, string password)
        {
            var user = userRepository.Get(userName, password);
            var userDto = mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
