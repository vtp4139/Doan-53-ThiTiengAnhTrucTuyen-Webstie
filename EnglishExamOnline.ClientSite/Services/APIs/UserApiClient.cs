using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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

        public async Task<bool> CheckRoleAdmin(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/User/roleadmin/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<bool>();
        }
    }
}
