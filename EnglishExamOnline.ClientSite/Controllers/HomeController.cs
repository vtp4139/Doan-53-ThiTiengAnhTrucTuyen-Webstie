using EnglishExamOnline.ClientSite.Models;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContestClient _contestApiClient;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IContestClient contestApiClient, IConfiguration configuration)
        {
            _logger = logger;
            _contestApiClient = contestApiClient; 
            _configuration = configuration;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var contests = await _contestApiClient.GetContests();
           
            return View(contests);
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
