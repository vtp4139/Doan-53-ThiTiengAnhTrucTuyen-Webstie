using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.Backend.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        //Set 1-1 relationship
        public int ContestRegistId { get; set; }
        public ContestRegist ContestRegist { get; set; }
    }
}
