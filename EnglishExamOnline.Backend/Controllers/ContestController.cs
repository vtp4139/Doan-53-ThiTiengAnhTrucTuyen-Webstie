﻿using EnglishExamOnline.Backend.Data;
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
        //[Authorize]
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
        //[Authorize]
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
            var x = await _context.Contests.Include(c => c.ContestRegists).Include(c => c.ContestSchedule)
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
                StartTime = x.ContestSchedule.StartTime
            };

            return ContestVm;
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
            contest.CreatedDate = ContestCreateRequest.CreatedDate;
            contest.Status = ContestCreateRequest.Status;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ContestVm>> PostContest(ContestFormVm ContestCreateRequest)
        {
            var Contest = new Contest
            {
                ContestName = ContestCreateRequest.ContestName,
                Description = ContestCreateRequest.Description,
                CreatedDate = ContestCreateRequest.CreatedDate,
                Status = ContestCreateRequest.Status,
            };

            _context.Contests.Add(Contest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContest",
                new { id = Contest.ContestId },
                new ContestVm
                {
                    ContestName = ContestCreateRequest.ContestName,
                    Description = ContestCreateRequest.Description,
                    CreatedDate = ContestCreateRequest.CreatedDate,
                    Status = ContestCreateRequest.Status,
                });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContest(int id)
        {
            var Contest = await _context.Contests.FindAsync(id);
            if (Contest == null)
            {
                return NotFound();
            }

            _context.Contests.Remove(Contest);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
