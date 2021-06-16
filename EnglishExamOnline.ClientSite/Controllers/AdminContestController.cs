using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    [RedirectingAction]
    public class AdminContestController : Controller
    {
        private readonly IContestClient _contestApiClient;
        private readonly IContestScheduleClient _contestScheduleApiClient;
        private readonly INotyfService _notyf;

        public AdminContestController(IContestClient contestApiClient, IContestScheduleClient contestScheduleApiClient, INotyfService notyf)
        {
            _contestApiClient = contestApiClient;
            _contestScheduleApiClient = contestScheduleApiClient;
            _notyf = notyf;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var contests = await _contestApiClient.GetContests();
            return View(contests);
        }

        [HttpPost("find-contest")]
        public IActionResult Find(string find)
        {
            if (find == null)
                return PartialView("Find", _contestApiClient.GetContests().Result);
            return PartialView("Find", _contestApiClient.FindContests(find).Result);
        }

        [HttpPost("/get-by-status")]
        public async Task<IActionResult> GetContestByStatus(int statusIndex)
        {
            if (statusIndex == 0)
            {
                var contestsList = await _contestApiClient.GetContests();
                return PartialView("Find", contestsList);
            }
            var contestsFilter = await _contestApiClient.GetContestByStatus(statusIndex);
            return PartialView("Find", contestsFilter);
        }

        public ActionResult Create()
        {
            //Set viewbag list schedule to load dropdown list
            IList<ContestScheduleVm> listSchedule = _contestScheduleApiClient.GetContestSchedulesAvailabe().Result;
            ViewBag.scheduleList = listSchedule;
            return View();
        }

        public async Task<ActionResult> Detail(int id)
        {
            var quest = await _contestApiClient.GetContest(id);
            if (quest == null)
            {
                return Content("Item not found");
            }
            return View(quest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(ContestFormVm request)
        {
            if (request == null)
                return Content("Item not found");

            await _contestApiClient.PostContest(request);
            _notyf.Success("Thêm cuộc thi mới thành công!", 4);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> EditAsync(int id)
        {
            var quest = await _contestApiClient.GetContest(id);
            if (quest == null)
            {
                return Content("Item not found");
            }
            return View(quest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(ContestVm contest)
        {
            if (contest == null)
                return Content("Item not found");

            ContestFormVm request = new ContestFormVm();
            request.ContestName = contest.ContestName;
            request.Description = contest.Description;

            await _contestApiClient.PutContest(contest.ContestId, request);
            _notyf.Success("Cập nhật cuộc thi thành công!", 4);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (id.Equals(null))
                return Content("Item not found");

            var result = await _contestApiClient.DeleteContest(id);

            if (result == 204)
            {
                _notyf.Error("Không thể xóa cuộc thi! Đã có thí sinh đăng ký cuộc thi này.", 4);
                return RedirectToAction("Index");
            }

            _notyf.Success("Xóa cuộc thi thành công!", 4);
            return RedirectToAction("Index");
        }
    }
}
