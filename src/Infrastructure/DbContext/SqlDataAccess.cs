using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace Infrastructure.DbContext
{
    public class SqlDataAccess : IDataAccess
    {
        private readonly string _connectionString;
        public SqlDataAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        DbConnection IDataAccess.GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}

