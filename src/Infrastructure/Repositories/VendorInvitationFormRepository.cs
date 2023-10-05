using Application.API.Repository;
using Dapper;
using Domain.Entities;
using Domain.ViewModel;
using Infrastructure.DbContext;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Linq;

namespace Infrastructure.Repositories
{

    public class VendorInvitationFormRepository : BaseRepository, IVendorInvitationFormRepository
    {
        public VendorInvitationFormRepository(ILogger<VendorInvitationFormRepository> logger, IDataAccess dataAccess) : base(logger, dataAccess)
        {
        }
        public async Task<List<VendorInvitationForm>> GetAllUsersAsync()

        {
            var result = await base.WithConnection(async c =>
            {
                return await c.QueryAsync<VendorInvitationForm>("Select [Supplier_Name] AS SupplierName,[Contact_Person] AS ContactPerson,[Supplier_Email] AS SupplierEmail,[Supplier_Mobile] AS SupplierMobile,[Project_Name] AS ProjectName," +
                    "[Initial_Submition_Deadline] AS InitialSubmitionDeadline,[GPD_Owner] AS GPDOwner,[Supplier_Guidelines] AS SupplierFormGuideline,[Email_Body] AS EmailBody,[Business_User_Name] AS BusinessUserName,[Business_User_Email] AS BusinessUserEmail from [GPA_VPQ_Vendor_Invitation]", commandType: CommandType.Text);
            });
            return result.ToList();
        }
        //Task<List<VendorInvitationFormViewModel>> IVendorInvitationFormRepository.GetAllBUssinessVerticalAsync()
        //{
        //    throw new NotImplementedException();
        //}
        public async Task<List<VendorInvitationForm>> GetAllBUssinessVerticalAsync()

        {
            var result = await base.WithConnection(async c =>
            {
                return await c.QueryAsync<VendorInvitationForm>("Select * from [GPA_VPQ_Business_Vertical_Master]", commandType: CommandType.Text);
            });
            return result.ToList();
        }
        public Task<List<VendorInvitationForm>> AddUsersAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<List<VendorInvitationForm>> CreateUsersAsync()
        {
            var result = await base.WithConnection(async c =>
            {
                return await c.QueryAsync<VendorInvitationForm>("Select [Supplier_Name] AS SupplierName,[Contact_Person] AS ContactPerson,[Supplier_Email] AS SupplierEmail,[Supplier_Mobile] AS SupplierMobile,[Project_Name] AS ProjectName," +
                   "[Initial_Submition_Deadline] AS InitialSubmitionDeadline,[GPD_Owner] AS GPDOwner,[Supplier_Guidelines] AS SupplierFormGuideline,[Email_Body] AS EmailBody,[Business_User_Name] AS BusinessUserName,[Business_User_Email] AS BusinessUserEmail from [GPA_VPQ_Vendor_Invitation]", commandType: CommandType.Text);
            });
            return result.ToList();

            //throw new NotImplementedException();
        }
        public async Task<int> CreateUsersAsync1(VendorInvitationFormViewModel vendorInvitationFormViewModel)
        {


            var result = await base.WithConnection(async c =>
            {
                //    return await c.ExecuteAsync("Insert into [GPA_VPQ_Vendor_Invitation] (VIN_Supplier_Name,VIN_Status,VIN_Type) Values ('" + vendorInvitationFormViewModel.SupplierName + "',0,0)", commandType: CommandType.Text);
                //});
                return await c.ExecuteAsync("Insert into [GPA_VPQ_Vendor_Invitation] (VIN_Supplier_Name,VIN_Status,VIN_Type,VIN_Contact_Person,VIN_Supplier_Email,VIN_Supplier_Mobile,VIN_Project_Name,VIN_GPD_Owner,VIN_Supplier_Guidelines,VIN_Initial_Submition_Deadline,VIN_Business_User_Name,VIN_Business_User_Email) Values ('" + vendorInvitationFormViewModel.SupplierName + "',2,0,'" + vendorInvitationFormViewModel.ContactPerson + "','" + vendorInvitationFormViewModel.SupplierEmail + "','" + vendorInvitationFormViewModel.SupplierMobile + "','" + vendorInvitationFormViewModel.ProjectName + "','" + vendorInvitationFormViewModel.GPDOwner + "','" + vendorInvitationFormViewModel.SupplierFormGuideline + "','" + vendorInvitationFormViewModel.InitialSubmitionDeadline + "','" + vendorInvitationFormViewModel.BusinessUserName + "','" + vendorInvitationFormViewModel.BusinessUserEmail + "')", commandType: CommandType.Text);
            });
            return result;
        }

        public async Task<int> CreateInvitation_Business_User(VendorInvitationFormViewModel vendorInvitationFormViewModel)
        {


            var result = await base.WithConnection(async c =>
            {
                //    return await c.ExecuteAsync("Insert into [GPA_VPQ_Vendor_Invitation] (VIN_Supplier_Name,VIN_Status,VIN_Type) Values ('" + vendorInvitationFormViewModel.SupplierName + "',0,0)", commandType: CommandType.Text);
                //});
                return await c.ExecuteAsync("Insert into [GPA_VPQ_Vendor_Invitation] (VIN_Supplier_Name,VIN_Status,VIN_Type,VIN_Contact_Person,VIN_Supplier_Email,VIN_Supplier_Mobile,VIN_Project_Name,VIN_GPD_Owner,VIN_Supplier_Guidelines,VIN_Initial_Submition_Deadline,VIN_Business_User_Name,VIN_Business_User_Email) Values ('" + vendorInvitationFormViewModel.SupplierName + "',1,1,'" + vendorInvitationFormViewModel.ContactPerson + "','" + vendorInvitationFormViewModel.SupplierEmail + "','" + vendorInvitationFormViewModel.SupplierMobile + "','" + vendorInvitationFormViewModel.ProjectName + "','" + vendorInvitationFormViewModel.GPDOwner + "','" + vendorInvitationFormViewModel.SupplierFormGuideline + "','" + vendorInvitationFormViewModel.InitialSubmitionDeadline + "','" + vendorInvitationFormViewModel.BusinessUserName + "','" + vendorInvitationFormViewModel.BusinessUserEmail + "')", commandType: CommandType.Text);
            });
            return result;
        }

        //Task<List<VendorInvitationFormViewModel>> IVendorInvitationFormRepository.GetAllBUssinessVerticalAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
    }

