using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class ContestRegistController : Controller
    {
        private readonly IContestRegistClient _contestRegistApiClient;
        private readonly IConfiguration _configuration;

        public ContestRegistController(IContestRegistClient contestRegistApiClient, IConfiguration configuration)
        {
            _contestRegistApiClient = contestRegistApiClient;
            _configuration = configuration;
        }
      
        public IActionResult PostRegist(int id)
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction(actionName: "SignIn", controllerName: "Account");

            ContestRegistFormVm x = new ContestRegistFormVm();
            x.ContestId = id;
            x.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            x.RegistDate = DateTime.Now;

            return View(_contestRegistApiClient.PostContestRegist(x).Result);
        }
    }
}
