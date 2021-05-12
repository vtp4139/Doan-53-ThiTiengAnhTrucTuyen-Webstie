using EnglishExamOnline.ClientSite.Services.Interfaces;
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
    public class ResultApiClient : IResultClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ISendToken _request;

        public ResultApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, ISendToken request)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _request = request;
        }

        public async Task<IList<ResultVm>> GetResults(string id)
        {
            var client = _request.SendAccessToken().Result;
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Result/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ResultVm>>();
        }
        public async Task<ResultVm> PostResult(List<string> listAnswer, string userId)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(listAnswer),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/Result/" + userId, httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ResultVm>();
        }
    }
}
