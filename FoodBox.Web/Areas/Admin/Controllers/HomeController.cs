using FoodBox.Service.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodBox.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task <IActionResult> Index()
        {
            var products = await productService.GetAllProductsAsync();
            return View(products);
        }
    }
}
