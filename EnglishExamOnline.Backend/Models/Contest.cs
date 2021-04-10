using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.Backend.Models
{
    public class Contest
    {
        [Key]
        public int ContestId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ContestName { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }

        //Set foreign key
        [ForeignKey("ContestSchedule")]
        public int ContestScheduleId { get; set; }
        public virtual ContestSchedule ContestSchedule { get; set; }

        //Set foreign access to primary key
        public virtual ICollection<QuestionDetail> QuestionDetails { get; set; }

        public virtual ICollection<ContestRegist> ContestRegists { get; set; }
    }
}
