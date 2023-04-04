using FoodBox.Entity.DTOs.Products;

namespace FoodBox.Service.Services.Abstract
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsWithCategoryNonDeletedAsync();
        Task<ProductDto> GetProductWithCategoryNonDeletedAsync(Guid productId);
        Task CreateProductAsync(ProductAddDto productAddDto);
        Task UpdateProductAsync(ProductUpdateDto productUpdateDto);
        Task SafeDeleteProductAsync(Guid productId);
    }
}