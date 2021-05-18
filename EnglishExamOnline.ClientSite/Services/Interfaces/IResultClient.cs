using EnglishExamOnline.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IResultClient
    {
        Task<ResultVm> PostResult(List<string> listAnswer, string userId);

        Task<IList<ResultVm>> GetResults(string id);
    }
}
