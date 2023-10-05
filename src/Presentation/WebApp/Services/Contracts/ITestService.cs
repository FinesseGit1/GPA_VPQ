using Domain.ViewModel;

namespace WebApp.Services.Contracts
{
    public interface ITestService
    {
        Task<IEnumerable<TestViewModel>> GetAllUsers();
        Task<int> CreateUsersTest(TestViewModel TestViewModel);
    }
}