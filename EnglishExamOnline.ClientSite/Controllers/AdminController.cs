using EnglishExamOnline.ClientSite.Services;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    [RedirectingAction]
    public class AdminController : Controller
    {
        private readonly IContestClient _contestApiClient;
        private readonly IUserClient _userApiClient;
        private readonly IQuestionClient _questionApiClient;

        public AdminController(IContestClient contestApiClient, IUserClient userApiClient, IQuestionClient questionApiClient)
        {
            _contestApiClient = contestApiClient;
            _userApiClient = userApiClient;
            _questionApiClient = questionApiClient;
        }

        public IActionResult Index()
        {
            OverviewVm overview = new OverviewVm();
            overview.TotalContest = _contestApiClient.GetContests().Result.Count();
            overview.TotalContestOpen = _contestApiClient.GetContestByStatus(1).Result.Count();
            overview.TotalContestEnd = _contestApiClient.GetContestByStatus(-1).Result.Count();
            overview.TotalUser = _userApiClient.GetUsers().Result.Count;
            overview.TotalQuestion = _questionApiClient.GetQuestions().Result.Count;

            return View(overview);
        }
    }
}
