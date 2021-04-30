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
    public class QuestionApiClient : IQuestionClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public QuestionApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<IList<QuestionVm>> GetQuestions()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Questions");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<QuestionVm>>();
        }
    }
}
