using AutoMapper;
using EBook.API.Data.DTOs;
using EBook.API.Data.DTOs.UserDTOs;
using EBook.API.Data.Entities;
using StoreApp.API.Data.DTOs.UserDTOs;

namespace StoreApp.API.Data.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User,UserRegisterDTO>().ReverseMap();

            CreateMap<Item, ItemDTO>().ReverseMap();
            CreateMap<Sale, SaleItemDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();

        }
    }
}
 