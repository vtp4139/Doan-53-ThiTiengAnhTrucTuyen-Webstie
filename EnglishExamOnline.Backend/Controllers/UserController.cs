using EnglishExamOnline.Backend.Data;
using EnglishExamOnline.Backend.Models;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
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
                    LockEnd = x.LockoutEnd.ToString(),
                    PhoneNumber = x.PhoneNumber
                })
                .ToListAsync();
        }

        [HttpGet("find/{find}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<UserVm>>> FindUsers(string find)
        {
            return await _context.Users
                .Where(u => u.FullName.Contains(find) || u.Id.Contains(find))
                 .Select(x => new UserVm
                 {
                     UserId = x.Id,
                     Email = x.Email,
                     Fullname = x.FullName,
                     LockEnd = x.LockoutEnd.ToString(),
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

        [HttpPut]
        public async Task<ActionResult<UserVm>> PutUser(UserVm request)
        {
            var user = await _context.Users.FindAsync(request.UserId);

            if (user == null)
            {
                return NotFound();
            }

            user.FullName = request.Fullname;
            user.PhoneNumber = request.PhoneNumber;
            user.DateOfBirth = request.DateOfBirth;
            user.Address = request.Address;
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPost("change-password")]
        public async Task<ActionResult> ChangePassword(PasswordFormVm request)
        {
            var user = await _context.Users.FindAsync(request.userId);

            //Check old password is correct ?
            var result = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, request.oldPassword);

            //Change password
            if (result.ToString().Equals("Success"))
            {
                await _userManager.ChangePasswordAsync(user, request.oldPassword, request.newPassword);
                return Ok();
            }

            return NoContent();
        }

        [HttpPost("logout")]
        public async Task<ActionResult> Logout()
        {
            //await _signInManager.SignOutAsync();
            await HttpContext.SignOutAsync();
            return Ok();
        }

        [HttpPost("lock-user/{id}")]
        public async Task<ActionResult> LockUser(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var user = await  _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (user == null)
                return NotFound();

            user.LockoutEnd = DateTimeOffset.Parse(DateTime.Today.AddDays(365).ToString());
            _context.Update(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPost("unlock-user/{id}")]
        public async Task<ActionResult> UnlockUser(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var user = await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (user == null)
                return NotFound();

            user.LockoutEnd = null;
            _context.Update(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}
