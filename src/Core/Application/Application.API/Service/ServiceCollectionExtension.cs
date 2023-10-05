using Microsoft.Extensions.DependencyInjection;

namespace Application.API.Service
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserMgmtService, UserMgmtService>();
            services.AddScoped<IVendorInvitationFormService, VendorInvitationFormService>();
        }
    }
}
