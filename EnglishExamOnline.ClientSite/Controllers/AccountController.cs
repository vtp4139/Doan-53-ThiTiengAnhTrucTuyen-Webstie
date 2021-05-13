using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
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
        private readonly IResultClient _ResultClient;
        private readonly INotyfService _notyf;

        public AccountController(IUserClient UserClient, INotyfService notyf, IResultClient ResultClient)
        {
            _UserClient = UserClient;
            _notyf = notyf;
            _ResultClient = ResultClient;
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

        [Authorize]
        public ActionResult GetResults()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var resultList = _ResultClient.GetResults(userId).Result;

            return View(resultList);
        }

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(PasswordFormVm request)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            request.userId = userId;

            var result = await _UserClient.ChangePassword(request);
            if (result == 204)
            {
                _notyf.Error("Mật khẩu cũ bạn nhập vào không đúng!", 4);
                return RedirectToAction("Index");
            }
          
            _notyf.Success("Thay đổi mật khẩu thành công.", 4);
            return RedirectToAction("ChangePassword");
        }
    }
}
