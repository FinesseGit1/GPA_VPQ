using Application.API.Service;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;
        private readonly IProductService productService;

        public ProductController(IProductService productService,
            ILogger<ProductController> logger)
        {
            this.logger = logger;
            this.productService = productService;
        }
        [HttpGet("GetProducts")]
        public async Task<IEnumerable<ProductDetails>> Get()
        {
            return await productService.GetProductDetailsAsync();
        }
    }
}
