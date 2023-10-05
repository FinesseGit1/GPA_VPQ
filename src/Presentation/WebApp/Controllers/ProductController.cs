using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services.Contracts;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService productService;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _logger = logger;
            this.productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await productService.GetAllProducts();
            return View(result.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductDetails product)
        {
            //do the logic
            return RedirectToAction("Index");
        }
    }
}
