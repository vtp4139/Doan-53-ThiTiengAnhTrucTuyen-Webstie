using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
