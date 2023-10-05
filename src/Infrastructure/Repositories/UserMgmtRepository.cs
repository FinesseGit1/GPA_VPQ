using Application.API.Repository;
using Dapper;
using Domain.Entities;
using Domain.ViewModel;
using Infrastructure.DbContext;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class UserMgmtRepository : BaseRepository, IUserMgmtRepository
    {
        public UserMgmtRepository(ILogger<UserMgmtRepository> logger, IDataAccess dataAccess) : base(logger, dataAccess)
        {
        }

        public async Task<List<UserMgmt>> GetAllUsersAsync()
        {
            var result = await base.WithConnection(async c =>
            {
                return await c.QueryAsync<UserMgmt>("Select [USR_User_Name] AS UserName,[USR_Email] AS Email,[USR_Phone] AS Phone from [User_Details]", commandType: CommandType.Text);
            });
            return result.ToList();
        }

        //public async Task<List<UserMgmt>> CreateUsersAsync(string strUserName, string strEmail, string strPhone)
        //{
        //    var result = await base.WithConnection(async c =>
        //    {
        //        return await c.QueryAsync<UserMgmt>("Insert into [User_Details] (USR_User_Name,USR_Email,USR_Phone) Values (strUserName,strEmail,strPhone)", commandType: CommandType.Text);
        //    });
        //    return result.ToList();
        //}

        public Task<List<UserMgmt>> AddUsersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserMgmt>> CreateUsersAsync()
        {
            var result = await base.WithConnection(async c =>
            {
                return await c.QueryAsync<UserMgmt>("Select [USR_User_Name] AS UserName,[USR_Email] AS Email,[USR_Phone] AS Phone from [User_Details] where [USR_User_Name] Like '%J%'", commandType: CommandType.Text);
            });
            return result.ToList();

            //throw new NotImplementedException();
        }


        public async Task<int> CreateUsersAsync1(UserMgmtViewModel userMgmtViewModel)
        {
            

            var result = await base.WithConnection(async c =>
            {
                return await c.ExecuteAsync("Insert into [User_Details] (USR_User_Name,USR_Email,USR_Phone) Values ('"+ userMgmtViewModel.UserName + "','"+ userMgmtViewModel.Email + "','"+ userMgmtViewModel.Phone + "')", commandType: CommandType.Text);
            });
            return result;
            //return Convert.ToInt32(result);

            //throw new NotImplementedException();
        }

        //public async Task<List<UserMgmt>> GetProductDetailsAsync()
        //{
        //    var result = await base.WithConnection(async c =>
        //    {
        //        return await c.QueryAsync<UserMgmt>("select * from dbo.tbl_Product", commandType: CommandType.Text);
        //    });
        //    return result.ToList();
        //}
    }
}
