using EnglishExamOnline.Backend.Data;
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
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<UserVm>>> GetUsers()
        {
            return await _context.Users
                .Select(x => new UserVm
                {
                    UserId = x.Id,
                    Email = x.Email,
                    Fullname = x.FullName,
                    PhoneNumber = x.PhoneNumber
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserVm>> GetUser(string id)
        {
            return await _context.Users
                .Select(x => new UserVm
                {
                    UserId = x.Id,
                    Email = x.Email,
                    Fullname = x.FullName,
                    PhoneNumber = x.PhoneNumber,
                    DateOfBirth = x.DateOfBirth,
                    Address = x.Address
                }).FirstOrDefaultAsync(x => x.UserId == id);
        }

        [HttpGet("roleadmin/{idUser}")]
        public bool CheckRoleAdmin(string idUser)
        {
            var result = (from u in _context.Users
                          join ur in _context.UserRoles on u.Id equals ur.UserId
                          join r in _context.Roles on ur.RoleId equals r.Id
                          where r.Name == "Admin" && u.Id == idUser
                          select u).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
