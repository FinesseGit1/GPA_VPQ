using Domain.ViewModel;

namespace WebApp.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDetailsViewModel>> GetAllProducts();
    }
}
