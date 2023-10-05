using Application.API.Repository;
using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.API.Service
{

    
    public class VendorInvitationFormService : IVendorInvitationFormService
    {
        private readonly IVendorInvitationFormRepository VendorInvitationFormRepository;
        public VendorInvitationFormService(IVendorInvitationFormRepository VendorInvitationFormRepository)
        {
            this.VendorInvitationFormRepository = VendorInvitationFormRepository;
        }

        public async Task<List<VendorInvitationFormViewModel>> CreateUsersAsync()
        {
            //return await UserMgmtRepository.CreateUsersAsync();


            var result = await VendorInvitationFormRepository.GetAllUsersAsync();

            return result.Select(x => new VendorInvitationFormViewModel()
            {

                
                SupplierName = x.SupplierName,
                ContactPerson = x.ContactPerson,
                SupplierEmail = x.SupplierEmail,
                SupplierMobile = x.SupplierMobile,
                ProjectName = x.ProjectName,
                InitialSubmitionDeadline = x.InitialSubmitionDeadline,
                GPDOwner = x.GPDOwner,
                Region = x.Region,
                SupplierFormGuideline = x.SupplierFormGuideline,
                CommodityName = x.CommodityName,
                EmailBody = x.EmailBody,
                BusinessUserName = x.BusinessUserName,
                BusinessUserEmail = x.BusinessUserEmail
            }).ToList();
            //throw new NotImplementedException();
        }

        public async Task<List<VendorInvitationFormViewModel>> GetAllUsersAsync()
        {
            var result = await VendorInvitationFormRepository.GetAllUsersAsync();
            return result.Select(x => new VendorInvitationFormViewModel()
            {
                SupplierName = x.SupplierName,
                ContactPerson = x.ContactPerson,
                SupplierEmail = x.SupplierEmail,
                SupplierMobile = x.SupplierMobile,
                ProjectName = x.ProjectName,
                InitialSubmitionDeadline = x.InitialSubmitionDeadline,
                GPDOwner = x.GPDOwner,
                Region = x.Region,
                SupplierFormGuideline = x.SupplierFormGuideline,
                CommodityName = x.CommodityName,
                EmailBody = x.EmailBody,
                BusinessUserName = x.BusinessUserName,
                BusinessUserEmail = x.BusinessUserEmail
            }).ToList();
        }
        public async Task<List<VendorInvitationFormViewModel>> GetAllBUssinessVerticalAsync()
        {
            var result = await VendorInvitationFormRepository.GetAllBUssinessVerticalAsync();
            return result.Select(x => new VendorInvitationFormViewModel()
            {
                BVM_Code = x.BVM_Code,
                BVM_Name = x.BVM_Name
            }).ToList();
        }
        public async Task<int> CreateUsersAsync1(VendorInvitationFormViewModel vendorInvitationFormViewModel)
        {
            //return await UserMgmtRepository.CreateUsersAsync();

            

            var result = await VendorInvitationFormRepository.CreateUsersAsync1(vendorInvitationFormViewModel);
            return Convert.ToInt32(result);

            //return result.Select(x => new UserMgmtViewModel()
            //{
            //    LoginId = x.LoginId,
            //    UserName = x.UserName,
            //    Email = x.Email,
            //    Phone = x.Phone
            //}).ToList();
            //throw new NotImplementedException();
        }

        public async Task<int> CreateInvitation_Business_User(VendorInvitationFormViewModel vendorInvitationFormViewModel)
        {
            //return await UserMgmtRepository.CreateUsersAsync();



            var result = await VendorInvitationFormRepository.CreateInvitation_Business_User(vendorInvitationFormViewModel);
            return Convert.ToInt32(result);

            //return result.Select(x => new UserMgmtViewModel()
            //{
            //    LoginId = x.LoginId,
            //    UserName = x.UserName,
            //    Email = x.Email,
            //    Phone = x.Phone
            //}).ToList();
            //throw new NotImplementedException();
        }

        //Task<List<VendorInvitationFormBussinessverticalViewModel>> IVendorInvitationFormService.GetAllBUssinessVerticalAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}


