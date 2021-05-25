using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    [RedirectingAction]
    public class AdminContestScheduleController : Controller
    {
        private readonly IContestScheduleClient _contestScheduleApiClient;
        private readonly INotyfService _notyf;

        public AdminContestScheduleController(IContestScheduleClient contestScheduleApiClient, INotyfService notyf)
        {
            _contestScheduleApiClient = contestScheduleApiClient;
            _notyf = notyf;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var contestSchedule = await _contestScheduleApiClient.GetContestSchedule();

            return View(contestSchedule);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(ContestScheduleFormVm request)
        {
            if (request == null)
                return Content("Item not found");

            var result = await _contestScheduleApiClient.PostContestSchedule(request);
            if (result == null)
            {
                _notyf.Error("Đã có lịch thi vào thời gian này!", 4);
                return View();
            }

            _notyf.Success("Thêm lịch thi mới thành công!", 4);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> EditAsync(int id)
        {
            var x = await _contestScheduleApiClient.GetContestSchedule(id);
            if (x == null)
            {
                return Content("Item not found");
            }
            return View(x);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(ContestScheduleVm contestSchedule)
        {
            if (contestSchedule == null)
                return Content("Item not found");

            ContestScheduleFormVm request = new ContestScheduleFormVm();
            request.StartTime = contestSchedule.StartTime;
            request.Length = contestSchedule.Length;

            await _contestScheduleApiClient.PutContestSchedule(contestSchedule.ContestScheduleId, request);
            _notyf.Success("Cập nhật lịch thi thành công!", 4);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (id.Equals(null))
                return Content("Item not found");

            int result = await _contestScheduleApiClient.DeleteContestSchedule(id);

            if(result == 204)
            {
                _notyf.Error("Không thể xóa lịch thi khi có cuộc thi tổ chức vào thời gian này!", 4);
                return RedirectToAction("Index");
            }
            _notyf.Success("Xóa lịch thi thành công!", 4);
            return RedirectToAction("Index");
        }

    }
}
