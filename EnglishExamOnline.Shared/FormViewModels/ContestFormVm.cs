using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.FormViewModels
{
    public class ContestFormVm
    {
        [Required(ErrorMessage = "Enter contest name!")]
        [StringLength(500, ErrorMessage = "Not exceed 100 characters !")]
        public string ContestName { get; set; }

        [Required(ErrorMessage = "Enter description!")]
        [StringLength(500, ErrorMessage = "Not exceed 500 characters !")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }

        public virtual List<int> QuestionDetails { get; set; }
    }
}
