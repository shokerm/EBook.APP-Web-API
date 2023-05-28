using AutoMapper;
using EBook.API.Data.Entities;
using StoreApp.API.Data.DTOs.UserDTOs;

namespace StoreApp.API.Data.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User,UserRegisterDTO>().ReverseMap();
        }
    }
}
 