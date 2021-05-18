using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class OverviewVm
    {
        public int TotalContest { get; set; }

        public int TotalContestOpen { get; set; }

        public int TotalContestEnd { get; set; }

        public int TotalUser { get; set; }

        public int TotalQuestion { get; set; }
    }
}
