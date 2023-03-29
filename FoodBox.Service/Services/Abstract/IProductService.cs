using FoodBox.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBox.Service.Services.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
    }
}
