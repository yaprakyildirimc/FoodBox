using AutoMapper;
using FoodBox.Data.UnitOfWorks;
using FoodBox.Entity.DTOs.Products;
using FoodBox.Entity.Entities;
using FoodBox.Service.Services.Abstract;

namespace FoodBox.Service.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task CreateProductAsync(ProductAddDto productAddDto)
        {
            var userId = Guid.Parse("E6C8D1CD-1B18-473A-B68A-7B3CB247307D");

            var product = new Product
            {
                ProductCode = productAddDto.ProductCode,
                ProductName = productAddDto.ProductName,
                Brand = productAddDto.Brand,
                Stock = productAddDto.Stock,
                CategoryId = productAddDto.CategoryId,
                StoreId = productAddDto.StoreId,
                UserId = userId
            };

            await unitOfWork.GetRepository<Product>().AddSync(product);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<ProductDto>> GetAllProductsWithCategoryNonDeletedAsync()
        
        {
           var products =  await unitOfWork.GetRepository<Product>().GetAllAsync(x => !x.IsDeleted, x=> x.Category, x => x.Store);
           var map = mapper.Map<List<ProductDto>>(products);

            return map;
        }
    }
}
