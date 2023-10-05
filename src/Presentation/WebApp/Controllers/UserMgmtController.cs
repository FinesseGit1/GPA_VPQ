using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Services.Contracts;

namespace WebApp.Controllers
{
    public class UserMgmtController : Controller 
    {
        private readonly IUserMgmtService userMgmtService;
        private readonly ILogger<UserMgmtController> logger;
        public UserMgmtController(IUserMgmtService userMgmtService,ILogger <UserMgmtController> logger) {
            this.userMgmtService = userMgmtService;
                this.logger= logger;

        }
        //List<UserMgmtViewModel> dummy = new List<UserMgmtViewModel>()
        //    {
        //        new UserMgmtViewModel(){ LoginId ="id001", Email = "test@test1.com", Role="Manager", UserName="test@test1.com" },
        //        new UserMgmtViewModel(){ LoginId ="id002", Email = "test@test2.com", Role="Manager", UserName="test@test2.com" },
        //        new UserMgmtViewModel(){ LoginId ="id003", Email = "test@test3.com", Role="Manager", UserName="test@test3.com" },
        //        new UserMgmtViewModel(){ LoginId ="id004", Email = "test@test4.com", Role="Manager", UserName="test@test4.com" },
        //    };
        [HttpPost ("SaveUser")]
        public async Task<IActionResult> SaveUser(UserMgmtViewModel userModel)
        {
             var result= await this.userMgmtService.CreateUsers(userModel);
            //return View("CreateUserListPartial");

            return View(result);
        }

        [HttpPost ("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UserMgmtViewModel userModel)
        {
            return View(userModel);
        }
        public async Task<IActionResult> Index()
        {

            var result = await userMgmtService.GetAllUsers();
            return View(result);
        }
        public IActionResult IndexWithPartial()
        {
            return View();
        }
        [HttpPost]
        //public async Task<IActionResult> Create(UserMgmt userMgmt)
        //{
        //    //do the logic
        //    var result = await userMgmtService.cre();
        //    return RedirectToAction("IndexWithPartial");
        //}
        public async Task<IActionResult> ShowUserListPartial()
        {
            //var result = await productService.GetAllProducts();
            var result = await userMgmtService.GetAllUsers();
            return PartialView("_ListUsers", result);
        }
        public IActionResult CreateUserListPartial()
        {


            //Creating the List of SelectListItem, this list you can bind from the database.
            List<SelectListItem> cities = new()
            {
                new SelectListItem { Value = "1", Text = "Latur" },
                new SelectListItem { Value = "2", Text = "Solapur" },
                new SelectListItem { Value = "3", Text = "Nanded" },
                new SelectListItem { Value = "4", Text = "Nashik" },
                new SelectListItem { Value = "5", Text = "Nagpur" },
                new SelectListItem { Value = "6", Text = "Kolhapur" },
                new SelectListItem { Value = "7", Text = "Pune" },
                new SelectListItem { Value = "8", Text = "Mumbai" },
                new SelectListItem { Value = "9", Text = "Delhi" },
                new SelectListItem { Value = "10", Text = "Noida" }
            };

            List<SelectListItem> region = new()
            {
                new SelectListItem { Value = "1", Text = "Latur" },
                new SelectListItem { Value = "2", Text = "Solapur" },
                new SelectListItem { Value = "3", Text = "Nanded" },
                new SelectListItem { Value = "4", Text = "Nashik" },
                new SelectListItem { Value = "5", Text = "Nagpur" },
                new SelectListItem { Value = "6", Text = "Kolhapur" },
                new SelectListItem { Value = "7", Text = "Pune" },
                new SelectListItem { Value = "8", Text = "Mumbai" },
                new SelectListItem { Value = "9", Text = "Delhi" },
                new SelectListItem { Value = "10", Text = "Noida" }
            };

            //assigning SelectListItem to view Bag
            ViewBag.cities = cities;
            ViewBag.region = region;



            return PartialView("_CreateUser", new UserMgmtViewModel() { LoginId = "some data" } );
        }
    }
}
