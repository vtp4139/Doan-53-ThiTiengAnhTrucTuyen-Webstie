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
    }
}
