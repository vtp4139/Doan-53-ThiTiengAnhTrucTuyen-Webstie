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
    public class QuestionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<QuestionVm>>> GetBrands()
        {
            return await _context.Questions
                .Select(x => new QuestionVm { QuestionId = x.QuestionId, QuestionInfo = x.QuestionInfo })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<QuestionVm>> GetBrand(int id)
        {
            var brand = await _context.Questions.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            var brandVm = new QuestionVm
            {
                QuestionId = brand.QuestionId,
                QuestionInfo = brand.QuestionInfo
            };

            return brandVm;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrand(int id, QuestionCreateRequest questCreateRequest)
        {
            var brand = await _context.Questions.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            brand.QuestionInfo = questCreateRequest.QuestionInfo;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<QuestionVm>> PostBrand(QuestionCreateRequest questCreateRequest)
        {
            var quest = new Question
            {
                QuestionInfo = questCreateRequest.QuestionInfo
            };

            _context.Questions.Add(quest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrand", new { id = quest.QuestionId }, new QuestionVm { QuestionId = quest.QuestionId, QuestionInfo = quest.QuestionInfo });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var brand = await _context.Questions.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            _context.Questions.Remove(brand);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
