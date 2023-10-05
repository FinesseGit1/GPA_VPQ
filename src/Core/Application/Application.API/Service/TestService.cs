using Application.API.Repository;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.API.Service
{
    
    public class TestService : ITestService
    {
        private readonly ITestRepository TestRepository;
        public TestService(ITestRepository TestRepository)
        {
            this.TestRepository = TestRepository;
        }

        public async Task<List<TestViewModel>> CreateUsersAsync()
        {
            //return await UserMgmtRepository.CreateUsersAsync();


            var result = await TestRepository.GetAllUsersAsync();

            return result.Select(x => new TestViewModel()
            {
                LoginId = x.LoginId,
                UserName = x.UserName,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();
            //throw new NotImplementedException();
        }

        public async Task<List<TestViewModel>> GetAllUsersAsync()
        {
            var result = await TestRepository.GetAllUsersAsync();
            return result.Select(x => new TestViewModel()
            {
                UserName = x.UserName,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();
        }

        public async Task<int> CreateUsersAsync1(TestViewModel TestViewModel)
        {
            //return await UserMgmtRepository.CreateUsersAsync();


            var result = await TestRepository.CreateUsersAsync1(TestViewModel);
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
