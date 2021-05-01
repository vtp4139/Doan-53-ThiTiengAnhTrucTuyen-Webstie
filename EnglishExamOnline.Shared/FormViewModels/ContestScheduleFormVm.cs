using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.FormViewModels
{
    public class ContestScheduleFormVm
    {
        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public int Length { get; set; }
    }
}
