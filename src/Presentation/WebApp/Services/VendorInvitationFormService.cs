using Domain.Entities;
using Domain.ViewModel;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using WebApp.Services.Contracts;
namespace WebApp.Services
{
   
    public class VendorInvitationFormService : IVendorInvitationFormService
    {
        private readonly BackendAPIService backendAPI;
        private readonly ILogger<VendorInvitationFormService> logger;

        public VendorInvitationFormService(BackendAPIService backendAPI, ILogger<VendorInvitationFormService> logger)
        {
            this.backendAPI = backendAPI;
            this.logger = logger;
        }

        public async Task<IEnumerable<VendorInvitationFormViewModel>> GetAllUsers()
        {
            var response = await this.backendAPI.Client.GetAsync("api\\VendorInvitationForm\\GetAllUsers");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(result) ? null : JsonConvert.DeserializeObject<List<VendorInvitationFormViewModel>>(result);

        }

        public async Task<int> CreateVendorInvitation(VendorInvitationFormViewModel vendorInvitationFormViewModel)
        {
            //var myContent = JsonConvert.SerializeObject(userMgmtViewModel);
            //var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            //var byteContent = new ByteArrayContent(buffer);
            //byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //var response = await this.backendAPI.Client.PostAsync("api//UserMgmt//CreateUsers1", byteContent);
            //response.EnsureSuccessStatusCode();
            //var result = await response.Content.ReadAsStringAsync();
            //return string.IsNullOrEmpty(result) ? 0 : JsonConvert.DeserializeObject<int>(result);


            var userJson = JsonConvert.SerializeObject(vendorInvitationFormViewModel);
            var requestContent = new StringContent(userJson, Encoding.UTF8, "application/json");
            var response = await this.backendAPI.Client.PostAsync("api\\VendorInvitationForm\\CreateVendorInvitation", requestContent);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(result) ? 0 : JsonConvert.DeserializeObject<int>(result);



            //var response = await this.backendAPI.Client.PostAsync("api\\UserMgmt\\CreateUsers1");
            //response.EnsureSuccessStatusCode();
            //var result = await response.Content.ReadAsStringAsync();
            //return 1
            //return string.IsNullOrEmpty(result) ? null : JsonConvert.DeserializeObject<List<UserMgmtViewModel>>(result);

        }
        public async Task<int> CreateInvitation_Business_User(VendorInvitationFormViewModel vendorInvitationFormViewModel)
        {
            
            var userJson = JsonConvert.SerializeObject(vendorInvitationFormViewModel);
            var requestContent = new StringContent(userJson, Encoding.UTF8, "application/json");
            var response = await this.backendAPI.Client.PostAsync("api\\VendorInvitationForm\\CreateInvitation_Business_User", requestContent);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(result) ? 0 : JsonConvert.DeserializeObject<int>(result);

        }

    }
}
