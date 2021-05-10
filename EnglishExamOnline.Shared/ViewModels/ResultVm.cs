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
        public int ResultId { get; set; }
       
        public int Point { get; set; }

        public int NumOfCorrect { get; set; }

        public DateTime EndTime { get; set; }
    }
}
