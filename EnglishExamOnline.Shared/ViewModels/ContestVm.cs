using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class ContestVm
    {
        public int ContestId { get; set; }

        public string ContestName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime StartTime { get; set; }

        public int CountRegists { get; set; }

        public int Length { get; set; }

        public bool Status { get; set; }

        public int ContestScheduleId { get; set; }

        public List<QuestionVm> ListQuestion { get; set; }


    }
}
