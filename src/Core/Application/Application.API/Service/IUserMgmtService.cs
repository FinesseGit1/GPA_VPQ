using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.API.Service
{
    public interface IUserMgmtService
    {
        Task<List<UserMgmtViewModel>> GetAllUsersAsync();

        Task<List<UserMgmtViewModel>> CreateUsersAsync();


        Task<int> CreateUsersAsync1(UserMgmtViewModel userMgmtViewModel);
    }
}
