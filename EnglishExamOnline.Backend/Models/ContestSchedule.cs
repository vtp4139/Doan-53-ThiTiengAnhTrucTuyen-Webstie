using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.Backend.Models
{
    public class ContestSchedule
    {
        [Key]
        public int ContestScheduleId { get; set; }

        public DateTime StartTime { get; set; }

        public int Length { get; set; }

        //Set foreign access to primary key
        public virtual ICollection<Contest> Contests { get; set; }
    }
}
