using Application.API.Repository;
using Domain.Entities;

namespace Application.API.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<List<ProductDetails>> GetProductDetailsAsync()
        {
            return await productRepository.GetProductDetailsAsync();
        }
    }
}
