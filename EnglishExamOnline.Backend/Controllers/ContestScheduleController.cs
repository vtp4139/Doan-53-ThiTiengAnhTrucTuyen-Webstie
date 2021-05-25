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
    public class ContestScheduleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContestScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ContestScheduleVm>>> GetContestSchedules()
        {
            return await _context.ContestSchedules
                .Select(x => new ContestScheduleVm
                {
                    ContestScheduleId = x.ContestScheduleId,
                    StartTime = x.StartTime,
                    Length = x.Length,
                })
                .OrderByDescending(x => x.StartTime)
                .ToListAsync();
        }

        [HttpGet("getavailabe")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ContestScheduleVm>>> GetContestSchedulesAvailabe()
        {
            return await _context.ContestSchedules
                .Select(x => new ContestScheduleVm
                {
                    ContestScheduleId = x.ContestScheduleId,
                    StartTime = x.StartTime,
                    Length = x.Length,
                })
                .Where(x => x.StartTime > DateTime.Now.AddDays(5) && x.StartTime < DateTime.Now.AddDays(30))
                .OrderByDescending(x => x.StartTime)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ContestScheduleVm>> GetContestSchedule(int id)
        {
            var contestSchedule = await _context.ContestSchedules.FindAsync(id);

            if (contestSchedule == null)
            {
                return NotFound();
            }

            var _contestScheduleVm = new ContestScheduleVm
            {
                ContestScheduleId = contestSchedule.ContestScheduleId,
                StartTime = contestSchedule.StartTime,
                Length = contestSchedule.Length,
            };

            return _contestScheduleVm;
        }

        [HttpPost]
        public async Task<ActionResult<ContestScheduleVm>> PostContestSchedule(ContestScheduleVm request)
        {
            var check = await _context.ContestSchedules.FirstOrDefaultAsync(cs => cs.StartTime == request.StartTime);

            if (check != null)
                return NoContent();

            var contestSchedule = new ContestSchedule
            {
                StartTime = request.StartTime,
                Length = request.Length,
            };

            _context.ContestSchedules.Add(contestSchedule);
            await _context.SaveChangesAsync();

            return Ok(contestSchedule);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ContestScheduleVm>> PutContestSchedule(int id, ContestScheduleFormVm request)
        {
            var contestSchedule = await _context.ContestSchedules.FindAsync(id);

            if (contestSchedule == null)
            {
                return NotFound();
            }

            contestSchedule.StartTime = request.StartTime;
            contestSchedule.Length = request.Length;
          
            await _context.SaveChangesAsync();

            return Ok(contestSchedule);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteContestSchedule(int id)
        {
            var request = await _context.ContestSchedules.Include(r => r.Contests).FirstOrDefaultAsync(x => x.ContestScheduleId == id);
            
            if (request == null)
                return NotFound();
            if (request.Contests.Count > 0)
                return NoContent();

            _context.ContestSchedules.Remove(request);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
