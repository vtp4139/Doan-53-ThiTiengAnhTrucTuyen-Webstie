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
        public async Task<IActionResult> Find(string find)
        {
            var getAll = await _userApiClient.GetUsers();
            if (find == null)
            {
                return PartialView("Find", getAll);
            }

            var contests = await _userApiClient.FindUsers(find);

            if (contests == null)
            {
                _notyf.Error("Không tìm thấy người dùng nào!", 4);
                return PartialView("Find", getAll);
            }
            return PartialView("Find", contests);
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
