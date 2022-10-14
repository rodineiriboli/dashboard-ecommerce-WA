using AutoMapper;
using EcommerceWA.Application.DTO;
using EcommerceWA.Domain.Entities;
using EcommerceWA.Domain.Queries;

namespace EcommerceWA.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Password,
                    map => map.MapFrom(src => "-"));

            CreateMap<PurchaseOrderQuery, PurchaseOrderQueryDto>();
        }
    }
}
