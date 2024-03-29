﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.FormViewModels
{
    public class ContestFormVm
    {
        [Display(Name = "Tên cuộc thi")]
        [Required(ErrorMessage = "Enter contest name!")]
        [StringLength(500, ErrorMessage = "Not exceed 100 characters !")]
        public string ContestName { get; set; }

        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Enter description!")]
        [StringLength(500, ErrorMessage = "Not exceed 500 characters !")]
        public string Description { get; set; }

        [Display(Name = "Lịch thi")]
        [Required(ErrorMessage = "Choose schedule!")]
        public int ContestScheduleId { get; set; }
    }
}
