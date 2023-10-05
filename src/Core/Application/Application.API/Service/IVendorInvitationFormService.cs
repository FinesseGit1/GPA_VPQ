using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.API.Service
{
    public interface IVendorInvitationFormService
    {
        Task<List<VendorInvitationFormViewModel>> GetAllUsersAsync();

        Task<List<VendorInvitationFormViewModel>> CreateUsersAsync();

        Task<List<VendorInvitationFormViewModel>> GetAllBUssinessVerticalAsync();

        Task<int> CreateUsersAsync1(VendorInvitationFormViewModel vendorInvitationFormViewModel);
        Task<int> CreateInvitation_Business_User(VendorInvitationFormViewModel vendorInvitationFormViewModel);
    }
}
