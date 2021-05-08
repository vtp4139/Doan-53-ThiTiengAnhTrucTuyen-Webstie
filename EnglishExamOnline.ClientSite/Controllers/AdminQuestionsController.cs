using AspNetCoreHero.ToastNotification.Abstractions;
using EnglishExamOnline.ClientSite.Services;
using EnglishExamOnline.ClientSite.Services.Interfaces;
using EnglishExamOnline.Shared;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    [RedirectingAction]
    public class AdminQuestionsController : Controller
    {
        private readonly IQuestionClient _questionApiClient;
        private readonly INotyfService _notyf;

        public AdminQuestionsController(IQuestionClient questionApiClient, INotyfService notyf)
        {
            _questionApiClient = questionApiClient;
            _notyf = notyf;
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
            _notyf.Success("Thêm câu hỏi mới thành công!", 4);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Detail(int id)
        {
            var quest = await _questionApiClient.GetQuestion(id);
            if (quest == null)
            {
                return Content("Item not found");
            }
            return View(quest);
        }

        public async Task<ActionResult> EditAsync(int id)
        {
            var quest = await _questionApiClient.GetQuestion(id);
            if (quest == null)
            {
                return Content("Item not found");
            }
            return View(quest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(QuestionVm question)
        {
            if(question == null)
                return Content("Item not found");

            QuestionFormVm request = new QuestionFormVm();
            request.QuestionInfo = question.QuestionInfo;
            request.AnswerA = question.AnswerA;
            request.AnswerB = question.AnswerB;
            request.AnswerC = question.AnswerC;
            request.AnswerD = question.AnswerD;
            request.CorrectAnswer = question.CorrectAnswer;

            await _questionApiClient.PutQuestion(question.QuestionId, request);
            _notyf.Success("Cập nhật câu hỏi thành công!", 4);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> DeleteAsync(int id)
        {
            if(id.Equals(null))
                 return Content("Item not found");
            int result = await _questionApiClient.DeleteQuestion(id);

            if(result == 200)
            {
                _notyf.Success("Xóa câu hỏi thành công!", 4);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
