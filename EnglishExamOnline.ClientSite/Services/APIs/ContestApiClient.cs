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
    public class ContestApiClient : IContestClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ContestApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }
     
        public async Task<IList<ContestVm>> GetContests()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Contest");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ContestVm>>();
        }

        public async Task<IList<ContestVm>> GetContestRegisted(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Contest/Registed/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ContestVm>>();
        }

        public async Task<IList<ContestVm>> GetContestExceptRegisted(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Contest/ExceptRegisted/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ContestVm>>();
        }

        public async Task<ContestVm> GetContest(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Contest/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ContestVm>();
        }
    }
}
