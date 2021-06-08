using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using System.IO;
using iText.Html2pdf;

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
        public IActionResult Logout()
        {
            _UserClient.Logout();
            return RedirectToAction("Index", "Home");
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

            //Update fullname when update user
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserVm getUser = _UserClient.GetUser(userId).Result;
            HttpContext.Session.SetString("fullname", getUser.Fullname);

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
        public ActionResult ExportPDFResult(int id)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = _ResultClient.GetResult(id).Result;
            UserVm getUser = _UserClient.GetUser(userId).Result;

            string htmlString =
                "<h1>VPenglish - Score Report</h1>" +
                "Report number: " + result.ResultId + "<hr>" +
                "<h3>Contest information</h3>" +
                "<p>Name: " + result.ContestName + "</p>" +
                "<p>Test Date: " + result.StartTime + "</p><hr>" +
                "<h3>Candidate information</h3>" +
                "<p>Fullname: " + getUser.Fullname + "</p>" +
                "<p>Email: " + getUser.Email + "</p>" +
                "<p>Date of birth: " + getUser.DateOfBirth.ToString("dd/MM/yyyy") + "</p>" +
                "<p>Address: " + getUser.Address + "</p><hr><br>" +
                "<h2>Exam result</h2>" +
                "<p>Submission time: " + result.EndTime + "</p>" +
                "<b>Score: </b>" + "<h1>" + result.Point + "/100</h1>" +
                "<b>Number of correct: </b>" + "<h1>" + result.NumOfCorrect + "/50</h1><br><hr><br>" +
                "<p><i>The score report has been verified by VPenglish.</i></p>" +
                "<p><u>Contact us</u></p>" +
                "<p><b>Phone: </b>0981234765</p>" +
                "<p><b>Address: </b>12 Nguyen Van Bao, Ward 4, Go Vap district, Ho Chi Minh City</p>" +
                "<p><b>Website: </b>vpenglish.azurewebsites.net</p>";

            string fileName = "score-report-" + result.ResultId + ".pdf";
            using (MemoryStream stream = new MemoryStream())
            {
                HtmlConverter.ConvertToPdf(htmlString, stream);
                return File(stream.ToArray(), "application/pdf", fileName);
            }
        }

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
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
                return RedirectToAction("ChangePassword");
            }

            _notyf.Success("Thay đổi mật khẩu thành công.", 4);
            return RedirectToAction("ChangePassword");
        }
    }
}
