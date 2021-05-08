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
            //Set viewbag list schedule to load dropdown list
            IList<ContestScheduleVm> listSchedule = _contestScheduleApiClient.GetContestSchedulesAvailabe().Result;
            ViewBag.scheduleList = listSchedule;

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
            request.ContestScheduleId = contest.ContestScheduleId;

            await _contestApiClient.PutContest(contest.ContestId, request);
            _notyf.Success("Cập nhật cuộc thi thành công!", 4);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (id.Equals(null))
                return Content("Item not found");
            await _contestApiClient.DeleteContest(id);
            _notyf.Success("Xóa cuộc thi thành công!", 4);
            return RedirectToAction("Index");
        }
    }
}
