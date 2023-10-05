using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.API.Repository
{
    public interface IVendorInvitationFormRepository
    {
       Task<List<VendorInvitationForm>> GetAllUsersAsync();
        Task<List<VendorInvitationForm>> CreateUsersAsync();
        Task<int> CreateUsersAsync1(VendorInvitationFormViewModel VendorInvitationFormViewModel);
        Task<int> CreateInvitation_Business_User(VendorInvitationFormViewModel VendorInvitationFormViewModel);
        Task<List<VendorInvitationForm>> GetAllBUssinessVerticalAsync();
    }
}
