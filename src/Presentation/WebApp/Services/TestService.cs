using Domain.Entities;
using Domain.ViewModel;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using WebApp.Services.Contracts;

namespace WebApp.Services
{

    public class TestService : ITestService
    {
        private readonly BackendAPIService backendAPI;
        private readonly ILogger<TestService> logger;

        public TestService(BackendAPIService backendAPI, ILogger<TestService> logger)
        {
            this.backendAPI = backendAPI;
            this.logger = logger;
        }

        public async Task<IEnumerable<TestViewModel>> GetAllUsers()
        {
            var response = await this.backendAPI.Client.GetAsync("api\\Test\\GetAllUsers");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(result) ? null : JsonConvert.DeserializeObject<List<TestViewModel>>(result);

        }


        public async Task<int> CreateUsersTest(TestViewModel TestViewModel)
        {
            //var myContent = JsonConvert.SerializeObject(userMgmtViewModel);
            //var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            //var byteContent = new ByteArrayContent(buffer);
            //byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //var response = await this.backendAPI.Client.PostAsync("api//UserMgmt//CreateUsers1", byteContent);
            //response.EnsureSuccessStatusCode();
            //var result = await response.Content.ReadAsStringAsync();
            //return string.IsNullOrEmpty(result) ? 0 : JsonConvert.DeserializeObject<int>(result);


            var userJson = JsonConvert.SerializeObject(TestViewModel);
            var requestContent = new StringContent(userJson, Encoding.UTF8, "application/json");
            var response = await this.backendAPI.Client.PostAsync("api\\Test\\CreateUsers1", requestContent);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(result) ? 0 : JsonConvert.DeserializeObject<int>(result);



            //var response = await this.backendAPI.Client.PostAsync("api\\UserMgmt\\CreateUsers1");
            //response.EnsureSuccessStatusCode();
            //var result = await response.Content.ReadAsStringAsync();
            //return 1
            //return string.IsNullOrEmpty(result) ? null : JsonConvert.DeserializeObject<List<UserMgmtViewModel>>(result);

        }
    }

    //public interface ITestServices
    //{
    //}
}
