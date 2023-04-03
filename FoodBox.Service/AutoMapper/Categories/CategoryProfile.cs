using AutoMapper;
using FoodBox.Entity.DTOs.Categories;
using FoodBox.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBox.Service.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
        }
    }
}
