using EnglishExamOnline.Backend.Data;
using EnglishExamOnline.Backend.Models;
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
    public class ResultController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ResultVm>>> GetResults(string id)
        {
            return await _context.Results
                .Include(r => r.ContestRegist)
                .ThenInclude(cr => cr.Contest)
                .ThenInclude(c => c.ContestSchedule)
                .Where(r => r.ContestRegist.UserId == id)
                .Select(r => new ResultVm
                {
                    ResultId = r.ResultId,
                    Point = r.Point,
                    NumOfCorrect = r.NumOfCorrect,
                    EndTime = r.EndTime,
                    ContestName = r.ContestRegist.Contest.ContestName,
                    StartTime = r.ContestRegist.Contest.ContestSchedule.StartTime,
                })
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ResultVm>> PostResult(ResultFormVm resultRequest)
        {
            //Get contest regist by user id and contest schedule 
            var getContestRegist = await _context.ContestRegists
                .Include(ct => ct.Contest)
                .ThenInclude(c => c.ContestSchedule)
                .Where(ct => ct.Contest.State == ContestStateEnum.Contesting
                       && ct.UserId == resultRequest.userId)
                .FirstOrDefaultAsync();           

            if (getContestRegist == null)
                throw new NullReferenceException($"{nameof(resultRequest.userId)} not found");

            //Get contest by contest regist include contest id
            var getContest = await _context.Contests
                .Include(c => c.QuestionDetails)
                .ThenInclude(q => q.Question)
                .Where(c => c.ContestId == getContestRegist.ContestId)
                .FirstOrDefaultAsync();

            if (getContest == null)
                return NotFound();

            //Get list correct answer of list question
            List<string> listResult = new List<string>();
            foreach (var item in getContest.QuestionDetails)
            {
                listResult.Add(item.Question.CorrectAnswer);
            }

            //Compare two list and output count
            int countCorrect = 0;
            for (int i = 0; i < listResult.Count; i++)
            {
                if (resultRequest.listAnswer[i].Equals(listResult[i]))
                {
                    countCorrect++;
                }
            }

            //Add result
            var result = new Result
            {
                Point = countCorrect * 2,
                NumOfCorrect = countCorrect,
                EndTime = DateTime.Now,
                ContestRegistId = getContestRegist.ContestRegistId
            };
            _context.Results.Add(result);
            await _context.SaveChangesAsync();

            //Return a result on view
            ResultVm resultVm = new ResultVm();
            resultVm.Point = result.Point;
            resultVm.NumOfCorrect = result.NumOfCorrect;
            resultVm.EndTime = result.EndTime;
            resultVm.ListAnswers = resultRequest.listAnswer;

            foreach (var item in getContest.QuestionDetails)
            {
                QuestionVm newItem = new QuestionVm();

                newItem.QuestionId = item.QuestionId;
                newItem.QuestionInfo = item.Question.QuestionInfo;
                newItem.AnswerA = item.Question.AnswerA;
                newItem.AnswerB = item.Question.AnswerB;
                newItem.AnswerC = item.Question.AnswerC;
                newItem.AnswerD = item.Question.AnswerD;
                newItem.CorrectAnswer = item.Question.CorrectAnswer;

                resultVm.ListQuestion.Add(newItem);
            }

            return Ok(resultVm);
        }
    }
}
