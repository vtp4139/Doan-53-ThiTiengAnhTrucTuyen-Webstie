using System.ComponentModel.DataAnnotations;


namespace EnglishExamOnline.Shared
{
    public class QuestionCreateRequest
    {
        [Required]
        public string QuestionInfo { get; set; }
    }
}
