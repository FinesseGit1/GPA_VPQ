using Domain.ViewModel;

namespace WebApp.Services.Contracts
{
    public interface IUserMgmtService
    {
        Task<IEnumerable<UserMgmtViewModel>> GetAllUsers();
        Task<int> CreateUsers(UserMgmtViewModel userMgmtViewModel);
        //Task<IEnumerable<UserMgmtViewModel>> CreateUsers();
    }
}
