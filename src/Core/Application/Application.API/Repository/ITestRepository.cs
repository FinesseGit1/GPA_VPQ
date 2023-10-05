using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.API.Repository
{
    
    public interface ITestRepository
    {
        Task<List<Test>> GetAllUsersAsync();
        Task<List<Test>> CreateUsersAsync();
        Task<int> CreateUsersAsync1(TestViewModel testViewModel);
    }
}
