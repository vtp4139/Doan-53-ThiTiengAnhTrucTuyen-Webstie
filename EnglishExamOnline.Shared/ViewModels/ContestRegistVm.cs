using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class ContestRegistVm
    {

        public string UserName { get; set; }

        public string Email { get; set; }

        public int ContestRegistId { get; set; }

        public string ContestName { get; set; }

        public DateTime StartTime { get; set; }

        public int Length { get; set; }

        public DateTime RegistDate { get; set; }
    }
}
