using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnglishExamOnline.Backend.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string QuestionInfo { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AnswerA { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AnswerB { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AnswerC { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AnswerD { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CorrectAnswer { get; set; }

        //Set foreign access to primary key
        public virtual ICollection<QuestionDetail> QuestionDetails { get; set; }
    }
}
