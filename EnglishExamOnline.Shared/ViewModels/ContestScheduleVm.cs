using System;
using System.ComponentModel.DataAnnotations;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class ContestScheduleVm
    {
        public int ContestScheduleId { get; set; }

        [Required]
        [Display(Name = "Lịch thi")]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "Thời lượng")]
        public int Length { get; set; }
    }
}
