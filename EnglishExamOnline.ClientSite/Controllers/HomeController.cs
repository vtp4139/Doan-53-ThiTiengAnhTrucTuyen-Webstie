using EnglishExamOnline.ClientSite.Models;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.ViewModels;
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
            await _contestApiClient.SetStatusContests();
            //Clear session in case user log out
            HttpContext.Session.Clear();
            if (User.Identity.IsAuthenticated)
            {
                //Get user id
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                bool check = _UserClient.CheckRoleAdmin(userId).Result;

                //Get fullname
                UserVm getUser = _UserClient.GetUser(userId).Result;
                HttpContext.Session.SetString("fullname", getUser.Fullname);

                //Check role is admin or not
                if (check)
                {
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

        public async Task<IActionResult> GetContests()
        {
            if (User.Identity.IsAuthenticated)
            {
                //Get user id
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var contests = await _contestApiClient.GetContestExceptRegisted(userId);
                return View(contests);
            }
            else
            {
                var contests = await _contestApiClient.GetContests();
                return View(contests);
            }
        }

        public async Task<IActionResult> GetEndContests()
        {
            var contests = await _contestApiClient.GetContests();
            return View(contests);
        }

        [HttpPost("find-contests")]
        public async Task<IActionResult> FindContests(string find)
        {
            var getAllcontests = await _contestApiClient.GetContests();
            if (find == null)
            {
                return PartialView("FindContests", getAllcontests);
            }

            var contests = await _contestApiClient.FindContests(find);

            if (contests == null)
            {
                return PartialView("FindContests", getAllcontests);
            }
            return PartialView("FindContests", contests);
        }

        [HttpPost("find-end-contests")]
        public async Task<IActionResult> FindEndContests(string find)
        {
            var getAllcontests = await _contestApiClient.GetContests();
            if (find == null)
            {
                return PartialView("FindEndContests", getAllcontests);
            }

            var contests = await _contestApiClient.FindContests(find);

            if (contests == null)
            {
                return PartialView("FindEndContests", getAllcontests);
            }
            return PartialView("FindEndContests", contests);
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
