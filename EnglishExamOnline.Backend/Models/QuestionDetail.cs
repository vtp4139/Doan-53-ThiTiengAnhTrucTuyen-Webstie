using System.ComponentModel.DataAnnotations.Schema;

namespace EnglishExamOnline.Backend.Models
{
    public class QuestionDetail
    {
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }

        [ForeignKey("Contest")]
        public int ContestId { get; set; }
        public virtual Contest Contest { get; set; }

        public int Index { get; set; }
    }
}
