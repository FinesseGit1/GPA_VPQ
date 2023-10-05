using Application.API.Repository;
using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.API.Service
{
    public  class UserMgmtService : IUserMgmtService
    {
        private readonly IUserMgmtRepository UserMgmtRepository;
        public UserMgmtService(IUserMgmtRepository UserMgmtRepository)
        {
            this.UserMgmtRepository = UserMgmtRepository;
        }

        public async Task<List<UserMgmtViewModel>> CreateUsersAsync()
        {
            //return await UserMgmtRepository.CreateUsersAsync();


            var result = await UserMgmtRepository.GetAllUsersAsync();
            
            return result.Select(x => new UserMgmtViewModel()
            {
                LoginId=x.LoginId,
                UserName = x.UserName,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();
            //throw new NotImplementedException();
        }

        public async Task<List<UserMgmtViewModel>> GetAllUsersAsync()
        {
            var result= await UserMgmtRepository.GetAllUsersAsync();
            return result.Select(x => new UserMgmtViewModel()
            {
                UserName = x.UserName,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();
        }

        public async Task<int> CreateUsersAsync1(UserMgmtViewModel userMgmtViewModel)
        {
            //return await UserMgmtRepository.CreateUsersAsync();


            var result = await UserMgmtRepository.CreateUsersAsync1(userMgmtViewModel);
            return Convert.ToInt32(result);

            //return result.Select(x => new UserMgmtViewModel()
            //{
            //    LoginId = x.LoginId,
            //    UserName = x.UserName,
            //    Email = x.Email,
            //    Phone = x.Phone
            //}).ToList();
            //throw new NotImplementedException();
        }

        //public async Task<List<UserMgmt>> GetProductDetailsAsync()
        //{
        //    return await UserMgmtRepository.GetProductDetailsAsync();
        //}
    }
}
