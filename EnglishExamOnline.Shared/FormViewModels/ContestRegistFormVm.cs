using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.FormViewModels
{
    public class ContestRegistFormVm
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int ContestId { get; set; }

        public DateTime RegistDate { get; set; }
      
        public virtual List<int> Results { get; set; }
    }
}
