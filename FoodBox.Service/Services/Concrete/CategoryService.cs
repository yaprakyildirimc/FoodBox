using AutoMapper;
using FoodBox.Data.UnitOfWorks;
using FoodBox.Entity.DTOs.Categories;
using FoodBox.Entity.Entities;
using FoodBox.Service.Services.Abstract;

namespace FoodBox.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(categories);

            return map;
        }
    }
}
