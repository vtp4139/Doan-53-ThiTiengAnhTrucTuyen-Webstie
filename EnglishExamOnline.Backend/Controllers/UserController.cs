using EnglishExamOnline.Backend.Data;
using EnglishExamOnline.Backend.Models;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PasswordVerificationResult = Microsoft.AspNet.Identity.PasswordVerificationResult;

namespace EnglishExamOnline.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public UserController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
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

        [HttpPut("/change-password/")]
        public async Task<ActionResult<bool>> ChangePassword(string userId, string oldPassword, string newPassword)
        {
            var user = await _context.Users.FindAsync(userId);

            //Check old password is correct ?
            var result = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, oldPassword);

            //Change password
            if (result.ToString().Equals("Success"))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                var result_pass = await _userManager.ResetPasswordAsync(user, token, newPassword);

                return Ok(true);
            }

            return Ok(false);
        }
    }
}
