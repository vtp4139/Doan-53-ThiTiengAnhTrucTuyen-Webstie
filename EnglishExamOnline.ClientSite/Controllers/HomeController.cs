using EnglishExamOnline.ClientSite.Models;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContestClient _contestApiClient;
        private readonly IUserClient _UserClient;

        public HomeController(ILogger<HomeController> logger, IContestClient contestApiClient, IUserClient UserClient)
        {
            _logger = logger;
            _contestApiClient = contestApiClient;
            _UserClient = UserClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            //Clear session in case user log out
            HttpContext.Session.Clear();
            if (User.Identity.IsAuthenticated)
            {
                //Get user id
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                bool check = _UserClient.CheckRoleAdmin(userId).Result;
                       
                //Check role is admin or not
                if (check)
                {
                    TempData["role"] = "admin"; //For view
                    HttpContext.Session.SetString("role", "admin"); //Secure controller
                }

                var contests = await _contestApiClient.GetContestExceptRegisted(userId);
                return View(contests);
            }
            else
            {
                var contests = await _contestApiClient.GetContests();
                return View(contests);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
