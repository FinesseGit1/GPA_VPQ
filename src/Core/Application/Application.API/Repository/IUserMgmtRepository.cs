using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.API.Repository
{
    public interface IUserMgmtRepository
    {
        Task<List<UserMgmt>> GetAllUsersAsync();
        Task<List<UserMgmt>> CreateUsersAsync();
        Task<int> CreateUsersAsync1(UserMgmtViewModel userMgmtViewModel);
    }
}
