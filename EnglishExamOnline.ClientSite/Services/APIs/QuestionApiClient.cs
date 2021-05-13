using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
    public class QuestionApiClient : IQuestionClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ISendToken _request;

        public QuestionApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, ISendToken request)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _request = request;
        }

        public async Task<IList<QuestionVm>> GetQuestions()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Questions");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<QuestionVm>>();
        }

        public async Task<QuestionVm> GetQuestion(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Questions/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<QuestionVm>();
        }

        public async Task<QuestionVm> PostQuestion(QuestionFormVm question)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(question),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/Questions", httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<QuestionVm>();
        }

        public async Task<QuestionVm> PutQuestion(int id, QuestionFormVm question)
        {
            var client = _request.SendAccessToken().Result;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(question),
                Encoding.UTF8, "application/json");
            var response = await client.PutAsync(_configuration["BackendUrl:Default"] + "/api/Questions/" + id, httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<QuestionVm>();
        }

        public async Task<int> DeleteQuestion(int id)
        {
            var client = _request.SendAccessToken().Result;

            var response = await client.DeleteAsync(_configuration["BackendUrl:Default"] + "/api/Questions/" + id);
            response.EnsureSuccessStatusCode();
            return (int)response.StatusCode;
        }
    }
}
