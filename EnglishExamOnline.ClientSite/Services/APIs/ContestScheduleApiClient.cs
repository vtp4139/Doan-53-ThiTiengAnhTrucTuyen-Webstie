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
    public class ContestScheduleApiClient : IContestScheduleClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ISendToken _request;

        public ContestScheduleApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, ISendToken request)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _request = request;

        }
        public async Task<IList<ContestScheduleVm>> GetContestSchedule()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/ContestSchedule");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ContestScheduleVm>>();
        }

        public async Task<IList<ContestScheduleVm>> GetContestSchedulesAvailabe()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/ContestSchedule/getavailabe");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ContestScheduleVm>>();

        }

        public async Task<ContestScheduleVm> GetContestSchedule(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/ContestSchedule/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ContestScheduleVm>();
        }

        public async Task<ContestScheduleVm> PostContestSchedule(ContestScheduleFormVm contestSchedule)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(contestSchedule),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/ContestSchedule", httpContent);
            response.EnsureSuccessStatusCode();

            if ((int)response.StatusCode == 204)
                return null; 
            return await response.Content.ReadFromJsonAsync<ContestScheduleVm>();
        }

        public async Task<ContestScheduleVm> PutContestSchedule(int id, ContestScheduleFormVm request)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(request),
                Encoding.UTF8, "application/json");
            var response = await client.PutAsync(_configuration["BackendUrl:Default"] + "/api/ContestSchedule/" + id, httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ContestScheduleVm>();
        }

        public async Task<int> DeleteContestSchedule(int id)
        {
            var client = _request.SendAccessToken().Result;

            var response = await client.DeleteAsync(_configuration["BackendUrl:Default"] + "/api/ContestSchedule/" + id);
            response.EnsureSuccessStatusCode();
            return (int) response.StatusCode;
        }
    }
}
