using Application.API.Service;
using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMgmtController : Controller
    {
        private readonly ILogger<UserMgmtController> logger;
        private readonly IUserMgmtService userMgmtService;
        public UserMgmtController(IUserMgmtService userMgmtService, 
            ILogger<UserMgmtController> logger)
        {
            this.userMgmtService = userMgmtService;
            this.logger= logger;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IEnumerable<UserMgmtViewModel>>  GetAllUsers()
        {
            return await userMgmtService.GetAllUsersAsync();
        }

        [HttpGet("CreateUsers")]
        public async Task<IEnumerable<UserMgmtViewModel>> CreateUsers()
        {
            return await userMgmtService.CreateUsersAsync();
        }

        [Route("CreateUsers1")]
        [HttpPost]
        public async Task<int> CreateUsers1([FromBody] UserMgmtViewModel userMgmtViewModel)
        {
           // return await Task.FromResult(1);
            return await userMgmtService.CreateUsersAsync1(userMgmtViewModel);
        }
    }
}
