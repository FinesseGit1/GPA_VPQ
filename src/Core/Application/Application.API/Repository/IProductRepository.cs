using Domain.Entities;

namespace Application.API.Repository
{
    public interface IProductRepository
    {
        Task<List<ProductDetails>> GetProductDetailsAsync();
    }
}
