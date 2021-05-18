using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IContestRegistClient
    {
        Task<ContestRegistVm> PostContestRegist(ContestRegistFormVm createRequest);

        Task<ContestRegistVm> DeleteContestRegist(ContestRegistFormVm createRequest);
    }
}
