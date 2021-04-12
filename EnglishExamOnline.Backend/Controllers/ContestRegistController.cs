using EnglishExamOnline.Backend.Data;
using EnglishExamOnline.Backend.Models;
using EnglishExamOnline.Shared;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public async Task<ActionResult<ContestRegistVm>> PostQuest(ContestRegistFormVm createRequest)
        {
            var x = new ContestRegist
            {
                UserId = createRequest.UserId,
                ContestId = createRequest.ContestId,
                RegistDate = createRequest.RegistDate,
            };

            _context.ContestRegists.Add(x);
            await _context.SaveChangesAsync();

            return new ContestRegistVm
            {
                UserId = x.UserId,
                ContestId = x.ContestId,
                RegistDate = x.RegistDate,
            });
        }

    }
}
