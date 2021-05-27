using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IContestClient
    {
        Task<IList<ContestVm>> GetContests();

        Task<IList<ContestVm>> FindContests(string find);

        Task<IList<ContestVm>> GetContestByStatus(int statusIndex);

        Task<IList<ContestVm>> GetContestRegisted(string id);

        Task<IList<ContestVm>> GetContestExceptRegisted(string id);

        Task<ContestVm> GetContest(int id);

        Task<ContestVm> PostContest(ContestFormVm contest);

        Task<ContestVm> PutContest(int id, ContestFormVm question);

        Task<int> DeleteContest(int id);

        Task<int> SetStatusContests();
    }
}
