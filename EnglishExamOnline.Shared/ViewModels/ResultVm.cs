using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class ResultVm
    {
        public ResultVm()
        {
            ListQuestion = new List<QuestionVm>();
            ListAnswers = new List<string>();
        }

        public int ResultId { get; set; }
       
        public int Point { get; set; }

        public int NumOfCorrect { get; set; }

        public DateTime EndTime { get; set; }

        public string ContestName { get; set; }

        public DateTime StartTime { get; set; }

        public List<QuestionVm> ListQuestion { get; set; }

        public List<string> ListAnswers { get; set; }
    }
}
