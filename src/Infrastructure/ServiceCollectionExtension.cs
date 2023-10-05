using Application.API.Repository;
using Infrastructure.DbContext;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IDataAccess, SqlDataAccess>();

            //Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserMgmtRepository, UserMgmtRepository>();
            services.AddScoped<IVendorInvitationFormRepository, VendorInvitationFormRepository>();
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
