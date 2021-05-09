using AspNetCoreHero.ToastNotification.Abstractions;
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
        private readonly INotyfService _notyf;

        public ContestRegistController(IContestRegistClient contestRegistApiClient, IConfiguration configuration, INotyfService notyf)
        {
            _contestRegistApiClient = contestRegistApiClient;
            _configuration = configuration;
            _notyf = notyf;
        }

        public IActionResult PostRegist(int id)
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction(actionName: "SignIn", controllerName: "Account");

            ContestRegistFormVm x = new ContestRegistFormVm();
            x.ContestId = id;
            x.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            x.RegistDate = DateTime.Now;

            var result = _contestRegistApiClient.PostContestRegist(x).Result;
            if (result == null)
            {
                _notyf.Error("Bạn đã có một cuộc thi khác trong thời gian này!", 4);
                return RedirectToAction(actionName: "Detail", controllerName: "Contest", new { id = id });
            }
            return View(result);
        }

        public IActionResult RemoveRegist(int id)
        {
            ContestRegistFormVm x = new ContestRegistFormVm();
            x.ContestId = id;
            x.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _contestRegistApiClient.DeleteContestRegist(x);
            return View();
        }
    }
}
