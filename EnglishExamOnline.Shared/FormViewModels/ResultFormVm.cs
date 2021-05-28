using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnglishExamOnline.Shared.FormViewModels
{
    public class ResultFormVm
    {
        public ResultFormVm()
        {
            listAnswer = new List<string>();
        }

        [Required]
        public string userId { get; set; }
        [Required]
        public List<string> listAnswer { get; set; }
    }
}
