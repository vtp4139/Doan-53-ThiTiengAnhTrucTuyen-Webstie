using EnglishExamOnline.Shared;
using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IContestClient
    {
        Task<IList<ContestVm>> GetContests();

        Task<IList<ContestVm>> GetContestRegisted(string id);

        Task<IList<ContestVm>> GetContestExceptRegisted(string id);

        Task<ContestVm> GetContest(int id);

        Task<ContestVm> PostContest(ContestFormVm contest);

        Task<ContestVm> PutContest(int id, ContestFormVm question);

        Task<int> DeleteContest(int id);
    }
}
