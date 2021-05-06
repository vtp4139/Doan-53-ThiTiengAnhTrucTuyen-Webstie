using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnglishExamOnline.Backend.Data;
using Microsoft.AspNetCore.Authorization;
using EnglishExamOnline.Shared;
using EnglishExamOnline.Backend.Models;
using EnglishExamOnline.Shared.ViewModels;

namespace EnglishExamOnline.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class QuestionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<QuestionVm>>> GetQuests()
        {
            return await _context.Questions
                .Select(x => new QuestionVm 
                { 
                    QuestionId = x.QuestionId, 
                    QuestionInfo = x.QuestionInfo,
                    AnswerA = x.AnswerA,
                    AnswerB = x.AnswerB,
                    AnswerC = x.AnswerC,
                    AnswerD= x.AnswerD,
                    CorrectAnswer = x.CorrectAnswer,
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<QuestionVm>> GetQuest(int id)
        {
            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            var questVm = new QuestionVm
            {
                QuestionId = question.QuestionId,
                QuestionInfo = question.QuestionInfo,
                AnswerA = question.AnswerA,
                AnswerB = question.AnswerB,
                AnswerC = question.AnswerC,
                AnswerD = question.AnswerD,
                CorrectAnswer = question.CorrectAnswer,
            };

            return questVm;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<QuestionVm>> PutQuest(int id, QuestionFormVm questCreateRequest)
        {
            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            question.QuestionInfo = questCreateRequest.QuestionInfo;
            question.AnswerA = questCreateRequest.AnswerA;
            question.AnswerB = questCreateRequest.AnswerB;
            question.AnswerC = questCreateRequest.AnswerC;
            question.AnswerD = questCreateRequest.AnswerD;
            question.CorrectAnswer = questCreateRequest.CorrectAnswer;

            await _context.SaveChangesAsync();

            return Ok(question);
        }

        [HttpPost]
        public async Task<ActionResult<QuestionVm>> PostQuest(QuestionFormVm questCreateRequest)
        {
            var question = new Question
            {
                QuestionInfo = questCreateRequest.QuestionInfo,
                AnswerA = questCreateRequest.AnswerA,
                AnswerB = questCreateRequest.AnswerB,
                AnswerC = questCreateRequest.AnswerC,
                AnswerD = questCreateRequest.AnswerD,
                CorrectAnswer = questCreateRequest.CorrectAnswer,
            };

            _context.Questions.Add(question);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuest", 
                new { id = question.QuestionId }, 
                new QuestionVm 
                { 
                    QuestionInfo = question.QuestionInfo,
                    AnswerA = question.AnswerA,
                    AnswerB = question.AnswerB,
                    AnswerC = question.AnswerC,
                    AnswerD = question.AnswerD,
                    CorrectAnswer = question.CorrectAnswer,
                });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteQuest(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
