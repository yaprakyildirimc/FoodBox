using AutoMapper;
using FoodBox.Entity.DTOs.Stores;
using FoodBox.Entity.Entities;

namespace FoodBox.Service.AutoMapper.Stores
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<StoreDto, Store>().ReverseMap();
        }
    }
}
