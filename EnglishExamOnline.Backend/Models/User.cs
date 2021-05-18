using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace EnglishExamOnline.Backend.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {
        }

        public User(string userName) : base(userName)
        {
        }

        [PersonalData]
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public virtual ICollection<ContestRegist> ContestRegists { get; set; }
    }
}
