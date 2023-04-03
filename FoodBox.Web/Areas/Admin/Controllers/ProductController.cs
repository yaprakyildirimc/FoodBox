using FoodBox.Entity.DTOs.Products;
using FoodBox.Service.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodBox.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IStoreService storeService;

        public ProductController(IProductService productService, ICategoryService categoryService, IStoreService storeService) 
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.storeService = storeService;
        }
        public async Task <IActionResult> Index()
        {
            var products = await productService.GetAllProductsWithCategoryNonDeletedAsync();
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var stories = await storeService.GetAllStoresWithNonDeleted();
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ProductAddDto { Categories = categories, Stores = stories});
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddDto productAddDto)
        {
            await productService.CreateProductAsync(productAddDto);
            
            var stories = await storeService.GetAllStoresWithNonDeleted();
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ProductAddDto { Categories = categories, Stores = stories });
        }

        

    }
}
