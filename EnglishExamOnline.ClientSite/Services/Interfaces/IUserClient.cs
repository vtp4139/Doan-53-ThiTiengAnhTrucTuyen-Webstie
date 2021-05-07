using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IUserClient
    {
        Task<bool> CheckRoleAdmin(string id);
    }
}
