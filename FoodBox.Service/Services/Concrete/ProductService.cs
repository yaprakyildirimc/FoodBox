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
        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
           var products =  await unitOfWork.GetRepository<Product>().GetAllAsync();
           var map = mapper.Map<List<ProductDto>>(products);

            return map;
        }
    }
}
