using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.APIs
{
    public class UserApiClient : IUserClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ISendToken _request;

        public UserApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, ISendToken request)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _request = request;
        }

        public async Task<IList<UserVm>> GetUsers()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/User");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<UserVm>>();
        }

        public async Task<bool> CheckRoleAdmin(string id)
        {
            var client = _request.SendAccessToken().Result;
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/User/roleadmin/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<UserVm> GetUser(string id)
        {
            var client = _request.SendAccessToken().Result;
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/User/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<UserVm>();
        }

        public async Task<UserVm> PutUser(UserVm user)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(user),
                Encoding.UTF8, "application/json");
            var response = await client.PutAsync(_configuration["BackendUrl:Default"] + "/api/User/", httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<UserVm>();
        }

        public async Task<int> ChangePassword(PasswordFormVm request)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(request),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/User/change-password", httpContent);

            response.EnsureSuccessStatusCode();
            return (int)response.StatusCode;
        }
    }
}
