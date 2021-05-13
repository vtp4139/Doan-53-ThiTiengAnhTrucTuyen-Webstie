using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IUserClient
    {
        Task<IList<UserVm>> GetUsers();

        Task<bool> CheckRoleAdmin(string id);

        Task<UserVm> GetUser(string id);

        Task<UserVm> PutUser(UserVm request);

        Task<int> ChangePassword(PasswordFormVm request);
    }
}
