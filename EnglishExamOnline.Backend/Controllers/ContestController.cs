using EnglishExamOnline.Backend.Data;
using EnglishExamOnline.Backend.Models;
using EnglishExamOnline.Shared;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class ContestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContestController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ContestVm>>> GetContests()
        {
            return await _context.Contests.Include(c => c.ContestRegists)
                .Select(x => new ContestVm
                {
                    ContestId = x.ContestId,
                    ContestName = x.ContestName,
                    Description = x.Description,
                    CreatedDate = x.CreatedDate,
                    Status = x.Status,
                    CountRegists = x.ContestRegists.Count,
                    Length = x.ContestSchedule.Length,
                    StartTime = x.ContestSchedule.StartTime
                })
                .ToListAsync();
        }

        [HttpGet("Registed/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ContestVm>>> GetContestRegisted(string id)
        {
            //Get list of contest user registed
            return await _context.Contests
                .Include(c => c.ContestRegists)
                .Include(c => c.ContestSchedule)
                .Where(x => x.Status == true && x.ContestRegists.FirstOrDefault(ct => ct.UserId == id) != null)
                   .Select(x => new ContestVm
                   {
                       ContestId = x.ContestId,
                       ContestName = x.ContestName,
                       Description = x.Description,
                       CreatedDate = x.CreatedDate,
                       Status = x.Status,
                       CountRegists = x.ContestRegists.Count,
                       Length = x.ContestSchedule.Length,
                       StartTime = x.ContestSchedule.StartTime
                   }).ToListAsync(); ;
        }

        [HttpGet("ExceptRegisted/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ContestVm>>> GetContestExceptRegisted(string id)
        {
            var listCon = await _context.Contests
                .Include(c => c.ContestRegists)
                .Include(c => c.ContestSchedule)
                .ToListAsync();

            List<ContestVm> listItem = new List<ContestVm>();

            //Get contest except contest user registed
            foreach (var x in listCon)
            {
                //Check contest has user registed 
                if (x.Status == true && x.ContestRegists.FirstOrDefault(x => x.UserId == id) != null)
                    continue;

                ContestVm newCon = new ContestVm();
                newCon.ContestId = x.ContestId;
                newCon.ContestName = x.ContestName;
                newCon.Description = x.Description;
                newCon.CreatedDate = x.CreatedDate;
                newCon.Status = x.Status;
                newCon.CountRegists = x.ContestRegists.Count;
                newCon.Length = x.ContestSchedule.Length;
                newCon.StartTime = x.ContestSchedule.StartTime;

                listItem.Add(newCon);
            }
            return listItem;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ContestVm>> GetContest(int id)
        {
            //Include schedule and regist
            var x = await _context.Contests
                .Include(c => c.ContestRegists)
                .Include(c => c.ContestSchedule)
                .Include(c => c.QuestionDetails)
                .ThenInclude(c => c.Question)
                .FirstOrDefaultAsync(x => x.ContestId == id);

            if (x == null)
            {
                return NotFound();
            }

            var ContestVm = new ContestVm
            {
                ContestId = x.ContestId,
                ContestName = x.ContestName,
                Description = x.Description,
                CreatedDate = x.CreatedDate,
                Status = x.Status,
                CountRegists = x.ContestRegists.Count,
                Length = x.ContestSchedule.Length,
                StartTime = x.ContestSchedule.StartTime,
                ListQuestion = new List<QuestionVm>()
            };

            //Get the list of question contest has
            foreach (var item in x.QuestionDetails)
            {
                QuestionVm newItem = new QuestionVm();

                newItem.QuestionId = item.QuestionId;
                newItem.QuestionInfo = item.Question.QuestionInfo;
                newItem.AnswerA = item.Question.AnswerA;
                newItem.AnswerB = item.Question.AnswerB;
                newItem.AnswerC = item.Question.AnswerC;
                newItem.AnswerD = item.Question.AnswerD;
                newItem.CorrectAnswer = item.Question.CorrectAnswer;

                ContestVm.ListQuestion.Add(newItem);
            }

            return Ok(ContestVm);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutContest(int id, ContestFormVm ContestCreateRequest)
        {
            var contest = await _context.Contests.FindAsync(id);

            if (contest == null)
            {
                return NotFound();
            }

            contest.ContestName = ContestCreateRequest.ContestName;
            contest.Description = ContestCreateRequest.Description;
            contest.ContestScheduleId = ContestCreateRequest.ContestScheduleId;

            await _context.SaveChangesAsync();

            return Ok(new ContestVm
            {
                ContestId = contest.ContestId,
                ContestName = contest.ContestName,
                Description = contest.Description,
                CreatedDate = contest.CreatedDate,
                Status = contest.Status,
            });
        }

        [HttpPost]
        public async Task<ActionResult<ContestVm>> PostContest(ContestFormVm ContestCreateRequest)
        {
            var Contest = new Contest
            {
                ContestName = ContestCreateRequest.ContestName,
                Description = ContestCreateRequest.Description,
                CreatedDate = DateTime.Now,
                Status = true,
                ContestScheduleId = ContestCreateRequest.ContestScheduleId,
            };

            _context.Contests.Add(Contest);
            await _context.SaveChangesAsync();

            //Random question
            var questList = _context.Questions.ToListAsync();
            Random r = new Random();
            List<int> listRand = new List<int>();

            //List random without duplicate. Random 10 questions
            while (listRand.Count < 10)
            {
                int indexRand = r.Next(questList.Result.Count() - 1);

                if (listRand.Contains(indexRand))
                    continue;
                else listRand.Add(indexRand);
            }

            int i = 1;
            //Get info of question to save question detail
            foreach (int index in listRand)
            {
                Question q = questList.Result.ElementAt(index);
                if (q != null)
                {
                    QuestionDetail x = new QuestionDetail();
                    x.ContestId = Contest.ContestId;
                    x.QuestionId = q.QuestionId;
                    x.Index = i;
                    _context.QuestionDetails.Add(x);
                    await _context.SaveChangesAsync();
                    i++;
                }
            }

            return Ok(new ContestVm
            {
                ContestId = Contest.ContestId,
                ContestName = Contest.ContestName,
                Description = Contest.Description,
                CreatedDate = Contest.CreatedDate,
                Status = Contest.Status,
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContest(int id)
        {
            var Contest = await _context.Contests.Include(c => c.ContestRegists).FirstOrDefaultAsync(x => x.ContestId == id);
            if (Contest == null)
                return NotFound();
            if (Contest.ContestRegists.Count > 0)
                return NoContent();

            _context.Contests.Remove(Contest);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
