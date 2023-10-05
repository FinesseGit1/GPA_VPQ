using Domain.Entities;

namespace Application.API.Service
{
    public interface IProductService
    {
        Task<List<ProductDetails>> GetProductDetailsAsync();
    }
}
