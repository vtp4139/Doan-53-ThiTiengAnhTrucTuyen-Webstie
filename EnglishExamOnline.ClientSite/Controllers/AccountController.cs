using EnglishExamOnline.ClientSite.Services.Interfaces;
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

        public AccountController(IUserClient UserClient)
        {
            _UserClient = UserClient;
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
    }
}
