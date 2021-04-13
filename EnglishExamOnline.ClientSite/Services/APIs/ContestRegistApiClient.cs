using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
    public class ContestRegistApiClient : IContestRegistClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContestRegistApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ContestRegistVm> PostContestRegist(ContestRegistFormVm createRequest)
        {
            //Send access token
            var client = _httpClientFactory.CreateClient();
            var accessToken = await _httpContextAccessor.HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);
            client.SetBearerToken(accessToken);

            //Send json with body
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(createRequest),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/ContestRegist", httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ContestRegistVm>();
            //return null;
        }
    }
}
