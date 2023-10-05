using System.Data.Common;

namespace Infrastructure.DbContext
{
    public interface IDataAccess
    {
        DbConnection GetConnection();
    }
}