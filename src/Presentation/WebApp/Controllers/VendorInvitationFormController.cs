using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Services.Contracts;

namespace WebApp.Controllers
{
    public class VendorInvitationFormController : Controller
    {
        private readonly IVendorInvitationFormService VendorInvitationFormService;
        private readonly ILogger<VendorInvitationFormController> logger;
        public VendorInvitationFormController(IVendorInvitationFormService VendorInvitationFormService, ILogger<VendorInvitationFormController> logger)
        {
            this.VendorInvitationFormService = VendorInvitationFormService;
            this.logger = logger;

        }
       
        [HttpPost("CreateVendorInvitation")]
        public async Task<IActionResult> CreateVendorInvitation(VendorInvitationFormViewModel VendorInvitationFormModel)
        {
            var result = await this.VendorInvitationFormService.CreateVendorInvitation(VendorInvitationFormModel);
            //return View("CreateUserListPartial");

            return View("Index");
        }

        [HttpPost("CreateInvitation_Business_User")]
        public async Task<IActionResult> CreateInvitation_Business_User(VendorInvitationFormViewModel VendorInvitationFormModel)
        {
            var result = await this.VendorInvitationFormService.CreateInvitation_Business_User(VendorInvitationFormModel);
            //return View("CreateUserListPartial");

            return View("Index");
        }

        [HttpPost("UpdateUser")]
        public async Task<IActionResult> UpdateUser(VendorInvitationFormViewModel VendorInvitationFormModel)
        {
            return View(VendorInvitationFormModel);
        }
        public async Task<IActionResult> Index()
        {

            //var result = await VendorInvitationFormService.GetAllUsers();
            //return View(result);
            return View();
        }
        
        
        
        



            
        
    }
}
