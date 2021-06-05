
using System.ComponentModel.DataAnnotations;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class QuestionVm
    {
        public int QuestionId { get; set; }

        [Display(Name = "Nội dung câu hỏi")]
        [Required(ErrorMessage = "Nhập nội dung câu hỏi!")]
        [StringLength(500, ErrorMessage = "Không được vượt qua 500 kí tự!")]
        public string QuestionInfo { get; set; }

        [Display(Name = "Đáp án A")]
        [Required(ErrorMessage = "Nhập đáp án A!")]
        [StringLength(500, ErrorMessage = "Không được vượt qua 500 kí tự!")]
        public string AnswerA { get; set; }

        [Display(Name = "Đáp án B")]
        [Required(ErrorMessage = "Nhập đáp án B!")]
        [StringLength(500, ErrorMessage = "Không được vượt qua 500 kí tự!")]
        public string AnswerB { get; set; }

        [Display(Name = "Đáp án C")]
        [Required(ErrorMessage = "Nhập đáp án C!")]
        [StringLength(500, ErrorMessage = "Không được vượt qua 500 kí tự!")]
        public string AnswerC { get; set; }

        [Display(Name = "Đáp án D")]
        [Required(ErrorMessage = "Nhập đáp án D!")]
        [StringLength(500, ErrorMessage = "Không được vượt qua 500 kí tự!")]
        public string AnswerD { get; set; }

        [Display(Name = "Đáp án đúng")]
        [StringLength(1)]
        public string CorrectAnswer { get; set; }
    }
}
