using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class ContestVm
    {
        public int ContestId { get; set; }

        [Display(Name = "Tên cuộc thi")]
        public string ContestName { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime StartTime { get; set; }

        public int CountRegists { get; set; }

        public int Length { get; set; }

        public int State { get; set; }


        [Display(Name = "Lịch thi")]
        public int ContestScheduleId { get; set; }

        public List<QuestionVm> ListQuestion { get; set; }
    }
}
