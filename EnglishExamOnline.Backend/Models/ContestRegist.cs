using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.Backend.Models
{
    public class ContestRegist
    {
        [Key]
        public int ContestRegistId { get; set; }
        public DateTime RegistDate { get; set; }

        //Foreign key

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User Users { get; set; }

        [ForeignKey("Contest")]
        public int ContestId { get; set; }
        public virtual Contest Contest { get; set; }

        //Set 1-1 relationship
        public Result Result { get; set; }
    }
}
