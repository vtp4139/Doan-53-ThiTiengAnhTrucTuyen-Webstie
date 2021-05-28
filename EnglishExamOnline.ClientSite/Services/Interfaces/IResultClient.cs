using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IResultClient
    {
        Task<ResultVm> PostResult(ResultFormVm resultRequest);

        Task<IList<ResultVm>> GetResults(string id);
    }
}
