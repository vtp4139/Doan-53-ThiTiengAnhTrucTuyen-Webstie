using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnglishExamOnline.Backend.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }

        public int Point { get; set; }

        public int NumOfCorrect { get; set; }

        public DateTime EndTime { get; set; }

        //Set 1-1 relationship
        public int ContestRegistId { get; set; }
        public ContestRegist ContestRegist { get; set; }
    }
}
