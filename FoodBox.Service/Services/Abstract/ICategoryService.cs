using FoodBox.Entity.DTOs.Categories;

namespace FoodBox.Service.Services.Abstract
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
    }
}
