using EnglishExamOnline.Backend.Data;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    

    public class QuestionDetailController : Controller
    {
        private readonly ApplicationDbContext _context;
        public QuestionDetailController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<QuestionVm>>> GetQuestionByContest(int id)
        {
            return await _context.QuestionDetails.Include(qd => qd.Question).Where(q => q.ContestId == id)
                .Select(x => new QuestionVm
                {
                    QuestionId = x.QuestionId,
                    QuestionInfo = x.Question.QuestionInfo,
                    AnswerA = x.Question.AnswerA,
                    AnswerB = x.Question.AnswerB,
                    AnswerC = x.Question.AnswerC,
                    AnswerD = x.Question.AnswerD,
                    CorrectAnswer = x.Question.CorrectAnswer
                })
                .ToListAsync();
        }
    }
}
