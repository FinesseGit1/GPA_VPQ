
using Application.API.Service;
using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorInvitationFormController : Controller
    {
        private readonly ILogger<VendorInvitationFormController> logger;
        private readonly IVendorInvitationFormService VendorInvitationFormService;
        public VendorInvitationFormController(IVendorInvitationFormService VendorInvitationFormService,
            ILogger<VendorInvitationFormController> logger)
        {
            this.VendorInvitationFormService = VendorInvitationFormService;
            this.logger = logger;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IEnumerable<VendorInvitationFormViewModel>> GetAllUsers()
        {
            return await VendorInvitationFormService.GetAllUsersAsync();
        }

        [HttpGet("GetBusinessVertical")]
        public async Task<List<VendorInvitationFormViewModel>> GetBusinessVertical()
        {
            return await VendorInvitationFormService.GetAllBUssinessVerticalAsync();
        }

        [HttpGet("CreateUsers")]
        public async Task<IEnumerable<VendorInvitationFormViewModel>> CreateUsers()
        {
            return await VendorInvitationFormService.CreateUsersAsync();
        }

        [Route("CreateVendorInvitation")]
        [HttpPost]
        public async Task<int> CreateVendorInvitation([FromBody] VendorInvitationFormViewModel vendorInvitationFormViewModel)
        {
            // return await Task.FromResult(1);
            return await VendorInvitationFormService.CreateUsersAsync1(vendorInvitationFormViewModel);
        }

        [Route("CreateInvitation_Business_User")]
        [HttpPost]
        public async Task<int> CreateInvitation_Business_User([FromBody] VendorInvitationFormViewModel vendorInvitationFormViewModel)
        {
            // return await Task.FromResult(1);
            return await VendorInvitationFormService.CreateInvitation_Business_User(vendorInvitationFormViewModel);
        }
    }
}