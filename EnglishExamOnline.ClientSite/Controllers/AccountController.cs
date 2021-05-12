using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserClient _UserClient;
        private readonly INotyfService _notyf;

        public AccountController(IUserClient UserClient, INotyfService notyf)
        {
            _UserClient = UserClient;
            _notyf = notyf;
        }

        public IActionResult SignIn()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/" }, "oidc");
        }

        public new IActionResult SignOut()
        {
            return SignOut(new AuthenticationProperties { RedirectUri = "/" }, "Cookies", "oidc");
        }

        [Authorize]
        public ActionResult MyProfile()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _UserClient.GetUser(userId).Result;

            if (user == null)
                return NotFound();
            return View(user);
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserVm user)
        {
            var result = _UserClient.PutUser(user).Result;

            if (result == null)
                return NotFound();
            _notyf.Success("Cập nhật thông tin tài khoản thành công!", 4);
            return RedirectToAction("MyProfile");
        }
    }
}
