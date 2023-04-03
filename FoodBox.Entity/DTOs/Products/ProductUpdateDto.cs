using FoodBox.Entity.DTOs.Categories;
using FoodBox.Entity.DTOs.Stores;

namespace FoodBox.Entity.DTOs.Products
{
    public class ProductUpdateDto
    {
        public Guid Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public Guid CategoryId { get; set; }

        public Guid StoreId { get; set; }
        public IList<StoreDto> Stores { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
