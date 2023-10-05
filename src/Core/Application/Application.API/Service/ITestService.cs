using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.API.Service
{
    
    
    public interface ITestService
    {
        Task<List<TestViewModel>> GetAllUsersAsync();

        Task<List<TestViewModel>> CreateUsersAsync();


        Task<int> CreateUsersAsync1(TestViewModel testViewModel);
    }
}
