﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class ContestRegistVm
    {
        public int UserId { get; set; }

        public int ContestId { get; set; }

        public int ContestRegistId { get; set; }

        public DateTime RegistDate { get; set; }
    }
}
