using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.APIs
{
    public class ContestApiClient : IContestClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ISendToken _request;

        public ContestApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, ISendToken request)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _request = request;
        }

        public async Task<IList<ContestVm>> GetContests()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Contest");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ContestVm>>();
        }

        public async Task<IList<ContestVm>> FindContests(string find)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Contest/find/" + find);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<IList<ContestVm>>();
        }

        public async Task<IList<ContestVm>> GetContestByStatus(int statusIndex)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Contest/get-by-status/" + statusIndex);
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

        public async Task<ContestVm> PostContest(ContestFormVm contest)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(contest),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/Contest", httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ContestVm>();
        }

        public async Task<ContestVm> PutContest(int id, ContestFormVm contest)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(contest),
                Encoding.UTF8, "application/json");
            var response = await client.PutAsync(_configuration["BackendUrl:Default"] + "/api/Contest/" + id, httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ContestVm>();
        }

        public async Task<int> DeleteContest(int id)
        {
            var client = _request.SendAccessToken().Result;

            var response = await client.DeleteAsync(_configuration["BackendUrl:Default"] + "/api/Contest/" + id);
            response.EnsureSuccessStatusCode();
            return (int)response.StatusCode;
        }
    }
}
