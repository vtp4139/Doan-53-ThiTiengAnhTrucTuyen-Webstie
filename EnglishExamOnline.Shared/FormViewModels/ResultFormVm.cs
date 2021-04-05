using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.FormViewModels
{
    public class ResultFormVm
    {
        [Range(0, 500, ErrorMessage = "The value not exceed 500 points!")]
        public int Point { get; set; }

        [Range(0, 50, ErrorMessage = "The value not exceed 50!")]
        public int NumOfCorrect { get; set; }
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
