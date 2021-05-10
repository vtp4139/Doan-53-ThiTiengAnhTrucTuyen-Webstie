using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class ContestController : Controller
    {
        private readonly IContestClient _contestApiClient;
        private readonly IConfiguration _configuration;

        public ContestController(IContestClient contestApiClient, IConfiguration configuration)
        {
            _contestApiClient = contestApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Detail(int id)
        {
            var product = await _contestApiClient.GetContest(id);
            
            return View(product);
        }

        public async Task<IActionResult> DetailRegisted(int id)
        {
            var product = await _contestApiClient.GetContest(id);

            return View(product);
        }

        public async Task<ActionResult> LoadQuestions(int id)
        {
            var quest = await _contestApiClient.GetContest(id);
            if (quest == null)
            {
                return Content("Item not found");
            }
            return View(quest);
        }

        [HttpPost("/result")]
        public async Task<ActionResult> Result(List<string> listAnswer)
        {
            //var quest = await _contestApiClient.GetContest(id);
            //if (quest == null)
            //{
            //    return Content("Item not found");
            //}
            return View();
        }

    }
}
