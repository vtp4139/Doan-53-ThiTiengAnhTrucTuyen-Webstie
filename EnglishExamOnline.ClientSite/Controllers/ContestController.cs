using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class ContestController : Controller
    {
        private readonly IContestClient _contestApiClient;
        private readonly IResultClient _resultApiClient;
        private readonly IConfiguration _configuration;

        public ContestController(IContestClient contestApiClient, IResultClient resultApiClient, IConfiguration configuration)
        {
            _contestApiClient = contestApiClient;
            _configuration = configuration;
            _resultApiClient = resultApiClient;
        }

        public async Task<IActionResult> Detail(int id)
        {
            var product = await _contestApiClient.GetContest(id);
            
            return View(product);
        }

        [Authorize]
        public async Task<IActionResult> DetailRegisted(int id)
        {
            var product = await _contestApiClient.GetContest(id);

            return View(product);
        }

        [Authorize]
        public async Task<IActionResult> DetailContesting(int id)
        {
            var product = await _contestApiClient.GetContest(id);

            return View(product);
        }

        [Authorize]
        [HttpGet("/questions")]
        public async Task<ActionResult> LoadQuestions(int id)
        {
            var quest = await _contestApiClient.GetContest(id);
            if (quest == null)
            {
                return Content("Item not found");
            }
            return PartialView("LoadQuestions", quest);
        }

        [Authorize]
        [HttpPost("/result")]
        public async Task<ActionResult> Result(List<string> listAnswer)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _resultApiClient.PostResult(listAnswer, userId);
            
            //Show result and choice of user
            ViewBag.ListAnswers = result.ListAnswers;

            return PartialView("Result", result);
        }
    }
}
