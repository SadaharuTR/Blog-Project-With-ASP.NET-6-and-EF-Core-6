using AutoMapper;
using Blog.Entity.DTOs.Roles;
using Blog.Entity.Entities;

namespace Blog.Service.AutoMapper.Roles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<AppUser, RoleDto>().ReverseMap();
        }
    }
}
