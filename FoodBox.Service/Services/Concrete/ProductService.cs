using FoodBox.Data.UnitOfWorks;
using FoodBox.Entity.Entities;
using FoodBox.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBox.Service.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await unitOfWork.GetRepository<Product>().GetAllAsync();
        }
    }
}
