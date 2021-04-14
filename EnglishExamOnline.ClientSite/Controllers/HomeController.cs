using EnglishExamOnline.ClientSite.Models;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContestClient _contestApiClient;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IContestClient contestApiClient, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _contestApiClient = contestApiClient; 
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> IndexAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                //Send access token when user login
                var client = _httpClientFactory.CreateClient();
                var accessToken = await _httpContextAccessor.HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);
                client.SetBearerToken(accessToken);

                //Get user id
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var contests = await _contestApiClient.GetContestExceptRegisted(userId);
                return View(contests);
            }
            else
            {
                var contests = await _contestApiClient.GetContests();
                return View(contests);
            }       
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
