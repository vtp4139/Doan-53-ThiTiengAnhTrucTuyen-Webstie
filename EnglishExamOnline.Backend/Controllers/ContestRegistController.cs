using EnglishExamOnline.Backend.Data;
using EnglishExamOnline.Backend.Models;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class ContestRegistController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContestRegistController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ContestRegistVm>> PostContestRegists(ContestRegistFormVm createRequest)
        {
            //Check user regis contests as same time
            var getContest = await _context.Contests
                .FirstOrDefaultAsync(ct => ct.ContestId == createRequest.ContestId);

            var testRegis = await _context.ContestRegists
                .Include(ct => ct.Contest)
                .Where(ct => ct.UserId == createRequest.UserId && ct.Contest.ContestScheduleId == getContest.ContestScheduleId && ct.Contest.State == 0)
                .ToListAsync();
         
            if (testRegis.Count > 0)
                return NoContent();

            var contestRegist = new ContestRegist
            {
                UserId = createRequest.UserId,
                ContestId = createRequest.ContestId,
                RegistDate = createRequest.RegistDate,
            };
            _context.ContestRegists.Add(contestRegist);

            //Get conteset regist info
            await _context.SaveChangesAsync();
            var x = await _context.ContestRegists
                .Include(c => c.Users)
                .Include(c => c.Contest)
                .ThenInclude(ct => ct.ContestSchedule)
                .FirstOrDefaultAsync(c => c.ContestRegistId == contestRegist.ContestRegistId);

            //Return contest regist to show on view confirm
            return new ContestRegistVm
            {
                UserId = x.UserId,
                UserName = x.Users.FullName,
                ContestRegistId = x.ContestRegistId,
                ContestName = x.Contest.ContestName,
                StartTime = x.Contest.ContestSchedule.StartTime,
                Length = x.Contest.ContestSchedule.Length,
                RegistDate = x.RegistDate,
            };
        }

        [HttpDelete]
        public async Task<ActionResult<ContestRegistVm>> DeleteContestRegist(ContestRegistFormVm createRequest)
        {
            var ContestRegist = await _context.ContestRegists.Where(x => x.ContestId == createRequest.ContestId && x.UserId == createRequest.UserId).FirstOrDefaultAsync(x => x.ContestId == createRequest.ContestId);
            if (ContestRegist == null)
            {
                return NotFound();
            }

            _context.ContestRegists.Remove(ContestRegist);
            await _context.SaveChangesAsync();
            return Ok(ContestRegist);
        }
    }
}
