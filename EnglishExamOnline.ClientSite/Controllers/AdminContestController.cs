using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
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
            IList<ContestScheduleVm> listSchedule = _contestScheduleApiClient.GetContestSchedule().Result;
            ViewBag.scheduleList = listSchedule;
            return View();
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
    }
}
