using AutoMapper;
using FoodBox.Entity.DTOs.Products;
using FoodBox.Entity.Entities;

namespace FoodBox.Service.AutoMapper.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, ProductDto>().ReverseMap();
        }
    }
}
