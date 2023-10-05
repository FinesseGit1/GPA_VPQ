using Application.API.Service;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
   
    public class TestController : Controller
    {
        private readonly ILogger<TestController> logger;
        private readonly ITestService TestService;
        public TestController(ITestService TestService,
            ILogger<TestController> logger)
        {
            this.TestService = TestService;
            this.logger = logger;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IEnumerable<TestViewModel>> GetAllUsers()
        {
            return await TestService.GetAllUsersAsync();
        }

        [HttpGet("CreateUsers")]
        public async Task<IEnumerable<TestViewModel>> CreateUsers()
        {
            return await TestService.CreateUsersAsync();
        }

        [Route("CreateUsers1")]
        [HttpPost]
        public async Task<int> CreateUsers1([FromBody] TestViewModel TestViewModel)
        {
            // return await Task.FromResult(1);
            return await TestService.CreateUsersAsync1(TestViewModel);
        }
    }
}