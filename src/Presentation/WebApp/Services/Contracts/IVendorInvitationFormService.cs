using Domain.ViewModel;

namespace WebApp.Services.Contracts
{
    public interface IVendorInvitationFormService
    {
        Task<IEnumerable<VendorInvitationFormViewModel>> GetAllUsers();
        Task<int> CreateVendorInvitation(VendorInvitationFormViewModel VendorInvitationFormViewModel);

        Task<int> CreateInvitation_Business_User(VendorInvitationFormViewModel VendorInvitationFormViewModel);

        
    }
}
