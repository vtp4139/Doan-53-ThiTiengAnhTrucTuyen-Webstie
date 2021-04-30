using System.ComponentModel.DataAnnotations;


namespace EnglishExamOnline.Shared
{
    public class QuestionFormVm
    {
        [Display(Name = "Nội dung câu hỏi")]
        [Required(ErrorMessage = "Enter question info!")]
        [StringLength(500, ErrorMessage = "Not exceed 500 characters !")]
        public string QuestionInfo { get; set; }

        [Display(Name = "Đáp án A")]
        [Required(ErrorMessage = "Enter answer A!")]
        [StringLength(500, ErrorMessage = "Not exceed 100 characters !")]
        public string AnswerA { get; set; }

        [Display(Name = "Đáp án B")]
        [Required(ErrorMessage = "Enter answer B!")]
        [StringLength(500, ErrorMessage = "Not exceed 100 characters !")]
        public string AnswerB { get; set; }

        [Display(Name = "Đáp án C")]
        [Required(ErrorMessage = "Enter answer C!")]
        [StringLength(500, ErrorMessage = "Not exceed 100 characters !")]
        public string AnswerC { get; set; }

        [Display(Name = "Đáp án D")]
        [Required(ErrorMessage = "Enter answer D!")]
        [StringLength(500, ErrorMessage = "Not exceed 100 characters !")]
        public string AnswerD { get; set; }

        [Display(Name = "Đáp án đúng")]
        [Required(ErrorMessage = "Enter correct answer!")]
        [StringLength(500, ErrorMessage = "Not exceed 100 characters !")]
        public string CorrectAnswer { get; set; }
    }
}
