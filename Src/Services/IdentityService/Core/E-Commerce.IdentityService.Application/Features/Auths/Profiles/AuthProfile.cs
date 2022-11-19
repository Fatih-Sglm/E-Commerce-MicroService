using AutoMapper;
using E_Commerce.IdentityService.Application.Features.Auths.Dtos;
using E_Commerce.IdentityService.Domain.Entities.Identity;

namespace E_Commerce.IdentityService.Application.Features.Auths.Profiles
{
    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            CreateMap<RegisterDto, AppUser>();
        }
    }
}
