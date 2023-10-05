using Domain.ViewModel;
using Newtonsoft.Json;
using WebApp.Services.Contracts;

namespace WebApp.Services
{
    public class ProductService : IProductService
    {
        private readonly BackendAPIService backendAPI;
        private readonly ILogger<ProductService> logger;

        public ProductService(BackendAPIService backendAPI, ILogger<ProductService> logger)
        {
            this.backendAPI = backendAPI;
            this.logger = logger;
        }

        public async Task<IEnumerable<ProductDetailsViewModel>> GetAllProducts()
        {
            var response = await this.backendAPI.Client.GetAsync("api\\Product\\GetProducts");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(result) ? null : JsonConvert.DeserializeObject<List<ProductDetailsViewModel>>(result);
        }
    }
}
