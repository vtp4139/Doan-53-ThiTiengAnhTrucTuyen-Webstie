using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnglishExamOnline.Backend.Data;
using Microsoft.AspNetCore.Authorization;
using EnglishExamOnline.Shared;
using EnglishExamOnline.Backend.Models;

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
                .Select(x => new QuestionVm { QuestionId = x.QuestionId, QuestionInfo = x.QuestionInfo })
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
                QuestionInfo = question.QuestionInfo
            };

            return questVm;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuest(int id, QuestionFormVm questCreateRequest)
        {
            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            question.QuestionInfo = questCreateRequest.QuestionInfo;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<QuestionVm>> PostQuest(QuestionFormVm questCreateRequest)
        {
            var question = new Question
            {
                QuestionInfo = questCreateRequest.QuestionInfo
            };

            _context.Questions.Add(question);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuest", new { id = question.QuestionId }, new QuestionVm { QuestionId = question.QuestionId, QuestionInfo = question.QuestionInfo });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuest(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
