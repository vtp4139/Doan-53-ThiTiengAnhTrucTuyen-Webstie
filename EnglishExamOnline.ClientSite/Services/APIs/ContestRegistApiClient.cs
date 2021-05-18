using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
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
        private readonly ISendToken _request;

        public ContestRegistApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, ISendToken request)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _request = request;
        }

        public async Task<ContestRegistVm> PostContestRegist(ContestRegistFormVm createRequest)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(createRequest),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/ContestRegist", httpContent);

            response.EnsureSuccessStatusCode();

            if ((int)response.StatusCode == 204)
                return null;

            return await response.Content.ReadFromJsonAsync<ContestRegistVm>();
        }

        public async Task<ContestRegistVm> DeleteContestRegist(ContestRegistFormVm createRequest)
        {
            var client = _request.SendAccessToken().Result;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(_configuration["BackendUrl:Default"] + "/api/ContestRegist"),
                Content = new StringContent(JsonConvert.SerializeObject(createRequest), Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ContestRegistVm>();
        }
    }
}
