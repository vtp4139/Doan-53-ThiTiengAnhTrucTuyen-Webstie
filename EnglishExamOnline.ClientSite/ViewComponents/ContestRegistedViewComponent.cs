using EnglishExamOnline.ClientSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.ViewComponents
{
    public class ContestRegistedViewComponent : ViewComponent
    {
        private readonly IContestClient _contestApiClient;

        public ContestRegistedViewComponent(IContestClient contestApiClient)
        {
            _contestApiClient = contestApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var contest = await _contestApiClient.GetContestRegisted(id);

            return View(contest);
        }
    }
}
