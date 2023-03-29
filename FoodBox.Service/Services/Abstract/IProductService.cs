using FoodBox.Entity.DTOs.Products;

namespace FoodBox.Service.Services.Abstract
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsAsync();
    }
}