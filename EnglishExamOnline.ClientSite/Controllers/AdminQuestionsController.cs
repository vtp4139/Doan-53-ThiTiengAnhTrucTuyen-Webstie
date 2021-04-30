using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class AdminQuestionsController : Controller
    {
        private readonly IQuestionClient _questionApiClient;

        public AdminQuestionsController(IQuestionClient questionApiClient)
        {
            _questionApiClient = questionApiClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var questions = await _questionApiClient.GetQuestions();

            return View(questions);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(QuestionFormVm questionRequest)
        {
            if (questionRequest == null)
                return Content("Item not found");

            await _questionApiClient.PostQuestion(questionRequest);
            TempData["message"] = "Thêm câu hỏi mới thành công !";
            return RedirectToAction("Index");
        }

        //public ActionResult Edit(int id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    eTour tour = tourBLL.findTour(id);
        //    if (tour == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tour);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "tourID,tourName,departureDate,numberOfDay,startAddress,price,numSeat,emptySeat,tourType")] eTour tour)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        tourBLL.editTour(tour);
        //        TempData["Message"] = "Cập nhập tour thành công !";
        //        return RedirectToAction("Index");
        //    }
        //    return View(tour);
        //}
    }
}
