using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost("find-user")]
        public IActionResult Find(string find)
        {
            if (find == null)            
                return PartialView("Find", _userApiClient.GetUsers().Result);           
            return PartialView("Find", _userApiClient.FindUsers(find).Result);
        }

        public async Task<ActionResult> ChangeStatusUser(string UserId, int index)
        {
            if (index == 1)
            {
                await _userApiClient.UnLockUser(UserId);
                _notyf.Warning("Đã cập nhật trạng thái mở khóa tài khoản", 4);
                return RedirectToAction("Index");
            }
            await _userApiClient.LockUser(UserId);
            _notyf.Warning("Đã cập nhật trạng thái khóa tài khoản", 4);
            return RedirectToAction("Index");
        }
    }
}
