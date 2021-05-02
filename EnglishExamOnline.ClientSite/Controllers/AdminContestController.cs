using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class AdminContestController : Controller
    {
        private readonly IContestClient _contestApiClient;
        private readonly INotyfService _notyf;

        public AdminContestController(IContestClient contestApiClient, INotyfService notyf)
        {
            _contestApiClient = contestApiClient;
            _notyf = notyf;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var contests = await _contestApiClient.GetContests();
            return View(contests);
        }
    }
}
