using EnglishExamOnline.Shared;
using EnglishExamOnline.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IQuestionClient
    {
        Task<IList<QuestionVm>> GetQuestions();

        Task<QuestionVm> GetQuestion(int id);

        Task<QuestionVm> PostQuestion(QuestionFormVm question);

        Task<QuestionVm> PutQuestion(int id, QuestionFormVm question);

        Task<QuestionVm> DeleteQuestion(int id);
    }
}
