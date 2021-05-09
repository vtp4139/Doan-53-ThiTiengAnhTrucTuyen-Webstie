using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    [RedirectingAction]
    public class AdminUserController : Controller
    {
        private readonly IUserClient _userApiClient;
        private readonly INotyfService _notyf;

        public AdminUserController(IUserClient userApiClient, INotyfService notyf)
        {
            _userApiClient = userApiClient;
            _notyf = notyf;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var userList = await _userApiClient.GetUsers();

            return View(userList);
        }
    }
}
