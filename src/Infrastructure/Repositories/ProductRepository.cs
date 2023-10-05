using Application.API.Repository;
using Dapper;
using Domain.Entities;
using Infrastructure.DbContext;
using Microsoft.Extensions.Logging;
using System.Data;

namespace Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ILogger<ProductRepository> logger, IDataAccess dataAccess) : base(logger, dataAccess)
        {
        }

        public async Task<List<ProductDetails>> GetProductDetailsAsync()
        {
            var result = await base.WithConnection(async c =>
             {
                 return await c.QueryAsync<ProductDetails>("select * from dbo.tbl_Product", commandType: CommandType.Text);
             });
            return result.ToList();
        }
    }
}
